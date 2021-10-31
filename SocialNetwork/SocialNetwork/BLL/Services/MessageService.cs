using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services
{
    public class MessageService
    {
        readonly IMessageRepository _messageRepository;
        readonly IUserRepository _userRepository;
        public MessageService()
        {
            _userRepository = new UserRepository();
            _messageRepository = new MessageRepository();
        }

        public IEnumerable<Message> GetIncomingMessagesByUserId(int recipientId)
        {
            var messages = new List<Message>();

            _messageRepository.FindByRecipientId(recipientId).ToList().ForEach(m =>
            {
                var senderUserEntity = _userRepository.FindById(m.SenderId);
                var recipientUserEntity = _userRepository.FindById(m.RecipientId);

                messages.Add(new Message(m.Id, m.Content, senderUserEntity.Email, recipientUserEntity.Email));
            });

            return messages;
        }

        public IEnumerable<Message> GetOutgoingMessagesByUserId(int senderId)
        {
            var messages = new List<Message>();

            _messageRepository.FindBySenderId(senderId).ToList().ForEach(m =>
            {
                var senderUserEntity = _userRepository.FindById(m.SenderId);
                var recipientUserEntity = _userRepository.FindById(m.RecipientId);

                messages.Add(new Message(m.Id, m.Content, senderUserEntity.Email, recipientUserEntity.Email));
            });

            return messages;
        }

        public void SendMessage(MessageSendingData messageSendingData)
        {
            if (String.IsNullOrEmpty(messageSendingData.Content))
                throw new ArgumentNullException();

            if (messageSendingData.Content.Length > 5000)
                throw new ArgumentOutOfRangeException();

            var findUserEntity = _userRepository.FindByEmail(messageSendingData.RecipientEmail);
            if (findUserEntity is null) throw new UserNotFoundException();

            var messageEntity = new MessageEntity
            {
                Content = messageSendingData.Content,
                SenderId = messageSendingData.SenderId,
                RecipientId = findUserEntity.Id
            };

            if (_messageRepository.Create(messageEntity) == 0)
                throw new Exception();
        }
    }
}

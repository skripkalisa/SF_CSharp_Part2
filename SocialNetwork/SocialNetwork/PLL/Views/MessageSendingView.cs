﻿using System;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class MessageSendingView
    {
        readonly UserService _userService;
        readonly MessageService _messageService;
        public MessageSendingView(MessageService messageService, UserService userService)
        {
            _messageService = messageService;
            _userService = userService;
        }

        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("Введите почтовый адрес получателя: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            Console.WriteLine("Введите сообщение (не больше 5000 символов): ");
            messageSendingData.Content = Console.ReadLine();

            messageSendingData.SenderId = user.Id;

            try
            {
                _messageService.SendMessage(messageSendingData);

                SuccessMessage.Show("Сообщение успешно отправлено!");

                user = _userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при отправке сообщения!");
            }

        }
    }
}

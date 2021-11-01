using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Linq;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        readonly UserService _userService;
        public UserMenuView(UserService userService)
        {
            _userService = userService;
        }

        public void Show(User user)
        {
            while(true)
            {
                Console.WriteLine("Входящие сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Исходящие сообщения: {0}", user.OutgoingMessages.Count());
                Console.WriteLine("Мои друзья: {0}", user.Friends.Count());

                Console.WriteLine("1 - Просмотреть входящие сообщения");
                Console.WriteLine("2 - Просмотреть исходящие сообщения");
                Console.WriteLine("3 - Просмотреть моих друзей");
                Console.WriteLine("4 - Написать сообщение");
                Console.WriteLine("5 - Добавить в друзья");
                Console.WriteLine("6 - Просмотреть информацию о моём профиле");
                Console.WriteLine("7 - Редактировать мой профиль");
                Console.WriteLine("8 - Выйти из профиля");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {

                            Program.UserIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }
                    case "2":
                        {
                            Program.UserOutgoingMessageView.Show(user.OutgoingMessages);
                            break;
                        }
                    case "3":
                        {
                            Program.UserFriendView.Show(user.Friends);
                            break;
                        }
                    case "4":
                        {
                            Program.MessageSendingView.Show(user);
                            user = _userService.FindById(user.Id);
                            break;
                        }
                    case "5":
                        {
                            Program.AddingFriendView.Show(user);
                            user = _userService.FindById(user.Id);
                            break;
                        }
                    case "6":
                        {
                            Program.UserInfoView.Show(user);
                            break;
                        }
                    case "7":
                        {
                            Program.UserDataUpdateView.Show(user);
                            user = _userService.FindById(user.Id);
                            break;
                        }





                }
            }
        }
    }
}

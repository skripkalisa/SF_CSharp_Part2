using System;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddingFriendView
    {
        readonly UserService _userService;
        public AddingFriendView(UserService userService)
        {
            _userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя которого хотите добавить в друзья: ");

                Console.WriteLine("user:");
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.Id);
                
                
                
                string email = Console.ReadLine();
                
                userAddingFriendData.FriendEmail = email;
                
                User friend  = _userService.FindByEmail(email);

                Console.WriteLine("friend:");
                Console.WriteLine(friend.FirstName);
                Console.WriteLine(friend.Id);
                
                userAddingFriendData.UserId = user.Id;

                _userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            
            catch(Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользователя в друзья!");
            }
 
        }
    }
}

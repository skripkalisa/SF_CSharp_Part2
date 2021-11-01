using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork
{
    class Program
    {
        static MessageService _messageService;
        static UserService _userService;
        private static MainView _mainView;
        public static RegistrationView RegistrationView;
        public static AuthenticationView AuthenticationView;
        public static UserMenuView UserMenuView;
        public static UserInfoView UserInfoView;
        public static UserDataUpdateView UserDataUpdateView;
        public static MessageSendingView MessageSendingView;
        public static UserIncomingMessageView UserIncomingMessageView;
        public static UserOutgoingMessageView UserOutgoingMessageView;
        public static AddingFriendView AddingFriendView;
        public static UserFriendView UserFriendView;

        static void Main(string[] args)
        {
            _userService = new UserService();
            _messageService = new MessageService();

            

            _mainView = new MainView();
            RegistrationView = new RegistrationView(_userService);
            AuthenticationView = new AuthenticationView(_userService);
            UserMenuView = new UserMenuView(_userService);
            UserInfoView = new UserInfoView();
            UserDataUpdateView = new UserDataUpdateView(_userService);
            MessageSendingView = new MessageSendingView(_messageService, _userService);
            UserIncomingMessageView = new UserIncomingMessageView();
            UserOutgoingMessageView = new UserOutgoingMessageView();
            AddingFriendView = new AddingFriendView(_userService);
            UserFriendView = new UserFriendView();

            while (true)
            {
                _mainView.Show();
            }
        }
    }
}

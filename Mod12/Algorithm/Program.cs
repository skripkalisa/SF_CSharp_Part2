using System;
using System.Collections.Generic;
using System.Threading;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = UserList();
            foreach(var user in users)
            {
                Console.WriteLine($"Hello, {user.Name}!");
                if (!user.IsPremium) ShowAds();
            }
        }

        private static List<User> UserList()
        {
            var userList = new List<User>();
            userList.Add(new User("admin", "John", true));
            userList.Add(new User("manager", "Jane", true));
            userList.Add(new User("visitor", "Jim", false));
            userList.Add(new User("buyer", "Joseph", false));
            userList.Add(new User("vipBuyer", "Jannet", true));
            userList.Add(new User("surfer", "Juan", false));
            return userList;
        }

        class User
		{
            public User(string login, string name, bool isPremium)
            {
                Login = login;
                Name = name;
                IsPremium = isPremium;
            }

            public string Login { get; set; }
			public string Name { get; set; }
			public bool IsPremium { get; set; }
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}
	}
}

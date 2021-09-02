# Skill Factory C# course || Алгоритмы

## Задание 12.1.5

Для следующей задачи составьте блок-схему и разработайте алгоритм её решения на C#:
Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

Класс пользователей:

```cs
class User
{
	public string Login { get; set; }
	public string Name { get; set; }
	public bool IsPremium { get; set; }
}
```

В качестве метода для показа рекламы вы можно использовать:

```cs
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
```

## Скриншот работы программы

![Скриншот](https://github.com/skripkalisa/SF_CSharp_Part2/blob/Mod12/Mod12/Mod12.png)

## Алгоритм

![Алгоритм](https://github.com/skripkalisa/SF_CSharp_Part2/blob/Mod12/Mod12/Algorithm.png)

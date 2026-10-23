// Урок 1. Задача 3: спроси имя и город, выведи две строки.
// Приветствие и "Город: ...". Реши сам, потом пришли на ревью.

Console.WriteLine("Привет, .NET");

Console.Write("Введите ваше имя: ");
var name = Console.ReadLine();

Console.Write("Введите ваш город: ");
var city = Console.ReadLine();

Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Город: {city}");
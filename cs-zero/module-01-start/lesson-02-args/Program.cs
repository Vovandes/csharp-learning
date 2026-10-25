namespace Lesson02;

internal class Program
{
    // int вместо void: возвращаем код завершения, 0 значит "успешно"
    private static int Main(string[] args)
    {
        Console.WriteLine($"Аргументов: {args.Length}");
        int i = 0;
        foreach (var arg in args)
        {
            Console.WriteLine($"Аргумент[{i++}]: {arg}");
        }

        Console.Write("Введи число для парса: ");
        double number = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"Удвоенное число  = : {number*number}");

        return 0;
    }
}
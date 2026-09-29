// ===== Классическая точка входа, как int main() в C++ =====

namespace Lesson01;   // пространство имён, как namespace в C++

internal class Program   // в C# любой код живёт внутри класса
{
    // Точка входа. Аналог C++: int main(int argc, char* argv[])
    // static: вызывается без объекта. args: аргументы командной строки.
    // Можно писать и void Main(), тогда код возврата будет 0.
    static int Main(string[] args)
    {        
        DoLearn1();
        return 0;    
    }

    static string FormatTool(int t, int d) => $"T{t:D2} D{d}";

    static void DoLearn1()
    {
        Console.Write("Part name: ");
        string? partName = Console.ReadLine() ?? "";

        int programNo = ReadInt("Program number (1-9999): ", 1, 9999);

        string offset;
        do
        {
            Console.Write("Work offset G5x (54-59): ");
            offset = Console.ReadLine() ?? "";
        }
        while (offset is not ("54" or "55" or "56" or "57" or "58" or "59"));

        int toolNumber = ReadInt("Tool T: (1-30): ", 1, 30); 
        int diameterCorrector = ReadInt("Offset D: (1-99): ", 1, 99);
        int spindleSpeed = ReadInt("Spindle speed (1000-12000): ", 1000, 12000);

        PrintProgramHeader(partName, programNo, offset, toolNumber, diameterCorrector, spindleSpeed);
        PrintProgramHeaderMyVersion(partName, programNo, offset, toolNumber, diameterCorrector, spindleSpeed);
    }

    static void PrintProgramHeader(string partName, int programNo, string offset, int toolNumber, int diameterCorrector, int spindleSpeed)
    {
        Console.WriteLine("");
        Console.WriteLine($"( {partName} )");
        Console.WriteLine($"O{programNo:D4}");
        Console.WriteLine($"G{offset}");
        Console.WriteLine(FormatTool(toolNumber, diameterCorrector));
        Console.WriteLine($"S{spindleSpeed} M03");
        Console.WriteLine("");
    }

    static void PrintProgramHeaderMyVersion(string partName, int programNo, string offset, int toolNumber, int diameterCorrector, int spindleSpeed)
    {
        Console.WriteLine("=== Start Program ===");
        Console.WriteLine($"( {partName.ToUpper()}.nc )");
        Console.WriteLine($"O{programNo:D4}");
        Console.WriteLine($"G{offset}");
        Console.WriteLine($"{FormatTool(toolNumber, diameterCorrector)} M6");
        Console.WriteLine($"S{spindleSpeed} M03");
        Console.WriteLine("=== End Program ===");
    }

    static int ReadInt(string prompt, int min, int max)
    {
        while (true)   // бесконечный цикл, выходим из него через return
        {
            Console.Write(prompt);
            string text = Console.ReadLine() ?? "";
            if (!int.TryParse(text, out int result))    // не число
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            else if (result < min || result > max)      // число, но вне диапазона
            {
                Console.WriteLine($"Out of range. Enter {min}..{max}.");
            }
            else
            {
                return result;   // всё хорошо, выходим из функции
            }
        }
    }
}
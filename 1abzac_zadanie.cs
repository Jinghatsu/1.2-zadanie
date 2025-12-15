using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Проверка наличия цифры в числе ===");
        
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("Введите цифру для поиска (0-9): ");
        int digit = int.Parse(Console.ReadLine());
        
        if (digit < 0 || digit > 9)
        {
            Console.WriteLine("Цифра должна быть от 0 до 9");
            return;
        }
        
        string numberStr = Math.Abs(number).ToString();
        
        bool found = false;
        foreach (char c in numberStr)
        {
            if (c.ToString() == digit.ToString())
            {
                found = true;
                break;
            }
        }
        
        Console.WriteLine($"Цифра {digit} {(found ? "входит" : "не входит")} в запись числа {number}");
    }
}
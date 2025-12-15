using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Разворот числа ===");
        
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        int reversedNumber = 0;
        bool isNegative = number < 0;
        int temp = Math.Abs(number);
        
        if (temp == 0)
        {
            reversedNumber = 0;
        }
        else
        {
            while (temp > 0)
            {
                int lastDigit = temp % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                temp /= 10;
            }
        }
        
        if (isNegative)
            reversedNumber = -reversedNumber;
        
        Console.WriteLine($"Исходное число: {number}");
        Console.WriteLine($"Число в обратном порядке: {reversedNumber}");
        
        Console.WriteLine("\nПроцесс разворота:");
        temp = Math.Abs(number);
        Console.Write("Цифры в обратном порядке: ");
        while (temp > 0)
        {
            Console.Write(temp % 10 + " ");
            temp /= 10;
        }
        if (number == 0) Console.Write("0");
        Console.WriteLine();
    }
}
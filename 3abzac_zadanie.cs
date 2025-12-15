using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Проверка на число Фибоначчи ===");
        
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 0)
        {
            Console.WriteLine($"Число {number} НЕ является числом Фибоначчи (все числа Фибоначчи >= 0)");
            return;
        }
        
        bool isFibonacci = false;

        if (number == 0 || number == 1)
        {
            isFibonacci = true;
        }
        else
        {
            int a = 0;  
            int b = 1; 
            int c = a + b; 
            
            while (c <= number)
            {
                if (c == number)
                {
                    isFibonacci = true;
                    break;
                }
                
                a = b;
                b = c;
                c = a + b;
            }
        }
        
        Console.WriteLine($"Число {number} {(isFibonacci ? "является" : "НЕ является")} числом Фибоначчи");

        if (isFibonacci && number > 0)
        {
            Console.Write("Последовательность Фибоначчи до этого числа: ");
            int a = 0, b = 1;
            Console.Write($"{a} {b}");
            
            while (true)
            {
                int next = a + b;
                if (next > number) break;
                Console.Write($" {next}");
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("\nПроверка через математическую формулу:");
        int squareCheck1 = 5 * number * number + 4;
        int squareCheck2 = 5 * number * number - 4;
        
        bool isPerfectSquare1 = IsPerfectSquare(squareCheck1);
        bool isPerfectSquare2 = IsPerfectSquare(squareCheck2);
        
        bool formulaCheck = isPerfectSquare1 || isPerfectSquare2;
        Console.WriteLine($"5*{number}² + 4 = {squareCheck1} - это {(isPerfectSquare1 ? "полный квадрат" : "не полный квадрат")}");
        Console.WriteLine($"5*{number}² - 4 = {squareCheck2} - это {(isPerfectSquare2 ? "полный квадрат" : "не полный квадрат")}");
        Console.WriteLine($"По формуле: число {(formulaCheck ? "является" : "НЕ является")} числом Фибоначчи");
    }
    
    static bool IsPerfectSquare(int x)
    {
        if (x < 0) return false;
        int sqrt = (int)Math.Sqrt(x);
        return sqrt * sqrt == x;
    }
}
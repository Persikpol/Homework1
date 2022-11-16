// Task 4

using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1ое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ое число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3ье число");
            int number3 = Convert.ToInt32(Console.ReadLine());
            PrintPower();
            
            void PrintPower() 
            {
                if (number1<number2)
                {
                    if (number2<number3)
                    {
                        Console.WriteLine("Max " + number3);
                    }
                    else
                    {
                        Console.WriteLine("Max " + number2);
                    }
                }
                else
                {
                    if (number1<number3)
                    {
                        Console.WriteLine("Max " + number3);
                    }
                    else
                    {
                        Console.WriteLine("Max " + number1);
                    }
                }
            }
        
         }
    }
}




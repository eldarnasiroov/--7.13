using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            try
            {
                uint numb = Convert.ToUInt32(Console.ReadLine());
                uint sum = 0;
                uint evenNumb = 0;
                uint oddNumb = 0;
                uint numbDivider = 0;
                for (uint i = 2; i < numb; i++)                    
                {
                    if (numb%i==0)
                    {
                        numbDivider++;
                        sum = sum + i;
                        Console.WriteLine($"Один из делителей числа {numb} это {i}.");
                    }                    
                }
                Console.WriteLine($"Сумма делителей числа {numb} равняется {sum}.");
                for (uint i = 2; i < numb; i++)
                {
                    if (i % 2 == 0 && numb % i == 0)
                    {                        
                        evenNumb += i;                                                                       
                    }                                        
                }
                for (uint i = 2; i < numb; i++)
                {
                    if(i % 2 != 0 && numb % i == 0)
                    {
                        oddNumb++;
                    }
                }
                    Console.WriteLine($"Сумма его четных делителей равна {evenNumb}.");
                Console.WriteLine($"Количество делителей числа {numb} равняется {numbDivider}.");
                Console.WriteLine($"Количество нечетных делителей числа {numb} равняется {oddNumb}.");
                Console.WriteLine($"Количество делителей числа {numb} равняется {numbDivider}, а количество четных делителей равняется {evenNumb}.");
            }
            catch 
            {
                Console.WriteLine("Ошибка! Было введено недопустимое значение");
            }
            Console.ReadKey();
            

        }
    }
}

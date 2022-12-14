using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа поиска наименьшего числа в последовательности чисел

            Console.WriteLine("Введите длину последовательности чисел");
            int lenght = int.Parse(Console.ReadLine());

            int i = 1;
            int maxValue = 2147483647;
            int number = 0;

            while (i <= lenght)
            {
                Console.WriteLine($"Введите {i}-е число последовательности");
                number = int.Parse(Console.ReadLine());
                i++;

                if (number < maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine($"{maxValue} - минимальное число в последовательности");
            Console.ReadLine();
        }
    }
}

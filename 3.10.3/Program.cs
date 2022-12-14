using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа проверяет введенное число на простоту

            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            bool check = true;
            int i = 2;
            int remains;

            while (check && (i <= number - 1))
            {
                remains = 0;
                remains = number % i;
                i++;

                if (remains == 0)
                {
                    Console.WriteLine($"Число {number} - не простое");
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine($"Число {number} - простое");
            }
            Console.ReadLine();
        }
    }
}

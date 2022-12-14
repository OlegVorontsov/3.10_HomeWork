using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._1_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа определяет введеннное число на четность

            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Число преобразовано в целочисленное: {number}");

            int check = number % 2;

            if (check == 0)
            {
                Console.WriteLine($"Число {number} - четное");
            }
            else
            {
                Console.WriteLine($"Число {number} - нечетное");
            }

            Console.ReadLine();
        }
    }
}

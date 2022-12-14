using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа считает сумму карт

            Console.WriteLine("Привет! Cколько у тебя карт?");
            int numberCarts = int.Parse(Console.ReadLine());

            Console.WriteLine("Какие у тебя карты?\n" +
                                "Валет = J\n" +
                                "Дама = Q\n" +
                                "Король = K\n" +
                                "Туз = T\n" +
                                "Цифра = номинал\n");
            int sum = 0;

            for (int i = 1; i <= numberCarts; i++)
            {
                Console.WriteLine($"Карта {i}: ");
                var temp = Console.ReadLine();

                switch (temp)
                {
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(temp);
                        break;
                }
            }

            Console.WriteLine($"Сумма твоих карт: {sum}");

            Console.ReadLine();
        }
    }
}

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
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Такой карты не бывает!");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"Сумма твоих карт: {sum}");

            Console.ReadLine();
        }
    }
}

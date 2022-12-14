using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа "Угадай число"

            Console.WriteLine("Введите целое число N\n" +
                              "Программа сгенерирует целое число от 0 до N\n" +
                              "Ваша задача угадать число!");
            int range = int.Parse(Console.ReadLine());

            Random r = new Random();
            int number = r.Next(0, range);

            Console.WriteLine("Программа загадала число. Попробуйте его угадать");

            int i = 1;
            while (true)
            {
                Console.WriteLine($"{i} - я попытка: ");
                string temp = Console.ReadLine();
                i++;

                if (int.TryParse(temp, out int tryNumber))
                {
                    if ((tryNumber < 0) || (tryNumber > range))
                    {
                        Console.WriteLine($"Число {tryNumber} находится вне диапазона");
                    }
                    else
                    {
                        if (tryNumber < number)
                        {
                            Console.WriteLine($"Число {tryNumber} меньше загаданного");
                        }
                        else if (tryNumber > number)
                        {
                            Console.WriteLine($"Число {tryNumber} больше загаданного");
                        }
                        else
                        {
                            Console.WriteLine($"Вы угадали число {tryNumber}!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Жаль, что вы не хотите играть. " +
                                      "Программа загадала: {0}", number);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

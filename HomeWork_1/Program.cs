using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*Упражнение 2.1 Тумаков глава 2*/
                Console.WriteLine("Упражнение 2.1 Написать программу , которая встречает пользователя по имени.\nEnter your name:");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name} UwU");
                Console.ReadKey();
            }
            {
                /*Упражнение 2.2 Тумаков глава 2*/
                Console.WriteLine("Упражнение 2.2 Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.");
                Console.WriteLine("Введите делимое число, а затем делитель");
                Console.WriteLine("Делимое:"); int delim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Делитель:"); int delit = Convert.ToInt32(Console.ReadLine());
                if (delit == 0)
                {
                    Console.WriteLine("Ошибка деления на НОЛЬ");
                }
                else
                {
                    Console.WriteLine($"Результат деления: {delim / delit}");
                }
                Console.ReadKey();
            }
            {
                /*Домашнее Задание 2.1 Тумаков глава 2*/
                Console.WriteLine("Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.");
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
                Console.WriteLine("Введите букву");
                char letter = Convert.ToChar(Console.ReadLine());
                int index = Array.IndexOf(alpha, letter);
                Console.WriteLine($"Ваша буква: {alpha[index + 1]}");
                Console.ReadKey();
            }
            {
                /*Домашнее задание 2.2 Тумаков глава 2*/
                Console.WriteLine("Домашнее задание 2.2 Тумаков глава 2 - найти корни квадратного уравнения \nВведите коэффиценты квадратного уравнения");
                Console.WriteLine("Введите значение а:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение c:");
                double c = Convert.ToDouble(Console.ReadLine());
                if (b * b - 4 * a * c < 0)
                {
                    Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
                }
                if (b * b - 4 * a * c == 0)
                {
                    double x0 = (-b / (2 * a));
                    Console.WriteLine("Дискриминант равен нулю. Корень равен " + x0 + ".");
                }
                if (b * b - 4 * a * c > 0)
                {
                    double x1 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    Console.WriteLine($"Первый корень равен {x1}, Второй корень равен {x2}.");
                }
                Console.ReadKey();
            }
        }
        
    }
}

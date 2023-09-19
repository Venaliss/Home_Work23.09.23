using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1*/
            Console.WriteLine("Задание 1\n Вывести тип данных и их границы");
            Console.WriteLine($"Bool - Maximal:True - Minimal:False");
            Console.WriteLine($"Byte - Maximal:{byte.MaxValue} - Minimal:{byte.MinValue}");
            Console.WriteLine($"SByte - Maximal:{sbyte.MaxValue} - Minimal:{sbyte.MinValue}");
            Console.WriteLine($"Short - Maximal:{short.MaxValue} - Minimal:{short.MinValue}");
            Console.WriteLine($"UShort - Maximal:{ushort.MaxValue} - Minimal:{ushort.MinValue}");
            Console.WriteLine($"Int - Maximal:{int.MaxValue} - Minimal:{int.MinValue}");
            Console.WriteLine($"UInt - Maximal:{uint.MaxValue} - Minimal:{uint.MinValue}");
            Console.WriteLine($"Long - Maximal:{long.MaxValue} - Minimal:{long.MinValue}");
            Console.WriteLine($"ULong - Maximal:{ulong.MaxValue} - Minimal:{ulong.MinValue}");
            Console.WriteLine($"Decimal - Maximal:{decimal.MaxValue} - Minimal:{decimal.MinValue}");
            Console.WriteLine($"Float - Maximal:{float.MaxValue} - Minimal:{float.MinValue}");
            Console.WriteLine($"Double - Maximal:{double.MaxValue} - Minimal:{double.MinValue}");
            Console.WriteLine($"Char - One symbol from Unicode");
            Console.WriteLine($"Int - Maximal:(-) - Minimal: (-)");
            Console.ReadKey();
            /*Задание 2*/
            Console.WriteLine("\nЗадание 2 Ввести данные в переменные и вывести их на экран\nAdd your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Where you from?");
            string city = Console.ReadLine();
            Console.WriteLine("How old are you?");
            byte year = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Add your PIN-code");
            ushort pin = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"\nYour info:\n\nName:{name}\nCity:{city}\nYears:{year}\nPIN-code:{pin}");
            Console.ReadKey();
            /*Задание 3*/
            Console.WriteLine("\n Задание 3\nВведите строку:\n");
            string s = Console.ReadLine();

            var chars = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
            var invertedCase = new string(chars.ToArray());

            Console.WriteLine($"Ваша строка: {invertedCase}");
            Console.ReadKey();
            /*Задание 4*/
            Console.WriteLine("\n Задание 4 \nВвести строку и подстроку и найти количество вхождений");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string understr = Console.ReadLine();
            int count = (str.Length - str.Replace(understr, "").Length) / understr.Length;
            Console.WriteLine($" Количество вхождений подстроки равно:{count}");
            Console.ReadKey();
            /*Задание 5*/
            Console.WriteLine("Задание 5 \n Определить сколько бутылок необходимо для поездки в отпуск");
            Console.WriteLine("Введите стоимость одной бутылки виски:"); float PriceViski = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free в %:"); float Sale = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:"); float PriceHoliday = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Количество необходимых бутылок для отпуска равна:{Convert.ToInt32(PriceHoliday / (PriceViski * (Sale * 0.01)))}");
            Console.ReadKey();
            /*Задание 6*/
            Console.WriteLine("Задание 6 Воспроизвести разговор Гарри и Дневника Реддла");
            Console.ReadLine();
            Console.WriteLine("Как вас зовут?");
            string magicer = Console.ReadLine();Console.WriteLine($"Здравствуйте, {magicer}");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Волшебство!!!!");
            Console.ReadKey();
        }

    }
}

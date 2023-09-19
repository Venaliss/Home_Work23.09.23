using System;
namespace HomeWork_2
{
    class Program
    {
        /*Упражнение 3.1*/
        enum bank_account1
        {
            actual = 120,
            saving = 360
        }
        /*Упражнение 3.2*/
        public struct bank_account2
        {
            public long number;
            public string type;
            public int balance;
            public void Print()
            {
                Console.WriteLine($"Your bank account info:\nNumber:{number}\nType:{type}\nBalance:{balance}");
            }
        }
        /*Домашнее задание 3.1*/
        enum VUZ
        {
            KGU,
            KAI,
            KHTI    
        }
        public struct Worker
        {
            public string name;
            public string VUZ;
            public void Print()
            {
                Console.WriteLine($"Name worker:{name}\nVUZ:{VUZ}");
            }
        }
        static void Main(string[] args)
        {
            /*Упражнение 3.1 Тумаков 3 глава*/
            Console.WriteLine("Упражнение 3.1 Тумаков 3 глава - Создать перечислимый тип с банковским текущим и сберегательным счетом, и вывести на экран\n");
            bank_account1 money = bank_account1.actual;
            Console.WriteLine("Bank account - {0}, Money - {1}.", money, (int)money);
            Console.ReadKey();
            /*Упражнение 3.2 Тумаков 3 глава*/
            Console.WriteLine("\nУпражнение 3.2 Тумаков 3 глава - Создать Структуру данных банковского счета(номер, тип, баланс) и вывести данные.\n");
            bank_account2 bank;
            bank.number = 220056788641235;
            bank.type = "Saving account";
            bank.balance = 7854621;
            bank.Print();
            Console.ReadKey();
            /**/
            Console.WriteLine("\nДомашнее задание 3.1 Тумаков глава 3 \nСоздать перечислимый тип ВУЗ и структуру данных Работник и вывести данные на экран\n");
            VUZ vuz = (VUZ)1;
            Worker work;
            work.name = "Valery Skvortsov";
            work.VUZ = Convert.ToString(vuz);
            work.Print();
            Console.ReadKey();
            
            
        } 
    }
}

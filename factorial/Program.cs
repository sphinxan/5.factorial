using System;
using System.Threading;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого нужно посчитать.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
                Console.WriteLine("Неверный ввод");
            else
            {
                string length = Convert.ToString(GetFactorial(number));
                int num = length.Length;

                int i = 0;
                do
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    DoFrame(length);
                    Thread.Sleep(150);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Thread.Sleep(150);
                    Console.Clear();
                    i++;
                } while (i < 100);
            }


          
        }
        static int GetFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * GetFactorial(number - 1);
        }
        public static void WriteBoxLine(int num, char beginSym, char indentSym, char endSym)
        {
            Console.Write(beginSym);
            for (int i = 0; i < num; i++)
                Console.Write(indentSym);
            Console.WriteLine(endSym);
        }

        static void DoFrame(string length)
        {
            WriteBoxLine(length.Length, '╔', '═', '╗');
            WriteBoxLine(length.Length, '║', ' ', '║');
            Console.WriteLine($"║{length}║");
            WriteBoxLine(length.Length, '║', ' ', '║');
            WriteBoxLine(length.Length, '╚', '═', '╝');
        }
    }
}

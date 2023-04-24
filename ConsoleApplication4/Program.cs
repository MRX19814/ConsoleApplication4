using System;

namespace ConsoleApplication4
{
    class Program
    {
        /*static void Main(string[] args) 
        {
             string[] favcolors = new string[3];

             for (int i = 0; i < favcolors.Length; i++)
             {
                 Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                 favcolors[i] = Console.ReadLine();
             }

             foreach (var color in favcolors)
             {
                 switch (color)
                 {
                     case "red":
                         Console.BackgroundColor = ConsoleColor.Red;
                         Console.ForegroundColor = ConsoleColor.Black;

                         Console.WriteLine("Your color is red!");
                         break;

                     case "green":
                         Console.BackgroundColor = ConsoleColor.Green;
                         Console.ForegroundColor = ConsoleColor.Black;

                         Console.WriteLine("Your color is green!");
                         break;

                     case "cyan":
                         Console.BackgroundColor = ConsoleColor.Cyan;
                         Console.ForegroundColor = ConsoleColor.Black;

                         Console.WriteLine("Your color is cyan!");
                         break;

                     default:
                         Console.BackgroundColor = ConsoleColor.Yellow;
                         Console.ForegroundColor = ConsoleColor.Black;

                         Console.WriteLine("Your color is yellow!");
                         break;
                 }
             }
        }*/ // код с выводом цвета текста

        /*static void Main(string[] args) 
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.ReadKey();
        }*/ // код с инверсией имени

        public static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
        }
    }
}
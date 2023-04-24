﻿using System;
using System.ComponentModel.DataAnnotations;

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

        /*public static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp; // создаем переменную для хранения элемента массива

            for (int i = 0; i < arr.Length; i++) // цикл проходит по всем элементам массива
            {
                for (int j =  i + 1; j< arr.Length; j++) // цикл начинается с i+1 проходит по всем элементам массива, если элемент массива i больше j то они меняются местами
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr [i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }*/ // Task 4.3.12

        /*static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }*/ // Task 4.3.13

        static void Main(string[] args)
        {
            int[] array = { 2, -1, 4, 7, -5, -2, -8, 9, 12, 15, -14 };

            var num = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > 0)
                    num++;
            }
            Console.WriteLine(num);
        }
    }
}

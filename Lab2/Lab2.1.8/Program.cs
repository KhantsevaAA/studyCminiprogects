﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Лабораторная работа№2. Сложность 1-го уровня\n Задание 8\n Введите значение аргумента x: ");

            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out x))
            {
                Console.Write(" Упс!ВВеденно некорректное значение.Попробуйте ещё раз: ");
            }
            if (Math.Abs(x) < 1)
                y = Math.Pow(x,2)-1;
            else
                y = 0;
            Console.WriteLine("Ответ: при значении аргумента x={0} значение функции равно y={1}", x, y);
        }

    }
}

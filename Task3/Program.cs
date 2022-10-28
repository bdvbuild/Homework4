using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цикл While. Количество вписанных квадратов без умножения и деления.
            Console.WriteLine("Введите сторону прямоугольника А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону вписаного квадрата C");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Ошибка ввода");
            else
            {
                int squareCount = 0;
                int countA = a;
                int countB = b;
                while (countA >= c)
                {
                    countA -= c;
                    while (countB >= c)
                    {
                        squareCount++;
                        countB -= c;
                    }
                    countB = b;
                }
                Console.WriteLine($"В прямоугольник {a}*{b} можно вписать {squareCount} квадратов со стороной {c}");
            }
                Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        //Цикл For
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N > 0:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine("Ошибка");
            else
            {
                int square = 0;
                for (int i = 1; i < n; i++)
                { square += ((2 * i) - 1);
                Console.WriteLine($"Квадрат числа {i} = {square}"); }

            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Цикл DoWhile
            Console.WriteLine("Введите n. \nДля завершения введите 0.");
            int positiveCount = 0, negativeCount = 0, n = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                negativeCount++;
                
                else
                positiveCount++;
            
            } while (n != 0);

            if (negativeCount > positiveCount)
            { Console.WriteLine("Количество отрицательных чисел больше"); 
            }
            else
                if (positiveCount > negativeCount)
            { Console.WriteLine("Количество положительных чисел больше");
            }
            else
            { Console.WriteLine("Количество положительных и отрицательных чисел равно");
            }
            Console.ReadLine();
        }
    }
}

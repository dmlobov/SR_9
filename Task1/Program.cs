using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое числою X=");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое числою Y=");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1-сложение");
                Console.WriteLine("2-вычитание");
                Console.WriteLine("3-умножение");
                Console.WriteLine("4-частное");
                Console.Write("Ваш выбор:");
                int Z = Convert.ToInt32(Console.ReadLine());
                double S=0;

                if (Z == 1)
                    S = X + Y;
                else
                    if (Z == 2)
                    S = X - Y;
                else
                    if (Z == 3)
                    S = X * Y;
                else
                    if (Z == 4)
                    S = ((double)X) / Y;
                else
                    Console.WriteLine("Нет операции с указанным кодом");
                Console.WriteLine("Результат = {0}", S);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                     
            Console.ReadKey();
        }
    }
}

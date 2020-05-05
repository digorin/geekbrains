using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            //Горин Дмитрий

            Console.WriteLine("Укажите координату x первой точки.");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите координату y первой точки.");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите координату x второй точки.");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите координату y второй точки.");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {r:0.00}."); //Вывод бкз использования метода
            Console.WriteLine($"Расстояние между точками: {CalculateR(x1, y1, x2, y2)}."); //Вывод с использованием метода
            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает расстояние между двумя точками
        /// </summary>
        /// <param name="x1">координата x перовй точки</param>
        /// <param name="y1">>координата y перовй точки</param>
        /// <param name="x2">>координата x второй точки</param>
        /// <param name="y2">координата y второй точки</param>
        /// <returns></returns>
        static double CalculateR(int x1, int y1, int x2, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
    }
}

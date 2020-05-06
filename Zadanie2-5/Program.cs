using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_5
{
    class Program
    {
        //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        //Горин Дмитрий

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите ваш рост в метрах");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажите ваш вес в килограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            double index = weight / Math.Pow(height,2);

            Console.WriteLine($"Ваш индекс массы тела: {index}.");
            HowAreYou(index);
            WhatToDo(index, height, weight);
            Console.ReadLine();
        }

        static void HowAreYou(double index)
        {
            if (index >= 18.5 && index <= 25)
            {
                Console.WriteLine("Всё хорошо.");

            }
            else if (index > 25)
            {
                Console.WriteLine("Пора худеть!");
            }
            else
            {
                Console.WriteLine("Ты дрищ!");
            }
        }

        static double WhatToDo(double index, double height, double weight)
        {
            double new_weight = 0;
            if (index >= 18.5 && index <= 25)
            {
                return new_weight;
            }
            else if (index > 25)
            {
                new_weight = weight - (25 * Math.Pow(height, 2));
                Console.WriteLine($"Вам надо скинуть минимум {new_weight} килограммов.");
                return new_weight;
            }
            else
            {
                new_weight = (18.5 * Math.Pow(height, 2)) - weight;
                Console.WriteLine($"Вам надо набрать минимум {new_weight} килограммов.");
                return new_weight;
            }
        }
    }
}

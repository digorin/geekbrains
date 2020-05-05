using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах
            //Горин Дмитрий

            Console.WriteLine("Укажите ваш рост в метрах");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес в килограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            double index = weight / (height * height);
            Console.WriteLine($"Ваш индекс массы тела: {index}.");
            Console.ReadLine();
        }
    }
}

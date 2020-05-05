using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) *используя вывод со знаком $.
            //Горин Дмитрий

            Console.WriteLine("Укажите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию");
            string surename = Console.ReadLine();
            Console.WriteLine("Укажите ваш возвраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите ваш рост");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Приветствую вас " + name + " " + surename + ", возраст " + age + ". Ваш рост " + height + ", вес " + weight + ".");
            Console.WriteLine(String.Format("Приветствую вас {0} {1}, возраст {2}. Ваш рост {3}, вес {4}.", name,surename,age,height,weight));
            Console.WriteLine($"Приветствую вас {name} {surename}, возраст {age}. Ваш рост {height}, вес {weight}.");
            Console.ReadLine();
        }
    }
}

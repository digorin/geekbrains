using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организуйте в центре экрана
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            //Горин Дмитрий
            string name = "Дмитрий";
            string surename = "Дмитрий";
            string city = "г. Москва";

            Console.WriteLine($"{name} {surename}, {city}.");
            Console.ReadKey();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"{name} {surename}, {city}.");
            Console.ReadKey();

            Print(name, surename, city);
            Console.ReadKey();

        }

        static void Print(string name, string surename, string city)
        {
            Console.WriteLine($"{name} {surename}, {city}.");
        }
        //Запускаю на проверку
    }
}

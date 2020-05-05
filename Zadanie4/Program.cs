using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Написать программу обмена значениями двух переменных.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            //Горин Дмитрий

            int a = 1;
            int b = 2;
            int c;
            Console.WriteLine($"Было a = {a}, b = {b}.");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Стало a = {a}, b = {b}.");
            Console.ReadKey();

            //Второй способ
            a = 1;
            b = 2;
            Console.WriteLine($"Было a = {a}, b = {b}.");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Стало a = {a}, b = {b}.");
            Console.ReadKey();

        }
    }
}

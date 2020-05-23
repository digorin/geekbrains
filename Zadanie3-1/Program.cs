using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_1
{
    class Program
    {
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        //Горин Дмитрий



        static void Main(string[] args)
        {
            Complex complex = new Complex(); //Базовое комплексное число относительно которого совершаются операции
            complex.im = 4;
            complex.re = 4;

            Complex complex2 = new Complex();
            complex2.im = 2;
            complex2.re = 2;

            Console.WriteLine("Какую операцию вы хотите сделать (+,-,*,/)?");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Сложение числа 1 и числа 2 дает: {complex.Plus(complex2).ToString()}.");
                    break;
                case "-":
                    Console.WriteLine($"Вычитание числа 2 из числа 1 дает: {complex.Minus(complex2).ToString()}.");
                    break;
                case "*":
                    Console.WriteLine($"Умножение числа 1 на число 2 дает: {complex.Multiply(complex2).ToString()}.");
                    break;
                case "/":
                    Console.WriteLine($"Деление числа 1 на число 2 дает: {complex.Divide(complex2).ToString()}.");
                    break;
                default:
                    Console.WriteLine("Вы ввели несуществующую операцию");
                    break;
            }
            Console.ReadKey();
        }

        class Complex
        {
            public double re;
            public double im;

            public Complex Plus(Complex x2)
            {
                Complex result = new Complex();

                result.re = x2.re + re;
                result.im = x2.im + im;

                return result;
            }

            public Complex Minus(Complex x2)
            {
                Complex result = new Complex();

                result.re = x2.re - re;
                result.im = x2.im - im;

                return result;
            }

            public Complex Multiply(Complex x2)
            {
                Complex result = new Complex();

                result.im = re * x2.re - im* x2.im;
                result.re = im * x2.re + re * x2.im;

                return result;
            }

            public Complex Divide(Complex x2)
            {
                Complex result = new Complex();

                result.im = (re * x2.re + im * x2.im) / (x2.re * x2.re + x2.im * x2.im);
                result.re = (im * x2.re - re * x2.im) / (x2.re * x2.re + x2.im * x2.im);

                return result;
            }

            public override string ToString()//Зменил стандартный метод приведения к строке с помощью override
            {
                return re + "+" + im + "i";
            }
        }
    }
}

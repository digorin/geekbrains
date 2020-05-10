using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_2
{
    class Program
    {
        //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //    Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.
        //Горин Дмитрий

        static void Main(string[] args)
        {
            double sum = 0;
            double numder = Input("Введите число");
            if (numder % 2 != 0 && numder > 0)
                sum = numder;

            while (numder != 0)
            {
                try
                {
                    numder = Input("Введите число");
                    if (numder % 2 != 0 && numder > 0)
                        sum += numder;
                }
                catch (InputException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }

            Console.WriteLine($"Сумма всех введенных нечетных и положительных чисел равна {sum}.");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод запрашивает число и не завершается пока пользователь его не введет
        /// </summary>
        /// <param name="question">Вопрос, который выводится пользователю перед вводом</param>
        /// <returns></returns>
        static double Input(string question)
        {
            Console.WriteLine(question);
            double result = 0;

            if (Double.TryParse(Console.ReadLine(), out result))
            {

            }
            else
            {
                throw new InputException("Вы ввели не число");
            }

            return result;
        }

        class InputException : Exception
        {
            public InputException(string message) : base(message)
            {

            }
        }
    }
}

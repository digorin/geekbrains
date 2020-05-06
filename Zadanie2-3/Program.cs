using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_3
{
    class Program
    {
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        //Горин Дмитрий

        static void Main(string[] args)
        {
            double sum = 0;
            double numder = Input("Введите число");
            if(numder % 2 != 0 && numder > 0)
            sum = numder;

            while (numder != 0)
            {
                numder = Input("Введите число");
                if (numder % 2 != 0 && numder > 0)
                    sum += numder;
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
                Console.WriteLine("Вы ввели не число");
                result = Input(question);//Рекурсией добиваемся ввода чила
            }

            return result;
        }
    }
}

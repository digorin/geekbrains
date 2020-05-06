using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Input("Введите первое число");
            int n2 = Input("Введите второе число");
            int n3 = Input("Введите третье число");
            
            if(n1>n2)
            {
                if(n1>n3)
                {
                    Console.WriteLine($"Максимальное число - перове ({n1}).");
                }
                else
                {
                    Console.WriteLine($"Максимальное число - третье ({n3}).");
                }
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine($"Максимальное число - второе ({n2}).");
                }
                else
                {
                    Console.WriteLine($"Максимальное число - третье ({n3}).");
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод запрашивает число и не завершается пока пользователь его не введет
        /// </summary>
        /// <param name="question">Вопрос, который выводится пользователю перед вводом</param>
        /// <returns></returns>
        static int Input(string question)
        {
            Console.WriteLine(question);
            int result = 0;

            if (Int32.TryParse(Console.ReadLine(), out result))
            {
               //Идем дальше по коду 
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
                Input(question);//Рекурсией добиваемся ввода чила
            }

            return result;
        }
    }
}

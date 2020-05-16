using System;

namespace Zadanie2_1
{
    class Program

    //1. Написать метод, возвращающий минимальное из трех чисел.
    //Программа не предлагает решения для случаем если несколько числе оказались одинаковыми, так как этого не требовалось в задании
    //Горин Дмитрий

    {
        static void Main(string[] args)
        {
            int n1 = Input("Введите первое число");
            int n2 = Input("Введите второе число");
            int n3 = Input("Введите третье число");

            int[] numbers = { n1, n2, n3 };

            int min = numbers[0]; //Небольшой костыль, но вроде без него никак проще не сделать
            int count = 0;

            foreach (int item in numbers) //сравниваем все элементы массива с минимальным
            {
                if(item <= min)
                {
                    min = item;
                    count++;
                }
            }

            Console.WriteLine($"Минимальное число под номером {count}. Оно равно {min}.");

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

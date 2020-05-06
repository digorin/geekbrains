using System;


namespace Zadanie2_2
{
    class Program
    {
        //2. Написать метод подсчета количества цифр числа.
        //Горин Дмитрий

        static void Main(string[] args)
        {
            int number = Input("Введите число");
            Console.WriteLine($"Количество символов введенного числа равно {Lenght(number)}.");
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
                
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
                result = Input(question);//Рекурсией добиваемся ввода чила
            }

            return result;
        }

        /// <summary>
        /// Метод подсчитывает количество символов в числе
        /// </summary>
        /// <param name="number">Передаваемое число int</param>
        /// <returns></returns>
        static int Lenght(int number)
        {
            int lenght = number.ToString().Length;
            return lenght;
        }//Впринципе можно данную задачу решить с помощью цикла foreach, считая каждый char, предварительно переведя в string number, но это излишнее.
    }
}

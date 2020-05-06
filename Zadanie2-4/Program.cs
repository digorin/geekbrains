using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_4
{
    class Program
    {
        //4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        //Горин Дмитрий

        static void Main(string[] args)
        {
            string[] result = new string[2];
            int tryCount = 0;
            do
            {
                result = Input();
                if (Authorization(result[0], result[1]))
                {
                    Console.WriteLine("Доступ разрешен.");
                    Console.ReadKey();
                    return; //Тут вожет быть значение true, а метод использоваться по аналогии с Authorization для получения доступа к продолжению выполнения кода из вызывающего класса.
                }
                else
                {
                    Console.WriteLine($"Неверный логин или пароль. Осталось {2-tryCount} попытки");
                }
                tryCount++;
            }
            while (tryCount < 3);
            Console.WriteLine("Вы исчерпали попытки");
            Console.ReadKey();
            }

        /// <summary>
        /// Метод проверяет правильность логина и пароля
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool Authorization(string login, string password)
        {
            string login_true = "root";
            string password_true = "GeekBrains";

            if(login_true == login && password_true == password)
            {
                return true;  
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод запрашивает число и не завершается пока пользователь его не введет
        /// </summary>
        /// <param name="question">Вопрос, который выводится пользователю перед вводом</param>
        /// <returns></returns>
        static string[] Input()
        {
            string[] result = new string[2];
            Console.WriteLine("Введите логин");
            result[0] = Console.ReadLine().ToString();
            Console.WriteLine("Введите пароль");
            result[1] = Console.ReadLine().ToString();
            return result;
        }
    }
}

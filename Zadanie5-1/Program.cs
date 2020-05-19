using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie5_1
{
    class Program
    {

//        Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//        б) **с использованием регулярных выражений.
//Горин Дмитрий
        static void Main()
        {

            int check;
            int count = 0;
            bool useRegex = true; //Определяется каким способом будем проверять пароль. Внутренний триггер для преподавателя.

            do
            {
                Console.WriteLine("Введите логин. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой.");
                string login = Console.ReadLine();

                check = 0;

                if (!useRegex) //Определяется каким способом будем проверять пароль. Внутренний триггер для преподавателя.
                {
                    //Проверяем Длину логина
                    if (login.Length >= 2 && login.Length <= 10)
                        check++;

                    //Проверяем на наличие латинских символов

                    count = 0;
                    foreach (char a in login)
                    {
                        if (((a >= 'a') && (a <= 'z')) || ((a >= 'A') && (a <= 'Z')))
                            count++;
                    }
                    if (login.Length == count)
                        check++;


                    if (!Char.IsDigit(login.ToCharArray(0, 1)[0]))
                        check++;
                }
                else//Используем регулярные выражения
                {
                    if (Regex.IsMatch(login.ToString(), @"^[A-Za-z]{1}[A-Za-z0-9]{1,9}$"))
                        check = 3;
                }

                if (check < 3)
                    Console.WriteLine("Логин не соответсвует требованиям");

            } while (check < 3);
            Console.WriteLine("Логин подходит по требованиям");
            Console.ReadKey();
        }


    }
}

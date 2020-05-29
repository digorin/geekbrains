using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Zadanie6_3
{
    class Program
    {
           //Переделать программу Пример использования коллекций для решения следующих задач:
           //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
           //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся;
           //в) отсортировать список по возрасту студента; - это задание не успел, но так понял, здесь нужен двумерный список
           //Горин Дмитрий

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int students56 = 0;

            // Создадим необобщенный список
            ArrayList list = new ArrayList();

            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;

            StreamReader sr = new StreamReader("students_1.csv");

            int[] arr = new int[6]; ;//массив для решения задачи б)

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                    list.Add(s[1] + " " + s[0] + " " );// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[6]) == 5 || int.Parse(s[6]) == 6) students56++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        arr[int.Parse(s[6])-1]++;
                    }
                }
                catch
                {
                    //на сколько я знаю, за такое ругают
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine("Студентов 5 и 6 курсов:{0}", students56);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"На {i+1} курсе в возрасте от 18 до 20 лет учится: {arr[i]}");
            }
            
            //foreach (var v in list) Console.WriteLine(v);
            // Вычислим время обработки данных
            //Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

}

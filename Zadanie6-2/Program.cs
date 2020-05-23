using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_2
{
    public delegate double Fun(double x, double a); //Делегат для выбора функций

    class Program
    {
        //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
        //Горин Дмитрий

        public static double F1(double x, double a) //первая функция
        {
            return a * Math.Sqrt(x);
        }

        public static double F2(double x, double a) //вторая функция
        {
            return a * Math.Sin(x);
        }

        public static double F3(double x, double a) //третья функция
        {
            return Math.Atan(x)-a;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, int choise, List<Fun> functions)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(functions[choise-1](x, a));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            List<Fun> functions = new List<Fun>();//список для хранения выбора функций
            functions.Add(F1);
            functions.Add(F2);
            functions.Add(F3);

            Console.WriteLine("Укажите начало отрезка");
            int start = Convert.ToInt32(Console.ReadLine());// Переменная для выбора начала отрезка
            Console.WriteLine("Укажите конец отрезка");
            int finish = Convert.ToInt32(Console.ReadLine());// Переменная для выбора конца отрезка

            Console.WriteLine("Какую функцию вы хотите использовать:\n 1 - a* x^2 \n 2 - a* sin(x) \n 3 - tan(x)-a?");
            int choice = Convert.ToInt32(Console.ReadLine());// Переменная для выбора функции

            SaveFunc("data.bin", start, finish, 0.5, choice, functions);

            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}

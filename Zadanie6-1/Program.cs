using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6_1
{
    class Program
    {
        //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
        //Горин Дмитрий

        public static double F(double x, double a, int choice) //Доработанная функция
        {
            switch (choice)
            {
                case 1:
                    return a * Math.Sqrt(x);
                case 2:
                    return a * Math.Sin(x);
                default:
                    return 
                        a* Math.Sqrt(x);
            }
            
        }
        public static void SaveFunc(string fileName, double a, double b, double h, int choice)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x, a, choice));
                x += h;// x=x+h;
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
            Console.WriteLine("Какую функцию вы хотите использовать: 1 - a* x^2 или 2 - a* sin(x)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            SaveFunc("data.bin", -100, 100, 0.5, choice);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }

}

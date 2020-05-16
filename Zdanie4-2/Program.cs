using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie4_2
{
    class Program
    {
        static void Main()
        {

            int[] arr = new int[20];
            StaticClass.FillArr(arr);


            int[] mass = StaticClass.GetArrFromFile("arr.txt");

            Console.WriteLine(mass);
            Console.ReadKey();

        }

        static class StaticClass
        {

            public static void FillArr(int[] arr)
            {
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    arr[i] = random.Next(-10000, 10000);
                    Console.WriteLine(arr[i]);
                }
                int count = 0;
                int pairs = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] % 3 == 0)
                        count++;
                    if (arr[i + 1] % 3 == 0)
                        count++;
                    if (count == 1)
                        pairs++;
                    count = 0;
                }
                Console.WriteLine($"Пар удовлетворяющих условию {pairs}.");
                Console.ReadKey();
            }

            public static int[] GetArrFromFile(string filename)
            {
                int[] mass;
                if (File.Exists(filename))//Если файл существует
                {
                    //Считываем все строки в файл 
                    string[] ss = File.ReadAllLines(filename);
                    mass = new int[ss.Length];

                    //Переводим данные из строкового формата в числовой
                    for (int i = 0; i < ss.Length; i++)
                        mass[i] = int.Parse(ss[i]);
                    return mass;
                }
                else
                {
                    Console.WriteLine("Error load file");
                    mass = new int[0]; //Создаем массив заглушку
                    return mass;
                }
            }
        }


    }
}

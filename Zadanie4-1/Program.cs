using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr[i] = random.Next(-10000,10000);
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
    }
}

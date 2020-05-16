using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Drobi drobi = new Drobi();
            drobi.A = 1;
            drobi.B = 4;
            double c;
            try
            {
                c = drobi.Operation();
                Console.WriteLine($"Результат: {c}.");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }

        public class Drobi
        {
            public int A { get; set; }
            public int B { get; set; }
            public double Result { get; set; } //не понял зачем давать этой переменной права только на чтение, если внутри класса тогда тоже нельзя будет присвоить ей значение

            public double Operation()
            {
                Console.WriteLine("Какую операцию вы хотите сделать (+,-,*,/)?");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Result = A + B;
                        break;
                    case "-":
                        Result = A - B;
                        break;
                    case "*":
                        Result = A * B;
                        break;
                    case "/":
                        Result = A / B;
                        break;
                    default:
                        Console.WriteLine("Вы ввели несуществующую операцию");
                        break;
                }
                return Result;
            }

            class OperationException : ArgumentException
            {
                public OperationException(string message) : base(message)
                {
                    //не разобрался еще с исключениями до конца
                }
            }

        }
    }
}

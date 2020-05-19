using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadanie5_2
{
    class Program
    {

        //  Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения,  которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //Горин Дмитрий

        static void Main()
        {
            Console.WriteLine("Введите предложение для обработки");
            string text = Console.ReadLine();
            Console.WriteLine("Какую задачу мы будем решать? 1,2,3 или 4?");
            int variant = 1;
            variant = int.Parse(Console.ReadLine());

            switch (variant)
            {
                case 1:
                    {
                        Console.WriteLine("Слова из скольких букв мы ищем?");
                        int n = int.Parse(Console.ReadLine());
                        Text.ShowWords(text, 4);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Укажите символ, на который заканчиваются слова, которые необходимо удалить.");
                        string c = Console.ReadLine();
                        Text.DeleteWord(text, c);
                        break;
                    }
                case 3:
                    {
                        Text.FindLongWord(text);
                        break;
                    }
                case 4:
                    {
                        Text.BuildString(text);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такой задачи нет.");
                        break;
                    }
            }
            


        }

        static class Text
        {
            static public void ShowWords(string text, int n)
            {
                int count = 0;
                text = text.Replace(".", "").Replace(",", "");
                char[] div = { ' ' };
                string[] parts = text.Split(div);
                List<string> toshow = new List<string>();
                foreach (string word in parts)
                {
                    count = 0;

                    foreach (char a in word)
                    {
                        if (char.IsLetter(a))
                        {
                            count++;
                        }
                    }
                    if (count >= 4)
                        toshow.Add(word);
                }
                Console.WriteLine("Указанным параматрам соответствуют слебующие слова:");
                for (int i = 0; i < toshow.Count; i++)
                {
                    Console.WriteLine(toshow[i]);
                }
                Console.ReadKey();
            }

            static public void DeleteWord(string text, string c)
            {
                c += " "; //Маленький костыль для работы регулярных выражений
                Console.WriteLine(Regex.Replace(text, "[^ ]{0,}" + c, "").Trim());
                Console.ReadKey();
            }

            static public void FindLongWord(string text)
            {
                text = text.Replace(".", "").Replace(",", "");
                char[] div = { ' ' };
                string[] parts = text.Split(div);
                string longestword = "";
                foreach (string word in parts)
                {
                    if (word.Length >= longestword.Length)
                        longestword = word;
                }
                Console.WriteLine($"Самое длинное слово: {longestword}.");
                Console.ReadKey();
            }

            static public void BuildString(string text)
            {
                text = text.Replace(".", "").Replace(",", "");
                char[] div = { ' ' };
                string[] parts = text.Split(div);
                string longestword = "";
                int count = 0;
                int num = 0;
                int num_max = 0;
                StringBuilder savemsx = new StringBuilder();
                do
                {
                    longestword = "";
                    num_max = 0;
                    num = 0;
                    foreach (string word in parts)
                    {
                        if (word.Length >= longestword.Length)
                        {
                            longestword = word;
                            num_max = num;
                        }
                        num++;
                    }
                    parts[num_max] = "";
                    count++;
                    savemsx.Append(longestword + " ");
                } while (count < 3);

                Console.WriteLine($"Три самых длинных слова: {savemsx.ToString()}");
                Console.ReadKey();
            }
        }

    }
}

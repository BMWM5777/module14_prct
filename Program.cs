using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14_prct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            // Приведем все слова к нижнему регистру, чтобы избежать различий в регистре
            string[] words = text.ToLower().Split(new char[] { ' ', ',', '.', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Подсчет вхождений слов
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Вывод статистики в виде таблицы
            Console.WriteLine("Слово\t\tКоличество");
            Console.WriteLine("░░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄░░░░░░░\r\n░░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄░░░░\r\n░░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█░░░\r\n░░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░░█░░\r\n░▄▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░░█░\r\n█░▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒░█\r\n█░▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█\r\n░█░▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█░\r\n░░█░░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█░░\r\n░░░█░░░░██░░▀█▄▄▄█▄▄█▄████░█░░░\r\n░░░░█░░░░▀▀▄░█░░░█░█▀██████░█░░\r\n░░░░░▀▄░░░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█░░\r\n░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░▒░░░█░\r\n░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░░░░█░\r\n░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░░░░█░░");

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key,-15}\t{pair.Value}");
            }
        }
    }

}

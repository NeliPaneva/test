using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumi
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Program.cs");
            StreamWriter writer = new StreamWriter("..\\..\\Rezult.txt");
            using (reader)
            {//komentar
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int countOfWords = 0;
                        String l = new String(line.ToArray());
                        var words = l.Trim().Split(' ');
                        countOfWords += words.Length;
                        writer.WriteLine("Line {0}: {1}", countOfWords, line);
                        Console.WriteLine("Line {0}: {1}", countOfWords, line);
                        line = reader.ReadLine();
                        Console.WriteLine("това е тест за работа с GitHub");
                        for (int i = 0; i < 100; i++)
			{
                            Console.WriteLine(i);
			}
                    }
                }
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("Kasuta formaati: s--a kus - tähistab tundmatut tähte");

            string choise = Console.ReadLine();

            WordFinder(choise);
        }

        private static void WordFinder(string choise)
        {
            Regex regualarExp = new Regex(@"\b" + choise.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                int lineNumber = 0;

                    while (sr.EndOfStream == false)
                    {
                       string line = sr.ReadLine();

                        if (line.Length == choise.Length)
                        {
                          MatchCollection matchCollection = regualarExp.Matches(line);
                            
                            if (matchCollection.Count > 0) 
                            {
                                lineNumber++;
                                Console.WriteLine(lineNumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();
        }
    }
}

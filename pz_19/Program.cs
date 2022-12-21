using System.IO;
using System.Text.RegularExpressions;

namespace pz_19
{
    internal class Program
    {
        static void PrintName(string path)
        {
            FileStream file = new FileStream(@"D:\f1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(file);
            string text = streamReader.ReadToEnd();
            file.Close();

            string pattern = @"[А-ЯЁ][а-яё]+\s?[А-ЯЁ][а-яё]+\s";

            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(text)) Console.WriteLine(match.Value);
        }

        static void AnalyzOfText(string path)
        {
            FileStream file = new FileStream(@"D:\f1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(file);
            string text = streamReader.ReadToEnd();
            file.Close();

            string ipAdress = @"(\d+[.]\d+[.]\d+[.]\d+\s)";

            Regex regex = new Regex(ipAdress);

            Console.WriteLine("IP-адреса:");
            foreach (Match match in regex.Matches(text)) Console.WriteLine(match);

            string date = @"[[]\d+[/]\w+[/]\d+[:]\d+[:]\d+[:]\d+\s*[+]\d+[]]";

            Regex regex2 = new Regex(date);

            Console.WriteLine("Даты:");
            foreach (Match match in regex2.Matches(text)) Console.WriteLine(match);
        }
        static void Main(string[] args)
        {

        }
    }
}
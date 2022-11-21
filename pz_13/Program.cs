using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace pz_13
{
    internal class Program
    {
        static bool GetPalindrom(string text)
        {
            if (text == null) return false;
            text = text.ToLower();
            text = text.Replace(" ", "");
            string textReverse = text;
            char[] Palindrom = text.ToCharArray();
            char[] ReversePalindrom = textReverse.ToCharArray();
            Array.Reverse(ReversePalindrom);
            text = new string(Palindrom);
            textReverse = new string(ReversePalindrom);


            if (text == textReverse) return true;
            else return false;
        }
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetPalindrom(text));

            //char[] ReversePalindrom = new char[Palindrom.Length];
            //Array.Copy(Palindrom, 0, ReversePalindrom, 0, Palindrom.Length);
            //Array.Reverse(ReversePalindrom);
        }
    }
}
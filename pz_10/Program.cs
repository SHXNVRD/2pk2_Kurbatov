namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение: ");
            string text = Console.ReadLine();

            /*
            string[] symbols = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string symbol in symbols)
                Console.Write(symbol + " ");
            Console.WriteLine();

             var three = char.GetNumericValue('\u0033');
            Console.WriteLine(three); 
            Console.WriteLine((int)'\u0033'); 
            string str1 = str0 ?? "1+2+3";
            */

            for (int i = 0; i < text.Length; i++)
            {
                char chr = text[i];
                int code = (int)chr;
            }

            char d = '3';
            int g = Convert.ToInt32(d);
            Console.WriteLine(g);



            string s = "ABCD";
            char ch = s[0];
            int charnum = (int)ch;
            Console.WriteLine(charnum);
        }
    }
}
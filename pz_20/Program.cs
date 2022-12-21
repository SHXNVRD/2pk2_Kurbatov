using System.Text;
using System.Xml.Serialization;

namespace pz_20
{
    internal class Program
    {
        static void Name(string text)
        {
            StringBuilder sb = new StringBuilder(text);

            for (int i = 0; i < sb.Length; i++)
            {
                if (i % 2 != 0)
                    sb[i] = Char.ToUpper(sb[i]);

            }

            foreach (var str in sb.ToString()) Console.Write(str);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
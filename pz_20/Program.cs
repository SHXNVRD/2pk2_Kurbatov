using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace pz_20
{
    internal class Program
    {
        static public void ReverseRegister(string text)
        {
            if (text == null) return;
                
            StringBuilder sb = new StringBuilder(text);
            
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsLower(text[i])) sb[i] = Char.ToUpper(sb[i]);
                else sb[i] = Char.ToLower(sb[i]);
                Console.Write(sb[i]);
            }  
        }
        static void Main(string[] args)
        {
            string str = "HellO WoRRld";
            ReverseRegister(str);
        }
    }
}
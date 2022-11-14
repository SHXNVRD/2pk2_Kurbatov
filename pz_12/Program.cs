using System.Security.Cryptography.X509Certificates;

namespace pz_12
{
    
    internal class Program
    {
       static void SetValues(out int x, out int y)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Sum(int x, int y, out int result)
        {
            result = x + y;
        }

        static void PrintResult(int chislo)
        {
            Console.WriteLine(chislo);
        }

        static void Main(string[] args) 
        {
            int x;
            int y;
            int result;
            SetValues(out x, out y);
            Sum(x, y, out result);
            PrintResult(result);
        }
    }
}
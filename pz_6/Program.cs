namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -2;

            while (x <= 2)
            {
                double y = -2.4 * Math.Pow(x, 2) + 5 * x - 3;
                x += 0.5;
                Console.WriteLine($"Значение функции:{y}\t Значение аргумента:{x}");
            }
            Console.ReadKey();

        }
    }
}

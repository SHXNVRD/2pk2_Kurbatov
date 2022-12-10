namespace Programm
{
    internal class programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задние 1");
            for (int i = -25; i <= 25; i += 5) Console.WriteLine(i);

            Console.WriteLine("Задание 2");

            for (char chr = 'P'; chr <= 'U'; chr++) Console.Write(chr);
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            char chr1 = '#';

            for (int m = 0; m < 7; m++)
            {
                for (int n = 0; n <= 4; n++) Console.Write(chr1);
                Console.WriteLine();
            }

            Console.WriteLine("Задание 4");
            int x = 0;
            for (int i = 0; i < 100; i++)
            {
                if (x == i % 2) Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("задание 5");
            for (int i = 3, j = 50; j - i != 17; i++, j--)
            {
                Console.WriteLine($"{i}\t{j}");
            }
            Console.ReadKey();
        }
    }
}
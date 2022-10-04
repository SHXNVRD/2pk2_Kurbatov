namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i] = rnd.Next(-10, 10)} ");
            }
            Console.WriteLine();
            Array.Reverse(myArray, 0, myArray.Length - 1);
            foreach (int i in myArray) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
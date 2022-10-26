namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Инициализация массива

            Console.Write("Введите количество строк: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[,] myArray = new int[y, x];

            Random rnd = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(-100, 101);
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Нахождение наименьших элементов столбцов 

            int[] myArrayMin = new int[x];
            for (int i = 0; i < x; i++)
            {
                int max = 100;
                for (int j = 0; j < y; j++)
                {
                    if (myArray[j, i] < max) max = myArray[j, i];
                }
                myArrayMin[i] = max;
            }
            Console.WriteLine("Минимальные значения столбцов массива: ");

            foreach (int i in myArrayMin) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine(myArrayMin.Max());
            Console.ReadKey();
            
        }
    }
}
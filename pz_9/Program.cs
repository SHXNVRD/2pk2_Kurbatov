namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива(задание 1)
            Random rnd = new Random();
            string[][] myArray = new string[9][];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new string[rnd.Next(1, 6)];
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите элементы массива столбца под индексом {i}");
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = Console.ReadLine();
                    if (myArray[i][j] == null) myArray[i][j] = String.Empty;
                }
            }

            //Перебор массива myArray
            Console.WriteLine("Вывод массива myArray(задание 2):");
            foreach (string[] row in myArray)
            {
                foreach (string item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            //Запись последних элементов массива myArray в массив myArraylastItem
            string[] myArrayLastItems = new string[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArrayLastItems[i] = myArray[i][^1];
            }

            //Перебор массива myArrayLastItem
            Console.WriteLine("Последние элементы строк массива массивов(задание 3): ");
            Console.WriteLine();
            foreach (var i in myArrayLastItems) Console.Write(i + " ");

            //Нахождение максимальных элементов массива myArray и запись их в массв myArrayMaxItem
            string[] myArrayMaxItems = new string[9];
            for (int i = 0; i < myArray.Length; i++)
            {
                string str = "a";
                for (int j = 0; j < myArray[i].Length; ++j)
                {
                    if (myArray[i][j].Length >= str.Length) str = myArray[i][j];
                    myArrayMaxItems[i] = str;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Максимальные элементы массива массивов(задание 4):");
            foreach (var i in myArrayMaxItems) Console.Write(i + " ");

            //Верерс каждой строки массива myArray
            for (int i = 0; i < myArray.Length; i++)
            {
                Array.Reverse(myArray[i]);
            }

            /*
             * Пытался сделать задание 5, но что-то не получилось
            for (int i = 0; i < myArray.Length; i++)    
            {
                string FirsItem = myArray[i][0];
                string str = "a";
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    if (myArray[i][j].Length >= str.Length) str = myArray[i][j];
                }
                myArray[i][Array.IndexOf(myArray, str)] = FirsItem;
                myArray[i][0] = str;
            }
            */

            Console.WriteLine("Вывод массива myArray после реверса(задание 6):");
            foreach (string[] row in myArray)
            {
                foreach (string item in row)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            //Общее количество символов в строках каждой строки массива
            for (int i = 0; i < myArray.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    sum += myArray[i][j].Length;

                }
                Console.WriteLine("Задание 7");
                Console.WriteLine($"Длинна подмассива массива myArray под индексом {i} равна {sum}");
                Console.ReadKey();
            }
        }
    }
}
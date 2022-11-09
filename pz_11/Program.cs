namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = i + 1; j < strArray.Length; j++)
                {
                    int result = string.Compare(strArray[i], strArray[j]);
                    if (result == 0)
                    {
                        Console.WriteLine($"Найдена одинаковая строка: {strArray[j]}");
                        strArray[j] = strArray[i].Remove(0);
                    }
                }
            }

            string fullstr = string.Join(" ", strArray);
            Console.WriteLine(fullstr);
            Console.ReadKey();
            
        }
    }
}
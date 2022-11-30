namespace pz_16
{
    internal class Program
    {
        private static void AnalyzOfText(string path)
        {
            //Проверяем существование файла
            if (!File.Exists(path))
                return;

            //Считываем содержимое файла в массив строк
            string[] text = File.ReadAllLines(path);

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Trim();
                //Добавляем к элементу массива под индексом i строку "-", пока его длина меньше длины самого большого элемента массива
                for (int j = text[i].Length; j < text.Max(x => x.Length); j++)
                {
                    text[i] = string.Concat(text[i], "-");
                }
                Console.WriteLine(text[i]);
            }
        }
        
        static void Main(string[] args)
        {
            string path = "Введите путь";
            AnalyzOfText(path);
        }
    }
}
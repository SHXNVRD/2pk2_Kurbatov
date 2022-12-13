using System.IO;

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

        private static void NameOfMetod(string path)
        {
            //Проверяем существование файла
            if (!File.Exists(path))
                return;

            //Считываем содержимое файла в массив строк
            string[] text = File.ReadAllLines(path);

            //Создание директории
            FileInfo f1 = new FileInfo(path);
            string directoryPath = f1.DirectoryName + @"\new";
            Directory.CreateDirectory(directoryPath);

            //Создание файла f2
            string f2Path = directoryPath + @"\f2.txt";
            FileInfo f2 = new FileInfo(f2Path);
            
            //Запись содержимого файла f1 в файл f2x
            using (StreamWriter writer = new StreamWriter(f2Path))
            {
                foreach (string line in text)
                {
                    writer.WriteLine(line);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь");
            string path = Console.ReadLine();
            NameOfMetod(path);
        }
    }
}
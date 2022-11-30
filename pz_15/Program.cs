namespace pz_15
{
    internal class Program
    {
        private static void GetGrades(string path)
        {
            //Проверяем существования файла
            if (!File.Exists(path))
                return;

            //Считываем содержание файла в строковый массив
            string[] studentsGrades = File.ReadAllLines(path);
            //Создаём массив под оценки
            int[] Grades = new int[studentsGrades.Length];
            //Создаём массив симовлов для проверки на число
            char[] chr = new char[studentsGrades.Length];
            double result = 0;
            //Находим оценки и выводим студентов с оценкой меньше 3
            for (int i = 0; i < studentsGrades.Length; i++)
            {
                chr = studentsGrades[i].ToCharArray();
                for (int j = 0; j < chr.Length; j++)
                {
                    if (Char.IsDigit(chr[j]))
                    {
                        Grades[i] = (int)Char.GetNumericValue(chr[j]);
                        if (Grades[i] < 3)
                            Console.WriteLine(studentsGrades[i]);
                    }
                }
            }
            //Считаем среднее арифметическое
            for (int i = 0; i < Grades.Length; i++)
            {
                result += Grades[i];
            }
            result /= Grades.Length;
            Console.WriteLine($"Среднее арифметическое учеников: {result}");
        }
        static void Main(string[] args)
        {
            string path = "Введите путь";
            GetGrades(path);
        }
    }
}
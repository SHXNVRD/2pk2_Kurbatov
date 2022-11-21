namespace pz_14
{
    internal class Program
    {
        /// <summary>
        /// Арифметическая прогрессия
        /// </summary>
        /// <param name="a">Первый член артфметической прогрессии</param>
        /// <param name="d">Разность между соседними членами прогрессии</param>
        /// <param name="an">Вычисляемый член прогрессии</param>
        /// <returns></returns>
        static double AriphmeticProgression(double a, double d, int an)
        {
            if (an == 1) return a;
            return AriphmeticProgression(a + d, d, an - 1);
        }
        /// <summary>
        /// Геометрическая прогрессия
        /// </summary>
        /// <param name="a">Первый член геометрической прогрессии</param>
        /// <param name="q">Знаменатель прогрессии</param>
        /// <param name="an">Вычисляемый член прогрессии</param>
        /// <returns></returns>
        static double GeometricProgression(double a, double q, int an)
        {
            if(an == 1) return a;
            return GeometricProgression(a * q, q, an - 1);
        }
        /// <summary>
        /// Вывод чисел от b до a в порядке возрастания, при условии что a > b
        /// </summary>
        /// <param name="a">Верхняя граница</param>
        /// <param name="b">Нижняя граница</param>
        static void PrintNumbers(int a, int b)
        {
            int number = a;
            if (a > b)
            {
                PrintNumbers(--a, b);
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// Сумма от 1 до x, при x > 0
        /// </summary>
        /// <param name="x">Число до которого необходимо найти сумму</param>
        /// <returns></returns>
        static double SummPlusNumber(int x)
        {
            if (x == 1) return 1;
            return x + SummPlusNumber(--x);
        }
        /// <summary>
        /// Сумма от 1 до x, при x < 0
        /// </summary>
        /// <param name="x">Число до которого необходимо найти сумму</param>
        /// <returns></returns>
        static double SummMinusNumber(int x)
        {
            if (x == 0) return 0;
            return x + SummMinusNumber(++x);
        }

        static void Main(string[] args)
        {
            //Вариант 13

            //Задание 1
            Console.WriteLine(AriphmeticProgression(0.3, 0.2, 3));
            //Задание 2
            Console.WriteLine(GeometricProgression(13, -0.01, 3));
            //Задание 3(включительно не получилось(-48 не выводит, хотя переменной в методе значение присваивается, скорее всего, прикол рекурсии, или я не знаю что ей надо))
            PrintNumbers(6, -48);
            //Задание на 5
            Console.WriteLine(SummMinusNumber(-5));
            Console.WriteLine(SummPlusNumber(5));
        }
    }
}
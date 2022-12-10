namespace pz_18
{
    internal class Program
    {
        enum Marks : byte
        {
            ОченьПлохо = 1,
            Неудовлетворительно,
            Удовлетворительно,
            Хорошо,
            Отлично
        }

        enum Seasons : byte
        {
           Зима,
           Весна,
           Лето,
           Осень
        }

        static void Main(string[] args)
        {
            //Задание 1

            Console.Write("Введите оценку: ");
            byte value = Convert.ToByte(Console.ReadLine());
            Marks mark;

            if (Enum.IsDefined(typeof(Marks), value))
            {
                mark = (Marks)value;
                switch (mark)
                {
                    case Marks.ОченьПлохо:
                        Console.WriteLine($"Характеристика оценки: {mark}");
                        break;
                    case Marks.Неудовлетворительно:
                        Console.WriteLine($"Характеристика оценки: {mark}");
                        break;
                    case Marks.Удовлетворительно:
                        Console.WriteLine($"Характеристика оценки: {mark}");
                        break;
                    case Marks.Хорошо:
                        Console.WriteLine($"Характеристика оценки: {mark}");
                        break;
                    case Marks.Отлично:
                        Console.WriteLine($"Характеристика оценки: {mark}");
                        break;
                    default:
                        break;
                }
            }
            else
                Console.WriteLine("Неверное значение");

            //Задание 2

            Console.Write("Введите сезон: ");
            string str = Console.ReadLine();

            if (str != null)
            {
                Seasons season = (Seasons)Enum.Parse(typeof(Seasons), str, ignoreCase: true);

                switch (season)
                {
                    case Seasons.Зима:
                        Console.WriteLine("Праздники в данный промежуток: \nНовый год (31.12) \nРождество (07.01) \nДень защитника отечества (23.02) \nМасленица (28.02 - 06.03)");
                        break;
                    case Seasons.Весна:
                        Console.WriteLine("Праздники в данный промежуток: \n Международный женский день (08.03) \nПасха (24.04) \nДень труда (01.05) \nДень Победы (09.05)");
                        break;
                    case Seasons.Лето:
                        Console.WriteLine("Праздники в данный промежуток: \n Мой день рождения (03.08) \nДень России (12.06)");
                        break;
                    case Seasons.Осень:
                        Console.WriteLine("Праздники в данный промежуток: \n Восшествие на престол Е. И. В. Государя Императора Николая Александровича (20.10) \nДень народного единства (04.11)");
                        break;
                    default:
                        break;
                }
            }
            else
                Console.WriteLine("Неверное значени");
        }
    }
}
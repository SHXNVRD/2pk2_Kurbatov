namespace pz_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TRAIN[] RASP = new TRAIN[4];

            for (int i = 0; i < RASP.Length; i++)
            {
                Console.Write("Введите пункт: ");
                string destination = Console.ReadLine();
                Console.Write("Введите номер поезда: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите время отправления: ");
                string time = Console.ReadLine();

                TRAIN train = new TRAIN(destination, number, time);
                RASP[i] = train;                
            }

            //Сортировка
            var RASPSORT = RASP.OrderBy(x => x.NAZN).ToArray();

            Console.Write("Введите время отправления: ");
            DateTime afterTime = DateTime.Parse(Console.ReadLine());

            for (int i = 0; i < RASPSORT.Length; i++)
            {
                if (RASPSORT[i].TIME > afterTime) RASPSORT[i].Print();
            }
        }
    }

    struct TRAIN
    {
        public string NAZN { get; set; }
        public int NUMR { get; set; }
        public DateTime TIME { get; set; }

        public TRAIN(string destination, int number, string time)
        {
            NAZN = destination;
            NUMR = number;
            TIME = DateTime.Parse(time);
        }

        public void Print()
        {
            Console.WriteLine($"Пункт назначение: {NAZN} \nНомер поезда: {NUMR} \nВремя отправления: {TIME}");
        }
    }
}
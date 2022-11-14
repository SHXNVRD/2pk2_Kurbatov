namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение: ");
            string str = Console.ReadLine();
            string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] value = new int[3];
            int i = 0;
            int action;
            foreach (string x in strArray)
            {
                string count = x;
                char[] chr = count.ToCharArray();
                foreach (char h in chr)
                {
                    if (char.IsDigit(h) == true)
                    {
                        value[i++] = Convert.ToInt32(h);
                    }
                }
            }

            switch (str[1])
            {
                case '+':
                    if (str[3] == '+')
                    {
                        action = value[0] + value[2] + value[4];
                        Console.WriteLine(action);
                    }
                    else
                    {
                        action = value[0] - value[2] - value[4];
                        Console.WriteLine(action);
                    }
                    break;

                    case '-':
                    if (str[3] == '+')
                    {
                        action = value[0] - value[2] + value[4];
                        Console.WriteLine(action);
                    }
                    else
                    {
                        action = value[0] - value[2] - value[4];
                        Console.WriteLine(action);
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
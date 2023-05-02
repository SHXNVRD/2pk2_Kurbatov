using System.Threading.Channels;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                string name = "Tom" + i;
                Client client = new Client(name);

                client.Limit += delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
            }            
        }
    }
}
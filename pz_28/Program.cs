using System.Threading.Channels;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client.Limit += delegate (string mes)
            {
                Console.WriteLine(mes);
            };

            Client client1 = new Client("Tom");
            Console.WriteLine(client1);
            Client client2 = new Client("Tom2");
            Console.WriteLine(client1);
            Client client3 = new Client("Tom3");
            Console.WriteLine(client1);
        }
    }
}
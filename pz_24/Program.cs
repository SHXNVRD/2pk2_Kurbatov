using pz_21;
using System.Dynamic;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный экземпляр:");
            DeliveryRequest request = new DeliveryRequest(1, 150, "Улица Пушкина, дом Колотушкина", "2023.02.18");
            RejectedDelivery rejected = new RejectedDelivery(request);
            rejected.GetDeliveryInfo();
            Console.WriteLine(rejected.GetHashCode());

            Console.WriteLine();

            Console.WriteLine("Клонированный экземпляр:");
            RejectedDelivery rejected1 = (RejectedDelivery)rejected.Clone();
            rejected1.GetDeliveryInfo();
            Console.WriteLine(rejected1.GetHashCode());

            Console.WriteLine();
            
            Console.WriteLine("Клонированный экзмепляр изменённый:");
            RejectedDelivery rejected2 = (RejectedDelivery)rejected.Clone();
            rejected2.ID = 999;
            rejected2.Summ = 777;
            rejected2.RequestTime = DateTime.Parse("2022.03.03");
            rejected2.Reason = "Товар закончился";
            rejected2.GetDeliveryInfo();
            Console.WriteLine(rejected2.GetHashCode());
        }
    }
}
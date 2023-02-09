using pz_21;
using System.Dynamic;
using System.Net.Mail;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryRequest delivery = new DeliveryRequest(4, 12, "dsf", "1.03.2022");
            delivery.GetDeliveryInfo();

            DeliveryRequest delivery1 = new DeliveryRequest(1, 1000000);
            delivery1.GetDeliveryInfo();
            DeliveryRequest.GetAllSumm();

            DeliveryRequest delivery2 = new DeliveryRequest(2, 100);
            delivery2.GetDeliveryInfo();
            DeliveryRequest.GetCountRequest();
            DeliveryRequest.GetAllSumm();


        }
    }
}
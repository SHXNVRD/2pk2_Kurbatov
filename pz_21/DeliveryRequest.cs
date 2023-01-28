using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class DeliveryRequest
    {
        public int ID { get; set; }
        public int Summ { get; set; }
        public string RequestTime { get; set; }
        public string Adr { get; set; }

        public DeliveryRequest() : this(0)
        { }
        public DeliveryRequest(int ID) : this(ID, 0)
        { }
        public DeliveryRequest(int ID, int Summ) : this(ID, Summ, "Неизвестно")
        { }
        public DeliveryRequest(int ID, int Summ, string RequestTime) : this(ID, Summ, RequestTime, "Неизвестно")
        { }
        public DeliveryRequest(int id, int summ, string requestTime, string adr)
        {
            ID = id;
            Summ = summ;
            RequestTime = requestTime;
            Adr = adr;
        }

        public DeliveryRequest(DeliveryRequest deliveryRequest)
        {
            ID = deliveryRequest.ID;
            Summ = deliveryRequest.Summ;
            RequestTime = deliveryRequest.RequestTime;
            Adr = deliveryRequest.Adr;
        }
        public void GetDeliveryInfo() => Console.WriteLine($"ID: {ID}\nСумма: {Summ}\nВремя заказа: {RequestTime}\nАдресс: {Adr}");
    }
}

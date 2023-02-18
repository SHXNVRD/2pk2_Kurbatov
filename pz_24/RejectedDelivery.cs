using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pz_21;

namespace pz_23
{
    internal class RejectedDelivery : DeliveryRequest
    {
        public string Reason { get; set; }

        public RejectedDelivery(DeliveryRequest deliveryRequest, string reason)
        {
            ID = deliveryRequest.ID;
            Summ = deliveryRequest.Summ;
            Adr = deliveryRequest.Adr;
            RequestTime = deliveryRequest.RequestTime;
            Reason = reason;
        }
        public RejectedDelivery(DeliveryRequest deliveryRequest)
        {
            ID = deliveryRequest.ID;
            Summ = deliveryRequest.Summ;
            Adr = deliveryRequest.Adr;
            RequestTime = deliveryRequest.RequestTime;
            Reason = "Причина не указана";
        }
        public override void GetDeliveryInfo() => Console.WriteLine($"ID: {ID}\nСумма: {Summ}\nВремя заказа: {RequestTime}\nАдресс: {Adr}\nПричина отклонения: {Reason}");
    }
}

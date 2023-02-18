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

        public RejectedDelivery(int id, int summ, string adr, string reason) : base(id, summ, adr)
        {
            Reason = reason;
        }

        public RejectedDelivery(int id, int summ, string adr) : base(id, summ, adr)
        {
            Reason = "Пичина не указана";
        }
        public override void GetDeliveryInfo() => Console.WriteLine($"ID: {ID}\nСумма: {Summ}\nВремя заказа: {RequestTime}\nАдресс: {Adr}\nПричина отклонения: {Reason}");
    }
}

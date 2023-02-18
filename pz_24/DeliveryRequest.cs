using pz_24;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class DeliveryRequest : IClonable
    {
        private DateTime dateFrom = new DateTime(2022, 01, 01); // нижняя граница даты заказа
        private static int allSumm;
        private static int countRequest = 0;

        private int id;
        public int ID
        {
            get { return id; }

            set
            {
                if (value != 0)
                    id = value;
                else
                    Console.WriteLine("Значение ID должно быть присвоено!");
            }
        }

        private int summ;
        public int Summ
        {
            get { return summ; }

            set
            {
                if (value >= 0 && value <= 10000)
                    summ = value;
                else
                    Console.WriteLine("Неверная сумма!");
            }
        }

        public string Adr { get; set; }

        private DateTime requestTime;
        public DateTime RequestTime
        {
            get { return requestTime; }

            set
            {
                if (value >= dateFrom && value <= DateTime.Now)
                    requestTime = value;
            }
        }

        public DeliveryRequest() : this(0)
        { }
        public DeliveryRequest(int ID) : this(ID, 0)
        { }
        public DeliveryRequest(int ID, int Summ) : this(ID, Summ, "Неизвестно")
        { }
        public DeliveryRequest(int ID, int Summ, string Adr) : this(ID, Summ, Adr, "01.01.0001")
        { }
        public DeliveryRequest(int id, int summ, string adr, string date)
        {
            ID = id;
            Summ = summ;
            Adr = adr;
            RequestTime = DateTime.Parse(date);
            allSumm += Summ;
            ++countRequest;
        }
        public DeliveryRequest(DeliveryRequest deliveryRequest)
        {
            ID = deliveryRequest.ID;
            Summ = deliveryRequest.Summ;
            Adr = deliveryRequest.Adr;
            RequestTime = deliveryRequest.RequestTime;
            allSumm += Summ;
            ++countRequest;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public virtual void GetDeliveryInfo() => Console.WriteLine($"ID: {ID}\nСумма: {Summ}\nВремя заказа: {RequestTime}\nАдресс: {Adr}");
        public static void GetCountRequest() => Console.WriteLine($"Общее количество заказов: {countRequest}");
        public static void GetAllSumm() => Console.WriteLine($"Общая сумма заказов: {allSumm}");
    }
}
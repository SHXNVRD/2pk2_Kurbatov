namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RejectedDelivery rejected = new RejectedDelivery(123, 10, "Где-то", "Потому что");
            rejected.GetDeliveryInfo();
            RejectedDelivery.GetCountRequest();
            RejectedDelivery.GetAllSumm();

            Console.WriteLine();

            RejectedDelivery rejected1 = new RejectedDelivery(228, 100000000, "Нет");
            rejected1.GetDeliveryInfo();
            RejectedDelivery.GetCountRequest();
            RejectedDelivery.GetAllSumm();
        }
    }
}
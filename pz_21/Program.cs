namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryRequest deliveryRequest = new();

            DeliveryRequest deliveryRequest1 = new()
            {
                ID = 21,
                RequestTime = "16:25"
            };

            DeliveryRequest deliveryRequest2 = new(deliveryRequest1);

            DeliveryRequest deliveryRequest3 = new(999, 270, "16:27", "Улица Пушкина, дом Колотушкина");

            Console.WriteLine($"{deliveryRequest}\n {deliveryRequest1}\n {deliveryRequest2}\n {deliveryRequest3}\n");
        }
    }
}
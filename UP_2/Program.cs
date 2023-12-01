using Microsoft.EntityFrameworkCore;

namespace UP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (OooNanContext db = new OooNanContext())
            {
                /*  Вывести информацию о заказе: дату заказа, которая находится в промежутке от 18.09.2023 до 19.09.2023 вкл.
                 *  Имя клиента, которое содержит в себе "ова", зарплату сотрудника, занимающийся заказом, которая равна 40000 или 35000.
                 *  Сгруппировать по именам сотрудников (EmployeeName), именам клиентов (ClientName), датам заказов (OrderDate) и названиям продуктов (ProductName).
                 *  Группы, у которых количество элементов больше 0, сортируются по дате заказа в порядке убывания.
                */
                Console.WriteLine("Запрос номер 1");

                var query1 = from o in db.Orders
                            join c in db.Clients on o.ClientId equals c.Id
                            join e in db.Employes on o.EmployeId equals e.Id
                            join p in db.Products on o.ProductId equals p.Id
                            where o.Date.Date >= new DateTime(2023, 9, 18) && o.Date.Date <= new DateTime(2023, 9, 19)
                                  && c.Name.Contains("ова")
                                  && (e.Salary == 40000 || e.Salary == 35000)
                            group new { EmployeeName = e.Name, ClientName = c.Name, OrderDate = o.Date, ProductName = p.Title }
                            by new { e.Name, ClientName = c.Name, o.Date, p.Title } into g
                            where g.Count() > 0
                            orderby g.Key.Date descending
                            select new
                            {
                                EmployeeName = g.Select(x => x.EmployeeName).First(),
                                ClientName = g.Select(x => x.ClientName).First(),
                                OrderDate = g.Select(x => x.OrderDate).First(),
                                ProductName = g.Select(x => x.ProductName).First(),
                                OrderCount = g.Count()
                            };

                foreach (var item in query1)
                    Console.WriteLine(item);


                // Вывести список клиентов и их заказов отсортированных по дате заказа:
                Console.WriteLine("Запрос номер 2");

                var query2 = from c in db.Clients
                             join o in db.Orders on c.Id equals o.ClientId
                             orderby o.Date
                             select new
                             {
                                 ClientName = c.Name,
                                 OrderDate = o.Date
                             };

                foreach (var item in query2)
                    Console.WriteLine(item);



                Console.WriteLine("Запрос номер 3");

                    var query3 = from c in db.Clients
                                join o in db.Orders on c.Id equals o.ClientId into orderGroup
                                from og in orderGroup.DefaultIfEmpty()
                                join p in db.Products on og.ProductId equals p.Id into productGroup
                                from pg in productGroup.DefaultIfEmpty()
                                orderby c.Name, og.Date descending
                                select new
                                {
                                    ClientName = c.Name,
                                    ClientPhone = c.Phone,
                                    OrderDate = og.Date,
                                    ProductName = (pg == null) ? "" : pg.Title,
                                    OrderStatus = (og.Id >= 0) ? "Есть заказ" : "Нет заказа"
                                };

                if (query3 != null)
                    Console.WriteLine("Есть заказ");
                else
                    Console.WriteLine("Нет заказа");


                // Вывести даты, которые совпадают с датами поставок
                Console.WriteLine("Запрос номер 4");

                var orderDates = db.Orders.Select(o => o.Date);
                var consignmentDates = db.Consignments.Select(c => c.Date);

                var query4 = orderDates.Intersect(consignmentDates);

                foreach (var item in query4)
                    Console.WriteLine(item);

                
                // Вывести работников, зарплату и их должность, если их зарплата больше 30000
                Console.WriteLine("Запрос номер 5");

                var query5 = from e in db.Employes
                             join j in db.Jobs on e.JobId equals j.Id
                             where e.Salary > 30000
                             select new
                             {
                                 EmployeeName = e.Name,
                                 JobTitle = j.Title,
                                 Salary = e.Salary
                             };

                foreach (var item in query5)
                    Console.WriteLine(item);
            }
        }
    }
}

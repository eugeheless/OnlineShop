using System;
using System.Linq;
using OnlineShop.Domain;
using OnlineShop.Infrastructure;

namespace OnlineShop.Presenter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                //Item sugar = new Item { Name = "Сахар", Cost = 15, Count = 10 };
                //Item salt = new Item { Name = "Соль", Cost = 10, Count = 6 };

                //Cart first = new Cart { Number = 12, Price = 500 };
                //Cart Sec = new Cart { Number = 14, Price = 1300 };

                //Client client1 = new Client { Address = "MOgilev", Name = "Anton", PhoneNumber = 378921, Surname = "Ivanov" };
                //Client client2 = new Client { Address = "Mogilev", Name = "vlad", PhoneNumber = 111225, Surname = "Bumaga" };

                //Order order1 = new Order { ClientID = 1, DoneDate = "12.10.06", OrderDate = "10.10.06" };
                //Order order2 = new Order { ClientID = 2, DoneDate = "12.10.12", OrderDate = "10.10.12" };
                
                //db.Items.AddRange(sugar, salt);
                //db.SaveChanges();

                //db.Carts.AddRange(first,Sec);
                //db.SaveChanges();

                //db.Clients.AddRange(client1, client2);
                //db.SaveChanges();

                //db.Orders.AddRange(order1, order2);
                //db.SaveChanges();

                //Console.WriteLine("Items list");
                //var item = db.Items.ToList();
                //foreach(Item q in item)
                //{
                //    Console.WriteLine($"{q.Id}.{q.Name} = {q.Cost} + {q.Count}");
                //}


                //Console.WriteLine("Clients list");
                //var client = db.Clients.ToList();
                //foreach (Client q in client)
                //{
                //    Console.WriteLine($"{q.Id}.{q.Name}  {q.Surname} = {q.Address} + {q.PhoneNumber}");
                //}

                //Console.WriteLine("Orders list");
                //var order = db.Orders.ToList();
                //foreach (Order q in order)
                //{
                //    Console.WriteLine($"{q.Id} = {q.ClientID} = {q.OrderDate} + {q.DoneDate}");
                //}

                Console.ReadLine();

            }

        }
    }
}

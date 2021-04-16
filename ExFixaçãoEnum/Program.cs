using System;
using ExFixaçãoEnum.Entities;
using ExFixaçãoEnum.Entities.Enums;
using System.Globalization;

namespace ExFixaçãoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            DateTime orderMoment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(date, status);
            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string namep = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product p = new Product(namep, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem product = new OrderItem(p, quantity, price);
                order.AddItem(product);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + orderMoment.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + c1.Name + "(" + c1.BirthDate + ") - " + c1.Email);
            Console.WriteLine(order);






        }
    }
}

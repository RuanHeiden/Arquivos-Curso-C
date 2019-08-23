using System;
using System.Globalization;
using Price.Entities;
using Price.Entities.Enums;

namespace Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Cliente Date ---");
            Console.WriteLine("");

            Console.Write("Your name :");
            string name = Console.ReadLine();
            Console.Write("Your E-mail :");
            string email = Console.ReadLine();
            Console.Write("Birth Date :");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("--- Enter order data ---"); 
            Console.WriteLine("");

            Console.Write("Status :");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("how many items to this order ? :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name : ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("--- ORDER SUMMARY ---");
            Console.WriteLine(order);
        }
    }
}

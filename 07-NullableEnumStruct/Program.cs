namespace _07_NullableEnumStruct
{
    internal class program
    {
        static void Main(string[] args)
        {

            DrinkOrder order1 = new DrinkOrder(
                1,
                "Ali",
                DrinkType.Coffee,
                DrinkSize.Small
            );


            DrinkOrder order2 = new DrinkOrder(
                2,
                "Vuqar",
                DrinkType.Juice,
                DrinkSize.Medium
            );


            DrinkOrder order3 = new DrinkOrder(
                3,
                "Nicat",
                DrinkType.Water,
                DrinkSize.Large
            );


            DrinkOrder order4 = new DrinkOrder(
                4,
                "Leyla",
                DrinkType.Tea,
                DrinkSize.Medium
            );




            order1.Status = OrderStatus.Preparing;
            order2.Status = OrderStatus.Ready;

            Console.WriteLine("Status deyisenden sonra");
            PrintOrder(order1);
            PrintOrder(order2);
            PrintOrder(order3);
            PrintOrder(order4);

        }

        static void PrintOrder(DrinkOrder order)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Order Number: " + order.OrderNumber);
            Console.WriteLine("Customer Name: " + order.CustomerName);
            Console.WriteLine("Drink Type: " + order.Drink);
            Console.WriteLine("Drink Size: " + order.Size);
            Console.WriteLine("Status: " + order.Status);
            Console.WriteLine("Price: " + order.Price);
        }
    }
}
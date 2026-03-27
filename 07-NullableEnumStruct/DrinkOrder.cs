using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullableEnumStruct
{
    enum DrinkType
    {
        Coffee,
        Juice,
        Water,
        Tea
    }
    enum DrinkSize
    {
        Medium,
        Small,
        Large
    }
    enum  OrderStatus {

        New,
        Preparing,
        Ready,
        Delivered
    }
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

    public DrinkOrder (int orderNumber, string customerName, DrinkType drink, DrinkSize size)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        Drink = drink;
        Size = size;
        Status = OrderStatus.New;
        Price = CalculatePrice();
    }
    public decimal CalculatePrice ()
    {
        if (Drink == DrinkType.Coffee)

        {
            if (Size == DrinkSize.Small)
                return 3;
            else if (Size == DrinkSize.Medium)
                return 4;
            else if (Size == DrinkSize.Large)
                return 5;
        }
        else if (Drink == DrinkType.Juice)
        {
            if (Size == DrinkSize.Small)
                return 4;
            else if (Size == DrinkSize.Medium)
                return 5;
            else if (Size == DrinkSize.Large)
                return 6;
        }
        else if (Drink == DrinkType.Water)
        {
            if (Size == DrinkSize.Small)
                return 1;
            else if (Size == DrinkSize.Medium)
                return 1.5m;
            else if (Size == DrinkSize.Large)
                return 2;
        }
            else if (Drink == DrinkType.Tea)
            {
                if (Size == DrinkSize.Small)
                    return 2;
                else if (Size == DrinkSize.Medium)
                    return 3;
                else if (Size == DrinkSize.Large)
                    return 4;
            }
            return 0;
        }
    }
    
}

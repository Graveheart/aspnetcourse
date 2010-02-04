using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQDesigner;

namespace ReadingFromMultipleTables
{
    class ReadingFromMultipleTables
    {
        static void Main(string[] args)
        {
            NorthwindDataContext context = new NorthwindDataContext();
            
            //enable readonly mode
            context.ObjectTrackingEnabled = false;

            var orders = from o in context.Orders
                         where o.Customer.Country == "UK"
                         select o;

            foreach (var item in orders)
            {
                Console.WriteLine("Order Dates To UK: " + item.OrderDate.Value.ToShortDateString());
            }
        }
    }
}

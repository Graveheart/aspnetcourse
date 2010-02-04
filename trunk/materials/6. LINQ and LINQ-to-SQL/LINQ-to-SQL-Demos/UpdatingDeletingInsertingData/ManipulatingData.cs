using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQDesigner;

namespace UpdatingDeletingInsertingData
{
    class ManipulatingData
    {
        static void Main(string[] args)
        {
            NorthwindDataContext context = new NorthwindDataContext();

            //create new order object
            Order customOrder = new Order()
            {
                OrderDate = DateTime.Now,
                ShipName = "Titanic",
                ShippedDate = new DateTime(1912, 4, 15),
                ShipCity = "Bottom Of The Ocean"
            };

            //mark to be insert on the next submit
            context.Orders.InsertOnSubmit(customOrder);
            context.SubmitChanges();
            
            Order order = context.Orders.First();
            //modify object properties
            order.OrderDate = DateTime.Now;
            context.SubmitChanges();

            //mark for delete on the next sumbit
            context.Orders.DeleteOnSubmit(order);
            context.SubmitChanges();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQDesigner;

namespace ExecuteSQLQuery
{
    class ExecuteSQLQuery
    {
        static void Main(string[] args)
        {
            NorthwindDataContext context = new NorthwindDataContext();
            var customers = context
                .ExecuteQuery<Customer>("select * from Customers where City='London'");
            foreach (var item in customers)
                Console.WriteLine(
                    String.Format("Company:{0}, Phone:{1}",
                    item.CompanyName, item.Phone));
        }
    }
}

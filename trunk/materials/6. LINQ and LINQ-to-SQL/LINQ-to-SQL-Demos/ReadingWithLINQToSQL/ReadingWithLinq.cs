using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQDesigner;


namespace UsingLINQDesigner
{
    class ReadingWithLinq
    {
        static void Main(string[] args)
        {
            NorthwindDataContext db = new NorthwindDataContext();

            //Used to attach logs to console
            Logger.SetLogToConsole(db);

            IQueryable customers = from c in db.Customers
                            where c.City=="London"
                            select c;

            Console.WriteLine("QUERY HERE IS NOT YET GENERATED AND EXECUTED\n");
            foreach (var item in customers)
                Console.WriteLine(
                    String.Format("Company:{0}, Phone:{1}",
                    item.CompanyName,item.Phone));

         
        }
    }
}

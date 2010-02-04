using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDesigner
{
    public class Logger
    {
        public static void SetLogToConsole(NorthwindDataContext db)
        {
            db.Log = Console.Out;
        }
    }
}

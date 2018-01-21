using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.DI.Log
{
    public class EmailLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Sending email with message [{message}]");
        }
    }

}

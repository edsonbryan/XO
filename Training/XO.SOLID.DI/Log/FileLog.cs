using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.DI.Log
{
    public class FileLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Saving file with message [{message}]");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.SOLID.DI
{
    public class Manager
    {
        public void Run(ILogger logger)
        {
            logger.Log("start");

            logger.Log("running process");

            logger.Log("end");
        }
    }
}

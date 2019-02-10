using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicInterfaceLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerInterface log = ILoggerFactoryClass.GetLogger();

            log.WriteToLog("Hello World");
        }
    }
}

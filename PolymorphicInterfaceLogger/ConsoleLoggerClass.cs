using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicInterfaceLogger
{
    class ConsoleLoggerClass : ILoggerInterface //implemented interface
    {
        public void WriteToLog(string cmessage) //must provide all methods from the interface
        {
            Console.WriteLine(cmessage);
        }
    }
}

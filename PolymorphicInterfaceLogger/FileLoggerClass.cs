using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input output for file access

namespace PolymorphicInterfaceLogger
{
    class FileLoggerClass : ILoggerInterface //implemented interface
    {
        public void WriteToLog(string fmessage)
        {
            var fileWriter = File.AppendText("log.txt"); //no path, so it will go into the bin dir, or where the app is running from
            fileWriter.WriteLine(fmessage);
            fileWriter.Close(); //need to close file
        }
    }
}

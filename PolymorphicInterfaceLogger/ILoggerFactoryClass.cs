using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //added reference

namespace PolymorphicInterfaceLogger
{
    static class ILoggerFactoryClass //a factory class job is to create new objects of a certain type, that satisfy a certain interface
    {
        private static ILoggerInterface _myLogger; //the type is-a iloggerinterface

        public static ILoggerInterface GetLogger()
        {
            if(_myLogger == null) //value will be read from app.config
            {
                string logType = ConfigurationManager.AppSettings["logtype"];

                if(logType == "C")
                {
                    _myLogger = new ConsoleLoggerClass(); //mylogger is a type of ilogger, consolelogger is a ilogger (Polymorphism)
                }
                else if(logType == "F")
                {
                    _myLogger = new FileLoggerClass();
                }
            }
            return _myLogger;
        }
    }
}
//if youre reading something from the config file you need to add a reference to system.config namespace

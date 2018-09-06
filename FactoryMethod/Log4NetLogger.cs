using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Log4NetLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log4Net : {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Log4Net Error : {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MyLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"MyLogger : {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"MyLogger Error : {message}");
        }
    }
}

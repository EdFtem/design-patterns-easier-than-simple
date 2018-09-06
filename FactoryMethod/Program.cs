using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerProviderFactory.GetLoggerProvider(LoggerType.Log4Net);
            logger.LogMessage("Test 1");
            logger.LogMessage("Test 2");
            logger = LoggerProviderFactory.GetLoggerProvider(LoggerType.MyLogger);
            logger.LogMessage("Test 3");
            logger.LogMessage("Test 4");
            Console.ReadKey();
        }
    }
}

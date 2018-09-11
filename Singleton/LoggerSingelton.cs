using System;

namespace Singleton
{
    class LoggerSingelton
    {
        private static LoggerSingelton _loggerSingelton = null;

        public static LoggerSingelton GetInstance()
        {
            if (_loggerSingelton == null)
            {
                _loggerSingelton = new LoggerSingelton();
            }

            return _loggerSingelton;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

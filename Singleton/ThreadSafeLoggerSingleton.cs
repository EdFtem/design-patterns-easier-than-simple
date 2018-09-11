using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ThreadSafeLoggerSingleton
    {
        private static ThreadSafeLoggerSingleton _threadSafeLoggerSingleton = null;
        private static readonly object locker = new object();

        public static ThreadSafeLoggerSingleton GetInstance()
        {
            lock (locker)
            {
                if (_threadSafeLoggerSingleton == null)
                {
                    _threadSafeLoggerSingleton = new ThreadSafeLoggerSingleton();
                }             
            }

            return _threadSafeLoggerSingleton;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

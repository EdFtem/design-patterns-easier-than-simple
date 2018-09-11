using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DoHardWork doHardWork = new DoHardWork();
            LoggerSingelton.GetInstance().Log("Start easy work !");
            doHardWork.EasyWork();
            LoggerSingelton.GetInstance().Log("Start hard work !");
            doHardWork.HardWork();
            ThreadSafeLoggerSingleton.GetInstance().Log("Thread Safe Logger !");
            Console.ReadKey();
        }
    }
}

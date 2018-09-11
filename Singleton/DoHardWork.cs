using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class DoHardWork
    {
        public void HardWork()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = i;
                LoggerSingelton.GetInstance().Log($"Iteration {++t}");
            }
        }

        public void EasyWork()
        {
            for (int i = 0; i < 5; i++)
            {
                var t = i;
                LoggerSingelton.GetInstance().Log($"EasyWork iteration {++t}");
            }
        }
    }
}

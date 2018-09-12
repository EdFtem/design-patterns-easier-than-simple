using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : INewElectricitySystem
    {
        private OldElectricitySystem _oldElectricitySystem;
        public Adapter(OldElectricitySystem oldElectricitySystem)
        {
            _oldElectricitySystem = oldElectricitySystem;
        }

        public string MatchWideSocket()
        {
            return _oldElectricitySystem.MatchThinSocket();
        }
    }
}

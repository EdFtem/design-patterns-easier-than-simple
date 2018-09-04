using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Toys;

namespace AbstractFactory.Factory
{
    public interface IToyFactory
    {
        Bear GetBear();
        Cat GetCat();
    }
}

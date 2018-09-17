using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.BodyParts
{
    public class Ear : BodyPart
    {
        private string _sounds = string.Empty;

        public Ear(Brain brain) : base(brain)
        {
        }

        public void HearSomething()
        {
            Console.WriteLine("Enter what you hear:");
            _sounds = Console.ReadLine();
            Change();
        }

        public string GetSounds()
        {
            return _sounds;
        }
    }
}

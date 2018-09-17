using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.BodyParts
{
    public class Face : BodyPart
    {
        public Face(Brain brain) : base(brain)
        {
        }

        public void Smile()
        {
            Console.WriteLine("FACE: Smiling...");
        }
    }
}

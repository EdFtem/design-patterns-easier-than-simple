using System;
using System.Collections.Generic;
using System.Text;
using Mediator.BodyParts;

namespace Mediator
{
    public class Brain
    {
        public Ear Ear { get; private set; }
        public Face Face { get; private set; }

        public Brain()
        {
            CreateBodyParts();
        }

        private void CreateBodyParts()
        {
            Ear = new Ear(this);
            Face = new Face(this);
        }

        public void SomethingHappenedToBodyPart(BodyPart bodyPart)
        {
            if (bodyPart is Ear)
            {
                string sounds = ((Ear) bodyPart).GetSounds();
                if (sounds.Contains("stupid"))
                {
                    Face.Smile();
                }
                else
                {
                    Face.Smile();
                    Face.Smile();
                }
            }
        }
    }
}

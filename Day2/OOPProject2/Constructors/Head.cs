using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject2.Constructors
{
    public class Head
    {
        //Composition
        public Eyes eyes;
        public Ear ear;
        public Nose nose;

        public Head(Nose nose, Ear ear, Eyes eyes)
        {
            this.nose = nose;
            this.ear = ear;
            this.eyes = eyes;
        }
    }
}

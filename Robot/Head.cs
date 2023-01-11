using System;
using System.Collections.Generic;

namespace Robot
{
    internal class Head
    {
        public Face Face { get; set; }
        public Hair Hair { get; set; }
        public Neck Neck { get; set; }
        public List<Ear> Ears { get; set; }
        public Head()
        {
        }
        public bool HasHair()
        {
            return true;
        }

        public bool HasFace()
        {
            return true;
        }

        public bool HasEars()
        {
            return true;
        }

        public bool HasNeck()
        {
            return true;
        }
        public void SwingHead()
        {

        }
    }
}
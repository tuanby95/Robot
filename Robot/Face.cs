using System;
using System.Collections.Generic;

namespace Robot
{
    internal class Face
    {
        public Mouth Mouth { get; set; }
        public List<Eye> Eyes { get; set; }
        
        public Face()
        {
        }


        public List<Eye> _eyes = new List<Eye>();
        
        public Eye _eye = new Eye(10, 10, "side", "white");
        
        public Eye GetEyes()
        {
            return _eye;
        }

        public bool HasMouth()
        {
            return true;
        }

        public bool HasEyes()
        {
            return (Eyes.Count > 1);
        }
        public void AddEye(Eye eye)
        {
            _eyes.Add(eye);
        }
        public Eye GetEye()
        {
            return _eye;
        }
        internal Eye OpenEye(string side)
        {
            this._eye.Side = side;
            this._eye.Height = 100;
            this._eye.Width = 100;
            this._eye.Color = "Red";
            return _eye;
        }
    }
}
using System.Collections.Generic;

namespace Robot
{
    public class Eye : BaseRobot
    {
        private Eyeball Eyeball { get; set; }
        private Eyelid Eyelid { get; set; }
        private Pupil Pupil { get; set; }
        private string Side { get; set; }

        public Eye() { }
        public Eye(int height, int width, string side, string color)
        {
            this.Side = side;
            this.Height = height;
            this.Width = width;
            this.Color = color;
        }

        public Eye GetEye()
        {
            return _eye;
        }
    }
}
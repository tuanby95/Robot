using System;

namespace Robot
{
    public class Leg
    {
        private Foot Foot { get; set; }
        public bool HadKickedFlag { get; set; }
        public Leg()
        {

        }
        public void KickLeg(string side, int x, int y)
        {
            this.Foot = new Foot();
            this.Foot.side = side;
            this.Foot.X = x;
            this.Foot.Y = y;
        }

        internal bool HadKicked(string side, int x, int y)
        {

            bool temp = (this.Foot.side == side && this.Foot.X == x && this.Foot.Y == y);
            if (temp) { SetLegLocationInternal(0,0); return true; }
            return false;
        }
        private void SetLegLocationInternal(int x, int y)
        {
            this.Foot.X = x; this.Foot.Y = y;
        }
        public void SetLegLocation()
        {
            if (HadKickedFlag)
            {
                SetLegLocationInternal(0,0);
            }
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInformation
{
    class Ball
    {
        public int radius;
        public bool popped = false;
        public int numbounces;

        public Ball(int radius, int numbounces, bool popped)
        {
            this.radius = radius;
            this.popped = popped;
            this.numbounces = numbounces;
        }

        public void SetBallInfo(int radius, int numbounces, bool popped)
        {
            this.radius = radius;
            this.popped = popped;
            this.numbounces = numbounces;
            if (this.popped == true) Poppedball(true);
        }

        public int BounceBall(int times)
        {
            if (popped) return 0;
            this.numbounces = times;
            return numbounces;
        }
        public void Poppedball(bool popped)
        {
            radius = 0;

        }
        public int GetBallRadius()
        {
            return this.radius;
        }
        public int GetBallBounceTimes()
        {
            return this.numbounces;
        }
        public bool GetIsBallPopped()
        {
            return this.popped;
        }

    }
}

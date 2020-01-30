using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolakPetersFlyingAdventure
{
    class BlackBird : Bird, IBirdCanFly
    {
        public override string Draw()
        {
            return "Km per hour " + SetLocation(25,25).ToString() + " " + Fly();
        }

        public string Fly()
        {
            //Here we fly
            return "Here we fly";
        }


        public override double SetLocation(double longitude, double latitude)
        {
            double x = longitude;
            double z = latitude;
            double d = x + z;
            double v = d / 1;
            return v;
        }
    }
}

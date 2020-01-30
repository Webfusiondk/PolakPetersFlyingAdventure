using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolakPetersFlyingAdventure
{
    class KiwiBird : Bird
    {
        public override string Draw()
        {
           return "Km per hour " + SetLocation(25, 25).ToString();
        }

        public override double SetLocation(double longitude, double latitude)
        {
            double x = longitude;
            double z = latitude;
            double d = x + z;
            double v = d / 3;
            return v;

        }
    }
}

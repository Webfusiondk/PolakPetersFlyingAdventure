using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolakPetersFlyingAdventure
{
    abstract class Bird
    {
        public abstract double SetLocation(double longitude, double latitude);
        public abstract string Draw();
    }
}

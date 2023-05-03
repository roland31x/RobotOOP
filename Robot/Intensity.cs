using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public struct Intensity
    {
        public static Intensity InstantKill = new Intensity(double.PositiveInfinity);
        public double Damage { get; private set; }
        public Intensity(double damage) { Damage = damage;}
    }
}

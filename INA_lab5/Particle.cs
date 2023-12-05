using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab5
{
    internal class Particle
    {
        internal double Position { get; set; }
        internal double Speed { get; set; }
        internal double BestOfParticle { get; set; }
        internal static double BestOfNeighbors { get; set; }
        internal double Fx { get; set; }
    }
}

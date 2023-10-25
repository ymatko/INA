using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA
{
    internal class DataGrid
    {
        public static Random rand = new Random();
        public double LP { get; set; }
        public double truexReal { get; set; }
        public double xReal { get; set; }
        public double FxReal { get; set; }
        public double GxReal { get; set; }
        public double PixReal { get; set; }

        public DataGrid(double a, double b, long lp, int l, double d, double pk, double pm)
        {
            LP = lp;
            int accuracy = 0;
            switch (d)
            {
                case 0.1:
                    accuracy = 1;
                    break;
                case 0.01:
                    accuracy = 2;
                    break;
                case 0.001:
                    accuracy = 3;
                    break;
            }
            truexReal = rand.NextDouble() * (b - a) + a;
            xReal = Math.Round(truexReal, accuracy);
            FxReal = (xReal % 1.0) * (Math.Cos(20.0 + Math.PI + xReal)) - Math.Sin(xReal);
        }
    }
}

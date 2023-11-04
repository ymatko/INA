using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab_1
{
    internal class DataGrid
    {
        internal static Random Random = new Random();

        internal double LP { get; set; }
        internal double truexReal { get; set; }
        internal double xReal { get; set; }
        internal long xInt_xReal { get; set; }
        internal string xBin_xInt { get; set; }
        internal long xInt_xBin { get; set; }
        internal double xReal_xInt { get; set; }
        internal double truexReal_xInt { get; set; }
        internal double FxReal { get; set; }

        internal DataGrid(double a, double b, long lp, int l, double d)
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
                case 0.0001:
                    accuracy = 4;
                    break;
            }
            truexReal = Random.NextDouble() * (b - a) + a;
            xReal = Math.Round(truexReal, accuracy);
            xInt_xReal = (long)Math.Round((1.0 / (b - a)) * (xReal - a) * ((Math.Pow(2.0, l)) - 1.0));
            xBin_xInt = Convert.ToString(xInt_xReal, 2).PadLeft(l, '0');
            xInt_xBin = Convert.ToInt64(xBin_xInt, 2);
            truexReal_xInt = ((b - a) * xInt_xBin) / (Math.Pow(2.0, l) - 1.0) + a;
            xReal_xInt = Math.Round(truexReal_xInt, accuracy);
            FxReal = (xReal % 1.0) * (Math.Cos(20.0 + Math.PI + xReal)) - Math.Sin(xReal);
        }
    }
}

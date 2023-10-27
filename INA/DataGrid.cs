using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA
{
    internal class DataGrid
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _lp { get; set; }
        private int _l { get; set; }
        private double _d { get; set; }
        private double _pk { get; set; }
        private double _pm { get; set; }
        public static Random rand = new Random();
        public double LP { get; set; }
        public double truexReal { get; set; }
        public double xReal { get; set; }
        public double FxReal { get; set; }
        public double GxReal { get; set; }
        public double PixReal { get; set; }
        public double Distributor { get; set; }
        public bool isParent { get; set; }
        public double IsSelected { get; set; }
        public double r { get; set; }

        public DataGrid(double a, double b, long lp, int l, double d, double pk, double pm)
        {
            _a = a;
            _b = b;
            _lp = lp;
            _l = l;
            _d = d;
            _pk = pk;
            _pm = pm;
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
        public string GetBin(double value)
        {
            long xInt_xReal = (long)Math.Round((1.0 / (_b - _a)) * (value - _a) * ((Math.Pow(2.0, _l)) - 1.0));
             return Convert.ToString(xInt_xReal, 2).PadLeft(_l, '0');
        }
    }
}

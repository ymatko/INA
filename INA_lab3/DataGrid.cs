using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab3
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
        internal static Random rand = new Random();
        internal double LP { get; set; }
        internal double truexReal { get; set; }
        internal double xReal { get; set; }
        internal double FxReal { get; set; }
        internal double GxReal { get; set; }
        internal double PixReal { get; set; }
        internal double Distributor { get; set; }
        internal bool isParent { get; set; }
        internal double IsSelected { get; set; }
        internal double r { get; set; }
        internal int CuttingPoint { get; set; }
        internal string AfterCrossover { get; set; }
        internal string Mutations { get; set; }
        internal string AfterMutation { get; set; }
        internal double NewxReal { get; set; }
        internal double NewFxReal { get; set; }

        internal DataGrid(double a, double b, long lp, int l, double d, double pk, double pm)
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

        internal DataGrid(DataGrid other)
        {
            this.FxReal = other.FxReal;
            this.xReal = other.xReal;
        }
        internal string GetBin(double value)
        {
            long xInt_xReal = (long)Math.Round((1.0 / (_b - _a)) * (value - _a) * ((Math.Pow(2.0, _l)) - 1.0));
             return Convert.ToString(xInt_xReal, 2).PadLeft(_l, '0');
        }
        internal void GetNewReal()
        {
            double xInt_xBin = Convert.ToInt64(AfterMutation, 2);
            NewxReal = ((_b - _a) * xInt_xBin) / (Math.Pow(2.0, _l) - 1.0) + _a;
        }

        internal void GetNewFxReal()
        {
            NewFxReal = (NewxReal % 1.0) * (Math.Cos(20.0 + Math.PI + NewxReal)) - Math.Sin(NewxReal);
        }
    }
}

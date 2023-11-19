using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab4
{
    internal class MainObject
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _d { get; set; }
        private double _t { get; set; }
        private double _xReal { get; set; }
        private double _FxReal { get; set; }
        private int _accuracy { get; set; }

        internal MainObject(double a, double b, double d, double t)
        {
            _a = a;
            _b = b;
            _t = t;
            switch (d)
            {
                case 0.1:
                    _accuracy = 1;
                    break;
                case 0.01:
                    _accuracy = 2;
                    break;
                case 0.001:
                    _accuracy = 3;
                    break;
                case 0.0001:
                    _accuracy = 4;
                    break;
            }
        }
    }
}

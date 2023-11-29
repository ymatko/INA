using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab4
{
    internal class ObjForTest
    {
        internal int Distributor { get; set; }
        internal int T { get; set; }
        internal double Percent { get; set; }
        private double _a { get; set; }
        private double _b { get; set; }
        private double _d { get; set; }
        private double _t { get; set; }
        internal double _xReal { get; set; }
        internal double _FxReal { get; set; }
        private int _accuracy { get; set; }
        internal string _xBin { get; set; }

        internal ObjForTest(double a, double b, double d)
        {
            _a = a;
            _b = b;
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
        internal ObjForTest()
        {

        }


        internal List<string> GetDescendants()
        {
            var result = new List<string>();
            for (int i = 0; i < _xBin.Length; i++)
            {
                var newxBin = new StringBuilder(_xBin);
                if (newxBin[i] == '1')
                    newxBin[i] = '0';
                else
                    newxBin[i] = '1';
                result.Add(newxBin.ToString());
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab4
{
    internal static class RandBin
    {
        internal static string GetValue(double a, double b, double d)
        {
            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);
            var result = new StringBuilder();
            var rand = new Random();
            for(int i = 1; i < l; i++)
            {
                result.Append(rand.Next(2));
            }
            return result.ToString();
        }
    }
}

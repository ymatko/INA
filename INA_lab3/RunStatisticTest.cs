using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INA_lab3
{
    internal class RunStatisticTest
    {
        public int N { get; set; }
        public int T { get; set; }
        public double Pk { get; set; }
        public double Pm { get; set; }
        public double Fx { get; set; }

        internal void ViewData(DataGridView dataGridView)
        {
            dataGridView.Rows.Add(N, Pk, Pm, T, Fx) ;
        }
    }
}

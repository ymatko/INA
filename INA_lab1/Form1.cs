using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INA_lab_1
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("N", "N");
            dataGridView1.Columns.Add("Xreal", "X Real");
            dataGridView1.Columns.Add("Xint", "X Int");
            dataGridView1.Columns.Add("Xbin", "X Bin");
            dataGridView1.Columns.Add("Xint", "X Int");
            dataGridView1.Columns.Add("Xreal", "X Real");
            dataGridView1.Columns.Add("Fx", "F(x)");
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double a = Convert.ToDouble(TbA.Text);
            double b = Convert.ToDouble(TbB.Text);
            double d = Convert.ToDouble(CbD.Text);
            int n = Convert.ToInt32(TbN.Text);

            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);

            DataGrid[] generation = new DataGrid[n];
            for (int i = 1; i <= n; i++)
            {
                var dataGrid = new DataGrid(a, b, i + 1, l, d);
                dataGridView1.Rows.Add(i, dataGrid.xReal, dataGrid.xInt_xBin, dataGrid.xBin_xInt, dataGrid.xInt_xReal, dataGrid.xReal_xInt, dataGrid.FxReal);
            }
        }
    }
}

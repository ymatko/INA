using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INA_lab4
{
    public partial class TestForm : Form
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _d { get; set; }
        private int M = 1000;
        public TestForm(string xReal, string xBin, string FxReal, double a, double b, double d)
        {
            InitializeComponent();
            tbBestXreal.Text = xReal;
            tbBestXbin.Text = xBin;
            tbBestFxReal.Text = FxReal;
            _a = a;
            _b = b;
            _d = d;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<ObjForTest> list = await Calculate();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                    list[0].Distributor = list[0].CountOfT;
                else
                    list[i].Distributor = list[i - 1].Distributor + list[i].CountOfT;
            }
            int totalCount = list.Sum(obj => obj.CountOfT);

            foreach (var obj in list)
            {
                obj.Percent = Math.Round((double)obj.Distributor / M * 100.0, 2);
            }


            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add(i+1, list[i].CountOfT, list[i].Distributor, list[i].Percent);
            }
        }
        private async Task<List<ObjForTest>> Calculate()
        {
            List<ObjForTest> listOfObj = new List<ObjForTest>();
            
            for(int i = 0; i < 100; i++)
            {
                ObjForTest obj = new ObjForTest(_a, _b, _d);
                for(int j = 0; j < M; j++)
                {
                    obj._xBin = RandBin.GetValue(_a, _b, _d);
                    var childrenOfObj = obj.GetDescendants();
                    for (int k = 0; k < childrenOfObj.Count; k++)
                    {
                        string str = childrenOfObj[k];

                        if (GetFx(GetxReal(obj._xBin)) < GetFx(GetxReal(str)))
                        {
                            obj._xBin = str;
                        }
                        if (obj._xBin == tbBestXbin.Text)
                        {
                            obj.CountOfT = j;
                            
                        }
                    }
                }
                listOfObj.Add(obj);
            }

            return listOfObj;
        }
        internal double GetxReal(string xBin)
        {
            int l = (int)Math.Floor(Math.Log((_b - _a) / _d, 2) + 1.0);
            long xInt_xBin = Convert.ToInt64(xBin, 2);
            return ((_b - _a) * xInt_xBin) / (Math.Pow(2.0, l) - 1.0) + _a;
        }

        internal double GetFx(double xReal)
        {
            return (xReal % 1.0) * (Math.Cos(20.0 + Math.PI + xReal)) - Math.Sin(xReal);
        }
    }
}

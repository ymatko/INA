namespace INA_lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int _t { get; set; }
        private double _a { get; set; }
        private double _b { get; set; }
        private double _d { get; set; }

        private void btnTests_Click(object sender, EventArgs e)
        {
            var form = new TestForm();
            btnTests.Enabled = false;
            form.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            _t = Convert.ToInt32(tbT.Text);
            _a = Convert.ToDouble(tbA.Text);
            _b = Convert.ToDouble(tbB.Text);
            _d = Convert.ToDouble(cbD.Text);
            var newList = Calculate();
            dataGridView1.Rows.Clear();
            SetTable(newList);
            SetBest(newList);
            //UpdatePlotView(newList);
        }

        private void SetBest(List<string> newList)
        {
            tbBestXreal.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            tbBestXbin.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            tbBestFxReal.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        private List<string> Calculate()
        {
            List<string> newObj = new List<string>();
            formsPlot1.Plot.Clear();
            for (int i = 0; i < _t; i++)
            {
                MainObject obj = new MainObject(_a, _b, _d);
                obj._xBin = RandBin.GetValue(_a, _b, _d);
                var listOfobj = obj.GetDescendants();
                for (int j = 0; j < listOfobj.Count; j++)
                {
                    
                    string str = listOfobj[j];
                    if (GetFx(GetxReal(obj._xBin)) < GetFx(GetxReal(str)))
                    {
                        obj._xBin = str;
                        //double s = GetFx(GetxReal(str));
                        formsPlot1.Plot.AddPoint(i, j);
                    }
                }
                newObj.Add(obj._xBin);
            }
            formsPlot1.Plot.Legend();
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();

            return newObj;
        }

        private void UpdatePlotView(List<string> list)
        {
            int runCount = list.Count;
            double[] runIndices = Enumerable.Range(1, runCount).Select(i => (double)i).ToArray();
            double[] values = list.Select(i => GetFx(GetxReal(i))).ToArray();

            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(runIndices, values, label: "Max");

            formsPlot1.Plot.Legend();
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
        }

        private void SetTable(List<string> list)
        {
            foreach (string obj in list)
            {
                dataGridView1.Rows.Add(GetxReal(obj), obj, GetFx(GetxReal(obj)));
            }
            dataGridView1.Sort(dataGridView1.Columns["FxReal"], System.ComponentModel.ListSortDirection.Descending);
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
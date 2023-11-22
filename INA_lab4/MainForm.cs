namespace INA_lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            var form = new TestForm();
            btnTests.Enabled = false;
            form.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(tbT.Text);
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double d = Convert.ToDouble(cbD.Text);
            var newList = Calculate(t, a, b, d);
            dataGridView1.Rows.Clear();
            SetTable(newList, a, b, d);
            SetBest(newList);
        }

        private void SetBest(List<string> newList)
        {
            tbBestXreal.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            tbBestXbin.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            tbBestFxReal.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        private List<string> Calculate(int t, double a, double b, double d)
        {
            List<string> newObj = new List<string>();
            for (int i = 0; i < t; i++)
            {
                MainObject obj = new MainObject(a, b, d);
                obj._xBin = RandBin.GetValue(a, b, d);
                var listOfobj = obj.GetDescendants();
                bool local = false;
                foreach (string str in listOfobj)
                {
                    if (GetFx(GetxReal(obj._xBin, a, b, d)) < GetFx(GetxReal(str, a, b, d)))
                    {
                        obj._xBin = str;
                    }
                }
                newObj.Add(obj._xBin);
            }
            return newObj;
        }

        private void SetTable(List<string> list, double a, double b, double d)
        {
            foreach (string obj in list)
            {
                dataGridView1.Rows.Add(GetxReal(obj, a, b, d), obj, GetFx(GetxReal(obj, a, b, d)));
            }
            dataGridView1.Sort(dataGridView1.Columns["FxReal"], System.ComponentModel.ListSortDirection.Descending);
        }

        internal double GetxReal(string xBin, double a, double b, double d)
        {
            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);
            long xInt_xBin = Convert.ToInt64(xBin, 2);
            return ((b - a) * xInt_xBin) / (Math.Pow(2.0, l) - 1.0) + a;
        }

        internal double GetFx(double xReal)
        {
            return (xReal % 1.0) * (Math.Cos(20.0 + Math.PI + xReal)) - Math.Sin(xReal);
        }
    }
}
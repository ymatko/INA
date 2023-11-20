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
            //for (int i = 0; i < t; i++)
            //{
            //    dataGridView1.Rows.Add(RandBin.GetValue(a, b, d));
            //}
            Calculate(t, a, b, d);
        }

        private void Calculate(int t, double a, double b, double d)
        {
            for (int i = 0; i < t; i++)
            {
                MainObject obj = new MainObject(a, b, d);
                obj.xBin = RandBin.GetValue(a, b, d);
                var listOfobj = obj.GetDescendants();
            }
        }
    }
}
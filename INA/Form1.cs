using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("N", "N");
            dataGridView1.Columns.Add("Xreal", "X Real");
            dataGridView1.Columns.Add("Fx", "F(x)");
            dataGridView1.Columns.Add("gx", "g(x)");
            dataGridView1.Columns.Add("Pi", "Pi");
            dataGridView1.Columns.Add("q", "q");
            dataGridView1.Columns.Add("r", "r");
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("X(bin)", "X(bin)");
            dataGridView1.Columns.Add("Rodzicy", "Rodz.");
            dataGridView1.Columns.Add("P(c)", "P(c)");
            dataGridView1.Columns.Add("Po skrzyzowaniu", "Po skrzyzowaniu");
            dataGridView1.Columns.Add("Pozycja mut.", "Pozycja mut.");
            dataGridView1.Columns.Add("Bin", "Bin");
            dataGridView1.Columns.Add("Fx", "F(x)");
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double a = Convert.ToDouble(textBox_A.Text);
            double b = Convert.ToDouble(textBox_B.Text);
            double d = Convert.ToDouble(comboBox_D.Text);
            double pk = Convert.ToDouble(textBox_Pk.Text);
            double pm = Convert.ToDouble(textBox_Pm.Text);
            int n = Convert.ToInt32(textBox_N.Text);

            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);

            DataGrid[] generation = new DataGrid[n];
            for (int i = 1; i <= n; i++)
            {
                var dataGrid = new DataGrid(a, b, i + 1, l, d, pk, pm);
                dataGridView1.Rows.Add(i, dataGrid.xReal, dataGrid.FxReal);
            }
        }
    }
}
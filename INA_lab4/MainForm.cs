namespace INA_lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new TestForm();
            btnTests.Enabled = false;
            form.Show();
        }
    }
}
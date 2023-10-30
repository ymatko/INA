using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            dataGridView1.Columns.Add("Po mutacji", "Po mutacji");
            dataGridView1.Columns.Add("Bin", "Bin");
            dataGridView1.Columns.Add("Fx", "F(x)");
        }
        public Random rand = new Random();
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
            for (int i = 0; i < n; i++)
            {
                var dataGrid = new DataGrid(a, b, i + 1, l, d, pk, pm);
                generation[i] = dataGrid;
            }


            double minFxReal = generation.Min(data => data.FxReal);
            foreach (DataGrid data in generation)
            {
                // g(x)
                data.GxReal = data.FxReal - minFxReal + d;
            }

            double sumGxReal = generation.Sum(data => data.GxReal);
            foreach (DataGrid data in generation)
            {
                // Pi
                data.PixReal = data.GxReal / sumGxReal;
            }

            for (int i = 0; i < generation.Length; i++)
            {
                // Distributor
                if (i == 0)
                    generation[0].Distributor = generation[0].PixReal;
                else
                    generation[i].Distributor = generation[i - 1].Distributor + generation[i].PixReal;
            }


            // selection
            double x;
            for (int i = 0; i < generation.Length; i++)
            {
                x = rand.NextDouble();
                if (generation[0].Distributor > x)
                {
                    generation[i].r = x;
                    generation[i].IsSelected = generation[0].xReal;
                }
                else
                {
                    for (int j = 0; j < generation.Length; j++)
                    {

                        if (generation[j].Distributor < x && x <= generation[j + 1].Distributor)
                        {
                            generation[i].r = x;
                            generation[i].IsSelected = generation[j + 1].xReal;

                        }
                    }
                }
            }

            // for last distributor
            if (generation[n-1].Distributor != 1)
                generation[n-1].Distributor = 1;

            // is parent random
            for (int i = 0; i < generation.Length; i++)
            {
                if (rand.NextDouble() <= pk)
                    generation[i].isParent = true;
            }

            // cutting point
            //foreach (DataGrid data in generation)
            //{
            //    if (data.isParent)
            //    {
            //        data.CuttingPoint = rand.Next(1, l);
            //    }
            //}
            //generation = generation.OrderByDescending(data => data.isParent).ToArray();


            // Crossover
            for (int i = 0; i < generation.Length; i++)
            {
                if (generation[i].isParent)
                {
                    if (i < generation.Length - 1 && generation[i + 1].isParent)
                    {
                        var (child1, child2, crossoverPoint) = Crossover(
                            generation[i].GetBin(generation[i].IsSelected),
                            generation[i + 1].GetBin(generation[i + 1].IsSelected),
                            l
                        );

                        generation[i].AfterCrossover = child1;
                        generation[i].CuttingPoint = crossoverPoint;
                        generation[i + 1].AfterCrossover = child2;
                        generation[i + 1].CuttingPoint = crossoverPoint;
                        i++;
                    }
                }
            }




            for (int i = 0; i < generation.Length; i++)
            {
                dataGridView1.Rows.Add(
                    i + 1,
                    generation[i].xReal,
                    generation[i].FxReal,
                    generation[i].GxReal,
                    generation[i].PixReal,
                    generation[i].Distributor,
                    generation[i].r,
                    generation[i].IsSelected,
                    generation[i].GetBin(generation[i].IsSelected),
                    generation[i].isParent ? generation[i].isParent : "",
                    generation[i].CuttingPoint != 0 ? generation[i].CuttingPoint : "",
                    generation[i].AfterCrossover
                    );
            }
        }

        public static (string child1, string child2, int cuttingPoint) Crossover(string parent1, string parent2, int l)
        {
            var rand = new Random();
            int crossoverPoint = rand.Next(1, l);
            string child1 = parent1.Substring(0, crossoverPoint) + parent2.Substring(crossoverPoint);
            string child2 = parent2.Substring(0, crossoverPoint) + parent1.Substring(crossoverPoint);

            return (child1, child2, crossoverPoint);
        }
    }
}
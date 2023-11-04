using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace INA_lab3
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_A.Text);
            double b = Convert.ToDouble(textBox_B.Text);
            double d = Convert.ToDouble(comboBox_D.Text);
            double pk = Convert.ToDouble(textBox_Pk.Text);
            double pm = Convert.ToDouble(textBox_Pm.Text);
            int n = Convert.ToInt32(textBox_N.Text);
            bool EliteOn = checkBox_elite.Checked;
            int t = Convert.ToInt32(textBox_T.Text);

            DataGrid[] generation = new DataGrid[n];
            List<RunStatistics> runStatisticsList = new List<RunStatistics>();
            for (int i = 0; i < t; i++)
            {
                runStatisticsList.Add(CalculateFromLab2(a, b, d, pk, pm, n, generation));
            }
            
        }
        internal Random rand = new Random();
        private RunStatistics CalculateFromLab2(double a, double b, double d, double pk, double pm, int n, DataGrid[] generation)
        {
            
            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);

            for (int i = 0; i < n; i++)
            {
                var dataGrid = new DataGrid(a, b, i + 1, l, d, pk, pm);
                generation[i] = dataGrid;
            }


            double minFxReal = generation.Min(data => data.FxReal);
            double maxFxReal = generation.Max(data => data.FxReal);
            double avgFxReal = generation.Average(data => data.FxReal);

            var runStatistics = new RunStatistics
            {
                MinFxReal = minFxReal,
                MaxFxReal = maxFxReal,
                AvgFxReal = avgFxReal
            };
            foreach (DataGrid data in generation)
            {
                // g(x)
                data.GxReal = data.FxReal - maxFxReal + d;
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
            if (generation[n - 1].Distributor != 1)
                generation[n - 1].Distributor = 1;

            // is parent random
            for (int i = 0; i < generation.Length; i++)
            {
                if (rand.NextDouble() <= pk)
                    generation[i].isParent = true;
            }

            // Crossover
            List<Tuple<DataGrid, int>> parentCandidates = new List<Tuple<DataGrid, int>>();

            for (int i = 0; i < generation.Length; i++)
            {
                if (generation[i].isParent)
                {
                    parentCandidates.Add(new Tuple<DataGrid, int>(generation[i], i));
                }
            }

            // Checking for an odd number of parents
            if (parentCandidates.Count % 2 != 0)
            {
                int index = rand.Next(parentCandidates.Count);
                Tuple<DataGrid, int> singleParent = parentCandidates[index];
                parentCandidates.RemoveAt(index);

                int otherIndex = rand.Next(parentCandidates.Count);

                Tuple<DataGrid, int> partnerParent = null;

                try
                {
                    partnerParent = parentCandidates[otherIndex];
                }
                catch
                {
                }

                if (partnerParent != null)
                {
                    var parent1 = singleParent.Item1;
                    var parent2 = partnerParent.Item1;

                    int position1 = singleParent.Item2;
                    int position2 = partnerParent.Item2;

                    var (child1, child2, crossoverPoint) = Crossover(
                        parent1.GetBin(parent1.IsSelected),
                        parent2.GetBin(parent2.IsSelected),
                        l
                    );

                    generation[position1].AfterCrossover = child1;
                    generation[position1].CuttingPoint = crossoverPoint;
                    generation[position2].AfterCrossover = child2;
                    generation[position2].CuttingPoint = crossoverPoint;
                }
            }

            // Now parentCandidates only contains parents with an even number
            for (int i = 0; i < parentCandidates.Count - 1; i += 2)
            {
                var parent1 = parentCandidates[i].Item1;
                var parent2 = parentCandidates[i + 1].Item1;

                int position1 = parentCandidates[i].Item2;
                int position2 = parentCandidates[i + 1].Item2;

                var (child1, child2, crossoverPoint) = Crossover(
                    parent1.GetBin(parent1.IsSelected),
                    parent2.GetBin(parent2.IsSelected),
                    l
                );

                generation[position1].AfterCrossover = child1;
                generation[position1].CuttingPoint = crossoverPoint;
                generation[position2].AfterCrossover = child2;
                generation[position2].CuttingPoint = crossoverPoint;
            }

            // Not parents
            foreach (DataGrid data in generation)
            {
                if (!data.isParent)
                    data.AfterCrossover = data.GetBin(data.IsSelected);
            }

            // Mutations
            foreach (var data in generation)
            {
                var (afterMutation, mutations) = PerformMutation(data.AfterCrossover, pm);
                data.AfterMutation = afterMutation;
                data.Mutations = mutations;
            }


            // 
            foreach(var data in generation)
            {
                data.truexReal = data.GetReal(data.AfterMutation);
            }

            return runStatistics;
        }


        internal static (string child1, string child2, int cuttingPoint) Crossover(string parent1, string parent2, int l)
        {
            var rand = new Random();
            int crossoverPoint = rand.Next(1, l);
            string child1 = parent1.Substring(0, crossoverPoint) + parent2.Substring(crossoverPoint);
            string child2 = parent2.Substring(0, crossoverPoint) + parent1.Substring(crossoverPoint);

            return (child1, child2, crossoverPoint);
        }

        internal (string result, string mutations) PerformMutation(string input, double mutationProbability)
        {
            var rand = new Random();
            var s = input.ToCharArray();
            StringBuilder mutations = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                double percent = mutationProbability * 100;
                int random = rand.Next(0, 100);

                if (random < percent)
                {
                    s[i] = (s[i] == '1') ? '0' : '1';
                    mutations.Append((i + 1).ToString() + " ");
                }
            }
            return (new string(s), mutations.ToString());
        }
    }
}
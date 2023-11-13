using ScottPlot;
using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace INA_lab3
{
    internal partial class Form1 : Form
    {
        private BindingList<GridDataWithPercentage> bindingList = new BindingList<GridDataWithPercentage>();

        internal Form1()
        {
            InitializeComponent();
        }
        internal Random rand = new Random();

        private void btnCalculate_Click(object sender, EventArgs e)
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

            int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);

            for (int i = 0; i < n; i++)
            {
                var dataGrid = new DataGrid(a, b, i + 1, l, d, pk, pm);
                generation[i] = dataGrid;
            }



            List<RunStatistics> runStatisticsList = new List<RunStatistics>();

            for (int i = 0; i < t; i++)
            {
                Calculate(d, l, pk, pm, n, generation);
                var runStatistics = new RunStatistics
                {
                    MinGxReal = generation.Min(data => data.GxReal),
                    MaxGxReal = generation.Max(data => data.GxReal),
                    AvgGxReal = generation.Average(data => data.GxReal)
                };
                runStatisticsList.Add(runStatistics);
                NewGeneration(generation, EliteOn);
            }
            Plot(runStatisticsList);
            ViewData(generation);
        }
        private void btnCalcTest_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox_A.Text);
            double b = Convert.ToDouble(textBox_B.Text);
            double d = Convert.ToDouble(comboBox_D.Text);
            List<double> _pk = new List<double>() { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };
            List<double> _pm = new List<double>() { 0.001, 0.003, 0.005, 0.007, 0.009, 0.011, 0.013, 0.015, 0.017, 0.02 };
            List<int> _t = new List<int>() { 50, 100, 150, 200, 250, 300 };
            List<int> _n = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220, 230, 240, 250, 260, 270, 280, 290, 300 };

            List<RunStatisticTest> runStatisticTestList = new List<RunStatisticTest>();
            foreach (int n in _n)
            {
                DataGrid[] generation = new DataGrid[n];

                int l = (int)Math.Floor(Math.Log((b - a) / d, 2) + 1.0);

                foreach (int t in _t)
                {
                    foreach (double pk in _pk)
                    {
                        foreach (double pm in _pm)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                var dataGrid = new DataGrid(a, b, i + 1, l, d, pk, pm);
                                generation[i] = dataGrid;
                            }
                            Calculate(d, l, pk, pm, n, generation);
                            var runStatisticTest = new RunStatisticTest
                            {
                                N = n,
                                T = t,
                                Pk = pk,
                                Pm = pm,
                                Fx = generation.Average(data => data.FxReal)
                            };
                            runStatisticTestList.Add(runStatisticTest);
                        }
                    }

                }
            }
            dataGridView2.Rows.Clear();
            var top10List = runStatisticTestList.OrderByDescending(x => x.Fx).Take(10).ToList();
            foreach (RunStatisticTest data in top10List)
            {
                data.ViewData(dataGridView2);
            }
            dataGridView2.Sort(dataGridView2.Columns["Fx"], ListSortDirection.Descending);
        }

        internal void Plot(List<RunStatistics> list)
        {
            int runCount = list.Count;
            double[] runIndices = Enumerable.Range(1, runCount).Select(i => (double)i).ToArray();
            double[] minValues = list.Select(stat => stat.MinGxReal).ToArray();
            double[] maxValues = list.Select(stat => stat.MaxGxReal).ToArray();
            double[] avgValues = list.Select(stat => stat.AvgGxReal).ToArray();

            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(runIndices, minValues, label: "Minimum");
            formsPlot1.Plot.AddScatter(runIndices, maxValues, label: "Maximum");
            formsPlot1.Plot.AddScatter(runIndices, avgValues, label: "Average");

            formsPlot1.Plot.Legend();
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
        }

        private void Calculate(double d, int l, double pk, double pm, int n, DataGrid[] generation)
        {
            // g(x)
            double maxFxReal = generation.Max(data => data.FxReal);
            foreach (DataGrid data in generation)
            {
                data.GxReal = -(data.FxReal - maxFxReal) + d;
            }

            // Pi
            double sumGxReal = generation.Sum(data => data.GxReal);
            foreach (DataGrid data in generation)
            {
                data.PixReal = data.GxReal / sumGxReal;
            }

            // Distributor
            for (int i = 0; i < generation.Length; i++)
            {
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
                if (data.AfterCrossover == null)
                {
                    data.AfterCrossover = "0";
                }
                var (afterMutation, mutations) = PerformMutation(data.AfterCrossover, pm);
                data.AfterMutation = afterMutation;
                data.Mutations = mutations;
            }

            //new xReal nad FxReal
            foreach (DataGrid data in generation)
            {
                data.GetNewReal();
                data.GetNewFxReal();
            }

        }

        private void NewGeneration(DataGrid[] generation, bool elite)
        {
            if (elite)
            {
                DataGrid maxFxData = new DataGrid(generation.OrderByDescending(data => data.FxReal).First());
                for (int i = 0; i < generation.Length; i++)
                {
                    generation[i].xReal = generation[i].NewxReal;
                    generation[i].FxReal = generation[i].NewFxReal;
                }

                double[] FxGeneration = new double[generation.Length];
                for (int i = 0; i < FxGeneration.Length; i++)
                {
                    FxGeneration[i] = generation[i].FxReal;
                }

                if (!FxGeneration.Contains(maxFxData.FxReal))
                {
                    int randomIndex;
                    do
                    {
                        randomIndex = rand.Next(FxGeneration.Length);
                    } while (FxGeneration[randomIndex] >= maxFxData.FxReal);

                    generation[randomIndex].FxReal = maxFxData.FxReal;
                    generation[randomIndex].xReal = maxFxData.xReal;
                    generation[randomIndex].NewFxReal = maxFxData.FxReal;
                    generation[randomIndex].NewxReal = maxFxData.xReal;
                }
            }
            else
            {
                for (int i = 0; i < generation.Length; i++)
                {
                    generation[i].xReal = generation[i].NewxReal;
                    generation[i].FxReal = generation[i].NewFxReal;
                }
            }
        }


        private void ViewData(DataGrid[] generation)
        {
            dataGridView1.Rows.Clear();

            var sum = generation.Sum(data => data.GxReal);

            for (int i = 0; i < generation.Length; i++)
            {
                double percentage = (generation[i].GxReal / sum) * 100.0;
                if (true)
                {
                    dataGridView1.Rows.Add(
                        i + 1,                    // N
                        generation[i].xReal,           // XReal
                        generation[i].AfterMutation,   // XBin
                        generation[i].GxReal,          // GxReal
                        percentage                 // Percentage
                    );
                }
            }
            dataGridView1.Sort(dataGridView1.Columns["Percentage"], ListSortDirection.Descending);
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
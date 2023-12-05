namespace INA_lab5
{
    public partial class MainForm : Form
    {
        private double _a;
        private double _b;
        private double _d;
        private int _n;
        private int _t;
        private double _c1;
        private double _c2;
        private double _c3;
        private static Random rand = new Random();
        private List<Particle> particles = new List<Particle>();
        List<RunStatistics> runStatisticsList = new List<RunStatistics>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _a = Convert.ToDouble(textBox_A.Text);
            _b = Convert.ToDouble(textBox_B.Text);
            _d = Convert.ToDouble(cbD.Text);
            _c1 = Convert.ToDouble(textBox_C1.Text);
            _c2 = Convert.ToDouble(textBox_C2.Text);
            _c3 = Convert.ToDouble(textBox_C3.Text);
            _n = Convert.ToInt32(textBox_N.Text);
            _t = Convert.ToInt32(textBox_T.Text);
            runStatisticsList.Clear();
            CreateParticles();
            Calculate();
            Plot(runStatisticsList);
            foreach (Particle obj in particles)
            {
                obj.Fx = Fx(obj.Position);
            }
            var best = particles.OrderByDescending(p => p.Fx).FirstOrDefault();
            textBox_resFx.Text = best.Fx.ToString();
            textBox_resX.Text = best.Position.ToString();
        }

        private void Calculate()
        {
            for (int i = 0; i < _t; i++)
            {
                for (int j = 0; j < particles.Count; j++)
                {
                    particles[j].Fx = Fx(particles[j].Position);
                    if (particles[j].Fx > Fx(particles[j].BestOfParticle))
                        particles[j].BestOfParticle = particles[j].Position;
                    if (particles[j].Fx > Fx(Particle.BestOfNeighbors))
                        Particle.BestOfNeighbors = particles[j].Position;
                }
                foreach (Particle obj in particles)
                {
                    obj.Speed = CalculateSpeed(obj);
                    obj.Position += obj.Speed;
                }
                var runStatistics = new RunStatistics
                {
                    MinFx = particles.Min(data => data.Fx),
                    MaxFx = particles.Max(data => data.Fx),
                    AvgFx = particles.Average(data => data.Fx)
                };
                runStatisticsList.Add(runStatistics);
            }
        }

        private void CreateParticles()
        {
            particles.Clear();
            for (int i = 0; i < _n; i++)
            {
                var obj = new Particle();
                obj.Position = rand.NextDouble() * (_b - _a) + _a;
                particles.Add(obj);
            }
        }

        private double Fx(double value)
        {
            return (value % 1.0) * (Math.Cos(20.0 + Math.PI + value)) - Math.Sin(value);
        }

        private double CalculateSpeed(Particle particle)
        {
            return _c1 * rand.NextDouble() * particle.Speed +
                _c2 * rand.NextDouble() * (particle.BestOfParticle - particle.Position) +
                _c3 * rand.NextDouble() * (Particle.BestOfNeighbors - particle.Position);
        }

        internal void Plot(List<RunStatistics> list)
        {
            int runCount = list.Count;
            double[] runIndices = Enumerable.Range(1, runCount).Select(i => (double)i).ToArray();
            double[] minValues = list.Select(stat => stat.MinFx).ToArray();
            double[] maxValues = list.Select(stat => stat.MaxFx).ToArray();
            double[] avgValues = list.Select(stat => stat.AvgFx).ToArray();

            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(runIndices, minValues, label: "Minimum");
            formsPlot1.Plot.AddScatter(runIndices, maxValues, label: "Maximum");
            formsPlot1.Plot.AddScatter(runIndices, avgValues, label: "Average");

            formsPlot1.Plot.Legend();
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
        }
    }
}
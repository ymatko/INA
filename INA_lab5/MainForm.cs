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
            CreateParticles();
            Calculate();
        }

        private void Calculate()
        {
            for(int i = 0; i < _t; i++)
            {
                for(int j = 0; j < particles.Count; j++)
                {
                    if (Fx(particles[j].Position) > Fx(particles[j].BestOfParticle))
                        particles[j].BestOfParticle = particles[j].Position;
                    if (Fx(particles[j].Position) > Fx(particles[j].BestOfNeighbors))
                        particles[j].BestOfNeighbors = particles[j].Position;
                }
                foreach(Particle obj in particles)
                {
                    obj.Speed = CalculateSpeed(obj);
                    obj.Position += obj.Speed;
                }
            }
        }

        private void CreateParticles()
        {
            particles.Clear();
            for(int i = 0; i < _n; i++)
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
                _c3 * rand.NextDouble() * (particle.BestOfNeighbors - particle.Position);
        }
    }
}
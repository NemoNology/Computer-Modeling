using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            inputStringLength.Text = "0,1";
            inputStartAngle.Text = "30";
            inputStartSpeed.Text = "5";

            outputBaseChart.Series[0].ChartType = SeriesChartType.Spline;
        }

        private const double g = 9.81;
        private const double Dt = 0.0005;

        private double _stringLength;
        private double _startAngle;
        private double _startSpeed;
                
        private double _frequency;
        private double _amplitude;
        private double _startPhase;
        private CancellationToken _simulationStop;

        private void InputStringLength_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(inputStringLength.Text, out _stringLength))
            {
                inputStringLength.ForeColor = Color.Red;
                return;
            }

            _simulationStop.ThrowIfCancellationRequested();
            Calculate();

            inputStringLength.ForeColor = Color.Black;
        }

        private void InputStartAngle_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(inputStartAngle.Text, out _startAngle))
            {
                inputStartAngle.ForeColor = Color.Red;
                return;
            }

            _simulationStop.ThrowIfCancellationRequested();
            Calculate();

            inputStartAngle.ForeColor = Color.Black;
        }

        private void InputStartSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(inputStartSpeed.Text, out _startSpeed))
            {
                inputStartSpeed.ForeColor = Color.Red;
                return;
            }

            _simulationStop.ThrowIfCancellationRequested();
            Calculate();

            inputStartSpeed.ForeColor = Color.Black;
        }

        private double Solution(double time)
        {
            return _amplitude * Math.Cos(_frequency * time + _startPhase);
        }

        private void Calculate()
        {
            _frequency = Math.Sqrt(_stringLength / g);
            _startPhase = Math.Atan(-_startSpeed / (_stringLength * _frequency * _startAngle));
            _amplitude = Math.Sqrt(
                (_startAngle * _startAngle) +
                (_startSpeed * _startSpeed) / Math.Pow(_stringLength * _frequency, 2));
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(inputStringLength.Text, out _stringLength) ||
                !double.TryParse(inputStartAngle.Text, out _startAngle) ||
                !double.TryParse(inputStartSpeed.Text, out _startSpeed))
            {
                MessageBox.Show("Invalid input parameters");
                return;
            }

            

            Parallel.Invoke(
                new ParallelOptions
                {
                    CancellationToken = _simulationStop
                },

                new Action[] { Simulate }

                );
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            _simulationStop.ThrowIfCancellationRequested();
        }

        private void Simulate()
        {
            double speed = 0;
            double time = 0;
            

            while (true)
            {
                speed = -g / _stringLength * Math.Sin(Solution(time));
                time += Dt;

                outputBaseChart.Series[0].Points.Add(speed);
            }
        }
    }
}

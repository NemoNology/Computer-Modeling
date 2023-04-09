using System;
using System.Windows.Forms;

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
        }

        private float _stringLength;
        private float _startAngle;
        private float _startSpeed;

        private void InputStringLength_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(inputStringLength.Text, out _stringLength))
            {
                status.Text = "Invalid String Length input value";
                return;
            }

            status.Text = "";
        }

        private void InputStartAngle_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(inputStartAngle.Text, out _startAngle))
            {
                status.Text = "Invalid Start Angle input value";
                return;
            }

            status.Text = "";
        }

        private void InputStartSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(inputStartSpeed.Text, out _startSpeed))
            {
                status.Text = "Invalid Start Speed input value";
                return;
            }

            status.Text = "";
        }

        private double Solutuion(float time)
        {

        }

        private void Calculate()
        {

        }
    }
}

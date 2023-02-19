using System;
using System.Drawing;
using System.Windows.Forms;

namespace CM__VI__Lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int L, N;
        double ourPI;
        Graphics graphics;

        private void but_calculate_Click(object sender, System.EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            L = (int)lengthL.Value;
            N = (int)repeatsAmount.Value;

            graphics = MainView.CreateGraphics();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graphics = MainView.CreateGraphics();
            graphics.DrawLine(new Pen(Color.Black, 10), new Point(0, MainView.Height / 2), new Point(MainView.Width, MainView.Height / 2));
            graphics.Dispose();
        }

        public void BitmapDrawLine(Point p1, Point p2, Pen pen)
        {

        }


    }
}

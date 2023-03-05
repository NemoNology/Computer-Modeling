using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        System.Drawing.Color colorLine = System.Drawing.Color.Black;
        System.Drawing.Color colorNeedle = System.Drawing.Color.Blue;
        System.Drawing.Color colorMatchNeedle = System.Drawing.Color.Red;

        private void MainWindowView_Loaded(object sender, RoutedEventArgs e)
        {
            input_L.Text = "200";
            input_N.Text = "1000";
            input_I.Text = "2";
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            int I, N, L;

            try
            {
                I = Convert.ToInt32(input_I.Text);
                N = Convert.ToInt32(input_N.Text);
                L = Convert.ToInt32(input_L.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input params");
                return;
            }

            
            Bitmap bmp = CreateBitmap(L, I);

            int N1 = DrawNeedles(ref bmp, L / 2, N, colorNeedle, colorMatchNeedle, colorLine);

            matchAmount.Content = N1.ToString();

            calculatedPI.Content = ((double)N1 / (double)N).ToString();

            if (bmp != null)
            {
                MainView.Source = ImageSourceFromBitmap(bmp);
            }
        }

        public Bitmap CreateBitmap(int lengthL, int intersectionAmount)
        {
            Bitmap bmp;

            try
            {
                bmp = new Bitmap(lengthL * 2, (lengthL * (intersectionAmount + 1)) + 1 * intersectionAmount);
            }
            catch
            {
                return null;
            }

            FillBitmap(ref bmp, System.Drawing.Color.White);

            if (intersectionAmount == 0)
            {
                return bmp;
            }

            DrawLine(ref bmp, new System.Drawing.Point(0, lengthL + 1), new System.Drawing.Point(bmp.Width, lengthL + 1), colorLine);

            for (int i = 1; i < intersectionAmount; i++)
            {
                DrawLine(ref bmp, new System.Drawing.Point(0, lengthL * (i + 1) + 1), new System.Drawing.Point(bmp.Width, lengthL * (i + 1) + 1), colorLine);
            }

            return bmp;
        }

        /// <summary>
        /// Paint full bitmap with one System.Drawing.Color
        /// </summary>
        public void FillBitmap(ref Bitmap bmp, System.Drawing.Color emptyPixelColor)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    bmp.SetPixel(j, i, emptyPixelColor);
                }
            }
        }

        public void DrawLine(ref Bitmap bmp, System.Drawing.Point p1, System.Drawing.Point p2, System.Drawing.Color lineColor)
        {
            double x1 = (double)p1.X;
            double y1 = (double)p1.Y;

            double x2 = (double)p2.X;
            double y2 = (double)p2.Y;

            if (Math.Abs(x2 - x1) >= Math.Abs(y2 - y1))
            {
                if (x2 - x1 == 0)
                {
                    return;
                }

                if (x2 < x1)
                {
                    Swap(ref x1, ref x2);
                    Swap(ref y1, ref y2);
                }

                double k = (y2 - y1) / (x2 - x1);

                double y = y1;

                for (double x = x1; x < x2; x++)
                {
                    bmp.SetPixel((int)x, (int)y, lineColor);
                    y += k;
                }
            }
            else
            {
                if (y2 - y1 == 0)
                {
                    return;
                }



                if (y2 < y1)
                {
                    Swap(ref x1, ref x2);
                    Swap(ref y1, ref y2);
                }

                double k = (x2 - x1) / (y2 - y1);

                double x = x1;

                for (int y = (int)y1; y < (int)y2; y++)
                {
                    bmp.SetPixel((int)x, (int)y, lineColor);
                    x += k;
                }

            }
        }

        public bool DrawNeedle(ref Bitmap bmp, System.Drawing.Point needleStart, 
            int needleLength, System.Drawing.Color neddleColor, System.Drawing.Color neddleMatchColor, System.Drawing.Color matchColor)
        {
            int angle = new Random(DateTime.Now.Millisecond).Next(0, 360);

            System.Drawing.Point needleEnd = new System.Drawing.Point(
                (int)(needleStart.X + Math.Cos(Radians(angle)) * needleLength), 
                (int)(needleStart.Y + Math.Sin(Radians(angle)) * needleLength));

            bool res = DrawLineWithMatch(ref bmp, needleStart, needleEnd, neddleColor, matchColor);

            if (res)
            {
                DrawLineWithMatch(ref bmp, needleStart, needleEnd, neddleMatchColor, matchColor);
            }

            return res;
        }


        public int DrawNeedles(ref Bitmap bmp, int needleLength, int needlesAmount,
            System.Drawing.Color neddleColor, 
            System.Drawing.Color neddleMatchColor, 
            System.Drawing.Color matchColor)
        {
            int res = 0;

            Random rnd = new Random(DateTime.Now.Millisecond);


            for (int i = 0; i < needlesAmount; i++)
            {
                System.Drawing.Point needleStart = new System.Drawing.Point(
                rnd.Next(0 + needleLength, bmp.Width - needleLength),
                rnd.Next(0 + needleLength, bmp.Height - needleLength));

                if (DrawNeedle(ref bmp, needleStart, needleLength, neddleColor, neddleMatchColor, matchColor))
                {
                    res++;
                }
            }

            return res;
        }

        #region Features

        /// <summary>
        /// Swap two double values between each other
        /// </summary>
        public void Swap(ref double item1, ref double item2)
        {
            double buffer = item1;
            item1 = item2;
            item2 = buffer;
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public ImageSource ImageSourceFromBitmap(Bitmap bmp)
        {
            var handle = bmp.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            finally { DeleteObject(handle); }
        }

        public double Radians(double degress)
        {
            return (Math.PI / 180) * degress;
        }

        public bool DrawLineWithMatch(ref Bitmap bmp, System.Drawing.Point p1, 
            System.Drawing.Point p2, System.Drawing.Color lineColor, System.Drawing.Color matchColor)
        {
            double x1 = (double)p1.X;
            double y1 = (double)p1.Y;

            double x2 = (double)p2.X;
            double y2 = (double)p2.Y;

            bool res = false;

            if (Math.Abs(x2 - x1) >= Math.Abs(y2 - y1))
            {
                if (x2 - x1 == 0)
                {
                    return false;
                }

                if (x2 < x1)
                {
                    Swap(ref x1, ref x2);
                    Swap(ref y1, ref y2);
                }

                double k = (y2 - y1) / (x2 - x1);

                double y = y1;

                for (double x = x1; x < x2; x++)
                {
                    if (bmp.GetPixel((int)x, (int)y).ToArgb() == matchColor.ToArgb())
                    {
                        res = true;
                    }
                    else
                    {
                        bmp.SetPixel((int)x, (int)y, lineColor);
                    }
                    y += k;
                }
            }
            else
            {
                if (y2 - y1 == 0)
                {
                    return false;
                }

                if (y2 < y1)
                {
                    Swap(ref x1, ref x2);
                    Swap(ref y1, ref y2);
                }

                double k = (x2 - x1) / (y2 - y1);

                double x = x1;

                for (int y = (int)y1; y < (int)y2; y++)
                {
                    if (bmp.GetPixel((int)x, (int)y).ToArgb() == matchColor.ToArgb())
                    {
                        res = true;
                    }
                    else
                    {
                        bmp.SetPixel((int)x, (int)y, lineColor);
                    }
                    x += k;
                }

            }

            return res;
        }

        #endregion




    }
}

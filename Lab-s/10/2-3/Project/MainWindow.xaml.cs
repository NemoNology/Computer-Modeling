using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Subscribing();

            inputTimeMultiplier.Value = 2;
        }

        private int _deniedAmount = 0;
        private int _inQueueAmount = 0;
        private int _servedAmount = 0;

        private int _queueCapacity = 0;

        private ServiceSystem _serviceSystem = new ServiceSystem();

        private float _timeMultiplier = 1;

        private double _remainingTime = 0;

        private void TimeMultiplier_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (outputTimeMultiplier == null)
            {
                return;
            }

            if (e.NewValue >= 0)
            {
                _timeMultiplier = (float)e.NewValue;
                outputTimeMultiplier.Content = $"{_timeMultiplier:f1}";
            }
            else
            {
                _timeMultiplier = (10 - (float)Math.Abs(e.NewValue)) / 10;
                outputTimeMultiplier.Content = $"{_timeMultiplier:f1}";
            }
        }

        private void QueueCapacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (outputQueueCapacity == null)
            {
                return;
            }

            _queueCapacity = (int)e.NewValue;
            outputQueueCapacity.Content = _queueCapacity.ToString();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() => _serviceSystem.ServiceShift(_timeMultiplier));

            inputStart.IsEnabled = false;
            outputStatus.Content = "Servicing...";
        }

        private void Client_InputStart(TimeSpan timeDelay)
        {
            Dispatcher.Invoke(() =>
            {
                outputClientIn.Visibility = Visibility.Visible;

                var canvasWidth = (double)outputClientIn.Parent.GetValue(ActualWidthProperty);
                var rollingAnimation = new DoubleAnimation(canvasWidth, 0, new Duration(timeDelay));

                outputClientIn.BeginAnimation(Canvas.RightProperty, rollingAnimation);

                outputRemainingTime.Content = $"{_remainingTime:f2} / {_serviceSystem.ServiceTime}";

                _remainingTime += timeDelay.TotalSeconds;
            });
        }

        private void Service_Completed()
        {
            _remainingTime = 0;

            Dispatcher.Invoke(() =>
            {
                outputStatus.Content = "Service completed";

                inputStart.IsEnabled = true;
                outputClientIn.Visibility = Visibility.Hidden;
                outputRemainingTime.Content = string.Empty;
            });
        }

        private void Subscribing()
        {
            _serviceSystem.OnClientInputStart += Client_InputStart;
            _serviceSystem.OnServiceCompleted += Service_Completed;
        }

    }
}

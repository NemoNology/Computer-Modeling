using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

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
            inputQueueCapacity.Value = 3;

            _serviceSystem.ServiceTime = 100;
        }

        private int _deniedAmount = 0;
        private int _inQueueAmount = 0;
        private int _servedAmount = 0;

        private int _queueCapacity = 0;

        private ServiceSystem _serviceSystem = new ServiceSystem();

        private float _timeMultiplier = 1;
        private double _remainingTime = 0;

        private void TimeMultiplier_ValueChanged(
            object sender,
            RoutedPropertyChangedEventArgs<double> e
        )
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

        private void QueueCapacity_ValueChanged(
            object sender,
            RoutedPropertyChangedEventArgs<double> e
        )
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
            _deniedAmount = 0;
            _inQueueAmount = 0;
            _servedAmount = 0;

            Dispatcher.Invoke(() =>
            {
                outputDeniedPeopleAmount.Content = _deniedAmount.ToString();
                outputPeopleInQueueAmount.Content = _inQueueAmount.ToString();
                outputServedPeopleAmount.Content = _servedAmount.ToString();
            });

            Task.Factory.StartNew(() => _serviceSystem.ServiceShift(_timeMultiplier));

            inputStart.IsEnabled = false;
            inputTimeMultiplier.IsEnabled = false;
            inputQueueCapacity.IsEnabled = false;
            outputStatus.Content = "Servicing...";
        }

        private void Client_Input(TimeSpan timeDelay)
        {
            Dispatcher.Invoke(() =>
            {
                outputClientIn.Visibility = Visibility.Visible;

                var canvasWidth = (double)outputClientIn.Parent.GetValue(ActualWidthProperty);
                var rollingAnimation = new DoubleAnimation(canvasWidth, 0, new Duration(timeDelay));

                outputClientIn.BeginAnimation(Canvas.RightProperty, rollingAnimation);

                outputRemainingTime.Content =
                    $"{_remainingTime:f2} / {_serviceSystem.ServiceTime / _timeMultiplier:f2}";

                _remainingTime += timeDelay.TotalSeconds;
            });
        }

        private void Client_Service(TimeSpan timeDelay, bool isStillBusy = false)
        {
            Dispatcher.Invoke(() =>
            {
                var clientsInQueueAmount = outputClientsQueue.Children.Count;

                if (isStillBusy)
                {
                    if (clientsInQueueAmount >= _queueCapacity)
                    {
                        Client_Denied(timeDelay);
                    }
                    else
                    {
                        Client_PuttedInQueue();
                    }
                }
                else
                {
                    if (clientsInQueueAmount > 0)
                    {
                        _inQueueAmount++;

                        outputPeopleInQueueAmount.Content = _inQueueAmount.ToString();
                    }
                }

                Service_Servicing(timeDelay);
            });
        }

        private void Service_Completed()
        {
            _remainingTime = 0;

            Dispatcher.Invoke(async () =>
            {
                outputClientIn.Visibility = Visibility.Hidden;
                outputClientDenied.Visibility = Visibility.Hidden;

                var timeDelay = TimeSpan.FromSeconds(4 / _timeMultiplier);

                while (outputClientsQueue.Children.Count > 0)
                {
                    outputClientsQueue.Children.RemoveAt(0);

                    Service_Servicing(timeDelay);

                    await Task.Delay(timeDelay);
                }

                outputStatus.Content = "Service completed";

                inputStart.IsEnabled = true;
                inputTimeMultiplier.IsEnabled = true;
                inputQueueCapacity.IsEnabled = true;
                outputRemainingTime.Content = string.Empty;
            });
        }

        private void Subscribing()
        {
            _serviceSystem.OnClientInputStart += Client_Input;
            _serviceSystem.OnServiceCompleted += Service_Completed;
            _serviceSystem.OnService += Client_Service;
        }

        private async void Client_Serviced(TimeSpan timeDelay)
        {
            await Dispatcher.InvokeAsync(() =>
            {
                var canvasWidth = (double)outputClientOut.Parent.GetValue(ActualWidthProperty);
                var rollingAnimation = new DoubleAnimation(0, canvasWidth, new Duration(timeDelay));

                outputClientOut.BeginAnimation(Canvas.LeftProperty, rollingAnimation);

                _servedAmount++;

                outputServedPeopleAmount.Content = _servedAmount.ToString();
            });
        }

        private async void Client_PuttedInQueue()
        {
            await Dispatcher.InvokeAsync(() =>
            {
                outputClientsQueue.Children.Add(
                    new Ellipse() { Fill = Brushes.Blue, Width = 50, Height = 50 }
                );

                _inQueueAmount++;

                outputPeopleInQueueAmount.Content = _inQueueAmount.ToString();
            });
        }

        private async void Client_Denied(TimeSpan timeDelay)
        {
            await Dispatcher.InvokeAsync(() =>
            {
                outputClientDenied.Visibility = Visibility.Visible;

                var canvasWidthScaled =
                    (double)outputClientDenied.Parent.GetValue(ActualWidthProperty) * 1.25;
                var rollingAnimation = new DoubleAnimation(
                    0,
                    canvasWidthScaled,
                    new Duration(timeDelay)
                );

                outputClientDenied.BeginAnimation(Canvas.RightProperty, rollingAnimation);

                _deniedAmount++;

                outputDeniedPeopleAmount.Content = _deniedAmount.ToString();
            });
        }
    
        private async void Service_Servicing(TimeSpan timeDelay)
        {
            await Dispatcher.InvokeAsync(() =>
            {
                var busyAnimation = new DoubleAnimation(0, 360, new Duration(timeDelay));

                outputServingBoxRotateTransform.BeginAnimation(RotateTransform.AngleProperty, busyAnimation);
            });

            await Task.Delay(timeDelay);

            Client_Serviced(timeDelay);
        }
    }
}

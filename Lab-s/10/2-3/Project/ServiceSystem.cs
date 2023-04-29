using System;
using System.Threading.Tasks;

namespace Project
{
    internal class ServiceSystem
    {
        public event Action<TimeSpan>? OnClientInputStart;
        public event Action? OnServiceCompleted;
        public event Action<TimeSpan, bool>? OnServiceBusy;
        public event Action<TimeSpan>? OnServiceFree;

        public int ServiceTime { get; set; } = 40;

        private double Lambda(double time)
        {
            return 1.1 - Math.Pow(time - 50, 2) / 2500;
        }

        private double Nu(double time, int ServiceTime)
        {
            float serviceTimePart = ServiceTime * 0.4f;

            if (time <= serviceTimePart)
            {
                return 0.7 * time;
            }
            else
            {
                return 0.9;
            }
        }

        public async void ServiceShift(double timeMultiplier)
        {
            int Tn = ServiceTime;
            double t = 0;

            bool firstClient = true;

            var rnd = new Random(DateTime.Now.Millisecond);

            while (t <= Tn)
            {
                var buffer = Lambda(t);

                var ro = -1 / buffer * Math.Log(rnd.NextDouble());

                var timeDelay = TimeSpan.FromSeconds(ro / timeMultiplier);

                double serviceIntensity = Nu(t, ServiceTime);

                double serviceDeniedPossibility =
                    //1 - (serviceIntensity / (buffer + serviceIntensity));
                    1 - serviceIntensity;

                t += ro;

                OnClientInputStart?.Invoke(timeDelay);
                await Task.Delay(timeDelay);

                if (rnd.NextDouble() <= serviceDeniedPossibility && !firstClient)
                {
                    OnServiceBusy?.Invoke(timeDelay, false);
                }
                else
                {
                    OnServiceFree?.Invoke(timeDelay);
                }

                firstClient = false;
            }

            OnServiceCompleted?.Invoke();
        }


    }
}

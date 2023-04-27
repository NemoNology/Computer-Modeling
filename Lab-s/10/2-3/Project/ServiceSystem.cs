using System;
using System.Threading.Tasks;

namespace Project
{
    internal class ServiceSystem
    {
        public event Action<TimeSpan>? OnClientInputStart;
        public event Action<TimeSpan>? OnClientDenied;
        public event Action<TimeSpan>? OnClientPutInQueue;
        public event Action<TimeSpan>? OnClientServed;
        public event Action? OnServiceCompleted;

        public int ServiceTime { get; set; } = 20;

        private double Lambda(double time)
        {
            return 1.1 - Math.Pow(time - 50, 2) / 2500;
        }

        private double Nu(double time)
        {
            if (time <= 40)
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

            var rnd = new Random(DateTime.Now.Millisecond);

            while (t <= Tn)
            {
                var buffer = Lambda(t);

                var ro = -1 / buffer * Math.Log(rnd.NextDouble());

                var timeDelay = TimeSpan.FromSeconds(ro / timeMultiplier);

                t += ro;

                OnClientInputStart?.Invoke(timeDelay);
                await Task.Delay(timeDelay);
            }

            OnServiceCompleted?.Invoke();
        }


    }
}

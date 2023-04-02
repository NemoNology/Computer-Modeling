namespace Project
{
    internal class HarmonicPendulum
    {
        private const float g = 9.8f;

        private int _startSpeed;
        private int _stringLength;

        public int StartAngleDegree { get; set; }
        public int StartSpeed 
        { 
            get => _startSpeed; 

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Start Speed can't be negative");
                }

                _startSpeed = value;
            }
        }
        public int StringLength
        {
            get => _stringLength;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Start Speed can't be negative");
                }

                _stringLength = value;
            }
        }

        public double Amplitude
        {
            get
            {
                return Math.Sqrt(
                    StartAngleDegree * StartAngleDegree +
                    (_startSpeed * _startSpeed) / 
                    Math.Pow(_stringLength * Frequency, 2)
                    );
            }
        }

        public double Frequency
        {
            get
            {
                return Math.Sqrt(_stringLength / g);
            }
        }
    
        public double Period
        {
            get
            {
                return 2 * Math.PI / Frequency;
            }
        }

        public double StartPhase
        {
            get
            {
                return Math.Atan(
                    -_startSpeed / 
                    (_stringLength * Frequency * StartAngleDegree)
                    );
            }
        }
    
        public HarmonicPendulum(int startAngleDegree, int startSpeed, int stringLength = 1)
        {
            StartAngleDegree = startAngleDegree;
            StartSpeed = startSpeed;
            StringLength = stringLength;
        }

        public double Solution(float t = 0.05f)
        {
            return Amplitude * Math.Cos(Frequency * t + StartPhase);
        }
    
        // TODO: method Move()
        public void Move()
        {

        }
    }
}

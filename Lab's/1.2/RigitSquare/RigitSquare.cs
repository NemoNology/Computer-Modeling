using RigitBody2D;

namespace RigitSquare;
{
    public class RigitSquare : IRigidBody2D
    {
        public Point Coordinates { get; set; } = 0;

        public double SpeedX { get; set; } = 0;

        public double AccelerationX { get; set; } = 0;

        public double SpeedY { get; set; } = 0;

        public double AccelerationY { get; set; } = 0;

        public void MovementVectorByNewCoordinates(Point point)
        {
            SpeedX = point.X - Coordinates.X;
            SpeedY = point.Y - Coordinates.Y;
        }

        public void Move()
        {
            
        }
    }

}


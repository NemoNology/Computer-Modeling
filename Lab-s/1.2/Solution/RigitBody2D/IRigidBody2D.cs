using System;

namespace RigitBody2D
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public interface IRigidBody2D
    {
        public Point Coordinates { get; set; }

        public double SpeedX { get; set; }

        public double AccelerationX { get; set; }

        public double SpeedY { get; set; }

        public double AccelerationY { get; set; }

        public void MovementVectorByNewCoordinates(Point point);

        public void Move();
    }
}


using RigitBody2D;

namespace RigitSquare
{
    public class RigitSquare : IRigidBody2D
    {
        /// <summary>
        /// Side Legth
        /// </summary>
        public byte Size { get; set; }

        /// <summary>
        /// Square Center Coordinates
        /// </summary>
        public Point Coordinates { get; set; } = 0;

        /// <summary>
        /// Speed by X - How change X Coordinate by time
        /// </summary>
        public double SpeedX { get; set; } = 0;

        /// <summary>
        /// Acceleratio by X - How change Speed X by time
        /// </summary>
        public double AccelerationX { get; set; } = 0;

        /// <summary>
        /// Speed by Y - How change Y Coordinate by time
        /// </summary>
        public double SpeedY { get; set; } = 0;

        /// <summary>
        /// Acceleratio by Y - How change Speed Y by time
        /// </summary>
        public double AccelerationY { get; set; } = 0;

        public void MovementVectorByNewCoordinates(Point point)
        {
            SpeedX = point.X - Coordinates.X;
            SpeedY = point.Y - Coordinates.Y;
        }

        public void Move()
        {
            Coordinates.X += SpeedX;
            Coordinates.Y += SpeedY;

            SpeedX += AccelerationX;
            SpeedY += AccelerationY;
        }
    }

}


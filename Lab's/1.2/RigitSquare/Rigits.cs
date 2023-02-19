using RigitBody2D;

namespace Rigits
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
        public Point Coordinates { get; set; }

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

        /// <summary>
        /// Set Speed by new Coordinates
        /// </summary>
        /// <param name="point">  New Coordinates  </param>
        public void MovementVectorByNewCoordinates(Point point)
        {
            SpeedX = point.X - Coordinates.X;
            SpeedY = point.Y - Coordinates.Y;
        }

        /// <summary>
        /// Change Coordinates and Speed
        /// </summary>
        public void Move()
        {
            Coordinates = new Point(Coordinates.X + (int)SpeedX, Coordinates.Y + (int)SpeedY);

            SpeedX += AccelerationX;
            SpeedY += AccelerationY;
        }
    }

    public class RigitPoint : IRigidBody2D
    {
        /// <summary>
        /// Square Center Coordinates
        /// </summary>
        public Point Coordinates { get; set; } = new Point(0, 0);

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

        /// <summary>
        /// Set Speed by new Coordinates
        /// </summary>
        /// <param name="point">  New Coordinates  </param>
        public void MovementVectorByNewCoordinates(Point point)
        {
            SpeedX = point.X - Coordinates.X;
            SpeedY = point.Y - Coordinates.Y;
        }

        /// <summary>
        /// Change Coordinates and Speed
        /// </summary>
        public void Move()
        {
            Coordinates = new Point(Coordinates.X + (int)SpeedX, Coordinates.Y + (int)SpeedY);

            SpeedX += AccelerationX;
            SpeedY += AccelerationY;
        }
    }

    public class RigitCircle : IRigidBody2D
    {
        /// <summary>
        /// Side Legth
        /// </summary>
        public byte Radius { get; set; }

        /// <summary>
        /// Square Center Coordinates
        /// </summary>
        public Point Coordinates { get; set; } = new Point(0, 0);

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

        /// <summary>
        /// Set Speed by new Coordinates
        /// </summary>
        /// <param name="point">  New Coordinates  </param>
        public void MovementVectorByNewCoordinates(Point point)
        {
            SpeedX = point.X - Coordinates.X;
            SpeedY = point.Y - Coordinates.Y;
        }

        /// <summary>
        /// Change Coordinates and Speed
        /// </summary>
        public void Move()
        {
            Coordinates = new Point(Coordinates.X + (int)SpeedX, Coordinates.Y + (int)SpeedY);

            SpeedX += AccelerationX;
            SpeedY += AccelerationY;
        }
    }

}


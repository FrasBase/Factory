using System;

namespace Factory.Points
{
    public partial class Point
    {
        double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => string.Format("X:{0} Y:{1}", x, y);
    }

}
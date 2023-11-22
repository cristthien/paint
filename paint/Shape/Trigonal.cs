using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.Shapes
{
    public class Trigonal: Rectangles
    {
        public Trigonal(Point p1, Point p2, Color color, int size) : base(p1, p2, color, size) { }
        public override void DrawShape(Graphics g)
        {
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            int X, Y;
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;
            Point[] curvePoints =
            {
                 new Point (X+width/2, Y ),
                 new Point(X, Y+ height),
                 new Point(X+width,Y+height)
             };
            g.DrawPolygon(pen, curvePoints);
        }

    }
}

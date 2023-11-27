using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.Shapes
{
    public class Hexagon : Squares
    {
        public Hexagon(Point p1, Point p2, Color color, int siae) : base(p1, p2, color, siae) { }
        public override void DrawShape(Graphics g)
        {
            int X, Y;
            int a = Math.Abs(p1.X - p2.X) > Math.Abs(p1.Y - p2.Y) ? Math.Abs(p1.Y - p2.Y) : Math.Abs(p1.X - p2.X);

            CalculateSquare();
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;

            Point[] points = {
                new Point(X+(a/2), Y),
                new Point(X+a,Y+(a/4)),
                new Point(X+a, Y+((3*a)/4)),
                new Point(X+(a/2), Y+a),
                new Point(X, Y+((3*a)/4)),
                new Point(X,Y+(a/4)),
            };
            g.DrawPolygon(pen, points);



        }

    }
}

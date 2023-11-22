using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.Shapes
{
    public class Cir : Rectangles
    {
        public Cir(Point p1, Point p2, Color color, int size) : base(p1, p2, color, size) { }
        public override void DrawShape(Graphics g)
        {
            int X, Y;
            int a = Math.Abs(p1.X - p2.X) > Math.Abs(p1.Y - p2.Y) ? Math.Abs(p1.Y - p2.Y) : Math.Abs(p1.X - p2.X);


            if (p2.X > p1.X)
            {
                p2.X = p1.X + a;
            }
            else
            {
                p2.X = p1.X - a;
            }
            if (p2.Y > p1.Y)
            {
                p2.Y = p1.Y + a;

            }
            else
            {
                p2.Y = p1.Y - a;

            }
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;
            g.DrawEllipse(pen, new Rectangle(X, Y, a, a));

        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.Shapes
{
    public class Line : Shape
    {
        public Line(Point p1, Point p2, Color color, int size) : base(p1, p2, color, size) { } 
        public override void DrawShape(Graphics g)
        {
            
            g.DrawLine(pen, p1, p2);

        }
    }
}

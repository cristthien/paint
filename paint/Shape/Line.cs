using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.Shapes
{
    public class Line : Shape
    {
        public Line(Point p1, Point p2, Color color, int size) : base(p1, p2, color, size) { }

        public override Cursor ChangeCursor(Point location)
        {
            if (IsResizePioint(location))
            {
                return Cursors.SizeNS;
            } else if (IsInsideShape(location)) {
                return Cursors.SizeAll;
            }
            else
            {
                return Cursors.Default;
            }
        }

        public override void ChangeSize(Point location)
        {
            if (clickedResizePoint == 0)
            {
                p1 = location;
            }
            else {
                p2 = location;
            }
        }

        public override void DetectPoint(Point location)
        {
            if(location.X < p1.X + size
                 && location.X > p1.X - size
                 && location.Y < p1.Y + size
                 && location.Y > p1.Y - size)


            {
                clickedResizePoint = 0;
            }
            else
            {
                clickedResizePoint = 1;
            }
        }

        public override void DrawResizePoint(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, p1.X- (size / 2),p1.Y- (size / 2), size, size);
            g.FillEllipse(brush, p2.X- (size / 2), p2.Y- (size / 2), size, size);
        }

        public override void DrawShape(Graphics g)
        {
            
            g.DrawLine(pen, p1, p2);

        }

        public override bool IsInsideShape(Point location)
        {
            var g = new GraphicsPath();
            var pen = new Pen(Color.Black, size);
            g.AddLine(p1, p2);
            return g.IsOutlineVisible(location, pen);
        }
        

        public override bool IsResizePioint(Point location)
        {
            if (
                 (location.X < p1.X + size
                 && location.X > p1.X - size
                 && location.Y < p1.Y + size
                 && location.Y > p1.Y - size) ||
                 (location.X < p2.X + size
                 && location.X > p2.X - size
                 && location.Y < p2.Y + size
                 && location.Y > p2.Y - size)
                 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

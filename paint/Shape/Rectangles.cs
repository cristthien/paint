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
    public class Rectangles : Shape
    {
        #region Properties 
        protected Point[] resizePoints = new Point[4];
        #endregion
        #region Constructor
        public Rectangles(Point p1, Point p2, Color color, int size) : base(p1, p2, color, size) { }
        #endregion
        #region Methods
        protected void UpdateResizePoint(){
            int X, Y;
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;
            resizePoints[0] = new Point(X, Y);
            resizePoints[1] = new Point(X + Math.Abs(p1.X - p2.X), Y);
            resizePoints[3] = new Point(X, Y + Math.Abs(p1.Y - p2.Y));
            resizePoints[2] = new Point(X + Math.Abs(p1.X - p2.X), Y + Math.Abs(p1.Y - p2.Y));
        } 


        public override Cursor ChangeCursor(Point location)
        {
            if (IsResizePioint(location))
            {
                return Cursors.SizeNS;
            }
            else if (IsInsideShape(location))
            {
                return Cursors.SizeAll;
            }
            else
            {
                return Cursors.Default;
            }
        }

        public override void DrawResizePoint(Graphics g)
        {
            UpdateResizePoint();
            foreach (var point in resizePoints) {
                SolidBrush brush = new SolidBrush(Color.Red);
                g.FillEllipse(brush, point.X - (size / 2), point.Y - (size / 2), size, size);

            }

        }

        public  override void DrawShape(Graphics g)
        {
            int X, Y;
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;
            g.DrawRectangle(pen, new Rectangle(X, Y, Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y)));
        }

        public override bool IsInsideShape(Point location)
        {
            var g = new GraphicsPath();
            int X, Y;
            X = p1.X > p2.X ? p2.X : p1.X;
            Y = p1.Y > p2.Y ? p2.Y : p1.Y;
            g.AddRectangle(new Rectangle(X, Y, Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y)));
            return g.IsVisible(location);
        }



        public override bool IsResizePioint(Point location)
        {
            foreach (var point in resizePoints) {
                if 
                 (location.X < point.X + size
                 && location.X > point.X - size
                 && location.Y < point.Y + size
                 && location.Y > point.Y - size) 
                 
                {
                    return true;
                }

            }
            return false;
            
        }

        public override void ChangeSize(Point location)
        {
            int staticPointIndex = clickedResizePoint + 2 > 3 ? clickedResizePoint - 2 : clickedResizePoint + 2; // tim diem doi dien
           

            p1 = resizePoints[staticPointIndex];
            p2 = location;
            
        }

        public override void DetectPoint(Point location)
        {
            UpdateResizePoint();
            for (int i = 0; i < 4; i++) {
                Point point = resizePoints[i];
                if
                 (location.X < point.X + size
                 && location.X > point.X - size
                 && location.Y < point.Y + size
                 && location.Y > point.Y - size)

                {
                    clickedResizePoint = i;
                }

            }
            
        }
        #endregion
    }
}

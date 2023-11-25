using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace paint.Shapes
{
    public abstract class Shape
    {
        #region Properties
        protected Point p1;
        protected Point p2;
        protected Color color;
        protected int size;
        protected Pen pen;
        protected int clickedResizePoint=-1;

        #endregion
        #region Constructor 
        public Shape(Point p1, Point p2,Color color, int size ) {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
            this.size = size;
            this.pen = new Pen(color,size);
        }

        public Shape() {
            this.p1 = Point.Empty;
            this.p2 = Point.Empty;
            this.size = 3;
            this.color = Color.Black;
            this.pen = new Pen(Color.Black, 3);
        }
        #endregion

        #region Methods
        public abstract void DrawShape(Graphics g);
        public abstract void DrawResizePoint(Graphics g);
        public abstract Cursor ChangeCursor(Point location);
        public abstract bool IsResizePioint(Point location);
        public abstract bool IsInsideShape(Point location);
        public abstract void ChangeSize(Point location);
        public abstract void DetectPoint(Point location);
        public void UpdateShape(Point p1, Point p2, Pen pen)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.pen = new Pen(color, size);
            this.color = pen.Color;
            this.size = (int)pen.Width;

        }

        public Point P2 { get => p2; set => p2= value; }
        public Point P1 { get => p1; set => p1 = value; }


        #endregion




    }
}

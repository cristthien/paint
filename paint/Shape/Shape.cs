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
        public Point p1;
        public Point p2;
        public Color color;
        public int size;
        public Pen pen;
        public bool isPoint1 =false;

        #endregion

        #region Methods
        // Constructor
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
        public abstract void DrawShape(Graphics g);
        public abstract void DrawResizePoint(Graphics g);
        public abstract Cursor ChangeCursor(Point location);
        public abstract bool IsResizePioint(Point location);
        public abstract bool IsInsideShape(Point location);
        public abstract void IsPoint1(Point location);


            #endregion




        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace paint.Shapes
{
    public abstract class Shape
    {
        #region Properties
        public Point p1;
        public Point p2;
        public Pen pen;

        #endregion

        #region Methods
        // Constructor
        public Shape(Point p1, Point p2,Color color, int size ) {
            this.p1 = p1;
            this.p2 = p2;
            this.pen = new Pen(color,size);
        }

        public Shape() {
            this.p1 = Point.Empty;
            this.p2 = Point.Empty;
            this.pen = new Pen(Color.Black, 1);
        }
        public abstract void DrawShape(Graphics g);

        #endregion




    }
}

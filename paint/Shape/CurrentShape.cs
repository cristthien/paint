using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.Shapes
{
    public class CurrentShape
    {

        #region Properties 
        Shape shape;
        #endregion
        #region Construtor
        public CurrentShape(Shape shape)
        {
            this.shape = shape;
        }
        #endregion
        #region Methods

        public void UpdateShape(Point p1, Point p2, Pen pen)
        {
            shape.UpdateShape(p1, p2, pen);
        }

        public void DetechPoint(Point location) {
            shape.DetectPoint(location);
        }

        public void UpdateP2(Point location) {
            shape.UpdateP2(location);
        }

        public Cursor ChangeCursor(Point location) {
            return shape.ChangeCursor(location);
        }
        public void InitMovingPosition(Point location ){
            shape.InitMovingPosition(location);
        }
        public void ChangeSize(Point location) {
            shape.ChangeSize(location);
        }

        public void MovingShape(Point  location) {
            shape.MovingShape(location);

        }
        public void DrawShape(Graphics g)
        {
            shape.DrawShape(g);
        }

        public void DrawResizePoint(Graphics g) {
            shape.DrawResizePoint(g);
        }

        #endregion

    }
}
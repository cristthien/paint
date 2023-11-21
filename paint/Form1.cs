using paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {

        #region Properties
        Status status = Status.GetInstance();
        Bitmap bmp;
        Graphics g;
        Color currColor;
        int penSize;
        Pen pen;
        Shape currShape;
        Bitmap oldBmp;
        Point changePosition;
        #endregion

        public Form1()
        {
            InitializeComponent();
            currColor = Color.Black;
            presentColor.BackColor = currColor;
            penSize = 5;
            pen = new Pen(currColor, penSize);
            bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = bmp;
            g = Graphics.FromImage(bmp);
            oldBmp = new Bitmap(drawArea.Width, drawArea.Height);
            changePosition= Point.Empty;

        }
        private void ExistDrawingMode() {
            status.Reset();
            currShape = null;
        
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pencil_btn_Click(object sender, EventArgs e)
        {

        }

        private void presentColor_Click(object sender, EventArgs e)
        {

        }

        private void blackColor_btn_Click(object sender, EventArgs e)
        {

        }

        // Handle click
        private void drawArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (status.IsDrawingNormalShape && !status.IsSelectedShape) {
                
                oldBmp = (Bitmap)bmp.Clone();
                currShape.p1 = e.Location;
                currShape.p2 = e.Location;
                currShape.pen = pen;
                status.IsChangingShape = true;
                TestBox.Text = "MouseDown";

            } else if (status.IsSelectedShape) {


                if (this.Cursor == Cursors.SizeNS)
                {
                    currShape.IsPoint1(e.Location);
                    status.IsResizeMouseDown = true;
                } else if (this.Cursor ==Cursors.SizeAll) {
                    status.IsMovingMouseDown = true;
                    changePosition = e.Location;
                    TestBox.Text = "MovingMouseDown";

                }
                else {
                    status.IsSelectedShape = false;
                    bmp = (Bitmap)oldBmp.Clone();
                    g = Graphics.FromImage(bmp);
                    currShape.DrawShape(g);
                    oldBmp = (Bitmap)bmp.Clone();
                    currShape.p1 = e.Location;
                    currShape.p2 = e.Location;
                    currShape.pen = pen;
                    status.IsChangingShape = true;
                    status.IsSelectedShape = false;
                    TestBox.Text = "MouseDown";


                }
            }
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {

            if ((status.IsDrawingNormalShape && status.IsChangingShape))
            {
                currShape.p2 = e.Location;
            } else if (status.IsSelectedShape) {
                this.Cursor = currShape.ChangeCursor(e.Location);
                if (status.IsResizeMouseDown) {

                    if (currShape.isPoint1)
                    {
                        currShape.p1 = e.Location;
                    }
                    else {
                        currShape.p2 = e.Location;
                    }
                } else if (status.IsMovingMouseDown)
                {
                    Point P1 = currShape.p1;
                    Point P2 = currShape.p2;

                    int distanceX = e.Location.X - changePosition.X;
                    int distanceY = e.Location.Y - changePosition.Y;

                    currShape.p1 = new Point(P1.X +distanceX, P1.Y+distanceY);
                    currShape.p2 = new Point(P2.X+ distanceX,  P2.Y +distanceY);
                    changePosition = e.Location;


                }
            } 

            drawArea.Image = bmp;
        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if ((status.IsDrawingNormalShape && status.IsChangingShape) || status.IsResizeMouseDown) {
                g = Graphics.FromImage(bmp);
                if (currShape.isPoint1)
                {
                    currShape.p1 = e.Location;
                }
                else
                {
                    currShape.p2 = e.Location;
                }

                currShape.DrawShape(g);

                TestBox.Text = "Mouseup";
                status.IsChangingShape = false;
                currShape.DrawResizePoint(g);
                status.IsSelectedShape = true;
                if (status.IsResizeMouseDown) {
                    status.IsResizeMouseDown = !status.IsResizeMouseDown;
                } 

            } else if (status.IsMovingMouseDown) {
                g = Graphics.FromImage(bmp);
                g.DrawLine(currShape.pen, currShape.p1, currShape.p2);
                TestBox.Text = "Mouseup";
                currShape.DrawResizePoint(g);
                status.IsMovingMouseDown = !status.IsMovingMouseDown;

            }
            drawArea.Image = bmp;

        }

        // line
        private void line_btn_Click(object sender, EventArgs e)
        {
            currShape = new Line(Point.Empty, Point.Empty,currColor, penSize);
            TestBox.Text = "Line";
            status.IsDrawingNormalShape = true;

        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if ((status.IsDrawingNormalShape && status.IsChangingShape) || status.IsResizeMouseDown || status.IsMovingMouseDown)
            {
                TestBox.Text = "Paintting";
                if (status.IsResizeMouseDown || status.IsMovingMouseDown) {
                    bmp = (Bitmap)oldBmp.Clone();
                    g = Graphics.FromImage(bmp);
                }
                currShape.DrawShape(g);
            }
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            ExistDrawingMode();
            TestBox.Text = "undo";
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            drawArea.Image = bmp;
        }
    }
}

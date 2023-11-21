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
        #endregion

        public Form1()
        {
            InitializeComponent();
            currColor = Color.FromArgb(2,7,199);
            presentColor.BackColor = currColor;
            penSize = 2;
            pen = new Pen(currColor, penSize);
            bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = bmp;
            g = Graphics.FromImage(bmp);
            oldBmp = new Bitmap(drawArea.Width, drawArea.Height);



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
            if (status.IsDrawingNormalShape) {
                oldBmp = (Bitmap)bmp.Clone();
                currShape.p1 = e.Location;
                currShape.p2 = e.Location;
                currShape.pen = pen;
                status.IsChangingShape = true;
                TestBox.Text = "MouseDown";


      
            }
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {

            if (status.IsDrawingNormalShape && status.IsChangingShape)
            {

               
            currShape.p2 = e.Location;

            }

            drawArea.Image = bmp;
        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (status.IsDrawingNormalShape && status.IsChangingShape) {
                
                currShape.p2 = e.Location;
                g.DrawLine(currShape.pen,  currShape.p1, currShape.p2);
                
                TestBox.Text = "Mouseup";
                status.IsChangingShape = false;



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
            if (status.IsDrawingNormalShape && status.IsChangingShape)
            {
                
                g.DrawLine(currShape.pen, currShape.p1, currShape.p2);
            }
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            TestBox.Text = "undo";
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            drawArea.Image = bmp;
        }
    }
}

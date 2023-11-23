using paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        ColorDialog cd;



        Pen eraser;
        int index;
        bool PenPaint = false;
        Point px, py;
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
            changePosition = Point.Empty;
            cd = new ColorDialog();
            eraser = new Pen(Color.White, 10);
            index=0;
            PenPaint = false;


        }
        private void ExistDrawingShapeMode() {
            status.Reset();
            currShape = null;
        }
        private void ChangeFunction()
        {
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            currShape.DrawShape(g);
            oldBmp = (Bitmap)bmp.Clone();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pencil_btn_Click(object sender, EventArgs e)
        {
            if (currShape == null)
            {
                currShape = new Line(Point.Empty, Point.Empty, currColor, penSize);
            }
            oldBmp= (Bitmap)bmp.Clone();
            ChangeFunction();
            ExistDrawingShapeMode();
            index = 1;
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
                    currShape.DetectPoint(e.Location);
                    status.IsResizeMouseDown = true;
                } else if (this.Cursor ==Cursors.SizeAll) {
                    status.IsMovingMouseDown = true;
                    changePosition = e.Location;
                    TestBox.Text = "MovingMouseDown";

                }
                else {
                    status.IsSelectedShape = false;
                    ChangeFunction();
                    currShape.p1 = e.Location; 
                    currShape.p2 = e.Location;
                    currShape.pen = pen;
                    status.IsChangingShape = true;
                    status.IsSelectedShape = false;
                    TestBox.Text = "MouseDown";


                }
            }else 
            {
                
                
                PenPaint = true;
                py = e.Location;
            }
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (PenPaint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                
            } else if ((status.IsDrawingNormalShape && status.IsChangingShape))
            {
                currShape.p2 = e.Location;
            } else if (status.IsSelectedShape) {
                this.Cursor = currShape.ChangeCursor(e.Location);
                if (status.IsResizeMouseDown) {
                    currShape.ChangeSize(e.Location); 
                }
                else if (status.IsMovingMouseDown)
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

            if ((status.IsDrawingNormalShape && status.IsChangingShape) || status.IsResizeMouseDown) {
                g = Graphics.FromImage(bmp);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                // Xu ly lai cho nay 

                if (status.IsDrawingNormalShape && status.IsChangingShape)
                {

                    currShape.p2 = e.Location;
                }
                else {
                    currShape.ChangeSize(e.Location);

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
                g.SmoothingMode = SmoothingMode.AntiAlias;
                currShape.DrawShape(g);
                TestBox.Text = "Mouseup";
                currShape.DrawResizePoint(g);
                status.IsMovingMouseDown = !status.IsMovingMouseDown;

            }
            else {
                PenPaint = false;
            }
            drawArea.Image = bmp;

        }

        // line
        private void line_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();

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
            ExistDrawingShapeMode();
            TestBox.Text = "undo";
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            drawArea.Image = bmp;
        }

        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            currShape = new Rectangles(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Rectangle";
            status.IsDrawingNormalShape = true;
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
                
            }
            ExistDrawingShapeMode();
            currShape = new Squares(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Square";
            status.IsDrawingNormalShape = true;
        }

        private void oval_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();

            currShape = new Ellip(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Ellip";
            status.IsDrawingNormalShape = true;
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();
            currShape = new Cir(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Circle";
            status.IsDrawingNormalShape = true;
        }

        private void star_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();
            currShape = new Trigonal(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Trigonal";
            status.IsDrawingNormalShape = true;
        }

        private void pentagon_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();
            currShape = new Hexagon(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Hexagon";
            status.IsDrawingNormalShape = true;
        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
            var saveImage = new SaveFileDialog();
            saveImage.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bmp.Clone(new Rectangle(0, 0, drawArea.Width, drawArea.Height), bmp.PixelFormat);
                btm.Save(saveImage.FileName, ImageFormat.Jpeg);
            }
        }

        private void eraser_btn_Click(object sender, EventArgs e)
        {
            if (currShape == null)
            {
                currShape = new Line(Point.Empty, Point.Empty, currColor, penSize);
            }
            oldBmp = (Bitmap)bmp.Clone();
            ChangeFunction();
            ExistDrawingShapeMode();
            index = 2;
        }

        private void drawArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7&& !status.IsDrawingNormalShape)
            {
                Point point = set_point(drawArea, e.Location);
                Fill(bmp, point.X, point.Y, currColor);
            }
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;

            return new Point((int)(pt.X * pX), (int)(pt.Y * pX));
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bmp.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bmp.SetPixel(x, y, new_clr);

            if (old_color == new_clr)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void formatColorFill_btn_Click(object sender, EventArgs e)
        {
            if (currShape == null)
            {
                currShape = new Line(Point.Empty, Point.Empty, currColor, penSize);
            }
            oldBmp = (Bitmap)bmp.Clone();
            ChangeFunction();
            ExistDrawingShapeMode();
            index = 7;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bmp.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        private void triangle_btn_Click(object sender, EventArgs e)
        {
            if (status.IsSelectedShape)
            {
                ChangeFunction();
            }
            ExistDrawingShapeMode();
            currShape = new Trigonal(Point.Empty, Point.Empty, currColor, penSize);
            TestBox.Text = "Trigonal";
            status.IsDrawingNormalShape = true;
        }

        private void LinenColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Linen;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void color_panel_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            currColor = cd.Color;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void whiteColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.White;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            currColor = Color.LightPink;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void grayColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Gray;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currColor = Color.Silver;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void LavenderBlushColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.LavenderBlush;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;

        }

        private void dimGrayColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.DimGray;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;

        }

        private void FireBrickColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Firebrick;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;

        }

        private void IvoryColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Ivory;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void blackColor_btn_Click_1(object sender, EventArgs e)
        {
            currColor = Color.Black;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void TanColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Tan;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void LimeColor_btn_Click(object sender, EventArgs e)
        {
            currColor = Color.Lime;
            presentColor.BackColor = cd.Color;
            pen.Color = currColor;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            oldBmp = new Bitmap(drawArea.Width, drawArea.Height);
            bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = bmp;
            currShape = new Line(Point.Empty, Point.Empty, currColor, penSize);
        }
    }
}

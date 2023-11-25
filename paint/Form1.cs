using paint.Management;
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
        // configuration variable
        Status status = Status.GetInstance();
        PenStatus penStatus = PenStatus.Instance();
        
        // Bitmap variable
        Bitmap bmp;
        Graphics g;
        Bitmap oldBmp;
        // Shape
        CurrentShape currShape;

        ColorDialog cd;
        private Image i;
        Pen eraser;
        int index;
        bool PenPaint = false;
        Point px, py;

        #endregion

        public Form1()
        {
            InitializeComponent();
            #region Initialize 
            // Shape
            presentColor.BackColor = penStatus.CurrColor;
            currShape = new CurrentShape(new Line(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
            
            // Bitmap 
            bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = bmp;
            g = Graphics.FromImage(bmp);
            oldBmp = new Bitmap(drawArea.Width, drawArea.Height);
            
            // External Function
            cd = new ColorDialog();
            eraser = new Pen(Color.White, 10);
            index = 0;
            PenPaint = false;
            #endregion

        }
        #region Handle Get Out and Into Mode 
        private void ExistDrawingMode()
        {
            status.Reset();
            currShape = new CurrentShape(new Line(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
            index = 0;
        }
        private void DrawOldShape()
        {
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            currShape.DrawShape(g);
            oldBmp = (Bitmap)bmp.Clone();
        }
        public void ChangeIntoDrawingFunction() {
            if (index == 0)
            {
                DrawOldShape();
            }else
            {
                oldBmp = (Bitmap)bmp.Clone();
            }
            ExistDrawingMode();
        }
        public void ChangeIntoShapeFunction()
        {

            if (status.IsSelectedShape)
            {
                DrawOldShape();
            }
            ExistDrawingMode();
            status.IsDrawingNormalShape = true;
        }
        #endregion

        #region Handle Drawing Click
        private void drawArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (status.IsDrawingNormalShape && !status.IsSelectedShape) {
                
                oldBmp = (Bitmap)bmp.Clone();

                currShape.UpdateShape(e.Location, e.Location, penStatus.Pens);

                status.IsChangingShape = true;

               

            } else if (status.IsSelectedShape) {


                if (this.Cursor == Cursors.SizeNS)
                {
                    currShape.DetechPoint(e.Location);
                    status.IsResizeMouseDown = true;
                } else if (this.Cursor ==Cursors.SizeAll) {
                    status.IsMovingMouseDown = true;
                    currShape.InitMovingPosition(e.Location);

                }
                else {
                    status.IsSelectedShape = false;
                    DrawOldShape();
                    currShape.UpdateShape(e.Location, e.Location, penStatus.Pens);
                    status.IsChangingShape = true;
                    status.IsSelectedShape = false;


                }
            }else 
            {
                PenPaint = true;
                py = e.Location;
                oldBmp = (Bitmap)bmp.Clone();
            }
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (PenPaint)
            {
                
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(penStatus.Pens, px, py);
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
                currShape.UpdateP2(e.Location);
            } else if (status.IsSelectedShape) {
                this.Cursor = currShape.ChangeCursor(e.Location);
                if (status.IsResizeMouseDown) {
                    currShape.ChangeSize(e.Location); 
                }
                else if (status.IsMovingMouseDown)
                {
                    currShape.MovingShape(e.Location);


                }
            } 

            drawArea.Image = bmp;
        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {

            if ((status.IsDrawingNormalShape && status.IsChangingShape) || status.IsResizeMouseDown) {

                g = Graphics.FromImage(bmp);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                if (status.IsDrawingNormalShape && status.IsChangingShape)
                {
                    currShape.UpdateP2(e.Location);
                }
                else {
                    currShape.ChangeSize(e.Location);
                }

                currShape.DrawShape(g);

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
                currShape.DrawResizePoint(g);
                status.IsMovingMouseDown = !status.IsMovingMouseDown;

            }
            else {
                PenPaint = false;
            }
            drawArea.Image = bmp;

        }
        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if ((status.IsDrawingNormalShape && status.IsChangingShape) || status.IsResizeMouseDown || status.IsMovingMouseDown)
            {
                if (status.IsResizeMouseDown || status.IsMovingMouseDown)
                {
                    bmp = (Bitmap)oldBmp.Clone();
                    g = Graphics.FromImage(bmp);
                }
                currShape.DrawShape(g);
            }
        }
        #endregion

        #region Handle Shape Function by Nguyen Huu Thien

        private void line_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Line(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
        }

        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Rectangles(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));   
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Squares(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
        }

        private void oval_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Ellip(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
             
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Cir(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
             
        }
        private void triangle_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Trigonal(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));   
        }

        private void pentagon_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoShapeFunction();
            currShape = new CurrentShape(new Hexagon(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
        }
        #endregion

        #region External function by Nguyen Dai Anh Tuan 
        private void pencil_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoDrawingFunction();
            index = 1;
        }
        private void eraser_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoDrawingFunction();
            index = 2;
        }
        private void formatColorFill_btn_Click(object sender, EventArgs e)
        {
            ChangeIntoDrawingFunction();
            index = 7;
        }
        private void undo_btn_Click(object sender, EventArgs e)
        {
            ExistDrawingMode();
            bmp = (Bitmap)oldBmp.Clone();
            g = Graphics.FromImage(bmp);
            drawArea.Image = bmp;
        }
        private void saveFile_btn_Click(object sender, EventArgs e)
        {

            SaveFileDialog svf = new SaveFileDialog();

            string imgName = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "_" + DateTime.Now.Hour;
            svf.FileName = imgName;
            if (svf.ShowDialog() == DialogResult.OK)
            {
                drawArea.Image.Save(svf.FileName);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            penStatus.UpdatePenSize(int.Parse(comboBox1.SelectedItem.ToString()));
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            oldBmp = new Bitmap(drawArea.Width, drawArea.Height);
            bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = bmp;
            currShape = new CurrentShape(new Line(Point.Empty, Point.Empty, penStatus.CurrColor, penStatus.Size));
        }
        private void openFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                i = Image.FromFile(ofd.FileName);
                bmp = (Bitmap)i;
                oldBmp = (Bitmap)i;
                drawArea.Image = bmp;
            }
        }
        private void drawArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7&& !status.IsDrawingNormalShape)
            {
                Point point = set_point(drawArea, e.Location);
                Fill(bmp, point.X, point.Y, penStatus.CurrColor);
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


        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bmp.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        #endregion

        #region Handle Change Color
        public void SetColor(Color color)
        {
            penStatus.UpdatePenColor(color);
            presentColor.BackColor = color;

        }
        private void LinenColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Linen);
        }

        private void color_panel_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            SetColor(cd.Color);
        }

        private void whiteColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetColor(Color.LightPink);
        }

        private void grayColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Gray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetColor(Color.Silver);
        }

        private void LavenderBlushColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.LavenderBlush);

        }

        private void dimGrayColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.DimGray);

        }

        private void FireBrickColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Firebrick);
        }

        private void IvoryColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Ivory);
        }

        private void blackColor_btn_Click_1(object sender, EventArgs e)
        {
            SetColor(Color.Black);
        }

        private void TanColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Tan);
        }

        private void LimeColor_btn_Click(object sender, EventArgs e)
        {
            SetColor(Color.Lime);
        }
        #endregion


    }
}

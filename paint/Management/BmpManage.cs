using paint.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint.Management
{
    public class BmpManage
    {
        static BmpManage instance;
        private Bitmap bmp;
        private Bitmap oldBmp;
        private Graphics g;
        private PictureBox drawArea;

        public Graphics G { get => g; set => g = value; }
        public Bitmap Bmp { get => bmp; set => bmp = value; }
        public Bitmap OldBmp { get => oldBmp; set => oldBmp = value; }

        protected BmpManage(PictureBox drawArea)
        {
            Bmp = new Bitmap(drawArea.Width, drawArea.Height);
            this.drawArea = drawArea;
            drawArea.Image = Bmp;
            G = Graphics.FromImage(Bmp);
            OldBmp = new Bitmap(drawArea.Width, drawArea.Height);
        }
        public void ResetBitmap() {

            g.Clear(Color.White);
            OldBmp = new Bitmap(drawArea.Width, drawArea.Height);
            Bmp = new Bitmap(drawArea.Width, drawArea.Height);
            drawArea.Image = Bmp;
        }
        public void CloneToOldBmp() {
            OldBmp = (Bitmap)Bmp.Clone();
        }
        public void DrawOldShape(CurrentShape currShape)
        {
            Bmp = (Bitmap)OldBmp.Clone();
            G = Graphics.FromImage(Bmp);
            G.SmoothingMode = SmoothingMode.AntiAlias;
            currShape.DrawShape(G);
            OldBmp = (Bitmap)Bmp.Clone();
        }
        public void BitmapRefesh()
        {
            drawArea.Image = Bmp;
        }
        public void ChangeIntoDrawingFunction(int index, CurrentShape currShape)
        {
            if (index == 0)
            {
                DrawOldShape(currShape);
            }
            else
            {
                OldBmp = (Bitmap)Bmp.Clone();
            }
        }
        public void ChangeIntoShapeFunction(Status status, CurrentShape currShape)
        {

            if (status.IsSelectedShape)
            {
                DrawOldShape(currShape);
            }

        }
        public void AsignBitmap() {
            g = Graphics.FromImage(Bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

        }
        public void DrawCurrentShape(CurrentShape currShape)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            currShape.DrawShape(g);


        }
        public void DrawResizePoints(CurrentShape currShape) {
            currShape.DrawResizePoint(g);
        }
        public void DrawShapeAfterMoving(CurrentShape currShape)
        {
            g = Graphics.FromImage(Bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            currShape.DrawShape(g);
            currShape.DrawResizePoint(g);

        }
        public void CloneToBmp()
        {

            Bmp = (Bitmap)OldBmp.Clone();
            g = Graphics.FromImage(Bmp);
        }
        public static BmpManage Instance(PictureBox drawArea)
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new BmpManage(drawArea);
            }
            return instance;
        }
    }
}

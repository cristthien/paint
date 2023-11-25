using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint.Management
{
    public class PenStatus
    {
        #region Properties 
        static PenStatus instance;

        private Color currColor;
        private int size;
        private Pen pen;

        #endregion

        #region Contructor 
        protected PenStatus() {
            currColor = Color.Black;
            size = 5;
            pen = new Pen(Color.Black, 5);
        }
        #endregion 


        #region  Get Set

        public Color CurrColor { get => currColor; set => currColor = value; }
        public int Size { get => size; set => size = value; }
        public Pen Pens { get => pen; set => pen = value; }
        public Color Color { get; internal set; }
        #endregion

        #region Mothods

        public static PenStatus Instance()
        {
            if (instance == null)
            {
                instance = new PenStatus();
            }
            return instance;
        }
        public void UpdatePenColor(Color value) {
            currColor = value;
            pen = new Pen(value, size);
        }
        public void UpdatePenSize(int value)
        {
            size = value;
            pen = new Pen(currColor, value);
        }
        #endregion



    }
}

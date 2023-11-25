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
        static PenStatus instance;

        private Color currColor;
        private int size;
        private Pen pen;

        protected PenStatus() {
            currColor = Color.Black;
            size = 5;
            pen = new Pen(Color.Black, 5);
        }

        public Color CurrColor { get => currColor; set => currColor = value; }
        public int Size { get => size; set => size = value; }
        public Pen Pens { get => pen; set => pen = value; }
        public Color Color { get; internal set; }

        public static PenStatus Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
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



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public class Status
    {
        private static Status instance;

        private bool isDrawingNormalShape = false;
        private bool isChangingShape = false;
        private bool isSelectedShape = false;

        private Status()
        {
        }

        public static Status GetInstance()
        {
            if (instance == null)
            {
                instance = new Status();
            }

            return instance;
        }

        public bool IsDrawingNormalShape
        {
            get { return isDrawingNormalShape; }
            set { isDrawingNormalShape = value; }
        }

        public bool IsChangingShape { get => isChangingShape; set => isChangingShape = value; }
        public bool IsSelectedShape { get => isSelectedShape; set => isSelectedShape = value; }
    }
}

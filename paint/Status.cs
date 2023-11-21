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
        private bool isResizeMouseDown = false;
        private bool isMovingMouseDown = false;


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
        public void Reset()
        {
            isDrawingNormalShape = false;
            isChangingShape = false;
            isSelectedShape = false;
            isMovingMouseDown = false;
            isResizeMouseDown = false;
        }

        public bool IsChangingShape { get => isChangingShape; set => isChangingShape = value; }
        public bool IsSelectedShape { get => isSelectedShape; set => isSelectedShape = value; }
       
        public bool IsResizeMouseDown { get => isResizeMouseDown; set => isResizeMouseDown = value; }
        public bool IsMovingMouseDown { get => isMovingMouseDown; set => isMovingMouseDown = value; }
    }
}

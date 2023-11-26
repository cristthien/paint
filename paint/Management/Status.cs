using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint
{
    public class Status
    {
        #region Properties 
        private static Status instance;

        private bool isDrawingNormalShape ;
        private bool isChangingShape ;
        private bool isSelectedShape ;
        private bool isResizeMouseDown;
        private bool isMovingMouseDown;
        #endregion
        #region Constructor 
        private Status()
        {
            isDrawingNormalShape = false;
            isChangingShape = false;
            isSelectedShape = false;
            isMovingMouseDown = false;
            isResizeMouseDown = false;

        }
        #endregion


        #region Get Set 
        public bool IsDrawingNormalShape
        {
            get { return isDrawingNormalShape; }
            set { isDrawingNormalShape = value; }
        }

        public bool IsChangingShape { get => isChangingShape; set => isChangingShape = value; }
        public bool IsSelectedShape { get => isSelectedShape; set => isSelectedShape = value; }
       
        public bool IsResizeMouseDown { get => isResizeMouseDown; set => isResizeMouseDown = value; }
        public bool IsMovingMouseDown { get => isMovingMouseDown; set => isMovingMouseDown = value; }
        #endregion

        #region Methods
        public static Status GetInstance()
        {
            if (instance == null)
            {
                instance = new Status();
            }
            return instance;
        }
        public void Reset()
        {
            isDrawingNormalShape = false;
            isChangingShape = false;
            isSelectedShape = false;
            isMovingMouseDown = false;
            isResizeMouseDown = false;
        }
        #endregion


    }
}

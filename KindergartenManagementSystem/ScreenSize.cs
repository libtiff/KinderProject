using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KindergartenManagementSystem
{
    class ScreenSize
    {
        int windowHeight;
        int windowWidth;

        public int getscreenHeight()
        {
            return windowHeight;
        }
        public int getscreenWidth()
        {
            return windowWidth;
        }
        //SetHeight
        public void setscreenHeight(int _Height)
        {
            windowHeight=_Height;
        }
        //SetWidth
        public void setscreenWidth(int _Width)
        {
            windowWidth=_Width;
        }
  
    }
}

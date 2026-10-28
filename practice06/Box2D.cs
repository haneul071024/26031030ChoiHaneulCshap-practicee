using practice06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice06
{
    class Box2D
    {
        private int width;
        public int height;

        public int width
        {
            set
            {
                if (value < 0)
                    return;
                width = value;
            }
            get
            {
                return width;
            }
        }
       
        public int height
        {
            get{ retrun height; }
            set
            {
                if (value < 0)
            }
    }
}

class UseBox
{
    public void UsingBox()
    {
        Box2D t = new Box2D();
    }
}
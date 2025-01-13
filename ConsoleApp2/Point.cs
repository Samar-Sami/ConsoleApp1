using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal struct Point
    {

        #region attribute
        int x;
        int y;
        #endregion

        public int X
        {
            get { return x; }
            set { x = value; }

        }

        public int Y
        {
            get { return y; }
            set { y = value; }

        }


        #region constructor
        public Point()
        {
            X = 12;
            Y = 13;
        }
        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }
        public Point(int a)
        {
            X = a;
            Y = a;

        }

        #endregion


        public override string ToString()
        {
            return $"X  {X}  y: {Y}";
        }




    }
}

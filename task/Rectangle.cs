using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal struct Rectangle
    {
        //4.Create a struct named Rectangle that represents a rectangle with the following field //
        //width(type: double)       //  height(type: double)

        double width;
        public double Width
        {  
            get { return width; } 
            set { 
                if(value < 0)
                    Console.WriteLine("You sholdnt Enter anegative value");
                else
                width = value; }
        }

        double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    Console.WriteLine("You sholdnt Enter anegative value");
                else
                    Height = value;
            }
        }


        public Rectangle(double width , double height)
        {
            this.width = width;
            this.height = height;
        }


        public double GetArea
        {
            get { return width * height; }

        }


        public double Area (double x, double y)
        {
            return width * height;
        }


        public override string ToString()
        {
            return $"width :{width}  height: {height}  area :{GetArea}";
        }
    }
}

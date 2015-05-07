using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape
{
    class Cylinder:ObjectType
    {
        private double radius;
        public double height;
        public Cylinder(double r,double h)
        {
            this.radius = r;
            height = h;
        }
        private static double pi = 3.1415926;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                    radius = 0;
                else
                    radius = value;
            }
        }
        public override double Volume()
        {
            return radius*radius*pi*height;
        }
        //public double Mass()
        //{
        //    return Volume() * density;
        //}
        public override string StringShape()
        {
            string str = "";
            str += string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8:F2}", height);
            return str;
        }
        //public string StringProperties()
        //{
        //    string str = "";
        //    str += StringShape();
        //    str += "\t";
        //    str += Volume().ToString();
        //    str += "\t";
        //    str += Mass().ToString();
        //    return str;

        //}
    }
}

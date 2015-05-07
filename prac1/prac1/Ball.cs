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
    class ball:ObjectType
    {
        private double radius;
        public ball(double radius)
        {
            this.radius = radius; 
        }
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
        private static double pi = 3.1415926;
        public override double Volume()
        {
            return 4 / 3 * pi * Math.Pow(radius, 3);
        }
        //public double Mass()
        //{
        //    return Volume() * density;
        //}
        public override string StringShape()
        {
            string str = "";
            str += string.Format("{0,10}","ball");
            str += "\t";
            str += string.Format("{0,8:F2}",radius);
            str += "\t";
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

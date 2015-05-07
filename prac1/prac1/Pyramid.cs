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
    class Pyramid:ObjectType
    {
        private double side;
        public double height;
        public Pyramid(double s,double h)
        {
            this.side = s;
            height = h;
        }
        public double Side
        {
            get { return side; }
            set
            {
                if (side < 0)
                    side = 0;
                else
                    side = value;
            }
        }
        public override double Volume()
        {
            return side * side* height/3;
        }
        //public double Mass()
        //{
        //    return Volume() * density;
        //}
        public override string StringShape()
        {
            string str = "";
            str += string.Format("{0,8}", "pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}",side);
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

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
    class Cube:ObjectType
    {
        private double side;
        public Cube(double s)
        {
            this.side = s; 
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
            return side*side*side;
        }
        //public double Mass()
        //{
        //    return Volume() * density;
        //}
        public override string StringShape()
        {
            string str = "";
            str += string.Format("{0,8}", "cube");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
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


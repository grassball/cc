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
    class ObjectType
    {
        public double density;
        public string StringMaterial;
        private static int amount=0;
        public static int Amount
        {
            get { return amount; }
            set 
            {
                    amount = value;
            }
        }
        public ObjectType()
        { 
            amount++;
        }
        public virtual double Volume()
        {
            return 0;
        }
        public double Mass()
        {
            return Volume() * density;
        }
        public virtual string StringShape()
        {
            return "";
        }
        public string StringProperties()
        {
            string str = "";
            str += string.Format("{0,8}",StringMaterial);
            str += "\t";
            str += StringShape();
            str += "\t";
            str += string.Format("{0,8:F2}", density);
            str += "\t";
            str += string.Format("{0,8:F2}",Volume());
            str += "\t";
            str += string.Format("{0,8:F2}",Mass())+"\r\n";
            return str;

        }
    }
}

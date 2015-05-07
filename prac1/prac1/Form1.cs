using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shape;

namespace prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void cBShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBShape.SelectedIndex)
            { 
                case 0://ball
                    label_radius.Text = "半徑";
                    label_height.Visible = false;
                    textBox_height.Visible = false;
                    break;
                case 1://cube
                    label_radius.Text = "邊長";
                    label_height.Visible = false;
                    textBox_height.Visible = false;
                    break;
                case 2://cylinder
                    label_radius.Text = "半徑";
                    label_height.Text = "高";
                    label_height.Visible = true;
                    textBox_height.Visible = true;
                    break;
                default://pyramid
                    label_radius.Text = "邊長";
                    label_height.Visible = true;
                    textBox_height.Visible = true;
                    break;
            }
        }
        ObjectType[] objectType =new ObjectType[10];
        double[] densityArr = { 2.70, 7.87, 11.35 };
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            int amount=ObjectType.Amount;
            if (amount >= 10)
                return;
            if (cBoxMaterial.Text == "")
            {
                MessageBox.Show( "Please choose the material.");
                return;
            }
            switch (cBShape.SelectedIndex)
            { 
                case 0:
                    objectType[amount] = new ball(Convert.ToDouble(txtBoxRadius.Text));
                    objectType[amount].density = densityArr[cBoxMaterial.SelectedIndex];
                    objectType[amount].StringMaterial = cBoxMaterial.Text;
                    break;
                case 1:
                    objectType[amount] = new Cube(Convert.ToDouble(txtBoxRadius.Text));
                    objectType[amount].density = densityArr[cBoxMaterial.SelectedIndex];
                    objectType[amount].StringMaterial = cBoxMaterial.Text;
                    break;
                case 2:
                    objectType[amount] = new Cylinder(Convert.ToDouble(txtBoxRadius.Text), Convert.ToDouble(textBox_height.Text));
                    objectType[amount].density = densityArr[cBoxMaterial.SelectedIndex];
                    objectType[amount].StringMaterial = cBoxMaterial.Text;
                    break;
                case 3:
                    objectType[amount] = new Pyramid(Convert.ToDouble(txtBoxRadius.Text), Convert.ToDouble(textBox_height.Text));
                    objectType[amount].density = densityArr[cBoxMaterial.SelectedIndex];
                    objectType[amount].StringMaterial = cBoxMaterial.Text;
                    break;
                default:
                    MessageBox.Show("Please choose the shape.");
                    return;
                    
            }
            textBox_shape.AppendText(objectType[amount].StringShape()+"\r\n");
            textBox_amount.Text = ObjectType.Amount.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ObjectType.Amount; i++)
            {
                textBox_Properties.AppendText((i+1).ToString()+"\t"+objectType[i].StringProperties());
            }
        }

    }
}

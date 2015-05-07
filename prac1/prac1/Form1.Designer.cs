namespace prac1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBShape = new System.Windows.Forms.ComboBox();
            this.txtBoxRadius = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_shape = new System.Windows.Forms.TextBox();
            this.textBox_Properties = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label_shape = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材質設定";
            // 
            // cBoxMaterial
            // 
            this.cBoxMaterial.FormattingEnabled = true;
            this.cBoxMaterial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cBoxMaterial.Location = new System.Drawing.Point(138, 21);
            this.cBoxMaterial.Name = "cBoxMaterial";
            this.cBoxMaterial.Size = new System.Drawing.Size(121, 20);
            this.cBoxMaterial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "材質類別";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_height);
            this.groupBox2.Controls.Add(this.label_radius);
            this.groupBox2.Controls.Add(this.label_shape);
            this.groupBox2.Controls.Add(this.textBox_height);
            this.groupBox2.Controls.Add(this.txtBoxRadius);
            this.groupBox2.Controls.Add(this.cBShape);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀設定";
            // 
            // cBShape
            // 
            this.cBShape.FormattingEnabled = true;
            this.cBShape.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cBShape.Location = new System.Drawing.Point(137, 22);
            this.cBShape.Name = "cBShape";
            this.cBShape.Size = new System.Drawing.Size(121, 20);
            this.cBShape.TabIndex = 0;
            this.cBShape.SelectedIndexChanged += new System.EventHandler(this.cBShape_SelectedIndexChanged);
            // 
            // txtBoxRadius
            // 
            this.txtBoxRadius.Location = new System.Drawing.Point(71, 60);
            this.txtBoxRadius.Name = "txtBoxRadius";
            this.txtBoxRadius.Size = new System.Drawing.Size(76, 22);
            this.txtBoxRadius.TabIndex = 1;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(211, 60);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(71, 22);
            this.textBox_height.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_amount);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(13, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加shape";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(205, 32);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(76, 22);
            this.textBox_amount.TabIndex = 2;
            // 
            // textBox_shape
            // 
            this.textBox_shape.Location = new System.Drawing.Point(13, 285);
            this.textBox_shape.Multiline = true;
            this.textBox_shape.Name = "textBox_shape";
            this.textBox_shape.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_shape.Size = new System.Drawing.Size(287, 144);
            this.textBox_shape.TabIndex = 3;
            // 
            // textBox_Properties
            // 
            this.textBox_Properties.Location = new System.Drawing.Point(348, 53);
            this.textBox_Properties.Multiline = true;
            this.textBox_Properties.Name = "textBox_Properties";
            this.textBox_Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Properties.Size = new System.Drawing.Size(447, 376);
            this.textBox_Properties.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(348, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Location = new System.Drawing.Point(68, 29);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(31, 12);
            this.label_shape.TabIndex = 3;
            this.label_shape.Text = "shape";
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(25, 70);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(29, 12);
            this.label_radius.TabIndex = 4;
            this.label_radius.Text = "半徑";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(163, 70);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(17, 12);
            this.label_height.TabIndex = 5;
            this.label_height.Text = "高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "數量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox_Properties);
            this.Controls.Add(this.textBox_shape);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox txtBoxRadius;
        private System.Windows.Forms.ComboBox cBShape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox_shape;
        private System.Windows.Forms.TextBox textBox_Properties;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_shape;
        private System.Windows.Forms.Label label2;
    }
}


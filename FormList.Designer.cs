namespace Kursova_rabota_Etap2_2023
{
    partial class FormList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.buttonConcat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAreaFrom = new System.Windows.Forms.TextBox();
            this.textBoxAreaTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxTri = new System.Windows.Forms.CheckBox();
            this.checkBoxEll = new System.Windows.Forms.CheckBox();
            this.checkBoxRect = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxYFrom = new System.Windows.Forms.TextBox();
            this.textBoxYTo = new System.Windows.Forms.TextBox();
            this.textBoxXTo = new System.Windows.Forms.TextBox();
            this.textBoxXFrom = new System.Windows.Forms.TextBox();
            this.textBoxHeightTo = new System.Windows.Forms.TextBox();
            this.textBoxHeightFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWidthTo = new System.Windows.Forms.TextBox();
            this.textBoxWidthFrom = new System.Windows.Forms.TextBox();
            this.labelShCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(246, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(684, 384);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Default",
            "Area: Low to High",
            "Area: High to Low",
            "Width: Low to High",
            "Width: High to Low",
            "Height: Low to High",
            "Height: High to Low"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(808, 49);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(122, 24);
            this.comboBoxSortBy.TabIndex = 1;
            this.comboBoxSortBy.Text = "Default";
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // buttonConcat
            // 
            this.buttonConcat.Location = new System.Drawing.Point(450, 502);
            this.buttonConcat.Name = "buttonConcat";
            this.buttonConcat.Size = new System.Drawing.Size(106, 38);
            this.buttonConcat.TabIndex = 3;
            this.buttonConcat.Text = "Concat";
            this.buttonConcat.UseVisualStyleBackColor = true;
            this.buttonConcat.Click += new System.EventHandler(this.buttonConcat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(824, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(246, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // textBoxAreaFrom
            // 
            this.textBoxAreaFrom.Location = new System.Drawing.Point(19, 138);
            this.textBoxAreaFrom.Name = "textBoxAreaFrom";
            this.textBoxAreaFrom.Size = new System.Drawing.Size(60, 22);
            this.textBoxAreaFrom.TabIndex = 11;
            // 
            // textBoxAreaTo
            // 
            this.textBoxAreaTo.Location = new System.Drawing.Point(113, 138);
            this.textBoxAreaTo.Name = "textBoxAreaTo";
            this.textBoxAreaTo.Size = new System.Drawing.Size(60, 22);
            this.textBoxAreaTo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBoxTri);
            this.groupBox1.Controls.Add(this.checkBoxEll);
            this.groupBox1.Controls.Add(this.checkBoxRect);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.textBoxYFrom);
            this.groupBox1.Controls.Add(this.textBoxYTo);
            this.groupBox1.Controls.Add(this.textBoxXTo);
            this.groupBox1.Controls.Add(this.textBoxXFrom);
            this.groupBox1.Controls.Add(this.textBoxHeightTo);
            this.groupBox1.Controls.Add(this.textBoxHeightFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxWidthTo);
            this.groupBox1.Controls.Add(this.textBoxWidthFrom);
            this.groupBox1.Controls.Add(this.textBoxAreaTo);
            this.groupBox1.Controls.Add(this.textBoxAreaFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 528);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "To";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "From";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "To";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "From";
            // 
            // checkBoxTri
            // 
            this.checkBoxTri.AutoSize = true;
            this.checkBoxTri.Location = new System.Drawing.Point(28, 83);
            this.checkBoxTri.Name = "checkBoxTri";
            this.checkBoxTri.Size = new System.Drawing.Size(86, 20);
            this.checkBoxTri.TabIndex = 30;
            this.checkBoxTri.Text = "Triangles";
            this.checkBoxTri.UseVisualStyleBackColor = true;
            // 
            // checkBoxEll
            // 
            this.checkBoxEll.AutoSize = true;
            this.checkBoxEll.Location = new System.Drawing.Point(28, 57);
            this.checkBoxEll.Name = "checkBoxEll";
            this.checkBoxEll.Size = new System.Drawing.Size(77, 20);
            this.checkBoxEll.TabIndex = 29;
            this.checkBoxEll.Text = "Ellipses";
            this.checkBoxEll.UseVisualStyleBackColor = true;
            // 
            // checkBoxRect
            // 
            this.checkBoxRect.AutoSize = true;
            this.checkBoxRect.Location = new System.Drawing.Point(28, 31);
            this.checkBoxRect.Name = "checkBoxRect";
            this.checkBoxRect.Size = new System.Drawing.Size(98, 20);
            this.checkBoxRect.TabIndex = 28;
            this.checkBoxRect.Text = "Rectangles";
            this.checkBoxRect.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 486);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 32);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(113, 486);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(78, 32);
            this.buttonApply.TabIndex = 26;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxYFrom
            // 
            this.textBoxYFrom.Location = new System.Drawing.Point(19, 435);
            this.textBoxYFrom.Name = "textBoxYFrom";
            this.textBoxYFrom.Size = new System.Drawing.Size(60, 22);
            this.textBoxYFrom.TabIndex = 25;
            // 
            // textBoxYTo
            // 
            this.textBoxYTo.Location = new System.Drawing.Point(113, 435);
            this.textBoxYTo.Name = "textBoxYTo";
            this.textBoxYTo.Size = new System.Drawing.Size(60, 22);
            this.textBoxYTo.TabIndex = 24;
            // 
            // textBoxXTo
            // 
            this.textBoxXTo.Location = new System.Drawing.Point(112, 363);
            this.textBoxXTo.Name = "textBoxXTo";
            this.textBoxXTo.Size = new System.Drawing.Size(60, 22);
            this.textBoxXTo.TabIndex = 23;
            // 
            // textBoxXFrom
            // 
            this.textBoxXFrom.Location = new System.Drawing.Point(18, 363);
            this.textBoxXFrom.Name = "textBoxXFrom";
            this.textBoxXFrom.Size = new System.Drawing.Size(60, 22);
            this.textBoxXFrom.TabIndex = 22;
            // 
            // textBoxHeightTo
            // 
            this.textBoxHeightTo.Location = new System.Drawing.Point(113, 287);
            this.textBoxHeightTo.Name = "textBoxHeightTo";
            this.textBoxHeightTo.Size = new System.Drawing.Size(60, 22);
            this.textBoxHeightTo.TabIndex = 21;
            // 
            // textBoxHeightFrom
            // 
            this.textBoxHeightFrom.Location = new System.Drawing.Point(19, 287);
            this.textBoxHeightFrom.Name = "textBoxHeightFrom";
            this.textBoxHeightFrom.Size = new System.Drawing.Size(60, 22);
            this.textBoxHeightFrom.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(63, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(82, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(81, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Height";
            // 
            // textBoxWidthTo
            // 
            this.textBoxWidthTo.Location = new System.Drawing.Point(113, 216);
            this.textBoxWidthTo.Name = "textBoxWidthTo";
            this.textBoxWidthTo.Size = new System.Drawing.Size(60, 22);
            this.textBoxWidthTo.TabIndex = 15;
            // 
            // textBoxWidthFrom
            // 
            this.textBoxWidthFrom.Location = new System.Drawing.Point(19, 216);
            this.textBoxWidthFrom.Name = "textBoxWidthFrom";
            this.textBoxWidthFrom.Size = new System.Drawing.Size(60, 22);
            this.textBoxWidthFrom.TabIndex = 14;
            // 
            // labelShCount
            // 
            this.labelShCount.AutoSize = true;
            this.labelShCount.Location = new System.Drawing.Point(243, 47);
            this.labelShCount.Name = "labelShCount";
            this.labelShCount.Size = new System.Drawing.Size(10, 16);
            this.labelShCount.TabIndex = 15;
            this.labelShCount.Text = "i";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 552);
            this.Controls.Add(this.labelShCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonConcat);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.listBox1);
            this.Name = "FormList";
            this.Text = "List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button buttonConcat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAreaFrom;
        private System.Windows.Forms.TextBox textBoxAreaTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYFrom;
        private System.Windows.Forms.TextBox textBoxYTo;
        private System.Windows.Forms.TextBox textBoxXTo;
        private System.Windows.Forms.TextBox textBoxXFrom;
        private System.Windows.Forms.TextBox textBoxHeightTo;
        private System.Windows.Forms.TextBox textBoxHeightFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWidthTo;
        private System.Windows.Forms.TextBox textBoxWidthFrom;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxTri;
        private System.Windows.Forms.CheckBox checkBoxEll;
        private System.Windows.Forms.CheckBox checkBoxRect;
        private System.Windows.Forms.Label labelShCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
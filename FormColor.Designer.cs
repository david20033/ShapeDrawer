namespace Kursova_rabota_Etap2_2023
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelRGB = new System.Windows.Forms.Label();
            this.panelMoveColor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Selector";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(156, 537);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(103, 36);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(39, 295);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(0, 16);
            this.labelRGB.TabIndex = 3;
            // 
            // panelMoveColor
            // 
            this.panelMoveColor.BackColor = System.Drawing.SystemColors.Control;
            this.panelMoveColor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.panelMoveColor.Location = new System.Drawing.Point(254, 281);
            this.panelMoveColor.Name = "panelMoveColor";
            this.panelMoveColor.Size = new System.Drawing.Size(107, 40);
            this.panelMoveColor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGreen);
            this.groupBox1.Controls.Add(this.panelSelectedColor);
            this.groupBox1.Controls.Add(this.textBoxBlue);
            this.groupBox1.Controls.Add(this.textBoxRed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Color";
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(79, 91);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(87, 22);
            this.textBoxGreen.TabIndex = 7;
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged_1);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGreen_KeyPress_1);
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Location = new System.Drawing.Point(222, 66);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(107, 44);
            this.panelSelectedColor.TabIndex = 6;
            this.panelSelectedColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelectedColor_Paint);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxBlue.Location = new System.Drawing.Point(79, 138);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(88, 22);
            this.textBoxBlue.TabIndex = 5;
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlue_KeyPress);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(79, 43);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(88, 22);
            this.textBoxRed.TabIndex = 3;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Red";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMoveColor);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Color";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.Panel panelMoveColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.TextBox textBoxGreen;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_rabota_Etap2_2023
{
    public partial class FormProp : Form
    {
        private float width;
        private float height;
        private float x;
        private float y;
        private Color Fill;
        private Color tempFill;
        private Color Border;
        private Color tempBorder;
        private bool isApplied=false;
        public FormProp(String s,  float w, float h, float _x, float _y, Color fcolor, Color bcolor)
        {
            InitializeComponent();
            width = w;
            height = h;
            x = _x;
            y = _y;
            Fill = fcolor;
            tempFill = fcolor;
            Border = bcolor;
            tempBorder = bcolor;
            labelShape.Text = s;
            labelArea.Text = (w*h).ToString();
            textBoxWidth.Text = w.ToString();
            textBoxHeight.Text = h.ToString();
            textBoxX.Text = _x.ToString();
            textBoxY.Text = _y.ToString();
            panelColor.BackColor = fcolor;
            panelBorder.BackColor = bcolor;
        }

        private void DigitsOnly(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)
                || char.IsControl(e.KeyChar))
                return;
                e.Handled = true;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            isApplied = true;
            width=int.Parse(textBoxWidth.Text);
            height=int.Parse(textBoxHeight.Text);
            x=int.Parse(textBoxX.Text);
            y=int.Parse(textBoxY.Text);
           // color = tempC;
            Refresh();
            this.Close();
        }
        public float getWidth()
        {
            return width;
        }
        public float getHeight()
        {
            return height;
        }
        public float getX() 
        { 
            return x;
        }
        public float getY()
        {
            return y;
        }
        public Color getFillColor()
        {
            if (isApplied)
            {
                return Fill;
            }
            return tempFill;
        }
        public Color getBorderColor()
        {
            if (isApplied)
            {
                return Border;
            }
            return tempBorder;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormColor f = new FormColor(Fill);
            f.ShowDialog();
            Fill = f.getColor();
            panelColor.BackColor = Fill;
            Refresh();
        }
        private void buttonBorder_Click(object sender, EventArgs e)
        {
            FormColor f = new FormColor(Border);
            f.ShowDialog();
            Border = f.getColor();
            panelBorder.BackColor = Border;
            Refresh();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Fill = tempFill;
            Border = tempBorder;
            this.Close();
        }


        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e);
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        { 
            DigitsOnly(e);
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e);
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e);
        }

        private void panelBorder_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelColor.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void panelColor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelColor.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}

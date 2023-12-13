using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova_rabota_Etap2_2023
{
    public partial class FormColor : Form
    {
        private Color selectedColor;
        private Color color;
        private int red;
        private int green;
        private int blue;
        private bool isClicked;
        public FormColor(Color c)
        {
            InitializeComponent();
            selectedColor = c;
            panelSelectedColor.BackColor = selectedColor;
            color = c;
        }
        public Color getColor()
        {
            return color;
        }
        private void DigitsOnly(KeyPressEventArgs e, String textBoxText)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                int.Parse(textBoxText + e.KeyChar) > 255)
                && !char.IsControl(c))
            {
                e.Handled = true;
                MessageBox.Show("Max value for color is 255!", "Warning!");
            }

        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            isClicked = true;
            color = selectedColor;
            this.Close();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Bitmap pixels = (Bitmap)pictureBox1.Image;
                Color paletteColor = pixels.GetPixel(e.X, e.Y);
                selectedColor = paletteColor;
                textBoxRed.Text = paletteColor.R.ToString();
                textBoxGreen.Text = paletteColor.G.ToString();
                textBoxBlue.Text = paletteColor.B.ToString();
                panelSelectedColor.BackColor = paletteColor;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixels = (Bitmap)pictureBox1.Image;
            Color paletteColor;
            try
            {
                paletteColor = pixels.GetPixel(e.X, e.Y);
            }
            catch 
            {
                return;
            }
            panelMoveColor.BackColor = paletteColor;
            String R = paletteColor.R.ToString();
            String G = paletteColor.G.ToString();
            String B = paletteColor.B.ToString();
            labelRGB.Text = $"Red: {R} Green: {G} Blue: {B}";
        }

        private void textBoxRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e, textBoxRed.Text);
        }
        private void textBoxGreen_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e, textBoxGreen.Text);
        }
        private void textBoxBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitsOnly(e, textBoxBlue.Text);
        }
        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            String strRed = textBoxRed.Text;
            if (strRed.Length == 0)
            {
                green = 0;
                return;
            }
            red = int.Parse(strRed);
            selectedColor = Color.FromArgb(red, green, blue);
            panelSelectedColor.BackColor = selectedColor;
            Refresh();
        }
        private void textBoxGreen_TextChanged_1(object sender, EventArgs e)
        {
            String strGreen = textBoxGreen.Text;
            if (strGreen.Length == 0)
            {
                green = 0;
                return;
            }
            green = int.Parse(strGreen);
            selectedColor = Color.FromArgb(red, green, blue);
            panelSelectedColor.BackColor = selectedColor;
            Refresh();
        }
        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            String strBlue = textBoxBlue.Text;
            if (strBlue.Length == 0)
            {
                blue = 0;
                return;
            }
            blue = int.Parse(strBlue);
            selectedColor = Color.FromArgb(red, green, blue);
            panelSelectedColor.BackColor = selectedColor;
            Refresh();
        }
        public bool IsClicked()
        {
            return isClicked;
        }
        private void panelSelectedColor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelSelectedColor.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
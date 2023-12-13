using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.AxHost;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Kursova_rabota_Etap2_2023
{
    public abstract class Shape
    {
        private float X;
        private float Y;
        private float Width;
        private float Height;
        private Color FillColor;
        private Color BorderColor;
        private int borderSize;
        private bool Selected;
        public void SetBounds(float startX, float startY,
             float endX, float endY)
        {
            SetX(Math.Min(startX, endX));
            SetY(Math.Min(startY, endY));
            SetWidth(Math.Abs(endX - startX));
            SetHeight(Math.Abs(endY - startY));
            SetBorderColor(GetBorderColor());
        }

        public abstract void Draw(Graphics g);

        public abstract bool PointInShape(float mouseX, float mouseY);

        public abstract float CalculateArea();
        public abstract Shape Paste(float newX, float newY);
        public abstract Shape Duplicate();
        public virtual void Move(float _x,float _y,float startX,float startY,float left, float top)
        {
            X=_x - startX + left;
            Y=_y - startY + top;
        }
        public void SetBorderSize(int _borderSize)
        {
            borderSize = _borderSize;
        }
        public int GetBorderSize()
        {
            return borderSize;
        }
        public void SetIsSelected(bool _isSelected)
        {
            Selected = _isSelected;
        }
        public bool GetIsSelected()
        {
            return Selected;
        }
        public void SetWidth(float _w)
        {
            Width = _w;
        }
        public void SetHeight(float _h)
        {
            Height = _h;
        }
        public float GetWidth()
        {
            return Width;
        }
        public float GetHeight()
        {
            return Height;
        }
        public void SetFillColor(Color color)
        {
            FillColor= color;
        }
        public Color GetFillColor()
        {
            return FillColor;
        }

        public void SetBorderColor(Color color)
        {
            BorderColor = color;
        }
        public Color GetBorderColor()
        {
            return BorderColor;
        }
        protected void setCoordinants(float _x, float _y)
        {
            X = _x;
            Y = _y;
        }
        public void SetX(float _x)
        {
            X = _x;
        }
        public void SetY(float _y)
        {
            Y = _y;
        }
        public float GetX()
        {
            return X;
        }

        public float GetY()
        {
            return Y;
        }
        protected Pen getPen()
        {
            using (Pen pen = new Pen(Color.Black, 3))
            {
                if (GetIsSelected())
                {
                    pen.Width = 3;
                    pen.DashStyle = DashStyle.DashDotDot;
                    // pen.Color = Color.Blue;
                }
                else
                {
                    pen.Color = GetBorderColor();
                    pen.Width = GetBorderSize();
                    pen.DashStyle = DashStyle.Solid;
                }
                return pen;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Kursova_rabota_Etap2_2023
{
    public class Rectangle : Shape
    {
        public override void Draw(Graphics graphics)
        {
            using (var brush = new SolidBrush(GetFillColor()))
            {
                graphics.FillRectangle(brush, GetX(), GetY(), GetWidth(), GetHeight());
            }
            using (var pen = new Pen(GetBorderColor(), GetBorderSize()))
            {
                if (GetIsSelected())
                {
                    pen.DashStyle = DashStyle.Dash;
                }
                graphics.DrawRectangle(pen, GetX(), GetY(), GetWidth(), GetHeight());
            }
        }
        public override bool PointInShape(float mouseX, float mouseY)
        {
            if (GetX() + GetWidth() > mouseX &&
                GetY() + GetHeight() > mouseY &&
                GetX() < mouseX &&
                GetY() < mouseY)
            {
                return true;
            }
            return false;
        }
        public override Shape Paste( float X, float Y)
        {
            Rectangle r = new Rectangle();
            r.SetX(X);
            r.SetY(Y);
            r.SetWidth(GetWidth());
            r.SetHeight(GetHeight());
            r.SetFillColor(GetFillColor());
            r.SetBorderColor(GetBorderColor());
            r.SetBorderSize(GetBorderSize());
            return r;
        }

        public override Shape Duplicate()
        {
            Rectangle r = new Rectangle();
            r.SetX(GetX());
            r.SetY(GetY());
            r.SetWidth(GetWidth());
            r.SetHeight(GetHeight());
            r.SetFillColor(GetFillColor());
            r.SetBorderColor(GetBorderColor());
             r.SetBorderSize(GetBorderSize());
            return r;
        }
        public override void Move(float _x, float _y, float startX, float startY, float left, float top)
        {
            base.Move(_x, _y, startX, startY, left, top);
        }
        public override float CalculateArea()
        {
            return GetWidth()*GetHeight();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_rabota_Etap2_2023
{
    public class Ellipse : Shape
    {
        public override void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(GetFillColor()))
            {
                g.FillEllipse(brush, GetX(), GetY(), GetWidth(), GetHeight());
            }
            using (var pen = new Pen(GetBorderColor(), GetBorderSize()))
            {
                if (GetIsSelected())
                {
                    pen.DashStyle = DashStyle.Dash;
                }
                g.DrawEllipse(pen, GetX(), GetY(), GetWidth(), GetHeight());
            }
        }
        public override bool PointInShape( float mouseX, float mouseY)
        {
            float endX = GetX() + GetWidth();
            float endY = GetY() + GetHeight();
            float h = (GetX() + endX) / 2;
            float k = (GetY() + endY) / 2;
            float x = mouseX;
            float y = mouseY;
            float a = GetWidth() / 2;
            float b = GetHeight() / 2;
            double p = ((double)Math.Pow((x - h), 2)
                    / (double)Math.Pow(a, 2))
                   + ((double)Math.Pow((y - k), 2)
                      / (double)Math.Pow(b, 2));
            if (p <= 1) return true;
            return false;
        }
        public override Shape Paste(float X, float Y)
        {
            Ellipse e = new Ellipse();
            e.SetX(X);
            e.SetY(Y);
            e.SetWidth(GetWidth());
            e.SetHeight(GetHeight());
            e.SetFillColor(GetFillColor());
            e.SetBorderColor(GetBorderColor());
            e.SetBorderSize(GetBorderSize());
            return e;
        }

        public override Shape Duplicate()
        {
            Ellipse e = new Ellipse();
            e.SetX(GetX());
            e.SetY(GetY());
            e.SetWidth(GetWidth());
            e.SetHeight(GetHeight());
            e.SetFillColor(GetFillColor());
            e.SetBorderColor(GetBorderColor());
            e.SetBorderSize(GetBorderSize());
            return e;
        }
        public override void Move(float _x, float _y, float startX, float startY, float left, float top)
        {
            base.Move(_x, _y, startX, startY, left, top);
        }
        public override float CalculateArea()
        {
            return (float)Math.PI*(GetWidth() / 2) * (GetHeight() / 2);
        }
    }
}

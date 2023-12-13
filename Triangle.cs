using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Windows.Forms.AxHost;

namespace Kursova_rabota_Etap2_2023
{
    public class Triangle : Shape
    {
        private Point[] pnt = new Point[3];
        private void SetPoints(float startX,float startY,float endX,float endY)
        {
            float var1;
            float var2;
            float temp;
            if (startX > endX)
            {
                temp = startX;
                startX = endX;
                endX = temp;
            }
            if (startY > endY)
            {
                temp = startY;
                startY = endY;
                endY = temp;
            }

            var1 = (startX + startX + GetWidth()) / 2;
            var2 = startY + GetHeight();
            pnt[0].X = (int)var1;
            pnt[0].Y = (int)startY;

            pnt[1].X = (int)endX;
            pnt[1].Y = (int)endY;

            pnt[2].X = (int)startX;
            pnt[2].Y = (int)var2;
        }

        public override void Draw(Graphics g)
        {
            var startX = GetX();
            var startY=GetY();
            var endX=GetX()+GetWidth();
            var endY= GetY()+GetHeight();
            SetPoints(startX, startY, endX, endY);
            using (var brush = new SolidBrush(GetFillColor()))
            {
                g.FillPolygon(brush, pnt);
            }
            using (var pen = new Pen(GetBorderColor(), GetBorderSize()))
            {
                if (GetIsSelected())
                {
                    pen.DashStyle = DashStyle.Dash;
                }
                g.DrawPolygon(pen, pnt);
            }
        }
        public override bool PointInShape(float mouseX, float mouseY)
        {
            float[] a = new float[] { pnt[0].X, pnt[0].Y };
            float[] b = new float[] { pnt[1].X, pnt[1].Y };
            float[] c = new float[] { pnt[2].X, pnt[2].Y };
            float[] p = new float[] { mouseX, mouseY };
            float alpha = ((b[1] - c[1]) * (p[0] - c[0]) + (c[0] - b[0]) * (p[1] - c[1])) /
                      ((b[1] - c[1]) * (a[0] - c[0]) + (c[0] - b[0]) * (a[1] - c[1]));
            float beta = ((c[1] - a[1]) * (p[0] - c[0]) + (a[0] - c[0]) * (p[1] - c[1])) /
                ((b[1] - c[1]) * (a[0] - c[0]) + (c[0] - b[0]) * (a[1] - c[1]));
            float gamma = 1 - alpha - beta;
            if (alpha > 0 && beta > 0 && gamma > 0)
            {
                return true;
            }
            else
                return false;
        }
        public override Shape Paste( float x, float y)
        {
            Triangle t = new Triangle();
            x -= GetWidth();
            y -= GetHeight();
            float endX = x + GetWidth();
            float endY = y + GetHeight();
            t.SetX(x);
            t.SetY(y);
            t.SetWidth(GetWidth());
            t.SetHeight(GetHeight());
            t.SetFillColor(GetFillColor());
            t.SetBorderColor(GetBorderColor());
            t.SetBorderSize(GetBorderSize());
            SetPoints(x, y, endX, endY);
            return t;
        }
        public override Shape Duplicate()
        {
            Triangle t = new Triangle();
            t.SetX(GetX());
            t.SetY(GetY());
            t.SetWidth(GetWidth());
            t.SetHeight(GetHeight());
            t.SetFillColor(GetFillColor());
            t.SetBorderColor(GetBorderColor());
            t.SetBorderSize(GetBorderSize());
            return t;
        }
        public override void Move(float _x, float _y, float startX, float startY, float left, float top)
        {
            base.Move(_x, _y, startX, startY, left, top);
            float endX = _x + GetWidth();
            float endY = _y + GetHeight();
            SetPoints(_x,_y,endX,endY);
        }
        public override float CalculateArea()
        {
            return (GetWidth() + GetHeight()) / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Kursova_rabota_Etap2_2023
{
    public partial class FormStage : Form
    {
        private Stage Shapes = new Stage();
        private float startX;
        private float startY;
        private bool isClicked = false;
        private Shape shape;
        private bool btnDraw;
        private bool btnSelect;
        private bool btnSave;
        private float left;
        private float top;
        private Shape copiedShape;
        private Color color;
        private Color borderColor;
        private bool shapeInRange;
        private int count = 0;
        public FormStage()
        {
            InitializeComponent();
            borderColor = Color.Black;
            color=Color.White;
            panelBorderColor.BackColor = Color.Black;
            ColorPanel.BackColor = Color.White;
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            btnSave = false;
            if (e.Button == System.Windows.Forms.MouseButtons.Left&&btnSelect)
            {
                SelectMouseDown(e.X,e.Y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left&&btnDraw&&!btnSelect)
            {
                DrawMouseDown(e.X, e.Y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left && !btnDraw && !btnSelect)
            {
                MoveMouseDown(e.X, e.Y);
            }
            if (e.Button != System.Windows.Forms.MouseButtons.Right) return;
            for (int i = Shapes.Count() - 1; i >= 0; i--)
            {
                //startX = e.X;
                //startY = e.Y;
                var currentShape = Shapes.GetShape(i);
                    shapeInRange = false;
                if (currentShape.PointInShape(e.X, e.Y))
                {
                    RightClickMenuStrip.Show(this, e.X, e.Y);
                    shapeInRange = true;
                    EnabledMenuStripItems(true);
                    shape = currentShape;
                    break;
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right && !shapeInRange)
            {
                EnabledMenuStripItems(false);
                RightClickMenuStrip.Show(this, e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelXY.Text = $"Mouse: {e.X},{e.Y}";
            if (!isClicked) return;
            if (!btnDraw)
            {
                shape.Move(e.X,e.Y,startX,startY,left,top);
                Invalidate();
            }
            else
            {
                shape.SetFillColor(default);
                shape.SetBorderColor(borderColor);
                shape.SetBounds(startX, startY, e.X, e.Y);
                labelSize.Text = $"Width: {shape.GetWidth()} Height: {shape.GetHeight()}";
                Invalidate();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (btnSave) return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left&&btnDraw&&!btnSelect)
            {
                isClicked = false;
                shape.SetFillColor(color);
                shape.SetBorderColor(borderColor);
                if(shape.GetWidth() > 0&&shape.GetHeight()>0) 
                Shapes.Add(shape);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left && !btnDraw && !btnSelect)
            {
                isClicked = false;
            }
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < Shapes.Count(); i++)
            {
                var sh=Shapes.GetShape(i);
                sh.Draw(e.Graphics);
            }
            if(shape!=null)
                shape.Draw(e.Graphics);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();        
            sfd.Filter = "XML-File | *.xml";
            sfd.Title = "Save stage";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Shapes.SaveToXMLFile(sfd.FileName);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            shape = null;
            btnSave = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML-File | *.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Shapes.LoadXmlFile(ofd.FileName);
                Invalidate();
            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (btnDraw == false)
            {
                btnDraw = true;
                labelDrawMode.Text = "ON";
                labelDrawMode.ForeColor = Color.Green;
            }
            else
            {
                btnDraw = false;
                labelDrawMode.Text = "OFF";
                labelDrawMode.ForeColor = Color.Red;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            buttonSelectAction();
                for (int i = Shapes.Count() - 1; i >= 0; i--)
                {
                    var currentShape = Shapes.GetShape(i);
                   if (currentShape.GetIsSelected())
                   {
                       currentShape.SetIsSelected(false);
                   }
                }
            Invalidate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonDelete.Enabled = false;
            buttonSelectAction();
            for (int i = Shapes.Count() - 1; i >= 0; i--)
            {
                var currentShape = Shapes.GetShape(i);
                if (currentShape.GetIsSelected())
                {
                    Shapes.Remove(currentShape);
                }
            }
            shape = null;
            Invalidate();
        }
        private void buttonSelectAction()
        {
            if (btnSelect == false)
            {
                count = 0;
                btnSelect = true;
                groupBoxSelected.Visible = true;
                buttonSelect.Text = "Cancel";
            }
            else
            {
                labelSeleced.Text = "Select Shapes";
                 btnSelect = false;
                groupBoxSelected.Visible = false;
                buttonSelect.Text = "Select";
                buttonDelete.Enabled = false;
                buttonColor2.Enabled = false;
            }
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shapes.Remove(shape);
            shape = null;
            Invalidate();
            shapeInRange = false;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shape s = new Rectangle();
            drawNewShapeFromForm(s);
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColor f2 = new FormColor(color);
            f2.ShowDialog();
            shape.SetFillColor(f2.getColor());
            Invalidate();
            shapeInRange = false;
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProp f = new FormProp(shape.GetType().Name , shape.GetWidth(), shape.GetHeight(),
                shape.GetX(), shape.GetY(), shape.GetFillColor(),shape.GetBorderColor());
            f.ShowDialog();
            shape.SetWidth(f.getWidth());
            shape.SetHeight(f.getHeight());
            shape.SetX(f.getX());
            shape.SetY(f.getY());
            shape.SetFillColor(f.getFillColor());
            shape.SetBorderColor(f.getBorderColor());
            Invalidate();
            shapeInRange = false;
        }
        private void EnabledMenuStripItems(bool enabled)
        {
            deleteToolStripMenuItem1.Enabled = enabled;
            colorToolStripMenuItem.Enabled = enabled;
            copyToolStripMenuItem.Enabled = enabled;
            propertiesToolStripMenuItem.Enabled = enabled;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapeInRange = false;
            copiedShape = shape.Duplicate();
            pasteToolStripMenuItem.Enabled = true;
            Invalidate();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copiedShape!=null)
            {
                shapeInRange = false;
                copiedShape=copiedShape.Paste(startX, startY);
                Shapes.Add(copiedShape);
                Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonColor2.Enabled = false;
            FormColor f2 = new FormColor(color);
            f2.ShowDialog();
            for (int i = 0; i < Shapes.Count(); i++)
            {
                var shape = Shapes.GetShape(i);
                if (shape.GetIsSelected())
                {
                    if (f2.IsClicked())
                    {
                        shape.SetFillColor(f2.getColor());
                    }
                    shape.SetIsSelected(false);
                }
            }
            buttonSelectAction();
            Invalidate();
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shape s = new Ellipse();
            drawNewShapeFromForm(s);
        }
        private void drawNewShapeFromForm(Shape s)
        {
            FormProp f = new FormProp(s.GetType().Name.ToString(), 0, 0, startX, startY,default,default);
            f.ShowDialog();
            if (f.getWidth() == 0 || f.getHeight() == 0) return;
            s.SetWidth(f.getWidth());
            s.SetHeight(f.getHeight());
            s.SetX(f.getX());
            s.SetY(f.getY());
            s.SetFillColor(f.getFillColor());
            s.SetBorderColor(f.getBorderColor());
            s.SetBorderSize(3);
            Shapes.Add(s);
            shapeInRange = false;
            Invalidate();
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangle s = new Triangle();
            drawNewShapeFromForm(s);
        }

        private void ColorPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ColorPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            FormColor f2 = new FormColor(color);
            f2.ShowDialog();
            ColorPanel.BackColor = f2.getColor();
            color = f2.getColor();
            Invalidate();
        }

        private void panelBorderColor_Click(object sender, EventArgs e)
        {
            FormColor f2 = new FormColor(borderColor);
            f2.ShowDialog();
            panelBorderColor.BackColor = f2.getColor();
            borderColor = f2.getColor();
            Invalidate();
        }

        private void panelBorderColor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ColorPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            FormList f4 = new FormList(Shapes);
            f4.ShowDialog();
            shape = null;
            Invalidate();
        }
        private void SelectMouseDown(float X,float Y)
        {
            shapeInRange = false;
            for (int i = Shapes.Count() - 1; i >= 0; i--)
            {
                var currentShape = Shapes.GetShape(i);
                if (currentShape.PointInShape(X, Y) && !currentShape.GetIsSelected())
                {
                    count++;
                    currentShape.SetIsSelected(true);
                    labelSeleced.Text = count.ToString() + " Shapes Selected";
                    Invalidate();
                    if (count == 0)
                    {
                        buttonDelete.Enabled = false;
                        buttonColor2.Enabled = false;
                    }
                    else
                    {
                        buttonDelete.Enabled = true;
                        buttonColor2.Enabled = true;
                    }
                    Invalidate();
                    break;
                }
                else if (currentShape.GetIsSelected() && currentShape.PointInShape(X, Y))
                {
                    currentShape.SetIsSelected(false);
                    currentShape.SetIsSelected(false);
                    count--;
                    labelSeleced.Text = count.ToString() + " Shapes Selected";
                    if (count == 0)
                    {
                        buttonDelete.Enabled = false;
                        buttonColor2.Enabled = false;
                    }
                    else
                    {
                        buttonDelete.Enabled = true;
                        buttonColor2.Enabled = true;
                    }
                    Invalidate();
                    break;
                }
            }
        }
        private void DrawMouseDown(float X, float Y)
        {
            shapeInRange = false;
            isClicked = true;
            //startX = X;
            //startY = Y;
            int i = ShapeComboBox.SelectedIndex;
            switch (i)
            {
                case 0: shape = new Rectangle(); break;
                case 1: shape = new Ellipse(); break;
                case 2: shape = new Triangle(); break;
                default: shape = new Rectangle(); break;
            }
            i = comboBoxSize.SelectedIndex;
            switch (i)
            {
                case 0: shape.SetBorderSize(1); break;
                case 1: shape.SetBorderSize(2); break;
                case 2: shape.SetBorderSize(3); break;
                case 3: shape.SetBorderSize(4); break;
                case 4: shape.SetBorderSize(5); break;
                default: shape.SetBorderSize(3); break;
            }
        }

        private void MoveMouseDown(float X,float Y)
        {
            shapeInRange = false;
            for (int i = Shapes.Count() - 1; i >= 0; i--)
            {
                var currentShape = Shapes.GetShape(i);
                if (currentShape.PointInShape(X, Y))
                {
                    isClicked = true;
                    startX = X;
                    startY = Y;
                    left = currentShape.GetX();
                    top = currentShape.GetY();
                    shape = currentShape;
                    Shapes.Remove(currentShape);
                    Shapes.Add(currentShape);
                    break;
                }
            }
        }
    }
    
}
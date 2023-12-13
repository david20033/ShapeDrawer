using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Kursova_rabota_Etap2_2023
{
    public partial class FormList : Form
    {
        private Stage Shapes;
        private List<Shape> tempShapes = new List<Shape>();
        private List<TextBox> tbox = new List<TextBox>();
        private static string Format = "{0,-11}{1,-6}{2,-6}{3,-7}{4,-8}{5,-8}{6,-9}{7,-8}";
        public FormList(Stage Sh)
        {
            InitializeComponent();
            Shapes = Sh;
            tbox.Add(textBoxAreaFrom);
            tbox.Add(textBoxAreaTo);
            tbox.Add(textBoxWidthFrom);
            tbox.Add(textBoxWidthTo);
            tbox.Add(textBoxHeightFrom);
            tbox.Add(textBoxHeightTo);
            tbox.Add(textBoxXFrom);
            tbox.Add(textBoxXTo);
            tbox.Add(textBoxYFrom);
            tbox.Add(textBoxYTo);
            FillTempList(Shapes);
            AddShapesToListBox(tempShapes);
            //labelShCount.Text = "";
        }
        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i=comboBoxSortBy.SelectedIndex;
            List<Shape> result = new List<Shape>();
            switch (i)
            {
                case 1:  result=tempShapes.OrderBy(s=>s.CalculateArea()).ToList(); break;
                case 2: result = tempShapes.OrderByDescending(s => s.CalculateArea()).ToList();break;
                case 3: result = tempShapes.OrderBy(s => s.GetWidth()).ToList(); break;
                case 4: result = tempShapes.OrderByDescending(s => s.GetWidth()).ToList(); break;
                case 5: result = tempShapes.OrderBy(s => s.GetHeight()).ToList(); break;
                case 6: result = tempShapes.OrderByDescending(s => s.GetHeight()).ToList(); break;
                default: result=tempShapes.OrderByDescending(s=>s.GetY()).ToList(); break;
            }
            AddShapesToListBox(result);
        }
        private void AddShapesToListBox(List<Shape> sh)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(String.Format(Format, "Shape", "X", "Y", "Width", "Height","Area","Fill","Border"));
            for (int i = 0; i < sh.Count(); i++)
            {
                var currShape = sh[i];
                var Name = currShape.GetType().Name;
                var X = currShape.GetX().ToString();
                var Y = currShape.GetY().ToString();
                var Width = currShape.GetWidth().ToString();
                var Height = currShape.GetHeight().ToString();
                var Area = currShape.CalculateArea().ToString();
                var FColor = currShape.GetFillColor().Name;
                var BColor = currShape.GetBorderColor().Name;
                listBox1.Items.Add(String.Format(Format, Name, X, Y, Width, Height, Area, FColor, BColor));
            }
            labelShCount.Text = "";
            var ShapesGroups = sh.GroupBy(s => s.GetType().Name);
            foreach(var group in ShapesGroups)
            {
                labelShCount.Text =labelShCount.Text+ $"{group.Key} - {group.Count()}\n";
            }
        }
        private void FillTempList(Stage s)
        {
            for (int i = 0; i < s.Count(); i++)
            {
                var currShape = s.GetShape(i);
                tempShapes.Add(currShape);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            tempShapes.Clear();
            FillTempList(Shapes);
            List<Shape> AllRect=null;
            List<Shape> AllEll=null;
            List<Shape> AllTri = null;
            if (checkBoxRect.Checked)
            {
                AllRect = tempShapes.Where(s => s.GetType().Name == "Rectangle").ToList();
                
            }
            if (checkBoxEll.Checked)
            {
                AllEll = tempShapes.Where(s => s.GetType().Name == "Ellipse").ToList();
            }
            if (checkBoxTri.Checked)
            {
                AllTri = tempShapes.Where(s => s.GetType().Name == "Triangle").ToList();
            }
            tempShapes.Clear ();
            if (AllRect != null)
            {
                tempShapes.AddRange(AllRect);
            }
            if (AllEll != null)
            {
                tempShapes.AddRange(AllEll);
            }
            if (AllTri != null)
            {
                tempShapes.AddRange(AllTri);
            }
            if (!checkBoxEll.Checked && !checkBoxRect.Checked && !checkBoxTri.Checked)
            {
                FillTempList(Shapes);
            }
            float from =0;
            float to=0;
            foreach (var tb in  tbox) 
            {
                if (tb.Text == "" && tbox.IndexOf(tb)%2 == 0)
                {
                    tb.Text = float.MinValue.ToString();
                }
                else if(tb.Text == "" && tbox.IndexOf(tb) % 2 != 0)
                {
                    tb.Text = float.MaxValue.ToString();
                }
            }
            from=float.Parse(textBoxAreaFrom.Text);
            to = float.Parse(textBoxAreaTo.Text);
            tempShapes=tempShapes.Where(s=>s.CalculateArea() >= from && s.CalculateArea() <= to).ToList();
            from = float.Parse(textBoxWidthFrom.Text);
            to = float.Parse(textBoxWidthTo.Text);
            tempShapes = tempShapes.Where(s => s.GetWidth() >= from && s.GetWidth() <= to).ToList();
            from = float.Parse(textBoxHeightFrom.Text);
            to = float.Parse(textBoxHeightTo.Text);
            tempShapes = tempShapes.Where(s => s.GetHeight() >= from && s.GetHeight() <= to).ToList();
            from = float.Parse(textBoxXFrom.Text);
            to = float.Parse(textBoxXTo.Text);
            tempShapes = tempShapes.Where(s => s.GetX() >= from && s.GetX() <= to).ToList();
            from = float.Parse(textBoxYFrom.Text);
            to = float.Parse(textBoxYTo.Text);
            tempShapes = tempShapes.Where(s => s.GetY() >= from && s.GetY() <= to).ToList();
            AddShapesToListBox(tempShapes);
            foreach (var tb in tbox)
            {
                if (tb.Text == float.MinValue.ToString() || tb.Text == float.MaxValue.ToString())
                {
                    tb.Text = "";
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tempShapes.Clear();
            FillTempList(Shapes);
            AddShapesToListBox(tempShapes);
            comboBoxSortBy_SelectedIndexChanged(sender, e);
            checkBoxRect.Checked = false;
            checkBoxEll.Checked = false;
            checkBoxTri.Checked = false;
            foreach(var tb in tbox)
            {
                tb.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex-1;
            if (i > -1) 
            {
                Shape s = tempShapes[i];
                tempShapes.RemoveAt(i);
                Shapes.Remove(s);
            }
            AddShapesToListBox(tempShapes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = tempShapes.Count-1; i >= 0; i--)
            {
                tempShapes.RemoveAt(i);
                Shapes.RemoveAt(i);
            }
            AddShapesToListBox(tempShapes);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex - 1;
            Shape s= tempShapes[i];
            if (listBox1.SelectedItem != null)
            {
                FormProp f = new FormProp(s.GetType().Name, s.GetWidth(), s.GetHeight(), s.GetX(), s.GetY(), s.GetFillColor(),s.GetBorderColor());
                f.ShowDialog();
                s.SetWidth(f.getWidth());
                s.SetHeight(f.getHeight());
                s.SetX(f.getX());
                s.SetY(f.getY());
                s.SetFillColor(f.getFillColor());
                s.SetBorderColor(f.getBorderColor());
                AddShapesToListBox(tempShapes);
            }
        }

        private void buttonConcat_Click(object sender, EventArgs e)
        {
            Stage s=new Stage();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML-File | *.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                s.LoadXmlFile(ofd.FileName);
            }
            tempShapes=tempShapes.Concat(s.ToList()).ToList();
            AddShapesToListBox(tempShapes );
            Shapes.AddRange(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

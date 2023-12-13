using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.AxHost;

namespace Kursova_rabota_Etap2_2023{
    public class Stage
    {
        private List<Shape> Shapes = new List<Shape>();
        private Stack<List<Shape>> _Undo=new Stack<List<Shape>>();
        private Stack<List<Shape>> _Redo = new Stack<List<Shape>>();
        public void Add(Shape sh)
        {
            _Undo.Push(new List<Shape>(Shapes));
            Shapes.Add(sh);
            _Redo.Clear();
        }
        public void AddRange(Stage st)
        {
            for(int i=0;i<st.Count();i++)
            {
                Shapes.Add(st.GetShape(i));
            }
        }
        public int Count()
        {
            return Shapes.Count;
        }
        public Shape GetShape(int index)
        {
            return Shapes[index];
        }
        public bool IsEmpty()
        {
            return Shapes.Count == 0;
        }
        public void Remove(Shape shape)
        {
            _Undo.Push(new List<Shape>(Shapes));
            Shapes.Remove(shape);
        }

        public void Replace(Shape oldSh, Shape newSh)
        {
            int i=Shapes.IndexOf(oldSh);
            if (i>=0)
            {
                Shapes[i] = newSh;
            }
        }
        public void RemoveAt(int at)
        {
            if (Shapes.Count == 0) { throw new IndexOutOfRangeException("The list is empty"); }
            if (at >= Shapes.Count && at > 0)
            {
                throw new IndexOutOfRangeException
                   ($"Index out of range.(Index range: {Shapes.Count - 1})");

            }
            else
                Shapes.RemoveAt(at);
        }
        public void Clear()
        {
            Shapes.Clear();
        }
        public void Undo(Button btnUndo)
        {
            if (_Undo.Count > 0)
            {
                btnUndo.Enabled = true;
                // _Redo.Push(ShapesHistory.Peek());
                List<Shape> previousShapes = _Undo.Pop();
                _Redo.Push(Shapes);
                Shapes = previousShapes;
            }
            if (Shapes.Count == 0)
            {
                btnUndo.Enabled = false;
            }
        }
        public void Redo(Button btnRedo)
        {
            if (_Redo.Count > 0)
            {
                List<Shape> previousShape = new List<Shape>(_Redo.Pop());
                //ShapesHistory.Push(new List<Shape>(previousShape));
                _Undo.Push(new List<Shape>(Shapes));
                Shapes = previousShape;
            }
            if (_Redo.Count == 0)
            {
                btnRedo.Enabled = false;
            }
        }
        public void SaveToXMLFile(string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("Stage");
            for (int i = Shapes.Count() - 1; i >= 0; i--)
            {
                var sh = Shapes[i];
                var FillColor = sh.GetFillColor();
                var BorderColor = sh.GetBorderColor();
                writer.WriteStartElement(sh.GetType().Name);
                writer.WriteStartElement("x");
                writer.WriteString(sh.GetX().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("y");
                writer.WriteString(sh.GetY().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("width");
                writer.WriteString(sh.GetWidth().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("height");
                writer.WriteString(sh.GetHeight().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("fillColor");
                writer.WriteString($"{FillColor.R}-{FillColor.G}-{FillColor.B}");
                writer.WriteEndElement();
                writer.WriteStartElement("borderColor");
                writer.WriteString($"{BorderColor.R}-{BorderColor.G}-{BorderColor.B}");
                writer.WriteEndElement();
                writer.WriteStartElement("borderSize");
                writer.WriteString(sh.GetBorderSize().ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
          //  writer.WriteEndDocument();
            writer.Close();
        }
        public void LoadXmlFile(string file)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(file);
            }
            catch
            {
                MessageBox.Show("File is empty or invalid!", "Error");
                return;
            }
            Shapes.Clear();
            foreach (XmlNode node in doc.SelectNodes("/Stage/*"))
            {
                Shape sh;
                var t = node.SelectSingleNode(".").Name.ToString();
                switch (t)
                {
                    case "Rectangle": sh = new Rectangle(); break;
                    case "Ellipse": sh = new Ellipse(); break;
                    case "Triangle": sh = new Triangle(); break;
                    default: sh = new Rectangle(); break;
                }
                sh.SetX(float.Parse(node.SelectSingleNode("./x").InnerText));
                sh.SetY(float.Parse(node.SelectSingleNode("./y").InnerText));
                sh.SetWidth(float.Parse(node.SelectSingleNode("./width").InnerText));
                sh.SetHeight(float.Parse(node.SelectSingleNode("./height").InnerText));
                string[] fcolor = node.SelectSingleNode("./fillColor").InnerText.Split('-');
                string[] bcolor = node.SelectSingleNode("./borderColor").InnerText.Split('-');
                sh.SetFillColor(Color.FromArgb(int.Parse(fcolor[0]), int.Parse(fcolor[1]), int.Parse(fcolor[2])));
                sh.SetBorderColor(Color.FromArgb(int.Parse(bcolor[0]), int.Parse(bcolor[1]), int.Parse(bcolor[2])));
                sh.SetBorderSize(int.Parse(node.SelectSingleNode("./borderSize").InnerText));
                _Undo.Push(new List<Shape>(Shapes));
                Shapes.Add(sh);
            }
        }
        public List<Shape> ToList()
        {
            return Shapes;
        }
    }
}

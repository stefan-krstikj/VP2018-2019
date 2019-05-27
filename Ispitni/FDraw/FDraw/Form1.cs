using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDraw
{
    [Serializable]
    public partial class Form1 : Form
    {
        public RecrangleDoc rectangleDoc { get; set; }
        public Color currentColor { get; set; }
        public Boolean clicked { get; set; }
        public int tmpW { get; set; }
        public int tmpH { get; set; }
        public Point startPos { get; set; }
        public Point tmpPos { get; set; }
        public Boolean selected { get; set; }
        public Boolean controlClick { get; set; }
        public Rectangle selectedRec { get; set; }

        public String FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            FileName = null;
            rectangleDoc = new RecrangleDoc();
            currentColor = Color.Black;
            clicked = false;
            controlClick = false;
            tmpW = 0;
            tmpH = 0;
            tmpPos = new Point();
            selected = false;
            selectedRec = null;
        }

        public void updateSize()
        {
            tmpW = Math.Abs(tmpPos.X - startPos.X);
            tmpH = Math.Abs(tmpPos.Y - startPos.Y);

            if (controlClick)
            {
                int a = Math.Max(tmpW, tmpH);
                tmpW = a;
                tmpH = a;
            }
                
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);

            updateSize();
            if (clicked)
               e.Graphics.DrawRectangle(pen, startPos.X - (tmpW / 2), startPos.Y - (tmpH / 2), tmpW, tmpH);
            
            rectangleDoc.Draw(e.Graphics);
            toolStripStatusLabel1.Text = "Rectangles: " + rectangleDoc.rectangles.Count.ToString();
            pen.Dispose();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                selectedRec.Move(e.Location);
                Invalidate();
                return;
            }
            tmpPos = e.Location;
            
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rec = rectangleDoc.Clicked(e.Location);
            if (rec != null)
            {
                selected = true;
                selectedRec = rec;
            }
            if (selected)
                return;
            clicked = true;
            startPos = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                selected = false;
                selectedRec = null;
                return;
            }
                
            clicked = false;
            Rectangle rectangle = new Rectangle(tmpW, tmpH, startPos.X - (tmpW / 2), startPos.Y - (tmpH / 2), this.currentColor);
            rectangleDoc.AddRectangle(rectangle);
            Invalidate();

           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                controlClick = true;
                Invalidate();
            }              
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                controlClick = false;
                Invalidate();
            }               
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.currentColor = colorDialog.Color;
            }
            colorDialog.Dispose();
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rectangles file (*.rect)|*.rect";
                saveFileDialog.Title = "Save rectangles doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, rectangleDoc);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rectangles file (*.rect)|*.rect";
            openFileDialog.Title = "Save rectangles doc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        rectangleDoc = (RecrangleDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rectangleDoc = new RecrangleDoc();
            Invalidate();
        }
    }
}

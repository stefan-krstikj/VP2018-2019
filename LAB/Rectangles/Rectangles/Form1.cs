using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangles
{
    public partial class Form1 : Form
    {
        public RectanglesDoc rectanglesDoc { get; set; }
        public Color color { get; set; }

        public String FileName {get;set;}
        public Form1()
        {
            InitializeComponent();
            this.FileName = null;

            this.DoubleBuffered = true;

            rectanglesDoc = new RectanglesDoc();
            color = Color.Black;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rectanglesDoc.Draw(e.Graphics);
            this.toolStripStatusLabel1.Text = String.Format("Pravoagolnici: {0}", rectanglesDoc.rectangles.Count);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int recX = e.X - 50;
            int recY = e.Y - 25;
            Rectangle rec = new Rectangle(recX, recY, this.color);
            rectanglesDoc.rectangles.Add(rec);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                rectanglesDoc.Click(e.Location, false);
            }
            else if(e.Button == MouseButtons.Right)
            {
                rectanglesDoc.Click(e.Location, true);
            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectanglesDoc.Move(this.Width, this.Height);
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.color = colorDialog.Color;
            }
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
                    formatter.Serialize(fileStream, rectanglesDoc);
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
                        rectanglesDoc = (RectanglesDoc)formater.Deserialize(fileStream);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectanglesDoc = new RectanglesDoc();
        }
    }
}

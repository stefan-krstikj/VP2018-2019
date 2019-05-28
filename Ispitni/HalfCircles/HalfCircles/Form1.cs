using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalfCircles
{
    [Serializable]
    public partial class Form1 : Form
    {
        public CircleDoc circleDoc { get; set; }
        public Color currentColor { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            circleDoc = new CircleDoc();
            currentColor = Color.Red;
        }

        public void SaveFile()
        {

        }

        public void OpenFile()
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (toolStripLabel1.Text.Equals("Старт"))
            {
                toolStripLabel1.Text = "Стоп";
                timer1.Start();
            }
            else
            {
                toolStripLabel1.Text = "Старт";
                timer1.Stop();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Circle circle = new Circle(e.X-30, e.Y-30, currentColor);
            circleDoc.circles.Add(circle);
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.currentColor = dialog.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            circleDoc.Draw(e.Graphics);
            this.toolStripStatusLabel1.Text = "Circles: " + circleDoc.circles.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleDoc.Pulse();
            Invalidate();
        }
    }
}

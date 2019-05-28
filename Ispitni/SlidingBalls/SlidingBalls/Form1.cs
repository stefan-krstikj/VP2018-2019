using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    [Serializable]
    public partial class Form1 : Form
    {
        public CircleDoc circleDoc { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            circleDoc = new CircleDoc();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            circleDoc.Draw(e.Graphics);
            this.toolStripStatusLabel1.Text = "Circles: " + circleDoc.circles.Count.ToString();
        }

        public void AddBall(Color color, Point p)
        {
            Circle circle = new Circle(p, color);
            circleDoc.circles.Add(circle);
            Invalidate();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int colorRnd = random.Next(0, 2);
            Color color = Color.Green;
            if (colorRnd == 1)
                color = Color.Blue;
            AddBall(color, e.Location);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (circleDoc.Click(e.Location))
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                AddBall(Color.Red, e.Location);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleDoc.Move(this.Height, this.Width);
            Invalidate();   
        }
    }
}

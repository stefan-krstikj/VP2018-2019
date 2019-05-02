using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Exercise
{
    public partial class Form1 : Form
    {
        public enum SHAPE_TYPE
        {
            circle, square
        }

        public Graphics g { get; set;  }
        public SHAPE_TYPE currentShape { get; set; }
        public Color currentColor { get; set; }


        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            currentShape = SHAPE_TYPE.circle;
            currentColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(currentShape == SHAPE_TYPE.circle)
            {
                
                Circle circle = new Circle(this.currentColor, g, 50);
                circle.draw(e.X, e.Y);
            }
            else
            {
                Square square = new Square(this.currentColor, g, 40, 40);
                square.draw(e.X, e.Y);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == circleToolStripMenuItem)
            {
                currentShape = SHAPE_TYPE.circle;
                circleToolStripMenuItem.Checked = true;
                squareToolStripMenuItem.Checked = false;

            }
            else if (e.ClickedItem == squareToolStripMenuItem)
            {
                currentShape = SHAPE_TYPE.square;
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = true;
            }
        }
    }

    abstract class Shape
    {
        public Color color { get; set; }
        public Graphics g { get; set; }

        public Shape(Color color, Graphics g)
        {
            this.color = color;
            this.g = g;
        }

        abstract public void draw(float x, float y);
    }

    class Circle : Shape
    {
        private float Radius { get; set; }

        public Circle(Color color, Graphics g, float Radius) : base(color, g)
        {
            this.Radius = Radius;
        }

        public override void draw(float x, float y)
        {
            
            Brush brush = new SolidBrush(this.color);
            Pen pen = new Pen(Color.Yellow);

            g.FillEllipse(brush, x-Radius, y-Radius, Radius*2, Radius*2);
            
            brush.Dispose();
        }
    }

    class Square : Shape
    {
        private float X { get; set; }
        private float Y { get; set; }

        public Square(Color color, Graphics g, float X, float Y) : base(color, g)
        {
            this.X = X;
            this.Y = Y;
        }

        public override void draw(float x, float y)
        {
            Brush brush = new SolidBrush(this.color);
            Pen pen = new Pen(Color.Yellow);

            g.FillRectangle(brush, x, y, this.X, this.Y);
            brush.Dispose();
        }
    }
}

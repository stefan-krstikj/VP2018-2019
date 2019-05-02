using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObjects
{
    public partial class Form1 : Form
    {

        private ShapesList shapesList;
        private Color currentColor;
        private ShapesList.SHAPE_TYPE currentType;
        private Boolean mouseDown { get; set; }
        private Shape selectedShape;

        private float prevX { get; set; }
        private float prevY { get; set; }

        public Form1()
        {
            InitializeComponent();
            shapesList = new ShapesList();
            currentColor = Color.MediumVioletRed;
            currentType = ShapesList.SHAPE_TYPE.CIRCLE;
            this.DoubleBuffered = true;
            mouseDown = false;
            selectedShape = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentType = ShapesList.SHAPE_TYPE.CIRCLE;
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentType = ShapesList.SHAPE_TYPE.SQUARE;
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             shapesList.AddShape(e.X, e.Y, currentColor, currentType);
             Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            shapesList.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Shape s = shapesList.Select(e.X, e.Y);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            selectedShape = shapesList.Select(e.X, e.Y);
            prevX = e.X;
            prevY = e.Y;
         
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if(selectedShape != null)
                {
                    float dx = e.X - prevX;
                    float dy = e.X - prevY;
                    selectedShape.Move(dx, dy);
                    Invalidate();
                }
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }

    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }

        public bool Selected { get; set; }

        public Color Color { get; set; }

        public Shape(float x, float y, Color color)
        {
            X = x;
            Y = y;
            this.Color = color;
        }

        public abstract void Draw(Graphics g);

        public abstract bool IsHit(float x, float y);

        public void Move(float dx, float dy)
        {
            X += dx;
            Y += dy;
        }

    }

    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(float x, float y, float radius, Color color) : base(x, y, color)
        {
            this.Radius = radius;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillEllipse(b, this.X - Radius, this.Y - Radius, 2*Radius, 2*Radius);

            b.Dispose();
        }

        public override bool IsHit(float x, float y)
        {
            double d = Math.Sqrt((X-x) * (X-x) + (Y-y) * (Y - y));
            return d <= Radius;
        }
    }

    public class Square : Shape
    {
        public float Width { get; set; }
        public float Height { get; set;}

        public Square(float x, float y, float width, float height, Color color) : base(x, y, color)
        {
            this.Width = width;
            this.Height = height;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.Color);
            g.FillRectangle(b, this.X, this.Y, this.Width, this.Height);

            b.Dispose();
        }

        public override bool IsHit(float x, float y)
        {
            throw new NotImplementedException();
        }
    }

    public class ShapesList
    {
        public List<Shape> Shapes;
        public const float RADIUS = 40;
        public enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }

        public ShapesList()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(float x, float y, Color color, SHAPE_TYPE type)
        {
            Shape shape = null;
            if(type == SHAPE_TYPE.CIRCLE)
            {
                shape = new Circle(x, y, RADIUS, color);
            }
            else if (type == SHAPE_TYPE.SQUARE)
            {
                shape = new Square(x, y, RADIUS * 2, RADIUS * 2, color);
            }
            Shapes.Add(shape);
        }

        public void Draw(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }

        public Shape Select(float x, float y)
        {
            foreach (Shape s in Shapes)
            {
                if (s.IsHit(x, y))
                {
                    s.Selected = !s.Selected;
                    return s;
                }
            }
            return null;
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class Form1 : Form
    { 

        Timer timer;
        Ball ball;
        Graphics graphics;
        Brush brush;
        Pen pen;
        Rectangle bounds;
        Bitmap doubleBuffer;
        static readonly int FRAMES_PER_SECOND = 30;
        public Form1()
        {
            InitializeComponent();
            bounds = new Rectangle(10, 10, this.Bounds.Width - 40, this.Bounds.Height - 60);
            doubleBuffer = new Bitmap(Width, Height);
            ball = new Ball(Width / 2, Height / 2, 20, 10, (float)(Math.PI / 4));
            graphics = CreateGraphics();
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(Color.Red);
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000 / FRAMES_PER_SECOND;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            g.DrawRectangle(pen, bounds);
            ball.Draw(brush, g);
            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }
    }

    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Radius { get; set; }

        public float Velocity { get; set; }
        public float Angle { get; set; }

        public Rectangle Bounds;

        private float velocityX;
        private float velocityY;

        public Ball(float x, float y, float radius, float velocity, float angle)
        {
            X = x;
            Y = y;
            Radius = radius;
            Velocity = velocity;
            Angle = angle;
            velocityX = (float)Math.Cos(Angle) * Velocity;
            velocityY = (float)Math.Sin(Angle) * Velocity;
        }

        public void Move()
        {
            float nextX = X + velocityX;
            float nextY = Y + velocityY;
            if (nextX - Radius <= Bounds.Left || (nextX + Radius >= Bounds.Right))
            {
                velocityX = -velocityX;
            }
            if (nextY - Radius <= Bounds.Top || (nextY + Radius >= Bounds.Bottom))
            {
                velocityY = -velocityY;
            }
            X += velocityX;
            Y += velocityY;
        }

        public void Draw(Brush brush, Graphics g)
        {
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}

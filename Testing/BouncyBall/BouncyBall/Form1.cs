using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBall
{
    public partial class Form1 : Form
    {
        public Ball ball { get; set; }
        public Graphics g { get; set; }
        public Brush brush { get; set; }
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            int windowUp = 0;

            int windowDown = this.Height - 150;
            ball = new Ball(30, this.g, 150, 150, windowUp, windowDown, 1);
            brush = new SolidBrush(Color.Red);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Draw(brush);
            ball.Move();
            lblPos.Text = "X: " + ball.posX + " Y: " + ball.posY + "\tBoundUp: " + ball.boundUp + " BoundDown: " + ball.boundDown;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }

    public class Ball
    {
        public float boundUp { get; set; }
        public float boundDown { get; set; }
        private int direction { get; set; }
        private float Radius { get; set; }
        public float posX { get; set; }
        public float posY { get; set; }
        private Graphics g { get; set; }


        public Ball(float Radius,  Graphics g, float posX, float posY, float boundUp, float boundDown, int direction)
        {
            this.Radius = Radius;
            this.g = g;
            this.posX = posX;
            this.posY = posY;

            this.boundDown = boundDown;
            this.boundUp = boundUp;
            this.direction = direction;
        }

        public void Draw(Brush b)
        {
            g.Clear(Color.White);
            g.FillEllipse(b, this.posX, this.posY, Radius * 2, Radius * 2);

        }

        public void Move()
        {
            if ((direction == 1 && posY >= boundDown) || (direction == -1 && posY <= boundUp))
                direction *= (-1);
            posY += direction * 10;
        }
    }
}

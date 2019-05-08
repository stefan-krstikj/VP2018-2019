using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[,] foodWorld;

        public Form1()
        {
            InitializeComponent();
            foodImage = Properties.Resources.food;
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = (int)Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = (int)Pacman.Radius * 2 * (WORLD_HEIGHT + 1);

            // kod za 2D matrica foodWorld
            foodWorld = new bool[WORLD_HEIGHT, WORLD_WIDTH];
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                for(int j = 0; j < WORLD_WIDTH; j++)
                {
                    this.foodWorld[i,j] = true;
                }
            }


            // kod za timer
            timer = new Timer();
            timer.Enabled = true;
            this.timer.Interval = TIMER_INTERVAL;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs s)
        {
            // kod
            //foodWorld[(int)pacman.X, (int)pacman.Y] = false;
            MessageBox.Show("a");
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                this.pacman.ChangeDirection(Pacman.DIRECTION.up);
                pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
                Invalidate();
            }
            else if(e.KeyData == Keys.Right)
            {
                this.pacman.ChangeDirection(Pacman.DIRECTION.right);
                pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
                Invalidate();
            }
            else if(e.KeyData == Keys.Down)
            {
                this.pacman.ChangeDirection(Pacman.DIRECTION.down);
                pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
                Invalidate();
            }
            else if (e.KeyData == Keys.Left)
            {
                this.pacman.ChangeDirection(Pacman.DIRECTION.left);
                pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
                Invalidate();
            }
            
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                for (int j = 0; j < WORLD_WIDTH; j++)
                {
                    if (foodWorld[i,j])
                    {
                        /*
                         * 
                         this.Width = (int)Pacman.Radius * 2 * (WORLD_WIDTH + 1);
                         this.Height = (int)Pacman.Radius * 2 * (WORLD_HEIGHT + 1);*/
                        int x = j * (int) Pacman.Radius * 2 + ((int) Pacman.Radius * 2 - foodImage.Height) / 2;
                        int y = i * (int) Pacman.Radius * 2 + ((int)Pacman.Radius * 2 - foodImage.Width) / 2;
                        g.DrawImageUnscaled(foodImage, x, y);
                    }
                }
            }

            pacman.Draw(g);
        }
    }

    public class Pacman
    {
        public enum DIRECTION
        {
            up, right, down, left
        }
        public float X { get; set; }
        public float Y { get; set; }
        public DIRECTION Direction { get; set; } // 0 = up, 1 = right, 2 = down, 3 = left
        public static float Radius = 20;
        public float Speed { get; set; }
        public Boolean mouthOpen { get; set; }
        public Brush brush { get; set; }

        public Pacman()
        {
            this.X = 7;
            this.Y = 5;

            this.Direction = DIRECTION.right;
            this.Speed = Radius;

            this.mouthOpen = false;

            brush = new SolidBrush(Color.Yellow);

        }

        public int coordX()
        {
            int coords = (int)this.X * (int) Radius * 2 + ((int) Radius * 2 - 35) / 2;
            return coords;
        }

        public int coordY()
        {
            int coords = (int) this.Y * (int)Radius * 2 + ((int)Radius * 2 - 35) / 2;
            return coords;
        }


        public void ChangeDirection(DIRECTION direction)
        {
            this.Direction = direction;
        }

        public void changeMouth()
        {
            if (this.mouthOpen)
                this.mouthOpen = false;
            else
                this.mouthOpen = true;
        }

        public void changePosition(int wWidth, int wHeight)
        {
            if(this.Direction == DIRECTION.up)
            {
                float newY = this.Y - 1;
                if (newY <= 0)
                    newY = wWidth;
                this.Y = newY;
            }
            else if (this.Direction == DIRECTION.right)
            {
                float newX = this.X + 1;
                if (newX >= wWidth)
                    newX = 0;
                this.X = newX;
            }
            else if (this.Direction == DIRECTION.down)
            {
                float newY = this.Y + 1;
                if (newY >= wHeight)
                    newY = 0;
                this.Y = newY;
            }
            else if (this.Direction == DIRECTION.left)
            {
                float newX = this.X - 1;
                if (newX <= 0)
                    newX = wHeight;
                this.X = newX;
            }
        }

        public void Move(int wWidth, int wHeight)
        {
           // changeMouth();
            changePosition(wWidth, wHeight);

        }

        public void Draw(Graphics g)
        {
            if (this.mouthOpen)
            {
                 //if(this.Direction == DIRECTION.right)
                  //  g.FillPie(this.brush, this.X- Radius, this.Y-Radius, Radius * 2, Radius * 2, 0,3/4);
                g.FillEllipse(this.brush, coordX() - Radius, coordY() - Radius, Radius * 2, Radius * 2);

            }
            else
            {
                g.FillEllipse(this.brush, coordX() - Radius, coordY() - Radius, Radius * 2, Radius * 2);
            }
        }
    }
}

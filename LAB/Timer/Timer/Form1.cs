using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Random random { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public char operation { get; set; }
        public int correctNumber { get; set; }
        public int points { get; set; }
        public int time { get; set; }
        public DataTable dt { get; set; }
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            points = 0;
            time = 2;
            dt = new DataTable { TableName = "MyTable" };
            dt.Columns.Add("Name");
            dt.Columns.Add("Points");
           
            this.ActiveControl = txtName;
        }

        public void generateNewNumbers()
        {
            int generatedNumber = 0;
            generatedNumber = random.Next(1, 20);
            this.num1 = generatedNumber;
            generatedNumber = random.Next(1, 20);
            this.num2 = generatedNumber;

            // 0 -> '+'  |   1 -> '-'   |   2 -> '*'   |   3 -> '/'
            generatedNumber = random.Next(0, 3);
            if (generatedNumber == 0)
            {
                operation = '+';
                this.correctNumber = num1 + num2;
            }
            else if (generatedNumber == 1)
            {
                operation = '-';
                this.correctNumber = num1 - num2;
            }
            else if (generatedNumber == 2)
            {
                operation = '*';
                this.correctNumber = num1 * num2;
            }
            else
            {
                operation = '/';
                this.correctNumber = num1 / num2;
            }

            if (num1 < num2 && operation == '-')
                generateNewNumbers();
            if (num1 % num2 != 0)
                generateNewNumbers();

            this.ActiveControl = txtGuess;
            txtOperator.Text = operation + "";
            txtNum1.Text = this.num1 + "";
            txtNum2.Text = this.num2 + "";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length == 0)
            {
                generateNewNumbers();
                return;
            }
            int guessNumb = Convert.ToInt32(txtGuess.Text);
            if (guessNumb == correctNumber)
                correctAnswer();
            txtGuess.Text = "";
        }

        public void correctAnswer()
        {
            points += 1;
            if (points % 10 == 0)
                time += 10;
            updatePoints();
            generateNewNumbers();
            txtGuess.Text  = "";
            
        }

        private void btnStartEverything_Click(object sender, EventArgs e)
        {
            generateNewNumbers();
            timer1.Start();
            btnGuess.Enabled = true;
        }

        public void updateRemainingTime()
        {
            this.progressTime.Value = time;
            int minsRemain = time / 60;
            int secsRemain = time % 60;
            lblTimeRemain.Text = String.Format("{0:00}:{1:00}", minsRemain, secsRemain);
        }

        public void updatePoints()
        {
            this.progressPoints.Value = points;
            lblPoints.Text = points + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressPoints.Value = points;
            time -= 1;
            if (time <- 0)
            {
                gameEnded();
                timer1.Dispose();
                string message = String.Format("Congratulations, {0}! You got {1} points!", txtName.Text, points);
                DialogResult dialog = MessageBox.Show(message, "Game ended");
                return;
            }
            updateRemainingTime();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Size = this.Size;
            newForm.Show();
                  this.Dispose(false);
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text.Length == 0)
            {
                e.Cancel = true;
                errName.SetError(txtName, "Enter a name!");
            }
            else
            {
                errName.SetError(txtName, null);
            }
        }

        //public void gameEnded()
        //{
        //    DataRow row = dt.NewRow();
        //    row["Name"] = txtName.Text;
        //    row["Points"] = points + "";
        //    dt.Rows.Add(row);
        //    dt.WriteXml("dtXML.xml");
        //}
    }
}

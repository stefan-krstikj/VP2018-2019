namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.progressPoints = new System.Windows.Forms.ProgressBar();
            this.progressTime = new System.Windows.Forms.ProgressBar();
            this.btnStartEverything = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Играч:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поени:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Преостанато Време:";
            // 
            // txtNum1
            // 
            this.txtNum1.Enabled = false;
            this.txtNum1.Location = new System.Drawing.Point(12, 70);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(70, 20);
            this.txtNum1.TabIndex = 4;
            // 
            // txtOperator
            // 
            this.txtOperator.Enabled = false;
            this.txtOperator.Location = new System.Drawing.Point(98, 70);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(36, 20);
            this.txtOperator.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Enabled = false;
            this.txtNum2.Location = new System.Drawing.Point(152, 70);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(70, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(379, 67);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(105, 23);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Погоди";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(282, 70);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(70, 20);
            this.txtGuess.TabIndex = 9;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(67, 120);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPoints.TabIndex = 10;
            this.lblPoints.Text = "0";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Location = new System.Drawing.Point(138, 195);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(34, 13);
            this.lblTimeRemain.TabIndex = 11;
            this.lblTimeRemain.Text = "00:00";
            // 
            // btnHighScores
            // 
            this.btnHighScores.Location = new System.Drawing.Point(179, 265);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(127, 23);
            this.btnHighScores.TabIndex = 12;
            this.btnHighScores.Text = "Најдобри Играчи";
            this.btnHighScores.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(379, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Исклучи";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 265);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(105, 23);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // progressPoints
            // 
            this.progressPoints.Location = new System.Drawing.Point(12, 154);
            this.progressPoints.Name = "progressPoints";
            this.progressPoints.Size = new System.Drawing.Size(472, 23);
            this.progressPoints.Step = 1;
            this.progressPoints.TabIndex = 15;
            // 
            // progressTime
            // 
            this.progressTime.Location = new System.Drawing.Point(12, 221);
            this.progressTime.Maximum = 60;
            this.progressTime.Name = "progressTime";
            this.progressTime.Size = new System.Drawing.Size(472, 23);
            this.progressTime.Step = 1;
            this.progressTime.TabIndex = 16;
            // 
            // btnStartEverything
            // 
            this.btnStartEverything.Location = new System.Drawing.Point(195, 17);
            this.btnStartEverything.Name = "btnStartEverything";
            this.btnStartEverything.Size = new System.Drawing.Size(75, 23);
            this.btnStartEverything.TabIndex = 17;
            this.btnStartEverything.Text = "START";
            this.btnStartEverything.UseVisualStyleBackColor = true;
            this.btnStartEverything.Click += new System.EventHandler(this.btnStartEverything_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 300);
            this.Controls.Add(this.btnStartEverything);
            this.Controls.Add(this.progressTime);
            this.Controls.Add(this.progressPoints);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.lblTimeRemain);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ProgressBar progressPoints;
        private System.Windows.Forms.ProgressBar progressTime;
        private System.Windows.Forms.Button btnStartEverything;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errName;
    }
}


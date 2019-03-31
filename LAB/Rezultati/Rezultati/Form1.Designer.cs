namespace Rezultati
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxBasketball = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxFootball = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMatchDate = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAwayName = new System.Windows.Forms.TextBox();
            this.txtHomeName = new System.Windows.Forms.TextBox();
            this.boxAwayStrelci = new System.Windows.Forms.ListBox();
            this.boxHomeStrelci = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxBasketball);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кошарка";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // boxBasketball
            // 
            this.boxBasketball.FormattingEnabled = true;
            this.boxBasketball.Location = new System.Drawing.Point(10, 29);
            this.boxBasketball.Name = "boxBasketball";
            this.boxBasketball.Size = new System.Drawing.Size(163, 134);
            this.boxBasketball.TabIndex = 0;
            this.boxBasketball.SelectedIndexChanged += new System.EventHandler(this.boxBasketball_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxFootball);
            this.groupBox2.Location = new System.Drawing.Point(246, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фудбал";
            // 
            // boxFootball
            // 
            this.boxFootball.FormattingEnabled = true;
            this.boxFootball.Location = new System.Drawing.Point(13, 29);
            this.boxFootball.Name = "boxFootball";
            this.boxFootball.Size = new System.Drawing.Size(163, 134);
            this.boxFootball.TabIndex = 1;
            this.boxFootball.SelectedIndexChanged += new System.EventHandler(this.boxFootball_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMatchDate);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.txtAwayName);
            this.groupBox3.Controls.Add(this.txtHomeName);
            this.groupBox3.Controls.Add(this.boxAwayStrelci);
            this.groupBox3.Controls.Add(this.boxHomeStrelci);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Детали за натпреварот";
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.Enabled = false;
            this.txtMatchDate.Location = new System.Drawing.Point(121, 157);
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(100, 20);
            this.txtMatchDate.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(247, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(46, 20);
            this.txtResult.TabIndex = 10;
            // 
            // txtAwayName
            // 
            this.txtAwayName.Enabled = false;
            this.txtAwayName.Location = new System.Drawing.Point(299, 26);
            this.txtAwayName.Name = "txtAwayName";
            this.txtAwayName.Size = new System.Drawing.Size(119, 20);
            this.txtAwayName.TabIndex = 9;
            // 
            // txtHomeName
            // 
            this.txtHomeName.Enabled = false;
            this.txtHomeName.Location = new System.Drawing.Point(121, 26);
            this.txtHomeName.Name = "txtHomeName";
            this.txtHomeName.Size = new System.Drawing.Size(119, 20);
            this.txtHomeName.TabIndex = 8;
            // 
            // boxAwayStrelci
            // 
            this.boxAwayStrelci.FormattingEnabled = true;
            this.boxAwayStrelci.Location = new System.Drawing.Point(299, 68);
            this.boxAwayStrelci.Name = "boxAwayStrelci";
            this.boxAwayStrelci.Size = new System.Drawing.Size(119, 82);
            this.boxAwayStrelci.TabIndex = 7;
            // 
            // boxHomeStrelci
            // 
            this.boxHomeStrelci.FormattingEnabled = true;
            this.boxHomeStrelci.Location = new System.Drawing.Point(121, 68);
            this.boxHomeStrelci.Name = "boxHomeStrelci";
            this.boxHomeStrelci.Size = new System.Drawing.Size(119, 82);
            this.boxHomeStrelci.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стрелци:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стрелци:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оддржан на:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Натпревар:";
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(22, 451);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(125, 23);
            this.btnAddMatch.TabIndex = 3;
            this.btnAddMatch.Text = "Додади Натпревар";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(292, 451);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(130, 23);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.Text = "Затвори Прозорец";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 507);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox boxBasketball;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox boxFootball;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMatchDate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtAwayName;
        private System.Windows.Forms.TextBox txtHomeName;
        private System.Windows.Forms.ListBox boxAwayStrelci;
        private System.Windows.Forms.ListBox boxHomeStrelci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}


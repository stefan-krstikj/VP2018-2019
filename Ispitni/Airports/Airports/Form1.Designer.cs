namespace Airports
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
            this.listAirports = new System.Windows.Forms.ListBox();
            this.listDestinations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnRemoveAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.tbAvgLength = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAirports
            // 
            this.listAirports.FormattingEnabled = true;
            this.listAirports.ItemHeight = 16;
            this.listAirports.Location = new System.Drawing.Point(31, 36);
            this.listAirports.Name = "listAirports";
            this.listAirports.Size = new System.Drawing.Size(364, 420);
            this.listAirports.TabIndex = 0;
            // 
            // listDestinations
            // 
            this.listDestinations.FormattingEnabled = true;
            this.listDestinations.ItemHeight = 16;
            this.listDestinations.Location = new System.Drawing.Point(422, 36);
            this.listDestinations.Name = "listDestinations";
            this.listDestinations.Size = new System.Drawing.Size(427, 420);
            this.listDestinations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дестинации";
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(35, 462);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(360, 37);
            this.btnAddAirport.TabIndex = 4;
            this.btnAddAirport.Text = "Додади Аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAirport
            // 
            this.btnRemoveAirport.Location = new System.Drawing.Point(35, 505);
            this.btnRemoveAirport.Name = "btnRemoveAirport";
            this.btnRemoveAirport.Size = new System.Drawing.Size(360, 45);
            this.btnRemoveAirport.TabIndex = 5;
            this.btnRemoveAirport.Text = "Избриши Аеродром";
            this.btnRemoveAirport.UseVisualStyleBackColor = true;
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(35, 556);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(360, 41);
            this.btnAddDestination.TabIndex = 6;
            this.btnAddDestination.Text = "Додади Дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAvgLength);
            this.groupBox1.Controls.Add(this.tbMostExpensive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(429, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(19, 57);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(395, 22);
            this.tbMostExpensive.TabIndex = 10;
            // 
            // tbAvgLength
            // 
            this.tbAvgLength.Enabled = false;
            this.tbAvgLength.Location = new System.Drawing.Point(19, 102);
            this.tbAvgLength.Name = "tbAvgLength";
            this.tbAvgLength.Size = new System.Drawing.Size(395, 22);
            this.tbAvgLength.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnRemoveAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDestinations);
            this.Controls.Add(this.listAirports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAirports;
        private System.Windows.Forms.ListBox listDestinations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnRemoveAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAvgLength;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}


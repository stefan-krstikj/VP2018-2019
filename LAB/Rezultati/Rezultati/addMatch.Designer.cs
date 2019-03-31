namespace Rezultati
{
    partial class addMatch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboMatchType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAwayGoals = new System.Windows.Forms.TextBox();
            this.txtHomeGoals = new System.Windows.Forms.TextBox();
            this.txtAway = new System.Windows.Forms.TextBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxAwayStrelci = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxHomeStrelci = new System.Windows.Forms.ListBox();
            this.btnAddAwayStrelec = new System.Windows.Forms.Button();
            this.btnAddHomeStrelec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errHome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAway = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAway)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboMatchType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAwayGoals);
            this.groupBox1.Controls.Add(this.txtHomeGoals);
            this.groupBox1.Controls.Add(this.txtAway);
            this.groupBox1.Controls.Add(this.txtHome);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAddAwayStrelec);
            this.groupBox1.Controls.Add(this.btnAddHomeStrelec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внесете податоци";
            // 
            // comboMatchType
            // 
            this.comboMatchType.Items.AddRange(new object[] {
            "Кошарка",
            "Фудбал"});
            this.comboMatchType.Location = new System.Drawing.Point(175, 51);
            this.comboMatchType.Name = "comboMatchType";
            this.comboMatchType.Size = new System.Drawing.Size(121, 21);
            this.comboMatchType.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // txtAwayGoals
            // 
            this.txtAwayGoals.Location = new System.Drawing.Point(240, 214);
            this.txtAwayGoals.Name = "txtAwayGoals";
            this.txtAwayGoals.Size = new System.Drawing.Size(43, 20);
            this.txtAwayGoals.TabIndex = 13;
            // 
            // txtHomeGoals
            // 
            this.txtHomeGoals.Location = new System.Drawing.Point(175, 214);
            this.txtHomeGoals.Name = "txtHomeGoals";
            this.txtHomeGoals.Size = new System.Drawing.Size(43, 20);
            this.txtHomeGoals.TabIndex = 12;
            // 
            // txtAway
            // 
            this.txtAway.Location = new System.Drawing.Point(175, 157);
            this.txtAway.Name = "txtAway";
            this.txtAway.Size = new System.Drawing.Size(108, 20);
            this.txtAway.TabIndex = 11;
            this.txtAway.Validating += new System.ComponentModel.CancelEventHandler(this.txtAway_Validating);
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(175, 97);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(108, 20);
            this.txtHome.TabIndex = 10;
            this.txtHome.Validating += new System.ComponentModel.CancelEventHandler(this.txtHome_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxAwayStrelci);
            this.groupBox3.Location = new System.Drawing.Point(214, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 118);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Стрелци гости";
            // 
            // boxAwayStrelci
            // 
            this.boxAwayStrelci.FormattingEnabled = true;
            this.boxAwayStrelci.Location = new System.Drawing.Point(6, 17);
            this.boxAwayStrelci.Name = "boxAwayStrelci";
            this.boxAwayStrelci.Size = new System.Drawing.Size(120, 95);
            this.boxAwayStrelci.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxHomeStrelci);
            this.groupBox2.Location = new System.Drawing.Point(25, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стрелци дома";
            // 
            // boxHomeStrelci
            // 
            this.boxHomeStrelci.FormattingEnabled = true;
            this.boxHomeStrelci.Location = new System.Drawing.Point(7, 20);
            this.boxHomeStrelci.Name = "boxHomeStrelci";
            this.boxHomeStrelci.Size = new System.Drawing.Size(120, 95);
            this.boxHomeStrelci.TabIndex = 0;
            // 
            // btnAddAwayStrelec
            // 
            this.btnAddAwayStrelec.Location = new System.Drawing.Point(203, 271);
            this.btnAddAwayStrelec.Name = "btnAddAwayStrelec";
            this.btnAddAwayStrelec.Size = new System.Drawing.Size(158, 23);
            this.btnAddAwayStrelec.TabIndex = 5;
            this.btnAddAwayStrelec.Text = "Додади стрелец гостин";
            this.btnAddAwayStrelec.UseVisualStyleBackColor = true;
            this.btnAddAwayStrelec.Click += new System.EventHandler(this.btnAddAwayStrelec_Click);
            // 
            // btnAddHomeStrelec
            // 
            this.btnAddHomeStrelec.Location = new System.Drawing.Point(25, 271);
            this.btnAddHomeStrelec.Name = "btnAddHomeStrelec";
            this.btnAddHomeStrelec.Size = new System.Drawing.Size(150, 23);
            this.btnAddHomeStrelec.TabIndex = 4;
            this.btnAddHomeStrelec.Text = "Додади Стрелец дома";
            this.btnAddHomeStrelec.UseVisualStyleBackColor = true;
            this.btnAddHomeStrelec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Резултат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Гостин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Домаќин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип на натпревар:";
            // 
            // errHome
            // 
            this.errHome.ContainerControl = this;
            // 
            // errAway
            // 
            this.errAway.ContainerControl = this;
            // 
            // addMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "addMatch";
            this.Text = "addMatch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAway)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAwayGoals;
        private System.Windows.Forms.TextBox txtHomeGoals;
        private System.Windows.Forms.TextBox txtAway;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox boxAwayStrelci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox boxHomeStrelci;
        private System.Windows.Forms.Button btnAddAwayStrelec;
        private System.Windows.Forms.Button btnAddHomeStrelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMatchType;
        private System.Windows.Forms.ErrorProvider errHome;
        private System.Windows.Forms.ErrorProvider errAway;
    }
}
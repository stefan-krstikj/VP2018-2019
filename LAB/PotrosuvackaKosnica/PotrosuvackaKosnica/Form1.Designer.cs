namespace PotrosuvackaKosnica
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
            this.boxProducts = new System.Windows.Forms.ListBox();
            this.boxCart = new System.Windows.Forms.ListBox();
            this.btnEmptyProductList = new System.Windows.Forms.Button();
            this.btnEmptyCartList = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtCateggory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // boxProducts
            // 
            this.boxProducts.FormattingEnabled = true;
            this.boxProducts.Location = new System.Drawing.Point(12, 12);
            this.boxProducts.Name = "boxProducts";
            this.boxProducts.Size = new System.Drawing.Size(256, 394);
            this.boxProducts.TabIndex = 0;
            this.boxProducts.SelectedIndexChanged += new System.EventHandler(this.boxProducts_SelectedIndexChanged);
            // 
            // boxCart
            // 
            this.boxCart.FormattingEnabled = true;
            this.boxCart.Location = new System.Drawing.Point(532, 12);
            this.boxCart.Name = "boxCart";
            this.boxCart.Size = new System.Drawing.Size(256, 368);
            this.boxCart.TabIndex = 1;
            // 
            // btnEmptyProductList
            // 
            this.btnEmptyProductList.Location = new System.Drawing.Point(12, 415);
            this.btnEmptyProductList.Name = "btnEmptyProductList";
            this.btnEmptyProductList.Size = new System.Drawing.Size(256, 23);
            this.btnEmptyProductList.TabIndex = 2;
            this.btnEmptyProductList.Text = "Испразни ја листата од продукти?";
            this.btnEmptyProductList.UseVisualStyleBackColor = true;
            this.btnEmptyProductList.Click += new System.EventHandler(this.btnEmptyProductList_Click);
            // 
            // btnEmptyCartList
            // 
            this.btnEmptyCartList.Location = new System.Drawing.Point(532, 415);
            this.btnEmptyCartList.Name = "btnEmptyCartList";
            this.btnEmptyCartList.Size = new System.Drawing.Size(256, 23);
            this.btnEmptyCartList.TabIndex = 3;
            this.btnEmptyCartList.Text = "Испразни ја кошницата?";
            this.btnEmptyCartList.UseVisualStyleBackColor = true;
            this.btnEmptyCartList.Click += new System.EventHandler(this.btnEmptyCartList_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(272, 215);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(167, 23);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Додади во кошницата >>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.Location = new System.Drawing.Point(272, 255);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(256, 23);
            this.btnDeleteFromCart.TabIndex = 5;
            this.btnDeleteFromCart.Text = "Избриши од кошница";
            this.btnDeleteFromCart.UseVisualStyleBackColor = true;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(272, 296);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(256, 23);
            this.btnAddNewProduct.TabIndex = 6;
            this.btnAddNewProduct.Text = "Додади нов продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(272, 335);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(256, 23);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Избриши продукт";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtCateggory);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(274, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(10, 127);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(74, 20);
            this.txtCena.TabIndex = 5;
            // 
            // txtCateggory
            // 
            this.txtCateggory.Enabled = false;
            this.txtCateggory.Location = new System.Drawing.Point(10, 88);
            this.txtCateggory.Name = "txtCateggory";
            this.txtCateggory.Size = new System.Drawing.Size(236, 20);
            this.txtCateggory.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(10, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категорија:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(575, 386);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(213, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вкупно:";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(446, 217);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(82, 20);
            this.nudAmount.TabIndex = 9;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnDeleteFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnEmptyCartList);
            this.Controls.Add(this.btnEmptyProductList);
            this.Controls.Add(this.boxCart);
            this.Controls.Add(this.boxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox boxProducts;
        private System.Windows.Forms.ListBox boxCart;
        private System.Windows.Forms.Button btnEmptyProductList;
        private System.Windows.Forms.Button btnEmptyCartList;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnDeleteFromCart;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtCateggory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}


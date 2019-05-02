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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxProducts
            // 
            this.boxProducts.FormattingEnabled = true;
            this.boxProducts.ItemHeight = 16;
            this.boxProducts.Location = new System.Drawing.Point(16, 15);
            this.boxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.boxProducts.Name = "boxProducts";
            this.boxProducts.Size = new System.Drawing.Size(340, 484);
            this.boxProducts.TabIndex = 0;
            this.boxProducts.SelectedIndexChanged += new System.EventHandler(this.boxProducts_SelectedIndexChanged);
            // 
            // boxCart
            // 
            this.boxCart.FormattingEnabled = true;
            this.boxCart.ItemHeight = 16;
            this.boxCart.Location = new System.Drawing.Point(709, 15);
            this.boxCart.Margin = new System.Windows.Forms.Padding(4);
            this.boxCart.Name = "boxCart";
            this.boxCart.Size = new System.Drawing.Size(340, 452);
            this.boxCart.TabIndex = 1;
            // 
            // btnEmptyProductList
            // 
            this.btnEmptyProductList.Location = new System.Drawing.Point(16, 511);
            this.btnEmptyProductList.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmptyProductList.Name = "btnEmptyProductList";
            this.btnEmptyProductList.Size = new System.Drawing.Size(341, 28);
            this.btnEmptyProductList.TabIndex = 2;
            this.btnEmptyProductList.Text = "Испразни ја листата од продукти?";
            this.btnEmptyProductList.UseVisualStyleBackColor = true;
            this.btnEmptyProductList.Click += new System.EventHandler(this.btnEmptyProductList_Click);
            // 
            // btnEmptyCartList
            // 
            this.btnEmptyCartList.Location = new System.Drawing.Point(709, 511);
            this.btnEmptyCartList.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmptyCartList.Name = "btnEmptyCartList";
            this.btnEmptyCartList.Size = new System.Drawing.Size(341, 28);
            this.btnEmptyCartList.TabIndex = 3;
            this.btnEmptyCartList.Text = "Испразни ја кошницата?";
            this.btnEmptyCartList.UseVisualStyleBackColor = true;
            this.btnEmptyCartList.Click += new System.EventHandler(this.btnEmptyCartList_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(363, 265);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(223, 28);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Додади во кошницата >>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.Location = new System.Drawing.Point(363, 314);
            this.btnDeleteFromCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(341, 28);
            this.btnDeleteFromCart.TabIndex = 5;
            this.btnDeleteFromCart.Text = "Избриши од кошница";
            this.btnDeleteFromCart.UseVisualStyleBackColor = true;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(363, 364);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(341, 28);
            this.btnAddNewProduct.TabIndex = 6;
            this.btnAddNewProduct.Text = "Додади нов продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(363, 412);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(341, 28);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Избриши продукт";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtCateggory);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(365, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(13, 156);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(97, 22);
            this.txtCena.TabIndex = 5;
            // 
            // txtCateggory
            // 
            this.txtCateggory.Enabled = false;
            this.txtCateggory.Location = new System.Drawing.Point(13, 108);
            this.txtCateggory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCateggory.Name = "txtCateggory";
            this.txtCateggory.Size = new System.Drawing.Size(313, 22);
            this.txtCateggory.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(13, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 22);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категорија:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(767, 475);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(283, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вкупно:";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(595, 267);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(109, 22);
            this.nudAmount.TabIndex = 9;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            this.nudAmount.Validating += new System.ComponentModel.CancelEventHandler(this.nudAmount_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(172, 156);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(97, 22);
            this.txtStock.TabIndex = 6;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(169, 134);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(73, 17);
            this.text.TabIndex = 7;
            this.text.Text = "Количина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox txtStock;
    }
}


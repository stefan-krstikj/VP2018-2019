namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.ListBox();
            this.cart = new System.Windows.Forms.ListBox();
            this.productDetails = new System.Windows.Forms.GroupBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.deleteFromCart = new System.Windows.Forms.Button();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.clearCart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.productDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кошничка";
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(25, 35);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(223, 316);
            this.products.TabIndex = 2;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // cart
            // 
            this.cart.FormattingEnabled = true;
            this.cart.Location = new System.Drawing.Point(522, 35);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(223, 316);
            this.cart.TabIndex = 3;
            this.cart.DataSourceChanged += new System.EventHandler(this.cart_DataSourceChanged);
            this.cart.DisplayMemberChanged += new System.EventHandler(this.cart_DisplayMemberChanged);
            // 
            // productDetails
            // 
            this.productDetails.Controls.Add(this.priceBox);
            this.productDetails.Controls.Add(this.categoryBox);
            this.productDetails.Controls.Add(this.nameBox);
            this.productDetails.Controls.Add(this.label5);
            this.productDetails.Controls.Add(this.label4);
            this.productDetails.Controls.Add(this.label3);
            this.productDetails.Location = new System.Drawing.Point(254, 46);
            this.productDetails.Name = "productDetails";
            this.productDetails.Size = new System.Drawing.Size(262, 168);
            this.productDetails.TabIndex = 4;
            this.productDetails.TabStop = false;
            this.productDetails.Text = "Детали за продуктот:";
            // 
            // priceBox
            // 
            this.priceBox.Enabled = false;
            this.priceBox.Location = new System.Drawing.Point(9, 134);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 10;
            // 
            // categoryBox
            // 
            this.categoryBox.Enabled = false;
            this.categoryBox.Location = new System.Drawing.Point(9, 88);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(247, 20);
            this.categoryBox.TabIndex = 9;
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(9, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(247, 20);
            this.nameBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Име:";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(254, 241);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(170, 23);
            this.addToCart.TabIndex = 11;
            this.addToCart.Text = "Додади во кошница >>";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // deleteFromCart
            // 
            this.deleteFromCart.Location = new System.Drawing.Point(254, 270);
            this.deleteFromCart.Name = "deleteFromCart";
            this.deleteFromCart.Size = new System.Drawing.Size(262, 23);
            this.deleteFromCart.TabIndex = 12;
            this.deleteFromCart.Text = "Избриши од кошница";
            this.deleteFromCart.UseVisualStyleBackColor = true;
            this.deleteFromCart.Click += new System.EventHandler(this.deleteFromCart_Click);
            // 
            // addNewProduct
            // 
            this.addNewProduct.Location = new System.Drawing.Point(254, 299);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(262, 23);
            this.addNewProduct.TabIndex = 13;
            this.addNewProduct.Text = "Додади нов продукт";
            this.addNewProduct.UseVisualStyleBackColor = true;
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(254, 328);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(262, 23);
            this.deleteProduct.TabIndex = 14;
            this.deleteProduct.Text = "Избриши продукт";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(25, 400);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(223, 23);
            this.clearList.TabIndex = 15;
            this.clearList.Text = "Испразни листа од продукти";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(522, 400);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(223, 23);
            this.clearCart.TabIndex = 16;
            this.clearCart.Text = "Испразни ја кошницата";
            this.clearCart.UseVisualStyleBackColor = true;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вкупно:";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(571, 367);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(174, 20);
            this.total.TabIndex = 11;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(430, 241);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(86, 20);
            this.quantityBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearCart);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.addNewProduct);
            this.Controls.Add(this.deleteFromCart);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.productDetails);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.productDetails.ResumeLayout(false);
            this.productDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.ListBox cart;
        private System.Windows.Forms.GroupBox productDetails;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Button deleteFromCart;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.NumericUpDown quantityBox;
    }
}


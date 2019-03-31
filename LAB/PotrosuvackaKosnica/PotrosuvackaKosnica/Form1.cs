using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Потрошувачка Кошница";
            boxProducts.Items.Add(new Product("Produkt 1", "Cat 1", 150));
            boxProducts.Items.Add(new Product("Produkt 2", "Cat 2", 250));
        }

        public void clearDetails()
        {
            txtCena.Text = "";
            txtName.Text = "";
            txtCateggory.Text = "";
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            
            if(form.ShowDialog() == DialogResult.OK)
            {
                boxProducts.Items.Add(form.addedProduct);
            }
            form.Close();
        }

        private void boxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(boxProducts.SelectedIndex != -1)
            {
                Product product = (Product) boxProducts.SelectedItem;
                txtName.Text = product.Name;
                txtCateggory.Text = product.Category;
                txtCena.Text = String.Format("{0:0.00}", product.price);
            }
        }

        private void btnEmptyProductList_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ги избришете продуктите?", "Избриши ги сите продукти", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                boxProducts.Items.Clear();
                clearDetails();
            }
            
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            if(boxCart.SelectedIndex != -1)
            {
                boxCart.Items.Remove(boxCart.SelectedItem);
            }
            calculateTotal();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            boxProducts.Items.Remove(boxProducts.SelectedItem);
            clearDetails();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            decimal amount = nudAmount.Value;
            Product selectedProduct = (Product) boxProducts.SelectedItem;
            Boolean foundInList = false;
            foreach(ProductItem p in boxCart.Items)
            {
                if (p.Product.Name.Equals(selectedProduct.Name))
                {
                    ProductItem newItem = new ProductItem(selectedProduct, p.Amount + amount);
                    boxCart.Items.Remove(p);
                    boxCart.Items.Add(newItem);
                    foundInList = true;
                    break;
                }
            }

            if (!foundInList)
            {
                ProductItem productItem = new ProductItem(selectedProduct, amount);
                boxCart.Items.Add(productItem);
            }
            calculateTotal();
        }

        private void btnEmptyCartList_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошницата?", "Испразни ја кошницата", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                boxCart.Items.Clear();
            }
            calculateTotal();
        }

        public void calculateTotal()
        {
            float tot = 0;
            foreach (ProductItem p in boxCart.Items)
                tot += p.getTotalCostOfProduct();

            txtTotal.Text = String.Format("{0:0.00}", tot);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float price { get; set; }

        public Product(string name, string category, float price)
        {
            this.Name = name;
            this.Category = category;
            this.price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ProductItem
    {
        public Product Product { get; set; }
        public decimal Amount { get; set; }

        public ProductItem(Product product, decimal amount)
        {
            this.Product = product;
            this.Amount = amount;
        }

        public float getTotalCostOfProduct()
        {
            return (float)Amount * Product.price;
        }

        public override string ToString()
        {
            return String.Format("{0} {1:0.0}x {2:0.0} = {3:0.00}", Product.Name, Amount, Product.price, Product.price * (float)Amount);

        }
    }
}

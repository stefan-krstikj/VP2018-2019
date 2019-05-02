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
            //boxProducts.Items.Add(new Product("Produkt 1", "Cat 1", 150));
            //boxProducts.Items.Add(new Product("Produkt 2", "Cat 2", 250));
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
            updateDisplay();
        }

        public void updateDisplay()
        {
            if (boxProducts.SelectedIndex != -1)
            {
                Product product = (Product)boxProducts.SelectedItem;
                txtName.Text = product.Name;
                txtCateggory.Text = product.Category;
                txtCena.Text = String.Format("{0:0.00}", product.price);
                txtStock.Text = product.Stock.ToString();
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
            selectedProduct.Stock -= (int)amount;
            Boolean foundInList = false;
            foreach(ProductItem p in boxCart.Items)
            {
                if (p.Product.Name.Equals(selectedProduct.Name))
                {
                    ProductItem newItem = new ProductItem(selectedProduct, p.Amount + amount, p.Stock);
                    boxCart.Items.Remove(p);
                    boxCart.Items.Add(newItem);
                    foundInList = true;
                    break;
                }
            }

            if (!foundInList)
            {
                ProductItem productItem = new ProductItem(selectedProduct, amount, selectedProduct.Stock);
                boxCart.Items.Add(productItem);
            }
            updateDisplay();
            calculateTotal();
        }

        public void returnStock(ProductItem pi)
        {
            foreach(Product p in boxProducts.Items)
            {
                if (pi.Product.Name.Equals(p.Name))
                {
                    p.Stock += pi.Stock;
                    updateDisplay();
                    return;
                }
            }
            
        }

        private void btnEmptyCartList_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошницата?", "Испразни ја кошницата", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                foreach(ProductItem p in boxCart.Items)
                {
                    returnStock(p);
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudAmount_Validating(object sender, CancelEventArgs e)
        {
            if (boxProducts.SelectedIndex == -1)
                return;
            Product selectedProduct = (Product)boxProducts.SelectedItem;
            int amountToAdd = (int)nudAmount.Value;
            if(amountToAdd > selectedProduct.Stock)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudAmount, "Not enough in stock!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudAmount, null);
            }
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float price { get; set; }
        public int Stock { get; set; }

        public Product(string name, string category, float price, int stock)
        {
            this.Name = name;
            this.Category = category;
            this.price = price;
            this.Stock = stock;
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
        public int Stock { get; set; }

        public ProductItem(Product product, decimal amount, int Stock)
        {
            this.Product = product;
            this.Amount = amount;
            this.Stock = Stock;
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

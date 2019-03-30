using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public List<Product> prods { get; set; }
        public List<ProductItem> kosnica { get; set; }

        public Form1()
        {
            InitializeComponent();
            prods = new List<Product>();
            kosnica = new List<ProductItem>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void addNewProduct_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.ShowDialog();
            refreshProducts();
        }

        private void refreshProducts()
        {
            products.DisplayMember = "";
            products.DisplayMember = "Name";
            products.DataSource = prods;
           

            cart.DisplayMember = "";
            cart.DisplayMember = "stringRepresentation";
            cart.DataSource = kosnica;
            
        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selected = (Product) products.SelectedItem;
            nameBox.Text = selected.Name;
            categoryBox.Text = selected.Category;
            priceBox.Text = String.Format("{0:0.00}", selected.Price);
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            Product selected = (Product)products.SelectedItem;
            prods.Remove(selected);
            refreshProducts();
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата?", "Испразни ја листата?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            { 
                prods.Clear();
                refreshProducts();
            }
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошницата?", "Испразни ја кошницата?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                kosnica.Clear();
                refreshProducts();
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Product selected = (Product)products.SelectedItem;
            decimal quantity = quantityBox.Value;
            if (quantity == 0)
                return;
            Boolean foundProduct = false;
            foreach(ProductItem pi in kosnica)
            {
                if (pi.product.Name == selected.Name)
                {
                    foundProduct = true;
                    pi.addQuantity(quantity);
                    break;
                }
            }

            if (!foundProduct)
            {
                ProductItem newProduct = new ProductItem(selected, quantity);
                kosnica.Add(newProduct);
            }

            refreshProducts();
        }

        private void deleteFromCart_Click(object sender, EventArgs e)
        {
            ProductItem selected = (ProductItem)cart.SelectedItem;
            kosnica.Remove(selected);
            refreshProducts();
        }

        private void cart_DataSourceChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cart_DisplayMemberChanged(object sender, EventArgs e)
        {
            float totalVal = 0;

            foreach (ProductItem pr in kosnica)
                totalVal += pr.product.Price;

            total.Text = String.Format("{0:0.00}", totalVal);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Product()
        {

        }

        public Product(string name, string category, float price)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }
    }

    public class ProductItem
    {
        public Product product { get; set; }
        public decimal quantity { get; set; }
        public string stringRepresentation { get; set; }

        public ProductItem(Product pr, decimal quan)
        {
            this.product = pr;
            this.quantity = quan;
            updateString();
        }

        public void updateString()
        {
            stringRepresentation = product.Name + " " + string.Format("{0:0.0#}", quantity) + " x " + String.Format("{0:0.0#}", product.Price) + " = " + String.Format("{0:0.0#}", (decimal)product.Price * quantity);
        }

        public void addQuantity(decimal q)
        {
            quantity += q;
            updateString();
        }
    }

}

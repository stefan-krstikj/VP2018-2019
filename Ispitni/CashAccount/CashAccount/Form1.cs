using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddProdut addProdut = new AddProdut();
            if(addProdut.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = new Product(addProdut.name, addProdut.code, addProdut.price);
                // todo proverka dali ima ist vo listata
                foreach(Product p in lbProducts.Items)
                {
                    if (p.code.Equals(newProduct.code))
                    {
                        MessageBox.Show("Веќе има продукт со истиот код!", "Duplicate product");
                        return;
                    }
                }
                lbProducts.Items.Add(newProduct);
                btnAddToCart.Enabled = true;
                nupQuantity.Enabled = true;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Product product = (Product) lbProducts.SelectedItem;
            int quantity = (int)nupQuantity.Value;
            CartItem toAdd = new CartItem(quantity, product);

            Boolean add = true;
            foreach(CartItem ci in lbCart.Items)
            {
                if (ci.product.code.Equals(toAdd.product.code))
                {
                    ci.quantity += quantity;
                    add = false;         
                }
            }
            if(add)
                lbCart.Items.Add(toAdd);
            

            btnRemove.Enabled = true;
            updateValues();
        }

        public void updateValues()
        {
            decimal total = 0;
            foreach (CartItem ci in lbCart.Items)
            {
                total += ci.getPrice();
            }
            tbTotal.Text = total.ToString();

            int danok = (int) nupDanok.Value;

            decimal zaPlakanje = total + ((danok / 100) * total);

            tbPlakanje.Text = zaPlakanje.ToString();
        }

        private void tbDanok_TextChanged(object sender, EventArgs e)
        {
            updateValues();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }

    public class Product
    {
        public string name { get; set; }
        public int code { get; set; }
        public decimal price { get; set; }

        public Product(string name, int code, decimal price)
        {
            this.name = name;
            this.code = code;
            this.price = price;
        }

        public override string ToString()
        {
            return name + " (" + code + ") " + price + "mkd";
        }
    }

    public class CartItem
    {
        public int quantity { get; set; }
        public Product product { get; set; }

        public CartItem(int quantity, Product product)
        {
            this.quantity = quantity;
            this.product = product;
        }

        public decimal getPrice()
        {
            return quantity * product.price;
        }

        public override string ToString()
        {
            return product + " x" + quantity;
        }
    }
}

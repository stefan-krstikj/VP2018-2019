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
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.Show();
            
            boxProducts.Items.Add(form.addedProduct);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string category { get; set; }
        public float price { get; set; }

        public Product(string name, string category, float price)
        {
            this.Name = name;
            this.category = category;
            this.price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

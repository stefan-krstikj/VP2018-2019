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
    public partial class AddProduct : Form
    {
        public Product addedProduct { get; set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string category = txtCategory.Text;
            float price = (float) Convert.ToDecimal(txtPrice.Text);
            Product product = new Product(name, category, price);
            this.addedProduct = product;
            this.Close();
        }
    }
}

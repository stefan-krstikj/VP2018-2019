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
            int kolicina = Convert.ToInt32(txtKolicina.Text);
            Product product = new Product(name, category, price, kolicina);
            this.addedProduct = product;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errName.SetError(txtName, "Внеси име!");
            }
            else
            {
                errName.SetError(txtName, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            int intVal;

            if (!int.TryParse(txtPrice.Text, out intVal))
            {
                e.Cancel = true;
                errPrice.SetError(txtPrice, "Внеси валидна цена!");
            }
            else
            {
                errPrice.SetError(txtPrice, null);
            }
        }
    }
}

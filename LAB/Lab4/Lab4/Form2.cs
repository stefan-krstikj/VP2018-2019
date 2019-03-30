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
    public partial class Form2 : Form
    {
        Form1 incomingForm;
        public Form2(Form1 IncomingForm)
        {
            InitializeComponent();
            this.Text = "Нов продукт";
            this.incomingForm = IncomingForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string category = categoryBox.Text;
            float price = (float)Convert.ToDouble(priceBox.Text);

            Product product = new Product(name, category, price);
            incomingForm.prods.Add(product);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Name_Validating(object sender, CancelEventArgs e)
        {
            if (nameBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nameBox, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(nameBox, null);
            }
        }
    }
}

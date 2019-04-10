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
    public partial class AddProdut : Form
    {
        public string name { get; set; }
        public int code { get; set; }
        public decimal price { get; set; }
        public AddProdut()
        {
            InitializeComponent();
        }

        private void AddProdut_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.name = tbName.Text;
            this.price = nupPrice.Value;
            this.code = (int) nupCode.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                e.Cancel = true;
                errName.SetError(tbName, "Не може да е празно името!");
            }
            else
            {
                e.Cancel = false;
                errName.SetError(tbName, null);
            }
        }
    }
}

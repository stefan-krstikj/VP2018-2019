using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezultati
{
    public partial class addStrelec : Form
    {
        public string attName { get; set; }
        public int pts { get; set; }
        public addStrelec()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            attName = txtPlayerName.Text;
            pts = Convert.ToInt32(txtPoints.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlayerName_Validating(object sender, CancelEventArgs e)
        {
            if(txtPlayerName.Text.Length == 0)
            {
                e.Cancel = true;
                errName.SetError(txtPlayerName, "Enter a player name!");
            }
            else
            {
                errName.SetError(txtPlayerName, null);
            }
        }

        private void txtPoints_Validating(object sender, CancelEventArgs e)
        {
            if (txtPoints.Text.Length == 0)
            {
                e.Cancel = true;
                errPts.SetError(txtPoints, "Enter points!!");
            }
            else
            {
                errPts.SetError(txtPoints, null);
            }
        }
    }
}

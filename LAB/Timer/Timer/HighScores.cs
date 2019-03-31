using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class HighScores : Form
    {
        List<Igrach> scores;
        public HighScores(List<Igrach> lista)
        {
            InitializeComponent();
            this.scores = lista;
            boxHighScores.DataSource = lista;
        }

        private void boxHighScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class addMatch : Form
    {
        public Game<Football> fGame { get; set; }
        public Game<Basketball> bGame { get; set; }
        public List<Details<int, string>> detaliD { get; set; }
        public List<Details<int, string>> detaliG { get; set; }
        public string type { get; set; }
        public addMatch(Form1 form)
        {
            InitializeComponent();
            detaliD = new List<Details<int, string>>();
            detaliG = new List<Details<int, string>>();
            comboMatchType.SelectedIndex = 0;
        }
        
        public Details<int, string> addStrelec()
        {
            addStrelec form = new addStrelec();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Details<int, string> details = new Details<int, string>();
                details.Key = form.pts;
                details.Value = form.attName;
                form.DialogResult = DialogResult.OK;
                form.Close();
                return details;
            }
            else
                return null;
            
        }

        private void button1_Click(object sender, EventArgs e) // add strelci doma
        {
            Details<int, string> strelec = addStrelec();
            detaliD.Add(strelec);
            boxHomeStrelci.Items.Add(strelec);
        }

        private void btnAddAwayStrelec_Click(object sender, EventArgs e) // add strelci away
        {
            Details<int, string> strelec = addStrelec();
            detaliG.Add(strelec);
            boxAwayStrelci.Items.Add(strelec);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string home = txtHome.Text;
            string visitor = txtAway.Text;
            int homeScore = Convert.ToInt32(txtHomeGoals.Text);
            int visitorScore = Convert.ToInt32(txtAwayGoals.Text);

            if(comboMatchType.SelectedIndex == 0)
            {
                // selected basketball
                this.type = "kosarka";
                Basketball detailsVisitor = new Basketball();
                Basketball detailsHome = new Basketball();

                foreach (Details<int, string> d in detaliD)
                    detailsHome.gameDetails.Add(d);
                foreach (Details<int, string> d in detaliG)
                    detailsVisitor.gameDetails.Add(d);

                bGame = new Game<Basketball>(home, visitor, homeScore, visitorScore, detailsHome, detailsVisitor);
            }
            else
            {
                // selected football
                this.type = "fudbal";
                Football detailsHome = new Football();
                Football detailsVisitor = new Football();

                foreach (Details<int, string> d in detaliD)
                {
                    Details<string, string> dt = new Details<string, string>();
                    dt.Key = d.Key + " min";
                    dt.Value = d.Value;
                    detailsHome.gameDetails.Add(dt);
                }

                foreach (Details<int, string> d in detaliG)
                {
                    Details<string, string> dt = new Details<string, string>();
                    dt.Key = d.Key + " min";
                    dt.Value = d.Value;
                    detailsVisitor.gameDetails.Add(dt);
                }

                fGame = new Game<Football>(home, visitor, homeScore, visitorScore, detailsHome, detailsVisitor);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHome_Validating(object sender, CancelEventArgs e)
        {
            if (txtHome.Text.Equals(""))
            {
                e.Cancel = true;
                errHome.SetError(txtHome, "Enter a name");
            }
            else
            {
                errHome.SetError(txtHome, null);
            }
        }

        private void txtAway_Validating(object sender, CancelEventArgs e)
        {
            if (txtAway.Text.Equals(""))
            {
                e.Cancel = true;
                errAway.SetError(txtAway, "Enter a name");
            }
            else
            {
                errAway.SetError(txtAway, null);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaracuvanjePizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(vkupnoNaplata.Text);
            double plateno = Convert.ToDouble(naplateno.Text);
            vrakanje.Text = plateno - total + "";
        }

        private void Form1_TextChanged(object sender, EventArgs s)
        {

        }

        private void CalculateTotal()
        {
            float total = 0;
            // first find which radio button is checked
            total += CalculateGolemina();
            total += CalculateDodatoci();
            total += CalculatePijaloci();
            total += CalculateDeserti();

            vkupnoNaplata.Text = total + "";
        }

        private float CalculateDeserti()
        {
            int total = 0;

            foreach(Desert d in desertBox.Items)
            {
                total += d.price;
            }

            return total;
        }

        private float CalculatePijaloci()
        {
            float total = 0;

            if (vkupno1.Enabled)
                total += (float)Convert.ToDouble(vkupno1.Text);
            if (vkupno2.Enabled)
                total += (float)Convert.ToDouble(vkupno2.Text);
            if (vkupno3.Enabled)
                total += (float)Convert.ToDouble(vkupno3.Text);

            return total;
        }

        private float CalculateDodatoci()
        {
            float total = 0;
            if (checkBox1.Checked)
                total += (float)Convert.ToDouble(textBox4.Text);
            if (checkBox2.Checked)
                total += (float)Convert.ToDouble(textBox5.Text);
            if (checkBox3.Checked)
                total += (float)Convert.ToDouble(textBox6.Text);

            return total;
        }
        private float CalculateGolemina()
        {
            float total = 0;
            RadioButton rb = null;
            if (radioButton1.Checked == true)
                rb = radioButton1;
            else if (radioButton2.Checked == true)
                rb = radioButton2;
            else
                rb = radioButton3;

            if (rb.TabIndex == 0)
                total += (float)Convert.ToDouble(textBox1.Text);
            else if (rb.TabIndex == 1)
                total += (float)Convert.ToDouble(textBox2.Text);
            else
                total += (float)Convert.ToDouble(textBox3.Text);
            return total;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poraka = "";
            if (radioButton1.Checked)
                poraka += "Mala";
            else if (radioButton2.Checked)
                poraka += "Sredna";
            else
                poraka += "Golema";

            poraka += "\nDodatoci:\n";
            bool foundDodatoci = false;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                foundDodatoci = true;
            if (checkBox1.Checked)
                poraka += checkBox1.Text + "\n";
            if (checkBox2.Checked)
                poraka += checkBox2.Text + "\n";
            if (checkBox3.Checked)
                poraka += checkBox3.Text + "\n";
            if (!foundDodatoci)
                poraka += "NEMA\n";


            poraka += "Pijaloci:\n";
            Boolean foundPijalok = false;
            if (vkupno1.Enabled)
            {
                foundPijalok = true;
                poraka += Convert.ToDouble(kolicina1.Text) + " " + label1.Text + "\n";
            }
            if (vkupno2.Enabled)
            {
                foundPijalok = true;
                poraka += Convert.ToDouble(kolicina2.Text) + " " + label2.Text + "\n";
            }
            if (vkupno3.Enabled)
            {
                foundPijalok = true;
                poraka += Convert.ToDouble(kolicina3.Text) + " " + label3.Text + "\n";
            }
            if (!foundPijalok)
                poraka += "NEMA\n";

            poraka += "Deserti: \n";
            if(desertBox.Items.Count > 0)
            {
                foreach (Desert d in desertBox.Items)
                    poraka += d.name + "\n";
            }
            else
            {
                poraka += "NEMA\n";
            }

            DialogResult result = MessageBox.Show(poraka, "Дали сакате да нарачате?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void kolicina1_TextChanged(object sender, EventArgs e)
        {
            vkupno1.Text = Convert.ToDouble(kolicina1.Text) * Convert.ToDouble(cena1.Text) + "";
            vkupno1.Enabled = true;
            CalculateTotal();
        }

        private void cena1_TextChanged(object sender, EventArgs e)
        {
            vkupno1.Enabled = true;
            vkupno1.Text = Convert.ToDouble(kolicina1.Text) * Convert.ToDouble(cena1.Text) + "";
            CalculateTotal();
        }

        private void kolicina2_TextChanged(object sender, EventArgs e)
        {
            vkupno2.Text = Convert.ToDouble(kolicina2.Text) * Convert.ToDouble(cena2.Text) + "";
            vkupno2.Enabled = true;
            CalculateTotal();
        }

        private void cena2_TextChanged(object sender, EventArgs e)
        {
            vkupno2.Text = Convert.ToDouble(kolicina2.Text) * Convert.ToDouble(cena2.Text) + "";
            vkupno2.Enabled = true;
            CalculateTotal();
        }

        private void kolicina3_TextChanged(object sender, EventArgs e)
        {
            vkupno3.Text = Convert.ToDouble(kolicina3.Text) * Convert.ToDouble(cena3.Text) + "";
            vkupno3.Enabled = true;
            CalculateTotal();
        }

        private void cena3_TextChanged(object sender, EventArgs e)
        {
            vkupno3.Text = Convert.ToDouble(kolicina3.Text) * Convert.ToDouble(cena3.Text) + "";
            vkupno3.Enabled = true;
            CalculateTotal();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void desertCena_TextChanged(object sender, EventArgs e)
        {

        }

        private void desertName_TextChanged(object sender, EventArgs e)
        {
            desertCena.Enabled = true;
        }

        private void addDesert_Click(object sender, EventArgs e)
        {
            if(desertName.Text != null && desertCena.Text != null)
            {
                Desert desert = new Desert(desertName.Text, Convert.ToInt32(desertCena.Text));
                desertBox.Items.Add(desert);
                desertName.Text = "";
                desertCena.Text = "";
                desertCena.Enabled = false;
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Please enter a desert name!", "Missing Desert Name");
            }
        }

        private void deleteItemFromBox_Click(object sender, EventArgs e)
        {
            desertBox.Items.Remove(desertBox.SelectedItem);
            CalculateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }
    }

    public class Desert
    {
        public string name { get; set; }
        public int price { get; set; }

        public Desert(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return name + " - " + price + "ден" ;
        }
    }
}

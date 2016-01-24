using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat
{
    public partial class AdaugMod : Form
    {
        public AdaugMod()
        {
            InitializeComponent();
            meniuTableAdapter.Categorii(tabelDataSet.Meniu);
            DataTable dt = tabelDataSet.Meniu;
            for (int i = 0; i < dt.Rows.Count; i++)
                listBox1.Items.Add(dt.Rows[i]["Categorie"].ToString());
        }

        private void AdaugMod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Preparate' table. You can move, or remove it, as needed.
            this.preparateTableAdapter.Fill(this.tabelDataSet.Preparate);
            // TODO: This line of code loads data into the 'tabelDataSet.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.tabelDataSet.Personal);
            // TODO: This line of code loads data into the 'tabelDataSet.Nr_comanda' table. You can move, or remove it, as needed.
            this.nr_comandaTableAdapter.Fill(this.tabelDataSet.Nr_comanda);
            // TODO: This line of code loads data into the 'tabelDataSet.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.tabelDataSet.Meniu);
            // TODO: This line of code loads data into the 'tabelDataSet.Comanda' table. You can move, or remove it, as needed.
            this.comandaTableAdapter.Fill(this.tabelDataSet.Comanda);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && listBox2.SelectedIndex > -1)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            else MessageBox.Show("Te rog sa alegi o categorie si un preparat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && listBox2.SelectedIndex > -1)
            {
                if (int.Parse(textBox1.Text) > 0)
                    textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            }
            else MessageBox.Show("Te rog sa alegi o categorie si un preparat");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.SelectedIndex > -1)
            {
                string s = listBox1.SelectedItem.ToString();
                int p = int.Parse(meniuTableAdapter.ReturnID(s).ToString());
                DataTable dt = tabelDataSet.Preparate;
                for (int i = 0; i < dt.Rows.Count; i++)

                    if ((int)dt.Rows[i]["ID_m"] == p)
                    {
                        listBox2.Items.Add(dt.Rows[i]["Denumire"].ToString());
                    }
            }
        }
        ModificareComenzi _owner = new ModificareComenzi();
        private void button3_Click(object sender, EventArgs e)
        {

                if (listBox2.SelectedIndex > -1)
                {
                   
                    string g = listBox2.SelectedItem.ToString();
                    int ok = 1;
                    int y = Class1.u;
                    comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, y);
                    DataTable dt = tabelDataSet.Comanda;
                    for (int i = 0; i < dt.Rows.Count; i++)
                        if (dt.Rows[i]["Denumire_prep"].ToString() == g)
                        {
                            ok = 0;
                            int can = int.Parse(textBox1.Text);
                            int ii=(int)dt.Rows[i]["ID_prep"];
                            if (can == 0)
                            {
                                comandaTableAdapter.StergerePrepDinComanda(y, ii, g);
                            }
                            else
                                comandaTableAdapter.Updateeee(can, y, ii, g);
                             comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, y);
                        }
                    if (ok == 1)
                    {
                        int o = (int)preparateTableAdapter.ReturnID(g);
                        comandaTableAdapter.AdaugareInComanda(y, o, g, int.Parse(textBox1.Text));
                        comandaTableAdapter.Fill(tabelDataSet.Comanda);
                        comandaTableAdapter.Update(tabelDataSet.Comanda);
                    }
                } _owner.Refreshh();
                listBox2.SelectedIndex = -1;
                textBox1.Text = "0";
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                int y = Class1.u;
                comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, y);
                DataTable dt = tabelDataSet.Comanda;
                string g = listBox2.SelectedItem.ToString();
                int ok=-1;
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["Denumire_prep"].ToString() == g)
                    {
                        ok = i;
                        i = dt.Rows.Count;
                    }
                if (ok == -1)
                    textBox1.Text = "0";
                else textBox1.Text = dt.Rows[ok]["Cantitate_prep"].ToString();

            }
        }

       /* private void Inchidere(object sender, FormClosingEventArgs e)
        {
            _owner.Refreshh();
        }*/
        


    }
}

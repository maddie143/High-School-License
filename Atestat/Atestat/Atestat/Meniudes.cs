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
    public partial class Meniudes : Form
    {
        public Meniudes()
        {
            InitializeComponent();
            meniuTableAdapter.Categorii(tabelDataSet.Meniu);
            DataTable dt = tabelDataSet.Meniu;
            for (int i = 0; i < dt.Rows.Count; i++)
                listBox1.Items.Add(dt.Rows[i]["Categorie"]);
            listBox2.Text = "";
            listBox3.Text = "";
            listBox4.Text = "";
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
        }
        private void Meniudes_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string s = listBox1.SelectedItem.ToString();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox2.Visible = true;
                listBox3.Visible = true;
                listBox4.Visible = true;
                
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                int p = int.Parse(meniuTableAdapter.ReturnID(s).ToString());
                DataTable dt = tabelDataSet.Preparate;
                for (int i = 0; i < dt.Rows.Count; i++)

                    if ((int)dt.Rows[i]["ID_m"] == p)
                    {
                        listBox2.Items.Add(dt.Rows[i]["Denumire"].ToString());
                        listBox3.Items.Add(dt.Rows[i]["Gramaj (g)"].ToString());
                        listBox4.Items.Add(dt.Rows[i]["Pret"].ToString() + " lei");
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox3.SelectedIndex = listBox2.SelectedIndex;
                listBox4.SelectedIndex = listBox2.SelectedIndex;
            }


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1 && listBox3.SelectedIndex != listBox2.SelectedIndex)
            {
                MessageBox.Show("Actiune nepermisa");
                listBox3.SelectedIndex = listBox2.SelectedIndex;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex > -1 && listBox4.SelectedIndex != listBox2.SelectedIndex)
            {
                MessageBox.Show("Actiune nepermisa");
                listBox4.SelectedIndex = listBox2.SelectedIndex;
            }
        }


        
    }
}

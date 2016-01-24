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
    public partial class Adauga : Form
    {
        public Adauga()
        {
            InitializeComponent();
            meniuTableAdapter.Categorii(tabelDataSet.Meniu);
            DataTable dt = tabelDataSet.Meniu;
            for (int i = 0; i < dt.Rows.Count; i++)
                listBox1.Items.Add(dt.Rows[i]["Categorie"]);
            button5.Visible = false;
            listBox2.Visible = false;
            listBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = true;
        }
        private void Adauga_Load(object sender, EventArgs e)
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
        public int ok = 0;




        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            MessageBoxButtons but = MessageBoxButtons.YesNoCancel;
            DialogResult res;
            res = MessageBox.Show("Doriti sa salvati comanda?", "", but);
            if (res == DialogResult.Yes)
            {
                this.Close();
                ok = 0;
            }
            else
            {
                if (res == DialogResult.Cancel)
                {
                }
                else
                {
                    if (res == DialogResult.No)
                    {
                        int v = int.Parse(nr_comandaTableAdapter.MaximID().ToString());
                        short u = (short)(v);
                        comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, u);
                        DataTable dt = tabelDataSet.Comanda;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int p1 = (int)dt.Rows[i]["ID_prep"];
                            int p2 = (int)dt.Rows[i]["Cantitate_prep"];
                            short p11 = short.Parse(p1.ToString());
                            short p22 = short.Parse(p2.ToString());
                            comandaTableAdapter.DeleteQuery(u, p11, dt.Rows[i]["Denumire_prep"].ToString(), p22);
                        }
                        nr_comandaTableAdapter.DeleteID(v);
                        ok = 0;
                        this.Close();
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string s = listBox1.SelectedItem.ToString();
                int p = int.Parse(meniuTableAdapter.ReturnID(s).ToString());
                DataTable dt = tabelDataSet.Preparate;
                listBox1.Visible = false;
                listBox2.Visible = true;
                label3.Visible = true;
                label2.Visible = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if ((int)dt.Rows[i]["ID_m"] == p)
                    {

                        listBox2.Items.Add(dt.Rows[i]["Denumire"]);
                    }
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                string u = listBox2.SelectedItem.ToString();
                string p = preparateTableAdapter.ReturnGramaj(u).ToString();

                label7.Text = "";
                label8.Text = "";
                textBox1.Text = "0";
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label7.Text = p.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            string u = listBox2.SelectedItem.ToString();
            label8.Text = (int.Parse(textBox1.Text) * (int.Parse(preparateTableAdapter.ReturnPret(u).ToString()))).ToString() + " lei";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = listBox2.SelectedItem.ToString();
            if (int.Parse(textBox1.Text) > 0)
            {
                textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
                label8.Text = (int.Parse(textBox1.Text) * (int.Parse(preparateTableAdapter.ReturnPret(u).ToString()))).ToString() + " lei";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1 && listBox1.SelectedIndex > -1)
            {
                int u = int.Parse(nr_comandaTableAdapter.MaximID().ToString());
                string t = listBox2.SelectedItem.ToString();
                int y = (int)preparateTableAdapter.ReturnID(t);
                if (ok == 0)
                {
                    nr_comandaTableAdapter.AdaugareComandaNoua(u + 1,int.Parse(textBox2.Text));
                    comandaTableAdapter.AdaugareInComanda(u + 1, y, t, int.Parse(textBox1.Text));
                    nr_comandaTableAdapter.Fill(tabelDataSet.Nr_comanda);
                    nr_comandaTableAdapter.Update(tabelDataSet.Nr_comanda);
                    ok = 1;
                    comandaTableAdapter.Fill(tabelDataSet.Comanda);
                    comandaTableAdapter.Update(tabelDataSet.Comanda);
                }
                else if (ok == 1)
                {
                    int ok1 = 1;
                    //int cl = Class1.u;
                    comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, u);
                    DataTable dt = tabelDataSet.Comanda;
                    int can=int.Parse(textBox1.Text);
                    if (can > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                            if (dt.Rows[i]["Denumire_prep"].ToString() == t)
                            {
                                ok1 = 0;
                                int ii = (int)dt.Rows[i]["ID_prep"];
                                int cant = (int)dt.Rows[i]["Cantitate_prep"] + can;
                                MessageBox.Show(cant.ToString());
                                comandaTableAdapter.Updateeee(cant, u, ii, t);
                                comandaTableAdapter.Update(tabelDataSet.Comanda);
                                i = dt.Rows.Count;
                            }
                        if (ok1 == 1)
                        {
                            int o = (int)preparateTableAdapter.ReturnID(t);
                            comandaTableAdapter.AdaugareInComanda(u, o, t, int.Parse(textBox1.Text));
                            comandaTableAdapter.Fill(tabelDataSet.Comanda);
                            comandaTableAdapter.Update(tabelDataSet.Comanda);
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void Enter2(object sender, KeyEventArgs e)
        {
            DataTable d = tabelDataSet.Personal;
            if (e.KeyData == Keys.Enter)
            {
                if ((int)personalTableAdapter.OraIntrare(int.Parse(textBox2.Text)) != 0)
                {
                    button5.Visible = true;
                    //listBox2.Visible = true;
                    listBox1.Visible = true;
                    //label3.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = false;
                    label9.Visible = false;
                    button6.Visible = true;
                   // Class1.u = int.Parse(textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Inainte de a adauga o comanda te rugam sa te autentifici.");
                    textBox2.Text = "";
                    this.Close();
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



    }
}

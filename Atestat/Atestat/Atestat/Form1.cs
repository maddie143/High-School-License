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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meniudes f2 = new Meniudes();
            f2.ShowDialog();
        }

        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adauga f3 = new Adauga();
            f3.Size = this.Size;
            f3.ShowDialog();
        }


        private void vizualizareComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareComenzi t = new VizualizareComenzi();
            t.Size = this.Size;
            t.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           textBox2.UseSystemPasswordChar = true;
        }

        private void Enter1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DataTable d = tabelDataSet.Personal;
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    int ok1 = 0, ok2 = 0, p = -1;
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        ok1 = 0;
                        ok2 = 0;
                        if (d.Rows[i]["ID"].ToString() == textBox1.Text)
                            ok1 = 1;
                        if (d.Rows[i]["Parola"].ToString() == textBox2.Text)
                            ok2 = 1;
                        if (ok1 + ok2 == 1)
                        {
                            MessageBox.Show("Datele nu au fost introduse corect.");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        if (ok1 == 1 && ok2 == 1)
                        {
                            p = i;
                            i = d.Rows.Count;
                        }
                    }
                    if (ok1 == 1 && ok2 == 1)
                    {
                        if (d.Rows[p]["Ora_intrare"].ToString() == "0")
                        {
                            d.Rows[p]["Ora_intrare"] = DateTime.Now.Hour;
                            //personalTableAdapter.Fill(tabelDataSet.Personal);
                            personalTableAdapter.Update(tabelDataSet.Personal);
                            button1.Visible = true;
                            button2.Visible = false;

                        }
                        else
                        {
                            d.Rows[p]["Nr_ore"] = ((int)d.Rows[p]["Nr_ore"] + int.Parse(DateTime.Now.Hour.ToString()) - int.Parse(d.Rows[p]["ora_intrare"].ToString())).ToString();
                            d.Rows[p]["Ora_intrare"] = 0;
                            //personalTableAdapter.Fill(tabelDataSet.Personal);
                            personalTableAdapter.Update(tabelDataSet.Personal);
                            button2.Visible = true;
                            button1.Visible = false;
                        }
                    }
                    if (ok1 + ok2 == 1)
                        MessageBox.Show("Datele nu au fost introduse corect.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            //personalTableAdapter.Fill(tabelDataSet.Personal);
            personalTableAdapter.Update(tabelDataSet.Personal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void vizualizareComenziToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VizualizareComenzi t=new VizualizareComenzi();
            t.ShowDialog();
        }

        private void modificareComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificareComenzi y = new ModificareComenzi();
            y.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInPersonal y = new LogInPersonal();
            y.ShowDialog();
        }


    }
}

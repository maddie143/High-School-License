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
    public partial class VizualizareComenzi : Form
    {
        public VizualizareComenzi()
        {
            InitializeComponent();
            listBox1.Visible = false;
            listBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void VizualizareComenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabelDataSet.Nr_comanda' table. You can move, or remove it, as needed.
            this.nr_comandaTableAdapter.Fill(this.tabelDataSet.Nr_comanda);
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
                MessageBox.Show("Actiune nepermisa");
            listBox1.SelectedIndex = -1;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
                MessageBox.Show("Actiune nepermisa");
            listBox2.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (dataGridView1.SelectedCells.Count != 0)
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    int y = int.Parse((dataGridView1.SelectedCells[0].ColumnIndex + 1).ToString());
                    if (y > 1)
                        MessageBox.Show("Selectati un ID al unei comenzi");
                    else
                    {
                        int p = int.Parse((dataGridView1.SelectedCells[0].RowIndex + 1).ToString());
                        comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, p);
                        int u = 0;
                        DataTable dt = tabelDataSet.Comanda;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            listBox1.Items.Add(dt.Rows[i]["Denumire_prep"].ToString());
                            listBox2.Items.Add(dt.Rows[i]["Cantitate_prep"].ToString());
                            int p1 = (int)preparateTableAdapter.ReturnPret(dt.Rows[i]["Denumire_prep"].ToString());
                            int pre = (int)dt.Rows[i]["Cantitate_prep"];
                            u = u + p1 * pre;
                        }
                        label4.Text = u.ToString();
                    }
                }
                else if (dataGridView1.SelectedCells.Count > 1)
                    MessageBox.Show("Acces nepermis");
            }
        }
    }
}

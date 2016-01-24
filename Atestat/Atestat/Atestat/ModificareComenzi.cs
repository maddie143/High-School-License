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
    public partial class ModificareComenzi : Form
    {
        public ModificareComenzi()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;


        }

        private void ModificareComenzi_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            button2.Visible = true;
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
                         comandaTableAdapter.Return3x(tabelDataSet.Comanda, p);
                        
                        comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, p);
                        int u = 0;
                        DataTable dt = tabelDataSet.Comanda;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                           int p1 = (int)preparateTableAdapter.ReturnPret(dt.Rows[i]["Denumire_prep"].ToString());
                           int pre = (int)dt.Rows[i]["Cantitate_prep"];
                           u = u + p1 * pre;
                        }
                        label3.Visible = true;
                        label4.Visible = true;
                        label4.Text = u.ToString() + " lei";
                        Class1.u = int.Parse((dataGridView1.SelectedCells[0].RowIndex + 1).ToString());
                         //dataGridView2.Update();
                    }
                }
                else if (dataGridView1.SelectedCells.Count > 1)
                    MessageBox.Show("Acces nepermis");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugMod p = new AdaugMod();
            p.ShowDialog();
        }
        public void Refreshh()
        {
            int y = Class1.u;
            comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, y);
            dataGridView2.Refresh();
            dataGridView2.Update();
        }

    }
}

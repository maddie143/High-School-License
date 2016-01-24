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
    public partial class PersonalEx : Form
    {
        public PersonalEx()
        {
            InitializeComponent();
            nr_comandaTableAdapter.Nimic(tabelDataSet.Nr_comanda);
            DataTable dt = tabelDataSet.Nr_comanda;
            int S=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int y = (int)dt.Rows[i]["ID"];
                comandaTableAdapter.GasireDupaID(tabelDataSet.Comanda, y);
                DataTable r = tabelDataSet.Comanda;
                for (int j = 0; j < r.Rows.Count; j++)
                {
                    //MessageBox.Show(r.Rows[j]["Denumire_prep"].ToString());
                    int ii = (int)preparateTableAdapter.ReturnPret(r.Rows[j]["Denumire_prep"].ToString());
                    S = S + ii * ((int)r.Rows[j]["Cantitate_prep"]);
                }
                comandaTableAdapter.Revenire(tabelDataSet.Comanda);
            }
            label4.Text = S.ToString();
        }

        private void PersonalEx_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'tabelDataSet.Preparate' table. You can move, or remove it, as needed.
this.preparateTableAdapter.Fill(this.tabelDataSet.Preparate);
// TODO: This line of code loads data into the 'tabelDataSet.Personal' table. You can move, or remove it, as needed.
this.personalTableAdapter.Fill(this.tabelDataSet.Personal);
// TODO: This line of code loads data into the 'tabelDataSet.Meniu' table. You can move, or remove it, as needed.
this.meniuTableAdapter.Fill(this.tabelDataSet.Meniu);
// TODO: This line of code loads data into the 'tabelDataSet.Comanda' table. You can move, or remove it, as needed.
this.comandaTableAdapter.Fill(this.tabelDataSet.Comanda);
            // TODO: This line of code loads data into the 'tabelDataSet.Nr_comanda' table. You can move, or remove it, as needed.
            this.nr_comandaTableAdapter.Fill(this.tabelDataSet.Nr_comanda);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchimbaParola t = new SchimbaParola();
            t.ShowDialog();
        }
    }
}

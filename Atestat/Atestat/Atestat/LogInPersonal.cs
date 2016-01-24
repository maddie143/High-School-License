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
    public partial class LogInPersonal : Form
    {
        public LogInPersonal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Class1.user && textBox2.Text == Class1.pass)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.Close();
                PersonalEx i = new PersonalEx();
                i.ShowDialog();
            }
            else MessageBox.Show("Date de identificare incorecte");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}

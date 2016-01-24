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
    public partial class SchimbaParola : Form
    {
        public SchimbaParola()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            textBox2.UseSystemPasswordChar = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Class1.pass)
                Class1.pass = textBox2.Text;
            else MessageBox.Show("Parola veche incorecta");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= "A cor é roxo";
            label1.ForeColor = Color.Purple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "A cor é verde";
            label1.ForeColor = Color.Lime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "A cor é vermelho";
            label1.ForeColor = Color.Red;
        }
    }
}

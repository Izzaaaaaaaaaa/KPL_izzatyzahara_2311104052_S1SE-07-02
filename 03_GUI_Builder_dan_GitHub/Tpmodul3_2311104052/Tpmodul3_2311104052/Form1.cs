using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpmodul3_2311104052
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaPraktikan = txtinput.Text.Trim(); 

            if (namaPraktikan.Equals("IZZATY ZAHARA", StringComparison.OrdinalIgnoreCase))
            {
                labeloutp.Text = $"Halo {namaPraktikan}";
            }
            else
            {
                labeloutp.Text = "Nama tidak dikenali.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

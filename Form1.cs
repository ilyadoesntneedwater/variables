using System;
using System.Windows.Forms;

namespace Программа__в_которой_есть_переменные
{


    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

       

        private void Button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}


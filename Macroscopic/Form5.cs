using System;
using System.Windows.Forms;

namespace Macroscopic
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();

            this.Hide();
            main.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

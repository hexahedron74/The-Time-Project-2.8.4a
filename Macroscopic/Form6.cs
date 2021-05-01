using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macroscopic
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label4.Text = DateTime.Now.ToString("ss");
            label2.Text = DateTime.Now.ToString("yyyy년 MMM월 dd일");
            label3.Text = DateTime.Now.ToString("dddd");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

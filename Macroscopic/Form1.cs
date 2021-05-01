using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Macroscopic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 stopwatch = new Form3();
            this.Hide();
            stopwatch.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 license = new Form4();
            this.Hide();
            license.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 about = new Form5();
            this.Hide();
            about.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 timer = new Form2();
            this.Hide();
            timer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 info = new AboutBox1();
            this.Hide();
            info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 CurrentTime = new Form6();
            this.Hide();
            CurrentTime.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 developer = new Form7();
            this.Hide();
            developer.Show();
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Macroscopic
{
    public partial class Form3 : Form
    {
        System.Timers.Timer t;
        int seconds;
        int minutes;
        int hours;
        
        public Form3()
        {
            InitializeComponent();
            seconds = minutes = hours = 0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
            label1.Text = appendZero(hours);
            label2.Text = appendZero(minutes);
            label3.Text = appendZero(seconds);
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if(seconds > 59)
            {
                minutes++;
                seconds = 0;
            }

            if(minutes >59)
            {
                hours++;
                minutes = 0;
            }
            label1.Text = appendZero(hours);
            label2.Text = appendZero(minutes);
            label3.Text = appendZero(seconds);
        }

        private string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

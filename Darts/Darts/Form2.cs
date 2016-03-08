using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darts
{
    public partial class Form2 : Form
    {
        public string fo
        {
            get { return label4.Text;}
            set { label4.Text = value; }
        }

        Form1 f1;
        Form3 f3;
        Form4 f4;
        
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
           
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {


        }

        private void displayTime()
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }             

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
            if ((radiobutton1 == true) || (radiobutton2 == true))
            {
                button2.Enabled = true;               
            }
            else {
                button2.Enabled = false;
            }
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label2.ForeColor = this.label1.ForeColor;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (radiobutton1 == true)
            {
                if (f4 == null)
                    f4 = new Form4();
                f4.fo = label4.Text;
                f4.Show();
                this.Hide();
            }
            else if (radiobutton2 == true) {
                if (f3 == null)
                    f3 = new Form3();
                f3.fo = label4.Text;
                f3.Show();
                this.Hide();
            }
                
        }
        private bool radiobutton1 = false;
        private bool radiobutton2 = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton1 = true;
            radiobutton2 = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton2 = true;
            radiobutton1 = false;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.MinimumSize = new Size(840, 640);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();

        }
    }
}

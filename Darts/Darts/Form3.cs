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
    public partial class Form3 : Form
    {

        //Title
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }
        Form2 f2;
        Form5 f5;
        Form6 f6;
        Form7 f7;
        Form9 f9;
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            b = true;
            c = false;
            g = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
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


        private void displayTime()
        {
            label1.Text = DateTime.Now.ToShortTimeString();
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
        private bool a = false;
        private bool b = false;
        private bool c = false;
        private bool g = false;

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
            if ((a == true) || (b == true) || (c == true) || (g == true))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void changeColor_Click_1(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label2.ForeColor = this.label1.ForeColor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            b = false;
            c = false;
            g = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if (f5 == null)
                    f5 = new Form5();
                f5.fo = label4.Text;
                f5.Show();
                this.Hide();
            }
            else if (b == true)
            {
                if (f6 == null)
                    f6 = new Form6();
                f6.fo = label4.Text;
                f6.Show();
                this.Hide();
            }
            else if (c == true)
            {
                if (f7 == null)
                    f7 = new Form7();
                f7.fo = label4.Text;
                f7.Show();
                this.Hide();
            }
            else if (g == true)
            {
                if (f9 == null)
                    f9 = new Form9();
                f9.fo = label4.Text;
                f9.Show();
                this.Hide();
            }
        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            b = false;
            c = true;
            g = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            b = false;
            c = false;
            g = true;
        }
        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2();
            f2.fo = label4.Text;
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
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

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;

            }
            Application.Exit();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Darts
{
    public partial class Form1 : Form
    {
        private bool button = false;
        Form2 f2;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void button1_Click(object sender, EventArgs e)
        {  
        }



        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public string fo
        {
            get { return label3.Text; }
            set { label3.Text = value; }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label2.ForeColor = this.label1.ForeColor;
            Color color = this.label2.ForeColor;

        }

        private void displayTime()
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (button == false)
            {
                button2.Enabled = false;
            }
            else {
                button2.Enabled = true;
            }
            if (bool1 == true) {
                GC.Collect();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sValue = textBox1.Text;
                       
            this.label3.Text = sValue.ToString();
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);

            
            string[] arrValues = sValue.Split(new char[] { ' ' });
            for (int i = 0; i < arrValues.Length; i++)
            {
                arrValues[i] = arrValues[i].ToString().Replace(arrValues[i].ToString(), "");
            }
            for (int o = 0; o < arrValues.Length; o++)
            {
                textBox1.Text = arrValues[o].ToString();
            }

            button = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private bool bool1 = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2();
            f2.fo = label3.Text;
            f2.Show();
            this.Hide();

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.MinimumSize = new Size(840, 640);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.CenterToScreen();
        }
        
    }
}

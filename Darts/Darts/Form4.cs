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
    public partial class Form4 : Form
    {
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private bool a = false;
        private bool b = false;
        private bool c = false;

        private void timer4_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
            if ((a == true) || (b == true) || (c == true))
            {
                button2.Enabled = true;
            }
            else
            {
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
        Form2 f2;
        Form11 f11;
        Form12 f12;
        Form13 f13;
        private void button2_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if (f11 == null)
                    f11 = new Form11();
                f11.fo = label4.Text;
                f11.Show();
                this.Hide();
            }
            else if (b == true)
            {
                if (f12 == null)
                    f12 = new Form12();
                f12.fo = label4.Text;
                f12.Show();
                this.Hide();
            }
            else if (c == true)
            {
                if (f13 == null)
                    f13 = new Form13();
                f13.fo = label4.Text;
                f13.Show();
                this.Hide();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = true;
            b = false;
            c = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            b = true;
            c = false;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = false;
            b = false;
            c = true;
            
        }

        

        private void Form4_Load_1(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.MinimumSize = new Size(840, 640);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2();
            f2.fo = label4.Text;
            f2.Show();
            this.Hide();
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

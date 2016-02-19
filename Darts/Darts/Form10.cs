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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

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

        private void timer10_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label1.Text = d.ToLongDateString();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label2.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label1.ForeColor = this.label2.ForeColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        Form9 f9;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f9 == null)
                f9 = new Form9();
            f9.fo = label4.Text;
            f9.Show();
            this.Hide();
        }
    }
}

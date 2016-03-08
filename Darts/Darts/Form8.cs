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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 0, 200, 200);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();

        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label2.ForeColor = this.label1.ForeColor;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }
        Form7 f7;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f7 == null)
                f7 = new Form7();
            f7.fo = label4.Text;
            f7.Show();
            this.Hide();
        }
    }
}

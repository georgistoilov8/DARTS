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
    public partial class Form_StartUP : Form
    {
        public Form_StartUP()
        {
            InitializeComponent();
        }

        private void Form_StartUP_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.MinimumSize = new Size(840, 640);
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            this.CenterToScreen();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        Form f1;

        private void button2_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
        }

        public void CloseAll()
        {
           Close();
        }
}
}

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
    public partial class Form12 : Form
    {
        Form3 f3;
        public static int count = 0; // can change because not const
        int[] numbers = new int[16];
        private int counter = 0;
        private int n = 0;
        private int i = 0;
        private int random;
        private bool isButtonClicked = false;
        private int arr_count = 0;
        public SortedList<int, int> perm = new SortedList<int, int>();
        Random rand = new Random();
        public Form12()
        {
            InitializeComponent();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label2.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label1.ForeColor = this.label2.ForeColor;
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();
            if (isButtonClicked == true)
            {
                count++;
                isButtonClicked = false;
            }
            if (textBox1.Text.Length > 0 && count < 16)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }
        Form4 f4;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f4 == null)
                f4 = new Form4();
            f4.fo = label4.Text;
            f4.Show();
            n = 0;
            i = 0;
            arr_count = 0;
            count = 0;
            this.Hide();
        }

        public IList<int> randomPermutation(int min, int max)
        {
            Random rand = new Random();
            perm = new SortedList<int, int>();
            for (int i = min; i <= max; i++)
            {
                perm.Add(rand.Next(), i);
            }
            foreach (var row in perm)
            {
                numbers[i] = row.Value;
                i++;
            }
            return perm.Values;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n == 0)
                randomPermutation(1, 16);

            random = numbers[arr_count];
            if (random == 1)
            {
                label10.Text = textBox1.Text;
            }
            else
            if (random == 2)
            {
                label11.Text = textBox1.Text;
            }
            else
            if (random == 3)
            {
                label12.Text = textBox1.Text;
            }
            else
            if (random == 4)
            {
                label13.Text = textBox1.Text;
            }
            else
            if (random == 5)
            {
                label14.Text = textBox1.Text;
            }
            else
            if (random == 6)
            {
                label15.Text = textBox1.Text;
            }
            else
            if (random == 7)
            {
                label16.Text = textBox1.Text;
            }
            else
            if (random == 8)
            {
                label17.Text = textBox1.Text;
            }
            if (random == 9)
            {
                label18.Text = textBox1.Text;
            }
            else
            if (random == 10)
            {
                label19.Text = textBox1.Text;
            }
            else
            if (random == 11)
            {
                label20.Text = textBox1.Text;
            }
            else
            if (random == 12)
            {
                label21.Text = textBox1.Text;
            }
            else
            if (random == 13)
            {
                label22.Text = textBox1.Text;
            }
            else if (random == 14)
            {
                label23.Text = textBox1.Text;
            }
            else
            if (random == 15)
            {
                label24.Text = textBox1.Text;
            }
            else
            if (random == 16)
            {
                label25.Text = textBox1.Text;
            }
            arr_count += 1;
            isButtonClicked = true;
            n++;
            counter++;



            string sValue = textBox1.Text;


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
        }
    }
}

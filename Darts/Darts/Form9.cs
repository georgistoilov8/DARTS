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
    public partial class Form9 : Form
    {
        public static int count = 0; // can change because not const
        int[] numbers = new int[64];
        private int counter = 0;
        private int n = 0;
        private int i = 0;
        private int random;
        private int arr_count = 0;
        public SortedList<int, int> perm = new SortedList<int, int>();
        Random rand = new Random();
        public Form9()
        {
            InitializeComponent();
        }
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }
        Form10 f10;

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isButtonClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (f10 == null)
                f10 = new Form10();
            f10.fo = label4.Text;
            f10.Show();
            this.Hide();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label1.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label2.ForeColor = this.label1.ForeColor;
        }

        private void timer9_Tick(object sender, EventArgs e)
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
            if (textBox1.Text.Length > 0 && count < 64)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void label1152_Click(object sender, EventArgs e)
        {

        }
        Form3 f3;
        private void button10_Click(object sender, EventArgs e)
        {
            if (f3 == null)
                f3 = new Form3();
            f3.fo = label4.Text;
            f3.Show();
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
                randomPermutation(1, 64);

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
            if (random == 17)
            {
                label26.Text = textBox1.Text;
            }
            else
            if (random == 18)
            {
                label27.Text = textBox1.Text;
            }
            else
            if (random == 19)
            {
                label28.Text = textBox1.Text;
            }
            else
            if (random == 20)
            {
                label29.Text = textBox1.Text;
            }
            else
            if (random == 21)
            {
                label30.Text = textBox1.Text;
            }
            else
            if (random == 22)
            {
                label31.Text = textBox1.Text;
            }
            else
            if (random == 23)
            {
                label32.Text = textBox1.Text;
            }
            else
            if (random == 24)
            {
                label33.Text = textBox1.Text;
            }
            if (random == 25)
            {
                label34.Text = textBox1.Text;
            }
            else
            if (random == 26)
            {
                label35.Text = textBox1.Text;
            }
            else
            if (random == 27)
            {
                label36.Text = textBox1.Text;
            }
            else
            if (random == 28)
            {
                label37.Text = textBox1.Text;
            }
            else
            if (random == 29)
            {
                label38.Text = textBox1.Text;
            }
            else if (random == 30)
            {
                label39.Text = textBox1.Text;
            }
            else
            if (random == 31)
            {
                label40.Text = textBox1.Text;
            }
            else
            if (random == 32)
            {
                label41.Text = textBox1.Text;
            }else
            if (random == 33)
            {
                label42.Text = textBox1.Text;
            }
            else
            if (random == 34)
            {
                label43.Text = textBox1.Text;
            }
            else
            if (random == 35)
            {
                label44.Text = textBox1.Text;
            }
            else
            if (random == 36)
            {
                label46.Text = textBox1.Text;
            }
            else
            if (random == 37)
            {
                label47.Text = textBox1.Text;
            }
            else
            if (random == 38)
            {
                label48.Text = textBox1.Text;
            }
            else
            if (random == 39)
            {
                label49.Text = textBox1.Text;
            }
            else
            if (random == 40)
            {
                label50.Text = textBox1.Text;
            }
            if (random == 41)
            {
                label51.Text = textBox1.Text;
            }
            else
            if (random == 42)
            {
                label52.Text = textBox1.Text;
            }
            else
            if (random == 43)
            {
                label53.Text = textBox1.Text;
            }
            else
            if (random == 44)
            {
                label54.Text = textBox1.Text;
            }
            else
            if (random == 45)
            {
                label55.Text = textBox1.Text;
            }
            else if (random == 46)
            {
                label56.Text = textBox1.Text;
            }
            else
            if (random == 47)
            {
                label57.Text = textBox1.Text;
            }
            else
            if (random == 48)
            {
                label58.Text = textBox1.Text;
            }
            if (random == 49)
            {
                label59.Text = textBox1.Text;
            }
            else
            if (random == 50)
            {
                label45.Text = textBox1.Text;
            }
            else
            if (random == 51)
            {
                label60.Text = textBox1.Text;
            }
            else
            if (random == 52)
            {
                label61.Text = textBox1.Text;
            }
            else
            if (random == 53)
            {
                label62.Text = textBox1.Text;
            }
            else
            if (random == 54)
            {
                label63.Text = textBox1.Text;
            }
            else
            if (random == 55)
            {
                label64.Text = textBox1.Text;
            }
            else
            if (random == 56)
            {
                label65.Text = textBox1.Text;
            }
            if (random == 57)
            {
                label66.Text = textBox1.Text;
            }
            else
            if (random == 58)
            {
                label67.Text = textBox1.Text;
            }
            else
            if (random == 59)
            {
                label68.Text = textBox1.Text;
            }
            else
            if (random == 60)
            {
                label69.Text = textBox1.Text;
            }
            else
            if (random == 61)
            {
                label70.Text = textBox1.Text;
            }
            else if (random == 62)
            {
                label71.Text = textBox1.Text;
            }
            else
            if (random == 63)
            {
                label72.Text = textBox1.Text;
            }
            else
            if (random == 63)
            {
                label73.Text = textBox1.Text;
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

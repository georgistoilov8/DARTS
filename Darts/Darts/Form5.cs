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
    public partial class Form5 : Form
    {
        Form3 f3;
        public static int count = 0; // can change because not const
        int[] numbers = new int[8];
        private int counter = 0;
        private int n = 0;
        private int i = 0;
        private int random;
        private int arr_count = 0;
        public SortedList<int, int> perm = new SortedList<int, int>();
        Random rand = new Random();

        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }

        public Form5()
        {
            InitializeComponent();
            if (f3 == null)
                f3 = new Form3();
        }
        
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isRefresh = false;
        private void changeColor_Click(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label2.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label1.ForeColor = this.label2.ForeColor;
        }
        private bool isButtonClicked = false;
        private void timer5_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToLongTimeString();
            DateTime d = DateTime.Now;
            label1.Text = d.ToLongDateString();
            if (isButtonClicked == true) {       
                count++;                 
                isButtonClicked = false;
            }
            if (textBox1.Text.Length > 0 && count < 8)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
                   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
                
        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
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
                randomPermutation(1, 8);         
            
            random = numbers[arr_count];
            if (random == 1)
            {
                label10.Text = textBox1.Text;
            }
            else if (random == 2)
            {
                label11.Text = textBox1.Text;
            }
            else if (random == 3)
            {
                label12.Text = textBox1.Text;
            }
            else
            if (random == 4)
            {
                label13.Text = textBox1.Text;              
            }
            if (random == 5)
            {
                label14.Text = textBox1.Text;
            }
            else if (random == 6)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isRefresh = true;
            if (isRefresh)
            {
                if (n1.Value == 3 && n2.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label18.Text = null;
                }else
                if (n1.Value == 3)
                {
                    label18.Text = label10.Text;
                }
                else if (n2.Value == 3)
                {
                    label18.Text = label11.Text;
                }
                else
                {
                    label18.Text = null;
                }

                if (n3.Value == 3 && n4.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label19.Text = null;
                }else
                if (n4.Value == 3)
                {
                    label19.Text = label12.Text;
                }
                else if (n3.Value == 3)
                {
                    label19.Text = label13.Text;
                }
                else
                {
                    label19.Text = null;
                }

                if (n5.Value == 3 && n6.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label20.Text = null;
                }else
                if (n6.Value == 3)
                {
                    label20.Text = label14.Text;
                }
                else if (n5.Value == 3)
                {
                    label20.Text = label15.Text;
                }
                else
                {
                    label20.Text = null;
                }

                if (n7.Value == 3 && n8.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label21.Text = null;
                }else
                if (n8.Value == 3)
                {
                    label21.Text = label16.Text;
                }
                else if (n7.Value == 3)
                {
                    label21.Text = label17.Text;
                }
                
                else
                {
                    label21.Text = null;
                }

                if (n10.Value == 3 && n9.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label22.Text = null;
                }else
                if (n9.Value == 3)
                {
                    label22.Text = label18.Text;
                }
                else if (n10.Value == 3)
                {
                    label22.Text = label19.Text;
                }
                else
                {
                    label22.Text = null;
                }

               if (n12.Value == 3 && n11.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label23.Text = null;
                }else
                if (n11.Value == 3)
                {
                    label23.Text = label20.Text;
                }
                else if (n12.Value == 3)
                {
                    label23.Text = label21.Text;
                }
                else
                {
                    label23.Text = null;
                }

                if (n14.Value == 3 && n13.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label24.Text = null;
                }else
                if (n13.Value == 3)
                {
                    label24.Text = label22.Text;
                }
                else if (n14.Value == 3)
                {
                    label24.Text = label23.Text;
                }
                else
                {
                    label24.Text = null;
                }
            }
            
            isRefresh = false;
        }
    }
}

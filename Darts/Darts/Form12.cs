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
            if(n29.Value == 3 || n30.Value == 3)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }
        Form4 f4;
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

        
        private bool isRefresh = false;
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (label10.Text == "  ")
            {
                label10.Text = "-";
            }
            if (label11.Text == "  ")
            {
                label11.Text = "-";
            }
            if (label12.Text == "  ")
            {
                label12.Text = "-";
            }
            if (label13.Text == "  ")
            {
                label13.Text = "-";
            }
            if (label14.Text == "  ")
            {
                label14.Text = "-";
            }
            if (label15.Text == "  ")
            {
                label15.Text = "-";
            }
            if (label16.Text == "  ")
            {
                label16.Text = "-";
            }
            if (label17.Text == "  ")
            {
                label17.Text = "-";
            }
            if (label25.Text == "  ")
            {
                label25.Text = "-";
            }
            if (label26.Text == "  ")
            {
                label26.Text = "-";
            }
            if (label27.Text == "  ")
            {
                label27.Text = "-";
            }
            if (label28.Text == "  ")
            {
                label28.Text = "-";
            }
            if (label29.Text == "  ")
            {
                label29.Text = "-";
            }
            if (label30.Text == "  ")
            {
                label30.Text = "-";
            }
            if (label31.Text == "  ")
            {
                label31.Text = "-";
            }
            if (label32.Text == "  ")
            {
                label32.Text = "-";
            }
            count = 16;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
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
                label25.Text = textBox1.Text;
            }
            else
            if (random == 10)
            {
                label26.Text = textBox1.Text;
            }
            else
            if (random == 11)
            {
                label27.Text = textBox1.Text;
            }
            else
            if (random == 12)
            {
                label28.Text = textBox1.Text;
            }
            else
            if (random == 13)
            {
                label29.Text = textBox1.Text;
            }
            else if (random == 14)
            {
                label30.Text = textBox1.Text;
            }
            else
            if (random == 15)
            {
                label31.Text = textBox1.Text;
            }
            else
            if (random == 16)
            {
                label32.Text = textBox1.Text;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            isRefresh = true;
            if (isRefresh)
            {
                if (label10.Text == "-" && label11.Text != "-")
                {
                    label18.Text = label11.Text;
                    n2.Value = 3;
                }
                if (label11.Text == "-" && label10.Text != "-")
                {
                    label18.Text = label10.Text;
                    n1.Value = 3;
                }
                if (label11.Text == "-" && label10.Text == "-")
                {
                    label18.Text = "-";
                    n1.Value = 3;
                }


                if (label12.Text == "-" && label13.Text != "-")
                {
                    label19.Text = label13.Text;
                    n3.Value = 3;
                }
                if (label13.Text == "-" && label12.Text != "-")
                {
                    label19.Text = label12.Text;
                    n4.Value = 3;
                }
                if (label12.Text == "-" && label13.Text == "-")
                {
                    label19.Text = "-";
                    n3.Value = 3;
                }


                if (label14.Text == "-" && label15.Text != "-")
                {
                    label20.Text = label15.Text;
                    n5.Value = 3;
                }
                else if (label15.Text == "-" && label14.Text != "-")
                {
                    label20.Text = label14.Text;
                    n6.Value = 3;
                }
                else if (label15.Text == "-" && label14.Text == "-")
                {
                    label20.Text = "-";
                    n6.Value = 3;
                }


                if (label16.Text == "-" && label17.Text != "-")
                {
                    label21.Text = label17.Text;
                    n7.Value = 3;
                }
                else if (label17.Text == "-" && label16.Text != "-")
                {
                    label21.Text = label16.Text;
                    n8.Value = 3;
                }
                else if (label17.Text == "-" && label16.Text == "-")
                {
                    label21.Text = "-";
                    n8.Value = 3;
                }


                if (label18.Text == "-" && label19.Text != "-")
                {
                    label22.Text = label19.Text;
                    n10.Value = 3;
                }
                else if (label19.Text == "-" && label18.Text != "-")
                {
                    label22.Text = label18.Text;
                    n9.Value = 3;
                }
                else if (label19.Text == "-" && label18.Text == "-")
                {
                    label22.Text = "-";
                    n9.Value = 3;
                }


                if (label20.Text == "-" && label21.Text != "-")
                {
                    label23.Text = label21.Text;
                    n12.Value = 3;
                }
                else if (label21.Text == "-" && label20.Text != "-")
                {
                    label23.Text = label20.Text;
                    n11.Value = 3;
                }
                else if (label20.Text == "-" && label21.Text == "-")
                {
                    label23.Text = "-";
                    n11.Value = 3;
                }


                if (label22.Text == "-" && label23.Text != "-")
                {
                    label24.Text = label23.Text;
                    n14.Value = 3;
                }
                else if (label23.Text == "-" && label22.Text != "-")
                {
                    label24.Text = label22.Text;
                    n13.Value = 3;
                }
                else if (label23.Text == "-" && label22.Text == "-")
                {
                    label24.Text = "-";
                    n13.Value = 3;
                }

                if (n1.Value == 3 && n2.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label18.Text = null;
                }
                else
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
                }
                else
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
                }
                else
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
                }
                else
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
                }
                else
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
                }
                else
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
                }
                else
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


                if (label25.Text == "-" && label26.Text != "-")
                {
                    label33.Text = label26.Text;
                    n16.Value = 3;
                }
                if (label26.Text == "-" && label25.Text != "-")
                {
                    label33.Text = label25.Text;
                    n15.Value = 3;
                }
                if (label25.Text == "-" && label26.Text == "-")
                {
                    label33.Text = "-";
                    n15.Value = 3;
                }


                if (label27.Text == "-" && label28.Text != "-")
                {
                    label34.Text = label28.Text;
                    n18.Value = 3;
                }
                if (label28.Text == "-" && label27.Text != "-")
                {
                    label34.Text = label27.Text;
                    n17.Value = 3;
                }
                if (label28.Text == "-" && label27.Text == "-")
                {
                    label34.Text = "-";
                    n17.Value = 3;
                }


                if (label29.Text == "-" && label30.Text != "-")
                {
                    label35.Text = label30.Text;
                    n20.Value = 3;
                }
                else if (label30.Text == "-" && label29.Text != "-")
                {
                    label35.Text = label29.Text;
                    n19.Value = 3;
                }
                else if (label29.Text == "-" && label30.Text == "-")
                {
                    label35.Text = "-";
                    n19.Value = 3;
                }


                if (label31.Text == "-" && label32.Text != "-")
                {
                    label36.Text = label32.Text;
                    n22.Value = 3;
                }
                else if (label32.Text == "-" && label31.Text != "-")
                {
                    label36.Text = label31.Text;
                    n21.Value = 3;
                }
                else if (label31.Text == "-" && label32.Text == "-")
                {
                    label36.Text = "-";
                    n21.Value = 3;
                }


                if (label33.Text == "-" && label34.Text != "-")
                {
                    label37.Text = label34.Text;
                    n24.Value = 3;
                }
                else if (label34.Text == "-" && label33.Text != "-")
                {
                    label37.Text = label33.Text;
                    n23.Value = 3;
                }
                else if (label34.Text == "-" && label33.Text == "-")
                {
                    label37.Text = "-";
                    n23.Value = 3;
                }


                if (label35.Text == "-" && label36.Text != "-")
                {
                    label38.Text = label36.Text;
                    n26.Value = 3;
                }
                else if (label36.Text == "-" && label35.Text != "-")
                {
                    label38.Text = label35.Text;
                    n25.Value = 3;
                }
                else if (label35.Text == "-" && label36.Text == "-")
                {
                    label38.Text = "-";
                    n25.Value = 3;
                }


                if (label37.Text == "-" && label38.Text != "-")
                {
                    label39.Text = label38.Text;
                    n28.Value = 3;
                }
                else if (label38.Text == "-" && label37.Text != "-")
                {
                    label39.Text = label37.Text;
                    n27.Value = 3;
                }
                else if (label37.Text == "-" && label38.Text == "-")
                {
                    label39.Text = "-";
                    n27.Value = 3;
                }

                if (n15.Value == 3 && n16.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label33.Text = null;
                }
                else
                if (n15.Value == 3)
                {
                    label33.Text = label25.Text;
                }
                else if (n16.Value == 3)
                {
                    label33.Text = label26.Text;
                }
                else
                {
                    label33.Text = null;
                }

                if (n17.Value == 3 && n18.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label34.Text = null;
                }
                else
                if (n17.Value == 3)
                {
                    label34.Text = label27.Text;
                }
                else if (n18.Value == 3)
                {
                    label34.Text = label28.Text;
                }
                else
                {
                    label34.Text = null;
                }

                if (n19.Value == 3 && n20.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label35.Text = null;
                }
                else
                if (n19.Value == 3)
                {
                    label35.Text = label29.Text;
                }
                else if (n20.Value == 3)
                {
                    label35.Text = label30.Text;
                }
                else
                {
                    label35.Text = null;
                }

                if (n21.Value == 3 && n22.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label36.Text = null;
                }
                else
                if (n21.Value == 3)
                {
                    label36.Text = label31.Text;
                }
                else if (n22.Value == 3)
                {
                    label36.Text = label32.Text;
                }

                else
                {
                    label36.Text = null;
                }

                if (n23.Value == 3 && n24.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label37.Text = null;
                }
                else
                if (n23.Value == 3)
                {
                    label37.Text = label33.Text;
                }
                else if (n24.Value == 3)
                {
                    label37.Text = label34.Text;
                }
                else
                {
                    label37.Text = null;
                }

                if (n25.Value == 3 && n26.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label38.Text = null;
                }
                else
                 if (n25.Value == 3)
                {
                    label38.Text = label35.Text;
                }
                else if (n26.Value == 3)
                {
                    label38.Text = label36.Text;
                }
                else
                {
                    label38.Text = null;
                }

                if (n27.Value == 3 && n28.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label39.Text = null;
                }
                else
                if (n27.Value == 3)
                {
                    label39.Text = label37.Text;
                }
                else if (n28.Value == 3)
                {
                    label39.Text = label38.Text;
                }
                else
                {
                    label39.Text = null;
                }
            }

            isRefresh = false;
        }

        private void changeColor_Click_1(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            this.label2.ForeColor = Color.FromArgb(randomColor.Next(0, 256),
                randomColor.Next(0, 256), randomColor.Next(0, 256));
            this.label1.ForeColor = this.label2.ForeColor;
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

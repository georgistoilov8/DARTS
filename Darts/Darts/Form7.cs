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
    public partial class Form7 : Form
    {
        Form3 f3;
        public static int count = 0; // can change because not const
        int[] numbers = new int[32];
        private int counter = 0;
        private int n = 0;
        private int i = 0;
        private int random;
        private int arr_count = 0;
        public SortedList<int, int> perm = new SortedList<int, int>();
        Random rand = new Random();
        public Form7()
        {
            InitializeComponent();
        }
        Form8 f8;
        public string fo
        {
            get { return label4.Text; }
            set { label4.Text = value; }

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f8 == null)
                f8 = new Form8();
            f8.fo = label4.Text;
            f8.Show();
            this.Hide();
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
        private bool isButtonClicked = false;

        private void timer7_Tick(object sender, EventArgs e)
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
            if (textBox1.Text.Length > 0 && count < 32)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private bool isRefresh = false;
        private void button5_Click(object sender, EventArgs e)
        {
            isRefresh = true;
            if (isRefresh)
            {
                if (label10.Text == "-" && label11.Text != "-")
                {
                    label26.Text = label11.Text;
                    n2.Value = 3;
                }
                if (label11.Text == "-" && label10.Text != "-")
                {
                    label26.Text = label10.Text;
                    n1.Value = 3;
                }
                if (label11.Text == "-" && label10.Text == "-")
                {
                    label26.Text = "-";
                    n1.Value = 3;
                }


                if (label12.Text == "-" && label13.Text != "-")
                {
                    label27.Text = label13.Text;
                    n3.Value = 3;
                }
                if (label13.Text == "-" && label12.Text != "-")
                {
                    label27.Text = label12.Text;
                    n4.Value = 3;
                }
                if (label12.Text == "-" && label13.Text == "-")
                {
                    label27.Text = "-";
                    n3.Value = 3;
                }


                if (label14.Text == "-" && label15.Text != "-")
                {
                    label28.Text = label15.Text;
                    n5.Value = 3;
                }
                else if (label15.Text == "-" && label14.Text != "-")
                {
                    label28.Text = label14.Text;
                    n6.Value = 3;
                }
                else if (label15.Text == "-" && label14.Text == "-")
                {
                    label28.Text = "-";
                    n6.Value = 3;
                }


                if (label16.Text == "-" && label17.Text != "-")
                {
                    label29.Text = label17.Text;
                    n7.Value = 3;
                }
                else if (label17.Text == "-" && label16.Text != "-")
                {
                    label29.Text = label16.Text;
                    n8.Value = 3;
                }
                else if (label17.Text == "-" && label16.Text == "-")
                {
                    label29.Text = "-";
                    n8.Value = 3;
                }


                if (label18.Text == "-" && label19.Text != "-")
                {
                    label30.Text = label19.Text;
                    n10.Value = 3;
                }
                else if (label19.Text == "-" && label18.Text != "-")
                {
                    label30.Text = label18.Text;
                    n9.Value = 3;
                }
                else if (label19.Text == "-" && label18.Text == "-")
                {
                    label30.Text = "-";
                    n9.Value = 3;
                }


                if (label20.Text == "-" && label21.Text != "-")
                {
                    label31.Text = label21.Text;
                    n12.Value = 3;
                }
                else if (label21.Text == "-" && label20.Text != "-")
                {
                    label31.Text = label20.Text;
                    n11.Value = 3;
                }
                else if (label20.Text == "-" && label21.Text == "-")
                {
                    label31.Text = "-";
                    n11.Value = 3;
                }


                if (label22.Text == "-" && label23.Text != "-")
                {
                    label32.Text = label23.Text;
                    n14.Value = 3;
                }
                else if (label23.Text == "-" && label22.Text != "-")
                {
                    label32.Text = label22.Text;
                    n13.Value = 3;
                }
                else if (label23.Text == "-" && label22.Text == "-")
                {
                    label32.Text = "-";
                    n13.Value = 3;
                }

                if (label24.Text == "-" && label25.Text != "-")
                {
                    label33.Text = label25.Text;
                    n16.Value = 3;
                }
                if (label25.Text == "-" && label24.Text != "-")
                {
                    label33.Text = label24.Text;
                    n15.Value = 3;
                }
                if (label25.Text == "-" && label24.Text == "-")
                {
                    label33.Text = "-";
                    n15.Value = 3;
                }


                if (label27.Text == "-" && label26.Text != "-")
                {
                    label34.Text = label26.Text;
                    n18.Value = 3;
                }
                if (label26.Text == "-" && label27.Text != "-")
                {
                    label34.Text = label27.Text;
                    n17.Value = 3;
                }
                if (label26.Text == "-" && label27.Text == "-")
                {
                    label34.Text = "-";
                    n17.Value = 3;
                }


                if (label29.Text == "-" && label28.Text != "-")
                {
                    label35.Text = label28.Text;
                    n20.Value = 3;
                }
                else if (label28.Text == "-" && label29.Text != "-")
                {
                    label35.Text = label29.Text;
                    n19.Value = 3;
                }
                else if (label29.Text == "-" && label28.Text == "-")
                {
                    label35.Text = "-";
                    n19.Value = 3;
                }


                if (label31.Text == "-" && label30.Text != "-")
                {
                    label36.Text = label30.Text;
                    n22.Value = 3;
                }
                else if (label30.Text == "-" && label31.Text != "-")
                {
                    label36.Text = label31.Text;
                    n21.Value = 3;
                }
                else if (label31.Text == "-" && label30.Text == "-")
                {
                    label36.Text = "-";
                    n21.Value = 3;
                }

                if (label33.Text == "-" && label32.Text != "-")
                {
                    label37.Text = label32.Text;
                    n23.Value = 3;
                }
                else if (label32.Text == "-" && label33.Text != "-")
                {
                    label37.Text = label33.Text;
                    n24.Value = 3;
                }
                else if (label33.Text == "-" && label32.Text == "-")
                {
                    label37.Text = "-";
                    n24.Value = 3;
                }

                //............................................................................................................
                // Start from here

                if (n1.Value == 3 && n2.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label26.Text = null;
                }
                else
                if (n1.Value == 3)
                {
                    label26.Text = label10.Text;
                }
                else if (n2.Value == 3)
                {
                    label26.Text = label11.Text;
                }
                else
                {
                    label26.Text = null;
                }

                if (n3.Value == 3 && n4.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label27.Text = null;
                }
                else
                if (n4.Value == 3)
                {
                    label27.Text = label12.Text;
                }
                else if (n3.Value == 3)
                {
                    label27.Text = label13.Text;
                }
                else
                {
                    label27.Text = null;
                }

                if (n5.Value == 3 && n6.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label28.Text = null;
                }
                else
                if (n6.Value == 3)
                {
                    label28.Text = label14.Text;
                }
                else if (n5.Value == 3)
                {
                    label28.Text = label15.Text;
                }
                else
                {
                    label28.Text = null;
                }

                if (n7.Value == 3 && n8.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label29.Text = null;
                }
                else
                if (n8.Value == 3)
                {
                    label29.Text = label16.Text;
                }
                else if (n7.Value == 3)
                {
                    label29.Text = label17.Text;
                }

                else
                {
                    label29.Text = null;
                }

                if (n10.Value == 3 && n9.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label30.Text = null;
                }
                else
                if (n9.Value == 3)
                {
                    label30.Text = label18.Text;
                }
                else if (n10.Value == 3)
                {
                    label30.Text = label19.Text;
                }
                else
                {
                    label30.Text = null;
                }

                if (n12.Value == 3 && n11.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label31.Text = null;
                }
                else
                 if (n11.Value == 3)
                {
                    label31.Text = label20.Text;
                }
                else if (n12.Value == 3)
                {
                    label31.Text = label21.Text;
                }
                else
                {
                    label31.Text = null;
                }

                if (n14.Value == 3 && n13.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label32.Text = null;
                }
                else
                if (n13.Value == 3)
                {
                    label32.Text = label22.Text;
                }
                else if (n14.Value == 3)
                {
                    label32.Text = label23.Text;
                }
                else
                {
                    label32.Text = null;
                }

                if (n16.Value == 3 && n15.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label33.Text = null;
                }
                else
                if (n15.Value == 3)
                {
                    label33.Text = label24.Text;
                }
                else if (n16.Value == 3)
                {
                    label33.Text = label25.Text;
                }
                else
                {
                    label33.Text = null;
                }

                if (n18.Value == 3 && n17.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label34.Text = null;
                }
                else
                if (n17.Value == 3)
                {
                    label34.Text = label26.Text;
                }
                else if (n18.Value == 3)
                {
                    label34.Text = label27.Text;
                }
                else
                {
                    label34.Text = null;
                }

                if (n20.Value == 3 && n19.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label35.Text = null;
                }
                else
                if (n19.Value == 3)
                {
                    label35.Text = label28.Text;
                }
                else if (n20.Value == 3)
                {
                    label35.Text = label29.Text;
                }
                else
                {
                    label35.Text = null;
                }

                if (n22.Value == 3 && n21.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label36.Text = null;
                }
                else
                if (n21.Value == 3)
                {
                    label36.Text = label30.Text;
                }
                else if (n22.Value == 3)
                {
                    label36.Text = label31.Text;
                }
                else
                {
                    label36.Text = null;
                }

                if (n24.Value == 3 && n23.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label37.Text = null;
                }
                else
                if (n23.Value == 3)
                {
                    label37.Text = label32.Text;
                }
                else if (n24.Value == 3)
                {
                    label37.Text = label33.Text;
                }
                else
                {
                    label37.Text = null;
                }

                //Right Side

                if (label38.Text == "-" && label39.Text != "-")
                {
                    label54.Text = label39.Text;
                    n30.Value = 3;
                }
                if (label39.Text == "-" && label38.Text != "-")
                {
                    label54.Text = label38.Text;
                    n29.Value = 3;
                }
                if (label39.Text == "-" && label38.Text == "-")
                {
                    label54.Text = "-";
                    n29.Value = 3;
                }


                if (label40.Text == "-" && label41.Text != "-")
                {
                    label55.Text = label41.Text;
                    n32.Value = 3;
                }
                if (label41.Text == "-" && label40.Text != "-")
                {
                    label55.Text = label40.Text;
                    n31.Value = 3;
                }
                if (label40.Text == "-" && label41.Text == "-")
                {
                    label55.Text = "-";
                    n31.Value = 3;
                }


                if (label42.Text == "-" && label43.Text != "-")
                {
                    label56.Text = label43.Text;
                    n34.Value = 3;
                }
                else if (label43.Text == "-" && label42.Text != "-")
                {
                    label56.Text = label42.Text;
                    n33.Value = 3;
                }
                else if (label43.Text == "-" && label42.Text == "-")
                {
                    label56.Text = "-";
                    n33.Value = 3;
                }


                if (label44.Text == "-" && label45.Text != "-")
                {
                    label57.Text = label45.Text;
                    n36.Value = 3;
                }
                else if (label45.Text == "-" && label44.Text != "-")
                {
                    label57.Text = label44.Text;
                    n35.Value = 3;
                }
                else if (label44.Text == "-" && label45.Text == "-")
                {
                    label57.Text = "-";
                    n35.Value = 3;
                }


                if (label46.Text == "-" && label47.Text != "-")
                {
                    label58.Text = label47.Text;
                    n38.Value = 3;
                }
                else if (label47.Text == "-" && label46.Text != "-")
                {
                    label58.Text = label46.Text;
                    n37.Value = 3;
                }
                else if (label47.Text == "-" && label46.Text == "-")
                {
                    label58.Text = "-";
                    n37.Value = 3;
                }


                if (label48.Text == "-" && label49.Text != "-")
                {
                    label59.Text = label49.Text;
                    n40.Value = 3;
                }
                else if (label49.Text == "-" && label48.Text != "-")
                {
                    label59.Text = label48.Text;
                    n39.Value = 3;
                }
                else if (label49.Text == "-" && label48.Text == "-")
                {
                    label59.Text = "-";
                    n39.Value = 3;
                }


                if (label50.Text == "-" && label51.Text != "-")
                {
                    label60.Text = label51.Text;
                    n42.Value = 3;
                }
                else if (label51.Text == "-" && label50.Text != "-")
                {
                    label60.Text = label50.Text;
                    n41.Value = 3;
                }
                else if (label51.Text == "-" && label50.Text == "-")
                {
                    label60.Text = "-";
                    n41.Value = 3;
                }

                if (label52.Text == "-" && label53.Text != "-")
                {
                    label61.Text = label53.Text;
                    n44.Value = 3;
                }
                if (label53.Text == "-" && label52.Text != "-")
                {
                    label61.Text = label52.Text;
                    n43.Value = 3;
                }
                if (label53.Text == "-" && label52.Text == "-")
                {
                    label61.Text = "-";
                    n43.Value = 3;
                }


                if (label54.Text == "-" && label55.Text != "-")
                {
                    label62.Text = label55.Text;
                    n46.Value = 3;
                }
                if (label55.Text == "-" && label54.Text != "-")
                {
                    label62.Text = label54.Text;
                    n45.Value = 3;
                }
                if (label55.Text == "-" && label54.Text == "-")
                {
                    label62.Text = "-";
                    n45.Value = 3;
                }


                if (label56.Text == "-" && label57.Text != "-")
                {
                    label63.Text = label57.Text;
                    n48.Value = 3;
                }
                else if (label57.Text == "-" && label56.Text != "-")
                {
                    label63.Text = label56.Text;
                    n47.Value = 3;
                }
                else if (label57.Text == "-" && label56.Text == "-")
                {
                    label63.Text = "-";
                    n47.Value = 3;
                }


                if (label58.Text == "-" && label59.Text != "-")
                {
                    label64.Text = label59.Text;
                    n50.Value = 3;
                }
                else if (label59.Text == "-" && label58.Text != "-")
                {
                    label64.Text = label58.Text;
                    n49.Value = 3;
                }
                else if (label59.Text == "-" && label58.Text == "-")
                {
                    label64.Text = "-";
                    n49.Value = 3;
                }

                if (label60.Text == "-" && label61.Text != "-")
                {
                    label65.Text = label61.Text;
                    n52.Value = 3;
                }
                else if (label61.Text == "-" && label60.Text != "-")
                {
                    label65.Text = label60.Text;
                    n51.Value = 3;
                }
                else if (label61.Text == "-" && label60.Text == "-")
                {
                    label64.Text = "-";
                    n51.Value = 3;
                }

                //............................................................................................................
                // Start from here

                if (n29.Value == 3 && n30.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label54.Text = null;
                }
                else
                if (n29.Value == 3)
                {
                    label54.Text = label38.Text;
                }
                else if (n30.Value == 3)
                {
                    label54.Text = label39.Text;
                }
                else
                {
                    label54.Text = null;
                }

                if (n31.Value == 3 && n32.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label55.Text = null;
                }
                else
                if (n31.Value == 3)
                {
                    label55.Text = label40.Text;
                }
                else if (n32.Value == 3)
                {
                    label55.Text = label41.Text;
                }
                else
                {
                    label55.Text = null;
                }

                if (n33.Value == 3 && n34.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label56.Text = null;
                }
                else
                if (n33.Value == 3)
                {
                    label56.Text = label42.Text;
                }
                else if (n34.Value == 3)
                {
                    label56.Text = label43.Text;
                }
                else
                {
                    label56.Text = null;
                }

                if (n35.Value == 3 && n36.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label57.Text = null;
                }
                else
                if (n35.Value == 3)
                {
                    label57.Text = label44.Text;
                }
                else if (n36.Value == 3)
                {
                    label57.Text = label45.Text;
                }
                else
                {
                    label57.Text = null;
                }

                if (n37.Value == 3 && n38.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label58.Text = null;
                }
                else
                if (n37.Value == 3)
                {
                    label58.Text = label46.Text;
                }
                else if (n38.Value == 3)
                {
                    label58.Text = label47.Text;
                }
                else
                {
                    label58.Text = null;
                }

                if (n39.Value == 3 && n40.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label59.Text = null;
                }
                else
                 if (n39.Value == 3)
                {
                    label59.Text = label48.Text;
                }
                else if (n40.Value == 3)
                {
                    label59.Text = label49.Text;
                }
                else
                {
                    label59.Text = null;
                }

                if (n41.Value == 3 && n42.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label60.Text = null;
                }
                else
                if (n41.Value == 3)
                {
                    label60.Text = label50.Text;
                }
                else if (n42.Value == 3)
                {
                    label60.Text = label51.Text;
                }
                else
                {
                    label60.Text = null;
                }

                if (n43.Value == 3 && n44.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label61.Text = null;
                }
                else
                if (n43.Value == 3)
                {
                    label61.Text = label52.Text;
                }
                else if (n44.Value == 3)
                {
                    label61.Text = label53.Text;
                }
                else
                {
                    label61.Text = null;
                }

                if (n45.Value == 3 && n46.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label62.Text = null;
                }
                else
                if (n45.Value == 3)
                {
                    label62.Text = label54.Text;
                }
                else if (n46.Value == 3)
                {
                    label62.Text = label55.Text;
                }
                else
                {
                    label62.Text = null;
                }

                if (n47.Value == 3 && n48.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label63.Text = null;
                }
                else
                if (n47.Value == 3)
                {
                    label63.Text = label56.Text;
                }
                else if (n48.Value == 3)
                {
                    label63.Text = label57.Text;
                }
                else
                {
                    label63.Text = null;
                }

                if (n49.Value == 3 && n50.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label64.Text = null;
                }
                else
                if (n49.Value == 3)
                {
                    label64.Text = label58.Text;
                }
                else if (n50.Value == 3)
                {
                    label64.Text = label59.Text;
                }
                else
                {
                    label64.Text = null;
                }

                if (n51.Value == 3 && n52.Value == 3)
                {
                    MessageBox.Show("You give same numbers");
                    label65.Text = null;
                }
                else
                if (n51.Value == 3)
                {
                    label65.Text = label60.Text;
                }
                else if (n52.Value == 3)
                {
                    label65.Text = label61.Text;
                }
                else
                {
                    label65.Text = null;
                }

            }

            isRefresh = false;
        }

        private void button3_Click(object sender, EventArgs e)
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
            if (label18.Text == "  ")
            {
                label18.Text = "-";
            }
            if (label19.Text == "  ")
            {
                label19.Text = "-";
            }
            if (label20.Text == "  ")
            {
                label20.Text = "-";
            }
            if (label21.Text == "  ")
            {
                label21.Text = "-";
            }
            if (label22.Text == "  ")
            {
                label22.Text = "-";
            }
            if (label23.Text == "  ")
            {
                label23.Text = "-";
            }
            if (label24.Text == "  ")
            {
                label24.Text = "-";
            }
            if (label38.Text == "  ")
            {
                label38.Text = "-";
            }
            if (label39.Text == "  ")
            {
                label39.Text = "-";
            }
            if (label40.Text == "  ")
            {
                label40.Text = "-";
            }
            if (label41.Text == "  ")
            {
                label41.Text = "-";
            }
            if (label42.Text == "  ")
            {
                label42.Text = "-";
            }
            if (label43.Text == "  ")
            {
                label43.Text = "-";
            }
            if (label44.Text == "  ")
            {
                label44.Text = "-";
            }
            if (label45.Text == "  ")
            {
                label45.Text = "-";
            }
            if (label46.Text == "  ")
            {
                label46.Text = "-";
            }
            if (label47.Text == "  ")
            {
                label47.Text = "-";
            }
            if (label48.Text == "  ")
            {
                label48.Text = "-";
            }
            if (label49.Text == "  ")
            {
                label49.Text = "-";
            }
            if (label50.Text == "  ")
            {
                label50.Text = "-";
            }
            if (label51.Text == "  ")
            {
                label51.Text = "-";
            }
            if (label52.Text == "  ")
            {
                label52.Text = "-";
            }
            if (label53.Text == "  ")
            {
                label53.Text = "-";
            }
            count = 32;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (n == 0)
                randomPermutation(1, 32);

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
            else
            if (random == 17)
            {
                label38.Text = textBox1.Text;
            }
            else
           if (random == 18)
            {
                label39.Text = textBox1.Text;
            }
            else
           if (random == 19)
            {
                label40.Text = textBox1.Text;
            }
            else
           if (random == 20)
            {
                label41.Text = textBox1.Text;
            }
            else
           if (random == 21)
            {
                label42.Text = textBox1.Text;
            }
            else
           if (random == 22)
            {
                label43.Text = textBox1.Text;
            }
            else
           if (random == 23)
            {
                label44.Text = textBox1.Text;
            }
            else
           if (random == 24)
            {
                label45.Text = textBox1.Text;
            }
            if (random == 25)
            {
                label46.Text = textBox1.Text;
            }
            else
            if (random == 26)
            {
                label47.Text = textBox1.Text;
            }
            else
            if (random == 27)
            {
                label48.Text = textBox1.Text;
            }
            else
            if (random == 28)
            {
                label49.Text = textBox1.Text;
            }
            else
            if (random == 29)
            {
                label50.Text = textBox1.Text;
            }
            else if (random == 30)
            {
                label51.Text = textBox1.Text;
            }
            else
            if (random == 31)
            {
                label52.Text = textBox1.Text;
            }
            else
            if (random == 32)
            {
                label53.Text = textBox1.Text;
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

        private void button2_Click_1(object sender, EventArgs e)
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_System
{
    public partial class Signup : Form
    {
        public static string fname;
        public static string lname;
        public static string email;
        public static string mobnum;
        public static string nic;
        public static string dob;
        public static string address;
        public static string gender;

        public Signup()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            lname = textBox2.Text;
            email = textBox3.Text;
            mobnum = textBox4.Text;
            nic = textBox5.Text;
            dob = dateTimePicker1.Value.ToShortDateString();
            address = textBox6.Text;

            Confirm f2 = new Confirm();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            //No need to do set any reset thing for DOB
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
        }
    }
}

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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            label9.Text = Signup.fname;
            label10.Text = Signup.lname;
            label11.Text = Signup.email;
            label12.Text = Signup.mobnum;
            label13.Text = Signup.nic;
            label14.Text = Signup.dob;
            label16.Text = Signup.address;
            label15.Text = Signup.gender;

            }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have registered successfully.", "Confimation",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Order od = new Order();
            od.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            this.Hide();
            sp.Show();
        }
    }
}

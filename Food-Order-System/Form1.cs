﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            this.Hide();

            if (username == "Admin" && password == "admin@123")
            {
                Signup f1 = new Signup();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Login Failed" 
                    , MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " "; 
        }
    }
}

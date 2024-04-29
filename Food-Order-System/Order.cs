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
    public partial class Order : Form
    {
        DataTable fd = new DataTable();
        public static double delivery = 450.00;
        public static double price, total;
        public static string foodname;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            foodDetails();
            comboBox1.DataSource = fd;
            comboBox1.DisplayMember = "Food - Name";
        }
        public void foodDetails()
        {
            fd.Columns.Add("Food - ID" , typeof(int));
            fd.Columns.Add("Food - Name");
            fd.Columns.Add("Price" , typeof(double));

            fd.Rows.Add(1, "Biriyani", 630.00);
            fd.Rows.Add(2, "Pasta", 550.00);
            fd.Rows.Add(3, "Noodles", 470.00);
            fd.Rows.Add(4, "Rice&Curry", 300.00);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = delivery.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total = price + delivery;
            label3.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Receipt rp = new Receipt();
            this.Hide();
            rp.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodname = fd.Rows[comboBox1.SelectedIndex]["Food - Name"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = fd.Rows[comboBox1.SelectedIndex]["Price"].ToString();
            price = Convert.ToDouble(label1.Text);
        }
    }
}

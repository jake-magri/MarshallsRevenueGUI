using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class Form1 : Form
    {
        // Jake Magri | SID: 801193292

        public Form1()
        {
            InitializeComponent();
        }

        // list of objects used
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // functional button
        private void button1_Click(object sender, EventArgs e)
        {
            // declare variables
            const double int_price = 500;
            const double ext_price = 750;

            double int_revenue, ext_revenue;
            double total_revenue;

            double int_final_price = int_price;
            double ext_final_price = ext_price;

            int int_num, ext_num;
            int month;

            bool comparison;

            // input number of months and murals from textBox then convert them to real numbers
            month = Convert.ToInt32(textBox1.Text);
            int_num = Convert.ToInt32(textBox2.Text);
            ext_num = Convert.ToInt32(textBox3.Text);

            // conditions of sale for certain months using if
            if (month == 12 || month == 1 || month == 2)
            {
                ext_num = 0;
            }
            if (month == 4 || month == 5 || month == 9 || month == 10)
            {
                ext_final_price = 699;
            }
            if(month == 7 || month == 8)
            {
                int_final_price = 450;
            }


            // find revenues of interior and exterior murals
            int_revenue = int_num * int_final_price;
            ext_revenue = ext_num * ext_final_price;

            total_revenue = int_revenue + ext_revenue;
            comparison = int_num > ext_num;

            

            // currency conversion
            string int_price_conversion, int_rev_conversion, ext_price_conversion, ext_rev_conversion, tot_rev_conversion;

            int_price_conversion = int_final_price.ToString("C2");
            int_rev_conversion = int_revenue.ToString("C2");
            ext_price_conversion = ext_final_price.ToString("C2");
            ext_rev_conversion = ext_revenue.ToString("C2");
            tot_rev_conversion = total_revenue.ToString("C2");


            // form prints out results as labels
            label4.Text = ($"{int_num} interior murals are scheduled\nfor a total of {int_rev_conversion}");
            label5.Text = ($"{ext_num} exterior murals are scheduled\nfor a total of {ext_rev_conversion}");
            label6.Text = ($"Total revenue expected is {tot_rev_conversion}");
            label7.Text = ($"It is {comparison} that there are more interior murals\nscheduled than exterior ones.");

        }

        // more objects
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

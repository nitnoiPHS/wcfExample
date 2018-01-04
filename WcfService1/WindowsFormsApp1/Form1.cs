using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            // string returnString;

            int result;
            int value1 = Convert.ToInt32(val1.Text);
            int value2 = Convert.ToInt32(val2.Text);
            result = client.sum(value1, value2);

            re1.Text = Convert.ToString(result);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
               ServiceReference1.Service1Client();
            // string returnString;

            int result;
            int value1 = Convert.ToInt32(val3.Text);
            int value2 = Convert.ToInt32(val4.Text);
            result = client.Subtract(value1, value2);

            re2.Text = Convert.ToString(result);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
               ServiceReference1.Service1Client();
            // string returnString;

            int result;
            int value1 = Convert.ToInt32(val5.Text);
            int value2 = Convert.ToInt32(val6.Text);
            result = client.Multiply(value1, value2);

            re3.Text = Convert.ToString(result);
        }

        private void div_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
               ServiceReference1.Service1Client();
            // string returnString;

            int result;
            int value1 = Convert.ToInt32(val7.Text);
            int value2 = Convert.ToInt32(val8.Text);
            result = client.Divide(value1, value2);

            re4.Text = Convert.ToString(result);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator_Grapecity
{
    public partial class Form1 : Form
    {
        private double amount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid amount");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Bill amount is out of the range double type");
            }
            int tip_percent = Convert.ToInt32(this.numericUpDown1.Value);
            int n = Convert.ToInt32(this.numericUpDown2.Value);
            // where n = number of people
            amount = Convert.ToDouble(textBox1.Text);
            if (amount > 0)
            {
                amount = amount / n;
                double tip,total;
                tip = amount * tip_percent / 100;
                total = amount + tip;
                textBox2.Text = tip.ToString("C2", new CultureInfo("en-US"));
                textBox3.Text = total.ToString("C2", new CultureInfo("en-US"));
            }
            else
            {
                MessageBox.Show("Enter the bill amount greater than 0");
            }

        }
    }
}

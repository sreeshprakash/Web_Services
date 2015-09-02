using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.WebService1 obj = new localhost.WebService1();
            textBox2.Text = Convert.ToString(obj.FahrenheitToCelsius(Convert.ToDouble(textBox1.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            localhost.WebService1 obj = new localhost.WebService1();
            textBox4.Text = Convert.ToString(obj.CelsiusToFahrenheit(Convert.ToDouble(textBox3.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

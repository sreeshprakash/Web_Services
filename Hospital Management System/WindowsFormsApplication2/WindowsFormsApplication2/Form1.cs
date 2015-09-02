using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.ServiceReference1;
using WindowsFormsApplication2.ServiceReference2;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        ServiceReference1.ServiceClient s1 = new ServiceReference1.ServiceClient();
        ServiceReference2.ServiceClient s3 = new ServiceReference2.ServiceClient();

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser3.Stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser3.GoHome();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            textBox2.Text = s1.Encrypt(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s2 = textBox1.Text;
            textBox2.Text = s1.Encrypt(s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s2 = textBox2.Text;
            textBox1.Text = s1.Decrypt(s2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s5 = textBox4.Text;
            textBox3.Text = s3.getStockquote(s5);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class Top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Invoke_Click(object sender, EventArgs e)
        {
            WebApplication7.TopService.Service1Client client = new TopService.Service1Client();
            string[] top = client.Top10Words(tb1.Text);
            tb2.Text = top[0];
            TextBox1.Text = top[1];
            TextBox9.Text = top[2];
            TextBox2.Text = top[3];
            TextBox3.Text = top[4];
            TextBox4.Text = top[5];
            TextBox5.Text = top[6];
            TextBox6.Text = top[7];
            TextBox7.Text = top[8];
            TextBox8.Text = top[9];
        }
    }
}
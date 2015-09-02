using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Try.DollarService;

namespace Try
{
    public partial class DollarForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //takes a number as input and displays the dollar amount in words
        protected void invoke_Click(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            int send = Convert.ToInt32(tb1.Text.ToString());
            tb2.Text = s.dollarAmount(send);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Try.TaxService;

namespace Try
{
    public partial class TaxForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void invoke_Click(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            int send = Convert.ToInt32(tb1.Text.ToString());
            double ans = s.taxCalculator(send);
            tb2.Text = ans.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication7.StemService;

namespace WebApplication7
{
    public partial class Stem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void invoke_Click(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            tb2.Text = s.Stemming(tb1.Text.ToString());

        }
    }
}
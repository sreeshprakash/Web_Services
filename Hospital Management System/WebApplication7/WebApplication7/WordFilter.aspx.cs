using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication7.WordFilterService;

namespace WebApplication7
{
    public partial class WordFilter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Invoke_Click(object sender, EventArgs e)
        {
            Service1Client stopWordRemover = new Service1Client();
            tb2.Text = stopWordRemover.WordFilter(tb1.Text);
        }
    }
}
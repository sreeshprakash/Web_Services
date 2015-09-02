using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Try.BillReference;

namespace Try
{
    public partial class BillForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //takes the Doctor's prescription as input and calculates the total bill amount by checking price of medicines
        protected void Invoke_Click(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            tb2.Text = s.GetData(tb1.Text.ToString());

        }
    }
}
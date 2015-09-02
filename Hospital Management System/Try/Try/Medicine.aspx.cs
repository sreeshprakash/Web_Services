using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Try.MedicineService;

namespace Try
{
    public partial class Medicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //takes the Doctor's report as the input and if common ailments are found it will suggest a suitable medicine
        protected void invoke_Click(object sender, EventArgs e)
        {
            Service1Client s = new Service1Client();
            tb2.Text = s.GetData(tb1.Text.ToString());

        }
    }
}
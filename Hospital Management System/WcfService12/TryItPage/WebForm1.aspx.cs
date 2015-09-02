using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TryItPage.ServiceReference1;


namespace TryItPage
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.Service1Client s = new ServiceReference1.Service1Client();

                   protected void Page_Load(object sender, EventArgs e)
        {
                
        }

                   protected void Validate_Click(object sender, EventArgs e)
                   {
                       TextBox3.Text = s.Validation(TextBox1.Text, TextBox2.Text);
                   }
                   protected void Generate_Click(object sender, EventArgs e)
                   {
                       TextBox7.Text = s.html(TextBox4.Text, TextBox5.Text, TextBox6.Text);
                   }

                   protected void TextBox6_TextChanged(object sender, EventArgs e)
                   {

                   }
    }
}
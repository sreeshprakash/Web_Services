using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Net;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Try
{
    public partial class TimeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Invoke_Click(object sender, EventArgs e)
        {
            String xml;


            string url = "http://webstrar40.fulton.asu.edu/page7/Time.svc/GetData";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader stream = new System.IO.StreamReader(res.GetResponseStream());
            xml = stream.ReadToEnd();
            XmlReader read = XmlReader.Create(new StringReader(xml));

            string[] result = new string[] { null, null, null, null, null };

            read.ReadToFollowing("string");
            tb1.Text = read.ReadString();
            read.ReadToFollowing("string");
            tb2.Text = read.ReadString();
            read.ReadToFollowing("string");
            TextBox1.Text = read.ReadString();
            read.ReadToFollowing("string");
            TextBox9.Text = read.ReadString();
            read.ReadToFollowing("string");
            TextBox2.Text = read.ReadString();
        }
    }
}
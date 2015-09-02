using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//Displays the current time at different places in the world which will be useful while interacting with other branches of the hospital
namespace WcfService11
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] GetData()
        {
            string[] result = new string[5];

            DateTime today = System.DateTime.Now;
            TimeSpan duration1 = new System.TimeSpan(0, 7, 0, 0);
            DateTime gmt = today.Add(duration1);
            result[0] = gmt.ToString();

            TimeSpan duration2 = new System.TimeSpan(0, 3, 0, 0);
            DateTime est = today.Add(duration2);
            result[1] = est.ToString();

            TimeSpan duration3 = new System.TimeSpan(0, 12, 30, 0);
            DateTime ist = today.Add(duration3);
            result[2] = ist.ToString();

            TimeSpan duration4 = new System.TimeSpan(0, 10, 0, 0);
            DateTime met = today.Add(duration4);
            result[3] = met.ToString();

            TimeSpan duration5 = new System.TimeSpan(0, 16, 0, 0);
            DateTime jst = today.Add(duration5);
            result[4] = jst.ToString();

            return (result);
        }
    }
}

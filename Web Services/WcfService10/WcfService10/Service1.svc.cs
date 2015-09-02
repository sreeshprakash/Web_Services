using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//takes the Doctor's report as the input and if common ailments are found it will suggest a suitable medicine
namespace WcfService10
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string input)
        {
            if (input.Contains("Cold"))
        {
		    return("nasacort");
        }
        if (input.Contains("headache"))
        {
		    return("Acetaminophen");
        }
        if (input.Contains("fever"))
        {
            return("Naproxen");
        }
        if (input.Contains("pain"))
        {
            return ("Traumeel");           
        }
        if (input.Contains("pimples"))
        {
            return("Zincovit");
        }
        if (input.Contains("Scars"))
        {
            return("Mederma");		
        }
        if (input.Contains("diabetes"))
        {
            return("Vetsulin");
        }
        if (input.Contains("burns"))
        {
            return("Resist C15");
        }
        if (input.Contains("cuts"))
        {
            return("Seagate olive cream");
        }
        else
        {
            return("medicine cannot be suggested please refere subscription");
        }
        }
    }
}

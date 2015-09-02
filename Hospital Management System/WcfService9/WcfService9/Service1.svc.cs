using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//takes the Doctor's prescription as input and calculates the total bill amount by checking price of medicines
namespace WcfService9
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string input)
        {
            int amount = 0;
            if (input.Contains("Lipitor"))
            {
                amount = amount + 10;
            }
            if (input.Contains("Nexium"))
            {
                amount = amount + 12;
            }
            if (input.Contains("Plavix"))
            {
                amount = amount + 14;
            }
            if (input.Contains("Advair"))
            {
                amount = amount + 15;
            }
            if (input.Contains("Abilify"))
            {
                amount = amount + 16;
            }
            if (input.Contains("Seroquel"))
            {
                amount = amount + 18;
            }
            if (input.Contains("Crestor"))
            {
                amount = amount + 20;
            }
            if (input.Contains("Actos"))
            {
                amount = amount + 22;
            }
            if (input.Contains("Epogen"))
            {
                amount = amount + 24;
            }
            return (amount.ToString());
        }
    }
}

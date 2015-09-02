using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//takes salary as input and calculates the annual tax of the person based on the tax bracket that he comes under

namespace WcfService7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double taxCalculator(int money)
        {
            double tax;
            if (money < 10000)
            {
                tax = .05 * money;
            }
            else if (money <= 100000)
            {
                tax = .08 * money;
            }
            else
            {
                tax = .09 * money;
            }
            return (tax);

        }
    }
}

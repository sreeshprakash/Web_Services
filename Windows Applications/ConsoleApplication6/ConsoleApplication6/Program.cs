using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

           DateTime today = System.DateTime.Now;
           TimeSpan duration1 = new System.TimeSpan(0, 7, 0, 0);
           DateTime gmt = today.Add(duration1);

           TimeSpan duration2 = new System.TimeSpan(0, 3, 0, 0);
           DateTime est = today.Add(duration1);

           TimeSpan duration3 = new System.TimeSpan(0, 12, 30, 0);
           DateTime ist = today.Add(duration1);

           TimeSpan duration4 = new System.TimeSpan(0, 10, 0, 0);
           DateTime met = today.Add(duration1);

           TimeSpan duration5 = new System.TimeSpan(0, 16, 0, 0);
           DateTime jst = today.Add(duration1);

           TimeSpan duration6 = new System.TimeSpan(0, 9, 0, 0);
           DateTime cat = today.Add(duration1);
           
           Console.WriteLine("{0:dddd HH:MM}", gmt);
           Console.ReadLine();
        }
    }
}

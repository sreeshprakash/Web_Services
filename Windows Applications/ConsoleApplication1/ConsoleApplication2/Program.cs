using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] instances = { "hopeless", "powerful", "freedom" };
            string[] suffixes = { "less", "ful", "dom", "ing", "ly", "ation", "ion", "s" };

            string result = "";
            foreach (string instance in instances)
            {
                foreach (string suffix in suffixes)
                {
                    if (Regex.IsMatch(instance, suffix))
                    {
                        result = Regex.Replace(instance, suffix, "", RegexOptions.None);
                        Console.WriteLine(result);
                    }
                }
            }
            Console.Read();
        }
    }
}
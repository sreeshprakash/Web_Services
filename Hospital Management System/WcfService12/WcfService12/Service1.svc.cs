using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Xml.Xsl;
using System.Xml.XPath;
namespace WcfService12
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Validation(string url2, string url1)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            try
            {
                settings.Schemas.Add("", url1);
            }
            catch(Exception)
            {
                return ("Error in schema");
            }
            try
            {
                XmlReader reader = XmlReader.Create(url2, settings);
            }
            catch (Exception)
            {
                return ("Error in XML");
            }
            return ("No Error");
        }
        public string html(string url1, string url2, string url3)
        {

            try
            {
                XPathDocument myXPathDocument = new XPathDocument("C:\\Users\\user\\Desktop\\Assignment 4\\schema.xml");
            XslTransform myXslTransform = new XslTransform();
            XmlTextWriter writer = new XmlTextWriter(url3, null);
            myXslTransform.Load(url2);
            myXslTransform.Transform(myXPathDocument, null, writer);
            writer.Close();
            StreamReader stream = new StreamReader(url3);
                
            }
            catch (Exception)
            {
                return("exception occured");
            }
            return ("HTML created successfully");
        }
        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                System.Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
               
            }
            else
            {
                System.Console.WriteLine("\tValidation error: " + args.Message);
            }
        }
    }
}
using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

public class TransformXML
{
    //This will transform xml document using xslt and produce result xml document
    //and display it

    public static void Main(string[] args)
    {
        try
        {
            XPathDocument myXPathDocument = new XPathDocument("C:/Users/user/Desktop/Assignment 4/schema.xml");
            XslTransform myXslTransform = new XslTransform();
            XmlTextWriter writer = new XmlTextWriter("C:/Users/user/Desktop/Assignment 4/output.html", null);
            myXslTransform.Load("http://www.public.asu.edu/~sprakas3/dsod/Hotels.xsl");
            myXslTransform.Transform(myXPathDocument, null, writer);
            writer.Close();
            StreamReader stream = new StreamReader("C:/Users/user/Desktop/Assignment 4/output.html");
            Console.Write("**This is result document**\n\n");
            Console.Write(stream.ReadToEnd());
	//parsing the xml
        }
        catch (Exception e)
        {
        }
    }
}
using System.Xml;
using System.Xml.Schema;
using System.IO;

public class ValidXSD
{
    public static void Main()
    {
        System.Console.WriteLine("entered");
        // Set the validation settings.
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
        settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
        settings.Schemas.Add("", "C://Users//user//Desktop//Assignment 4//schema.xsd");

        // Create the XmlReader object.
        XmlReader reader = XmlReader.Create("http://www.public.asu.edu/~sprakas3/dsod/schema.xml", settings);
        // Parse the file. 
        while (reader.Read()) ;

    }
    // Display any warnings or errors.
    private static void ValidationCallBack(object sender, ValidationEventArgs args)
    {
        if (args.Severity == XmlSeverityType.Warning)
        {
            System.Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            System.Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("\tValidation error: " + args.Message);
            System.Console.ReadLine();
        }
        System.Console.ReadLine();

    }
}
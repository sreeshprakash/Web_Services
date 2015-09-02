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

namespace XMLService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }
    

public class ValidXSD
{
    public static void Main()
    {

        // Set the validation settings.
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
        settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
        settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

        // Create the XmlReader object.
        XmlReader reader = XmlReader.Create("inlineSchema.xml", settings);

        // Parse the file. 
        while (reader.Read()) ;

    }
    // Display any warnings or errors.
    private static void ValidationCallBack(object sender, ValidationEventArgs args)
    {
        if (args.Severity == XmlSeverityType.Warning)
            Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
        else
            Console.WriteLine("\tValidation error: " + args.Message);

    }
}


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

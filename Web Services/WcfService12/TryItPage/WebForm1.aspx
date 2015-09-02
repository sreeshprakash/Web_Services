<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TryItPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <asp:Label ID="Label4" runat="server"><h1>TryIt Page (for 5.1)</h1></asp:Label>
     <asp:label ID="Label5" runat="server"><b>Verification</b></asp:label>
    <br />
    <asp:label ID="Label6" runat="server">This service takes the URL of an XML (.xml) file and the URL of the corresponding XMLS (.xsd) file as input and validates the XML file against the corresponding XMLS (XSD) file</asp:label>
    <br />
        <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Verification</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>URL of XML & XMLS</td>
        </tr>
        <tr>
               <th>Output of Verification:</th>
               <td>No Error or the Page having the error</td>
        </tr>
    </table>
        <br />
        <br />
    <table>
        <tr>
            <th>XML Link</th>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
               <th>Schema </th>
               <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                   </td>
        </tr>
        <tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
    </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
        <asp:Button ID="Validate" runat="server" Text="Validate" OnClick="Validate_Click" />
        <asp:Label ID="Label8" runat="server"><h1>TryIt Page(for 5.2)</h1></asp:Label>
     <asp:label ID="Label9" runat="server"><b>Transformation</b></asp:label>
    <br />
    <asp:label ID="Label10" runat="server">This service takes the URL of an XML (.xml) file and the URL of the XSL file as inputs and generates the HTML file based on the XML and XSL files at any location specified by the user.</asp:label>
    <br />
        <br />
            <table>
        <tr>
           <th>Operation Name:</th>
            <td>Transformation</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>Url of XML, XLS and output file location</td>
        </tr>

        <tr>
               <th>Output of Transformation:</th>
               <td>HTML file will be created</td>
        </tr>
    </table>
        <br />
            <td>Please note for output the files in the path must be separated by "\" and end with fileanme.html</td>
        <br />
    <br />
         <table>
        <tr>
            <th>XML Link</th>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
               <th>Corresponding XMLS</th>
               <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                   </td>
        </tr>
        <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="Local path to save output file"></asp:Label>
    </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            </td>
        </tr>
             </table>

            
        <asp:Button ID="Button1" runat="server" Text="Generate HTML file" OnClick="Generate_Click" />
       
        <table>
        <tr>
    <td>
        <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
    </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
            </table>
    <br />
    <br />
    
    </div>
    </form>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tax.aspx.cs" Inherits="Try.TaxForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"><h1>TryIt Page</h1></asp:Label>
     <asp:label ID="Label2" runat="server"><b>Tax Calculator</b></asp:label>
    <br />
    <asp:label ID="Label3" runat="server">This service takes salary as input and calculates the annual salary of the person based on the tax bracket that he comes under</asp:label>
    <br />
    <asp:label ID="Label4" runat="server"> URL for the Web Service : </asp:label>
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);"><a href="http://webstrar40.fulton.asu.edu/Page8/Tax.svc?wsdl">http://webstrar40.fulton.asu.edu/Page8/Tax.svc?wsdl</a></pre>
        <br class="Apple-interchange-newline" />
    <br />
    <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Tax Calculator</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>Salary</td>
        </tr>
        <tr>
               <th>Output of Tax Calculator:</th>
               <td>Tax amount</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Table runat="server">
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Enter your salary:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox ID="tb1" runat="server"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Your tax amount is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tb2"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:Button ID="Invoke" runat="server" Text="Invoke" OnClick="invoke_Click" /></asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    </div>
    </form>
</body>
</html>

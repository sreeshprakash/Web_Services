<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"><h1>TryIt Page</h1></asp:Label>
     <asp:label ID="Label2" runat="server"><b>Display dollar Amount</b></asp:label>
    <br />
    <asp:label ID="Label3" runat="server">This service takes a number as input and displays the dollar amount in words</asp:label>
    <br />
    <asp:label ID="Label4" runat="server"> URL for the Web Service : </asp:label>
    <asp:HyperLink ID="HyperLink1" NavigateUrl="http://localhost:52635/Service1.svc" runat="server">http://localhost:52635/Service1.svc</asp:HyperLink>
    <br />
    <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Dollar Amount</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>Number</td>
        </tr>
        <tr>
               <th>Output:</th>
               <td>The amount in dollars</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Table runat="server">
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Enter the number:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox ID="tb1" runat="server"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The dollar amount is:</asp:TableHeaderCell>
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
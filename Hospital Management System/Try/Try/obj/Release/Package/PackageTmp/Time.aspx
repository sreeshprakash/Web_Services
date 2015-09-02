<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Time.aspx.cs" Inherits="Try.TimeForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"><h1>TryIt Page</h1></asp:Label>
     <asp:label ID="Label2" runat="server"><b>Time around the world</b></asp:label>
    <br />
    <asp:label ID="Label3" runat="server">Displays the current time at different places in the world which will be useful while interacting with other branches of the hospital</asp:label>
    <br />
    <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Global Watch</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>No input required</td>
        </tr>
        <tr>
               <th>Output:</th>
               <td>Current time at different places around the world</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Table runat="server">
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">London : </asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox ID="tb1" runat="server"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">New York : </asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tb2"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Delhi : </asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox1"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Riyadh : </asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox9"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Tokyo : </asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox2"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:Button ID="Invoke" runat="server" Text="Invoke" OnClick="Invoke_Click" /></asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    </div>
    </form>
</body>
</html>



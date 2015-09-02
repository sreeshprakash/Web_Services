<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stem.aspx.cs" Inherits="WebApplication7.Stem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"><h1>TryIt Page</h1></asp:Label>
     <asp:label ID="Label2" runat="server"><b>Stemming</b></asp:label>
    <br />
    <asp:label ID="Label3" runat="server">This service takes an input string, replaces each of the inflected or derived words to their stem or root word</asp:label>
    <br />
    <asp:label ID="Label4" runat="server"> URL for the Web Service : </asp:label>
        <a href="http://webstrar40.fulton.asu.edu/page8/Service1.svc">http://webstrar40.fulton.asu.edu/page8/Service1.svc</a><br />
    <br />
    <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Stemming</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>String of words</td>
        </tr>
        <tr>
               <th>Output of Stemming:</th>
               <td>The Stem or Root words are</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Table runat="server">
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Enter the input string:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox ID="tb1" runat="server"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The output string is:</asp:TableHeaderCell>
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

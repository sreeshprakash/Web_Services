<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top.aspx.cs" Inherits="WebApplication7.Top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"><h1>TryIt Page</h1></asp:Label>
     <asp:label ID="Label2" runat="server"><b>Top 10 Words</b></asp:label>
    <br />
    <asp:label ID="Label3" runat="server">Analyze the webpage at the given url and return the 10 most frequently occuring words</asp:label>
    <br />
    <asp:label ID="Label4" runat="server"> URL for the Web Service : </asp:label>
        <a href="http://webstrar40.fulton.asu.edu/page8/Service2.svc">http://webstrar40.fulton.asu.edu/page8/Service2.svc</a><br />
    <br />
    <br />
    <table>
        <tr>
           <th>Operation Name:</th>
            <td>Top 10 words</td>
        </tr>
        <tr>
            <th>Parameter List:</th>
            <td>String of words</td>
        </tr>
        <tr>
               <th>Output:</th>
               <td>The Top 10 used words are</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Table runat="server">
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">Enter the input url:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox ID="tb1" runat="server"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 1st word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tb2"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 2nd word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox1"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 3rd word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox9"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 4th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox2"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 5th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox3"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 6th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox4"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 7th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox5"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 8th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox6"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 9th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox7"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableHeaderCell runat="server">The 10th word is:</asp:TableHeaderCell>
        <asp:TableCell runat="server"><asp:TextBox runat="server" ID="TextBox8"></asp:TextBox></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server"><asp:Button ID="Invoke" runat="server" Text="Invoke" OnClick="Invoke_Click" /></asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WcfService12.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
    
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
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                   </td>
        </tr>
        <tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
        <asp:Button ID="Validate" runat="server" Text="Validate" OnClick="Validate_Click" />
    <br />
    <br />
    
    </div>
    </form>
</body>
</html>

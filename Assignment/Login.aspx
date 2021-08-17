<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Username:<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td> Password:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            </tr>
        </table>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

        
       

        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

        
       

        <asp:Button ID="btnAdminLogin" runat="server" Text="Admin Login" OnClick="btnAdminLogin_Click" />

        
       

    </form>
</body>
</html>

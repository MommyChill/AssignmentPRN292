<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerWeb.aspx.cs" Inherits="Assignment.ManagerWeb" %>


<%@ Register Src="PannerAdmin.ascx" TagName="PannerAdmin" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><uc1:PannerAdmin ID="pane" runat="server"></uc1:PannerAdmin></td>
            </tr>
            <tr>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>


        </table>




    </form>
</body>
</html>

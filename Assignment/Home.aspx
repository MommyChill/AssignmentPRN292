<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment.Index" %>

<%@ Register Src="Panner.ascx" TagName="Panner" TagPrefix="uc1" %>
<%@ Register Src="Menu.ascx" TagName="Menu" TagPrefix="uc2" %>
<%@ Register Src="Product.ascx"TagName="Product" TagPrefix="uc3" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .auto-style {
            width: 195px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%">
              <tr>
                  <td>
                      <uc1:Panner ID="pane" runat="server"></uc1:Panner>
                  </td>
              </tr>
            <tr>
                <td>
                    <uc2:Menu ID="menu" runat="server"></uc2:Menu>
                </td>
                <td>
                    <asp:PlaceHolder ID="loadContent" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BillDetail.ascx.cs" Inherits="Assignment.BillDetail" %>
<asp:GridView ID="gvBillDetail" runat="server"
     Caption="Bill Detail"
    DataKeyNames="oID"
    AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="pid" HeaderText="Product ID" />
        <asp:BoundField DataField="oID" HeaderText="Bill id" />
        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
        <asp:BoundField DataField="price" HeaderText="Price" />
        <asp:BoundField DataField="total" HeaderText="Total" />
    </Columns>
</asp:GridView>
Customer Name:<asp:Label ID="lblCustomerName" runat="server" Text=""></asp:Label>

<asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" />
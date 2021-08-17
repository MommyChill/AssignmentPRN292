<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Bill.ascx.cs" Inherits="Assignment.Bill" %>

<asp:GridView ID="gvBill" runat="server"
     Caption="Product List Manual"
    DataKeyNames="oID"
    AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="oID" HeaderText="oID" />
        <asp:BoundField DataField="dateCreate" HeaderText="Date" />
        <asp:BoundField DataField="cname" HeaderText="Customer Name" />
        <asp:BoundField DataField="cphone" HeaderText="Phone" />
        <asp:BoundField DataField="cAddress" HeaderText="Address" />
        <asp:BoundField DataField="total" HeaderText="Total" />
        <asp:BoundField DataField="status" HeaderText="Status" />
         <asp:BoundField DataField="cid" HeaderText="customerID" />
        
        <asp:HyperLinkField HeaderText="Detail"
            DataNavigateUrlFields="oID"
            DataNavigateUrlFormatString="ManagerWeb.aspx?oID={0}" Text="Detail" />
    </Columns>
</asp:GridView>
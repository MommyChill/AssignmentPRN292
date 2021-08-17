<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customer.ascx.cs" Inherits="Assignment.Customer" %>

<asp:GridView ID="gvCustomer" runat="server"
     Caption="Product List Manual"
    DataKeyNames="cid"
    AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="cid" HeaderText="customer ID" />
        <asp:BoundField DataField="cname" HeaderText="Custoemr Name" />
        <asp:BoundField DataField="cphone" HeaderText="Phone" />
        <asp:BoundField DataField="cAddress" HeaderText="Address" />
        <asp:BoundField DataField="cAddress" HeaderText="Address" />
        <asp:BoundField DataField="username" HeaderText="Username" />
        <asp:BoundField DataField="password" HeaderText="Password" />
        
<%--        <asp:HyperLinkField HeaderText="Add to cart"
            DataNavigateUrlFields="pid"
            DataNavigateUrlFormatString="Home.aspx?id={0}" Text="add to cart" />--%>
    </Columns>
</asp:GridView>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="Assignment.Menu" %>

<asp:GridView ID="GridView1" runat="server"
    AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="cid" HeaderText="cid" ShowHeader="False" Visible="False" />
        <asp:BoundField DataField="cateName" HeaderText="" />

        <asp:HyperLinkField HeaderText="Find"
            DataNavigateUrlFields="cateID"
            DataNavigateUrlFormatString="Index.aspx?cateID={0}" Text="Find"/>
    </Columns>
</asp:GridView>




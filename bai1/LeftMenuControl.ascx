<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenuControl.ascx.cs" Inherits="LeftMenuControl" %>
<asp:DataList ID="dlMenu" runat="server" Width="250px">
    <ItemTemplate>
        <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("NAME") %>' NavigateUrl='<%# "Category.aspx?IDCAT="+Eval("ID") %>'></asp:HyperLink>
    </ItemTemplate>
</asp:DataList>


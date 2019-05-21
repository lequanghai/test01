<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="ProductDelait.aspx.cs" Inherits="_ProductDetait" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 125px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="dlProduct" runat="server" RepeatColumns="1">
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="75px" ImageUrl='<%# "images/"+Eval("IMAGE") %>' Width="67px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Name:</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NAME") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Price</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("PRICE") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Description:</td>
                    <td>
                              <asp:Label ID="Label3" runat="server" Text='<%# Eval("DECRIPTION") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAddtocart" runat="server" Text="Add to Cart" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>


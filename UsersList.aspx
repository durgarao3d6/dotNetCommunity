<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="DotNetCommunity.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image:linear-gradient(45deg,#ff6a00,#ffd800);height:400px;width:200px;align-content:center">
        <h3>users</h3>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" BorderStyle="None" CellPadding="5" GridLines="None">
        <AlternatingRowStyle BackColor="#6699FF" ForeColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="LoginId">
                <ItemTemplate>
                    <asp:Label ID="lbllid" runat="server" Text='<%# Eval("LoginId") %>' >

                    </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblname" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="UserName">
                <ItemTemplate>
                    <asp:Label ID="lbluname" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:LinkButton ID="Linkstatus"  runat="server" Text='<%# Eval("status") %>' CommandName="status" CommandArgument='<%#Eval("LoginId") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <HeaderStyle BackColor="Black" BorderColor="White" ForeColor="White" />

    </asp:GridView>
</asp:Content>

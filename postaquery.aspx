<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="postaquery.aspx.cs" Inherits="DotNetCommunity.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbluser" CssClass="badge badge-info " runat="server"></asp:Label><br />
    <asp:Image ID="Image3" runat="server" ImageUrl="~/images (4).jpeg" Height="300px" Width="300px"/>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <i class="fa fa-question-circle"></i> ENTER YOUR QUESTION:<br />
    <asp:TextBox ID="TextBox1"  CssClass="form-control" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="Button1" CssClass="btn btn-primary fa" runat="server" Text="SUBMIT" OnClick="Button1_Click"/><br />
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    

    <br />
    

</asp:Content>

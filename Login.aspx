<%@ Page Title="" Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DotNetCommunity.page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;box-shadow:2px 2px 2px 2px #908080; height:300px;width:400px;">
          <h1 style="margin:auto;color:rgba(119, 16, 102, 0.80)">LOGIN</h1>
    Enter your email id:
    <asp:TextBox ID="name" cssclass="form-control"  runat="server"></asp:TextBox><br /><br />
    Enter your password:
    <asp:TextBox ID="pwd" CssClass="form-control" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btnsubmit"  runat="server" text="SUBMIT" OnClick="btnsubmit_Click" CssClass="button"/>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </div>
  
</asp:Content>

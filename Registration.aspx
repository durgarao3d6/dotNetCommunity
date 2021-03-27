<%@ Page Title="" Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DotNetCommunity.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
    <div class="container">
        <div class="row">
            <h3 class="modal-header">REGISTRATION</h3>
        </div>
    <div class="row" style="margin-bottom:2px">
        <div class="col-4 col-md-4">
            Entter name:
        </div>
        <div class="col-8 col-md-8">
           <asp:TextBox ID="txtusername"  runat="server" ></asp:TextBox>
        </div>
    </div>
    <div class="row" style="margin-bottom:2px">
        <div class="col-4 col-md-4">
            Enter username:
        </div>
        <div class="col-8 col-md-8">
           <asp:TextBox ID="txtuname"  runat="server" ></asp:TextBox>
        </div>
    </div>
    <div class="row" style="margin-bottom:2px">
        <div class="col-4 col-md-4">
            Enter password:
        </div>
        <div class="col-8 col-md-8">
           <asp:TextBox ID="txtpwd"  runat="server" ></asp:TextBox>
        </div>
    </div>
    <div class="row" style="margin-bottom:2px">
        <div class="col-4 col-md-4">
            select security question:
        </div>
        <div class="col-8 col-md-8">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>-select-</asp:ListItem>
                <asp:ListItem>what is your petname</asp:ListItem>
                <asp:ListItem>what is your favorite place?</asp:ListItem>
                <asp:ListItem>who is your informaton?</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-4 col-md-4">
            Enter answer:
        </div>
        <div class="col-8 col-md-8">
           <asp:TextBox ID="txtanswer"  runat="server" ></asp:TextBox>
        </div>
    </div>
         <div class="row">
             
             <asp:Button ID="btnregister" CssClass="btn btn-primary" runat="server" Text="submit" OnClick="btnregister_Click" />
    </div>
    
    
    
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Content>

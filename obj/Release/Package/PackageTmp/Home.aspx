<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    Welcome  <asp:Label ID="lblname" runat="server" Text=""></asp:Label>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server"></asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" Runat="Server"></asp:Content>
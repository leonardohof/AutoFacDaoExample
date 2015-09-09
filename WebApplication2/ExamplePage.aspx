<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExamplePage.aspx.cs" Inherits="WebApplication2.ExamplePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Example Data</h1>
    <asp:GridView ID="grid" runat="server" AutoGenerateColumns="true" Width="100%"></asp:GridView>
</asp:Content>

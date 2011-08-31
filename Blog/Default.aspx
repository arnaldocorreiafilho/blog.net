<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Blog._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Criar squema
    </h2>
<p>
        <asp:Button ID="btnCriar" runat="server" onclick="btnCriar_Click" 
            Text="Criar" />
    </p>
    </asp:Content>

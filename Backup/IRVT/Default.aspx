<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="IRVT._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to IRVT!
    </h2>
    <p>
       
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Run Test Driver" />
       
    </p>
    <p>
        
    </p>
</asp:Content>

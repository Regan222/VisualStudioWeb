<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CSSAnimateTest._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--This is a comment. Comments are not displayed in the browser-->
    <link type="text/css" rel="stylesheet" href="main.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--This is where I put the grid view.  It goes inside the placeholder-->
<asp:GridView 
    runat="server" 
    ID="GridView1" 
    CssClass="gvclass"
    Gridlines="None">
     
</asp:GridView> 
    <!--This is where the include file starts.  Add the following to your page where you want it to appear-->
<div id="LetterBlock">
    <%
        Response.WriteFile("letter.txt");
    %>

</div>
</asp:Content>


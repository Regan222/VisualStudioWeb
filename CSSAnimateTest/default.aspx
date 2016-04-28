<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CSSAnimateTest._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="SearchBox" runat="server"  style="position: absolute; width: 157px; z-index: 100; background-image: url('Images/tagsbox.png'); height: 169px;">

text text text text text text text    

</div>

  <div id="Button">
        <asp:Button ID="Button1" runat="server" Text="Click Here" OnClick="Button1_Click" />

    </div>

   <div id="Greeting" runat="server"> <asp:Literal ID="Literal1" runat="server"></asp:Literal>&nbsp;</div>

    <div id="NewBox">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    </div>
</asp:Content>

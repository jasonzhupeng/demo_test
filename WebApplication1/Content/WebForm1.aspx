<%--<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Content.WebForm1" %>--%>

<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>啦啦啦啦</h1>
    <input type="button" id="test" value="test" />
    <script type="text/javascript">
        $("#test").click(function () {
            var a1 = 10;
            var a2 = 20;
            alert("a1+a2=" + a1 + a2);
        })
    </script>

</asp:Content>

<!-- NOTE:
The "Inherits" attribute is what connects this .aspx file to its .cs file. 
The "CodeBehind" attribute is just what Visual Studio (not the language itself) uses to connect the two.
-->
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleHttpRequest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>The Amazing Form Submitter</h1>
        <p class="lead">ASP.NET and C#.</p>
    </div>

    <!-- notice that you can use bootstrap CSS (look at the classes on the form elements) on asp:Button and asp:TextBox. -->
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <h2>This is a form</h2>
            <p>
                <asp:TextBox ID="nameInput" class="form-control" placeholder="name" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="emailInput" class="form-control" placeholder="email address" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="myButton" class="btn btn-default" runat="server" Text="Submit &raquo;" OnClick="myButton_Click" />
            </p>
        </div>
        <div class="col-md-4">

        </div>
    </div>

</asp:Content>
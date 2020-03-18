<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApp_vbnet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="grafico.css">
    <title>PizzaXMês</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <section class="grafico_">
        <div class="mes">
            <div class="mes__centralizado">teste</div>
        </div>
        <div class="valor">
            <div class="barra_width" style="width: 50%;" title="24%">24%</div>
        </div>
    </section>
</asp:Content>

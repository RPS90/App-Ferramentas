<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="subMenuGerenciarAgecefs.aspx.cs" Inherits="SistemaFenag.subMenuGerenciarAgecefs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SIGA - FENAG</title>
    <meta name="author" content="Mike Ewerthon de Figueiredo Silva" />
    <link rel="stylesheet" type="text/css" href="css/estilo.css" />
    <meta charset="utf-8" />
    <link rel="icon" href="img/logotipo-fenag-topo.png">
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
	<script src="js/script.js"></script>
    <script src="js/jquery-1.5.2.min.js"></script>
    <style>.wow:first-child {visibility: hidden;}</style>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Gerenciar AGECEF'S</h1>
            <div class="containerFormsPrincipais">
                <br />
                <div class="botoesMenusSIGA">Cadastrar AGECEF</div>
                <div class="botoesMenusSIGA">Pesquisar AGECEF</div>
                <div class="botoesMenusSIGA">Alterar AGECEF</div>
                <div class="clearfix"></div>
                <br /><br />
            </div>
        </div>
    </center>
    <%
        Response.WriteFile("rodape.htm");
    %>
</body>
</html>

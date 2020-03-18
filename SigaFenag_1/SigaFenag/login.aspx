<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SistemaFenag.login" %>

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
	<script src="js/jquery.maskedinput-1.3.min.js"></script>
    <style>.wow:first-child {visibility: hidden;}</style>
	<script>
	    jQuery(function ($) {
	        $("#txtMatricula").mask("999999-9");

	    });	
	</script>
</head>
<body>
     <center>
        <div class="topoPaginaLogin">
            <img src="img/logotipo-fenag-topo.png" class="logotipoTopoLogin"/>
            <div class="clearfix"></div>
        </div>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Login</h1>
            <p class="BoasVindasPaginaLogin">Bem vindo ao sistema de gerenciamento dos associados da <br />Federação Nacional das Associações dos Gestores da Caixa Econômica Federal.</p>
            <div class="formLogin">
                <form id="form1" runat="server">
                    <asp:Label ID="lblMatricula" runat="server" Text="Matrícula" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:TextBox ID="txtMatricula" runat="server" class="txtLogin" required></asp:TextBox>
                    <br />
                    <asp:Label ID="lblSenha" runat="server" Text="Senha" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:TextBox ID="txtSenha" runat="server" class="txtLogin"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnAcessar" runat="server" Text="Acessar" class="btnAcessar"/>
                    <div class="clearfix"></div><br />
                    <hr class="linhaLogin" />
                    <asp:Button ID="btnRecuperarSenha" runat="server" Text="Recuperar senha" class="btnRecuperarSenha"/>
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastro" class="btnCadastro"/>
                    <div class="clearfix"></div>
                </form>
            </div>
            <br /><br />
        </div>
    </center>
    <%
        Response.WriteFile("rodape.htm");
    %>
</body>
</html>

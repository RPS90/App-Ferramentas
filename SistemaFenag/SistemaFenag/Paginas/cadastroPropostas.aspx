<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroPropostas.aspx.cs" Inherits="SistemaFenag.cadastroPropostas" %>

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
            <h1 class="tituloPaginaLogin">FAÇA A SUA PROPOSTA</h1>
            <div class="containerFormsPrincipais">
                <form id="form1" runat="server">
                    <br />
                    <asp:Label ID="lblNomeUsuario" runat="server" Text="Nome do usuário Logado" class="lblInfoUsuarioNaTela"></asp:Label>
                    <br />
                    <asp:Label ID="lblEmailUsuario" runat="server" Text="E-mail do usuário Logado" class="lblInfoUsuarioNaTela"></asp:Label>
                    <div class="clearfix"></div>
                    <textarea ID="txtSugestao" class="TxtAmpliado" cols="23" rows="4" [COLOR="Red"]wrap="hard"[/COLOR] required placeholder="Digite a sua sugestão aqui"></textarea>
                    <asp:Button ID="btnSugestao" runat="server" Text="Enviar Sugestão" title="Ao clicar neste botão, a sugestão será enviada para análise" class="btnCadastro" style="float: none;max-width: 200px;"/>
                    <div class="clearfix"></div><br /><br />
                </form>
            </div>
        </div>
    </center>
    <%
        Response.WriteFile("rodape.htm");
    %>
</body>
</html>

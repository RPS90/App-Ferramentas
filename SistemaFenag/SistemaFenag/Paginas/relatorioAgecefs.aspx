<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="relatorioAgecefs.aspx.cs" Inherits="SistemaFenag.relatorioAgecefs" %>

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
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Relatório das AGECEF'S</h1>
            <div class="formLogin">
                <form id="form1" runat="server">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropEstado" runat="server" class="txtLogin" required>
                            <asp:ListItem Value="Acre">Acre</asp:ListItem>
                            <asp:ListItem Value="Amapá">Amapá</asp:ListItem>
                            <asp:ListItem Value="Amazonas">Amazonas</asp:ListItem>
                            <asp:ListItem Value="Alagoas">Alagoas</asp:ListItem>
                            <asp:ListItem Value="Bahia">Bahia</asp:ListItem>
                            <asp:ListItem Value="Ceará">Ceará</asp:ListItem>
                            <asp:ListItem Value="Distrito Federal">Distrito Federal</asp:ListItem>
                            <asp:ListItem Value="Espírito Santo">Espírito Santo</asp:ListItem>
                            <asp:ListItem Value="Goiás">Goiás</asp:ListItem>
                            <asp:ListItem Value="Maranhão">Maranhão</asp:ListItem>
                            <asp:ListItem Value="Mato Grosso">Mato Grosso</asp:ListItem>
                            <asp:ListItem Value="Mato Grosso do Sul">Mato Grosso do Sul</asp:ListItem>
                            <asp:ListItem Value="Minas Gerais">Minas Gerais</asp:ListItem>
                            <asp:ListItem Value="Pará">Pará</asp:ListItem>
                            <asp:ListItem Value="Paraíba">Paraíba</asp:ListItem>
                            <asp:ListItem Value="Paraná">Paraná</asp:ListItem>
                            <asp:ListItem Value="Rio de Janeiro">Rio de Janeiro</asp:ListItem>
                            <asp:ListItem Value="Rio Grande do Norte">Rio Grande do Norte</asp:ListItem>
                            <asp:ListItem Value="Rio Grande do Sul">Rio Grande do Sul</asp:ListItem>
                            <asp:ListItem Value="Rondônia">Rondônia</asp:ListItem>
                            <asp:ListItem Value="Roraima">Roraima</asp:ListItem>
                            <asp:ListItem Value="Santa Catarina">Santa Catarina</asp:ListItem>
                            <asp:ListItem Value="São Paulo">São Paulo</asp:ListItem>
                            <asp:ListItem Value="Sergipe">Sergipe</asp:ListItem>
                            <asp:ListItem Value="Pernambuco">Pernambuco</asp:ListItem>
                            <asp:ListItem Value="Piauí">Piauí</asp:ListItem>
                            <asp:ListItem Value="Tocantins">Tocantins</asp:ListItem>
                    </asp:DropDownList>
                    <div class="clearfix">
                    <br />
                    <asp:Label ID="lblRegiao" runat="server" Text="Região" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropRegiao" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Região</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="clearfix">
                    <br />
                    <asp:Label ID="lblStatus" runat="server" Text="Status" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"><br />
                    <asp:DropDownList ID="dropStatus" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Ativo</asp:ListItem>
                        <asp:ListItem Value="">Inativo</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="clearfix"><br />
                    <asp:Button ID="btnGerarRelatorio" runat="server" Text="Gerar Relatório" class="btnCadastroInterno"/>
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

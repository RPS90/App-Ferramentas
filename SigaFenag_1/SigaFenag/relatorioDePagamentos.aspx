<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="relatorioDePagamentos.aspx.cs" Inherits="SistemaFenag.relatorioDePagamentos" %>

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
            <h1 class="tituloPaginaLogin">Relatório de Pagamentos</h1>
            <div class="formLogin">
                <form id="form1" runat="server">
                    <asp:Label ID="lblAgecef" runat="server" Text="AGECEF" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropAgecef" runat="server" class="txtLogin" required>
                            <asp:ListItem Value="">Selecione --</asp:ListItem>
                            <asp:ListItem Value="">AGECEF São Paulo</asp:ListItem>
                    </asp:DropDownList>
                    <div class="clearfix">
                    <br />
                    <asp:Label ID="lblStatusPagamento" runat="server" Text="Status de Pagamento" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropStatusPagamento" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Efetivado</asp:ListItem>
                        <asp:ListItem Value="">Pendente</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="clearfix"></div>
                    <br />
                    <asp:Label ID="lblMes" runat="server" Text="Mês" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"><br />
                    <asp:DropDownList ID="dropMes" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Mês</asp:ListItem>
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

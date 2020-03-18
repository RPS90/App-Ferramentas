<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizarStatusPagamentos.aspx.cs" Inherits="SistemaFenag.visualizarStatusPagamentos" %>

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
            <h1 class="tituloPaginaLogin">Visualizar Status de Pagamentos</h1>
            <div class="containerGrids">
                <br />
                <asp:Label ID="lblTituloPagamentos" runat="server" Text="Pagamentos carregados" class="tituloInternoGrids"></asp:Label>
                <table border="1" style="margin-top:2%;">
                    <tr>
                        <td class="GridTables">Usuário</td>
                        <td class="GridTables">Matrícula</td>
                        <td class="GridTables">Status de Pagamento</td>
                        <td class="GridTables">Mês</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Pendente</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Pendente</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Pendente</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Pendente</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Efetivado</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Pendente</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Efetivado</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Efetivado</td>
                        <td class="GridTables">Mês selecionado</td>
                    </tr>
                </table>
                <br />
            </div>
            <div class="formLogin">
                <form id="form1" runat="server">
                    <br />
                    <asp:Label ID="lblTituloFiltro" runat="server" Text="Realize outro filtro de pagamentos" class="tituloInternoGrids"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:Label ID="lblAgecef" runat="server" Text="Agecef" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropAgecef" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Agecef São Paulo</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:Label ID="lblMes" runat="server" Text="Mês" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropMes" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Mês</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="clearfix"></div><br />
                    <br />
                    <asp:Label ID="lblStatus" runat="server" Text="Status" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropStatus" runat="server" class="txtLogin">
                        <asp:ListItem Value="">Selecione --</asp:ListItem>
                        <asp:ListItem Value="">Efetivado</asp:ListItem>
                        <asp:ListItem Value="">Pendente</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="clearfix"></div><br />
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" class="btnCadastro" style="float:none;"/>
                    <div class="clearfix"></div>
                </form>
            </div>
        </div>
    </center>
    <%
        Response.WriteFile("rodape.htm");
    %>
</body>
</html>

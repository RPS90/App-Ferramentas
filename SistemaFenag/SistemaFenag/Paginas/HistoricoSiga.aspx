<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoricoSiga.aspx.cs" Inherits="SistemaFenag.HistoricoSiga" %>

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
	        $("#txtInicioData").mask("99/99/9999");
	        $("#txtFinalData").mask("99/99/9999");
	    });	
	</script>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Visualizar Histórico do SIGA</h1>
            <div class="containerGrids">
                <br />
                <asp:Label ID="lblTituloPagamentos" runat="server" Text="Lançamentos" class="tituloInternoGrids"></asp:Label>
                <table border="1" style="margin-top:2%;">
                    <tr>
                        <td class="GridTables">Usuário</td>
                        <td class="GridTables">Data</td>
                        <td class="GridTables">Ação</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Alteração de dados do usuário X</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Cadastro do usuário X com permissão 1</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Cadastro do usuário Y com permissão 2</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Cadastro da AGECEF Z</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Alteração de dados da AGECEF Z</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Alteração no status de pagamento do usuário X</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Inativação do usuário Z</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">dd/mm/aaaa 00h00</td>
                        <td class="GridTables">Aprovação da Proposta X</td>
                    </tr>
                </table>
                <br />
            </div>
            <div class="formLogin">
                <form id="form1" runat="server">
                <asp:Label ID="lblAgecef" runat="server" Text="Agecef" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:DropDownList ID="dropAgecef" runat="server" class="txtLogin" required>
                            <asp:ListItem Value="">Selecione --</asp:ListItem>
                            <asp:ListItem Value="">AGECEF São Paulo</asp:ListItem>
                            <asp:ListItem Value="">AGECEF CP</asp:ListItem>
                    </asp:DropDownList>
                    <div class="clearfix"></div>
                    <br />
                    <asp:Label ID="lblData" runat="server" Text="Data" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:TextBox ID="txtInicioData" runat="server" placeholder="Da data" class="txtLoginPequeno" title="Digite a data que você deseja que o filtro inicie"></asp:TextBox>
                    <asp:TextBox ID="txtFinalData" runat="server" placeholder="Até a data" class="txtLoginPequeno" title="Digite a data que você deseja que o filtro finalize"></asp:TextBox>
                    <br />
                    <div class="clearfix">
                    <br />
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" class="btnCadastroInterno"/>
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

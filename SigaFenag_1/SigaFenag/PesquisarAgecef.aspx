<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PesquisarAgecef.aspx.cs" Inherits="SistemaFenag.PesquisarAgecef" %>

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
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Pesquisar Associados</h1>
            <br />
            <asp:Label ID="lblTituloPagamentos" runat="server" Text="AGECEF" class="tituloInternoGrids"></asp:Label>
            <div class="containerGrids">
                <table border="1" style="margin-top:2%;">
                    <tr>
                        <td class="GridTables">Nome da AGECEF</td>
                        <td class="GridTables">Número da entidade</td>
                        <td class="GridTables">Número da rubrica</td>
                        <td class="GridTables">Número da unidade</td>
                        <td class="GridTables">Endereço completo</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tipo da AGECEF</td>
                        <td class="GridTables">CNPJ</td>
                    </tr>
                    <tr>
                        <td class="GridTables">Nome da AGECEF pesquisada</td>
                        <td class="GridTables">Número da entidade da AGECEF pesquisada</td>
                        <td class="GridTables">Número da rubrica da AGECEF pesquisada</td>
                        <td class="GridTables">Número da unidade da AGECEF pesquisada</td>
                        <td class="GridTables">Endereço da AGECEF pesquisada</td>
                        <td class="GridTables">Status da AGECEF pesquisada</td>
                        <td class="GridTables">Tipo da AGECEF pesquisada</td>
                        <td class="GridTables">CNPJ da AGECEF pesquisada</td>
                    </tr>
                </table>
                <br />
            </div>
            <br />
            <asp:Label ID="lblTituloFiltros" runat="server" Text="Use a pesquisa para selecionar a AGECEF" class="tituloInternoGrids"></asp:Label>
            <br />
            <asp:Label ID="lblDescricaoFiltro" runat="server" Text="Escolha uma das AGECEF'S e clique em pesquisar" class="tituloInternoGrids"></asp:Label>
            <br />
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
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" class="btnCadastroInterno"/>
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

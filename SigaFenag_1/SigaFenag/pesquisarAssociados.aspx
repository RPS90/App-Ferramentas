<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pesquisarAssociados.aspx.cs" Inherits="SistemaFenag.pesquisarAssociados" %>

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
            <h1 class="tituloPaginaLogin">Pesquisar Associados</h1>
            <br />
            <asp:Label ID="lblTituloPagamentos" runat="server" Text="Associados" class="tituloInternoGrids"></asp:Label>
            <div class="containerGrids">
                <table border="1" style="margin-top:2%;">
                    <tr>
                        <td class="GridTables">Matrícula</td>
                        <td class="GridTables">Nome</td>
                        <td class="GridTables">RG</td>
                        <td class="GridTables">CPF</td>
                        <td class="GridTables">Data de Nascimento</td>
                        <td class="GridTables">Sexo</td>
                        <td class="GridTables">Estado civil</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tamanho da Camisa</td>
                        <td class="GridTables">Função</td>
                        <td class="GridTables">Telefone celular</td>
                        <td class="GridTables">Telefone comercial</td>
                        <td class="GridTables">Ramal do telefone</td>
                        <td class="GridTables">Telefone residencial</td>
                        <td class="GridTables">Preferência de contato</td>
                        <td class="GridTables">E-mail pessoal</td>
                        <td class="GridTables">E-mail CAIXA</td>
                        <td class="GridTables">Endereço</td>
                        <td class="GridTables">Nome do cônjugue</td>
                        <td class="GridTables">Superintendência</td>
                        <td class="GridTables">Conta do banco</td>
                        <td class="GridTables">Agência do banco</td>
                        <td class="GridTables">Local do banco</td>
                        <td class="GridTables">Operação do banco</td>
                        <td class="GridTables">Convênio REC FENAG</td>
                        <td class="GridTables">Outro convênios</td>
                        <td class="GridTables">Situação</td>
                        <td class="GridTables">Lotação</td>
                        <td class="GridTables">Nível de acesso</td>
                        <td class="GridTables">Data de cadastro</td>
                        <td class="GridTables">assinatura</td>
                    </tr>
                    <tr>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">00.000.000-0</td>
                        <td class="GridTables">000.000.000-00</td>
                        <td class="GridTables">dd/mm/aaaa</td>
                        <td class="GridTables">F/M</td>
                        <td class="GridTables">Estado civil atual</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tamanho X</td>
                        <td class="GridTables">Função do usuário na CAIXA</td>
                        <td class="GridTables">(99) 99999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">Ramal do telefone</td>
                        <td class="GridTables">Preferência de contato do usuário</td>
                        <td class="GridTables">email@email.com.br</td>
                        <td class="GridTables">email@caixa.sp.gov.br</td>
                        <td class="GridTables">Endereço completo, com número, bairro, cidade e estado</td>
                        <td class="GridTables">Nome do cônjugue do usuário</td>
                        <td class="GridTables">Superintendência do usuário</td>
                        <td class="GridTables">00000000-0</td>
                        <td class="GridTables">Agência do usuário</td>
                        <td class="GridTables">Endereço do banco</td>
                        <td class="GridTables">Operação da conta do usuário</td>
                        <td class="GridTables">Possui convênios FENAG RDC?</td>
                        <td class="GridTables">Possui outros convênios?</td>
                        <td class="GridTables">Atual situação</td>
                        <td class="GridTables">Lotação do usuário</td>
                        <td class="GridTables">Nível de acesso no SIGA</td>
                        <td class="GridTables">Data de efetivação do cadastro no SIGA</td>
                        <td class="GridTables">assinatura do usuário</td>
                    </tr>
                    <tr>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">00.000.000-0</td>
                        <td class="GridTables">000.000.000-00</td>
                        <td class="GridTables">dd/mm/aaaa</td>
                        <td class="GridTables">F/M</td>
                        <td class="GridTables">Estado civil atual</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tamanho X</td>
                        <td class="GridTables">Função do usuário na CAIXA</td>
                        <td class="GridTables">(99) 99999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">Ramal do telefone</td>
                        <td class="GridTables">Preferência de contato do usuário</td>
                        <td class="GridTables">email@email.com.br</td>
                        <td class="GridTables">email@caixa.sp.gov.br</td>
                        <td class="GridTables">Endereço completo, com número, bairro, cidade e estado</td>
                        <td class="GridTables">Nome do cônjugue do usuário</td>
                        <td class="GridTables">Superintendência do usuário</td>
                        <td class="GridTables">00000000-0</td>
                        <td class="GridTables">Agência do usuário</td>
                        <td class="GridTables">Endereço do banco</td>
                        <td class="GridTables">Operação da conta do usuário</td>
                        <td class="GridTables">Possui convênios FENAG RDC?</td>
                        <td class="GridTables">Possui outros convênios?</td>
                        <td class="GridTables">Atual situação</td>
                        <td class="GridTables">Lotação do usuário</td>
                        <td class="GridTables">Nível de acesso no SIGA</td>
                        <td class="GridTables">Data de efetivação do cadastro no SIGA</td>
                        <td class="GridTables">assinatura do usuário</td>
                    </tr>
                    <tr>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">00.000.000-0</td>
                        <td class="GridTables">000.000.000-00</td>
                        <td class="GridTables">dd/mm/aaaa</td>
                        <td class="GridTables">F/M</td>
                        <td class="GridTables">Estado civil atual</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tamanho X</td>
                        <td class="GridTables">Função do usuário na CAIXA</td>
                        <td class="GridTables">(99) 99999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">Ramal do telefone</td>
                        <td class="GridTables">Preferência de contato do usuário</td>
                        <td class="GridTables">email@email.com.br</td>
                        <td class="GridTables">email@caixa.sp.gov.br</td>
                        <td class="GridTables">Endereço completo, com número, bairro, cidade e estado</td>
                        <td class="GridTables">Nome do cônjugue do usuário</td>
                        <td class="GridTables">Superintendência do usuário</td>
                        <td class="GridTables">00000000-0</td>
                        <td class="GridTables">Agência do usuário</td>
                        <td class="GridTables">Endereço do banco</td>
                        <td class="GridTables">Operação da conta do usuário</td>
                        <td class="GridTables">Possui convênios FENAG RDC?</td>
                        <td class="GridTables">Possui outros convênios?</td>
                        <td class="GridTables">Atual situação</td>
                        <td class="GridTables">Lotação do usuário</td>
                        <td class="GridTables">Nível de acesso no SIGA</td>
                        <td class="GridTables">Data de efetivação do cadastro no SIGA</td>
                        <td class="GridTables">assinatura do usuário</td>
                    </tr>
                    <tr>
                        <td class="GridTables">000000-0</td>
                        <td class="GridTables">Nome completo do usuário</td>
                        <td class="GridTables">00.000.000-0</td>
                        <td class="GridTables">000.000.000-00</td>
                        <td class="GridTables">dd/mm/aaaa</td>
                        <td class="GridTables">F/M</td>
                        <td class="GridTables">Estado civil atual</td>
                        <td class="GridTables">Status</td>
                        <td class="GridTables">Tamanho X</td>
                        <td class="GridTables">Função do usuário na CAIXA</td>
                        <td class="GridTables">(99) 99999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">(99) 9999-9999</td>
                        <td class="GridTables">Ramal do telefone</td>
                        <td class="GridTables">Preferência de contato do usuário</td>
                        <td class="GridTables">email@email.com.br</td>
                        <td class="GridTables">email@caixa.sp.gov.br</td>
                        <td class="GridTables">Endereço completo, com número, bairro, cidade e estado</td>
                        <td class="GridTables">Nome do cônjugue do usuário</td>
                        <td class="GridTables">Superintendência do usuário</td>
                        <td class="GridTables">00000000-0</td>
                        <td class="GridTables">Agência do usuário</td>
                        <td class="GridTables">Endereço do banco</td>
                        <td class="GridTables">Operação da conta do usuário</td>
                        <td class="GridTables">Possui convênios FENAG RDC?</td>
                        <td class="GridTables">Possui outros convênios?</td>
                        <td class="GridTables">Atual situação</td>
                        <td class="GridTables">Lotação do usuário</td>
                        <td class="GridTables">Nível de acesso no SIGA</td>
                        <td class="GridTables">Data de efetivação do cadastro no SIGA</td>
                        <td class="GridTables">assinatura do usuário</td>
                    </tr>
                </table>
                <br />
            </div>
            <br />
            <asp:Label ID="lblTituloFiltros" runat="server" Text="Use os filtros para realizar pesquisar específicas" class="tituloInternoGrids"></asp:Label>
            <br />
            <asp:Label ID="lblDescricaoFiltro" runat="server" Text="Escolha apenas uma das opções, por AGECEF ou um usuário específico" class="tituloInternoGrids"></asp:Label>
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
                    <asp:Label ID="lblMatricula" runat="server" Text="Matrícula" class="nomesCamposForms"></asp:Label>
                    <div class="clearfix"></div><br />
                    <asp:TextBox ID="txtMatricula" runat="server" placeholder="Número de matrícula" class="txtLogin" style="float: none;"></asp:TextBox>
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

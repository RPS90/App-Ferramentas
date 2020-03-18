<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroAssociadoParte2.aspx.cs" Inherits="SistemaFenag.cadastroAssociadoParte2" %>

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
	        $("#txtMatriculaAssociado").mask("999999-9");
	        $("#txtData").mask("99/99/9999");


	    });
	</script>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Cadastro de Associados</h1>
            <div class="containerFormsPrincipais">
                <h2 class="TitulosPaginasCadastros">Dados Cadastrais</h2>
                <form id="form1" runat="server">
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblMatriculaAssociado" runat="server" Text="Matrícula: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtMatriculaAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblLoginAssociado" runat="server" Text="Login: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtLoginAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblSenhaAssociado" runat="server" type="password" Text="Senha: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtSenhaAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEmailAssociado" runat="server" Text="E-mail CAIXA: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEmailAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblTamanhoCamisaAssociado" runat="server" Text="Tam. da Camisa: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtTamanhoCamisaAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblLotacaoAssociado" runat="server" Text="Lotação: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtLotacaoAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblFuncaoAssociado" runat="server" Text="Função: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtFuncaoAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblSituacaoAssociado" runat="server" Text="Situação: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtSituacaoAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="clearfix"></div><br /><br />
                    <hr style="width: 90%;"/>
                    <div class="clearfix"></div>
                    <h3 class="TitulosPaginasCadastros">Dados CAIXA</h3>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblSuperintendenciaAssociado" runat="server" Text="Superintendência: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtSuperintendenciaAssociado" runat="server" class="CamposForms" required></asp:TextBox><br /><br />
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblConta" runat="server" Text="Conta: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtConta" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblAgencia" runat="server" Text="Agência: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtAgencia" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblLocal" runat="server" Text="Local:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtLocal" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblData" runat="server" Text="Complemento: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtData" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblOperacao" runat="server" Text="Operação: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtOperacao" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblAssinatura" runat="server" Text="Assinatura: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtAssinatura" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblConvenio" runat="server" Text="Possui convênio com FENAG FÉRIAS ou RDC: *" class="lblNomeTextBox"></asp:Label>
                        <asp:DropDownList ID="dropConvenioRdcouFenag" runat="server" class="CamposForms" required>
                            <asp:ListItem Value="sim">Sim</asp:ListItem>
                            <asp:ListItem Value="nao">Não</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblOutroConvenio" runat="server" Text="Possui outros Convênios? Quais: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtConvenioRdcFenag" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <asp:Button ID="btnProsseguir" runat="server" Text="Cadastrar" class="btnCadastroInterno"/>
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

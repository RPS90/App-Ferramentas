<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alterarAssociadoParte2.aspx.cs" Inherits="SistemaFenag.alterarAssociadoParte2" %>

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
	        $("#txtCpf").mask("999.999.999-99");
	        $("#txtCep").mask("99999-999");
	        $("#txtDataNascimentoAssociado").mask("99/99/9999");
	        $("#txtCelular").mask("(99) 99999-9999");

	    });	
	</script>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Alterar Associados</h1>
            <div class="containerFormsPrincipais">
                <h2 class="TitulosPaginasCadastros">Dados Pessoais</h2>
                <form id="form1" runat="server">
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNomeAssociado" runat="server" Text="Nome: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNomeAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEmailAssociado" runat="server" Text="E-mail: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEmailAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblCpf" runat="server" Text="CPF: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtCpf" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblRgAssociado" runat="server" Text="Rg: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtRgAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblOrgaoEmissorAssociado" runat="server" Text="Orgão Emissor: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtOrgaoEmissorAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblSexoAssociado" runat="server" Text="Sexo: *" class="lblNomeTextBox"></asp:Label>
                        <asp:DropDownList ID="dropSexoAssociado" runat="server" class="CamposForms" required>
                            <asp:ListItem Value="Feminino">Feminino</asp:ListItem>
                            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblDataNascimentoAssociado" runat="server" Text="Data nasc.: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtDataNascimentoAssociado" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEstadoCivil" runat="server" Text="Estado civil: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEstadoCivil" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNomeConjuge" runat="server" Text="Nome cônjuge: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNomeConjuge" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <hr style="width: 90%;"/>
                    <h3 class="TitulosPaginasCadastros">Dados Presenciais</h3>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblCep" runat="server" Text="Cep: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtCep" runat="server" class="CamposForms" required></asp:TextBox><br /><br />
                        <a href="http://www.buscacep.correios.com.br/sistemas/buscacep/" target="_blank"><asp:Label ID="lblPesquisaCep" runat="server" Text="Não sei o meu cep" class="lblNomeTextBox" style="color:#ff0000;font-size:12px;"></asp:Label></a>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEndereco" runat="server" Text="Endereço: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEndereco" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNumeroEndereco" runat="server" Text="Número: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNumeroEndereco" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblComplemento" runat="server" Text="Complemento: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtComplemento" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblMunicipio" runat="server" Text="Município: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtMunicipio" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado: *" class="lblNomeTextBox"></asp:Label>
                        <asp:DropDownList ID="dropEstado" runat="server" class="CamposForms" required>
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
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblTelefone1" runat="server" Text="Telefone: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtTelefone1" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblTelefoneComercial" runat="server" Text="Telefone comer.: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtTelefoneComercial" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblRamal1" runat="server" Text="Ramal:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtRamal1" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblCelular" runat="server" Text="Celular: *" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtCelular" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <asp:Button ID="btnProsseguir" runat="server" Text="Prosseguir" class="btnCadastroInterno"/>
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

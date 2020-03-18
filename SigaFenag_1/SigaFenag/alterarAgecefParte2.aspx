<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alterarAgecefParte2.aspx.cs" Inherits="SistemaFenag.alterarAgecefParte2" %>

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
	        $("#txtCpnj").mask("99.999.999/9999-99");
	        $("#txtCep").mask("99999-999");
	    });	
	</script>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">Alterar informações das AGECEF'S</h1>
            <div class="containerFormsPrincipais">
                <h2 class="TitulosPaginasCadastros">Dados da AGECEF</h2>
                <form id="form1" runat="server">
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblStatus" runat="server" Text="Status: *" class="lblNomeTextBox"></asp:Label>
                        <asp:DropDownList ID="dropStatus" runat="server" class="CamposForms" required>
                            <asp:ListItem Value="Ativo">Ativo</asp:ListItem>
                            <asp:ListItem Value="Inativo">Inativo</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblTipoAgecef" runat="server" Text="Tipo: *" class="lblNomeTextBox"></asp:Label>
                        <asp:DropDownList ID="dropTipoAgecef" runat="server" class="CamposForms" required>
                            <asp:ListItem Value="Estadual">Estadual</asp:ListItem>
                            <asp:ListItem Value="Regional">Regional</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblCnpjAgecef" runat="server" Text="CNPJ:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtCpnj" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblPresidente" runat="server" Text="Presidente:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtPresidente" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblUnidade" runat="server" Text="Unidade:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtUnidade" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNumeroUnidade" runat="server" Text="Número:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNumeroUnidade" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEntidade" runat="server" Text="Entidade:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEntidade" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNumeroEntidade" runat="server" Text="Número:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNumeroEntidade" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblRubrica" runat="server" Text="Rubrica" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtRubrica" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNumeroRubrica" runat="server" Text="Número:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNumeroRubrica" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEmail" runat="server" Text="E-mail:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <hr style="width: 90%;"/>
                    <h3 class="TitulosPaginasCadastros">Dados de Endereço</h3>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblCep" runat="server" Text="Cep:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtCep" runat="server" class="CamposForms" required></asp:TextBox><br /><br />
                        <a href="http://www.buscacep.correios.com.br/sistemas/buscacep/" target="_blank"><asp:Label ID="lblPesquisaCep" runat="server" Text="Não sei o meu cep" class="lblNomeTextBox" style="color:#ff0000;font-size:12px;"></asp:Label></a>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEndereco" runat="server" Text="Endereço:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtEndereco" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblNumeroEndereco" runat="server" Text="Número:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtNumeroEndereco" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblComplemento" runat="server" Text="Complemento:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtComplemento" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblMunicipio" runat="server" Text="Município:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtMunicipio" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado:" class="lblNomeTextBox"></asp:Label>
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
                        <asp:Label ID="lblTelefone1" runat="server" Text="Telefone 1:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtTelefone1" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblRamal1" runat="server" Text="Ramal:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtRamal1" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblTelefone2" runat="server" Text="Telefone 2:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtTelefone2" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfixMobile"></div>
                    <div class="BlocosFormsCadastro">
                        <asp:Label ID="lblRamal2" runat="server" Text="Ramal 2:" class="lblNomeTextBox"></asp:Label>
                        <asp:TextBox ID="txtRamal2" runat="server" class="CamposForms" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div><br /><br />
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btnCadastroInterno"/>
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

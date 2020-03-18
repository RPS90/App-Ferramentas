<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarInformacoesClientes.aspx.cs" Inherits="SGVersaoBeta.ConsultarInformacoesClientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Versão Beta - Sistema de Gerenciamento</title>
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	<link rel="icon" href="homeicon.png">
	<meta charset="utf-8">
	<meta name="author" content="Mike Ewerthon de Figueiredo Silva" />
	<link rel="stylesheet" href="css/libs/animate.css">
  	<link rel="stylesheet" href="css/site.css">
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
	<script src="js/script.js"></script>
   <script src="js/jquery-1.5.2.min.js"></script>
   <style>.wow:first-child {visibility: hidden;}</style>
   <script src="js/jquery.maskedinput-1.3.min.js"></script>
</head>
<body>
     <div class="container-topo">
	<!-- Menu do projeto -->
	    <%         
            Response.WriteFile("menu.htm");
        %>
	<!-- Fim do Menu do Projeto -->
	</div>
	<div class="clearfix"></div>
    <br/><br/>
	<img src="slides/gerenciamento-dos-clientes.png" class="banner-interno">
    <center>
        <br /><br />
        <asp:Label ID="lblRespostaServer" runat="server" Text="" style="margin-top: 3%; text-align: center; color: #ff0000; padding-bottom: 2%; font-size: 22px; font-family: 'Tahoma';"></asp:Label>
        <br /><br />
        <!--Início do conteúdo -->
        <div class="container-formularios" style="height: auto; min-height: 1000px;">
            <h1 class="titulos-paginas-internas"><u>Consulte informações sobre clientes</u></h1>
            <div class="clearfix"></div>
            <form id="form1" runat="server">
                <div class="bloco-grande-form">
				    <span class="nome-input-formularios">Escolha o cliente: <span style="color: #ff0000;">*</span></span><br>
                    <asp:DropDownList ID="dropNomeCliente" runat="server" class="input-formularios" required="required"></asp:DropDownList>
				</div>
				<div class="clearfix"></div>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    class="botao-form-home" style="float: none; margin-right: 0%;" 
                    onclick="btnConsultar_Click"/>
			    <div class="clearfix"></div>
                <br /><br />
                <p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Informações do cliente</p>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Nome do Cliente:<br>
                            <asp:Label ID="lblNomeCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Número do Celular:<br>
                            <asp:Label ID="lblNumeroCelularCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">CEP:<br>
                            <asp:Label ID="lblCepCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Endereço:<br><!--Trazer do banco todos os campos que complementam o endereço-->
                            <asp:Label ID="lblEnderecoCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Host FTP:<br>
                            <asp:Label ID="lblHostFtp" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Usuário FTP:<br>
                            <asp:Label ID="lblUsuarioFtp" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Senha do FTP:<br>
                            <asp:Label ID="lblSenhaFtp" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Link do Painel de controle:<br>
                            <asp:Label ID="lblLinkPainelControle" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Login do Painel de controle:<br>
                            <asp:Label ID="lblLoginPainelControle" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Senha do Painel de controle:<br>
                            <asp:Label ID="lblSenhaPainelControle" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">E-mail do cliente:<br>
                            <asp:Label ID="lblEmailCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Domínio do cliente:<br>
                            <asp:Label ID="lblDominioCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Status do cliente:<br>
                            <asp:Label ID="lblStatusCliente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="clearfix"></div>
                    <br /><br />
            </form>
        </div>
    </center>
    <div class="clearfix"></div>
	<!-- Fim do conteúdo-->
	<!-- Início do Rodapé -->
		<%
            Response.WriteFile("rodape.htm");
	    %>
	<!-- Fim do Rodapé -->
	<script src="dist/wow.js"></script>		
	<script>
	    wow = new WOW(
		{
		    animateClass: 'animated',
		    offset: 100,
		    callback: function (box) {
		        console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
		    }
		}
		);
	    wow.init();
	    document.getElementById('moar').onclick = function () {
	        var section = document.createElement('section');
	        section.className = 'section--purple wow fadeInDown';
	        this.parentNode.insertBefore(section, this);
	    };
	</script>
</body>
</html>

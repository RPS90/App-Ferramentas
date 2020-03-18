<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SGVersaoBeta.index" %>

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
	<script src="js/script.js"></script>
   <script src="js/jquery-1.5.2.min.js"></script>
   <style>.wow:first-child {visibility: hidden;}</style>
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
    <%         
        Response.WriteFile("slide.htm");
    %>
    <br />
    <asp:Label ID="lblNomeLogin" runat="server" Text="" class="nome-input-formularios"></asp:Label>
    <br />
    <div class="clearfix"></div>
	<!-- Conteúdo da Home -->
		<div class="blocos-icones-home"><center>
			<a href="cadastrarProjeto.aspx"><img src="img/icone-criar-novo-projeto.jpg" id="icones-home" class="wow tada" data-wow-delay="0.3s"></a></center>
			<p class="titulo-icones-home">Criar um novo projeto</p>
		</div>
		<div class="blocos-icones-home"><center>
			<a href="cadastroMembroEquipe.aspx"><img src="img/icone-gerencia-colaborativa.jpg" id="icones-home" class="wow tada" data-wow-delay="0.6s"></a></center>
			<p class="titulo-icones-home">Cadastrar um membro</p>
		</div>
		<div class="blocos-icones-home"><center>
			<a href=""><img src="img/icone-manual-do-usuario.jpg" id="icones-home" class="wow tada" data-wow-delay="0.9s"></a></center>
			<p class="titulo-icones-home">Visualizar Sugestões</p>
		</div>
		<div class="clearfix"></div>
		<div id="blocos-finais-home" class="wow bounceIn" data-wow-delay="0.3s">
			<p class="titulo-blocos-finais-home">Pesquisar contato de um cliente:</p>
			<form id="form1" runat="server">
                <asp:DropDownList ID="dropInformacoesClientes" runat="server" class="select-form-home"></asp:DropDownList>
                <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" 
                    class="botao-form-home" onclick="btnPesquisar_Click"/>
			</form>
		</div>
		<div id="blocos-finais-home" class="wow bounceIn" data-wow-delay="0.6s">
			<p class="titulo-blocos-finais-home">Dados do cliente:</p>
			<p class="texto-blocos-finais-home">E-mail: <asp:Label class="texto-blocos-finais-home" style="color: #ff0000;" ID="lblEmail" runat="server" Text=""></asp:Label></p> 
			<p class="texto-blocos-finais-home">Celular: <asp:Label class="texto-blocos-finais-home" style="color: #ff0000;" ID="lblCelular" runat="server" Text=""></asp:Label></p>
			<p class="texto-blocos-finais-home">CEP: <asp:Label class="texto-blocos-finais-home" style="color: #ff0000;" ID="lblCEP" runat="server" Text=""></asp:Label></p>
		</div>
		<div class="clearfix"></div>
	<!-- Fim do conteúdo da Home -->
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="painelClientes.aspx.cs" Inherits="SGVersaoBeta.painelClientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Versão Beta - Sistema de Gerenciamento<</title>
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
	<br><br>
	<img src="slides/gerenciamento-dos-clientes.png" class="banner-interno">
	<!-- Conteúdo da Home -->
        <div class="blocos-icones-quatro"><center>
			<a href="cadastrarCliente.aspx"><img src="img/botao-cadastrar-cliente.png" id="icones-home" class="wow tada" data-wow-delay="0.6s"></a></center>
			<p class="titulo-icones-home-quatro">Cadastrar um novo cliente</p>
		</div>
        <div class="blocos-icones-quatro"><center>
			<a href="ConsultarInformacoesClientes.aspx"><img src="img/consultar-cliente.png" id="icones-home" class="wow tada" data-wow-delay="1.2s"></a></center>
			<p class="titulo-icones-home-quatro">Consultar dados de um cliente</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="AlterarInformacoesClientes.aspx"><img src="img/botao-alterar-dados-de-um-cliente.png" id="icones-home" class="wow tada" data-wow-delay="0.3s"></a></center>
			<p class="titulo-icones-home-quatro">Alterar dados do cliente</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="InativarCliente.aspx"><img src="img/botao-congelar-cliente.png" id="icones-home" class="wow tada" data-wow-delay="0.9s"></a></center>
			<p class="titulo-icones-home-quatro">Inativar um cliente</p>
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

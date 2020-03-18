<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="painelProjetos.aspx.cs" Inherits="SGVersaoBeta.painelProjetos" %>

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
	<br><br>
	<img src="slides/gestao-dos-projetos.png" class="banner-interno">
	<!-- Conteúdo da Home -->
		<div class="blocos-icones-quatro"><center>
			<a href="cadastrarProjeto.aspx"><img src="img/botao-cadastrar-novo-projeto.png" id="icones-home" class="wow tada" data-wow-delay="0.3s"></a></center>
			<p class="titulo-icones-home-quatro">Cadastrar novo projeto</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="enviarrelatorioProjetos.aspx"><img src="img/botao-enviar-portifolio.png" id="icones-home" class="wow tada" data-wow-delay="0.6s"></a></center>
			<p class="titulo-icones-home-quatro">Enviar um relatório</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="ConsultarDadosProjetos.aspx"><img src="img/botao-consultar-dados.png" id="icones-home" class="wow tada" data-wow-delay="0.6s"></a></center>
			<p class="titulo-icones-home-quatro">Consultar dados</p>
		</div>
        <div class="blocos-icones-quatro"><center>
			<a href="FinalizarProjetos.aspx"><img src="img/botao-finalizar-projeto.png" id="icones-home" class="wow tada" data-wow-delay="0.3s"></a></center>
			<p class="titulo-icones-home-quatro">Finalizar um projeto</p>
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

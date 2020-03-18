<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerenciarEquipe.aspx.cs" Inherits="SGVersaoBeta.gerenciarEquipe" %>

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
	<img src="slides/equipe.png" class="banner-interno">
	<!-- Conteúdo da Home -->
        <div class="blocos-icones-quatro"><center>
			<a href="cadastroMembroEquipe.aspx"><img src="img/btn-cadastrar-membro-equipe.png" id="icones-home" class="wow tada" data-wow-delay="0.3s"></a></center>
			<p class="titulo-icones-home-quatro">Cadastrar um <br />membro na equipe</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="ConsultarMembroEquipe.aspx"><img src="img/btn-pesquisar-membro-equipe.png" id="icones-home" class="wow tada" data-wow-delay="0.6s"></a></center>
			<p class="titulo-icones-home-quatro">Pesquisar um <br />membro da equipe</p>
		</div>
        <div class="blocos-icones-quatro"><center>
			<a href="AlterarMembroEquipe.aspx"><img src="img/btn-alterar-membro-equipe.png" id="icones-home" class="wow tada" data-wow-delay="0.9s"></a></center>
			<p class="titulo-icones-home-quatro">Alterar um <br />membro da equipe</p>
		</div>
		<div class="blocos-icones-quatro"><center>
			<a href="InativarMembroEquipe.aspx"><img src="img/btn-excluir-membro-equipe.png" id="icones-home" class="wow tada" data-wow-delay="1.2s"></a></center>
			<p class="titulo-icones-home-quatro">Desativar um <br />membro da equipe</p>
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
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enviarrelatorioProjetos.aspx.cs" Inherits="SGVersaoBeta.enviarrelatorioProjetos" %>

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
    <br />
    <center>
    <asp:Label ID="lblRespostaServer" runat="server" Text="" style="color: #ff0000; margin-top: 2%; padding-bottom: 2%; font-family:'Tahoma';text-align:center;"></asp:Label>
    </center>
    <br /><br />
	<!-- Conteúdo da Home -->
		<center>
			<div class="container-formularios">	
				<h1 class="titulos-paginas-internas"><u>Enviar relatório de um projeto</u></h1>
				<!--<p class="nome-input-formularios"><u></u></p>-->
				<div class="clearfix"></div>
				<form id="form1" runat="server"  style="padding-bottom: 3%;">
					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Prencha todos os campos</p>
					<div class="bloco-medio-form" style="float: none; margin-left: 0%;">
						<span class="nome-input-formularios">O relatório pertence a qual projeto?<span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="dropProjetos" runat="server" class="input-formularios" required="required"></asp:DropDownList>
					</div>
					<div class="clearfix"></div>
					<div class="bloco-grande-form">
						<span class="nome-input-formularios">Cole o texto aqui:</span><br>
                        <asp:TextBox ID="txtRelatorio" runat="server" class="input-formularios" required="required" placeholder="Digite o relatório:" style="height: 300px;"></asp:TextBox>
					</div>
					<br><br>
                    <asp:Button ID="btnEnviarRelatorio" runat="server" Text="Enviar" 
                        class="botao-form-home" onclick="btnEnviarRelatorio_Click"/>
					<div class="clearfix"></div>
					<br>
				</form>
			</div>
		</center>
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

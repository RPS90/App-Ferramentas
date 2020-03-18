<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SGVersaoBeta.WebForm1" %>

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
    <!--Conteúdo do login -->
		<img src="img/banner-pagina-login2.jpg" id="banner-login">
		<img src="img/logotipo-fatec.png" class="wow slideInLeft" data-wow-delay="0.4s" id="logotipo-fatec-interno">
		<div class="container-login">
			<center>
				<img src="img/logotipo-articulando-comunicacao.jpg" id="logotipo-artc-login" class="wow bounceIn" data-wow-delay="0.6s">
				<form id="form1" runat="server">
                    <asp:TextBox ID="txtLogin" class="input-login" placeholder="E-mail ou usuário:" required runat="server"></asp:TextBox>	
                    <asp:TextBox ID="txtSenha" type="password" class="input-login" placeholder="Senha:" required runat="server"></asp:TextBox>
                    <div class="clearfix"></div>
                    <br /><br />	
                    <asp:Label ID="lblRespostaLogin" runat="server" style="color: #ff0000;margin-top:1%;padding-bottom:1%;"></asp:Label>
                    <asp:Button ID="btnLogar" class="botao-form-home" style="margin-top: 9%; margin-right: 15%;" runat="server" Text="Logar" 
                        onclick="btnLogar_Click" />
				</form>
			</center>
		</div>
	<!-- Fim do conteúdo do Login -->
    <%         
        Response.WriteFile("rodape.htm");
    %>
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

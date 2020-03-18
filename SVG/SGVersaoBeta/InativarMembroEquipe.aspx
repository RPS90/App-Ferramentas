<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InativarMembroEquipe.aspx.cs" Inherits="SGVersaoBeta.InativarMembroEquipe" %>

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
    <br />
    <center>
    <asp:Label ID="lblRespostaServer" runat="server" Text="" style="color: #ff0000; margin-top: 2%; padding-bottom: 2%; font-family:'Tahoma';text-align:center;"></asp:Label>
    </center>
    <br /><br />
	<!-- Conteúdo da Home -->
    <center>
		<div class="container-formularios">	
		    <h1 class="titulos-paginas-internas"><u>Selecione o colaborador que será inativado.</u></h1>
            <form id="form1" runat="server">
            <div class="bloco-grande-form" style="float: none; margin-left: 0%;">
		        <span class="nome-input-formularios">Colaborador: <span style="color: #ff0000;">*</span></span><br>
                <asp:DropDownList ID="dropInativarColaborador" runat="server" class="input-formularios" required="required"></asp:DropDownList>
                 <br /><br />
			</div>
            <asp:Button ID="btnInativarColaborador" runat="server" Text="Inativar" 
                class="botao-form-home" onclick="btnInativarColaborador_Click"/>
            </form>
			<div class="clearfix"></div>
            <br /><br />
        </div>
    </center>
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

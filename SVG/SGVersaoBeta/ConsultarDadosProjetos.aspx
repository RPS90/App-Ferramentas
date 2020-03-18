<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarDadosProjetos.aspx.cs" Inherits="SGVersaoBeta.ConsultarDadosProjetos" %>

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
	<script src="js/jquery.maskedinput-1.3.min.js"></script>
   <style>.wow:first-child {visibility: hidden;}</style>
	<script>
	    jQuery(function ($) {
	        $("#celular").mask("(99) 99999-9999");
	        $("#txtDataInicio").mask("99/99/9999");
	        $("#txtDataFim").mask("99/99/9999");

	    });	
	</script>
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
    <br />
    <center>
    <asp:Label ID="lblRespostaServer" runat="server" Text="" style="color: #ff0000; margin-top: 2%; padding-bottom: 2%; font-family:'Tahoma';text-align:center;"></asp:Label>
    </center>
    <div class="clearfix"></div>
	<br><br>
	<!-- Conteúdo da Home -->
		<center>
			<div class="container-formularios">	
				<h1 class="titulos-paginas-internas"><u>Consulte informações sobre projetos</u></h1>
				<div class="clearfix"></div>
				<form style="padding-bottom: 3%;" id="form1" runat="server">
					<div class="bloco-grande-form">
						<span class="nome-input-formularios">Selecione o Projeto: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="dropNomeProjetos" class="input-formularios" required="required" runat="server"></asp:DropDownList>
					</div>
					<div class="clearfix"></div>
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                        class="botao-form-home" style="float: none; margin-right: 0%;" onclick="btnConsultar_Click" 
                        />
					<div class="clearfix"></div>
				</form>
				<div style="padding-bottom: 3%;">
					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados do projeto</p>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Nome do projeto:<br>
                            <asp:Label ID="lblNomeProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Descrição do projeto:<br>
                             <asp:Label ID="lblDescricaoProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Data de início:<br>
                            <asp:Label ID="lblDataInicioProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Data de entrega:<br>
                             <asp:Label ID="lblDataEntregaProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Projeto desenvolvido para:<br>
						    <asp:Label ID="lblNomeClienteProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
                    </div>
					<div class="bloco-medio-form">
                        <span class="nome-input-formularios">Tipo de projeto:<br>
						    <asp:Label ID="lblTipoProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Status:<br>
						    <asp:Label ID="lblStatusProjetos" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Setor:<br>
						    <asp:Label ID="lblSetorProjeto" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Redator do relatório:<br>
                            <asp:Label ID="lblRedatorRelatorio" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Último relatório:<br>
                             <asp:Label ID="lblUltimorelatorio" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
					<div class="clearfix"></div>
					<br>
				</div>
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

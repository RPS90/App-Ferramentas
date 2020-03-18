<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarProjeto.aspx.cs" Inherits="SGVersaoBeta.cadastrarProjeto" %>

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
	<img src="slides/gestao-dos-projetos.png" class="banner-interno">
     <center>
    <br />
      <asp:Label ID="lblRespostaServer" runat="server" Text="" style="text-align: center;color: #ff0000; margin-top: 2%; padding-bottom: 2%;font-family: 'Tahoma';font-size:19px;"></asp:Label>
      <br /><br /><br /></center>
	<!-- Conteúdo da Home -->
		<center>
			<div class="container-formularios">	
              
				<h1 class="titulos-paginas-internas"><u>Cadastre um novo projeto no sistema</u></h1>
				<p class="nome-input-formularios"><u>Campos com o <span style="color: #ff0000;">*</span> são obrigatórios</u></p>
				<div class="clearfix"></div>
				<form id="form1" runat="server" style="padding-bottom: 3%;">

					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados do projeto</p>

					<div class="bloco-grande-form">
						<span class="nome-input-formularios">Nome do projeto: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtNome" runat="server" class="input-formularios" required="required" placeholder="Digite o nome do projeto:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Data de início: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtDataInicio" runat="server" class="input-formularios" required="required" placeholder="Informe a data:"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
                        <span class="nome-input-formularios">Data de entrega:</span><br>
                        <asp:TextBox ID="txtDataFim" runat="server" class="input-formularios" placeholder="Informe a data de entrega:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Para qual cliente é o projeto? <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="nomeCliente" runat="server" class="input-formularios" required="required"></asp:DropDownList>

					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Tipo de projeto: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="tipoProjeto" runat="server" class="input-formularios" required="required">
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="Pequeno">Pequeno</asp:ListItem>
                            <asp:ListItem Value="Médio">Médio</asp:ListItem>
                            <asp:ListItem Value="Grande">Grande</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Status: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="statusProjeto" runat="server" class="input-formularios" required="required">
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="Pendente">Pendente</asp:ListItem>
                            <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios" style="margin-left: 0%;">Setor: <span style="color: #ff0000;">*</span></span><br>
						<asp:DropDownList ID="setorProjeto" runat="server" class="input-formularios" required="required">
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="TI">TI</asp:ListItem>
                            <asp:ListItem Value="Jornalismo">Jornalismo</asp:ListItem>
                            <asp:ListItem Value="Design">Design</asp:ListItem>
                            <asp:ListItem Value="Gerência">Gerência</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Descrição do projeto: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="descricaoProjeto" runat="server" class="input-formularios" required="required" placeholder="Escreva uma breve descrição para o projeto:" style="height: 120px;"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Relatório:</span><br>
                        <asp:TextBox ID="relatorioProjeto" runat="server" class="input-formularios" placeholder="Digite o relatório:" style="height: 120px;"></asp:TextBox>
					</div>
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" 
                        class="botao-form-home" onclick="btnCadastrar_Click"/>
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

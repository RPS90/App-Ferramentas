<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarMembroEquipe.aspx.cs" Inherits="SGVersaoBeta.ConsultarMembroEquipe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <br /><br />
	<!-- Conteúdo da Home -->
		<center>
			<div class="container-formularios">	
				<h1 class="titulos-paginas-internas"><u>Consulte informações sobre os colaboradores</u></h1>
				<div class="clearfix"></div>
				<form style="padding-bottom: 3%;" id="form1" runat="server">

					<div class="bloco-grande-form">
						<span class="nome-input-formularios">Selecione o colaborador:</span><br>
                        <asp:DropDownList ID="dropNomeMembro" class="input-formularios" required="required" runat="server"></asp:DropDownList>
					</div>
					<div class="clearfix"></div>
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                        class="botao-form-home" style="float: none; margin-right: 0%;" 
                        onclick="btnConsultar_Click"/>
					<div class="clearfix"></div>
				</form>

				<div style="padding-bottom: 3%;">

					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados profissionais</p>

					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Nome do colaborador:<br>
                            <asp:Label ID="lblNomeColaborador" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Setor em que atua:<br>
                            <asp:Label ID="lblSetor" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Cargo que ocupa:<br>
                             <asp:Label ID="lblCargo" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Nível Empresarial:<br>
                            <asp:Label ID="lblNivelEmpresarial" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Expediente:<br>
                             <asp:Label ID="lblExpediente" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <br><br>
					<div class="clearfix"></div>
					<hr class="linha-divisoria-conteudo" />
                    <br /><br />
                    <p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados de acesso</p>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">E-mail:<br>
						    <asp:Label ID="lblEmail" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
                    </div>
                    <div class="bloco-medio-form">
                        <span class="nome-input-formularios">Número do celular:<br>
						    <asp:Label ID="lblNumeroCelular" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Login:<br>
						    <asp:Label ID="lblLogin" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Status do colaborador:<br>
						    <asp:Label ID="lblStatusColaborador" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <br><br>
					<div class="clearfix"></div>
					<hr class="linha-divisoria-conteudo" />
                    <br /><br />
                    <p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados pessoais</p>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">CEP:<br>
						    <asp:Label ID="lblCep" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Endereço:<br>
                            <asp:Label ID="lblEndereco" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Bairro:<br>
                            <asp:Label ID="lblBairro" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Cidade:<br>
                            <asp:Label ID="lblCidade" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
                        </span>
					</div>
                    <div class="bloco-medio-form">
						<span class="nome-input-formularios">Estado:<br>
                            <asp:Label ID="lblEstado" class="lblInformacoesProjetos" runat="server" Text="Consulte para visualizar"></asp:Label>
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

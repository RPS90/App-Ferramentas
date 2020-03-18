<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarMembroEquipe.aspx.cs" Inherits="SGVersaoBeta.AlterarMembroEquipe" %>

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
	        $("#txtCelular").mask("(99) 99999-9999");
	        $("#txtCep").mask("99999-999");

	    });	
	</script>
	<script type="text/javascript">
	    function MostrarSenha() {
	        if (document.getElementById("txtSenha").type == "password") {
	            document.getElementById("txtSenha").type = "text";
	        }
	        else {
	            document.getElementById("txtSenha").type = "password";
            }

	    }
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
    <br /><center>
    <asp:Label ID="lblRespostaServer" runat="server" Text="" style="color:#ff0000;font-size:18px;font-weight:bold;padding-bottom:3%; text-align: center;font-family:'Tahoma';"></asp:Label>
    </center>
    <div class="clearfix"></div>
	<br><br>
	<!-- Conteúdo da Home -->
		<center>
			<div class="container-formularios">	
				<h1 class="titulos-paginas-internas"><u>Alterar dados de um membro no sistema</u></h1>
                <p class="nome-input-formularios"><u>Campos com o <span style="color: #ff0000;">*</span> são obrigatórios</u></p>
				<div class="clearfix"></div>
				<form id="form1" runat="server" style="padding-bottom: 3%;">
                    <div class="bloco-grande-form">
						<span class="nome-input-formularios">Selecione o Colaborador: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="dropNomeColaborador" class="input-formularios" required="required" runat="server"></asp:DropDownList>
					</div>
					<div class="clearfix"></div>
                    <asp:Button ID="btnConsultar" runat="server" Text="Selecionar" 
                        class="botao-form-home" style="float: none; margin-right: 0%;" 
                        onclick="btnConsultar_Click"/>
					<div class="clearfix"></div>
                    <br /><br />
					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados profissionais</p>
					<div class="bloco-grande-form">
						<span class="nome-input-formularios">Nome: <span style="color: #ff0000;">*</span>
                        </span><br>
                        <asp:TextBox ID="txtNome" runat="server" class="input-formularios" placeholder="Digite o nome do novo membro:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios" style="margin-left: 0%;">Setor: <span style="color: #ff0000;">*</span></span><br>
						 <asp:DropDownList ID="dropSetor" runat="server" class="input-formularios" >
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="TI">TI</asp:ListItem>
                            <asp:ListItem Value="Jornalismo">Jornalismo</asp:ListItem>
                            <asp:ListItem Value="Design">Design</asp:ListItem>
                            <asp:ListItem Value="Gerência">Gerência</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Cargo: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtCargo" runat="server" class="input-formularios" placeholder="Informe o cargo:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios" style="margin-left: 0%;">Nível Empresarial: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="dropNivelEmpresarial" runat="server" class="input-formularios">
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="Estratégico">Estratégico</asp:ListItem>
                            <asp:ListItem Value="Tático">Tático</asp:ListItem>
                            <asp:ListItem Value="Operacional">Operacional</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Expediente: <span style="color: #ff0000;">*</span></span><br>
                        <asp:DropDownList ID="dropExpediente" runat="server" class="input-formularios">
                            <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                            <asp:ListItem Value="Período integral">Período integral</asp:ListItem>
                            <asp:ListItem Value="Meio Período">Meio Período</asp:ListItem>
                            <asp:ListItem Value="Parcial Manhãs">Parcial Manhãs</asp:ListItem>
                            <asp:ListItem Value="Parcial Tardes">Parcial Tardes</asp:ListItem>
                            <asp:ListItem Value="Home Office">Home Office</asp:ListItem>
                        </asp:DropDownList>
					</div>
					<br><br>
					<div class="clearfix"></div>
					<hr class="linha-divisoria-conteudo" />
					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados de acesso</p>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">E-mail: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtEmail" runat="server" class="input-formularios" placeholder="Digite o e-mail do novo membro:"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Celular: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtCelular" runat="server" class="input-formularios" placeholder="Digite o número do celular:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Login do usuário: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtLogin" runat="server" class="input-formularios" placeholder="Digite o login que será usado:"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Senha do usuário: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtSenha" type="password" runat="server" class="input-formularios" placeholder="Digite a senha que será usada:"></asp:TextBox>
						<img style="cursor: pointer;" title="Exibir a senha" id="olho" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABDUlEQVQ4jd2SvW3DMBBGbwQVKlyo4BGC4FKFS4+TATKCNxAggkeoSpHSRQbwAB7AA7hQoUKFLH6E2qQQHfgHdpo0yQHX8T3exyPR/ytlQ8kOhgV7FvSx9+xglA3lM3DBgh0LPn/onbJhcQ0bv2SHlgVgQa/suFHVkCg7bm5gzB2OyvjlDFdDcoa19etZMN8Qp7oUDPEM2KFV1ZAQO2zPMBERO7Ra4JQNpRa4K4FDS0R0IdneCbQLb4/zh/c7QdH4NL40tPXrovFpjHQr6PJ6yr5hQV80PiUiIm1OKxZ0LICS8TWvpyyOf2DBQQtcXk8Zi3+JcKfNafVsjZ0WfGgJlZZQxZjdwzX+ykf6u/UF0Fwo5Apfcq8AAAAASUVORK5CYII=" onclick="MostrarSenha();"/>
					</div>
					<br><br>
					<div class="clearfix"></div>
					<hr class="linha-divisoria-conteudo" />
					<p id="topico-formulario" class="wow bounceIn" data-wow-delay="0.3s">Dados pessoais</p>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">CEP: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtCep" runat="server" class="input-formularios" placeholder="Digite o CEP:"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Endereço: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtLogradouro" runat="server" class="input-formularios" placeholder="Inclua o endereço do novo membro:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Bairro: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtBairro" runat="server" class="input-formularios" placeholder="Digite o nome do bairro:"></asp:TextBox>
					</div>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Cidade: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtCidade" runat="server" class="input-formularios" placeholder="Informe o nome da cidade:"></asp:TextBox>
					</div>
					<br><br>
					<div class="bloco-medio-form">
						<span class="nome-input-formularios">Estado: <span style="color: #ff0000;">*</span></span><br>
                        <asp:TextBox ID="txtUF" runat="server" class="input-formularios" placeholder="Informe o estado:"></asp:TextBox>
					</div>
					<div class="clearfix"></div><br><br>
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" 
                        class="botao-form-home" onclick="btnAlterar_Click"/>

					&nbsp;<div class="clearfix"></div>
					<br>
				</form>
                <script type="text/javascript">
                    $("#txtCep").focusout(function () {
                        //Início do Comando AJAX
                        $.ajax({
                            //O campo URL diz o caminho de onde virá os dados
                            //É importante concatenar o valor digitado no CEP
                            url: 'https://viacep.com.br/ws/' + $(this).val() + '/json/unicode/',
                            //Aqui você deve preencher o tipo de dados que será lido,
                            //no caso, estamos lendo JSON.
                            dataType: 'json',
                            //SUCESS é referente a função que será executada caso
                            //ele consiga ler a fonte de dados com sucesso.
                            //O parâmetro dentro da função se refere ao nome da variável
                            //que você vai dar para ler esse objeto.
                            success: function (resposta) {
                                //Agora basta definir os valores que você deseja preencher
                                //automaticamente nos campos acima.
                                if (resposta.logradouro == null)
                                    $("#txtLogradouro").val("Não encontrado/CEP inválido");
                                else
                                    $("#txtLogradouro").val(resposta.logradouro);
                                if (resposta.complemento == null)
                                    $("#txtComplemento").val("Não encontrado/CEP inválido");
                                else
                                    $("#txtComplemento").val(resposta.complemento);
                                if (resposta.bairro == null)
                                    $("#txtBairro").val("Não encontrado/CEP inválido");
                                else
                                    $("#txtBairro").val(resposta.bairro);
                                if (resposta.localidade == null)
                                    $("#txtCidade").val("Não encontrado/CEP inválido");
                                else
                                    $("#txtCidade").val(resposta.localidade);
                                if (resposta.uf == null)
                                    $("#txtUF").val("Não encontrado/CEP inválido");
                                else
                                    $("#txtUF").val(resposta.uf);
                                //Vamos incluir para que o Número seja focado automaticamente
                                //melhorando a experiência do usuário
                                $("#txtUF").focus();
                            }
                        });
                    });
				</script>
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

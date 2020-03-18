<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarCliente.aspx.cs" Inherits="SGVersaoBeta.cadastrarCliente" %>

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
            if (document.getElementById("txtSenhaFtp").type == "password") {
                document.getElementById("txtSenhaFtp").type = "text";
            }
            else {
                document.getElementById("txtSenhaFtp").type = "password";
            }

        }

        function MostrarSenha2() {
            if (document.getElementById("txtSenhaPainelControle").type == "password") {
                document.getElementById("txtSenhaPainelControle").type = "text";
            }
            else {
                document.getElementById("txtSenhaPainelControle").type = "password";
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
    <br/><br/>
	<img src="slides/gerenciamento-dos-clientes.png" class="banner-interno">
    <center>
        <asp:Label ID="lblRespostaServer" runat="server" Text="" style="color: #ff0000; margin-top: 2%; margin-left: 2%; font-size: 26px; padding-bottom:3%; font-weight: bold;"></asp:Label>
        <br /><br />
        <!--Início do conteúdo -->
	    <div class="container-formularios" style="height: auto; min-height: 1230px;">
            <h1 class="titulos-paginas-internas"><u>Parabéns pelo novo cliente</u></h1>
            <p class="nome-input-formularios"><u>Campos com o <span style="color: #ff0000;">*</span> são obrigatórios</u></p>
            <div class="clearfix"></div>
            <form id="form1" runat="server">
            <p class="nome-input-formularios"><u>Dados do cliente</u></p>
            <div class="clearfix"></div>
				<div class="bloco-medio-form">
					<span class="nome-input-formularios">Nome: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtNomeCliente" runat="server" class="input-formularios" required="required" placeholder="Digite o nome do cliente:"></asp:TextBox>
			    </div>
				<div class="bloco-medio-form">
					<span class="nome-input-formularios">Celular: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtCelular" runat="server" class="input-formularios" required="required" placeholder="Informe o número de celular:"></asp:TextBox>
				</div>
                <br/><br/>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">CEP: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtCep" runat="server" class="input-formularios" required="required" placeholder="Insira o CEP:"></asp:TextBox>
				</div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Endereço: <span style="color: #ff0000;">*</span></span></span><br>
                    <asp:TextBox ID="txtLogradouro" runat="server" class="input-formularios" required="required" placeholder="Endereço: "></asp:TextBox>
				</div>
				<br/><br/>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Bairro: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtBairro" runat="server" class="input-formularios" required="required" placeholder="Bairro: "></asp:TextBox>
			    </div>
                 <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Cidade: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtCidade" runat="server" class="input-formularios" required="required" placeholder="Cidade: "></asp:TextBox>
				</div>
                <br/><br/>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Estado: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtUF" runat="server" class="input-formularios" required="required" placeholder="UF:"></asp:TextBox>
		        </div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Número: <span style="color: #ff0000;">*</span></span><br>
                    <asp:TextBox ID="txtNumero" runat="server" class="input-formularios" required="required" placeholder="Informe o número: "></asp:TextBox>
			    </div>
                <br/><br/>
                <p class="nome-input-formularios"><u>Dados de acesso</u></p>
                <div class="clearfix"></div>
                <div class="bloco-medio-form">
                   <span class="nome-input-formularios">Host FTP: </span><br>
                   <asp:TextBox ID="txtHostFtp" runat="server" class="input-formularios" placeholder="Digite o host do FTP: "></asp:TextBox>
				</div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Usuário FTP: </span><br>
                    <asp:TextBox ID="txtUsuarioFtp" runat="server" class="input-formularios" placeholder="Insira o nome de usuário do FTP: "></asp:TextBox>
				</div>
                <br/><br/>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Senha do FTP: </span><br>
                    <asp:TextBox ID="txtSenhaFtp" type="password" runat="server" class="input-formularios" placeholder="Armazene a senha do FTP:"></asp:TextBox>
				    <img style="cursor: pointer;" title="Exibir a senha" id="olho" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABDUlEQVQ4jd2SvW3DMBBGbwQVKlyo4BGC4FKFS4+TATKCNxAggkeoSpHSRQbwAB7AA7hQoUKFLH6E2qQQHfgHdpo0yQHX8T3exyPR/ytlQ8kOhgV7FvSx9+xglA3lM3DBgh0LPn/onbJhcQ0bv2SHlgVgQa/suFHVkCg7bm5gzB2OyvjlDFdDcoa19etZMN8Qp7oUDPEM2KFV1ZAQO2zPMBERO7Ra4JQNpRa4K4FDS0R0IdneCbQLb4/zh/c7QdH4NL40tPXrovFpjHQr6PJ6yr5hQV80PiUiIm1OKxZ0LICS8TWvpyyOf2DBQQtcXk8Zi3+JcKfNafVsjZ0WfGgJlZZQxZjdwzX+ykf6u/UF0Fwo5Apfcq8AAAAASUVORK5CYII=" onclick="MostrarSenha();"/>
                </div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Link do Painel de controle:</span><br>
                    <asp:TextBox ID="txtLinkPainelControle" runat="server" class="input-formularios" placeholder="Guarde o link do painel de controle:"></asp:TextBox>
				</div>
                 <br/><br/>
                 <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Login do Painel de controle:</span><br>
                    <asp:TextBox ID="txtLoginPainelControle" runat="server" class="input-formularios" placeholder="Digite o login do painel de controle:"></asp:TextBox>
				</div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Senha do Painel de controle:</span><br>
                    <asp:TextBox ID="txtSenhaPainelControle" type="password" runat="server" class="input-formularios" placeholder="Digite a senha do painel de controle:"></asp:TextBox>
				    <img style="cursor: pointer;" title="Exibir a senha" id="Img1" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABDUlEQVQ4jd2SvW3DMBBGbwQVKlyo4BGC4FKFS4+TATKCNxAggkeoSpHSRQbwAB7AA7hQoUKFLH6E2qQQHfgHdpo0yQHX8T3exyPR/ytlQ8kOhgV7FvSx9+xglA3lM3DBgh0LPn/onbJhcQ0bv2SHlgVgQa/suFHVkCg7bm5gzB2OyvjlDFdDcoa19etZMN8Qp7oUDPEM2KFV1ZAQO2zPMBERO7Ra4JQNpRa4K4FDS0R0IdneCbQLb4/zh/c7QdH4NL40tPXrovFpjHQr6PJ6yr5hQV80PiUiIm1OKxZ0LICS8TWvpyyOf2DBQQtcXk8Zi3+JcKfNafVsjZ0WfGgJlZZQxZjdwzX+ykf6u/UF0Fwo5Apfcq8AAAAASUVORK5CYII=" onclick="MostrarSenha2();"/>
                </div>
                <br/><br/>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">E-mail do cliente:</span><br>
                    <asp:TextBox ID="txtEmailCliente" runat="server" class="input-formularios" placeholder="Informe o E-mail do cliente:"></asp:TextBox>
				</div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Domínio do cliente:</span><br>
                    <asp:TextBox ID="txtDominioCliente" runat="server" class="input-formularios" placeholder="Escreva o domínio do cliente:"></asp:TextBox>
				</div>
                <br/><br/>
                <p class="nome-input-formularios"><u>Dados de atividade:</u></p>
                <div class="clearfix"></div>
                <div class="bloco-medio-form">
                    <span class="nome-input-formularios">Status do cliente: <span style="color: #ff0000;">*</span></span><br>
                    <asp:DropDownList ID="dropStatusCliente" runat="server" class="input-formularios" required="required">
                        <asp:ListItem Value="invalido">Selecione --</asp:ListItem>
                        <asp:ListItem Value="Ativo">Ativo</asp:ListItem>
                        <asp:ListItem Value="Inativo">Inativo</asp:ListItem>
                    </asp:DropDownList>
			     </div>
                 <div class="clearfix"></div>
                <br/><br/>
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" 
                class="botao-form-home" onclick="btnCadastrar_Click"/>
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
                            $("#txtNumero").focus();
                        }
                    });
                });
		    </script>
        </div>
    </center>
    <div class="clearfix"></div>
	<!-- Fim do conteúdo -->
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="muralDePropostas.aspx.cs" Inherits="SistemaFenag.muralDePropostas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SIGA - FENAG</title>
    <meta name="author" content="Mike Ewerthon de Figueiredo Silva" />
    <link rel="stylesheet" type="text/css" href="css/estilo.css" />
    <meta charset="utf-8" />
    <link rel="icon" href="img/logotipo-fenag-topo.png">
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
	<script src="js/script.js"></script>
    <script src="js/jquery-1.5.2.min.js"></script>
    <style>.wow:first-child {visibility: hidden;}</style>
</head>
<body>
    <%
        Response.WriteFile("topo.htm");
    %>
    <center>
        <div class="containerPaginas">
            <h1 class="tituloPaginaLogin">MURAL DE PROPOSTAS</h1>
            <div class="containerFormsPrincipais">
                <br /><br />
                <div class="blocosMuralDeSugestoes">
                    <asp:Label ID="lblNomeUsuario0" runat="server" Text="Nome do usuário logado" class="InformacaoTopoSugestao"></asp:Label><asp:Label ID="lblEmailUsuario" runat="server" Text="email@emaildousuario.com" class="InformacaoTopoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblSugestao0" runat="server" Text="Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores." class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaSugestao0" runat="server" Text="Proposta Aprovada - 05-06-2019" class="InformacaoTopoSugestao" style="font-weight:bold;color: #45a546;"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaProposta0" runat="server" Text="Resposta" class="DescricaoSugestao" style="font-weight: bold;"></asp:Label>
                    <asp:Label ID="lblFeedbackProposta0" runat="server" Text="Aqui será descrita a resposta do condel sobre a aprovação ou reprovação sobre a proposta" class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                </div>
                <br /><br />
                <br /><br />
                <div class="blocosMuralDeSugestoes">
                    <asp:Label ID="lblNomeUsuario1" runat="server" Text="Nome do usuário logado" class="InformacaoTopoSugestao"></asp:Label><asp:Label ID="Label2" runat="server" Text="email@emaildousuario.com" class="InformacaoTopoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblSugestao1" runat="server" Text="Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores." class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaSugestao1" runat="server" Text="Proposta reprovada - 15-06-2019" class="InformacaoTopoSugestao" style="font-weight:bold;color: #e50505;"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaProposta1" runat="server" Text="Resposta" class="DescricaoSugestao" style="font-weight: bold;"></asp:Label>
                    <asp:Label ID="lblFeedbackProposta1" runat="server" Text="Aqui será descrita a resposta do condel sobre a aprovação ou reprovação sobre a proposta" class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                </div>
                <br /><br />
                <br /><br />
                <div class="blocosMuralDeSugestoes">
                    <asp:Label ID="lblNomeUsuario2" runat="server" Text="Nome do usuário logado" class="InformacaoTopoSugestao"></asp:Label><asp:Label ID="Label6" runat="server" Text="email@emaildousuario.com" class="InformacaoTopoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblSugestao2" runat="server" Text="Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores - Aqui será descrita a sugestão do usuário para os gestores." class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaSugestao2" runat="server" Text="Proposta aprovada com alterações - 22-06-2019" class="InformacaoTopoSugestao" style="font-weight:bold;color: #bfae2e;"></asp:Label>
                    <div class="clearfix"></div>
                    <asp:Label ID="lblRespostaProposta2" runat="server" Text="Resposta" class="DescricaoSugestao" style="font-weight: bold;"></asp:Label>
                    <asp:Label ID="lblFeedbackProposta2" runat="server" Text="Aqui será descrita a resposta do condel sobre a aprovação ou reprovação sobre a proposta" class="DescricaoSugestao"></asp:Label>
                    <div class="clearfix"></div>
                </div>
                <br /><br />
            </div>
            <br /><br />
        </div>
    </center>
    <%
        Response.WriteFile("rodape.htm");
    %>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Autenticar.aspx.cs" Inherits="LojaVirtual.WEB.Autenticar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 151px">
                <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
            </td>
            <td style="width: 501px">
                <asp:TextBox ID="txtEmail" runat="server" Width="500px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
            </td>
            <td style="width: 501px">
                <asp:TextBox ID="txtSenha" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblMsg2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">
                <asp:Button ID="btEntrar" runat="server" onclick="btEntrar_Click" Text="LOGIN" 
                    Width="125px" />
            </td>
            <td align="right" style="width: 501px">
                &nbsp;</td>
            <td align="right">
                <asp:HyperLink ID="lnkCadastrar" runat="server" NavigateUrl="/Cadastrar.aspx">Cadastrar-se agora!</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="width: 151px">
                &nbsp;</td>
            <td style="width: 501px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

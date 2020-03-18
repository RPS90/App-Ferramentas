<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="LojaVirtual.ADMIN.Clientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 150px;
        }
        .style2
        {
            width: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text="&lt;h1&gt;Gerenciamento de CLIENTES&lt;/h1&gt;"></asp:Label>
    </div>
    <table style="width:100%;">
        <tr>
            <td class="style1">
        <asp:Label ID="lblCodCliente" runat="server" Text="Código de Cliente:"></asp:Label>
            </td>
            <td class="style2">
    <asp:TextBox ID="txtCodCliente" runat="server" ReadOnly="True" Width="250px"></asp:TextBox>
            </td>
            <td>
    <asp:Label ID="Label1" runat="server" Text="*Campo não editável"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
        <asp:Label ID="lblNomeCliente" runat="server" Text="Nome de Cliente:"></asp:Label>
            </td>
            <td class="style2">
        <asp:TextBox ID="txtNomeCliente" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
    <asp:Label ID="lblEmail" runat="server" Text="Email do Cliente:"></asp:Label>
            </td>
            <td class="style2">
        <asp:TextBox ID="txtEmailCliente" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblSenha" runat="server" Text="Senha!"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtSenhaCliente" runat="server" style="margin-bottom: 0px" 
                    TextMode="Password" Width="250px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblEndereco" runat="server" Text="Endereço:"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="txtEnderecoCliente" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:Button ID="btSalvar" runat="server" Text="Salvar" OnClick="btSalvar_Click" />
    </p>
    <asp:GridView ID="grvClientes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvClientes_selectedIndexChanged"
        DataKeyNames="IDT_CLIENTE" OnRowDeleting="grvClientes_RowDeleting">
        <Columns>
            <asp:BoundField DataField="IDT_CLIENTE" HeaderText="Código:" />
            <asp:BoundField DataField="NOME" HeaderText="Nome:" />
            <asp:BoundField DataField="EMAIL" HeaderText="E-Mail:" />
            <asp:BoundField DataField="SENHA" HeaderText="Senha:" >
            <ControlStyle BackColor="Black" />
            </asp:BoundField>
            <asp:BoundField DataField="ENDERECO" HeaderText="Endereço:" />
            <asp:CommandField SelectText="Editar!" ShowSelectButton="True" />
            <asp:CommandField DeleteText="Excluir!" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>

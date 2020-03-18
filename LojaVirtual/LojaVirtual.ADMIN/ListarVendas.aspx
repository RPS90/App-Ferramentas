<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarVendas.aspx.cs" Inherits="LojaVirtual.ADMIN.ListarVendas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 135px;
        }
        .style4
        {
            width: 135px;
            height: 26px;
        }
        .style5
        {
            height: 26px;
            width: 210px;
        }
        .style7
        {
            width: 210px;
        }
        .style8
        {
            width: 138px;
        }
        .style9
        {
            width: 138px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text="&lt;h1&gt;Gerenciamento de PRODUTOS&lt;/h1&gt;"></asp:Label>
    </div>
    <table style="width:100%;">
        <tr>
            <td class="style8">
        <asp:Label ID="lblCodProduto" runat="server" Text="Código do Produto"></asp:Label>
            </td>
            <td class="style2">
    <asp:TextBox ID="txtCodProduto" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style7">
    <asp:Label ID="Label1" runat="server" Text="*Campo não editável"></asp:Label>
            </td>
                   <td rowspan="5">
                       <asp:Image ID="imgProduto" runat="server" Height="120px" Width="120px" />
            </td>
        </tr>
        <tr>
            <td class="style8">
        <asp:Label ID="lblNomeProduto" runat="server" Text="Nome do Produto"></asp:Label>
            </td>
            <td class="style2">
        <asp:TextBox ID="txtNomeProduto" runat="server"></asp:TextBox>
            </td>
            <td class="style7">
               </td>
               
        </tr>
        <tr>
            <td class="style8">
    <asp:Label ID="lblValor" runat="server" Text="Valor do Produto"></asp:Label>
            </td>
            <td class="style2">
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            </td>
            <td class="style7">
        <asp:Label ID="Label4" runat="server" Text="R$"></asp:Label>
            </td>
                   
        </tr>
        <tr>
            <td class="style9">
                <asp:Label ID="Label2" runat="server" Text="Descrição  do Produto"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
                   
        </tr> 
        <tr>
            <td class="style9">
        <asp:Label ID="Label3" runat="server" Text="Imagem  do Produto"></asp:Label>
            </td>
            <td class="style4">
        <asp:FileUpload ID="FileFotoProduto" runat="server" />
            </td>
            <td class="style5">
                <asp:Label ID="lblFoto" runat="server" ForeColor="#0000CC"></asp:Label>
            </td>
                   
        </tr> 
    </table>
 

    <p>
        <asp:Button ID="btSalvar" runat="server" Text="Salvar" OnClick="btSalvar_Click" />
    </p>
    <asp:GridView ID="grvVendas" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvProdutos_selectedIndexChanged"
        DataKeyNames="IDT_PRODUTO" OnRowDeleting="grvProdutos_RowDeleting">
        <Columns>
            <asp:BoundField DataField="IDT_PRODUTO" HeaderText="Código:" />
            <asp:BoundField DataField="NOME" HeaderText="Nome:" />
            <asp:BoundField DataField="VALOR" HeaderText="Valor:" />
            <asp:CommandField SelectText="Editar!" ShowSelectButton="True" />
            <asp:CommandField DeleteText="Excluir!" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    </form>
</body>

</html>

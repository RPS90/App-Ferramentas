<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true"
    CodeBehind="Detalhes.aspx.cs" Inherits="LojaVirtual.WEB.Detalhes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contents">
        <div id="main">
            <div align="center">
                <asp:Label ID="lblNomeProduto" runat="server" Font-Bold="True" 
                    Font-Size="XX-Large"></asp:Label>
            </div>
            <p>
                <table style="width: 100%;" align="center" border="1">
                    <tr>
                        <td rowspan="6" style="width: 250px">
                            <span>
                                <asp:Image ID="imgProduto" runat="server" Height="300px" Width="250px" />
                            </span>
                        </td>
                        <td>
                            Preço:&nbsp;
                            <asp:Label ID="lblValor" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 150px" valign="top">
                            Descrição:
                            <asp:Label ID="lblDescricao" runat="server" Font-Underline="True"></asp:Label>
                        </td>
                    </tr>
                </table>
            </p>
            <div align="center">
                <asp:ImageButton ID="btCarrinho" runat="server" ImageUrl="/images/carrinho.png" 
                    Width="100px" Height="100px"                      onclick="btCarrinho_Click" />
            </div>
        </div>
        <div id="featured">
            <ul>
                <li>
                    <img src="images/item3.jpg" alt="shirt" /></li>
                <li>
                    <img src="images/item6.jpg" alt="shirt" /></li>
                <li>
                    <img src="images/item9.jpg" alt="shirt" /></li>
                <li class="last">
                    <img src="images/item2.jpg" alt="shirt" /></li>
            </ul>
            <a href="../Default.aspx" class="button">Comprar!!</a>
        </div>
    </div>
</asp:Content>

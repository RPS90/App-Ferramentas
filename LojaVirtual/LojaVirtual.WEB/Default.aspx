<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="LojaVirtual.WEB.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contents">
        <div id="shop">
            <ul class="items">
                <asp:DataList ID="dtlProdutos" runat="server" RepeatColumns="4" 
                OnItemDataBound="dtlProdutos_ItemDataBound" 
                    OnItemCommand="dtlProdutos_ItemCommand">
                    <ItemTemplate>
                        <li><span>
                            <asp:HyperLink ID="lnkImgProduto" runat="server" ImageUrl="images/item1.jpg" NavigateUrl="#"></asp:HyperLink></span>
                            <br>
                            </br>
                            <table style="width: 92%;">
                                <tr>
                                    <td align="left">
                                        &nbsp;
                                        <asp:Label ID="lblNomeProduto" runat="server" Text="Nome"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 59px">
                                        &nbsp;
                                        <asp:Label ID="lblPrecoProduto" runat="server" Text="123"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        &nbsp;
                                        <asp:HyperLink ID="lnkDetProduto" runat="server" Text="Detalhes" NavigateUrl="~/detalhes.aspx"></asp:HyperLink>
                                    </td>
                                    <td style="width: 59px" align="right">
                                        <asp:ImageButton ID="btCarrinho" runat="server" ImageUrl="/images/carrinho.png" Width="25"
                                            Height="25"  CommandName = "carrinho"  />
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </li>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <li><span>
                            <asp:HyperLink ID="lnkImgProduto" runat="server" ImageUrl="images/item1.jpg" NavigateUrl="#"></asp:HyperLink></span>
                            <br>
                            </br>
                            <table style="width: 92%;">
                                <tr>
                                    <td align="left">
                                        &nbsp;
                                        <asp:Label ID="lblNomeProduto" runat="server" Text="Nome"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 59px">
                                        &nbsp;
                                        <asp:Label ID="lblPrecoProduto" runat="server" Text="123"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        &nbsp;
                                        <asp:HyperLink ID="lnkDetProduto" runat="server" Text="Detalhes" NavigateUrl="~/detalhes.aspx"></asp:HyperLink>
                                    </td>
                                    <td style="width: 59px" align="right">
                                        <asp:ImageButton ID="btCarrinho" runat="server" ImageUrl="/images/carrinho.png" Width="25"
                                            Height="25" CommandName = "carrinho" />
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </li>
                    </AlternatingItemTemplate>
                </asp:DataList>
                
            </ul>
        </div>
    </div>
    <!-- /#contents -->
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CarrinhoCompra.aspx.cs" Inherits="LojaVirtual.WEB.CarrinhoCompra" %>

<%@ Register assembly="UOL.PagSeguro" namespace="UOL.PagSeguro" tagprefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <p style="text-align: center">
        Carrinho de Compras</p>


    <div style="text-align: center">
        <asp:Image ID="Image1" runat="server" Height="200px" 
            ImageUrl="~/images/carrinho.gif" Width="200px" EnableTheming="False" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Visible="False"></asp:Label>
        <br />
    </div>
    <div>
        <div>

            <asp:GridView ID="grvCarrinho" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="IDT_PRODUTO" HorizontalAlign="Center" 
                onrowdatabound="grvCarrinho_RowDataBound" ShowFooter="True" Width="650px" 
                onrowdeleting="grvCarrinho_RowDeleting">
                <Columns>
                    <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/delete.gif" 
                        HeaderText="Excluir" ShowDeleteButton="True" />
                    <asp:TemplateField HeaderText="Descrição">
                  
                        <ItemTemplate>
                            <asp:Label ID="lblDescricao" runat="server" ></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="QUANTIDADE" HeaderText="Quantidade">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="VALOR_UNITARIO"                         HeaderText="Valor Unitário"></asp:BoundField>
                    <asp:BoundField DataField="SUBTOTAL"                         HeaderText="SubTotal"></asp:BoundField>
                </Columns>
            </asp:GridView>

            <div align="center">
                <asp:ImageButton ID="btPagar" runat="server" ImageUrl="images/comprar.jpg" 
                    ToolTip = "Pagar" onclick="btPagar_Click" />
                <cc1:VendaPagSeguro ID="VendaPagSeguro1" runat="server" EmailCobranca= "horohoro@live.com">
                </cc1:VendaPagSeguro>
            </div>

        </div>
    </div>


</asp:Content>

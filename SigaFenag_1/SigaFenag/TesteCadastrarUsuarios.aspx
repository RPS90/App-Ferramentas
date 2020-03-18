<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteCadastrarUsuarios.aspx.cs" Inherits="SistemaFenag.CadastrarUsuarios" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
   
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="td">Nome:</td>
            <td><asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
            <td><asp:Label ID="lblcodigo" runat="server" Text="Código: "></asp:Label><asp:Label ID="lblcodigo_usuario" runat="server"></asp:Label>
                <asp:Label ID="lblDateTime" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="td">Matricula:</td>
            <td><asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtUsr_senha:</td>
            <td><asp:TextBox ID="txtUsr_senha" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">Unidade:</td>
            <td><asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="True">
                <asp:ListItem Value="1071">São Paulo</asp:ListItem>
                <asp:ListItem Value="1069">Rio de Janeiro</asp:ListItem>
                <asp:ListItem Value="1074">São Paulo Interior</asp:ListItem>
                <asp:ListItem Value="000">teste</asp:ListItem>
               </asp:DropDownList>
            </td>
            <td><asp:DropDownList ID="ddlCodigo_unidade" runat="server"><asp:ListItem Value="1">Unidade</asp:ListItem></asp:DropDownList></td>
        </tr>
        <tr>
            <td class="td">txtBanco_agencia:</td>
            <td><asp:TextBox ID="txtBanco_agencia" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtBanco_conta:</td>
            <td><asp:TextBox ID="txtBanco_conta" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">ddlConvenio_fenag_rdc:</td>
            <td><asp:DropDownList ID="ddlConvenio_fenag_rdc" runat="server">
                <asp:ListItem>Sim</asp:ListItem>
                <asp:ListItem>Não</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td class="td">txtConvenio_outro:</td>
            <td><asp:TextBox ID="txtConvenio_outro" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtDoc_cpf:</td>
            <td><asp:TextBox ID="txtDoc_cpf" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtDoc_rg:</td>
            <td><asp:TextBox ID="txtDoc_rg" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtEmail:</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtEmail_caixa:</td>
            <td><asp:TextBox ID="txtEmail_caixa" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtEndereco_bairro:</td>
            <td><asp:TextBox ID="txtEndereco_bairro" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtEndereco_cep:</td>
            <td><asp:TextBox ID="txtEndereco_cep" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="td">txtEndereco_cidade:</td>
            <td><asp:TextBox ID="txtEndereco_cidade" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtEndereco_complemento:</td>
            <td><asp:TextBox ID="txtEndereco_complemento" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtEndereco_numero:</td>
            <td><asp:TextBox ID="txtEndereco_numero" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtEndereco_rua:</td>
            <td><asp:TextBox ID="txtEndereco_rua" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlEstado_civil:</td>
            <td><asp:DropDownList ID="ddlEstado_civil" runat="server">
                <asp:ListItem>Solteiro</asp:ListItem>
                <asp:ListItem>Casado</asp:ListItem>
                <asp:ListItem>Viúvo</asp:ListItem>
                </asp:DropDownList></td>
                                  
        </tr>
        <tr>
            <td class="td">txtFone_celular:</td>
            <td><asp:TextBox ID="txtFone_celular" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtFone_residencial:</td>
            <td><asp:TextBox ID="txtFone_residencial" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtFuncao:</td>
            <td><asp:TextBox ID="txtFuncao" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">txtLotacao:</td>
            <td><asp:TextBox ID="txtLotacao" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlNivel_acesso:</td>
            <td><asp:DropDownlist ID="ddlNivel_acesso" runat="server">
                <asp:ListItem Value="1">Usuário</asp:ListItem>
                <asp:ListItem Value="2">Gerente de Unidade</asp:ListItem>
                <asp:ListItem Value="3">FENAG</asp:ListItem>
                <asp:ListItem Value="4">Admin</asp:ListItem>
                </asp:DropDownlist></td>
                                  
        </tr>
        <tr>
            <td class="td">txtNome_conjugue:</td>
            <td><asp:TextBox ID="txtNome_conjugue" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlPreferencia_contato:</td>
            <td><asp:DropDownList ID="ddlPreferencia_contato" runat="server">
                <asp:ListItem>Telefones</asp:ListItem>
                <asp:ListItem>Emails</asp:ListItem>
                </asp:DropDownList></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlSexo:</td>
            <td><asp:DropDownList ID="ddlSexo" runat="server">
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
                </asp:DropDownList></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlSituacao:</td>
            <td><asp:DropDownList ID="ddlSituacao" runat="server">
                <asp:ListItem Value="1">Ativo</asp:ListItem>
                <asp:ListItem Value="0">Aposentado</asp:ListItem>
                </asp:DropDownList></td>
                                  
        </tr>
        <tr>
            <td class="td">txtSuper_intendencia:</td>
            <td><asp:TextBox ID="txtSuper_intendencia" runat="server"></asp:TextBox></td>
                                  
        </tr>
        <tr>
            <td class="td">ddlTamanho_camisa:</td>
            <td><asp:DropDownList ID="ddlTamanho_camisa" runat="server">
                <asp:ListItem>P</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>GG</asp:ListItem>
                </asp:DropDownList></td>
                                  
        </tr>
        <tr>
            <td class="td">txtFone_comer:</td>
            <td><asp:TextBox ID="txtFone_comer" runat="server"></asp:TextBox></td>
                                  
        </tr>
         <tr>
            <td class="td">txtFone_ramal:</td>
            <td><asp:TextBox ID="txtFone_ramal" runat="server"></asp:TextBox></td>
                                  
        </tr>


        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Visible="false" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td>
            <td class="auto-style1"></td>
        </tr>
    </table>

    <div style="padding: 10px; margin: 0px; width: 100%;">
        <p>
            Total Usuários:<asp:Label ID="lbltotalcount" runat="server" Font-Bold="true"></asp:Label>
        </p>
        <asp:GridView ID="GridViewStudent" runat="server" DataKeyNames="nome" 
            OnSelectedIndexChanged="GridViewStudent_SelectedIndexChanged" OnRowDeleting="GridViewStudent_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" Width="338px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField HeaderText="Update" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
</asp:Content>

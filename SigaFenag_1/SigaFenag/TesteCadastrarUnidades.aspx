<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteCadastrarUnidades.aspx.cs" Inherits="SistemaFenag.CadastrarUnidades" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
   
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>numero_entidade</td>
            <td class="auto-style5"><asp:TextBox ID="txtnumero_entidade" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
             <td>numero_rubrica</td>
             <td class="auto-style5"><asp:TextBox ID="txtnumero_rubrica" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
             <td>numero_unidade</td>
             <td class="auto-style5"><asp:TextBox ID="txtnumero_unidade" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
             <td>endereco_cidade</td>
             <td class="auto-style5"><asp:TextBox ID="txtendereco_cidade" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>endereco_nome</td>
           <td class="auto-style5"><asp:TextBox ID="txtendereco_nome" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>estatus</td>
            <td class="auto-style5"><asp:TextBox ID="txtestatus" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>endereco_uf</td>
            <td class="auto-style5"><asp:TextBox ID="txtendereco_uf" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>tipo</td>
             <td class="auto-style5"><asp:DropDownList ID="ddltipo" runat="server">
                 <asp:ListItem Value="0">Regional</asp:ListItem>
                 <asp:ListItem Value="1">Estadual</asp:ListItem>
                 </asp:DropDownList></td>
        </tr>
          <tr>
             <td>nome_entidade</td>
            <td class="auto-style5"><asp:TextBox ID="txtnome_entidade" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>nome_rubrica</td>
            <td class="auto-style5"><asp:TextBox ID="txtnome_rubrica" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>nome_unidade</td>
            <td class="auto-style5"><asp:TextBox ID="txtnome_unidade" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>endereco_cep</td>
          <td class="auto-style5"><asp:TextBox ID="txtendereco_cep" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>endereco_numero</td>
            <td class="auto-style5"><asp:TextBox ID="txtendereco_numero" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>endereco_bairro</td>
            <td class="auto-style5"><asp:TextBox ID="txtendereco_bairro" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>cnpj</td>
             <td class="auto-style5"><asp:TextBox ID="txtcnpj" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
             <td>telefone1</td>
             <td class="auto-style5"><asp:TextBox ID="txttelefone1" runat="server"></asp:TextBox></td>
              <td class="auto-style1">telefone1_ramal<asp:TextBox ID="txttelefone1_ramal" runat="server" Width="31px"></asp:TextBox></td>
        </tr>
          <tr>
             <td class="auto-style2">telefone2</td>
             <td class="auto-style6"><asp:TextBox ID="txttelefone2" runat="server" CssClass="auto-style4" Height="16px"></asp:TextBox></td>
              <td class="auto-style3">telefone2_ramal<asp:TextBox ID="txttelefone2_ramal" runat="server" Width="31px"></asp:TextBox></td>
        </tr>
        <tr>
             <td>endereco_complemento</td>
         <td class="auto-style5"><asp:TextBox ID="txtendereco_complemento" runat="server"></asp:TextBox></td>
        </tr>  
        <tr>
             <td>codigo_presidente</td>
            <td>Escolher Estado</td>
            <td>Escolher Unidade</td>
            <td>Escolher Usuário</td>
             <td class="auto-style5"><asp:DropDownList ID="ddlPresidente" runat="server"></asp:DropDownList></td>


        </tr>
        <tr>
            <td>email</td>
            <td class="auto-style5"><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> <asp:Button ID="btSalvar" runat="server" Text="Cadastrar" /></td>
           <td> <asp:Button ID="btAlterar" runat="server" Text="Alterar" /></td>
            <td> <asp:Button ID="btCancel" runat="server" Text="X" /></td>
        </tr>


    </table>

     <div style="padding: 10px; margin: 0px; width: 100%;">
    <asp:GridView ID="GridViewDados" runat="server">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
         </div>

</asp:Content>

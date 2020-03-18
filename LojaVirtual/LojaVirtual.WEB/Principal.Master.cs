using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.BLL;
using LojaVirtual.DAO;

namespace LojaVirtual.WEB
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        Carrinho carrinho = new Carrinho();

        protected void Page_Load(object sender, EventArgs e)
        {
            CLIENTE cliente = new CLIENTE();

            AtualizarCarrinho();
            lblCliente.Visible = false;
            if (Session["cliente"] != null)
            {
                cliente = (CLIENTE)Session["cliente"];
                lblCliente.Text = "olá!" + cliente.NOME;
                cliente = null;
            }
            if (!IsPostBack)
            {
                //BuscarProdutos();
                AtualizarCarrinho();
            }
        }
        public void AtualizarCarrinho()
        {
            if (carrinho.Itens.Count > 0)
            {
                lblItens.Text = carrinho.Itens.Count.ToString();
                lblValor.Text = carrinho.ValorTotal().ToString("C");  //----------------------------currency
            }
            else 
            {
                lblItens.Text = "Vazio";
                lblValor.Text = "N/A";
            }
        }















    }
}
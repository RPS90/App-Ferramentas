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
    public partial class Detalhes : System.Web.UI.Page
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        PRODUTO produto = new PRODUTO();
        int codigoProduto = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["produto"] != null)
            {
                codigoProduto = int.Parse(Request.QueryString["produto"].ToString());
                BuscarProduto();
            }
        }
        public void BuscarProduto()
        {
            //ProdutoBLL produtoBLL = new ProdutoBLL();
            //PRODUTO produto = new PRODUTO();
            produto = produtoBLL.Find(p => p.IDT_PRODUTO.Equals(codigoProduto)).First();
            imgProduto.ImageUrl = "http://localhost:2709/Produtos/" + produto.FOTO.ToString();
            lblDescricao.Text = produto.DESCRICAO;
            lblValor.Text = produto.VALOR.ToString("C");
            lblNomeProduto.Text = produto.NOME;
        }

        protected void btCarrinho_Click(object sender, ImageClickEventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            ITEM_VENDA item = new ITEM_VENDA();

            item.IDT_PRODUTO = codigoProduto;
            item.QUANTIDADE =1;
            item.VALOR_UNITARIO = produto.VALOR;

            carrinho.AdicionarItem(item);
            Response.Redirect("CarrinhoCompra.aspx");

        }


















    }
}
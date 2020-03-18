using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.DAO;
using LojaVirtual.BLL;

namespace LojaVirtual.WEB
{
    public partial class CarrinhoCompra : System.Web.UI.Page

    {
        int codProduto = 0;
        Carrinho carrinho = new Carrinho();
        ProdutoBLL produtobll = new ProdutoBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            BuscarItens();
        }
        public void BuscarItens()
        {
            if (carrinho.Itens.Count > 0)
            {
                grvCarrinho.DataSource = carrinho.Itens;
                grvCarrinho.DataBind();
                lblMsg.Visible = false;
            }
            else
            {
                lblMsg.Text = "Não tem itens no seu carrinho!";
                lblMsg.Visible = true;
                grvCarrinho.DataBind();
            }
        }
        protected void grvCarrinho_RowDataBound(object sender, GridViewRowEventArgs e)
        {          
           if(e.Row.RowType != DataControlRowType.Header && e.Row.RowType != DataControlRowType.Footer)
           {
               codProduto = ((ITEM_VENDA)e.Row.DataItem).IDT_PRODUTO;
               //ProdutoBLL produtobll = new ProdutoBLL();
               PRODUTO produto = produtobll.Find(p => p.IDT_PRODUTO == codProduto).First();
              ((Label) e.Row.FindControl("lblDescricao")).Text = produto.NOME;
           }
           else if (e.Row.RowType == DataControlRowType.Footer)
           {
               e.Row.Cells[1].Text = "Total de Itens Selecionados" + carrinho.QuantidadeTotal().ToString();
               e.Row.Cells[4].Text = String.Format("R$" + carrinho.ValorTotal());
           }
        }
        protected void grvCarrinho_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if(carrinho.ExcluirItem(int.Parse(grvCarrinho.DataKeys[e.RowIndex].Value.ToString())))
            {
                BuscarItens();
            }

        }

        protected void btPagar_Click(object sender, ImageClickEventArgs e)
        {//finaliza venda
            PRODUTO prd = null;
            int idCodigoVenda = carrinho.FinalizarVenda(1, 5); //fixo por enquanto
            VendaPagSeguro1.CodigoReferencia = idCodigoVenda.ToString();
            VendaPagSeguro1.Produtos = new List<UOL.PagSeguro.Produto>();

            foreach (ITEM_VENDA item in carrinho.Itens)
            { 
                UOL.PagSeguro.Produto produto = new UOL.PagSeguro.Produto();
                produto.Codigo = item.IDT_PRODUTO.ToString();
                prd = new PRODUTO();
                prd = produtobll.BuscarProduto(item.IDT_PRODUTO);
                produto.Descricao = prd.NOME;
                produto.Quantidade = item.QUANTIDADE;
                produto.Valor = double.Parse(item.VALOR_UNITARIO.ToString());
                VendaPagSeguro1.Produtos.Add(produto);
            }
            prd = null;

            VendaPagSeguro1.Cliente = new UOL.PagSeguro.Cliente();
            VendaPagSeguro1.Cliente.Nome = "Rafael";//alterar
            VendaPagSeguro1.Executar(this.Response);//própria pagina





        }
    }
}
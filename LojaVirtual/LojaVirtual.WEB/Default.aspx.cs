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
    public partial class Default : System.Web.UI.Page
    {
        ProdutoBLL produtosBLL = new ProdutoBLL();
        ProdutoDAO produtos = new ProdutoDAO();        
        //Carrinho carrinho = new Carrinho();
        //ITEM_VENDA item = new ITEM_VENDA();        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuscarProdutos();
            }
        }                
        public void BuscarProdutos()
        {
         dtlProdutos.DataSource = produtosBLL.GetAll();
         dtlProdutos.DataBind();
        }
        protected void dtlProdutos_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType != ListItemType.Header && e.Item.ItemType != ListItemType.Footer)
            {//Label - Nome
                ((Label)e.Item.FindControl("lblNomeProduto")).Text = ((PRODUTO)e.Item.DataItem).NOME;
             //Label - Preco
                ((Label)e.Item.FindControl("lblPrecoProduto")).Text = ((PRODUTO)e.Item.DataItem).VALOR.ToString("C");
             //Hyperlink - DETALHES
                //((HyperLink)e.Item.FindControl("lnkDetProduto")).Text = ((PRODUTO)e.Item.DataItem).NOME;
                ((HyperLink)e.Item.FindControl("lnkDetProduto")).NavigateUrl = "Detalhes.aspx?produto=" + ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();
             //HyperLink - IMG        
                ((HyperLink)e.Item.FindControl("lnkImgProduto")).NavigateUrl = "Detalhes.aspx?produto=" + ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();
                ((HyperLink)e.Item.FindControl("lnkImgProduto")).ImageUrl = "http://localhost:2709/Produtos/" + ((PRODUTO)e.Item.DataItem).FOTO.ToString();
             //imgBT - Carrinho
                ((ImageButton)e.Item.FindControl("btCarrinho")).CommandArgument = ((PRODUTO)e.Item.DataItem).IDT_PRODUTO.ToString();
             
            }
        }       
        protected void dtlProdutos_ItemCommand(object sender, DataListCommandEventArgs e)
        {
                Carrinho carrinho = new Carrinho();
                ITEM_VENDA item = new ITEM_VENDA();
                PRODUTO produto = new PRODUTO();
            

            if (e.CommandName == "carrinho")
            {           
                int codProduto = int.Parse(e.CommandArgument.ToString());
                //produto = produtosBLL.Find(p => p.IDT_PRODUTO == int.Parse(e.CommandArgument.ToString())).First();            //cast1
                //produto = produtosBLL.Find(p => p.IDT_PRODUTO == (int)e.CommandArgument).First();                             //cast2
                //produto = (PRODUTO)produtosBLL.Find(p => p.IDT_PRODUTO == (int)e.CommandArgument).First();                    //cast3
                produto = (PRODUTO)produtosBLL.Find(p => p.IDT_PRODUTO == codProduto).First();   //cast4  a que funciona
       
                item.IDT_PRODUTO = int.Parse(e.CommandArgument.ToString());
                item.QUANTIDADE =1;
                item.VALOR_UNITARIO = produto.VALOR;

                carrinho.AdicionarItem(item);
                Response.Redirect("CarrinhoCompra.aspx");
            }
        }    
    }
}



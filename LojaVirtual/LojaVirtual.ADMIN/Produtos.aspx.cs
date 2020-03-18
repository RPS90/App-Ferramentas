using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.BLL;
using LojaVirtual.DAO;

namespace LojaVirtual.ADMIN
{
    public partial class Produtos : System.Web.UI.Page
    {//start Passos para comunicação entre BD
        ProdutoBLL produtosBLL = new ProdutoBLL(); //Business 
        ProdutoDAO produtos = new ProdutoDAO(); // DATA ACCESS 
        PRODUTO produto = new PRODUTO();        
        string diretorio = "";
        string nomefoto = "";        
        int codProduto = 0; //variável do código
        DateTime data = new DateTime();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //de praxe
            { BuscarProdutos(); }
        }
        protected void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != string.Empty)
            { AtualizarProduto(); }
            else
            {//tem auto incremente, n precisa por cod
                produto.VALOR = Decimal.Parse(txtValor.Text);
                produto.NOME = txtNomeProduto.Text;
                produto.DESCRICAO = txtDescricao.Text;
                //IMAGEM-----------------------------
                if (FileFotoProduto.HasFile)
                {
                    Random rdm = new Random();
                    diretorio = MapPath("~/Produtos/");
                    nomefoto = "produto" + rdm.Next(0, 999999).ToString() + FileFotoProduto.FileName.Substring(FileFotoProduto.FileName.LastIndexOf("."), 4); 
                    //nomefoto = produto.FOTO;
                    FileFotoProduto.SaveAs(diretorio + nomefoto);
                    produto.FOTO = nomefoto;
                }                
                //para checkbox chktrealala.checked == true  ? "S" : "N"; //if ternario
                //produto.DATA = dateTime.now;
                produtosBLL.Add(produto);
                produtosBLL.SaveChanges();
                BuscarProdutos();
                produtosBLL = null;
                produto = null;
                LimparCampos();
            }//else            
        }//btSalvar
        //meus métodos
        //---------------------------------------------------------------------------------
        public void AtualizarProduto()
        {
            codProduto = int.Parse(txtCodProduto.Text);
            produto = produtos.Find(cat => cat.IDT_PRODUTO == codProduto).First<PRODUTO>();
            produto.NOME = txtNomeProduto.Text;
            produto.VALOR = Decimal.Parse(txtValor.Text);
            produto.DESCRICAO = txtDescricao.Text;
      
            if (FileFotoProduto.HasFile)//se tem arquivo
            {
                Random rdm = new Random(); //random agora funfa
                data = DateTime.Now;
                diretorio = MapPath("/Produtos/");
                nomefoto = "produto" + rdm.Next(0, 999999).ToString() + FileFotoProduto.FileName.Substring(FileFotoProduto.FileName.LastIndexOf("."), 4); 
                //nomefoto = "produto" + data.ToOADate() + FileFotoProduto.FileName.Substring(FileFotoProduto.FileName.LastIndexOf("."), 4); 
               
                FileFotoProduto.SaveAs(diretorio + nomefoto);
                produto.FOTO = nomefoto;
            }   
            produtos.Update(produto);
            produtos.SaveChanges();
            BuscarProdutos();//atualizando

            produtos = null;
            produto = null;
            LimparCampos();
        }
        public void LimparCampos()
        {
            txtDescricao.Text = "";
            lblFoto.Text = "";
            txtCodProduto.Text = ""; 
            txtNomeProduto.Text = "";
            txtValor.Text = "";
            btSalvar.Text = "Salvar";
            lblMsg.Text = "<h1>Gerenciamento de PRODUTOS</h1>";
            imgProduto.Visible = false;
        }
        public void BuscarProdutos()
        {
            //ProdutoBLL produtos = new ProdutoBLL();
            grvProdutos.DataSource = produtosBLL.GetAll();
            grvProdutos.DataBind();
        }
        protected void grvProdutos_selectedIndexChanged(object sender, EventArgs e)
        {
            btSalvar.Text = "Atualizar";
            lblMsg.Text = "<h1>Gerenciamento de PRODUTOS : alterando</h1>";
            codProduto = (int)grvProdutos.SelectedValue;
            produto = produtos.Find(pro => pro.IDT_PRODUTO == codProduto).First<PRODUTO>();

            txtCodProduto.Text = produto.IDT_PRODUTO.ToString();
            txtNomeProduto.Text = produto.NOME;
            txtValor.Text = produto.VALOR.ToString();
            lblFoto.Text = produto.FOTO;
            txtDescricao.Text = produto.DESCRICAO;
            imgProduto.Visible = true;
            imgProduto.ImageUrl = "~/Produtos/" + produto.FOTO;

            produtos = null;
            produto = null;                 
        }
        protected void grvProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {//só chama qnd clica em excluir
            codProduto = int.Parse(grvProdutos.DataKeys[e.RowIndex].Value.ToString());
            produto = produtos.Find(pro => pro.IDT_PRODUTO == codProduto).First<PRODUTO>();
            produtos.Delete(produto);
            produtos.SaveChanges();
            produtos = null;
            produto = null;
            BuscarProdutos();
        }
        protected void btExcluir_Click(object sender, EventArgs e)
        {

        }     
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaVirtual.DAO;
using System.Web;

namespace LojaVirtual.BLL
{
    public class Carrinho
    {
        public List<ITEM_VENDA> Itens { get {return BuscarLista();}}
       
        public void AdicionarItem(ITEM_VENDA item)
        {
            List<ITEM_VENDA> lista = Itens;
            //se já existe?
            var resultado = lista.Where(i => i.IDT_PRODUTO == item.IDT_PRODUTO);//lambda
            if (resultado != null && resultado.Count() > 0)
            {
                AtualizarLista(item);
            }
            else
            {
                item.SUBTOTAL = (item.VALOR_UNITARIO * item.QUANTIDADE);
                lista.Add(item);
                HttpContext.Current.Session["lista"] = lista;
            }
        }
        public bool ExcluirItem(int codProduto)
        {
            List<ITEM_VENDA> lista = Itens;
            //se já existe?
            var resultado = lista.Where(i => i.IDT_PRODUTO == codProduto);//lambda
            if (resultado != null && resultado.Count() > 0)
            {
                ITEM_VENDA itemEncontrado = resultado.First();
                lista.Remove(itemEncontrado);
                HttpContext.Current.Session["lista"] = lista;
                return true;
            }
            return false;

        }
        public int QuantidadeTotal()
        {            return Itens.Count;        }
        public decimal ValorTotal()
        {
            decimal total = 0;
            foreach (ITEM_VENDA item in Itens)
            {
                total += (decimal)item.SUBTOTAL;
            }
            return total;
        }
        public int FinalizarVenda(int idCliente, int idtTipoVenda)
        {
            try
            {
                ItemVendaBLL itemVendaBLL = new ItemVendaBLL();
                VendaBLL vendaBLL = new VendaBLL();
                VENDA venda = new VENDA();

                venda.IDT_CLIENTE = idCliente;
                venda.IDT_TIPO_VENDA = idtTipoVenda;
                venda.VALOR_TOTAL = this.ValorTotal();
                //venda.datacadastro = datetime.now;
                vendaBLL.Add(venda);
                vendaBLL.SaveChanges();

                foreach (ITEM_VENDA itemvenda in Itens)
                {
                    itemvenda.IDT_VENDA = venda.IDT_VENDA;
                    itemVendaBLL.Add(itemvenda);
                    itemVendaBLL.SaveChanges();
                }
                itemVendaBLL = null;               
                vendaBLL = null;

                return venda.IDT_VENDA;
            }
            catch
            {
                return 0;
            }
        }    
        private void AtualizarLista(ITEM_VENDA item)
        {
            List<ITEM_VENDA> lista = Itens;
            var resultado = lista.Where(i => i.IDT_PRODUTO == item.IDT_PRODUTO);
            if (resultado != null && resultado.Count() > 0)
            {
                ITEM_VENDA itemEncontrado = resultado.First();
                itemEncontrado.QUANTIDADE += item.QUANTIDADE;
                itemEncontrado.SUBTOTAL = (itemEncontrado.QUANTIDADE* itemEncontrado.VALOR_UNITARIO);
                HttpContext.Current.Session["lista"] = lista;
            }
        }
        private List<ITEM_VENDA> BuscarLista()
        {
            List<ITEM_VENDA> lista;
            if (HttpContext.Current.Session["lista"] != null)
            {
                lista = (List<ITEM_VENDA>)HttpContext.Current.Session["lista"];

            }
            else
            {
                lista = new List<ITEM_VENDA>();        
                
            }
            return lista;
        }
   

    }//p clas
}

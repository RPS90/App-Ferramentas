using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaVirtual.DAO.Interfaces;

namespace LojaVirtual.DAO
{
    public class ProdutoDAO : AbstractCRUD<PRODUTO>, IProdutoDAO
    {
        public int Quantidade { get; set; }
        public PRODUTO BuscarProduto(int idProduto)
        {
            return Find(p => p.IDT_PRODUTO.Equals(idProduto)).First();

        }

    }
}

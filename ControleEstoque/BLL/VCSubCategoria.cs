using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLSubCategoria
    {
        private CADConexao conexao;
        public BLLSubCategoria(CADConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorCategoria(int categoria)
        {
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            return DALobj.LocalizarPorCategoria(categoria);
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            CADSubCategoria DALobj = new CADSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo);
        }
    }
}

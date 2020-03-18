using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategoria
    {
        private CADConexao conexao;
        public BLLCategoria(CADConexao cx)//construtor
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)//verificação, se for igual a zero\/
            {
                throw new Exception("O nome da categoria é obrigatório");//msg erro, pq n tem nada no nome
            }                    
            CADCategoria DALobj = new CADCategoria(conexao);
            DALobj.Incluir(modelo);//método incluir
        }
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");//msg erro, pq precisa ter algum código
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            CADCategoria DALobj = new CADCategoria(conexao);
            DALobj.Alterar(modelo);//método alterar do CADdaCategoria
        }
        public void Excluir(int codigo)
        {
            CADCategoria DALobj = new CADCategoria(conexao);
            DALobj.Excluir(codigo);//método excluir do CADdaCategoria
        }
        public DataTable Localizar(String valor)
        {
            CADCategoria DALobj = new CADCategoria(conexao);
            return DALobj.Localizar(valor);//método localizar do CADdaCategoria
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            CADCategoria DALobj = new CADCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);//método Carrega e procura do CADdaCategoria
        }
    }
}

using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{//numeropatrimonio,patrimonioprov,departamento,sigla,DATACRIACAO,DATAALTERACAO,STATUS
    public class BLLMesa
    {
        private DALConexao conexao;
        public BLLMesa (DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesa modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            }
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            } 
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("O Departamento é obrigatório");
            }
            DALMesa DALobj = new DALMesa(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloMesa modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código do Mesa é obrigatório");
            }
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            }
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            }
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("O Departamento é obrigatório");
            }
            DALMesa DALobj = new DALMesa(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALMesa DALobj = new DALMesa(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALMesa DALobj = new DALMesa(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DALMesa DALobj = new DALMesa(conexao);
            return DALobj.LocalizarApenasAtivos(valor);
        }
        public ModeloMesa CarregaModeloMesa(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALMesa DALobj = new DALMesa(conexao);
            return DALobj.CarregaModeloMesa(codigo);
        }
    }//class
}//namespace
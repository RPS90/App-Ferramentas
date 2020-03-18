using Modelo;
using System;
using System.Data;
using DAL;

namespace BLL
{    
    public class BLLTabelas
    {
        private DALConexao conexao;
        public BLLTabelas(DALConexao cx)
        {            this.conexao = cx;        }
        public void CriarBancoDeDados()//--------------------------------------CriarBanco
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            DALobj.CriarBancoDeDados();
        }
        public DataTable Relacionamento()//------------------------------------Relacionamento
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.Relacionamento();           
        }
        public DataTable LocalizarEspecifico()//-------------------------------Localizar Especifico (Like)
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.LocalizarEspecifico();
        }
        public DataTable LocalizarEspecificoSemLike()//------------------------Localizar Especifico (sem Like)
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.LocalizarEspecificoSemLike();
        }
        #region regras para LISTAGEM (Tabelas e Colunas)
        public DataTable ListarTabelas()//-------------------------------------Listar Tabelas
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarTabelas();
        }
        public DataTable ListarColunasDasTabelas()//---------------------------Listar Colunas
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarColunasDasTabelas();
        }  
        #endregion
        public DataTable TesteDeComando()//------------------------------------Teste, sem retorno
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.TesteDeComando();
        }
        public void TesteDeComandoSemDataTable()//-----------------------------Teste, retorna datatable
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            DALobj.TesteDeComandoSemDataTable();
        }
    }//class
}//namespace
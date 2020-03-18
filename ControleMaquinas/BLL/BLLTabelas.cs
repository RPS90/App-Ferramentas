using System.Data;
using DAL;

namespace BLL
{    
    public class BLLTabelas
    {
        private DALConexao conexao;
        public BLLTabelas(DALConexao cx)
        {            this.conexao = cx;        }
        public void CriarBancoDeDados()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            DALobj.CriarBancoDeDados();
        }
        public DataTable Relacionamento()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.Relacionamento();           
        }
        public DataTable TesteDeComando()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.TesteDeComando();
        }

        #region regras para LISTAR TABELAS
        public DataTable ListarTabelas()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarTabelas();
        }
        public DataTable ListarColunasDaTabelaMesas()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarColunasDaTabelaMesas();
        }//mesas
        public DataTable ListarColunasDaTabelaComputadores()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarColunasDaTabelaComputadores();
        }//computadores
        public DataTable ListarColunasDaTabelaMonitores()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarColunasDaTabelaMonitores();
        }//monitores
        public DataTable ListarColunasDaTabelaUsuarios()
        {
            DALTabelas DALobj = new DALTabelas(conexao);
            return DALobj.ListarColunasDaTabelaUsuarios();
        }//usuarios
        #endregion

    }//class
}//namespace
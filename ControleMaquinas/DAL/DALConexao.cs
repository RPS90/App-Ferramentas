using System;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private MySqlConnection _conexao;
        
        public DALConexao(String dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }
        public MySqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }//class
}//namespaceara mySQL já
using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//Necessida ALTERACOESS!!!
    public class DALMesaUsuario
    {
        private DALConexao conexao;
        public DALMesaUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMesaUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"insert into mesa_usuario (codigo_mesa,codigo_usuario) values (@codigo_mesa,@codigo_usuario); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_usuario", modelo.Codigo_Usuario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloMesaUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR-(Desenvolvendooooo)
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"update mesa_usuario set codigo_mu = @codigo_mu, codigo_mesa = @codigo_mesa, codigo_usuario = @codigo_usuario where codigo_mu = @codigo_mu;";           
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_usuario", modelo.Codigo_Usuario);   
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirUsuario(int codigo_usuario)//<<<lembra q essa variável é temporária!
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_usuario where codigo_usuario = @codigo_usuario;";
            cmd.Parameters.AddWithValue("@codigo_usuario", codigo_usuario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirMesa(int codigo_mesa)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_usuario where codigo_mesa = @codigo_mesa;";
            cmd.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR-(Desenvolvendooooo)
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from mesa_usuario where codigo_mu like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }        
        public ModeloMesaUsuario CarregaModeloMesaUsuario(int codigo_mu)
        {//---------------------------------------------------------------------------------------------------------------------modelo
            ModeloMesaUsuario modelo = new ModeloMesaUsuario();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from mesa_usuario where codigo_mu = @codigo_mu";
            cmd.Parameters.AddWithValue("@codigo", codigo_mu);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo_Mesa = Convert.ToInt32(registro["codigo_mesa"]);
                modelo.Codigo_Usuario = Convert.ToInt32(registro["codigo_usuario"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace

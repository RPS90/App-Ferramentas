using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//Necessita ALTERACOESS!!!
    public class DALMesaComputador
    {
        private DALConexao conexao;
        public DALMesaComputador(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesaComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"insert into mesa_computador (codigo_mesa,codigo_computador) values (@codigo_mesa,@codigo_computador); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_computador", modelo.Codigo_Computador);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); 
            conexao.Desconectar();
        }
        public void Alterar(ModeloMesaComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR-(Desenvolvendooooo)
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"update mesa_computador set codigo_mesa = @codigo_mesa, codigo_computador = @codigo_computador where codigo_mu = @codigo_mu;";     
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_computador", modelo.Codigo_Computador);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirComputador(int codigo_computador)//<<<lembra q essa variável é temporária!
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_computador where codigo_computador = @codigo_computador;";
            cmd.Parameters.AddWithValue("@codigo_computador", codigo_computador);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirMesa(int codigo_mesa)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_computador where codigo_mesa = @codigo_mesa;";
            cmd.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR-(Desenvolvendooooo)
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from mesa_computador where codigo_mu like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }        
        public ModeloMesaComputador CarregaModeloMesaComputador(int codigo_mc)
        {//---------------------------------------------------------------------------------------------------------------------modelo-ok
            ModeloMesaComputador modelo = new ModeloMesaComputador();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from mesa_computador where codigo_mc = @codigo_mc";
            cmd.Parameters.AddWithValue("@codigo", codigo_mc);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();              
                modelo.Codigo_Mesa = Convert.ToInt32(registro["codigo_mesa"]);
                modelo.Codigo_Computador = Convert.ToInt32(registro["codigo_computador"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
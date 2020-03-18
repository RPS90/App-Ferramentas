using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//Necessida ALTERACOESS!!!
    public class DALMesaMonitor
    {
        private DALConexao conexao;
        public DALMesaMonitor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMesaMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"insert into mesa_monitor (codigo_mesa,codigo_monitor) values (@codigo_mesa,@codigo_monitor); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_monitor", modelo.Codigo_Monitor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloMesaMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR-(Desenvolvendooooo)
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"update mesa_monitor set codigo_mu = @codigo_mu, codigo_mesa = @codigo_mesa, codigo_monitor = @codigo_monitor where codigo_mu = @codigo_mu;";
           
            cmd.Parameters.AddWithValue("@codigo_mesa", modelo.Codigo_Mesa);
            cmd.Parameters.AddWithValue("@codigo_monitor", modelo.Codigo_Monitor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirMonitor(int codigo_monitor)//<<<lembra q essa variável é temporária!
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_monitor where codigo_monitor = @codigo_monitor;";
            cmd.Parameters.AddWithValue("@codigo_monitor", codigo_monitor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirMesa(int codigo_mesa)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-ok
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesa_monitor where codigo_mesa = @codigo_mesa;";
            cmd.Parameters.AddWithValue("@codigo_mesa", codigo_mesa);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR-(Desenvolvendooooo)
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from mesa_monitor where codigo_mu like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloMesaMonitor CarregaModeloMesaMonitor(int codigo_mm)
        {//---------------------------------------------------------------------------------------------------------------------modelo
            ModeloMesaMonitor modelo = new ModeloMesaMonitor();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from mesa_monitor where codigo_mm = @codigo_mm";
            cmd.Parameters.AddWithValue("@codigo", codigo_mm);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo_Mesa = Convert.ToInt32(registro["codigo_mesa"]);
                modelo.Codigo_Monitor = Convert.ToInt32(registro["codigo_monitor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
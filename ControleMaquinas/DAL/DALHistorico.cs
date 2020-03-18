using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALHistorico
    {
     private DALConexao conexao;
     public DALHistorico(DALConexao cx)
        {
            this.conexao = cx;
        }
     public void Incluir(ModeloHistorico modelo)
     {//-------------------------------------------------INCLUIR
         MySqlCommand cmd = new MySqlCommand();
         cmd.Connection = conexao.ObjetoConexao;
         cmd.CommandText =
             "insert into historico (historico) values (@historico); select @@IDENTITY;";
         cmd.Parameters.AddWithValue("@historico", modelo.Historico);
         conexao.Conectar();
         modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
         conexao.Desconectar();
     }        
     public DataTable Localizar(String valor)
     {//-------------------------------------------------LOCALIZAR
         DataTable tabela = new DataTable();
         MySqlDataAdapter da = new MySqlDataAdapter(
             "Select * from historico where historico like '%" + valor + "%'", conexao.StringConexao);
         da.Fill(tabela);
         return tabela;
     }
     public ModeloHistorico CarregaModeloHistorico(int codigo)
     {//-------------------------------------------------DATATABLE
         ModeloHistorico modelo = new ModeloHistorico();
         MySqlCommand cmd = new MySqlCommand();
         cmd.Connection = conexao.ObjetoConexao;
         cmd.CommandText = "select * from historico where codigo = @codigo";
         cmd.Parameters.AddWithValue("@codigo", codigo);
         conexao.Conectar();
         MySqlDataReader registro = cmd.ExecuteReader();
         if (registro.HasRows)
         {
             registro.Read();
             modelo.Codigo = Convert.ToInt32(registro["codigo"]);
             modelo.Historico = Convert.ToString(registro["historico"]);
         }
         conexao.Desconectar();
         return modelo;
     }
    }//class
}//namespace
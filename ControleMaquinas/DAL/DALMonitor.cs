using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//numeropatrimonio,patrimonioprov,marca,nserie,departamento,sigla,tipo,estado,datacadastro,ultimaalteracao

    public class DALMonitor
    {
        private DALConexao conexao;
        public DALMonitor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"insert into monitores (numeropatrimonio,patrimonioprov,marca,nserie,departamento,sigla,tipo,estado,datacadastro,ultimaalteracao) " +
"values (@numeropatrimonio,@patrimonioprov,@marca,@nserie,@departamento,@sigla,@tipo,@estado,@datacadastro,@ultimaalteracao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@numeropatrimonio", modelo.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@patrimonioprov", modelo.PatrimonioProv);
            cmd.Parameters.AddWithValue("@marca", modelo.Marca);
            cmd.Parameters.AddWithValue("@nserie", modelo.Nserie);
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);
            cmd.Parameters.AddWithValue("@sigla", modelo.Sigla);
            cmd.Parameters.AddWithValue("@tipo", modelo.Tipo);
            cmd.Parameters.AddWithValue("@estado", modelo.Estado);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@ultimaalteracao", modelo.UltimaAlteracao);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"update monitores set numeropatrimonio = @numeropatrimonio, patrimonioprov = @patrimonioprov,marca = @marca,"+
"nserie = @nserie, departamento = @departamento, sigla = @sigla, tipo = @tipo, estado = @estado, ultimaalteracao =@ultimaalteracao where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.Codigo);
            cmd.Parameters.AddWithValue("@numeropatrimonio", modelo.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@patrimonioprov", modelo.PatrimonioProv);
            cmd.Parameters.AddWithValue("@marca", modelo.Marca);
            cmd.Parameters.AddWithValue("@nserie", modelo.Nserie);
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);
            cmd.Parameters.AddWithValue("@sigla", modelo.Sigla);
            cmd.Parameters.AddWithValue("@tipo", modelo.Tipo);
            cmd.Parameters.AddWithValue("@estado", modelo.Estado);
            //DATA DE CADASTRO NAO ALTERAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            cmd.Parameters.AddWithValue("@ultimaalteracao", modelo.UltimaAlteracao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"delete from monitores where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR  
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from monitores where numeropatrimonio like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from monitores where numeropatrimonio like '%" + valor + "%' and monitores.estado = 'ATIVO'", 
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloMonitor CarregaModeloMonitor(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloMonitor modelo = new ModeloMonitor();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from monitores where codigo = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.NumeroPatrimonio = Convert.ToString(registro["numeropatrimonio"]);
                modelo.PatrimonioProv = Convert.ToString(registro["patrimonioprov"]);
                modelo.Marca = Convert.ToString(registro["marca"]);
                modelo.Nserie = Convert.ToString(registro["nserie"]);
                modelo.Departamento = Convert.ToString(registro["departamento"]);
                modelo.Sigla = Convert.ToString(registro["sigla"]);
                modelo.Tipo = Convert.ToString(registro["tipo"]);
                modelo.Estado = Convert.ToString(registro["estado"]);
                modelo.DataCadastro = Convert.ToString(registro["datacadastro"]);
                modelo.UltimaAlteracao = Convert.ToString(registro["ultimaalteracao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
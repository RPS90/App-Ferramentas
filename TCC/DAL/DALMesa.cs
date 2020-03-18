using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//codigo,numeropatrimonio,patrimonioprov,departamento,sigla,estado,datacadastro,ultimaalteracao
    public class DALMesa
    {
        private DALConexao conexao;
        public DALMesa(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesa modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao; 
            cmd.CommandText =
"insert into mesas (numeropatrimonio,patrimonioprov,departamento,sigla,estado,datacadastro,ultimaalteracao) " +
"values (@numeropatrimonio,@patrimonioprov,@departamento,@sigla,@estado,@datacadastro, @ultimaalteracao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@numeropatrimonio", modelo.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@patrimonioprov", modelo.PatrimonioProv);
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);
            cmd.Parameters.AddWithValue("@sigla", modelo.Sigla);
            cmd.Parameters.AddWithValue("@estado", modelo.Estado);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@ultimaalteracao", modelo.UltimaAlteracao);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();     
        }
        public void Alterar(ModeloMesa modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
"update mesas set numeropatrimonio = @numeropatrimonio, patrimonioprov = @patrimonioprov, departamento = @departamento,"+
"sigla = @sigla, estado = @estado, ultimaalteracao = @ultimaalteracao where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.Codigo);
            cmd.Parameters.AddWithValue("@numeropatrimonio", modelo.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@patrimonioprov", modelo.PatrimonioProv);
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);
            cmd.Parameters.AddWithValue("@sigla", modelo.Sigla);
            cmd.Parameters.AddWithValue("@estado", modelo.Estado);
          //cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro); NAO ALTERAAAAAAAAAAAAAAAAAAAAAAAAA
            cmd.Parameters.AddWithValue("@ultimaalteracao", modelo.UltimaAlteracao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//executeNonQuery não retorna parâmetro algum
            conexao.Desconectar();
        }
        public void Excluir(int codigo) //Vai receber como código, o registro pra remover do banco
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from mesas where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);//deleta pelo código
            conexao.Conectar();//abrir conexao
            cmd.ExecuteNonQuery();
            conexao.Desconectar();//fechar conexao
        }//mudar o delet, não pode deletar da bade de dados
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select mesas.codigo,"+
                "mesas.numeropatrimonio,"+
                "mesas.patrimonioprov,"+
                "mesas.sigla,"+
                "mesas.estado,"+
                "mesas.datacadastro,"+
                "mesas.ultimaalteracao, "+
                "departamentos.departamento from mesas inner join departamentos on mesas.departamento = departamentos.codigo " + 
                "where numeropatrimonio like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select mesas.codigo," +
                "mesas.numeropatrimonio," +
                "mesas.patrimonioprov," +
                "mesas.sigla," +
                "mesas.estado," +
                "mesas.datacadastro," +
                "mesas.ultimaalteracao, " +
                "departamentos.departamento from mesas inner join departamentos on mesas.departamento = departamentos.codigo " +
                "where numeropatrimonio like '%" + valor + "%' and mesas.estado = 'ATIVO'", conexao.StringConexao);
                //"Select * from mesas where numeropatrimonio like '%" + valor + "%' and mesas.estado = 'ATIVO'",                 
            da.Fill(tabela);
            return tabela;
        }
        public ModeloMesa CarregaModeloMesa(int codigo)//metodo
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloMesa modelo = new ModeloMesa();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from mesas where codigo = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.NumeroPatrimonio = Convert.ToString(registro["numeropatrimonio"]);
                modelo.PatrimonioProv = Convert.ToString(registro["patrimonioprov"]);
                modelo.Departamento = Convert.ToInt32(registro["departamento"]);
                modelo.Sigla = Convert.ToString(registro["sigla"]);
                modelo.Estado = Convert.ToString(registro["estado"]);
                modelo.DataCadastro = Convert.ToString(registro["datacadastro"]);
                modelo.UltimaAlteracao = Convert.ToString(registro["ultimaalteracao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloMesa CarregaModeloMesaCopiaSeguranca(int codigo)//metodo
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloMesa modelo = new ModeloMesa();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from mesas where codigo = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.NumeroPatrimonio = Convert.ToString(registro["numeropatrimonio"]);
                modelo.PatrimonioProv = Convert.ToString(registro["patrimonioprov"]);
                modelo.Departamento = Convert.ToInt32(registro["departamento"]);
                modelo.Sigla = Convert.ToString(registro["sigla"]);
                modelo.Estado = Convert.ToString(registro["estado"]);
                modelo.DataCadastro = Convert.ToString(registro["datacadastro"]);
                modelo.UltimaAlteracao = Convert.ToString(registro["ultimaalteracao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
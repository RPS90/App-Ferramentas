using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//codigo,nomeusuario,login,ramal,departamento,email,foto,estado,datacadastro,ultimaalteracao
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloUsuario obj)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into usuarios (nomeusuario,login,ramal,departamento,email,foto,estado,datacadastro,ultimaalteracao) " +
                "values (@nomeusuario,@login,@ramal,@departamento,@email,@foto,@estado,@datacadastro,@ultimaalteracao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nomeusuario", obj.NomeUsuario);
            cmd.Parameters.AddWithValue("@login", obj.Login);
            cmd.Parameters.AddWithValue("@ramal", obj.Ramal);
            cmd.Parameters.AddWithValue("@departamento", obj.Departamento);
            cmd.Parameters.AddWithValue("@email", obj.Email);
            cmd.Parameters.AddWithValue("@foto", obj.Foto);           
            if (obj.Foto == null)//n tem foto
            { 
                cmd.Parameters["@foto"].Value = DBNull.Value;            
            }
            else
            { 
                cmd.Parameters["@foto"].Value = obj.Foto;            
            }
            cmd.Parameters.AddWithValue("@estado", obj.Estado);
            cmd.Parameters.AddWithValue("@datacadastro", obj.DataCadastro);
            cmd.Parameters.AddWithValue("@ultimaalteracao", obj.UltimaAlteracao);
            conexao.Conectar();
            obj.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuarios where (codigo) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario obj)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "update usuarios set nomeusuario = (@nomeusuario), login = (@login), " +
                "ramal = (@ramal), departamento = (@departamento), email = (@email), " +
                "foto = (@foto), estado = (@estado), ultimaalteracao = (@ultimaalteracao) where codigo = (@codigo) ";
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
            cmd.Parameters.AddWithValue("@nomeusuario", obj.NomeUsuario);
            cmd.Parameters.AddWithValue("@login", obj.Login);
            cmd.Parameters.AddWithValue("@ramal", obj.Ramal);
            cmd.Parameters.AddWithValue("@departamento", obj.Departamento);
            cmd.Parameters.AddWithValue("@email", obj.Email);
            cmd.Parameters.AddWithValue("@foto", obj.Foto);          
            if (obj.Foto == null)
            { 
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            { 
                cmd.Parameters["@foto"].Value = obj.Foto;
            }
            cmd.Parameters.AddWithValue("@estado", obj.Estado);
            //data de cadastro nao ALTERAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            cmd.Parameters.AddWithValue("@ultimaalteracao", obj.UltimaAlteracao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select usuarios.codigo," +
                "usuarios.nomeusuario," +
                "usuarios.login," +
                "usuarios.ramal," +
                "departamentos.departamento," +
                "usuarios.email," +
                "usuarios.foto," +
                "usuarios.estado," +
                "usuarios.datacadastro," +
                "usuarios.ultimaalteracao from usuarios inner join departamentos on usuarios.departamento = departamentos.codigo " +
                "where nomeusuario like '%" + valor + "%'", conexao.StringConexao);            
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select usuarios.codigo," +
                "usuarios.nomeusuario," +
                "usuarios.login," +
                "usuarios.ramal," +
                "departamentos.departamento," + //inner join aqui
                "usuarios.email," +
                "usuarios.foto," +
                "usuarios.estado," +
                "usuarios.datacadastro," +
                "usuarios.ultimaalteracao from usuarios inner join departamentos on usuarios.departamento = departamentos.codigo " +
                "where nomeusuario like '%" + valor + "%' and usuarios.estado = 'ATIVO'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarApenasAtivosAZ(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select usuarios.codigo," +
                "usuarios.nomeusuario," +
                "usuarios.login," +
                "usuarios.ramal," +
                "departamentos.departamento," + //inner join aqui
                "usuarios.email," +
                "usuarios.foto," +
                "usuarios.estado," +
                "usuarios.datacadastro," +
                "usuarios.ultimaalteracao from usuarios inner join departamentos on usuarios.departamento = departamentos.codigo " +
                "where nomeusuario like '%" + valor + "%' and usuarios.estado = 'ATIVO' order by usuarios.nomeusuario asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloUsuario modelo = new ModeloUsuario();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuarios where (codigo) = " + codigo.ToString();
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.NomeUsuario = Convert.ToString(registro["nomeusuario"]);
                modelo.Login = Convert.ToString(registro["login"]);
                modelo.Ramal = Convert.ToString(registro["ramal"]);
                modelo.Departamento = Convert.ToInt32(registro["departamento"]);
                modelo.Email = Convert.ToString(registro["email"]);
            try{modelo.Foto = (byte[])registro["foto"];} catch { }
                modelo.Estado = Convert.ToString(registro["estado"]);
                modelo.DataCadastro = Convert.ToString(registro["datacadastro"]);
                modelo.UltimaAlteracao = Convert.ToString(registro["ultimaalteracao"]);
            }
            conexao.Desconectar();
            return modelo;
        }       
    }//class
}//namespace
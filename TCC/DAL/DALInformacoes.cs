using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DALInformacoes
    {
        private DALConexao conexao;
        public DALInformacoes(DALConexao cx)
        { this.conexao = cx; }
        public void IncluirDepartamento(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into departamentos (departamento) values (@departamento); select @@IDENTITY;";         
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);    
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirMarca(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into marcas (marca) values (@marca); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@marca", modelo.Marca);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void AlterarDepartamento(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update departamentos set departamento = @departamento where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.Codigo);            
            cmd.Parameters.AddWithValue("@departamento", modelo.Departamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void AlterarMarca(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update marcas set marca = @marca where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.Codigo);
            cmd.Parameters.AddWithValue("@marca", modelo.Marca);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirDepartamento(int codigo) 
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from departamentos where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirMarca(int codigo) 
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from marcas where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable LocalizarDepartamento(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from departamentos where departamento like '%" + valor + "%'",
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarMarca(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from marcas where marca like '%" + valor + "%'", 
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }       
        public ModeloInformacoes CarregaModeloDepartamento(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloInformacoes modelo = new ModeloInformacoes();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from departamentos where codigo = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);                
                modelo.Departamento = Convert.ToString(registro["departamento"]);               
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloInformacoes CarregaModeloMarca(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            ModeloInformacoes modelo = new ModeloInformacoes();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from marcas where codigo = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.Marca = Convert.ToString(registro["marca"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
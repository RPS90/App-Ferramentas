using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using System.Data;

namespace DAL
{
    public class CADFornecedor//ARRUMAR TODO ESSE CODIGO
    {
        private CADConexao conexao;

        public CADFornecedor(CADConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fornecedor (for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado) " +
            "values (@nome,@cnpj,@cep,@endereco,@bairro,@endnumero,@fone,@email,@cidade,@estado); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome"     , obj.ForNome);
            cmd.Parameters.AddWithValue("@cnpj"     , obj.ForCNPJ);
            cmd.Parameters.AddWithValue("@cep"      , obj.ForCEP);
            cmd.Parameters.AddWithValue("@endereco" , obj.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro"   , obj.ForBairro);
            cmd.Parameters.AddWithValue("@endnumero", obj.ForEndNumero);
            cmd.Parameters.AddWithValue("@fone"     , obj.ForFone);
            cmd.Parameters.AddWithValue("@email"    , obj.ForEmail);
            cmd.Parameters.AddWithValue("@cidade"   , obj.ForCidade);
            cmd.Parameters.AddWithValue("@estado"   , obj.ForEstado);          

            conexao.Conectar();
            obj.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Fornecedor where (for_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloFornecedor obj)
        {//for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Fornecedor SET for_nome = (@nome), "+
           "for_cnpj = (@cnpj), " +
           "for_cep = (@cep)," +
           "for_endereco = (@endereco)," +
           "for_bairro = (@bairro)," +
           "for_endnumero = (@endnumero)," +
           "for_fone = (@fone)," +
           "for_email = (@email)," +
           "for_cidade = (@cidade)," +
           "for_estado = (@estado) WHERE for_cod = (@codigo) ";

            cmd.Parameters.AddWithValue("@nome", obj.ForNome);
            cmd.Parameters.AddWithValue("@cnpj", obj.ForCNPJ);
            cmd.Parameters.AddWithValue("@cep", obj.ForCEP);
            cmd.Parameters.AddWithValue("@endereco", obj.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", obj.ForBairro);
            cmd.Parameters.AddWithValue("@endnumero", obj.ForEndNumero);
            cmd.Parameters.AddWithValue("@fone", obj.ForFone);
            cmd.Parameters.AddWithValue("@email", obj.ForEmail);
            cmd.Parameters.AddWithValue("@cidade", obj.ForCidade);
            cmd.Parameters.AddWithValue("@estado", obj.ForEstado);
            cmd.Parameters.AddWithValue("@codigo", obj.ForCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where For_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where (for_cod) =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {// for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCNPJ = Convert.ToString(registro["for_cnpj"]);
                modelo.ForCEP = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);

            }
            return modelo;
        }
    }
}

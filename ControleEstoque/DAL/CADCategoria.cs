using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CADCategoria
    {
        private CADConexao conexao;
        public CADCategoria(CADConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo) 
        {//mesclando comando sql com C#, comando incluir para tabela CATEGORIA do banco de dados
            SqlCommand cmd = new SqlCommand();// criei o comando
            cmd.Connection = conexao.ObjetoConexao; //Defini qual conexao meu comando vai usar
            cmd.CommandText = "insert into categoria(cat_nome) values (@nome); select @@IDENTITY;"; //Defini qual comando ele vai executar
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome); //parâmetros do comando
            conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());//executeScalar retorna valor
            conexao.Desconectar();
            //using Modelo;
            //using System.Data.SqlClient;
        }
        public void Alterar(ModeloCategoria modelo)
        {//Alterar da tabela CATEGORIA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//executeNonQuery não retorna parâmetro algum
            conexao.Desconectar();
        }
        public void Excluir(int codigo) //Vai receber como código, o registro pra remover do banco
        {//Excluir da Tabela CATEGORIA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);//deleta pelo código
            conexao.Conectar();//abrir conexao
            cmd.ExecuteNonQuery();
            conexao.Desconectar();//fechar conexao
        }

        public DataTable Localizar(String valor)
        {//método localizar, 'selecet' do SQL
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria where cat_nome like '%" +
                valor + "%'", conexao.StringConexao);//sqlDataAdapter, precisa de conexao, pois já tem um q n funciona
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {//método para pegar info, procurar e preencher objeto categoria
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//execute reader, retorna VARIAS info
            //DataReader = Ler e acessar info retornada por um comando
            if (registro.HasRows)//se tem alguma linha no resultado da pesquisa
            {
                registro.Read();//carrega informações
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);         
            }
            conexao.Desconectar();//fechar conexao
            return modelo;//retorna p usuario modelo carregado
        }
    }
}

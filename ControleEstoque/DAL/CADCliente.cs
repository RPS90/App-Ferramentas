using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class CADCliente
    {
        private CADConexao conexao;
        public CADCliente(CADConexao cx)
        {
            this.conexao = cx;
        }
        //Incluir
        public void Incluir(ModeloCliente modelo)
        {//mesclando comando sql com C#, comando incluir para tabela CATEGORIA do banco de dados
            SqlCommand cmd = new SqlCommand();// criei o comando
            cmd.Connection = conexao.ObjetoConexao; //Defini qual conexao meu comando vai usar
            cmd.CommandText = "insert into cliente(cli_nome, cli_cpfcnpj, cli_rsocial, cli_cep, cli_endereco, cli_fone, cli_email, cli_endNumero,"+
            "cli_cidade, cli_estado) values (@cli_nome, @cli_cpfcnpj, @cli_rsocial, @cli_cep, @cli_endereco," +
            "@cli_fone, @cli_email, @cli_endNumero, @cli_cidade, @cli_estado); select @@IDENTITY;"; //Defini qual comando ele vai executar
            cmd.Parameters.AddWithValue("@cli_nome", modelo.CliNome); //parâmetros do comando
            cmd.Parameters.AddWithValue("@cli_cpfcnpj", modelo.Clicpfcnpj);
            cmd.Parameters.AddWithValue("@cli_rsocial", modelo.CliRSocial);       
            cmd.Parameters.AddWithValue("@cli_cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@cli_endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@cli_fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cli_email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@cli_endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cli_cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cli_estado", modelo.CliEstado);

            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());//executeScalar retorna valor
            conexao.Desconectar();
            //using Modelo;
            //using System.Data.SqlClient;
        }
        //alterar
        public void Alterar(ModeloCliente modelo)
        {//Alterar da tabela CATEGORIA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cliente set " +
            "cli_nome = @cli_nome," +
            "cli_cpfcnpj = @cli_cpfcnpj," +
            "cli_rsocial = @cli_rsocial, " +
        
            "cli_cep = @ cli_cep, " +
            "cli_endereco = @cli_endereco" +
            "cli_fone = @cli_fone, " +
            "cli_email = @cli_email, " +
            "cli_endNumero = @cli_endNumero," +
            "cli_cidade = @cli_cidade, " +
            "cli_estado = @cli_estado where cli_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", modelo.CliCod);
            cmd.Parameters.AddWithValue("@cli_nome", modelo.CliNome); 
            cmd.Parameters.AddWithValue("@cli_cpfcnpj", modelo.Clicpfcnpj);
            cmd.Parameters.AddWithValue("@cli_rsocial", modelo.CliRSocial);
    
            cmd.Parameters.AddWithValue("@cli_cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@cli_endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@cli_fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cli_email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@cli_endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cli_cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@cli_estado", modelo.CliEstado);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();//executeNonQuery não retorna parâmetro algum
            conexao.Desconectar();
        }
        //excluir 
        public void Excluir(int codigo) //Vai receber como código, o registro pra remover do banco
        {//Excluir da Tabela CATEGORIA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where cli_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);//deleta pelo código
            conexao.Conectar();//abrir conexao
            cmd.ExecuteNonQuery();
            conexao.Desconectar();//fechar conexao
        }
        public DataTable Localizar(String valor)
        {//método localizar,apenas pelo nome
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cliente where cli_nome like '%" +
                valor + "%'", conexao.StringConexao);//sqlDataAdapter, precisa de conexao, pois já tem um q n funciona
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCliente CarregaModeloCliente(int codigo)
        {//método para pegar info, procurar e preencher objeto categoria
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = @codigo";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//execute reader, retorna VARIAS info
            //DataReader = Ler e acessar info retornada por um comando
            if (registro.HasRows)//se tem alguma linha no resultado da pesquisa
            {
                registro.Read();//carrega informações
                modelo.CliCod       = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome      = Convert.ToString(registro["cli_nome"]);
                modelo.Clicpfcnpj   = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRSocial   = Convert.ToString(registro["cli_rsocial"]);

                modelo.CliCep       = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco  = Convert.ToString(registro["cli_endereco"]);
                modelo.CliFone      = Convert.ToString(registro["cli_fone"]);
                modelo.CliEmail     = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade    = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado    = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();//fechar conexao
            return modelo;//retorna p usuario modelo carregado
        }
        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {//método para pegar info, procurar e preencher objeto categoria
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cpfcnpj = @cpfcnpj";//+ codigo.ToString();
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//execute reader, retorna VARIAS info
            //DataReader = Ler e acessar info retornada por um comando
            if (registro.HasRows)//se tem alguma linha no resultado da pesquisa
            {
                registro.Read();//carrega informações
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.Clicpfcnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRSocial = Convert.ToString(registro["cli_rsocial"]);
      
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
            }
            conexao.Desconectar();//fechar conexao
            return modelo;//retorna p usuario modelo carregado
        }








    }
}

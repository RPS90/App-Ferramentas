using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;
namespace DAL
{//codigo,ip,marca,modelopc,nserie,numeropatrimonio,nomemaquina,patrimonioprov,sigla,estado,datacadastro,ultimaalteracao,tipo
    public class DALComputador
    {
        private DALConexao conexao;
        public DALComputador(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            MySqlCommand cmd = new MySqlCommand();// criei o comando
            cmd.Connection = conexao.ObjetoConexao; //Defini qual conexao meu comando vai usar
            cmd.CommandText =
"insert into computadores(ip,marca,modelopc,nserie,numeropatrimonio,nomemaquina,patrimonioprov,sigla,estado,datacadastro,ultimaalteracao,tipo) " +
"values (@ip,@marca,@modelopc,@nserie,@numeropatrimonio,@nomemaquina,@patrimonioprov,@sigla,@estado, @datacadastro,@ultimaalteracao, @tipo); select @@IDENTITY;"; //Defini qual comando ele vai executar           
            //não vai o codigo pq é gerado no sql, AUTOINCREMENT            
            cmd.Parameters.AddWithValue("@ip",                  modelo.IP);
            cmd.Parameters.AddWithValue("@marca",               modelo.Marca);
            cmd.Parameters.AddWithValue("@modelopc",            modelo.ModeloPC);
            cmd.Parameters.AddWithValue("@nserie",              modelo.Nserie);
            cmd.Parameters.AddWithValue("@numeropatrimonio",    modelo.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@nomemaquina",         modelo.NomeMaquina);
            cmd.Parameters.AddWithValue("@patrimonioprov",      modelo.PatrimonioProv);
            cmd.Parameters.AddWithValue("@sigla",               modelo.Sigla);
            cmd.Parameters.AddWithValue("@estado", modelo.Estado);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@ultimaalteracao", modelo.UltimaAlteracao);
            cmd.Parameters.AddWithValue("@tipo", modelo.Tipo);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());//executeScalar retorna valor
            conexao.Desconectar();           
        }
        public void Alterar(ModeloComputador obj)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = 
                "update computadores set numeropatrimonio = (@numeropatrimonio), ip = (@ip),marca = (@marca), "+
                "modelopc = (@modelopc), nserie = (@nserie), nomemaquina = (@nomemaquina), patrimonioprov = (@patrimonioprov), sigla = (@sigla), "+
                "estado = (@estado), ultimaalteracao = (@ultimaalteracao), tipo = (@tipo) where codigo = (@codigo);";
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);           
            cmd.Parameters.AddWithValue("@ip", obj.IP);
            cmd.Parameters.AddWithValue("@marca", obj.Marca);
            cmd.Parameters.AddWithValue("@modelopc", obj.ModeloPC);
            cmd.Parameters.AddWithValue("@nserie", obj.Nserie);
            cmd.Parameters.AddWithValue("@numeropatrimonio", obj.NumeroPatrimonio);
            cmd.Parameters.AddWithValue("@nomemaquina", obj.NomeMaquina);
            cmd.Parameters.AddWithValue("@patrimonioprov", obj.PatrimonioProv);
            cmd.Parameters.AddWithValue("@sigla", obj.Sigla);
            cmd.Parameters.AddWithValue("@estado", obj.Estado);
            //datacadastro nao altera, tem q permanecer o mesmo sempre, ENTÕO NAO ALTERA
            cmd.Parameters.AddWithValue("@ultimaalteracao", obj.UltimaAlteracao);
            cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//executeNonQuery não retorna parâmetro algum
            conexao.Desconectar();
        }
        public void Excluir(int codigo) //Vai receber como código, o registro pra remover do banco
        {//---------------------------------------------------------------------------------------------------------------------Excluir
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from computadores where codigo = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);//deleta pelo código
            conexao.Conectar();//abrir conexao
            cmd.ExecuteNonQuery();
            conexao.Desconectar();//fechar conexao
        }//mudar o delet, não pode deletar da bade de dados
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------Localizar
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select "+
                "computadores.codigo,"+
                "computadores.ip,"+
                "marcas.marca,"+
                "computadores.modelopc,"+
                "computadores.nserie,"+
                "computadores.numeropatrimonio,"+
                "computadores.nomemaquina,"+
                "computadores.patrimonioprov,"+
                "computadores.sigla,"+
                "computadores.estado,"+
                "computadores.datacadastro,"+
                "computadores.ultimaalteracao,"+
                "computadores.tipo from computadores "+
                "inner join marcas on computadores.marca = marcas.codigo "+
                "where numeropatrimonio like '%" + valor + "%'", 
                conexao.StringConexao);//sqlDataAdapter, precisa de conexao, pois já tem um q n funciona
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------Localizar APENAS ATIVOS
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from computadores where numeropatrimonio like '%" + valor + "%' and computadores.estado = 'ATIVO'", 
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloComputador CarregaModeloComputador(int codigo)
        {//------------------------------------------------------------------método para pegar info, procurar e preencher objeto categoria
            ModeloComputador modelo = new ModeloComputador();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from computadores where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            MySqlDataReader registro = cmd.ExecuteReader();
            //execute reader, retorna VARIAS info
            //DataReader = Ler e acessar info retornada por um comando
            if (registro.HasRows)//se tem alguma linha no resultado da pesquisa
            {//carrega informações
                registro.Read();
                modelo.Codigo               = Convert.ToInt32(registro["codigo"]);                
                modelo.IP                   = Convert.ToString(registro["ip"]);
                modelo.Marca = Convert.ToInt32(registro["marca"]);
                modelo.ModeloPC             = Convert.ToString(registro["modelopc"]);
                modelo.Nserie               = Convert.ToString(registro["nserie"]);
                modelo.NumeroPatrimonio     = Convert.ToString(registro["numeropatrimonio"]);
                modelo.NomeMaquina          = Convert.ToString(registro["nomemaquina"]);
                modelo.PatrimonioProv       = Convert.ToString(registro["patrimonioprov"]);
                modelo.Sigla                = Convert.ToString(registro["sigla"]);
                modelo.Estado               = Convert.ToString(registro["estado"]);
                modelo.DataCadastro         = Convert.ToString(registro["datacadastro"]);
                modelo.UltimaAlteracao      = Convert.ToString(registro["ultimaalteracao"]);
                modelo.Tipo                 = Convert.ToString(registro["tipo"]);
            }
            conexao.Desconectar();
            return modelo;//retorna modelo carregado do select * from computadores where cod é oq vc inseriu
        }        
    }//class
}//namespace

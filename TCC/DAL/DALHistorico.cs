using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;

namespace DAL
{//codigo,acao,descricao,historicodata
    public class DALHistorico
    {
        private DALConexao conexao;
        public DALHistorico(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloHistorico modelo)
        {//-----------------------------------------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into historico (acao,descricao,historicodata,cod_computador,cod_mesa,cod_monitor,cod_usuario)"+ 
                " values (@acao,@descricao,@historicodata,@cod_computador,@cod_mesa,@cod_monitor,@cod_usuario); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@acao", modelo.Acao);       
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@historicodata", modelo.HistoricoData);
            cmd.Parameters.AddWithValue("@cod_computador", modelo.COD_computador);
            cmd.Parameters.AddWithValue("@cod_mesa", modelo.COD_mesa);
            cmd.Parameters.AddWithValue("@cod_monitor", modelo.COD_monitor);
            cmd.Parameters.AddWithValue("@cod_usuario", modelo.COD_usuario);    
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirComputadorHistorico(ModeloHistorico modelo)
        {//-----------------------------------------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into historico (acao,descricao,historicodata,cod_computador)" +
                " values (@acao,@descricao,@historicodata,@cod_computador); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@acao", modelo.Acao);        
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@historicodata", modelo.HistoricoData);
            cmd.Parameters.AddWithValue("@cod_computador", modelo.COD_computador);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirMesaHistorico(ModeloHistorico modelo)
        {//-----------------------------------------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into historico (acao,descricao,historicodata,cod_mesa)" +
                " values (@acao,@descricao,@historicodata,@cod_mesa); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@acao", modelo.Acao);            
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@historicodata", modelo.HistoricoData);
            cmd.Parameters.AddWithValue("@cod_mesa", modelo.COD_mesa);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirMonitorHistorico(ModeloHistorico modelo)
        {//-----------------------------------------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into historico (acao,descricao,historicodata,cod_monitor)" +
                " values (@acao,@descricao,@historicodata,@cod_monitor); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@acao", modelo.Acao);           
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@historicodata", modelo.HistoricoData);
            cmd.Parameters.AddWithValue("@cod_monitor", modelo.COD_monitor);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void IncluirUsuarioHistorico(ModeloHistorico modelo)
        {//-----------------------------------------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into historico (acao,descricao,historicodata,cod_usuario)" +
                " values (@acao,@descricao,@historicodata,@cod_usuario); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@acao", modelo.Acao);          
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@historicodata", modelo.HistoricoData);
            cmd.Parameters.AddWithValue("@cod_usuario", modelo.COD_usuario);
            conexao.Conectar();
            modelo.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }                    
        public DataTable Localizar(String valor)
        {//-------------------------------------------------LOCALIZAR
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, "+
                " historico.campovazio as marca, historico.campovazio as dp, historico.campovazio as item " +
                " from historico where acao like '%cria%' union " + //pra exibir o criação do banco
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, computadores.marca, " +
                " historico.campovazio as dp, computadores.numeropatrimonio as item " +
                " from historico  " +
                " inner join computadores on historico.cod_computador = computadores.codigo " +
                " where computadores.numeropatrimonio like '%" + valor + "%' " +
                " union  " +
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, monitores.marca, " +
                " historico.campovazio as dp, monitores.numeropatrimonio as item  " +
                " from historico  " +
                " inner join monitores    on historico.cod_monitor = monitores.codigo " +
                " where monitores.numeropatrimonio like '%" + valor + "%' " +
                " union  " +
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, historico.campovazio, " +
                " mesas.departamento as dp, mesas.numeropatrimonio as item " +
                " from historico " +
                " inner join mesas        on historico.cod_mesa = mesas.codigo  " +
                " where mesas.numeropatrimonio like '%" + valor + "%' " +
                " union  " +
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, historico.campovazio, " +
                " usuarios.departamento as dp, usuarios.nomeusuario as item " +
                " from historico  " +
                " inner join usuarios     on historico.cod_usuario = usuarios.codigo " +
                " where usuarios.nomeusuario like '%" + valor + "%' " +
                " order by codigo asc; " 
                ,conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }        
        public DataTable LocalizarComFiltros(String valorPesquisa, String valorDataDe, String valorDataAte,
            int valorDepartamento, int valorMarca, String valorAcao, String valorEstado, String Operacao)
        {// 2=Data, 3=Departamento, 4=Marca, 5=Estado, 6=Ação 
            string FiltroDeData =       " and historicodata BETWEEN '" + valorDataDe + "' AND '" + valorDataAte + "' "; //funciona
            string FiltroDepartamento = " and departamento = '" + valorDepartamento + "' "; //testar        
            string FiltroMarca =        " and marca = '" + valorMarca + "' ";// testar
            string FiltroAcao =         " and acao = '" + valorAcao + "' "; //funciona
            string FiltroEstado =       " and estado = '" + valorEstado + "' ";//funciona
            if (Operacao.Contains("2"))
            {
                FiltroDeData = " and historicodata BETWEEN '" + valorDataDe + "' AND '" + valorDataAte + "' ";
            }            else { FiltroDeData = ""; }
            if (Operacao.Contains("3"))
            {            
                FiltroDepartamento = " and departamento = '" + valorDepartamento + "' ";    
            }            else { FiltroDepartamento = ""; }
            if (Operacao.Contains("4"))
            {
                FiltroMarca = " and marca = '" + valorMarca + "' ";
            }            else { FiltroMarca = ""; }            
            if (Operacao.Contains("5"))
            {
                FiltroEstado = " and estado = '" + valorEstado + "' ";
            }            else { FiltroEstado = ""; }
            if (Operacao.Contains("6"))
            {
                FiltroAcao = " and acao like '%" + valorAcao + "%' ";
            }            else { FiltroAcao = ""; }
            //string FiltrosDePesquisa = FiltroDeData + FiltroDepartamento + FiltroMarca + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaComputador = FiltroDeData + FiltroMarca + FiltroAcao + FiltroEstado;            
            string FiltrosDePesquisaMonitor = FiltroDeData + FiltroMarca + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaMesa = FiltroDeData + FiltroDepartamento + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaUsuario = FiltroDeData + FiltroDepartamento + FiltroAcao + FiltroEstado;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, computadores.marca, "+
                " historico.campovazio as dp, computadores.numeropatrimonio as item "+
                " from historico  "+
                " inner join computadores on historico.cod_computador = computadores.codigo "+
                " where computadores.numeropatrimonio like '%" + valorPesquisa + "%' " + FiltrosDePesquisaComputador +  
    
                " union  "+
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, monitores.marca, "+
                " historico.campovazio as dp, monitores.numeropatrimonio as item  "+
                " from historico  "+
                " inner join monitores    on historico.cod_monitor = monitores.codigo "+
                " where monitores.numeropatrimonio like '%" + valorPesquisa + "%' " + FiltrosDePesquisaMonitor +  
               
                " union  "+
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, historico.campovazio, "+
                " mesas.departamento as dp, mesas.numeropatrimonio as item "+
                " from historico "+
                " inner join mesas        on historico.cod_mesa = mesas.codigo  "+
                " where mesas.numeropatrimonio like '%" + valorPesquisa + "%' " + FiltrosDePesquisaMesa +  
              
                " union  "+
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, historico.campovazio, "+ 
                " usuarios.departamento as dp, usuarios.nomeusuario as item "+
                " from historico  "+
                " inner join usuarios     on historico.cod_usuario = usuarios.codigo "+
                " where usuarios.nomeusuario like '%" + valorPesquisa + "%' " + FiltrosDePesquisaUsuario +  

                " order by codigo asc; "
                ,conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarComFiltrosEspecifico(String valorSelecao, String valorPesquisa, String valorDataDe, String valorDataAte,
            int valorDepartamento, int valorMarca, String valorAcao, String valorEstado, String Operacao)
        {   
            //tira do plural            
            string valorSelecaoSingular = "";
            string valorSelecaoNomeNumero = "";
            string campo0 = "";
            string campo1 = "";
            string campo2 = "";
            if (valorSelecao == "usuarios")
            { valorSelecaoSingular = "usuario"; valorSelecaoNomeNumero = "nomeusuario";
                campo0 = "historico"; campo1 = "campovazio"; campo2 = "departamento";
            }
            if (valorSelecao == "computadores")
            { valorSelecaoSingular = "computador"; valorSelecaoNomeNumero = "numeropatrimonio";
                campo0 = "computadores"; campo1 = "marca"; campo2 = "campovazio";
            }
            if (valorSelecao == "mesas")
            { valorSelecaoSingular = "mesa"; valorSelecaoNomeNumero = "numeropatrimonio";
                campo0 = "historico"; campo1 = "campovazio"; campo2 = "departamento";
            }
            if (valorSelecao == "monitores")
            { valorSelecaoSingular = "monitor"; valorSelecaoNomeNumero = "numeropatrimonio";
                campo0 = "monitores"; campo1 = "marca"; campo2 = "campovazio";
            }            
            // 2=Data, 3=Departamento, 4=Marca, 5=Estado, 6=Ação 
            string FiltroDeData = " and historicodata BETWEEN '" + valorDataDe + "' AND '" + valorDataAte + "' "; //funciona
            string FiltroDepartamento = " and departamento = '" + valorDepartamento + "' "; //testar        
            string FiltroMarca = " and marca = '" + valorMarca + "' ";// testar
            string FiltroAcao = " and acao = '" + valorAcao + "' "; //funciona
            string FiltroEstado = " and estado = '" + valorEstado + "' ";//funciona
            if (Operacao.Contains("2"))
            {
                FiltroDeData = " and historicodata BETWEEN '" + valorDataDe + "' AND '" + valorDataAte + "' ";
            }            else { FiltroDeData = ""; }
            if (Operacao.Contains("3"))
            {
                FiltroDepartamento = " and departamento = '" + valorDepartamento + "' ";
            }            else { FiltroDepartamento = ""; }
            if (Operacao.Contains("4"))
            {
                FiltroMarca = " and marca = '" + valorMarca + "' ";
            }            else { FiltroMarca = ""; }
            if (Operacao.Contains("5"))
            {
                FiltroEstado = " and estado = '" + valorEstado + "' ";
            }            else { FiltroEstado = ""; }
            if (Operacao.Contains("6"))
            {
                FiltroAcao = " and acao like '%" + valorAcao + "%' ";
            }            else { FiltroAcao = ""; }
            //string FiltrosDePesquisa = FiltroDeData + FiltroDepartamento + FiltroMarca + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaComputador = FiltroDeData + FiltroMarca + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaMonitor = FiltroDeData + FiltroMarca + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaMesa = FiltroDeData + FiltroDepartamento + FiltroAcao + FiltroEstado;
            string FiltrosDePesquisaUsuario = FiltroDeData + FiltroDepartamento + FiltroAcao + FiltroEstado;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(                
                " select historico.codigo, historico.acao, historico.descricao, historico.historicodata, "+campo0+"."+campo1+" as marca, " +
                " " + valorSelecao + "." + campo2 + " as dp, " + valorSelecao + "." + valorSelecaoNomeNumero + " as item " +
                " from historico  " +
                " inner join " + valorSelecao + "     on historico.cod_" + valorSelecaoSingular + " = " + valorSelecao + ".codigo " +
                " where " + valorSelecao + "." + valorSelecaoNomeNumero + " like '%" + valorPesquisa + "%' " + FiltrosDePesquisaUsuario +
                " order by codigo asc; "            
                , conexao.StringConexao);
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
            {//codigo,acao,descricao,historicodata
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["codigo"]);
                modelo.Acao = Convert.ToString(registro["acao"]);          
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.HistoricoData = Convert.ToString(registro["historicodata"]);
                modelo.COD_computador = Convert.ToInt32(registro["cod_computador"]);
                modelo.COD_mesa = Convert.ToInt32(registro["cod_mesa"]);
                modelo.COD_monitor = Convert.ToInt32(registro["cod_monitor"]);
                modelo.COD_usuario = Convert.ToInt32(registro["cod_usuario"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }//class
}//namespace
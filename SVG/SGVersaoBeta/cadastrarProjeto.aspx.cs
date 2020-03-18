using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace SGVersaoBeta
{
    public partial class cadastrarProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbDataAdapter da2 = new OleDbDataAdapter();
            DataSet ds2 = new DataSet();
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "select Nome from DadosClientes";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            da2.SelectCommand = cmd2;
            da2.Fill(ds2, "Nome");
            nomeCliente.DataSource = ds2.Tables["Nome"];
            nomeCliente.DataValueField = "Nome";
            nomeCliente.DataBind();
            conn2.Dispose();
            cmd2.Dispose();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
           OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from Projetos where NomeProjeto = '" + txtNome.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lblRespostaServer.Text = "Esse projeto já existe na base de dados";
            }
            else
            {
                string nomeRedator = Session["LoginUsuario"].ToString();
                conn.Close();
                cmd.CommandText = "insert into Projetos(NomeProjeto, DataInicio, DataEntrega, Cliente, Descricao, Setor, Tipo, StatusProjeto, Relatorio, RedatorRelatorio) values ('" + txtNome.Text + "', '" + txtDataInicio.Text + "', '" + txtDataFim.Text + "', '" + nomeCliente.Text + "', '" + descricaoProjeto.Text + "', '" + setorProjeto.Text + "', '" + tipoProjeto.Text + "', '" + statusProjeto.Text + "', '" + relatorioProjeto.Text + "', '" + nomeRedator + "')";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();

                string data = DateTime.Now.ToString();
                string nome = Session["LoginUsuario"].ToString();
                OleDbConnection conn2 = new OleDbConnection();
                OleDbCommand cmd2 = new OleDbCommand();
                conn2.ConnectionString = Conexao.ConexaoStr;
                cmd2.Connection = conn2;
                cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Cadastrou o projeto " + txtNome.Text + "', '" + data + "')";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                cmd2.ExecuteScalar();
                conn2.Close();
                conn2.Dispose();

                txtNome.Text = "";
                txtDataInicio.Text = "";
                txtDataFim.Text = "";
                descricaoProjeto.Text = "";
                relatorioProjeto.Text = "";
                statusProjeto.Text = "";
                lblRespostaServer.Text = "Projeto cadastrado no sistema.";

            }
            conn.Close();
            conn.Dispose();


        }
    }
}
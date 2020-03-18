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
    public partial class ConsultarDadosProjetos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select NomeProjeto from Projetos";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(ds,"NomeProjeto");
            dropNomeProjetos.DataSource = ds.Tables["NomeProjeto"];
            dropNomeProjetos.DataValueField = "NomeProjeto";
            dropNomeProjetos.DataBind();
            conn.Close();
            conn.Dispose();

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbDataReader dr2;
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "select * from Projetos where NomeProjeto = '" + dropNomeProjetos.Text + "'";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblNomeProjeto.Text = dr2["NomeProjeto"].ToString();
                lblDataInicioProjeto.Text = dr2["DataInicio"].ToString();
                lblDataEntregaProjeto.Text = dr2["DataEntrega"].ToString();
                lblNomeClienteProjeto.Text = dr2["Cliente"].ToString();
                lblDescricaoProjeto.Text = dr2["Descricao"].ToString();
                lblSetorProjeto.Text = dr2["Setor"].ToString();
                lblTipoProjeto.Text = dr2["Tipo"].ToString();
                lblStatusProjetos.Text = dr2["StatusProjeto"].ToString();
                lblUltimorelatorio.Text = dr2["Relatorio"].ToString();
                lblRedatorRelatorio.Text = dr2["RedatorRelatorio"].ToString();
                lblRespostaServer.Text = "Dados carregados com sucesso";

            }
            else
            {
                lblRespostaServer.Text = "As informações do cliente " + dropNomeProjetos.Text + " não foram encontradas";
            }
            conn2.Close();
            conn2.Dispose();

        }

    }
}
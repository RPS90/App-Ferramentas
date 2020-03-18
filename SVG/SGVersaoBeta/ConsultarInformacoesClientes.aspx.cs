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
    public partial class ConsultarInformacoesClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

            OleDbConnection conn3 = new OleDbConnection();
            OleDbCommand cmd3 = new OleDbCommand();
            OleDbDataAdapter da3 = new OleDbDataAdapter();
            DataSet ds3 = new DataSet();
            conn3.ConnectionString = Conexao.ConexaoStr;
            cmd3.Connection = conn3;
            cmd3.CommandText = "select Nome from DadosClientes";
            cmd3.CommandType = CommandType.Text;
            conn3.Open();
            da3.SelectCommand = cmd3;
            da3.Fill(ds3, "Nome");
            dropNomeCliente.DataSource = ds3.Tables["Nome"];
            dropNomeCliente.DataValueField = "Nome";
            dropNomeCliente.DataBind();
            conn3.Close();
            conn3.Dispose();

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr4;
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from DadosClientes where Nome = '" + dropNomeCliente.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr4 = cmd.ExecuteReader();
            if (dr4.Read())
            {
                string endereco = dr4["Endereco"].ToString() + ", " + dr4["Bairro"].ToString() + " - " + dr4["Cidade"].ToString(); 
                lblNomeCliente.Text = dr4["Nome"].ToString();
                lblNumeroCelularCliente.Text = dr4["Celular"].ToString();
                lblCepCliente.Text = dr4["Cep"].ToString();
                lblEnderecoCliente.Text = endereco;
                lblHostFtp.Text = dr4["HostFtp"].ToString();
                lblUsuarioFtp.Text = dr4["UsuarioFtp"].ToString();
                //lblSenhaFtp.Text = dr4["SenhaFtp"].ToString();
                lblSenhaFtp.Text = "********";
                lblLinkPainelControle.Text = dr4["LinkPainelControle"].ToString();
                lblLoginPainelControle.Text = dr4["LoginPainelControle"].ToString();
                //lblSenhaPainelControle.Text = dr4["SenhaPainelControle"].ToString();
                lblSenhaPainelControle.Text = "********";
                lblEmailCliente.Text = dr4["EmailCliente"].ToString();
                lblDominioCliente.Text = dr4["DominioCliente"].ToString();
                lblStatusCliente.Text = dr4["StatusCliente"].ToString();
                lblRespostaServer.Text = "Dados carregados com sucesso";
                
            }
            else
            {
                lblRespostaServer.Text = "Cliente não encontrado";
            }
            conn.Close();
            conn.Dispose();
        }
    }
}
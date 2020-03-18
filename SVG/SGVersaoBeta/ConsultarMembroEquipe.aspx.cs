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
    public partial class ConsultarMembroEquipe : System.Web.UI.Page
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
            cmd.CommandText = "select Nome from DadosEquipeArticulando";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(ds,"Nome");
            dropNomeMembro.DataSource = ds.Tables["Nome"];
            dropNomeMembro.DataValueField = "Nome";
            dropNomeMembro.DataBind();
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
            cmd2.CommandText = "select * from DadosEquipeArticulando where Nome = '" + dropNomeMembro.Text + "'";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblNomeColaborador.Text = dr2["Nome"].ToString();
                lblCargo.Text = dr2["Cargo"].ToString();
                lblSetor.Text = dr2["Setor"].ToString();
                lblEmail.Text = dr2["Email"].ToString();
                lblLogin.Text = dr2["Login"].ToString();
                lblCep.Text = dr2["Cep"].ToString();
                lblCidade.Text = dr2["Cidade"].ToString();
                lblBairro.Text = dr2["Bairro"].ToString();
                lblEndereco.Text = dr2["Endereco"].ToString();
                lblNumeroCelular.Text = dr2["Celular"].ToString();
                lblNivelEmpresarial.Text = dr2["NivelEmpresarial"].ToString();
                lblStatusColaborador.Text = dr2["StatusColaborador"].ToString();
                lblExpediente.Text = dr2["Expediente"].ToString();
                lblEstado.Text = dr2["Estado"].ToString();
                lblRespostaServer.Text = "Dados carregados com sucesso";
            }
            else
            {
                lblRespostaServer.Text = "Colaborador não encontrado";
            }
            conn2.Close();
            conn2.Dispose();

        }
    }
}
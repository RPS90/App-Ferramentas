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
    public partial class AlterarMembroEquipe : System.Web.UI.Page
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
            cmd3.CommandText = "select Nome from DadosEquipeArticulando";
            cmd3.CommandType = CommandType.Text;
            conn3.Open();
            da3.SelectCommand = cmd3;
            da3.Fill(ds3, "Nome");
            dropNomeColaborador.DataSource = ds3.Tables["Nome"];
            dropNomeColaborador.DataValueField = "Nome";
            dropNomeColaborador.DataBind();
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
            cmd.CommandText = "select * from DadosEquipeArticulando where Nome = '" + dropNomeColaborador.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr4 = cmd.ExecuteReader();
            if (dr4.Read())
            {
                txtNome.Text = dr4["Nome"].ToString();
                dropSetor.SelectedValue = dr4["Setor"].ToString();
                txtCargo.Text = dr4["Cargo"].ToString();
                dropNivelEmpresarial.SelectedValue = dr4["NivelEmpresarial"].ToString();
                dropExpediente.SelectedValue = dr4["Expediente"].ToString();
                txtEmail.Text = dr4["Email"].ToString();
                txtCelular.Text = dr4["Celular"].ToString();
                txtLogin.Text = dr4["Login"].ToString();
                txtSenha.Text = dr4["Senha"].ToString();
                txtCep.Text = dr4["Cep"].ToString();
                txtLogradouro.Text = dr4["Endereco"].ToString();
                txtBairro.Text = dr4["Bairro"].ToString();
                txtCidade.Text = dr4["Cidade"].ToString();
                txtUF.Text = dr4["Estado"].ToString();
                lblRespostaServer.Text = "Informações carregadas com sucesso";


            }
            else
            {
                lblRespostaServer.Text = "As informações do cliente " + dropNomeColaborador.Text + " não foram encontradas";
            }
            conn.Close();
            conn.Dispose();
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn5 = new OleDbConnection();
            OleDbCommand cmd5 = new OleDbCommand();
            conn5.ConnectionString = Conexao.ConexaoStr;
            cmd5.Connection = conn5;
            cmd5.CommandText = "update DadosEquipeArticulando set Nome = '" + txtNome.Text + "', Cargo = '" + txtCargo.Text + "', Setor = '" + dropSetor.Text + "', Email = '" + txtEmail.Text + "', Login = '" + txtLogin.Text + "', Senha = '" + txtSenha.Text + "', Cep = '" + txtCep.Text + "', Cidade = '" + txtCidade.Text + "', Bairro = '" + txtBairro.Text + "', Endereco = '" + txtLogradouro.Text + "', Celular = '" + txtCelular.Text + "', NivelEmpresarial = '" + dropNivelEmpresarial.Text + "', StatusColaborador = 'Ativo', Expediente = '" + dropExpediente.Text + "' where Nome = '" + dropNomeColaborador.Text + "'";
            cmd5.CommandType = CommandType.Text;
            conn5.Open();
            cmd5.ExecuteNonQuery();
            conn5.Close();
            conn5.Dispose();

            string data = DateTime.Now.ToString();
            string nome = Session["LoginUsuario"].ToString();
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Alterou o colaborador " + txtNome.Text + "', '" + data + "')";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            cmd2.ExecuteScalar();
            conn2.Close();
            conn2.Dispose();

            lblRespostaServer.Text = "Informações alteradas";
        }
    }
}
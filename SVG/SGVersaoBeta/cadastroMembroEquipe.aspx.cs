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
    public partial class cadastroMembroEquipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from DadosEquipeArticulando where Login = '" + txtLogin.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lblrespostaServer.Text = "Colaborador já cadastrado no sistema.";
            }
            else
            {
                conn.Close();
                string endereco = txtLogradouro.Text + ", " + txtNumero.Text;
                cmd.CommandText = "insert into DadosEquipeArticulando(Nome, Cargo, Setor, Email, Login, Senha, Cep, Cidade, Bairro, Endereco, Celular, NivelEmpresarial, StatusColaborador, Expediente, Estado) values ('" + txtNome.Text  + "', '" + txtCargo.Text  + "', '" + dropSetor.Text + "', '" + txtEmail.Text  + "', '" + txtLogin.Text  + "', '" + txtSenha.Text  + "', '" + txtCep.Text  + "', '" + txtCidade.Text + "', '" + txtBairro.Text  + "', '" + endereco  + "', '" + txtCelular.Text  + "', '" + dropNivelEmpresarial.Text + "', '" + "Ativo"  + "', '" + dropExpediente.Text + "', '" + txtUF.Text + "')";
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
                cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Cadastrou o colaborador " + txtNome.Text + "', '" + data + "')";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                cmd2.ExecuteScalar();
                conn2.Close();
                conn2.Dispose();

                lblrespostaServer.Text = "Colaborador cadastrado com sucesso.";
            }
            conn.Close();
            conn.Dispose();
        }

    }
}
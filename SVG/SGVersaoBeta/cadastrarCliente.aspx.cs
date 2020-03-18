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
    public partial class cadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }
            txtUF.Text = "SP";
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string endereco = txtLogradouro.Text + ", " + txtNumero.Text;
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from DadosClientes where Nome = '" + txtNomeCliente.Text + "'";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                lblRespostaServer.Text = "Cliente já cadastrado no sistema";
            }
            else
            {
                conn.Close();
                cmd.CommandText = "insert into DadosClientes(Nome, Celular, Cep, Endereco, Bairro, Cidade, Estado, HostFtp, UsuarioFtp, SenhaFtp, LinkPainelControle, LoginPainelControle, SenhaPainelControle, EmailCliente, DominioCliente, StatusCliente) values ('" + txtNomeCliente.Text + "', '" + txtCelular.Text + "', '" + txtCep.Text + "', '" + endereco + "', '" + txtBairro.Text + "', '" + txtCidade.Text + "', '" + txtUF.Text + "', '" + txtHostFtp.Text + "', '" + txtUsuarioFtp.Text + "', '" + txtSenhaFtp.Text + "', '" + txtLinkPainelControle.Text + "', '" + txtLoginPainelControle.Text + "', '" + txtSenhaPainelControle.Text + "', '" + txtEmailCliente.Text + "', '" + txtDominioCliente.Text + "', '" + dropStatusCliente.Text + "')";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                conn.Dispose();

                string data = DateTime.Now.ToString();
                string nome = Session["LoginUsuario"].ToString();
                OleDbConnection conn2 = new OleDbConnection();
                OleDbCommand cmd2 = new OleDbCommand();
                conn2.ConnectionString = Conexao.ConexaoStr;
                cmd2.Connection = conn2;
                cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Cadastrou o cliente " + txtNomeCliente.Text + "', '" + data + "')";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                cmd2.ExecuteScalar();
                conn2.Close();
                conn2.Dispose();

                txtNomeCliente.Text = "";
                txtCelular.Text = "";
                txtLogradouro.Text = "";
                txtDominioCliente.Text = "";
                txtUsuarioFtp.Text = "";
                txtLoginPainelControle.Text = "";
                txtEmailCliente.Text = "";
                txtNumero.Text = "";
                txtSenhaPainelControle.Text = "";
                txtCep.Text = "";
                txtHostFtp.Text = "";
                txtBairro.Text = "";
                txtLinkPainelControle.Text = "";
                txtSenhaFtp.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "SP";
                lblRespostaServer.Text = "Cliente cadastrado com sucesso.";
            }
            conn.Close();
            conn.Dispose();

        }
    }
}
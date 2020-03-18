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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                OleDbConnection conn2 = new OleDbConnection();
                OleDbCommand cmd2 = new OleDbCommand();
                OleDbDataReader dr2;
                conn2.ConnectionString = Conexao.ConexaoStr;
                cmd2.Connection = conn2;
                cmd2.CommandText = "select Nome from DadosEquipeArticulando where Login = '" + Session["LoginUsuario"] + "'";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    string nome = dr2["Nome"].ToString();
                    lblNomeLogin.Text = "Olá " + nome + ", seja bem vindo ao sistema de gerenciamento de projetos.";

                }
                else
                {
                    lblNomeLogin.Text = "Nome não carregado.";
                }
                conn2.Close();
                conn2.Dispose();

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
                dropInformacoesClientes.DataSource = ds3.Tables["Nome"];
                dropInformacoesClientes.DataValueField = "Nome";
                dropInformacoesClientes.DataBind();
                conn3.Close();
                conn3.Dispose();
                
            }


        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn4 = new OleDbConnection();
            OleDbCommand cmd4 = new OleDbCommand();
            OleDbDataReader dr4;
            conn4.ConnectionString = Conexao.ConexaoStr;
            cmd4.Connection = conn4;
            cmd4.CommandText = "select Celular, CEP, EmailCliente from DadosClientes where Nome = '" + dropInformacoesClientes.Text + "'";
            cmd4.CommandType = CommandType.Text;
            conn4.Open();
            dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                string celular = dr4["Celular"].ToString();
                string cep = dr4["CEP"].ToString();
                string email = dr4["EmailCliente"].ToString();
                lblCelular.Text = celular + ".";
                lblCEP.Text = cep + ".";
                lblEmail.Text = email + ".";

            }
            else
            {
                lblCelular.Text = "Não carregado.";
                lblCEP.Text = "Não carregado.";
                lblEmail.Text = "Não carregado.";
            }
            conn4.Close();
            conn4.Dispose();

        }

    }
}
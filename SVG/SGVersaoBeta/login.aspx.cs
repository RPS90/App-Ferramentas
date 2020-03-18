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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] != null)
            {
                Response.Redirect("index.aspx");
            }

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text, senha = txtSenha.Text;
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            OleDbDataReader dr2;
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "select Login, Senha from DadosEquipeArticulando where Login = '" + login + "'";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                string loginBanco = dr2["Login"].ToString();
                string senhaBanco = dr2["senha"].ToString();

                if (loginBanco == login && senhaBanco == senha)
                {

                   Session["LoginUsuario"] = loginBanco;
                   Response.Redirect("index.aspx");

                }

                else
                {
                    lblRespostaLogin.Text = "Login ou senha inválidos";
                }

            }
            else
            {
                lblRespostaLogin.Text = "Login não encontrado, verifique.";
            }
            conn2.Close();
            conn2.Dispose();
            
        }

        
    }
}
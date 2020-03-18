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
    public partial class AlterarInformacoesClientes : System.Web.UI.Page
    {
        private string SelecaoCliente = ""; //string de selecao
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }            
        }
        protected void DropDownListTESTE_Load(object sender, EventArgs e)
        {//-------------------------------------------------------------------------LOAD
            if (!IsPostBack)
            {
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
                DropDownListTESTE.DataSource = ds3.Tables["Nome"];
                DropDownListTESTE.DataValueField = "Nome"; // value em text
                DropDownListTESTE.DataTextField = "Nome"; //text 
                DropDownListTESTE.DataBind();               
                conn3.Close();
                conn3.Dispose();
            }
        }
        protected void DropDownListTESTE_TextChanged(object sender, EventArgs e)
        {//--------------------------------------------------------------------------mudou text
            SelecaoCliente = DropDownListTESTE.Text;
            string str1 = DropDownListTESTE.SelectedItem.ToString();  //teste 1
            string str2 = DropDownListTESTE.SelectedValue;         //teste 7
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr4;
            conn.ConnectionString = Conexao.ConexaoStr;
            cmd.Connection = conn;
            cmd.CommandText = "select * from DadosClientes where Nome = '" + SelecaoCliente + "';";           
            cmd.CommandType = CommandType.Text;
            conn.Open();
            dr4 = cmd.ExecuteReader();
            if (dr4.Read())
            {
                string celular = dr4["Celular"].ToString();
                celular.Replace("(","");
                celular.Replace(")","");
                celular.Replace(" ","");
                txtNomeCliente.Text = dr4["Nome"].ToString();
                txtCelular.Text = celular;
                txtCep.Text = dr4["Cep"].ToString();
                txtHostFtp.Text = dr4["HostFtp"].ToString();
                txtUsuarioFtp.Text = dr4["UsuarioFtp"].ToString();
                txtSenhaFtp.Text = "Insira a nova senha";
                txtLinkPainelControle.Text = dr4["LinkPainelControle"].ToString();
                txtLoginPainelControle.Text = dr4["LoginPainelControle"].ToString();
                txtSenhaPainelControle.Text = "Insira a nova senha";
                txtEmailCliente.Text = dr4["EmailCliente"].ToString();
                txtDominioCliente.Text = dr4["DominioCliente"].ToString();
                dropStatusCliente.Text = dr4["StatusCliente"].ToString();
                txtLogradouro.Text = dr4["Endereco"].ToString();
                txtBairro.Text = dr4["Bairro"].ToString();
                txtCidade.Text = dr4["Cidade"].ToString();
                txtUF.Text = dr4["Estado"].ToString();
            }
            else
            {
                lblRespostaServer.Text = "As informações do cliente " + DropDownListTESTE.Text + " não foram encontradas";
            }
        }
        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                lblRespostaServer.Text = "Preencha o número de celular";
            }
            else
            {
                OleDbConnection conn5 = new OleDbConnection();
                OleDbCommand cmd5 = new OleDbCommand();
                conn5.ConnectionString = Conexao.ConexaoStr;
                cmd5.Connection = conn5;
                cmd5.CommandText = "update DadosClientes set Nome = '" + txtNomeCliente.Text + "', Celular = '" + txtCelular.Text + "', Cep = '" + txtCep.Text + "', Endereco = '" + txtLogradouro.Text + "', Bairro = '" + txtBairro.Text + "', Cidade = '" + txtCidade.Text + "', Estado = '" + txtUF.Text + "', HostFtp = '" + txtHostFtp.Text + "', UsuarioFtp = '" + txtUsuarioFtp.Text + "', SenhaFtp = '" + txtSenhaFtp.Text + "', LinkPainelControle = '" + txtLinkPainelControle.Text + "', LoginPainelControle = '" + txtLoginPainelControle.Text + "', SenhaPainelControle = '" + txtSenhaPainelControle.Text + "', EmailCliente = '" + txtEmailCliente.Text + "', DominioCliente = '" + txtDominioCliente.Text + "', StatusCliente = '" + dropStatusCliente.Text + "' where Nome = '" + DropDownListTESTE.Text + "'";
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
                cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Alterou o cliente " + txtNomeCliente.Text + "', '" + data + "')";
                cmd2.CommandType = CommandType.Text;
                conn2.Open();
                cmd2.ExecuteScalar();
                conn2.Close();
                conn2.Dispose();

                lblRespostaServer.Text = "Informações alteradas";
            }
            
        }
       
    }
}
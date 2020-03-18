using System;
using System.Windows.Forms;
using BLL;
using DAL;
using MySql.Data.MySqlClient;

namespace GUI
{  
    public partial class FormCriarBanco : Form
    {
       public string publicStrServidor="";
       public string publicStrUsuario="";
        public FormCriarBanco()
        {
            InitializeComponent();
        }
        private void FormCriarBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            { this.Close(); }
        }
        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;                
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexaoSemBanco;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Teste realizado com sucesso");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Verifique as informações");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
        private void btCriarBanco_Click(object sender, EventArgs e)
        {
            if (txtCriarBanco.Text == "")
            {
                MessageBox.Show("É necessário inserir um nome para criação\nde um novo Banco de Dados");
            }
            else if (txtServidor.Text == "")
            {
                MessageBox.Show("Insira um Servidor");
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Insira um Usuário");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Insira uma Senha");
            }
            else
            {
                try
                {
                    DadosDaConexao.servidor = txtServidor.Text;
                    DadosDaConexao.usuario = txtUsuario.Text;
                    DadosDaConexao.senha = txtSenha.Text;
                    DALTabelas.CriarBanco = txtCriarBanco.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexaoSemBanco);
                    BLLTabelas bll = new BLLTabelas(cx);
                    bll.CriarBancoDeDados();
                    MessageBox.Show("Banco '" + txtCriarBanco.Text + "' Criado com Sucesso\nTeste sua conexão");
                    this.Close();
                }
                catch (Exception erros)
                {
                    MessageBox.Show(erros.Message);
                }
            }//else
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCriarBanco_Load(object sender, EventArgs e)
        {
            txtServidor.Text = publicStrServidor;
            txtUsuario.Text = publicStrUsuario;
        }

                      
    }//class
}//namespace

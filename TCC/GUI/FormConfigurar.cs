using System;
using System.IO;
using System.Windows.Forms;
using DAL;
using MySql.Data.MySqlClient;
namespace GUI
{
    public partial class FormConfigurar : Form
    {
        public FormConfigurar()
        {
            InitializeComponent();
        }
        private void FormConfigurar_Load(object sender, EventArgs e)
        {          
            try
            {
                StreamReader arquivo = new StreamReader("conf.cfg");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception){}//Sem mensagem
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text.Contains(";")) { txtServidor.Text = ""; }
            if (txtUsuario.Text.Contains(";")) { txtUsuario.Text = ""; }
            if (txtBanco.Text.Contains(";")) { txtBanco.Text = ""; }
            if (txtBanco.Text.Contains(";")) { txtBanco.Text = ""; }
            if ((txtBanco.Text == "") || (txtPort.Text == "") || (txtSenha.Text == "") || (txtServidor.Text == "") || (txtUsuario.Text == ""))
            {
                MessageBox.Show("Existem campos não preenchidos");
            }
            else
            {
                try
                {//REALIZA CONEXAO
                    DadosDaConexao.servidor = txtServidor.Text;
                    DadosDaConexao.banco = txtBanco.Text;
                    DadosDaConexao.usuario = txtUsuario.Text;
                    DadosDaConexao.senha = txtSenha.Text;
                    MySqlConnection conexao = new MySqlConnection();
                    conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                    conexao.Open();
                    conexao.Close();
                    try
                    {//SALVA PRO ARQUIVO
                        StreamWriter arquivo = new StreamWriter("conf.cfg", false);
                        arquivo.WriteLine(txtServidor.Text);
                        arquivo.WriteLine(txtBanco.Text);
                        arquivo.WriteLine(txtUsuario.Text);
                        arquivo.WriteLine(txtSenha.Text);
                        arquivo.Close();
                        MessageBox.Show("Salvo.");      

                        FormMenu FM = new FormMenu();
                        FM.lblMsgBanco.Text = "Conectado";
                        FM.lblMsgBanco.ForeColor = System.Drawing.Color.Green;

                        this.Close();
                    }
                    catch (MySqlException error)
                    { MessageBox.Show("Verifique as informações\n\nERRO: " + error.Message); }
                    catch (Exception error)
                    { MessageBox.Show("Verifique as informações\n\nERRO: " + error.Message); }
                }
                catch (MySqlException error)
                { MessageBox.Show("Não é possível salvar configurações que não foram testadas\n\nERRO: " + error.Message); }
                catch (Exception error)
                { MessageBox.Show("Não é possível salvar configurações que não foram testadas\n\nERRO: " + error.Message); }
            }//else
        }    
        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Teste realizado com sucesso");
            }
            catch (MySqlException error)
            { MessageBox.Show("Verifique as informações\n\nERRO: " + error.Message); }
            catch (Exception error)
            { MessageBox.Show("Verifique as informações\n\nERRO: " + error.Message); }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btCriarBanco_Click(object sender, EventArgs e)
        {
            //this.Close();
            FormCriarBanco f = new FormCriarBanco();
            f.publicStrServidor = txtServidor.Text;
            f.publicStrUsuario  = txtUsuario.Text;
            
            f.ShowDialog();            
            f.Dispose();
        }
        private void FormConfigurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            { this.Close(); }
        }
        private void txtServidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtServidor, "");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtUsuario, "");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtBanco, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtPort, "LESP");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //senha pode ser o Que deus quiser
        }
    }//class
}//namespace

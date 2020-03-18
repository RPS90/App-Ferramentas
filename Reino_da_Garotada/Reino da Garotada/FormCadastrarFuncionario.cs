using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    public partial class FormCadastrarFuncionario : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;

        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDtEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDadosdeLogin_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            salvarFuncionario();
        }

        private void salvarFuncionario()
        {
            if (txtNome.Text == "" || txtCpf.Text == "")
            {
                MessageBox.Show("Não foi possível salvar este cadastro.\n\n" +
                    "Os campos Nome e CPF são obrigatórios.",
                            "Reino da Garotada", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text != txtRepSenha.Text)
            {
                MessageBox.Show("Senha diferente ! \n Por favor repita a mesma senha",
                "Reino da Garotada", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtRepSenha.Clear();
                txtRepSenha.Focus();
            }
            else
            {
                conn.ConnectionString = Classedall.conexaoString;
                cmd.Connection = conn;
                try
                {
                    cmd.CommandText = "insert into TB_Funcionarios(txtNome, txtFuncao, txtDtEntrada, txtDtDeslig, chkDeslig, txtFone1," +
                           " txtFone2, txtCelular, txtCpf, txtRg, txtLogin, txtSenha, txtRepSenha) values('" + txtNome.Text + "', '" + txtFuncao.Text +
                           "', '" + txtDtEntrada.Text + "', '" + txtDtDeslig.Text + "', " + chkDeslig.Checked + ", '" + txtFone1.Text + "', '" +
                           txtFone2.Text + "', '" + txtCelular.Text + "', '" + txtCpf.Text + "', '" + txtRg.Text + "', '" +
                           txtLogin.Text + "', '" + txtSenha.Text + "', '" + txtRepSenha.Text + "')";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    if (MessageBox.Show("Cadastro realizado com sucesso!\n\nDeseja cadastrar novo Funcionário?",
                                "Reino da Garotada", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        txtDtEntrada.Text = "";
                        txtDtDeslig.Text = "";
                        chkDeslig.Checked = false;
                        txtFone1.Text = "";
                        txtFone2.Text = "";
                        txtCelular.Text = "";
                        txtCpf.Text = "";
                        txtRg.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txtRepSenha.Text = "";
                        txtNome.Focus();
                        txtNome.Text = "";
                        txtFuncao.Text = "";
                    }
                    else
                    {
                        FormPrincipal principal = new FormPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível cadastrar este Funcionário," +
                        "\n\nOcorreu um erro de conexão com o banco de dados.\n\n" + ex.ToString(),
                                "Reino da Garotada", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

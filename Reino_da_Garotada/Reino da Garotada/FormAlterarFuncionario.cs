using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    public partial class FormAlterarFuncionario : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public string where;

        public FormAlterarFuncionario()
        {
            InitializeComponent();
        }



        private void buttonCancelarCadastro_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonBuscarFuncionario_Click_1(object sender, EventArgs e)
        {
            if (textBoxPesq.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório vazio !", "Reino da Garotada");
                textBoxPesq.Focus();
            }
            try
            {
                conn.ConnectionString = conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "Select * from TB_Funcionarios where " + where + "= '" + textBoxPesq.Text + "';";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtFuncao.Text = dr["txtFuncao"].ToString();
                    txtNome.Text = dr["txtNome"].ToString();
                    txtRg.Text = dr["txtRg"].ToString();
                    txtCpf.Text = dr["txtCpf"].ToString();
                    txtDtEntrada.Text = dr["txtDtEntrada"].ToString();
                    chkDeslig.Checked = Convert.ToBoolean(dr["chkDeslig"].ToString());
                    txtDtDeslig.Text = dr["txtDtDeslig"].ToString();
                    txtFone1.Text = dr["txtFone1"].ToString();
                    txtFone2.Text = dr["txtFone2"].ToString();
                    txtCelular.Text = dr["txtCelular"].ToString();
                    txtLogin.Text = dr["txtLogin"].ToString();
                    txtSenha.Text = dr["txtSenha"].ToString();
                    txtRepSenha.Text = dr["txtRepSenha"].ToString();
                    lblCodigoFunc.Text = dr["CodFuncionario"].ToString();

                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum funcionário !");
                    textBoxPesq.Clear();
                    textBoxPesq.Focus();
                    conn.Close();
                }
            }
            catch (OleDbException)
            {

                MessageBox.Show("Um erro inesperado aconteceu \nTente novamente mais tarde ", "Reino da Garotada");
                this.Close();
            }
        }

        private void rdbNome_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxPesq.Mask = "";
            textBoxPesq.Clear();
            textBoxPesq.Focus();
            where = "txtNome";
        }

        private void buttonLimparCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Essa ação irá apagar todos os dados ! \nDeseja continuar ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                LimparDadosFuncionário();
            }
            else
            {

            }
        }
        private void LimparDadosFuncionário()
        {
                txtFuncao.Clear();
                txtNome.Clear();
                txtDtEntrada.Text = "";
                txtDtDeslig.Text = "";
                txtFone1.Clear();
                txtFone2.Clear();
                txtCelular.Clear();
                txtCpf.Clear();
                txtRg.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
                txtRepSenha.Clear();
        }

        private void rdbCPF_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesq.Mask = "000,000,000-00";
            textBoxPesq.Clear();
            textBoxPesq.Focus();
            where = "txtCpf";
        }

        private void rdbRG_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesq.Mask = "00,000,000-A";
            textBoxPesq.Clear();
            textBoxPesq.Focus();
            where = "txtRg";
        }

        private void FormAlterarFuncionario_Load(object sender, EventArgs e)
        {
            rdbNome.Checked = true;
        }

        private void buttonEditarCadastro_Click(object sender, EventArgs e)
        {
            if (textBoxPesq.Text == "")
            {
                MessageBox.Show("Por favor digite alguma coisa no campo de pesquisa ", "Reino da Garotada");
                textBoxPesq.Focus();
            }
            else
            {
                buttonCancelarCadastro.Enabled = true;
                buttonLimparCadastro.Enabled = true;
                buttonSalvarCadastro.Enabled = true;
                destravandoCampos();
            }

        }
        private void destravandoCampos()
        {
            txtFuncao.Enabled = true;
            txtNome.Enabled = true;
            txtDtEntrada.Enabled = true;
            txtFone1.Enabled = true;
            txtFone2.Enabled = true;
            txtCelular.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtRepSenha.Enabled = true;
            chkDeslig.Enabled = true;
        }
        private void travandoCampos()
        {
            txtFuncao.Enabled = false;
            txtNome.Enabled = false;
            txtDtEntrada.Enabled = false;
            txtFone1.Enabled = false;
            txtFone2.Enabled = false;
            txtCelular.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtRepSenha.Enabled = false;
            chkDeslig.Enabled = false;
        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtRepSenha.Text)
            {
                MessageBox.Show("Por favor repita a senha !", "Reino da Garotada");
                txtRepSenha.Clear();
                txtRepSenha.Focus();
            }
            else if (txtSenha.Text == "" || txtRepSenha.Text == "" || txtLogin.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Alguns campos obrigatórios não estão preenchidos !", "Reino da Garotada");
                txtNome.Focus();
            }
            else
            {
                conn.ConnectionString = conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "update TB_Funcionarios set txtFuncao = '" + txtFuncao.Text + "', txtNome = '" + txtNome.Text + "', " +
                    "txtDtEntrada = '" + txtDtEntrada.Text + "', txtDtDeslig = '" + txtDtDeslig.Text + "', txtFone1 = '" + txtFone1.Text + "'," +
                    "txtFone2 = '" + txtFone2.Text + "', txtCelular ='" + txtCelular.Text + "', txtCpf = '" + txtCpf.Text + "'," +
                    "txtRg = '" + txtRg.Text + "', txtLogin = '" + txtLogin.Text + "', txtSenha = '" + txtSenha.Text + "', txtRepSenha = '" + txtRepSenha.Text + "'" +
                    " where CodFuncionario = " + lblCodigoFunc.Text + ";";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (MessageBox.Show("Alteração efetuada com sucesso !\nDeseja efetuar outra alteração ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    travandoCampos();
                    LimparDadosFuncionário();
                    textBoxPesq.Clear();
                    textBoxPesq.Focus();
                }
                else
                {
                    LimparDadosFuncionário();
                    this.Close();
                }
            }

        }

        private void chkDeslig_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeslig.Checked == true)
            {
                txtDtDeslig.Enabled = true;
            }
            else
            {
                txtDtDeslig.Enabled = false;
            }
        }

        private void chkVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisualizarSenha.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';

            }
        }
    }
}

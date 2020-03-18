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
    public partial class FormCadastrarCurso : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public FormCadastrarCurso()
        {
            InitializeComponent();
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLocalRealizacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrarCurso_Load(object sender, EventArgs e)
        {
            cboDiasSemana.SelectedIndex = 0;
            cboHorário.SelectedIndex = 0;
            cboPeriodo.SelectedIndex = 0;

            if (!Classedall.VerificaFuncionario())
            {
                if (MessageBox.Show("Não tem nenhum funcionário cadastrado ! /n Deseja Cadastrar agora ?","Reino da Garotada",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Close();
                    FormCadastrarFuncionario cadastrarFunc = new FormCadastrarFuncionario();
                    cadastrarFunc.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                cboResponsCurso.DataSource = Classedall.DadosFuncionario();
                cboResponsCurso.DisplayMember = "Nome_Funcionário";
                cboResponsCurso.ValueMember = "Código_Funcionário";
            }
        }

        private void buttonLimparCadastro_Click(object sender, EventArgs e)
        {
            CodCurso.Text = "";
            txtCurso.Text = "";
            txtCargaHoraria.Text = "";
            txtDescricao.Text = "";
            txtQualifProfissional.Text = "";
            cboDiasSemana.Text = "";
            cboHorário.Text = "";
            cboPeriodo.Text = "";
            cboResponsCurso.Text = "";
            cboLocalRealizacao.Text = "";
            mkdQtdAluno.Clear();
        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text == string.Empty || txtCargaHoraria.Text == string.Empty || mkdQtdAluno.Text == string.Empty)
            {
                MessageBox.Show("Digite o nome, carga horaria do curso e o quantidade de alunos !", "Reino da Garotada !");
                txtCurso.Focus();
            }
            else
            {
                if (!Classedall.VerificaCurso(txtCurso.Text.Trim()))
                {
                    MessageBox.Show("O curso digitado já está cadastrado ! \n Digite um nome diferente", "Reino da Garotada");
                    txtCurso.Clear();
                    txtCurso.Focus();
                }
                else
                {
                    try
                    {
                        int cargaHoraria = Convert.ToInt32(txtCargaHoraria.Text.Replace("h", ""));
                        conn.ConnectionString = conexaoString;
                        cmd.Connection = conn;
                        cmd.CommandText = "Insert into TB_Cursos (txtCurso, txtDescricao, cboHorário, txtCargaHoraria, cboDiasSemana, txtQualifProfissional," +
                        "cboLocalRalizacao, cboResponsCurso, cboPeriodo, status, alunosCadastradosTurma, qtdeAlunosCurso) values ('" + txtCurso.Text + "','" + txtDescricao.Text + "','" + cboHorário.Text + "','"
                        + cargaHoraria + "','" + cboDiasSemana.Text + "','" + txtQualifProfissional.Text + "','" + cboLocalRealizacao.Text + "','" +
                        cboResponsCurso.Text + "','" + cboPeriodo.Text + "'," + true + ", 0, " + mkdQtdAluno.Text + ");";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("O curso foi cadastrado com sucesso ! \nDeseja cadastrar um novo curso", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            conn.Close();
                            txtCurso.Clear();
                            txtDescricao.Clear();
                            cboHorário.SelectedIndex = 0;
                            txtCargaHoraria.Clear();
                            cboDiasSemana.SelectedIndex = 0;
                            txtQualifProfissional.Clear();
                            cboLocalRealizacao.Clear();
                            cboResponsCurso.SelectedIndex = 0;
                            cboPeriodo.SelectedIndex = 0;
                        }
                        else
                        {
                            conn.Close();
                            this.Close();
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Deu algo errado com o banco \n Tente novamente mais tarde !" + ex.ToString(), "Reino da Garotada");
                        conn.Close();
                        this.Close();
                        
                    }

                }
            }
        }

        private void panelLow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

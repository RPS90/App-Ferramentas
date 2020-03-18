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
    public partial class FormCadastrarTurma : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public  int numeroMaximoAluno = 0;
        public int controladorNumeroAluno = 0;
        public int ult;
        public bool situacao = true;
        public int HorasCurso = 0;
        public FormCadastrarTurma()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            situacao = false;
            this.Close();
        }

        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_reinoDataSet1.TB_Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FuncionariosTableAdapter.Fill(this.banco_reinoDataSet1.TB_Funcionarios);
            cboFuncionario.Text = "Selecione...";
            // TODO: esta linha de código carrega dados na tabela 'banco_reinoDataSet1.TB_Cursos'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_CursosTableAdapter.Fill(this.banco_reinoDataSet1.TB_Cursos);
            cboCurso.Text = "Selecione...";
            lblVerifica.Text = "Você tem " + numeroMaximoAluno.ToString() + " vagas disponivéis";
            dtDadosAluno.AutoGenerateColumns = false;
            lblVerifica.Text = "";

            if (!Classedall.VerificaCurso())
            {
                if (MessageBox.Show("Não tem nenhum curso cadastrado !\n\nDeseja cadastrar agora ?", "Reino da Garoatada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    FormCadastrarCurso cadCurso = new FormCadastrarCurso();
                    cadCurso.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else if (!Classedall.verificaAlunoCadastrado())
            {
                if (MessageBox.Show("Não tem nenhum Aluno cadastrado !\n\nDeseja cadastrar agora ?", "Reino da Garoatada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    FormCadastrarAluno cadAluno = new FormCadastrarAluno();
                    cadAluno.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else if (!Classedall.VerificaFuncionario())
            {
                if (MessageBox.Show("Não tem nenhum Professor cadastrado !\n\nDeseja cadastrar agora ?", "Reino da Garoatada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    FormCadastrarFuncionario cadFunc = new FormCadastrarFuncionario();
                    cadFunc.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {

            }
        }

        private void dtDadosAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool verifca;
            if (e.ColumnIndex == dtDadosAluno.Columns["CadastroAlunoTurma"].Index)
            {
                dtDadosAluno.EndEdit();
                verifca = Convert.ToBoolean(dtDadosAluno.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (verifca)
                {
                    controladorNumeroAluno = controladorNumeroAluno + 1;
                    lblVerifica.Text = controladorNumeroAluno.ToString();
                }
                else
                {
                    controladorNumeroAluno = controladorNumeroAluno - 1;
                    lblVerifica.Text = controladorNumeroAluno.ToString();
                }
                if (controladorNumeroAluno > numeroMaximoAluno)
                {
                    ult = Convert.ToInt32(((numeroMaximoAluno - controladorNumeroAluno)) * -1);
                    if (ult == 1)
                    {
                        lblVerifica.Text = "Você ultrapassou " + ult.ToString() + " vaga";
                        lblVerifica.ForeColor = Color.Red;
                        lblVerifica.BackColor = Color.White;
                    }
                    else
                    {
                        lblVerifica.Text = "Você ultrapassou " + ult.ToString() + " vagas";
                        lblVerifica.ForeColor = Color.Red;
                        lblVerifica.BackColor = Color.White;
                    }
                }
                else if (controladorNumeroAluno == numeroMaximoAluno)
                {
                    lblVerifica.Text = "Turma completa !";
                    lblVerifica.ForeColor = Color.Green;
                    lblVerifica.BackColor = Color.White;
                }
                else
                {
                    lblVerifica.Text = "Você tem " + (numeroMaximoAluno - controladorNumeroAluno).ToString() + " vagas disponivéis para o curso de "+cboCurso.Text;
                    lblVerifica.ForeColor = Color.Black;
                    lblVerifica.BackColor = Color.Transparent;
                }
            }
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (situacao == true)
            {
                if (!Classedall.VerificaAlunoCurso(cboCurso.Text))
                {
                    MessageBox.Show("Não tem nenhum aluno cadastrado nesse curso");
                    LimpaDadosTurma();
                    cboCurso.Focus();
                }
                else
                {
                    numeroMaximoAluno = PreenchendoQtdVagas(Convert.ToInt32(cboCurso.SelectedValue));

                    controladorNumeroAluno = PreenchendoQtdeAlunosCad(Convert.ToInt32(cboCurso.SelectedValue));

                    lblVerifica.Text = "Você tem " + (numeroMaximoAluno - controladorNumeroAluno).ToString() + " vagas disponivéis para o curso de " + cboCurso.Text;
                    PreencheCamposCurso(Convert.ToInt32(cboCurso.SelectedValue));
                    try
                    {
                        CodCurso.Text = cboCurso.SelectedValue.ToString();
                    }
                    catch (Exception)
                    {

                    }
                    conn.ConnectionString = conexaoString;
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from TB_Alunos where cboCurso = '" + cboCurso.Text + "' and txtForaTurma = true;";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtDadosAluno.DataSource = dt;
                    var sql = "Select cboSemestre from TB_Alunos where cboCurso = '" + cboCurso.Text + "';";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    var semestreAluno = cmd.ExecuteScalar();
                    txtTurma.Text = "00" + semestreAluno + "-" + cboCurso.Text;
                    conn.Close();
                }
            }
            else
            {

            }
        }
        private void PreencheCamposCurso(int CodCurso_)
        {
            //Preenchendo campos do horario do curso automatico
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Cursos where CodCurso = " + CodCurso_ + ";";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboHorario.Text = dr["cboHorário"].ToString();
                HorasCurso = Convert.ToInt32(dr["txtCargaHoraria"].ToString());
            }
            conn.Close();

        }
        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {

            if (CodFuncionario.Text == "" || CodCurso.Text == "" || txtQtdFaltas.Text == "" || txtTurma.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos", "Reino da Garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCurso.Focus();
            }
            else
            {
                int contador = 0;
                bool verifica = true;

                if (ult == 1)
                {
                    MessageBox.Show("Você ultrapassou o limite de alunos por turma ! \n\nPor favor tire " + ult.ToString() + " alunos para que o cadastro da turma possa ser executado com sucesso !", "Reino da garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ult > 2)
                {
                    MessageBox.Show("Você ultrapassou o limite de alunos por turma ! \n\nPor favor tire " + ult.ToString() + " alunos para que o cadastro da turma possa ser executado com sucesso !", "Reino da garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (controladorNumeroAluno <= numeroMaximoAluno)
                {
                    if (bool.Parse(dtDadosAluno.CurrentRow.Cells[0].FormattedValue.ToString()) == true)
                    {
                        foreach (DataGridViewRow check in dtDadosAluno.Rows)
                        {
                            if ((bool)check.Cells[0].FormattedValue)
                            {
                                var sqlInsertTurma = "insert into TB_Turma(txtTurma, CodCurso, cboCurso, CodFuncionario, cboFuncionario, " +
                                    "cboHorario, txtInicio, txtTermino, CodAluno, cboAluno, txtQtdFaltas, Situação) values ('" + txtTurma.Text + "', " +
                                    CodCurso.Text + ", '" + cboCurso.Text + "', " + CodFuncionario.Text + ", '" + cboFuncionario.Text + "'," +
                                    "'" + cboHorario.Text + "','" + txtInicio.Text + "','" + txtTermino.Text + "', " + check.Cells[1].Value.ToString()
                                    + ", '" + check.Cells[3].Value.ToString() + "'," + txtQtdFaltas.Text + "," + true + ")";
                                var sqlUpdateAluno = "Update TB_Alunos set txtTurma = '" + txtTurma.Text + "', txtForaTurma = " + false + ", txtInicio = '" + txtInicio.Text + "', txtTermino = " +
                                    "'" + txtTermino.Text + "' where cboCurso = '" + cboCurso.Text + "';";
                                conn.ConnectionString = conexaoString;
                                cmd.Connection = conn;
                                cmd.CommandText = sqlInsertTurma;
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = sqlUpdateAluno;
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                contador = contador + 1;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione pelo menos 1 aluno");
                        verifica = false;
                    }
                    if (verifica == true)
                    {
                        conn.ConnectionString = conexaoString;
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE TB_Cursos SET alunosCadastradosTurma = " + contador + " where CodCurso = " + cboCurso.SelectedValue + ";";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        if (MessageBox.Show("Foi cadastrado um total de " + contador.ToString() + " alunos\n\nDeseja continuar o cadastro ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            LimpaDadosTurma();
                            txtTurma.Focus();
                        }
                        else
                        {
                            situacao = false;
                            this.Close();
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CodFuncionario.Text = cboFuncionario.SelectedValue.ToString();
            }
            catch (Exception)
            {

                
            }
        }
        private void LimpaDadosTurma()
        {
            txtTurma.Clear();
            cboFuncionario.Text = "Selecione...";
            txtQtdFaltas.Clear();
            dtDadosAluno.DataSource = null;
            CodCurso.Clear();
            CodFuncionario.Clear();
            cboHorario.Clear();
            lblVerifica.Text = "";
        }

        private void buttonLimparCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta ação irá apagar tudo que foi digitado, deseja continuar ?", "Reino da garotada", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                LimpaDadosTurma();
                txtTurma.Focus();
            }
            else
            {

            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                situacao = false;
                this.Close();
            }
            else
            {

            }

        }
        private int PreenchendoQtdeAlunosCad(int codigoCurso)
        {
            int qtde;
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select count(CodCurso) from TB_Turma where CodCurso = " + codigoCurso + ";";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return qtde;
        }
        private int PreenchendoQtdVagas(int codigoCurso)
        {
            int qtde;
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select qtdeAlunosCurso from TB_Cursos where CodCurso = " + codigoCurso + ";";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return qtde;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_CursosTableAdapter.FillBy(this.banco_reinoDataSet1.TB_Cursos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tB_CursosTableAdapter.FillBy1(this.banco_reinoDataSet1.TB_Cursos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormCadastrarTurma_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtInicio_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            txtTermino.Value = txtInicio.Value;
            while (i < HorasCurso)
            {
                switch (txtTermino.Value.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        txtTermino.Value = txtTermino.Value.AddDays(2);
                        break;
                    case DayOfWeek.Sunday:
                        txtTermino.Value = txtTermino.Value.AddDays(1);
                        break;
                    default:
                        txtTermino.Value = txtTermino.Value.AddDays(1);
                        i++;
                        break;
                }
            }
            switch (txtTermino.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    txtTermino.Value = txtTermino.Value.AddDays(1);
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    txtTermino.Value = txtTermino.Value.AddDays(2);
                    break;
                default:
                    break;
            }
        }
    }
}

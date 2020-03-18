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
    public partial class FormPesquisarTurma : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public static string where;
        public FormPesquisarTurma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtPesqNome_CheckedChanged(object sender, EventArgs e)
        {
            where = "cboCurso";
            cbPesquisa.DataSource = Classedall.DadosTurma();
            cbPesquisa.DisplayMember = "cboCurso";
            cbPesquisa.ValueMember = "CodCurso";
            cbPesquisa.Focus();
            cbPesquisa.Text = "Selecione";

        }

        private void rdbPesqTurma_CheckedChanged(object sender, EventArgs e)
        {
            where = "txtTurma";
            cbPesquisa.DataSource = Classedall.DadosTurma();
            cbPesquisa.DisplayMember = "txtTurma";
            cbPesquisa.ValueMember = "CodTurma";
            cbPesquisa.Focus();
            cbPesquisa.Text = "Selecione";
        }

        private void rdbNomeAluno_CheckedChanged(object sender, EventArgs e)
        {

                where = "cboAluno";
                cbPesquisa.DataSource = Classedall.DadosTurma();
                cbPesquisa.DisplayMember = "cboAluno";
                cbPesquisa.ValueMember = "CodAluno";
                cbPesquisa.Focus();
                cbPesquisa.Text = "Selecione";
        }

        private void buttonBuscarAluno_Click(object sender, EventArgs e)
        {
            if (cbPesquisa.Text == "Selecione")
            {
                MessageBox.Show("Selecione alguma coisa !");
                cbPesquisa.Focus();
            }
            else
            {
                conn.ConnectionString = conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "Select * from TB_Turma where " + where + " = '" + cbPesquisa.Text + "';";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTurma.DataSource = dt;
                conn.Close();
            }
        }

        private void FormPesquisarTurma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_reinoDataSet1.TB_Turma'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_TurmaTableAdapter.Fill(this.banco_reinoDataSet1.TB_Turma);

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
    }
}

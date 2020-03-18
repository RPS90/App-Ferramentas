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
    public partial class PesquisaAvancada : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public string sql;
        public PesquisaAvancada()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void PesquisaAvancada_Load(object sender, EventArgs e)
        {
            cbPesquisa.DataSource = Classedall.DadosAlunoCid();
            cbPesquisa.DisplayMember = "txtCidade";
        }

        private void rbtPesqNomeCurso_CheckedChanged(object sender, EventArgs e)
        {
            cbPesquisa.Enabled = false;
            mkdPesquisa.Visible = false;
            mkdPesquisa.Clear();
            sql = "Select * from TB_Alunos;";
        }

        private void rdbPesqIdade_CheckedChanged(object sender, EventArgs e)
        {
            cbPesquisa.Visible = false;
            mkdPesquisa.Visible = true;
            mkdPesquisa.Clear();
            mkdPesquisa.Focus();
        }

        private void buttonBuscarAluno_Click(object sender, EventArgs e)
        {
            if (rdbPesqIdadeAcima.Checked == true)
            {
                sql = "Select * from TB_Alunos where txtIdadeAluno > " + mkdPesquisa.Text + ";";
            }
            else if (rdbAbaixo.Checked == true)
            {
                sql = "Select * from TB_Alunos where txtIdadeAluno < " + mkdPesquisa.Text + ";";
            }
            else if (rdbPesqIdadeExp.Checked == true)
            {
                sql = "Select * from TB_Alunos where txtIdadeAluno = " + mkdPesquisa.Text + ";";
            }
            else if (rdbPesqCdef.Checked == true)
            {
                sql = "Select * from TB_Alunos where chkNaoPossui = false;";
            }
            else if (rdbPesqSdef.Checked == true)
            {
                sql = "Select * from TB_Alunos where chkNaoPossui = true;";
            }
            else if (rdbPesqSitu.Checked == true)
            {
                sql = "Select * from TB_Alunos where chkSitEvadido = true or chkSitDispensado = true or chkSitTrancamento = true or chkSitTransferido = true ;";
            }
            else if (rdbPesqReg.Checked == true)
            {
                sql = "Select * from TB_Alunos where txtCidade = '" + cbPesquisa.Text + "';";
            }
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtPesquisaAvancada.DataSource = dt;
                lblContagem.Text = "Quantidade de alunos: " + dt.Rows.Count.ToString();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Não teve nenhum dado !");
                cbPesquisa.Text = "";
                mkdPesquisa.Clear();
                conn.Close();
            }

        }

        private void rdbAbaixo_CheckedChanged(object sender, EventArgs e)
        {
            mkdPesquisa.Visible = true;
            cbPesquisa.Visible = false;
            mkdPesquisa.Clear();
            mkdPesquisa.Focus();

        }

        private void rdbPesqIdadeExp_CheckedChanged(object sender, EventArgs e)
        {
            mkdPesquisa.Visible = true;
            cbPesquisa.Visible = false;
            mkdPesquisa.Clear();
            mkdPesquisa.Focus();
        }

        private void rdbPesqCdef_CheckedChanged(object sender, EventArgs e)
        {
            cbPesquisa.Enabled = false;
            mkdPesquisa.Visible = false;
            mkdPesquisa.Clear();
        }

        private void rdbPesqSdef_CheckedChanged(object sender, EventArgs e)
        {
            cbPesquisa.Enabled = false;
            mkdPesquisa.Visible = false;
            mkdPesquisa.Clear();
        }

        private void rdbPesqSitu_CheckedChanged(object sender, EventArgs e)
        {
            cbPesquisa.Enabled = false;
            mkdPesquisa.Visible = false;
            mkdPesquisa.Clear();
        }

        private void rdbPesqReg_CheckedChanged(object sender, EventArgs e)
        {
            mkdPesquisa.Visible = false;
            cbPesquisa.Visible = true;
            cbPesquisa.Enabled = true;

        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    public partial class FormCadastrarAluno : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        public static int idadeAluno;

        public FormCadastrarAluno()
        {
            InitializeComponent();
        }

        private void panelVoltar_Paint(object sender, PaintEventArgs e)
        {
            this.Close();
        }

        private void textBoxDtNascto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRg_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
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

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void pictureBoxPesqCep_Click(object sender, EventArgs e)
        {
            //Se a internet estiver conectada
            if (IsConnected())
            {
                localizaCep();
            }
            else
            {
                MessageBox.Show("Este serviço necessita de uma conexão com a internet !", "Reino da Garotada");
                txtCEP.Clear();
                txtCEP.Focus();
            }
        }
        //Método da api
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int description, int reservedValue);
        // Metódo que verifica se está conectado
        public static Boolean IsConnected()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }
        private void localizaCep()
        {
            using (var ws = new Wscorreios_.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txtCEP.Text);
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtComplemento.Text = resultado.complemento;
                    txtLogradouro.Text = resultado.end;
                    cboUF.Text = resultado.uf;
                }
                catch (Exception)
                {

                    MessageBox.Show("Digite um CEP válido !");
                    txtCEP.Focus();
                    txtCEP.Clear();
                }
            }
        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            if (!Classedall.VerificaAluno(txtRGAluno.Text))
            {
                MessageBox.Show("O RG Digitado já está cadastrado !", "Reino da Garotada !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.ConnectionString = Classedall.conexaoString;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into TB_Alunos" +
                        "(txtMatricula, cboSemestre, txtAno_Cadastro, txtDtCadastro, txtNomeAluno, txtRGAluno, txtCPFAluno," +
                        "txtDtNascto, txtNatural, txtNacionalidade, cboSexo, cboEscolaridade, txtAnoConclui, txtNomeResp, " +
                        "txtRGResp, txtCPFResp, txtLogradouro, txtNum, txtComplemento, txtBairro, txtCidade, " +
                        "cboUF, txtCEP, txtFoneRes, txtFoneCom,  txtFoneCelular, chkNaoPossui, chkDefAuditiva, " +
                        "chkDefVisual, chkDefIntelectual, chkDefMultiplas, chkDefOutras, txtDescOutras, chkDefPsicossocial, chkDefAltaHabil, " +
                        "chkDefCondutaTipicaTEA, chkSitOcupAutonomo, chkSitOcupEmpregComCarteira, chkSitOcupProfLiberal, chkSitOcupDesempregado, chkSitOcupEmpregador, chkSitOcupEmpSemCarteira, " +
                        "chkSitOcupAposentado, chkSitOcupBusca1Emprego, cboCurso, cboHorario, txtCargaHoraria, cboDiasSemana, txtInicio, " +
                        "txtTermino, txtTurma, txtQualiProfissional, chkSitEvadido, chkSitDispensado, chkSitTrancamento, chkSitTransferido, txtIdadeAluno, txtForaTurma) values ('" +
                         "','" + cboSemestre.SelectedItem.ToString() + "','" + txtAno_Cadastro.Text + "','" + txtDtCadastro.Text + "', '" + txtNomeAluno.Text + "','" + txtRGAluno.Text + "','" + txtCPFAluno.Text
                        + "','" + txtDtNascto.Text + "','" + txtNatural.Text + "','" + txtNacionalidade.Text + "','" + cboSexo.SelectedItem.ToString() + "','" + cboEscolaridade.SelectedItem.ToString() + "','" + txtAnoConclui.Text + "','" + txtNomeResp.Text + "','" +
                            txtRGResp.Text + "','" + txtCPFResp.Text + "','" + txtLogradouro.Text + "','" + txtNum.Text + "','" + txtComplemento.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "','"
                            + cboUF.Text + "','" + txtCEP.Text + "','" + txtFoneRes.Text + "','" + txtFoneCom.Text + "','" + txtFoneCelular.Text + "'," + chkNaoPossui.Checked + "," + chkDefAuditiva.Checked + "," +
                            chkDefVisual.Checked + "," + chkDefIntelectual.Checked + "," + chkDefMultiplas.Checked + "," + chkDefOutras.Checked + ",'" + txtDescOutras.Text + "'," + chkDefPsicossocial.Checked + "," + chkDefAltaHabil.Checked + "," +
                            chkDefCondutaTipicaTEA.Checked + "," + chkSitOcupAutonomo.Checked + "," + chkSitOcupEmpregComCarteira.Checked + "," + chkSitOcupProfLiberal.Checked + "," + chkSitOcupDesempregado.Checked + "," + chkSitOcupEmpregador.Checked + "," + chkSitOcupEmpSemCarteira.Checked
                            + "," + chkSitOcupAposentado.Checked + "," + chkSitOcupBusca1Emprego.Checked + ",'" + cboCurso.Text + "','" + cboHorario_.Text + "','" + txtCargaHoraria.Text + "','" + cboDiasSemana_.Text + "','','','" + txtTurma.Text + "','" 
                            + txtQualiProfissional.Text + "'," + chkSitEvadido.Checked + "," + chkSitDispensado.Checked + "," + chkSitTrancamento.Checked + "," + chkSitTransferido.Checked +
                            "," + idadeAluno + "," + true +")";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    var sqlrCodAluno = "Select CodAluno from TB_Alunos where txtCPFAluno = '" + txtCPFAluno.Text + "';";
                    cmd.CommandText = sqlrCodAluno;
                    cmd.CommandType = CommandType.Text;
                    var codAluno = cmd.ExecuteScalar();
                    var sql = "update TB_Alunos set txtMatricula = '" + txtDtCadastro.Value.Year.ToString() + "-" + cboSemestre.SelectedItem.ToString() + "-" + codAluno + "' where txtCPFAluno  ='" + txtCPFAluno.Text + "';";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (MessageBox.Show("Aluno cadastrado com sucesso ! \n Deseja cadastrar um novo aluno ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        limpaDadosAluno("não");
                        cboSemestre.Focus();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                catch (OleDbException dr)
                {

                    MessageBox.Show("Algo inesperado aconteceu ! \n tente novamente mais tarde " + dr.ToString(), "Reino da Garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void chkDefOutras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDefOutras.Checked == true)
            {
                txtDescOutras.Enabled = true;
            }
            else
            {
                txtDescOutras.Enabled = false;
            }
        }

        private void chkNaoPossui_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNaoPossui.Checked == true)
            {
                chkDefAltaHabil.Checked = false;
                chkDefAltaHabil.Enabled = false;
                chkDefAuditiva.Checked = false;
                chkDefAuditiva.Enabled = false;
                chkDefCondutaTipicaTEA.Checked = false;
                chkDefCondutaTipicaTEA.Enabled = false;
                chkDefIntelectual.Checked = false;
                chkDefIntelectual.Enabled = false;
                chkDefMultiplas.Checked = false;
                chkDefMultiplas.Enabled = false;
                chkDefOutras.Checked = false;
                chkDefOutras.Enabled = false;
                chkDefPsicossocial.Checked = false;
                chkDefPsicossocial.Enabled = false;
                chkDefVisual.Checked = false;
                chkDefVisual.Enabled = false;
                txtDescOutras.Enabled = false;
            }
            else
            {
                chkDefAltaHabil.Checked = false;
                chkDefAltaHabil.Enabled = true;
                chkDefAuditiva.Checked = false;
                chkDefAuditiva.Enabled = true;
                chkDefCondutaTipicaTEA.Checked = false;
                chkDefCondutaTipicaTEA.Enabled = true;
                chkDefIntelectual.Checked = false;
                chkDefIntelectual.Enabled = true;
                chkDefMultiplas.Checked = false;
                chkDefMultiplas.Enabled = true;
                chkDefOutras.Checked = false;
                chkDefOutras.Enabled = true;
                chkDefPsicossocial.Checked = false;
                chkDefPsicossocial.Enabled = true;
                chkDefVisual.Checked = false;
                chkDefVisual.Enabled = true;
            }
        }

        private void txtDtNascto_Leave(object sender, EventArgs e)
        {            

            if (DateTime.Now.DayOfYear < txtDtNascto.Value.Year)
            {
                idadeAluno = (DateTime.Now.Year - txtDtNascto.Value.Year) - 1;
            }
            else
            {
                idadeAluno = DateTime.Now.Year - txtDtNascto.Value.Year;
            }

            if (idadeAluno < 18)
            {
                txtNomeResp.Enabled = true;
                txtRGResp.Enabled = true;
                txtCPFResp.Enabled = true;
            }
            else
            {
                txtNomeResp.Enabled = false;
                txtRGResp.Enabled = false;
                txtCPFResp.Enabled = false;
            }
        }

        private void txtDtCadastro_Leave(object sender, EventArgs e)
        {
            txtAno_Cadastro.Text = txtDtCadastro.Value.Year.ToString();
        }

        private void buttonLimparCadastro_Click(object sender, EventArgs e)
        {
            limpaDadosAluno("sim");
        }
        public void limpaDadosAluno(string pergunta)
        {
            if (pergunta == "sim")
            {
                if (MessageBox.Show("Está ação irá apagar todas as informações digitadas, deseja continuar ?", "Reino da Garotada ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cboHorario_.Clear();
                    cboCurso.Text = "Selecione";
                    cboSemestre.Text = string.Empty;
                    txtAno_Cadastro.Text = string.Empty;
                    txtNomeAluno.Text = string.Empty;
                    txtRGAluno.Text = string.Empty;
                    txtCPFAluno.Text = string.Empty;
                    txtNatural.Text = string.Empty;
                    txtNacionalidade.Text = string.Empty;
                    cboSexo.Text = "Selecione";
                    cboEscolaridade.Text = "Selecione";
                    txtAnoConclui.Text = string.Empty;
                    txtNomeResp.Text = string.Empty;
                    txtRGResp.Text = string.Empty;
                    txtCPFResp.Text = string.Empty;
                    txtLogradouro.Text = string.Empty;
                    txtNum.Text = string.Empty;
                    txtComplemento.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtCidade.Text = string.Empty;
                    cboUF.Text = string.Empty;
                    txtCEP.Text = string.Empty;
                    txtFoneRes.Text = string.Empty;
                    txtFoneCom.Text = string.Empty;
                    txtFoneCelular.Text = string.Empty;
                    chkNaoPossui.Checked = false;
                    chkDefAuditiva.Checked = false;
                    chkDefVisual.Checked = false;
                    chkDefIntelectual.Checked = false;
                    chkDefMultiplas.Checked = false;
                    chkDefOutras.Checked = false;
                    txtDescOutras.Text = string.Empty;
                    chkDefPsicossocial.Checked = false;
                    chkDefAltaHabil.Checked = false;
                    chkDefCondutaTipicaTEA.Checked = false;
                    chkSitOcupAutonomo.Checked = false;
                    chkSitOcupEmpregComCarteira.Checked = false;
                    chkSitOcupProfLiberal.Checked = false;
                    chkSitOcupDesempregado.Checked = false;
                    chkSitOcupEmpregador.Checked = false;
                    chkSitOcupEmpSemCarteira.Checked = false;
                    chkSitOcupAposentado.Checked = false;
                    chkSitOcupBusca1Emprego.Checked = false;
                    cboCurso.Text = "Selecione";
                    txtCargaHoraria.Clear();
                    cboDiasSemana_.Clear();
                    txtTurma.Text = string.Empty;
                    txtQualiProfissional.Text = string.Empty;
                    chkSitEvadido.Checked = false;
                    chkSitDispensado.Checked = false;
                    chkSitTrancamento.Checked = false;
                    chkSitTransferido.Checked = false;
                }
                else
                {

                }
            }
            else
            {
                cboHorario_.Clear();
                cboCurso.Text = "Selecione";
                cboSemestre.Text = string.Empty;
                txtAno_Cadastro.Text = string.Empty;
                txtNomeAluno.Text = string.Empty;
                txtRGAluno.Text = string.Empty;
                txtCPFAluno.Text = string.Empty;
                txtNatural.Text = string.Empty;
                txtNacionalidade.Text = string.Empty;
                cboSexo.Text = "Selecione";
                cboEscolaridade.Text = "Selecione";
                txtAnoConclui.Text = string.Empty;
                txtNomeResp.Text = string.Empty;
                txtRGResp.Text = string.Empty;
                txtCPFResp.Text = string.Empty;
                txtLogradouro.Text = string.Empty;
                txtNum.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                cboUF.Text = string.Empty;
                txtCEP.Text = string.Empty;
                txtFoneRes.Text = string.Empty;
                txtFoneCom.Text = string.Empty;
                txtFoneCelular.Text = string.Empty;
                chkNaoPossui.Checked = false;
                chkDefAuditiva.Checked = false;
                chkDefVisual.Checked = false;
                chkDefIntelectual.Checked = false;
                chkDefMultiplas.Checked = false;
                chkDefOutras.Checked = false;
                txtDescOutras.Text = string.Empty;
                chkDefPsicossocial.Checked = false;
                chkDefAltaHabil.Checked = false;
                chkDefCondutaTipicaTEA.Checked = false;
                chkSitOcupAutonomo.Checked = false;
                chkSitOcupEmpregComCarteira.Checked = false;
                chkSitOcupProfLiberal.Checked = false;
                chkSitOcupDesempregado.Checked = false;
                chkSitOcupEmpregador.Checked = false;
                chkSitOcupEmpSemCarteira.Checked = false;
                chkSitOcupAposentado.Checked = false;
                chkSitOcupBusca1Emprego.Checked = false;
                cboCurso.Text = "Selecione";
                txtCargaHoraria.Clear();
                cboDiasSemana_.Clear();
                txtTurma.Text = string.Empty;
                txtQualiProfissional.Text = string.Empty;
                chkSitEvadido.Checked = false;
                chkSitDispensado.Checked = false;
                chkSitTrancamento.Checked = false;
                chkSitTransferido.Checked = false;
            }
            
        }

        private void panelLow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCadastrarAluno_Load(object sender, EventArgs e)
        {
            txtAno_Cadastro.Text = txtDtCadastro.Value.Year.ToString();
            cboSemestre.SelectedIndex = 0;
            try
            {
                if (!Classedall.VerificaCurso())
                {
                    if (MessageBox.Show("Não tem nenhum curso cadastrado ! \n Deseja cadastrar agora ? ", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
                        cadastrarCurso.Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                cboCurso.DataSource = Classedall.DadosCursos();
                cboCurso.DisplayMember = "Nome_Curso";
                cboCurso.ValueMember = "Código_Curso";
                PreencheCamposCurso(Convert.ToInt32(cboCurso.SelectedValue));
            }
            catch (OleDbException)
            {
                MessageBox.Show("Algo inesperado aconteceu ! /n tente novamente mais tarde ", "Reino da Garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void PreencheCamposCurso(int codigoCurso)
        {
            try
            {
                conn.ConnectionString = conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "Select * from TB_Cursos where CodCurso = " + codigoCurso;
                cmd.CommandType = CommandType.Text;
                conn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cboDiasSemana_.Text = dr["cboDiasSemana"].ToString();
                    cboHorario_.Text = dr["cboHorário"].ToString();
                    txtCargaHoraria.Text = dr["txtCargaHoraria"].ToString();
                    txtQualiProfissional.Text = dr["txtQualifProfissional"].ToString();
                    conn.Close();
                }
                else
                {
                    if (MessageBox.Show("Não tem nenhum curso cadastrado ! \n Deseja cadastrar agora ? ", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
                        cadastrarCurso.Show();
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        this.Close();
                    }
                }
            }
            catch (OleDbException)
            {
                conn.Close();
                MessageBox.Show("Algo inesperado aconteceu ! /n tente novamente mais tarde ", "Reino da Garotada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void cboCurso_Leave(object sender, EventArgs e)
        {
            PreencheCamposCurso(Convert.ToInt32(cboCurso.SelectedValue));
        }

        private void txtNomeAluno_Leave(object sender, EventArgs e)
        {
         }

        private void labelCarga_Click(object sender, EventArgs e)
        {

        }

        private void txtCargaHoraria_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cboEscolaridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEscolaridade.Text == "Analfabeto")
            {
                txtAnoConclui.Enabled = false;
                txtAnoConclui.Clear();
            }
            else
            {
                txtAnoConclui.Enabled = true;
            }
        }
    }
}

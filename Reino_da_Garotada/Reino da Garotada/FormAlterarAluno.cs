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
    public partial class FormAlterarAluno : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public static OleDbCommand cmd = Classedall.cmd;
        public static OleDbConnection conn = Classedall.conn;
        //Variavel para receber a excessão de acordo ao radio button selecionado
        public string Where;
        public FormAlterarAluno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelarCadastro_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar? \n\nAs aterações efetuadas não serão salvas", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void rbtPesqNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            txtPesquisar.Mask = string.Empty;
            txtPesquisar.Focus();
            txtPesquisar.Text = "";
            Where = "txtNomeAluno";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            txtPesquisar.Mask = "00,000,000-A";
            txtPesquisar.Focus();
            txtPesquisar.Text = "";
            Where = "txtRGAluno";
        }
        public static void PesquisarAluno(string pesquisa)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            txtPesquisar.Mask = "000,000,000-00";
            txtPesquisar.Focus();
            txtPesquisar.Text = "";
            Where = "txtCPFAluno";
        }

        private void FormPesquisarNMatricula_Load(object sender, EventArgs e)
        {
            rbtPesqNome.Checked = true;
            buttonCancelarCadastro.Enabled = false;
            buttonLimparCadastro.Enabled = false;
            buttonSalvarCadastro.Enabled = false;
            cboCurso.DataSource = Classedall.DadosCursos();
            cboCurso.DisplayMember = "Nome_Curso";
            cboCurso.ValueMember = "Código_Curso";
            cboCurso.Text = "Selecione";
        }

        private void buttonBuscarAluno_Click(object sender, EventArgs e)
        {
            limpaDadosAluno();
            if (txtPesquisar.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório vazio !", "Reino da Garotada");
                txtPesquisar.Focus();
            }
            else
            {
                conn.ConnectionString = Classedall.conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "Select * from TB_Alunos where " + Where + " = '" + txtPesquisar.Text + "';";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblCodigoAluno.Text = dr["CodAluno"].ToString();
                    txtIdade.Text = dr["txtIdadeAluno"].ToString();
                    txtMatricula.Text = dr["txtMatricula"].ToString();
                    cboSemestre.Text = dr["cboSemestre"].ToString();
                    txtDtCadastro.Text = dr["txtDtCadastro"].ToString();
                    txtNomeAluno.Text = dr["txtNomeAluno"].ToString();
                    txtCPFAluno.Text = dr["txtCPFAluno"].ToString();
                    txtRGAluno.Text = dr["txtRGAluno"].ToString();
                    txtDtNascto.Text = dr["txtDtNascto"].ToString();
                    txtNatural.Text = dr["txtNatural"].ToString();
                    txtNacionalidade.Text = dr["txtNacionalidade"].ToString();
                    cboSexo.Text = dr["cboSexo"].ToString();
                    cboEscolaridade.Text = dr["cboEscolaridade"].ToString();
                    txtAnoConclui.Text = dr["txtAnoConclui"].ToString();
                    txtNomeResp.Text = dr["txtNomeResp"].ToString();
                    txtRGResp.Text = dr["txtRGResp"].ToString();
                    txtCPFResp.Text = dr["txtCPFResp"].ToString();
                    txtLogradouro.Text = dr["txtLogradouro"].ToString();
                    txtNum.Text = dr["txtNum"].ToString();
                    txtComplemento.Text = dr["txtComplemento"].ToString();
                    txtBairro.Text = dr["txtBairro"].ToString();
                    txtCidade.Text = dr["txtCidade"].ToString();
                    cboUF.Text = dr["cboUF"].ToString();
                    txtCEP_.Text = dr["txtCEP"].ToString();
                    txtFoneRes.Text = dr["txtFoneRes"].ToString();
                    txtFoneCom.Text = dr["txtFoneCom"].ToString();
                    txtFoneCelular.Text = dr["txtFoneCelular"].ToString();
                    chkNaoPossui.Checked = Convert.ToBoolean(dr["chkNaoPossui"]);
                    chkDefAuditiva.Checked = Convert.ToBoolean(dr["chkDefAuditiva"]);
                    chkDefVisual.Checked = Convert.ToBoolean(dr["chkDefVisual"]);
                    chkDefIntelectual.Checked = Convert.ToBoolean(dr["chkDefIntelectual"]);
                    chkDefMultiplas.Checked = Convert.ToBoolean(dr["chkDefMultiplas"]);
                    chkDefOutras.Checked = Convert.ToBoolean(dr["chkDefOutras"]);
                    txtDescOutras.Text = dr["txtDescOutras"].ToString();
                    chkDefPsicossocial.Checked = Convert.ToBoolean(dr["chkDefPsicossocial"]);
                    chkDefAltaHabil.Checked = Convert.ToBoolean(dr["chkDefAltaHabil"]);
                    chkDefCondutaTipicaTEA.Checked = Convert.ToBoolean(dr["chkDefCondutaTipicaTEA"]);
                    chkSitOcupAutonomo.Checked = Convert.ToBoolean(dr["chkSitOcupAutonomo"]);
                    chkSitOcupEmpregComCarteira.Checked = Convert.ToBoolean(dr["chkSitOcupEmpregComCarteira"]);
                    chkSitOcupProfLiberal.Checked = Convert.ToBoolean(dr["chkSitOcupProfLiberal"]);
                    chkSitOcupDesempregado.Checked = Convert.ToBoolean(dr["chkSitOcupDesempregado"]);
                    chkSitOcupEmpregador.Checked = Convert.ToBoolean(dr["chkSitOcupEmpregador"]);
                    chkSitOcupEmpSemCarteira.Checked = Convert.ToBoolean(dr["chkSitOcupEmpSemCarteira"]);
                    chkSitOcupAposentado.Checked = Convert.ToBoolean(dr["chkSitOcupAposentado"]);
                    chkSitOcupBusca1Emprego.Checked = Convert.ToBoolean(dr["chkSitOcupBusca1Emprego"]);
                    cboCurso.Text = dr["cboCurso"].ToString();
                    txtInicio.Text = dr["txtInicio"].ToString();
                    txtTermino.Text = dr["txtTermino"].ToString();
                    txtTurma.Text = dr["txtTurma"].ToString();
                    txtQualiProfissional.Text = dr["txtQualiProfissional"].ToString();
                    cboResultFinal.Text = dr["cboResultFinal"].ToString();
                    chkSitEvadido.Checked = Convert.ToBoolean(dr["chkSitEvadido"]);
                    chkSitDispensado.Checked = Convert.ToBoolean(dr["chkSitDispensado"]);
                    chkSitTrancamento.Checked = Convert.ToBoolean(dr["chkSitTrancamento"]);
                    chkSitTransferido.Checked = Convert.ToBoolean(dr["chkSitTransferido"]);
                    txtAno_Cadastro.Text = txtDtCadastro.Value.Year.ToString();
                    conn.Close();
                    PreencheCamposCursoEdita(Convert.ToInt32(cboCurso.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Nenhum resultado foi encontrado !", "Reino da Garotada");
                    txtPesquisar.Text = "";
                    txtPesquisar.Focus();
                }
            }

        }

        private void buttonEditarCadastro_Click(object sender, EventArgs e)
        {

            if (txtPesquisar.Text == string.Empty || !Classedall.VerificaAluno(txtPesquisar.Text))
            {
                MessageBox.Show("Primeiro digite algo válido !", "Reino da garotada!");
                txtPesquisar.Focus();
                txtPesquisar.Clear();
            }
            else
            {
                buttonCancelarCadastro.Enabled = true;
                buttonSalvarCadastro.Enabled = true;
                buttonLimparCadastro.Enabled = true;
                btnPesqCep.Visible = true;
                DesbloqueandoCampos();
            }
        }
        public void DesbloqueandoCampos()
        {
            txtIdade.Enabled = true;
            btnPesqCep.Enabled = true;
            cboSemestre.Enabled = true;
            txtDtCadastro.Enabled = true;
            txtNomeAluno.Enabled = true;
            txtCPFAluno.Enabled = true;
            txtDtNascto.Enabled = true;
            txtNatural.Enabled = true;
            txtNacionalidade.Enabled = true;
            cboSexo.Enabled = true;
            cboEscolaridade.Enabled = true;
            txtAnoConclui.Enabled = true;
            txtNomeResp.Enabled = true;
            txtRGResp.Enabled = true;
            txtCPFResp.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNum.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cboUF.Enabled = true;
            txtCEP_.Enabled = true;
            txtFoneRes.Enabled = true;
            txtFoneCom.Enabled = true;
            txtFoneCelular.Enabled = true;
            chkNaoPossui.Enabled = true;
            chkDefAuditiva.Enabled = true;
            chkDefVisual.Enabled = true;
            chkDefIntelectual.Enabled = true;
            chkDefMultiplas.Enabled = true;
            chkDefOutras.Enabled = true;
            txtDescOutras.Enabled = true;
            chkDefPsicossocial.Enabled = true;
            chkDefAltaHabil.Enabled = true;
            chkDefCondutaTipicaTEA.Enabled = true;
            chkSitOcupAutonomo.Enabled = true;
            chkSitOcupEmpregComCarteira.Enabled = true;
            chkSitOcupProfLiberal.Enabled = true;
            chkSitOcupDesempregado.Enabled = true;
            chkSitOcupEmpregador.Enabled = true;
            chkSitOcupEmpSemCarteira.Enabled = true;
            chkSitOcupAposentado.Enabled = true;
            chkSitOcupBusca1Emprego.Enabled = true;
            cboCurso.Enabled = true;
            txtInicio.Enabled = true;
            txtTurma.Enabled = true;
            txtQualiProfissional.Enabled = true;
            cboResultFinal.Enabled = true;
            chkSitEvadido.Enabled = true;
            chkSitDispensado.Enabled = true;
            chkSitTrancamento.Enabled = true;
            chkSitTransferido.Enabled = true;
            txtRGAluno.Enabled = true;
        }
        public void BloqueandoCampos()
        {
            txtIdade.Enabled = false;
            btnPesqCep.Enabled = false;
            cboSemestre.Enabled = false;
            txtDtCadastro.Enabled = false;
            txtNomeAluno.Enabled = false;
            txtCPFAluno.Enabled = false;
            txtDtNascto.Enabled = false;
            txtNatural.Enabled = false;
            txtNacionalidade.Enabled = false;
            cboSexo.Enabled = false;
            cboEscolaridade.Enabled = false;
            txtAnoConclui.Enabled = false;
            txtNomeResp.Enabled = false;
            txtRGResp.Enabled = false;
            txtCPFResp.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNum.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cboUF.Enabled = false;
            txtCEP_.Enabled = false;
            txtFoneRes.Enabled = false;
            txtFoneCom.Enabled = false;
            txtFoneCelular.Enabled = false;
            chkNaoPossui.Enabled = false;
            chkDefAuditiva.Enabled = false;
            chkDefVisual.Enabled = false;
            chkDefIntelectual.Enabled = false;
            chkDefMultiplas.Enabled = false;
            chkDefOutras.Enabled = false;
            txtDescOutras.Enabled = false;
            chkDefPsicossocial.Enabled = false;
            chkDefAltaHabil.Enabled = false;
            chkDefCondutaTipicaTEA.Enabled = false;
            chkSitOcupAutonomo.Enabled = false;
            chkSitOcupEmpregComCarteira.Enabled = false;
            chkSitOcupProfLiberal.Enabled = false;
            chkSitOcupDesempregado.Enabled = false;
            chkSitOcupEmpregador.Enabled = false;
            chkSitOcupEmpSemCarteira.Enabled = false;
            chkSitOcupAposentado.Enabled = false;
            chkSitOcupBusca1Emprego.Enabled = false;
            cboCurso.Enabled = false;
            txtInicio.Enabled = false;
            txtTurma.Enabled = false;
            txtQualiProfissional.Enabled = false;
            cboResultFinal.Enabled = false;
            chkSitEvadido.Enabled = false;
            chkSitDispensado.Enabled = false;
            chkSitTrancamento.Enabled = false;
            chkSitTransferido.Enabled = false;
            txtRGAluno.Enabled = false;
            buttonCancelarCadastro.Enabled = false;
            buttonLimparCadastro.Enabled = false;
            buttonSalvarCadastro.Enabled = false;
        }
        public void limpaDadosAluno()
        {
            txtDtNascto.Text = string.Empty;
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
            txtCEP_.Text = string.Empty;
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
            cboHorario.Text = "Selecione";
            txtCargaHoraria.Text = "Selecione";
            cboDiasSemana.Text = "Selecione";
            txtTurma.Text = string.Empty;
            txtQualiProfissional.Text = string.Empty;
            cboResultFinal.Text = "Selecione";
            chkSitEvadido.Checked = false;
            chkSitDispensado.Checked = false;
            chkSitTrancamento.Checked = false;
            chkSitTransferido.Checked = false;
        }

        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a alteração dos dados ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    // Alterando Dados
                    conn.ConnectionString = conexaoString;
                    cmd.Connection = conn;
                    //Pegando o codigo do aluno
                    //cmd.CommandText = "Update"
                    cmd.CommandText = "update TB_Alunos set cboSemestre = '" + cboSemestre.SelectedItem.ToString() + "', txtAno_Cadastro = '" + txtAno_Cadastro.Text + "', txtDtCadastro = '"
                    + txtDtCadastro.Text + "', txtNomeAluno = '" + txtNomeAluno.Text + "', txtRGAluno = '" + txtRGAluno.Text + "', txtCPFAluno = '" + txtCPFAluno.Text + "', txtDtNascto = '" +
                    txtDtNascto.Text + "', txtNatural = '" + txtNatural.Text + "', txtNacionalidade = '" + txtNacionalidade.Text + "', cboSexo = '" + cboSexo.SelectedItem.ToString() + "'," +
                    "cboEscolaridade = '" + cboEscolaridade.SelectedItem.ToString() + "', txtAnoConclui = '" + txtAnoConclui.Text + "', txtNomeResp = '" + txtNomeResp.Text + "', txtRGResp = '" + txtRGResp.Text +
                    "', txtCPFResp = '" + txtCPFResp.Text + "', txtLogradouro = '" + txtLogradouro.Text + "', txtNum = " + Convert.ToInt32(txtNum.Text) + ", txtComplemento = '" + txtComplemento.Text +
                    "', txtBairro = '" + txtBairro.Text + "', txtCidade = '" + txtCidade.Text + "', cboUF = '" + cboUF.Text + "', txtCEP = '" + txtCEP_.Text +
                    "', txtFoneRes = '" + txtFoneRes.Text + "', txtFoneCom = '" + txtFoneCom.Text + "', txtFoneCelular = '" + txtFoneCelular.Text + "', chkNaoPossui = " + chkNaoPossui.Checked +
                    ", chkDefAuditiva = " + chkDefAuditiva.Checked + ", chkDefVisual = " + chkDefVisual.Checked + ", chkDefIntelectual = " + chkDefIntelectual.Checked + ", chkDefMultiplas = " + chkDefMultiplas.Checked +
                    ", chkDefOutras = " + chkDefOutras.Checked + ", txtDescOutras = '" + txtDescOutras.Text + "', chkDefPsicossocial = " + chkDefPsicossocial.Checked + ", chkDefAltaHabil = " + chkDefAltaHabil.Checked +
                    ", chkDefCondutaTipicaTEA = " + chkDefCondutaTipicaTEA.Checked + ", chkSitOcupAutonomo = " + chkSitOcupAutonomo.Checked + ", chkSitOcupEmpregComCarteira = " + chkSitOcupEmpregComCarteira.Checked + ", chkSitOcupProfLiberal = " + chkSitOcupProfLiberal.Checked +
                    ", chkSitOcupDesempregado = " + chkSitOcupDesempregado.Checked + ", chkSitOcupEmpregador = " + chkSitOcupEmpregador.Checked + ", chkSitOcupEmpSemCarteira = " + chkSitOcupEmpSemCarteira.Checked + ", chkSitOcupAposentado = " + chkSitOcupAposentado.Checked +
                    ", chkSitOcupBusca1Emprego = " + chkSitOcupBusca1Emprego.Checked + ", cboCurso = '" + cboCurso.Text + "', cboHorario = '" + cboHorario.Text + "', txtCargaHoraria = '" + txtCargaHoraria.Text + "', cboDiasSemana = '" + cboDiasSemana.Text +
                    "', txtInicio = '" + txtInicio.Text + "', txtTermino = '" + txtTermino.Text + "', txtTurma = '" + txtTurma.Text + "', txtQualiProfissional = '" + txtQualiProfissional.Text + "', cboResultFinal = '" + cboResultFinal.SelectedItem.ToString() + "', chkSitEvadido = " + chkSitEvadido.Checked +
                    ", chkSitDispensado = " + chkSitDispensado.Checked + ", chkSitTrancamento = " + chkSitTrancamento.Checked + ", chkSitTransferido = " + chkSitTransferido.Checked + ", txtIdadeAluno = " + Convert.ToInt32(txtIdade.Text) + " where CodAluno =" + lblCodigoAluno.Text + ";";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Alteração foi efetuada com sucesso ! \n\nGostaria de efetuar mais alguma alteração ?", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        conn.Close();
                        limpaDadosAluno();
                        txtPesquisar.Clear();
                        txtPesquisar.Focus();
                        BloqueandoCampos();
                    }
                    else
                    {
                        conn.Close();
                        this.Close();
                    }
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Algo deu errado, por favor tente novamente !", "Reino da Garotada");
                    conn.Close();
                    this.Close();
                }
            }
        }

        private void rdbNMatricula_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Mask = "0000000000";
            txtPesquisar.Visible = true;
            txtPesquisar.Text = "";
            Where = "txtMatricula";
        }

        private void buttonLimparCadastro_Click(object sender, EventArgs e)
        {
            limpaDadosAluno();
        }

        private void rdbPesqIdAcima_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDtCadastro_Leave(object sender, EventArgs e)
        {
            txtAno_Cadastro.Text = txtDtCadastro.Value.Year.ToString();
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
                txtCEP_.Clear();
                txtCEP_.Focus();
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
                    var resultado = ws.consultaCEP(txtCEP_.Text);
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtComplemento.Text = resultado.complemento;
                    txtLogradouro.Text = resultado.end;
                    cboUF.Text = resultado.uf;
                }
                catch (Exception)
                {

                    MessageBox.Show("Digite um CEP válido !");
                    txtCEP_.Focus();
                    txtCEP_.Clear();
                }
            }
        }

        private void cboCurso_Leave(object sender, EventArgs e)
        {
            PreencheCamposCursoEdita(Convert.ToInt32(cboCurso.SelectedValue));
        }
        public void PreencheCamposCursoEdita(int codigoCurso)
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
                    cboDiasSemana.Text = dr["cboDiasSemana"].ToString();
                    cboHorario.Text = dr["cboHorário"].ToString();
                    txtCargaHoraria.Text = dr["txtCargaHoraria"].ToString();
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

        private void txtInicio_Leave(object sender, EventArgs e)
        {

            int i = 0, contador;
            txtTermino.Value = txtInicio.Value;
            contador = Convert.ToInt32(txtCargaHoraria.Text.Replace("h", ""));
            while (i < contador)
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

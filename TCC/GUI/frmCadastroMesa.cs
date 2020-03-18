using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroMesa : GUI.frmModeloDeFormularioDeCadastro
    {
        public int codigo = 0;
        public frmCadastroMesa()
        {
            InitializeComponent();
        }       
        private void frmCadastroMesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
                this.Close();
        }
        private void frmCadastroMesa_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            AtualizaTabela();
            PopularComboBox();
        }
        #region Botões
        private void btInserir_Click(object sender, EventArgs e)
        {//---------------------------------------------------------------------------------BOTAO INSERIR
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {//---------------------------------------------------------------------------------BOTAO CANCELAR
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {//---------------------------------------------------------------------------------BOTAO ALTERAR
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }                
        private void btLocalizar_Click(object sender, EventArgs e)
        {//---------------------------------------------------------------------------------BOTAO LOCALIZAR
            frmConsultaMesa f = new frmConsultaMesa();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                ModeloMesa modelo = bll.CarregaModeloMesa(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                cbDepartamento.Text = modelo.Departamento.ToString();
                txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                txtPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                txtSigla.Text = modelo.Sigla.ToString();//joga de volta pra alteração
                cbEstado.Text = modelo.Estado.ToString();
                txtDataCadastro.Text = modelo.DataCadastro.ToString();
                txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {//----------------------------------------------------------------------------------BOTAO SALVAR
            Salvar();
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btfrmCadastroInformacoes_Click(object sender, EventArgs e)
        {
            frmCadastroInformacoes f = new frmCadastroInformacoes();
            f.ShowDialog();
            PopularComboBox();
            f.Dispose();
        }
        #endregion
                       
        #region Controle das TextBox
        private void txtNumeroPatrimonio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNumeroPatrimonio, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtPatrimonioProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtPatrimonioProv, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtSigla, "NES");//Letras,Números,Espaço,Simbolos,Pontuação
        }     
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
#endregion

        #region Métodos
       
        public void LimpaTela()
        {
            txtNumeroPatrimonio.Clear();
            txtPatrimonioProv.Clear();            
            txtSigla.Clear();
            txtDataCadastro.Clear();
            txtUltimaAlteracao.Clear();
            AtualizaTabela();
        }        
        private void AtualizaTabela()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                dgvDados.DataSource = bll.Localizar("");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
            FormMenu organizacao = new FormMenu();
            organizacao.ArrumarTabelaMESAS(dgvDados);
        }
        private void PopularComboBox()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                cbDepartamento.DataSource = bll.LocalizarDepartamento("");
                cbDepartamento.DisplayMember = "departamento";
                cbDepartamento.ValueMember = "codigo";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
            }
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
            if (codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                ModeloMesa modelo = bll.CarregaModeloMesa(codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                cbDepartamento.Text = modelo.Departamento.ToString();
                txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                txtPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                txtSigla.Text = modelo.Sigla.ToString();
                cbEstado.Text = modelo.Estado.ToString();
                txtDataCadastro.Text = modelo.DataCadastro.ToString();
                txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
        }
        private void LimparMesaInativa(int codigoMesa)
        {
            if (cbEstado.Text == "INATIVO")
            {
                codigoMesa = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaComputador bll = new BLLMesaComputador(cx);
                    bll.ExcluirMesa(Convert.ToInt32(codigoMesa));
                    BLLMesaMonitor bll2 = new BLLMesaMonitor(cx);
                    bll2.ExcluirMesa(Convert.ToInt32(codigoMesa));
                    BLLMesaUsuario bll3 = new BLLMesaUsuario(cx);
                    bll3.ExcluirMesa(Convert.ToInt32(codigoMesa));
                    BLLHistorico bll4 = new BLLHistorico(cx);
                    bll4.HistoricoRegistrar("Limpar Mesa","Alterar descrição",codigoMesa);
                }
                catch (Exception) { }
            }
        }
        private void Salvar()
        {
            try
            {
                ModeloMesa modelo = new ModeloMesa();                   //
                modelo.Departamento = Convert.ToInt32(cbDepartamento.SelectedValue);             //
                modelo.NumeroPatrimonio = txtNumeroPatrimonio.Text;     //
                modelo.PatrimonioProv = txtPatrimonioProv.Text;         //
                modelo.Sigla = txtSigla.Text.ToUpper();                           //
                modelo.Estado = cbEstado.Text;                          //
                modelo.DataCadastro = DateTime.Now.ToString();          //
                modelo.UltimaAlteracao = DateTime.Now.ToString();       // Vai salvar oq ta aqui
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                if (this.operacao == "inserir")
                {//------------------------------------------------------------------------------------------------------SALVAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        MessageBox.Show("Não é possível Cadastrar uma Mesa em INATIVO\nCadastre como ATIVO e Altere o Cadastro efetuado\n se é isso que deseja.");
                        this.alteraBotoes(2);
                    }
                    else //Estado ATIVO
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Cadastrar Mesa","mesa cadastrada", modelo.Codigo);                      
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
                else
                {//------------------------------------------------------------------------------------------------------ALTERAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        DialogResult dialogResult = MessageBox.Show("Alterar para INATIVO irá limpar a Mesa, Tem Certeza?", "Aviso!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                            bll.Alterar(modelo);                         
                            LimparMesaInativa(Convert.ToInt32(txtCodigo.Text)); //remove da mesa e adiciona no historico
                            MessageBox.Show("Cadastro alterado");                      
                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        if (dialogResult == DialogResult.No)
                        {
                            this.alteraBotoes(2);//Volta pra alterar
                        }
                    }
                    else
                    {
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Alterar Mesa", "mesa alterada", modelo.Codigo); 
                        MessageBox.Show("Cadastro alterado");
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }
        }
        #endregion           

       

       
    }//class
}//namespace

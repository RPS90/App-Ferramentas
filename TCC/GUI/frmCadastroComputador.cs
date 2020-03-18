using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroComputador : GUI.frmModeloDeFormularioDeCadastro
    {
        public int codigo = 0;
        public frmCadastroComputador()
        {
            InitializeComponent();
        }
        private void frmCadastroComputador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
                this.Close();
        }
        private void frmCadastroComputador_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            AtualizaTabela();
            PopularComboBoxMarca();
        }
        #region Botões
        private void btInserir_Click(object sender, EventArgs e)
        {//-----------------------------------------INSERIR--------------------------------------------------------------
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }        
        private void btCancelar_Click(object sender, EventArgs e)
        {//-----------------------------------------Cancelar-------------------------------------------------------------
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {//------------------------------------------------------------------------------------------------------BOTAO SALVAR
            Salvar();
        }      
        private void btAlterar_Click(object sender, EventArgs e)
        {//-----------------------------------------ALTERAR---------------------------------------------------------------
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }            
        private void btLocalizar_Click(object sender, EventArgs e)
        {//-----------------------------------------Localizar---------------------------------------------------------------
            frmConsultaComputador f = new frmConsultaComputador();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll = new BLLComputador(cx);
                ModeloComputador modelo = bll.CarregaModeloComputador(f.codigo);
                txtCodigo.Text              = modelo.Codigo.ToString();             
                txtIP.Text                  = modelo.IP.ToString();   
                cbMarca.Text               = modelo.Marca.ToString(); 
                txtModeloPC.Text            = modelo.ModeloPC.ToString();
                txtNserie.Text              = modelo.Nserie.ToString();
                txtNumeroPatrimonio.Text    = modelo.NumeroPatrimonio.ToString();
                txtNomeMaquina.Text         = modelo.NomeMaquina.ToString();
                txtPatrimonioProv.Text      = modelo.PatrimonioProv.ToString();
                txtSigla.Text               = modelo.Sigla.ToString();
                cbEstado.Text               = modelo.Estado.ToString();
                txtDataCadastro.Text        = modelo.DataCadastro.ToString();            
                txtUltimaAlteracao.Text     = modelo.UltimaAlteracao.ToString();
                cbTipo.Text = modelo.Tipo.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btfrmCadastroInformacoes_Click(object sender, EventArgs e)
        {
            frmCadastroInformacoes f = new frmCadastroInformacoes();
            f.ShowDialog();
            PopularComboBoxMarca();
            f.Dispose();
        }
        #endregion 
        //---------------------------------------------------------------------------------------------------------------
        #region Controle das TextBox
        private void txtNumeroPatrimonio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNumeroPatrimonio, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtPatrimonioProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtPatrimonioProv, "SP");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtSigla, "NESP");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtIP, "LES");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtModeloPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtModeloPC, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }     
        private void txtNomeMaquina_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNomeMaquina, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtNserie_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNserie, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }   
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//não deixa alterar 
        }
        private void cbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion     
        //---------------------------------------------------------------------------------------------------------------
        #region Métodos
        public void LimpaTela()
        {            
            txtIP.Clear();
           
            txtModeloPC.Clear();
            txtNserie.Clear();
            txtNumeroPatrimonio.Clear();
            txtNomeMaquina.Clear();
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
                BLLComputador bll = new BLLComputador(cx);
                dgvDados.DataSource = bll.Localizar("");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
            FormMenu organizacao = new FormMenu();
            organizacao.ArrumarTabelaCOMPUTADORES(dgvDados);
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //armazena o código da categoria selecionada e fecha o formulário
            {   
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);                
                if (codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLComputador bll = new BLLComputador(cx);
                    ModeloComputador modelo = bll.CarregaModeloComputador(codigo);
                    txtCodigo.Text = modelo.Codigo.ToString();                   
                    txtIP.Text = modelo.IP.ToString();
                    cbMarca.Text = modelo.Marca.ToString();
                    txtModeloPC.Text = modelo.ModeloPC.ToString();
                    txtNserie.Text = modelo.Nserie.ToString();
                    txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                    txtNomeMaquina.Text = modelo.NomeMaquina.ToString();
                    txtPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                    txtSigla.Text = modelo.Sigla.ToString();
                    cbEstado.Text = modelo.Estado.ToString();
                    txtDataCadastro.Text = modelo.DataCadastro.ToString();
                    txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                    cbTipo.Text = modelo.Tipo.ToString();
                    alteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
        }
        private void DesvincularComputadorDasMesas(int codigoComputador)
        {
            if (cbEstado.Text == "INATIVO")
            {
                codigoComputador = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaComputador bll = new BLLMesaComputador(cx);
                    bll.ExcluirComputador(Convert.ToInt32(codigoComputador));
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.HistoricoRegistrar("Desvincular Computador", "Descrição Alterar", codigoComputador); 
                }
                catch (Exception) { }
            }
        }
        private void Salvar()
        {
            try
            {
                ModeloComputador modelo = new ModeloComputador(); //armazena no modelo categoria               
                modelo.IP = txtIP.Text;
                modelo.Marca = Convert.ToInt32(cbMarca.SelectedValue); 
                modelo.ModeloPC = txtModeloPC.Text;
                modelo.Nserie = txtNserie.Text;
                modelo.NumeroPatrimonio = txtNumeroPatrimonio.Text;
                modelo.NomeMaquina = txtNomeMaquina.Text;
                modelo.PatrimonioProv = txtPatrimonioProv.Text;
                modelo.Sigla = txtSigla.Text.ToUpper();//joga pra maiusculo
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                modelo.Tipo = cbTipo.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll = new BLLComputador(cx);
                if (this.operacao == "inserir")
                {//------------------------------------------------------------------------------------------------------SALVAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        MessageBox.Show("Não é possível Cadastrar um Computador em INATIVO\nCadastre como ATIVO e Altere o Cadastro efetuado\nse é isso que deseja.");
                        this.alteraBotoes(2);
                    }
                    else //Estado ATIVO
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Cadastrar Computador","Descrição Alterar", modelo.Codigo);  
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
                else
                {//------------------------------------------------------------------------------------------------------ALTERAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        DialogResult dialogResult = MessageBox.Show("Alterar para INATIVO irá remove-lo\nde todas as Mesas, Tem Certeza?", "Aviso!", 
                            MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {                                     
                            modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                            bll.Alterar(modelo);
                            MessageBox.Show("Cadastro alterado");
                            DesvincularComputadorDasMesas(Convert.ToInt32(txtCodigo.Text));//já envia pro histórico
                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        if (dialogResult == DialogResult.No) { this.alteraBotoes(2); }//Volta pra alterar
                    }
                    else//está ativo
                    {
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado");
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Alterar Computador", "Descrição Alterar", modelo.Codigo); 
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }
        }
        private void PopularComboBoxMarca()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                cbMarca.DataSource = bll.LocalizarMarca("");
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "codigo";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
            }
        }
        #endregion

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {

        }

        

 
        

        

        
    }//class
}//namespace

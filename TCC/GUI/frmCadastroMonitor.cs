using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroMonitor : GUI.frmModeloDeFormularioDeCadastro
    {
        public int codigo = 0;
        public frmCadastroMonitor()
        {
            InitializeComponent();
        }
        private void frmCadastroMonitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
                this.Close();
        }  
        private void frmCadastroMonitor_Load(object sender, EventArgs e)
        {//-----------------------------------------LOAD do FORM---------------------------------------------------------
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
        {//-----------------------------------------CANCELAR-------------------------------------------------------------
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {//-----------------------------------------ALTERAR---------------------------------------------------------------
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }        
        private void btLocalizar_Click(object sender, EventArgs e)
        {//-----------------------------------------LOCALIZAR---------------------------------------------------------------
            frmConsultaMonitor f = new frmConsultaMonitor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                ModeloMonitor modelo = bll.CarregaModeloMonitor(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                txtPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                cbMarca.Text = modelo.Marca.ToString();
                txtNserie.Text = modelo.Nserie.ToString();               
                txtSigla.Text = modelo.Sigla.ToString();
                cbTipo.Text = modelo.Tipo.ToString();
                cbEstado.Text = modelo.Estado.ToString();
                txtDataCadastro.Text = modelo.DataCadastro.ToString();
                txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                txtModelo.Text = modelo.ModeloMNT.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {//-----------------------------------------EXCLUIR---------------------------------------------------------------
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMonitor bll = new BLLMonitor(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {//------------------------------------------------------------------------------------------------------BOTAO SALVAR
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
            PopularComboBoxMarca();
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
        private void txtNserie_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNserie, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }       
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        #region Métodos

        public void LimpaTela()
        {
            txtNumeroPatrimonio.Clear();
            txtPatrimonioProv.Clear();           
            txtNserie.Clear();            
            txtSigla.Clear();
            txtDataCadastro.Clear();
            txtUltimaAlteracao.Clear();
            txtModelo.Clear();
            AtualizaTabela();
        }
        private void AtualizaTabela()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                dgvDados.DataSource = bll.Localizar("");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
            FormMenu organizacao = new FormMenu();
            organizacao.ArrumarTabelaMONITORES(dgvDados);
        }     
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //armazena o código da categoria selecionada e fecha o formulário
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                if (codigo != 0)
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMonitor bll = new BLLMonitor(cx);
                    ModeloMonitor modelo = bll.CarregaModeloMonitor(codigo);
                    txtCodigo.Text = modelo.Codigo.ToString();
                    txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                    txtPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                    cbMarca.Text = modelo.Marca.ToString();
                    txtNserie.Text = modelo.Nserie.ToString();                    
                    txtSigla.Text = modelo.Sigla.ToString();
                    cbTipo.Text = modelo.Tipo.ToString();
                    cbEstado.Text = modelo.Estado.ToString();
                    txtDataCadastro.Text = modelo.DataCadastro.ToString();
                    txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                    txtModelo.Text = modelo.ModeloMNT.ToString();
                    alteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
        }
        private void DesvincularMonitorDasMesas(int codigoMonitor)
        {
            if (cbEstado.Text == "INATIVO")
            {
                codigoMonitor = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaMonitor bll = new BLLMesaMonitor(cx);
                    bll.ExcluirMonitor(Convert.ToInt32(codigoMonitor));
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.HistoricoRegistrar("Desvincular Monitor", "Alterar descrição", codigoMonitor);
                }
                catch (Exception) { }
            }
        }
        private void Salvar()
        {
            try
            {
                ModeloMonitor modelo = new ModeloMonitor(); //vai salvar oq ta nesse modelo
                modelo.NumeroPatrimonio = txtNumeroPatrimonio.Text;
                modelo.PatrimonioProv = txtPatrimonioProv.Text;
                modelo.Marca = Convert.ToInt32(cbMarca.SelectedValue);
                modelo.Nserie = txtNserie.Text;
                modelo.Sigla = txtSigla.Text.ToUpper();
                modelo.Tipo = cbTipo.Text;
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                modelo.ModeloMNT = txtModelo.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);

                if (this.operacao == "inserir")
                {//------------------------------------------------------------------------------------------------------SALVAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        MessageBox.Show("Não é possível Cadastrar um Monitor em INATIVO\nCadastre como ATIVO e Altere o Cadastro efetuado\nse é isso que deseja.");
                        this.alteraBotoes(2);
                    }
                    else //Estado ATIVO
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Cadastrar Monitor", "Alterar descrição", modelo.Codigo);
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
                else
                {//------------------------------------------------------------------------------------------------------ALTERAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        DialogResult dialogResult = MessageBox.Show("Alterar para INATIVO irá remove-lo\nde todas as Mesas, Tem Certeza?", "Aviso!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                            bll.Alterar(modelo);
                            MessageBox.Show("Cadastro alterado");
                            DesvincularMonitorDasMesas(Convert.ToInt32(txtCodigo.Text));
                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        if (dialogResult == DialogResult.No)
                        {
                            this.alteraBotoes(2);//Volta pra alterar
                        }
                    }
                    else//está ativo
                    {
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado");
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Alterar Monitor", "Alterar descrição", modelo.Codigo);
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

        

        

      
    }//class
}//namespace
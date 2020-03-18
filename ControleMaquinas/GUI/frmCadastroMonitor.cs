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
                txtMarca.Text = modelo.Marca.ToString();
                txtNserie.Text = modelo.Nserie.ToString();
                txtDepartamento.Text = modelo.Departamento.ToString();
                txtSigla.Text = modelo.Sigla.ToString();
                cbTipo.Text = modelo.Tipo.ToString();
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
        {//-----------------------------------------SALVAR---------------------------------------------------------------
            try
            {
                ModeloMonitor modelo = new ModeloMonitor(); //vai salvar oq ta nesse modelo
                modelo.NumeroPatrimonio = txtNumeroPatrimonio.Text;
                modelo.PatrimonioProv = txtPatrimonioProv.Text;
                modelo.Marca = txtMarca.Text;
                modelo.Nserie=txtNserie.Text;
                modelo.Departamento=txtDepartamento.Text;
                modelo.Sigla =txtSigla.Text;
                modelo.Tipo = cbTipo.Text;
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.AdicionarAoHistorico("Monitor", txtNumeroPatrimonio.Text);
                }
                else //salvando alteração
                {
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.AdicionarAlteracaoAoHistorico("Monitor", txtNumeroPatrimonio.Text);
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtMarca, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtNserie_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNserie, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtDepartamento, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Métodos

        public void LimpaTela()
        {
            txtNumeroPatrimonio.Clear();
            txtPatrimonioProv.Clear();
            txtMarca.Clear();
            txtNserie.Clear();
            txtDepartamento.Clear();
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
                BLLMonitor bll = new BLLMonitor(cx);
                dgvDados.DataSource = bll.Localizar("");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
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
                    txtMarca.Text = modelo.Marca.ToString();
                    txtNserie.Text = modelo.Nserie.ToString();
                    txtDepartamento.Text = modelo.Departamento.ToString();
                    txtSigla.Text = modelo.Sigla.ToString();
                    cbTipo.Text = modelo.Tipo.ToString();
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

        }
        #endregion
    }//class
}//namespace
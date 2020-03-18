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
        {//-----------------------------------------Cancelar-------------------------------------------------------------
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {//-----------------------------------------SALVAR---------------------------------------------------------------
            try
            {   //leitura dos dados
                ModeloComputador modelo = new ModeloComputador(); //armazena no modelo categoria
                modelo.Departamento = txtDepartamento.Text;
                modelo.IP = txtIP.Text;
                modelo.Marca = txtMarca.Text;
                modelo.ModeloPC = txtModeloPC.Text;
                modelo.Nserie = txtNserie.Text;
                modelo.NumeroPatrimonio = txtNumeroPatrimonio.Text;
                modelo.NomeMaquina = txtNomeMaquina.Text;
                modelo.PatrimonioProv = txtPatrimonioProv.Text;
                modelo.Sigla = txtSigla.Text.ToUpper();//joga pra maiusculo
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll = new BLLComputador(cx);
                if (this.operacao == "inserir")//se a operação for inserir
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);//chama o método incluir
                    MessageBox.Show("Cadastro efetuado: Código "+modelo.Codigo.ToString());                
                   BLLHistorico bll2 = new BLLHistorico(cx);
                   bll2.AdicionarAoHistorico("Computador", txtNumeroPatrimonio.Text);
                }
                else
                {                 
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.AdicionarAlteracaoAoHistorico("computador", txtNumeroPatrimonio.Text);
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }           
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
                txtDepartamento.Text        = modelo.Departamento.ToString();
                txtIP.Text                  = modelo.IP.ToString();   
                txtMarca.Text               = modelo.Marca.ToString(); 
                txtModeloPC.Text            = modelo.ModeloPC.ToString();
                txtNserie.Text              = modelo.Nserie.ToString();
                txtNumeroPatrimonio.Text    = modelo.NumeroPatrimonio.ToString();
                txtNomeMaquina.Text         = modelo.NomeMaquina.ToString();
                txtPatrimonioProv.Text      = modelo.PatrimonioProv.ToString();
                txtSigla.Text               = modelo.Sigla.ToString();
                cbEstado.Text               = modelo.Estado.ToString();
                txtDataCadastro.Text        = modelo.DataCadastro.ToString();            
                txtUltimaAlteracao.Text     = modelo.UltimaAlteracao.ToString();
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
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtMarca, "S");//Letras,Números,Espaço,Simbolos,Pontuação
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
        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtDepartamento, "SP");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//não deixa alterar 
        }            
        #endregion     
        
        #region Métodos
        public void LimpaTela()
        {
            txtDepartamento.Clear();
            txtIP.Clear();
            txtMarca.Clear();
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
                    txtDepartamento.Text = modelo.Departamento.ToString();
                    txtIP.Text = modelo.IP.ToString();
                    txtMarca.Text = modelo.Marca.ToString();
                    txtModeloPC.Text = modelo.ModeloPC.ToString();
                    txtNserie.Text = modelo.Nserie.ToString();
                    txtNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                    txtNomeMaquina.Text = modelo.NomeMaquina.ToString();
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
        }
        #endregion
    }//class
}//namespace

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroInformacoes : Form
    {
        string Operacao = "";
        int codigo = 0;
        public frmCadastroInformacoes()
        {
            InitializeComponent();
        }
        private void frmCadastroInformacoes_Load(object sender, EventArgs e)
        {
            gbCadastrando.Enabled = false;
        }
        #region Botões
        private void btValorCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrando();
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {
            Alterando();
        }        
        private void btExcluir_Click(object sender, EventArgs e)
        {
            Excluindo();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btValorCadastrar.Enabled = true;
            AtualizaTabela();
        }
        #endregion
        #region Métodos
        private void btDepartamento_Click(object sender, EventArgs e)
        {
            gbCadastrando.Enabled = true;
            gbCadastrando.Text = "Cadastrar Departamento";            
            btDepartamento.Enabled = false;
            btMarca.Enabled = true;
            Operacao = "Departamento";
            LimparDados();      
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btValorCadastrar.Enabled = true;
            AtualizaTabela();
        }
        private void btMarca_Click(object sender, EventArgs e)
        {
            gbCadastrando.Enabled = true;
            gbCadastrando.Text = "Cadastrar Marca";            
            btMarca.Enabled = false;
            btDepartamento.Enabled = true;
            Operacao = "Marca";
            LimparDados();     
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btValorCadastrar.Enabled = true;
            AtualizaTabela();
        }            
        private void Cadastrando()
        {//---------------------------------------Salvar
            try
            {
                ModeloInformacoes modelo = new ModeloInformacoes(); 
                modelo.Departamento = txtValor.Text;
                modelo.Marca = txtValor.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                BLLHistorico bll2 = new BLLHistorico(cx);
                switch (Operacao)
                {
                    case "Departamento":
                        bll.IncluirDepartamento(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                        //BLLHistorico bll2 = new BLLHistorico(cx);
                        //bll2.AdicionarAoHistorico("Computador", txtNumeroPatrimonio.Text);   
                        LimparDados();
                        AtualizaTabela();                        
                        bll2.HistoricoRegistrar("Departamento Cadastrado", txtValor.Text, 1);
                        break;
                    case "Marca":
                        bll.IncluirMarca(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());                    
                        bll2.HistoricoRegistrar("Marca Cadastrada", txtValor.Text, 1);
                        LimparDados();
                        AtualizaTabela();
                        break;
                    default:
                        break;
                }                                                           
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }
        }
        private void Alterando()
        {
            try
            {
                ModeloInformacoes modelo = new ModeloInformacoes();
                modelo.Departamento = txtValor.Text;
                modelo.Marca = txtValor.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                switch (Operacao)
                {
                    case "Departamento":
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        bll.AlterarDepartamento(modelo);
                        MessageBox.Show("Cadastro alterado");
                        //BLLHistorico bll2 = new BLLHistorico(cx);
                        //bll2.AdicionarAlteracaoAoHistorico("Computador", txtNumeroPatrimonio.Text);
                        LimparDados();
                        AtualizaTabela();
                        break;
                    case "Marca":
                        modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                        bll.AlterarMarca(modelo);
                        MessageBox.Show("Cadastro alterado");
                        //BLLHistorico bll2 = new BLLHistorico(cx);
                        //bll2.AdicionarAoHistorico("Computador", txtNumeroPatrimonio.Text);
                        LimparDados();
                        AtualizaTabela();
                        break;
                    default:
                        break;
                }
                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
                btCancelar.Enabled = false;
                btValorCadastrar.Enabled = true;
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }
        }     
        private void AtualizaTabela()
        {//--------------------------------------------Organização
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                switch (Operacao)
                {
                    case "Departamento":                              
                        dgvDados.DataSource = bll.LocalizarDepartamento("");
                        dgvDados.Columns["codigo"].HeaderText = "Código";
                        dgvDados.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvDados.Columns["codigo"].DisplayIndex = 0;  
                        dgvDados.Columns["departamento"].HeaderText = "Departamentos Cadastrados";
                        dgvDados.Columns["departamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvDados.Columns["departamento"].DisplayIndex = 1;   
                        break;
                    case "Marca":
                        dgvDados.DataSource = bll.LocalizarMarca("");
                        dgvDados.Columns["codigo"].HeaderText = "Código";
                        dgvDados.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvDados.Columns["codigo"].DisplayIndex = 0;  
                        dgvDados.Columns["marca"].HeaderText = "Marcas Cadastradas";
                        dgvDados.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvDados.Columns["marca"].DisplayIndex = 1; 
                        break;
                    default:
                        break;
                }          
            }
            catch (Exception erros){MessageBox.Show(erros.Message);}            
        }
        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                switch (Operacao)
                {
                    case "Departamento":
                        if (e.RowIndex >= 0)
                        {
                            this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                            if (codigo != 0)
                            {                                                        
                                ModeloInformacoes modelo = bll.CarregaModeloDepartamento(codigo);
                                txtCodigo.Text = modelo.Codigo.ToString();
                                txtValor.Text = modelo.Departamento.ToString();
                            }                          
                        }                      
                        break;
                    case "Marca":
                        if (e.RowIndex >= 0)
                        {
                            this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                            if (codigo != 0)
                            {
                                ModeloInformacoes modelo = bll.CarregaModeloMarca(codigo);
                                txtCodigo.Text = modelo.Codigo.ToString();
                                txtValor.Text = modelo.Marca.ToString();
                            }
                        }  
                        break;
                    default:
                        break;
                }//switch
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
                btValorCadastrar.Enabled = false;
            }//try
            catch (Exception erros) { MessageBox.Show(erros.Message); }            
        }
        private void Excluindo()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                switch (Operacao)
                {
                    case "Departamento":
                        DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                        if (d.ToString() == "Yes")
                        {
                            bll.ExcluirDepartamento(Convert.ToInt32(txtCodigo.Text));
                            LimparDados();
                            btAlterar.Enabled = false;
                            btExcluir.Enabled = false;
                            btCancelar.Enabled = false;
                            btValorCadastrar.Enabled = true;
                            AtualizaTabela();
                        }
                        break;
                    case "Marca":
                        DialogResult m = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                        if (m.ToString() == "Yes")
                        {
                            bll.ExcluirMarca(Convert.ToInt32(txtCodigo.Text));
                            LimparDados();
                            btAlterar.Enabled = false;
                            btExcluir.Enabled = false;
                            btCancelar.Enabled = false;
                            btValorCadastrar.Enabled = true;
                            AtualizaTabela();
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
            }
        }
        private void LimparDados()
        {
            txtValor.Text = "";
            txtCodigo.Text = "";
        }
        #endregion










    }
}

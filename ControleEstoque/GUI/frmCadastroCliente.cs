using Modelo;
using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
    {
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtEndNum.Clear();
            txtEstado.Clear();
            txtRsocial.Clear();
            txtTelefone.Clear();
            
        }
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                txtNome.Text = modelo.CliNome;
                txtCPF.Text = modelo.Clicpfcnpj;
                txtRsocial.Text = modelo.CliRSocial;
                txtCEP.Text = modelo.CliCep;
                txtEndereco.Text = modelo.CliEndereco;
                txtTelefone.Text = modelo.CliFone;
                txtEmail.Text = modelo.CliEmail;
                txtEndNum.Text = modelo.CliEndNumero;
                txtCidade.Text = modelo.CliCidade;
                txtEstado.Text = modelo.CliEstado;
        
                alteraBotoes(3);//estado dos botões
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                   // CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                   // BLLCategoria bll = new BLLCategoria(cx);
                   // bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                   // this.LimpaTela();
                   // this.alteraBotoes(1);//estado original
                }
            }
            catch//caso erro
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {             
             try
            {
                //leitura dos dados
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliCep = txtCEP.Text;
                modelo.CliCidade = txtCidade.Text;
             
                modelo.Clicpfcnpj = txtCPF.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndereco = txtEndereco.Text;
                modelo.CliEndNumero = txtEndNum.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliFone = txtTelefone.Text;
                modelo.CliRSocial = txtRsocial.Text;
              
                CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (this.operacao == "inserir")//se a operação for inserir
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }
}

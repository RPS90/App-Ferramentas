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
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
    {
        public void LimpaTela()
        {
            txtCodigo.Clear();           
            txtNome.Clear();
            txtCNPJ.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtEndNumero.Clear();
            txtFone.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }
        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
        public frmCadastroFornecedor()
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
        //-----------inserir
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        //-------------------cancel
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
            try
            {
                //leitura dos dados
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNome.Text; //armazena no modelo categoria
                modelo.ForCNPJ = txtCNPJ.Text;
                modelo.ForCEP = txtCEP.Text;
                modelo.ForEndereco = txtEndereco.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForEndNumero = txtEndNumero.Text;
                modelo.ForFone = txtFone.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;

                CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                if (this.operacao == "inserir")//se a operação for inserir
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);//chama o método incluir
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtCNPJ.Text = modelo.ForCNPJ;
                txtCEP.Text = modelo.ForCEP;
                txtEndereco.Text = modelo.ForEndereco;
                txtBairro.Text = modelo.ForBairro;
                txtEndNumero.Text = modelo.ForEndNumero;
                txtFone.Text = modelo.ForFone;
                txtEmail.Text = modelo.ForEmail;
                txtCidade.Text =  modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;


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
                    CADConexao cx = new CADConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(cx);
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
    }
}

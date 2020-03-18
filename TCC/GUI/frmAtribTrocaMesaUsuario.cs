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
using MySql.Data.MySqlClient;
namespace GUI
{
    public partial class frmAtribTrocaMesaUsuario : Form
    {
        string ordenar = "AZ";
        
        public frmAtribTrocaMesaUsuario()
        {
            InitializeComponent();
        }
        private void frmAtribTrocaMesaUsuario_Load(object sender, EventArgs e)
        {
            btOrdenarAZ.Enabled = false;
            PopularComboBox();
        }
        #region Botões  
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarMesaUsuario();
        }
        private void btDesvincularUsuario_Click(object sender, EventArgs e)
        {
            RemoverUsuario();
        }
        private void btLimparMesa_Click(object sender, EventArgs e)
        {
            LimparMesa();
        }        
        private void btTelaAnterior_Click(object sender, EventArgs e)
        {
            Close();
            frmAtribTrocaMesaMonitor f = new frmAtribTrocaMesaMonitor();
            f.TopMost = true;
            f.Show();
        }
        private void btProximaTela_Click(object sender, EventArgs e)
        {
            Close();
            frmAtribTrocaMesaComputador f = new frmAtribTrocaMesaComputador();
            f.TopMost = true;
            f.Show();
        }
        #endregion

        #region Métodos
        private void LimparMesa()
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaUsuario bll = new BLLMesaUsuario(cx);
                    bll.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Todos os Usuários foram removidos desta mesa");
                }
            }
            catch { }
        }
        private void RemoverUsuario()
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaUsuario bll = new BLLMesaUsuario(cx);
                    bll.ExcluirUsuario(Convert.ToInt32(cbUsuario.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Usuário removido da mesa onde estava");
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.HistoricoRegistrar("Desvincular Usuário", "Descrição Alterar", Convert.ToInt32(cbUsuario.SelectedValue)); 
                }
            }
            catch { }
        }
        private void CadastrarMesaUsuario()
        {
            try
            {
                ModeloMesaUsuario modelo = new ModeloMesaUsuario();
                modelo.Codigo_Usuario = Convert.ToInt32(cbUsuario.SelectedValue);
                modelo.Codigo_Mesa = Convert.ToInt32(cbMesa.SelectedValue);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesaUsuario bll = new BLLMesaUsuario(cx);
                bll.Incluir(modelo);
                MessageBox.Show("Usuário: " + cbUsuario.Text + " atribuido à mesa: " + cbMesa.Text);

                //BLLHistorico bll2 = new BLLHistorico(cx);
                //bll2.AdicionarConexaoAoHistorico("Usuário", cbUsuario.Text, cbMesa.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no SQL:\n" + erro.Message);
            }
        }
        private void PopularComboBox()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                cbMesa.DataSource = bll.LocalizarApenasAtivos("");
                cbMesa.DisplayMember = "numeropatrimonio";
                cbMesa.ValueMember = "codigo";
                if (ordenar == "AZ")
                {
                    BLLUsuario bll2 = new BLLUsuario(cx);
                    cbUsuario.DataSource = bll2.LocalizarApenasAtivosAZ("");
                    cbUsuario.DisplayMember = "nomeusuario";
                    cbUsuario.ValueMember = "codigo";
                }
                if (ordenar == "codigo")
                {
                    BLLUsuario bll2 = new BLLUsuario(cx);
                    cbUsuario.DataSource = bll2.LocalizarApenasAtivos("");
                    cbUsuario.DisplayMember = "nomeusuario";
                    cbUsuario.ValueMember = "codigo";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
            }
        }   
        #endregion                 

        private void cbMesa_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                ModeloMesa modelo = bll.CarregaModeloMesa(Convert.ToInt32(cbMesa.SelectedValue));
                lblNumeroPatrimonio.Text = modelo.NumeroPatrimonio.ToString();
                //lblDepartamento.Text = modelo.Departamento.ToString();
                lblPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                lblSigla.Text = modelo.Sigla.ToString();
                BLLInformacoes bllInfo = new BLLInformacoes(cx);
                ModeloInformacoes modeloInfo = bllInfo.CarregaModeloDepartamento(modelo.Departamento);
                lblDepartamento.Text = modeloInfo.Departamento;
            }
            catch { }  
        }
        private void cbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll2 = new BLLUsuario(cx);
                ModeloUsuario modelo = bll2.CarregaModeloUsuario(Convert.ToInt32(cbUsuario.SelectedValue));
                lblRamalUsuario.Text = modelo.Ramal.ToString();                
                lblEmailUsuario.Text = modelo.Email.ToString();
                //lblDepartamentoUsuario.Text = modelo.Departamento.ToString();
                BLLInformacoes bllInfo2 = new BLLInformacoes(cx);
                ModeloInformacoes modeloInfo = bllInfo2.CarregaModeloDepartamento(modelo.Departamento);
                lblDepartamentoUsuario.Text = modeloInfo.Departamento;
            }
            catch { }  
        }

        private void btOrdenarAZ_Click(object sender, EventArgs e)
        {
            ordenar = "AZ";
            btOrdenarCodigo.Enabled = true;
            btOrdenarAZ.Enabled = false;
            PopularComboBox();
        }

        private void btOrdenarCodigo_Click(object sender, EventArgs e)
        {
            ordenar = "codigo";
            btOrdenarCodigo.Enabled = false;
            btOrdenarAZ.Enabled = true;
            PopularComboBox();
        }
    }//class
}//namespace

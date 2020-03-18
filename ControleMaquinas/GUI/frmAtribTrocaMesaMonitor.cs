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
    public partial class frmAtribTrocaMesaMonitor : Form
    {
        public frmAtribTrocaMesaMonitor()
        {
            InitializeComponent();
        }
        private void frmAtribTrocaMesaMonitor_Load(object sender, EventArgs e)
        {
            PopularComboBox();
        }
        #region Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarMesaMonitor();
        }
        private void btDesvincularMonitor_Click(object sender, EventArgs e)
        {
            RemoverMonitor();
        }
        private void btLimparMesa_Click(object sender, EventArgs e)
        {
            LimparMesa();
        }
        private void btTelaAnterior_Click(object sender, EventArgs e)
        {
            Close();
            frmAtribTrocaMesaComputador f = new frmAtribTrocaMesaComputador();
            f.TopMost = true; 
            f.Show();
        }
        private void btProximaTela_Click(object sender, EventArgs e)
        {
            Close();
            frmAtribTrocaMesaUsuario f = new frmAtribTrocaMesaUsuario();
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
                    BLLMesaMonitor bll = new BLLMesaMonitor(cx);
                    bll.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Todos os Monitores foram removidos desta mesa");
                }
            }
            catch { }
        }
        private void RemoverMonitor()
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaMonitor bll = new BLLMesaMonitor(cx);
                    bll.ExcluirMonitor(Convert.ToInt32(cbMonitor.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Monitor removido da mesa onde estava");
                }
            }
            catch { }
        }
        private void CadastrarMesaMonitor()
        {
            try
            {
                ModeloMesaMonitor modelo = new ModeloMesaMonitor();
                modelo.Codigo_Monitor = Convert.ToInt32(cbMonitor.SelectedValue);
                modelo.Codigo_Mesa = Convert.ToInt32(cbMesa.SelectedValue);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesaMonitor bll = new BLLMesaMonitor(cx);
                bll.Incluir(modelo);
                MessageBox.Show("Monitor: " + cbMonitor.Text + " atribuido à mesa: " + cbMesa.Text);
                BLLHistorico bll2 = new BLLHistorico(cx);
                bll2.AdicionarConexaoAoHistorico("Monitor", cbMonitor.Text, cbMesa.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
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
                BLLMonitor bll2 = new BLLMonitor(cx);
                cbMonitor.DataSource = bll2.LocalizarApenasAtivos("");
                cbMonitor.DisplayMember = "numeropatrimonio";
                cbMonitor.ValueMember = "codigo";
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
                lblNumeroPatrimonio.Text = modelo.Departamento.ToString();
                lblDepartamento.Text = modelo.NumeroPatrimonio.ToString();
                lblPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                lblSigla.Text = modelo.Sigla.ToString();
            }
            catch { }  
        }

        private void cbMonitor_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll2 = new BLLMonitor(cx);
                ModeloMonitor modelo = bll2.CarregaModeloMonitor(Convert.ToInt32(cbMonitor.SelectedValue));
                lblNumeroPatrimonioMonitor.Text = modelo.NumeroPatrimonio.ToString();
                lblMarcaMonitor.Text = modelo.Marca.ToString();
                lblNserieMonitor.Text = modelo.Nserie.ToString();
                lblDepartamento.Text = modelo.Departamento.ToString();
                lblTipoMonitor.Text = modelo.Tipo.ToString();
            }
            catch { }  
        }

    }//class
}//namespace
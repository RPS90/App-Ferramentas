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
        public frmAtribTrocaMesaUsuario()
        {
            InitializeComponent();
        }
        private void frmAtribTrocaMesaUsuario_Load(object sender, EventArgs e)
        {
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
                BLLHistorico bll2 = new BLLHistorico(cx);
                bll2.AdicionarConexaoAoHistorico("Usuário", cbUsuario.Text, cbMesa.Text);
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
                BLLUsuario bll2 = new BLLUsuario(cx);
                cbUsuario.DataSource = bll2.LocalizarApenasAtivos("");
                cbUsuario.DisplayMember = "nomeusuario";
                cbUsuario.ValueMember = "codigo";
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
        private void cbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll2 = new BLLUsuario(cx);
                ModeloUsuario modelo = bll2.CarregaModeloUsuario(Convert.ToInt32(cbUsuario.SelectedValue));
                lblRamalUsuario.Text = modelo.Ramal.ToString();
                lblDepartamento.Text = modelo.Departamento.ToString();
                lblEmailUsuario.Text = modelo.Email.ToString();                
            }
            catch { }  
        }
    }//class
}//namespace

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
    public partial class frmAtribTrocaMesaComputador : Form
    {
        public frmAtribTrocaMesaComputador()
        {
            InitializeComponent();
        }      
        private void frmAtribTrocaMesaComputador_Load(object sender, EventArgs e)
        {
            PopularComboBox();
        }      
        #region Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarMesaComputador();
        }        
        private void btLimparMesa_Click(object sender, EventArgs e)
        {
            LimparMesa();
        }
        private void btDesvincularComputador_Click(object sender, EventArgs e)
        {
            RemoverComputador();
        }
        private void btTelaAnterior_Click(object sender, EventArgs e)
        {
            Close();
            frmAtribTrocaMesaUsuario f = new frmAtribTrocaMesaUsuario();
          //  f.Closed += (s, args) => this.Close();
            f.TopMost = true; 
            f.Show();
        }
        private void btProximaTela_Click(object sender, EventArgs e)
        {           
            Close();
            frmAtribTrocaMesaMonitor f = new frmAtribTrocaMesaMonitor();
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
                    BLLMesaComputador bll = new BLLMesaComputador(cx);
                    bll.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Todos os computadores foram removidos desta mesa");    
                }
            }
            catch{}
        }
        private void RemoverComputador()
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaComputador bll = new BLLMesaComputador(cx);
                    bll.ExcluirComputador(Convert.ToInt32(cbComputador.SelectedValue));//Não esquecer do ConvertToINT
                    MessageBox.Show("Computador removido da mesa onde estava");
                }
            }
            catch { }
        }
        private void CadastrarMesaComputador()
        {
            try
            {
                ModeloMesaComputador modelo = new ModeloMesaComputador();
                modelo.Codigo_Computador = Convert.ToInt32(cbComputador.SelectedValue);
                modelo.Codigo_Mesa = Convert.ToInt32(cbMesa.SelectedValue);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesaComputador bll = new BLLMesaComputador(cx);
                bll.Incluir(modelo);
                MessageBox.Show("Computador: " + cbComputador.Text + " atribuido à mesa: " + cbMesa.Text);
                BLLHistorico bll2 = new BLLHistorico(cx);
                bll2.AdicionarConexaoAoHistorico("Computador", cbComputador.Text, cbMesa.Text);
            }
            catch (Exception erro)
            {                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
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
                BLLComputador bll2 = new BLLComputador(cx);
                cbComputador.DataSource = bll2.LocalizarApenasAtivos("");
                cbComputador.DisplayMember = "numeropatrimonio";
                cbComputador.ValueMember = "codigo";    
            }
            catch (Exception erro)
            {                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
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
                lblDepartamento.Text = modelo.Departamento.ToString();
                lblPatrimonioProv.Text = modelo.PatrimonioProv.ToString();
                lblSigla.Text = modelo.Sigla.ToString(); 
            }
            catch { }              
        }
        private void cbComputador_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll2 = new BLLComputador(cx);
                ModeloComputador modelo = bll2.CarregaModeloComputador(Convert.ToInt32(cbComputador.SelectedValue));
                lblNumeroPatrimonioComputador.Text = modelo.NumeroPatrimonio.ToString();               
                lblNserieComputador.Text = modelo.Nserie.ToString();
                lblModeloComputador.Text = modelo.ModeloPC.ToString();                
                lblMarcaComputador.Text = modelo.Marca.ToString();
                lblDepartamentoComputador.Text = modelo.Departamento.ToString();
            }
            catch { }  
        }
    }//class
}//namespace
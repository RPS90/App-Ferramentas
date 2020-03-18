using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class frmConsultaMonitor : GUI.frmModeloDeFormularioDeConsulta
    {
        public frmConsultaMonitor()
        {
            InitializeComponent();
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
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                dgvDados.DataSource = bll.Localizar(txtValor.Text);
            }
            catch (Exception) { }     
            
        }
    }//class
}//namespace

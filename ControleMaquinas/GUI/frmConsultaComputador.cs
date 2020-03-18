using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class frmConsultaComputador : GUI.frmModeloDeFormularioDeConsulta
    {
        public frmConsultaComputador()
        {
            InitializeComponent();
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
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLComputador bll = new BLLComputador(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }
    }//class
}//namespace
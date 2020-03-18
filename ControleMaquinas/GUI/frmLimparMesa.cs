using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmLimparMesa : Form
    {
        public frmLimparMesa()
        {
            InitializeComponent();
        }
        private void btLimparMesa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Remover TODOS os registros desta mesa?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaComputador bll = new BLLMesaComputador(cx);
                    bll.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));
                    BLLMesaMonitor bll2 = new BLLMesaMonitor(cx);
                    bll2.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));
                    BLLMesaUsuario bll3 = new BLLMesaUsuario(cx);
                    bll3.ExcluirMesa(Convert.ToInt32(cbMesa.SelectedValue));
                    MessageBox.Show("Mesa: '" + cbMesa.Text + "' foi Limpa");
                    BLLHistorico bll4 = new BLLHistorico(cx);
                    bll4.HistoricoLimparMesa(cbMesa.Text);
                }
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }  
        }
        private void frmLimparMesa_Load(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                cbMesa.DataSource = bll.Localizar("");
                cbMesa.DisplayMember = "numeropatrimonio";
                cbMesa.ValueMember = "codigo";                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
            } 
        }
    }//class
}//namespace

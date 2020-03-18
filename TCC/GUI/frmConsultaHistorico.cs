using System;
using System.Windows.Forms;
using BLL;
using DAL;
using ImprimirDataGridView;

namespace GUI
{
    public partial class frmConsultaHistorico : Form
    {
        string Coluna = ""; //ainda n sei se precisa, resolver isso
        string Pesquisa = "";
        string strDE = "";
        string strATE = "";
        int Departamento = 0;
        int Marca = 0;
        string Acao = "";
        string Estado = "";

        string Operacao= "";
        public frmConsultaHistorico()
        {
            InitializeComponent();
        }
        private void btPesquisar_Click(object sender, EventArgs e)
        {//---------------------------------------------------------------------------Botão PESQUISAR
            switch (cbBusca.Text)
            {
                case "Todos":
                    Pesquisar();
                    OrganizarDataGrid();
                    break;
                case "Computadores":
                    PesquisarEspecifico("computadores");
                    break;
                case "Mesas":
                    PesquisarEspecifico("mesas");
                    break;
                case "Monitores":
                    PesquisarEspecifico("monitores");
                    break;
                case "Usuários":
                    PesquisarEspecifico("usuarios");
                    break;
                default:
                    break;
            }            
            txtValor.Text = "";
            OrganizarDataGrid();
        }
        private void btImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvDados);
        }
        #region Eventos!
        private void frmConsultaHistorico_Load(object sender, EventArgs e)
        {
            strATE = dtpRegistroAte.Value.Year.ToString() + "-" + dtpRegistroAte.Value.Month.ToString() + "-" + dtpRegistroAte.Value.Day.ToString(); 
            PopularComboBox();
            CarregaHistorico();
            OrganizarDataGrid();
            chbAtivo.Checked = true;
            chbInativo.Checked = true;
            chbDepartamento.Checked = false;
            chbMarca.Checked = false;

            cbDepartamento.Enabled =false;
            cbMarca.Enabled = false;
        }
        private void chbAtivo_CheckedChanged(object sender, EventArgs e)//------------------------------------------CHECKBOXES
        {
           if ((chbInativo.Checked == false) && (chbAtivo.Checked == false))
           {
               chbInativo.Checked = true;              
           }
        }
        private void chbInativo_CheckedChanged(object sender, EventArgs e)
        {
           if ((chbInativo.Checked == false) && (chbAtivo.Checked == false))
           {
               chbAtivo.Checked = true;             
           }
        }
        private void chbDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDepartamento.Checked == true)
            {
                cbDepartamento.Enabled = true;
            }
            if (chbDepartamento.Checked == false)
            {
                cbDepartamento.Enabled = false;
                Departamento = 0;
            }
        }
        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMarca.Checked == true)
            {
                cbMarca.Enabled = true;
            }
            if (chbDepartamento.Checked == false)
            {
                cbMarca.Enabled = false;
                Marca = 0;
            }
        }
        private void dtpDE_ValueChanged(object sender, EventArgs e)//------------------------------------------Calendário
        {
            strDE = dtpRegistroDe.Value.Year.ToString() + "-" + dtpRegistroDe.Value.Month.ToString() + "-" + dtpRegistroDe.Value.Day.ToString();          
        }
        private void dtpATE_ValueChanged(object sender, EventArgs e)
        {
            strATE = dtpRegistroAte.Value.Year.ToString() + "-" + dtpRegistroAte.Value.Month.ToString() + "-" + dtpRegistroAte.Value.Day.ToString();           
        }
        private void cbBusca_TextChanged(object sender, EventArgs e)//------------------------------------------Busca
        {
            switch (cbBusca.Text)
            {
                case "Todos":

                    break;
                case "Computadores":

                    break;
                case "Mesas":

                    break;
                case "Monitores":

                    break;
                case "Usuários":

                    break;
                default:
                    break;
            }
        }
        private void cbDepartamento_TextChanged(object sender, EventArgs e)
        {
           //Departamento = Convert.ToInt32(cbDepartamento.SelectedValue);// nao sei se funciona
        }
        private void cbMarca_TextChanged(object sender, EventArgs e)
        {
            //Marca = Convert.ToInt32(cbMarca.SelectedValue);
        }
        private void cbAcoes_TextChanged(object sender, EventArgs e)
        {
            Acao = cbAcoes.Text;
            if (cbAcoes.Text == "Todas")
            {
                Acao = "";
            }
        }
        private void cbBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion  Eventos!   
        #region Métodos
        private void PopularComboBox()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                cbDepartamento.DataSource = bll.LocalizarDepartamento("");
                cbDepartamento.DisplayMember = "departamento";
                cbDepartamento.ValueMember = "codigo";

                BLLInformacoes bll2 = new BLLInformacoes(cx);
                cbMarca.DataSource = bll2.LocalizarMarca("");
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "codigo";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
            }
        }
        private void CarregaHistorico()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLHistorico bll = new BLLHistorico(cx);
                dgvDados.DataSource = bll.Localizar(txtValor.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível carregar o Histórico\nBanco de dados não conectado\nErro: '" + error.Message + "'");
            }      
        }
        public void OrganizarDataGrid()
        {
            dgvDados.Columns["codigo"].HeaderText = "Cód";
            dgvDados.Columns["codigo"].Width = 30;
            dgvDados.Columns["codigo"].DisplayIndex = 0;
            dgvDados.Columns["acao"].HeaderText = "Ação realizada";
            dgvDados.Columns["acao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["acao"].DisplayIndex = 1;
            dgvDados.Columns["item"].HeaderText = "Item do Banco"; //mudar esse título
            dgvDados.Columns["item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["item"].DisplayIndex = 2;
            dgvDados.Columns["dp"].HeaderText = "Departamento";
            dgvDados.Columns["dp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["dp"].DisplayIndex = 3;
            dgvDados.Columns["marca"].HeaderText = "Marca";
            dgvDados.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["marca"].DisplayIndex = 4;
            dgvDados.Columns["descricao"].HeaderText = "Descrição";
            dgvDados.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["descricao"].DisplayIndex = 5; 
            dgvDados.Columns["historicodata"].HeaderText = "Data";
            dgvDados.Columns["historicodata"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //fill manda célula até o fim do form
            dgvDados.Columns["historicodata"].DisplayIndex = 6;     
        }
        private void OrganizarFiltros()
        {           // Coluna 
            string OrgFilPesquisa = "";
            string OrgFilData = "";
            string OrgFilDepartamento = "";
            string OrgFilMarca = "";
            string OrgFilEstado = "";
            string OrgFilAcao = "";
            if (chbAtivo.Checked == true)
            { Estado = "ATIVO"; }
            if (chbInativo.Checked == true)
            { Estado = "INATIVO"; }
            if ((chbAtivo.Checked == true) && (chbInativo.Checked == true))
            {Estado = "";}
            Acao = cbAcoes.Text;
            if (cbAcoes.Text == "Todas")
            { Acao = ""; }
            else { Acao = cbAcoes.Text; }           

            if (Pesquisa.Length != 0){OrgFilPesquisa = "1";}
            if ((strDE.Length != 0) && (strATE.Length != 0)){OrgFilData = "2";}
            if (cbDepartamento.Enabled == true){OrgFilDepartamento = "3";}
            if (cbMarca.Enabled == true){OrgFilMarca = "4";}
            if (Estado.Length != 0){OrgFilEstado = "5";}
            if (Acao.Length != 0) { OrgFilAcao = "6"; }
          
            Operacao = OrgFilPesquisa + OrgFilData + OrgFilDepartamento + OrgFilMarca + OrgFilEstado + OrgFilAcao;          
        }
        private void Pesquisar()//-----------------------------------------------------------------------------Botão pesquisar
        {
            OrganizarFiltros();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLHistorico bll = new BLLHistorico(cx);
                dgvDados.DataSource = bll.LocalizarComFiltros(
                    txtValor.Text, strDE, strATE, Convert.ToInt32(cbDepartamento.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), Acao, Estado, Operacao);
             }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possível carregar o Histórico\nBanco de dados não conectado\nErro: '" + error.Message + "'");
            }             
        }
        private void PesquisarEspecifico(string strBusca)//-----------------------------------------------------------------------------Botão pesquisar
        {
            OrganizarFiltros();
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLHistorico bll = new BLLHistorico(cx);
                dgvDados.DataSource = bll.LocalizarComFiltrosEspecifico( strBusca, txtValor.Text, strDE, strATE, 
                    Convert.ToInt32(cbDepartamento.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), Acao, Estado, Operacao);
            }
            catch (Exception error)
            {                MessageBox.Show("Erro: '" + error.Message + "'");            }
        }
        #endregion Métodos

        







    }        
}

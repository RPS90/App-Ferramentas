using MySql.Data.MySqlClient;
using BLL;
using DAL;
using ImprimirDataGridView;
using System;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        #region Eventos!
        private void FormMenu_Load(object sender, EventArgs e) //LOAD do programa, importante
        {
            LeArquivoConfiguracao();                     
            RelacionamentoTabelaPrincipal();         
        }
        private void cbAtualizarBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Não deixar editar o combobox
        }
        #endregion

        #region Botoes da Tela Principal
        private void btUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void btMesa_Click(object sender, EventArgs e)
        {
            frmCadastroMesa f = new frmCadastroMesa();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void btComputador_Click(object sender, EventArgs e)
        {
            frmCadastroComputador f = new frmCadastroComputador();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void btMonitor_Click(object sender, EventArgs e)
        {
            frmCadastroMonitor f = new frmCadastroMonitor();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }             
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarPesquisar();         
        }
        private void btUsuarioPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioPesquisar();
        }
        private void btMesaPesquisar_Click(object sender, EventArgs e)
        {
            MesaPesquisar();
        }
        private void btComputadorPesquisar_Click(object sender, EventArgs e)
        {
            ComputadorPesquisar();
        }
        private void btMonitorPesquisar_Click(object sender, EventArgs e)
        {
            MonitorPesquisar();
        }
        private void btImprimir_Click(object sender, EventArgs e)
        {            printDGV.Print_DataGridView(dgvDados);
        }
        private void btHistorico_Click(object sender, EventArgs e)
        {            CarregarHistorico();
        }
        private void btTabelaPrincipal_Click(object sender, EventArgs e)
        {            RelacionamentoTabelaPrincipal(); 
        }
        private void skinDark_Click(object sender, EventArgs e)
        {            SkinDarkBanguela();
        }
        private void skinGusta_Click(object sender, EventArgs e)
        {            SkinGustavo();
        }
        private void skinBombom_Click(object sender, EventArgs e)
        {            SkinCecilia();
        }  
        #endregion

        #region Menu de Contexto (tsm)
        private void tsm1Usuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm1Mesa_Click(object sender, EventArgs e)
        {
            frmCadastroMesa f = new frmCadastroMesa();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm1Computador_Click(object sender, EventArgs e)
        {
            frmCadastroComputador f = new frmCadastroComputador();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm1Monitor_Click(object sender, EventArgs e)
        {
            frmCadastroMonitor f = new frmCadastroMonitor();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm2Usuario_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }
        private void tsm2Mesa_Click(object sender, EventArgs e)
        {
            frmConsultaMesa f = new frmConsultaMesa();
            f.ShowDialog();
            f.Dispose();
        }
        private void tsm2Computador_Click(object sender, EventArgs e)
        {
            frmConsultaComputador f = new frmConsultaComputador();
            f.ShowDialog();
            f.Dispose();
        }
        private void tsm2Monitor_Click(object sender, EventArgs e)
        {
            frmConsultaMonitor f = new frmConsultaMonitor();
            f.ShowDialog();
            f.Dispose();
        }
        private void tsm3MesaUsuario_Click(object sender, EventArgs e)
        {
            frmAtribTrocaMesaUsuario f = new frmAtribTrocaMesaUsuario();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm3MesaComputador_Click(object sender, EventArgs e)
        {
            frmAtribTrocaMesaComputador f = new frmAtribTrocaMesaComputador();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm3MesaMonitor_Click(object sender, EventArgs e)
        {
            frmAtribTrocaMesaMonitor f = new frmAtribTrocaMesaMonitor();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm3LimparMesa_Click(object sender, EventArgs e)
        {
            frmLimparMesa f = new frmLimparMesa();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm4ConfigurarBanco_Click(object sender, EventArgs e)
        {
            FormConfigurar f = new FormConfigurar();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm4CriarBanco_Click(object sender, EventArgs e)
        {
            FormCriarBanco f = new FormCriarBanco();
            f.ShowDialog();
            f.Dispose();
        } 
        private void tsm4Historico_Click(object sender, EventArgs e)
        {
            CarregarHistorico();
        }
        private void tsm4Imprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dgvDados);
        }
        private void tsm4Backup_Click(object sender, EventArgs e)
        {
            FormBackup f = new FormBackup();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm6Sobre_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.ShowDialog();
            f.Dispose();
        }     
        #endregion           
 
        #region Principais Métodos
        private void LeArquivoConfiguracao()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                StreamReader arquivo = new StreamReader("conf.cfg"); //Sem parametros
                DadosDaConexao.servidor = arquivo.ReadLine();  //ESTÁ mandando do arquivo de configuração para a DadosDaConexao
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;//teste
                conexao.Open();
                conexao.Close();
            }
            catch (MySqlException)
            { 
                MessageBox.Show("erro ao se conectar ao banco de dados \n Acesse as config do Programa"); 
            }
            catch (Exception erros)
            { 
                MessageBox.Show(erros.Message); 
            }  
        }
        private void RelacionamentoTabelaPrincipal()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTabelas bll = new BLLTabelas(cx);
                dgvDados.DataSource = bll.Relacionamento();
                dgvDados.Columns[0].HeaderText = "Mesa (N°Patrimônio)";
                dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDados.Columns[1].HeaderText = "Usuário (Nome)";
                dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDados.Columns[2].HeaderText = "Computadores (N°Patrimônio)";
                dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDados.Columns[3].HeaderText = "Monitores (N°Patrimônio)";
                dgvDados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDados.Columns[4].HeaderText = "Departamento";
                dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dgvDados.Columns[5].HeaderText = "";
                //dgvDados.Columns[6].HeaderText = "";
                //dgvDados.Columns[7].HeaderText = "";
                //dgvDados.Columns[8].HeaderText = "";
                //dgvDados.Columns[9].HeaderText = "";
            }
            catch (Exception) { }  //sem mensagem de erro           
        }        
        private void CarregarHistorico()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLHistorico bll = new BLLHistorico(cx);
                dgvDados.DataSource = bll.Localizar("");
                dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }              
        }
        private void AtualizarPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            string AtualizarBuscarString = cbAtualizarBuscar.Text; //passando da cb para texto usável no código               
            if (AtualizarBuscarString == "Mesa")
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesa bll = new BLLMesa(cx);
                    dgvDados.DataSource = bll.Localizar(txtValor.Text);
                    txtValor.Text = "";
                    ArrumarTabelaMESAS();
                }
                catch (Exception erros) {MessageBox.Show(erros.Message);}                   
            }
            if (AtualizarBuscarString == "Usuário")
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    dgvDados.DataSource = bll.Localizar(txtValor.Text);
                    txtValor.Text = "";
                    ArrumarTabelaUSUARIOS();
                }
                catch (Exception erros) { MessageBox.Show(erros.Message); }                  
            }
            if (AtualizarBuscarString == "Computador")
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLComputador bll = new BLLComputador(cx);
                    dgvDados.DataSource = bll.Localizar(txtValor.Text);
                    txtValor.Text = "";
                    ArrumarTabelaCOMPUTADORES();
                }
                catch (Exception erros) { MessageBox.Show(erros.Message); }                                  
            }
            if (AtualizarBuscarString == "Monitor")
            {
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMonitor bll = new BLLMonitor(cx);
                    dgvDados.DataSource = bll.Localizar(txtValor.Text);
                    txtValor.Text = "";
                    ArrumarTabelaMONITORES();
                }
                catch (Exception erros) { MessageBox.Show(erros.Message); }                  
            }
        }
        private void UsuarioPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                dgvDados.DataSource = bll.Localizar("");
                txtValor.Text = "";
                ArrumarTabelaUSUARIOS();
            }
            catch (Exception erros) { MessageBox.Show(erros.Message); }              
        }
        private void MesaPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                dgvDados.DataSource = bll.Localizar("");
                txtValor.Text = "";
                ArrumarTabelaMESAS();
            }
            catch (Exception erros) { MessageBox.Show(erros.Message); }              
        }
        private void ComputadorPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll = new BLLComputador(cx);
                dgvDados.DataSource = bll.Localizar("");
                txtValor.Text = "";
                ArrumarTabelaCOMPUTADORES();
            }
            catch (Exception erros) { MessageBox.Show(erros.Message); }             
        }
        private void MonitorPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                dgvDados.DataSource = bll.Localizar("");
                txtValor.Text = "";
                ArrumarTabelaMONITORES();
            }
            catch (Exception erros) { MessageBox.Show(erros.Message); }              
        }
        #endregion

        #region Organização de TABELAS
        private void SkinDarkBanguela()
        {
            btUsuario.BackgroundImage = GUI.Properties.Resources.DarkU;
            btComputador.BackgroundImage = GUI.Properties.Resources.DarkC;
            btMesa.BackgroundImage = GUI.Properties.Resources.DarkMes;
            btMonitor.BackgroundImage = GUI.Properties.Resources.DarkMon;
            btUsuarioPesquisar.BackgroundImage = GUI.Properties.Resources.DarkU;
            btComputadorPesquisar.BackgroundImage = GUI.Properties.Resources.DarkC;
            btMesaPesquisar.BackgroundImage = GUI.Properties.Resources.DarkMes;
            btMonitorPesquisar.BackgroundImage = GUI.Properties.Resources.DarkMon;
            btImprimir.BackgroundImage = GUI.Properties.Resources.DarkPrint;
            btHistorico.BackgroundImage = GUI.Properties.Resources.DarkH;
        }
        private void SkinGustavo()
        {
            btUsuario.BackgroundImage = GUI.Properties.Resources.GustaU;
            btComputador.BackgroundImage = GUI.Properties.Resources.GustaC;
            btMesa.BackgroundImage = GUI.Properties.Resources.GustaMes;
            btMonitor.BackgroundImage = GUI.Properties.Resources.GustaMon;
            btUsuarioPesquisar.BackgroundImage = GUI.Properties.Resources.GustaU;
            btComputadorPesquisar.BackgroundImage = GUI.Properties.Resources.GustaC;
            btMesaPesquisar.BackgroundImage = GUI.Properties.Resources.GustaMes;
            btMonitorPesquisar.BackgroundImage = GUI.Properties.Resources.GustaMon;
            btImprimir.BackgroundImage = GUI.Properties.Resources.GustaP;
            btHistorico.BackgroundImage = GUI.Properties.Resources.GustaH;
        }
        private void SkinCecilia()
        {
            btUsuario.BackgroundImage = GUI.Properties.Resources.DarkU;
            btComputador.BackgroundImage = GUI.Properties.Resources.DarkC;
            btMesa.BackgroundImage = GUI.Properties.Resources.DarkMes;
            btMonitor.BackgroundImage = GUI.Properties.Resources.DarkMon;
            btUsuarioPesquisar.BackgroundImage = GUI.Properties.Resources.DarkU;
            btComputadorPesquisar.BackgroundImage = GUI.Properties.Resources.DarkC;
            btMesaPesquisar.BackgroundImage = GUI.Properties.Resources.DarkMes;
            btMonitorPesquisar.BackgroundImage = GUI.Properties.Resources.DarkMon;
            btImprimir.BackgroundImage = GUI.Properties.Resources.DarkPrint;
            btHistorico.BackgroundImage = GUI.Properties.Resources.DarkH;
        }
        private void ArrumarTabelaMESAS()
        {//5 itens
            dgvDados.Columns[0].HeaderText = "CoD";
            dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[1].HeaderText = "N° de Patrimônio";
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[2].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[3].HeaderText = "Departamento";
            dgvDados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[4].HeaderText = "Sigla";
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[5].HeaderText = "Estado:"; 
            dgvDados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[6].HeaderText = "Data de Cadastro";
            dgvDados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[7].HeaderText = "Última Alteração";
            dgvDados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ArrumarTabelaUSUARIOS()
        {//7 itens
            dgvDados.Columns[0].HeaderText = "CoD";
            dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[1].HeaderText = "Usuário";
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[2].HeaderText = "Login";
            dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[3].HeaderText = "Ramal";
            dgvDados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[4].HeaderText = "Departamento";
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[5].HeaderText = "E-mail";
            dgvDados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[6].HeaderText = "Foto";
            dgvDados.Columns[6].Visible = false;
         // dgvDados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[7].HeaderText = "Estado:";
            dgvDados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[8].HeaderText = "Data de Cadastro";
            dgvDados.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[9].HeaderText = "Última Alteração";
            dgvDados.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ArrumarTabelaMONITORES()
        {// 8 itens
            dgvDados.Columns[0].HeaderText = "CoD";
            dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[1].HeaderText = "N° de Patrimônio";
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[2].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[3].HeaderText = "Marca";
            dgvDados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[4].HeaderText = "N° Série";
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[5].HeaderText = "Departamento";
            dgvDados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[6].HeaderText = "Sigla";
            dgvDados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[7].HeaderText = "Tipo";
            dgvDados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[8].HeaderText = "Estado:";
            dgvDados.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[9].HeaderText = "Data de Cadastro";
            dgvDados.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[10].HeaderText = "Última Alteração";
            dgvDados.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ArrumarTabelaCOMPUTADORES()
        {//10 itens
            dgvDados.Columns[0].HeaderText = "CoD";
            dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //.wid
            dgvDados.Columns[1].HeaderText = "Departamento";
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[2].HeaderText = "IP na Rede";
            dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[3].HeaderText = "Marca";
            dgvDados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[4].HeaderText = "Modelo";
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[5].HeaderText = "N° Série";
            dgvDados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[6].HeaderText = "N° de Patrimônio";
            dgvDados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[7].HeaderText = "Nome da Máquina";
            dgvDados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[8].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[9].HeaderText = "Sigla";
            dgvDados.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[10].HeaderText = "Estado:";
            dgvDados.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[11].HeaderText = "Data de Cadastro";
            dgvDados.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[12].HeaderText = "Última Alteração";
            dgvDados.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

        #region Regras para TEXTBOXES
        public void ControleDasTextBoxes(Object senderX, KeyPressEventArgs eX, TextBox txtbox, String selecao)
        {//Como isso funciona, Letra marcada impede que seja executado no TEXTBOX. ex = 'L' impede que seja escrito LETRAS no TEXTBOX            
            //letras    = L
            //números   = N
            //espaço    = E
            //Simbolos  = S
            //Pontuação = P
            if (txtbox.Text.StartsWith(" ")) { txtbox.Text = ""; }            
            if (selecao.Contains("L"))
            {
                if ((char.IsLetter(eX.KeyChar)))
                { eX.Handled = true; }
            }
            if (selecao.Contains("N"))
            {
                if ((char.IsNumber(eX.KeyChar)))
                { eX.Handled = true; }
            }
            if (selecao.Contains("C"))
            {
                if ((char.IsControl(eX.KeyChar)))
                { eX.Handled = true; }
            }
            if (selecao.Contains("E"))
            {
                if ((char.IsWhiteSpace(eX.KeyChar)))
                { eX.Handled = true; }
            }
            if (selecao.Contains("S"))
            {
                if ((char.IsSymbol(eX.KeyChar)))
                { eX.Handled = true; }
            }
            if (selecao.Contains("P"))
            {
                if ((char.IsPunctuation(eX.KeyChar)))
                { eX.Handled = true; }
            }
        }  
        #endregion
        //private void dgvDados_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        var hti = dgvDados.HitTest(e.X, e.Y);
        //        dgvDados.ClearSelection();
        //        dgvDados.Rows[hti.RowIndex].Selected = true;
        //    }        
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        var ht = dgvDados.HitTest(e.X, e.Y);
        //        // See if the user right-clicked over the header of the last column.
        //        if ((ht.ColumnIndex == dgvDados.Columns.Count - 1) && (ht.Type == DataGridViewHitTestType.ColumnHeader))
        //        {
        //            // This positions the menu at the mouse's location.
        //            contextMenuStrip1.Show(MousePosition);
        //        }
        //    }            
        //}

    }//class
}//namespace
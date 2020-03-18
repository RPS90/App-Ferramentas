using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using BLL;
using DAL;
using ImprimirDataGridView;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        #region Eventos!
        private void FormMenu_Load(object sender, EventArgs e) //LOAD do programa, importante - Chamadas
        {
            LeArquivoConfiguracao();            //try devolve erro                   
            RelacionamentoTabelaPrincipal();    //tirei o erro desse try, mas pensar em algo novo
            Popular_cbAtualizarBuscarColuna();  //pesquisa no Banco pelo nome das TABELAS.COLUNA e retorna, caso crie uma coluna nova no SQL, vai aparecer aqui direto
        }
        private void cbAtualizarBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Não deixar editar o combobox
        }
        private void cbAtualizarBuscar_TextChanged(object sender, EventArgs e)
        {
            switch (cbAtualizarBuscarTabela.Text)
            {
                case "Todos"://ESTADO NORMAL do campo de busca
                    txtValor.Enabled = false; 
                    txtValor.Text = "";         
                    lblMensagem.Text = "";                   
                    rbAtivo.Enabled = false;  
                    rbAtivo.Visible = false;
                    rbInativo.Enabled = false;
                    rbInativo.Visible = false;
                    cbTerceiroCB.Visible = false;
                    cbTerceiroCB.Enabled = false;
                    cbAtualizarBuscarColuna.Enabled = false;
                    break;
                default:
                    cbAtualizarBuscarColuna.Enabled = true;
                    txtValor.Enabled = true;
                    Popular_cbAtualizarBuscarColuna();
                    break;
            }
            
        }
        private void cbAtualizarBuscarColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbAtualizarBuscarColuna_TextChanged(object sender, EventArgs e)
        {
            switch (cbAtualizarBuscarColuna.Text)
            {                
                case "estado":
                   txtValor.Enabled = false;        //desativa campo de busca
                   lblMensagem.Visible = false;     //desativa a mensagem 
                   rbAtivo.Enabled = true;          //ativa os rbs
                   rbAtivo.Visible = true;
                   rbInativo.Enabled = true;            
                   rbInativo.Visible = true;
                   cbTerceiroCB.Visible = false;
                   cbTerceiroCB.Enabled = false;
                   break;
                case "foto":
                   txtValor.Enabled = false;   //desativa campo de busca tbm
                   txtValor.Text = "";
                   lblMensagem.Text = "Retorna apenas Usuários com Foto"; 
                   lblMensagem.Visible = true;  
                   rbAtivo.Enabled = false;   
                   rbAtivo.Visible = false;
                   rbInativo.Enabled = false;
                   rbInativo.Visible = false; 
                   cbTerceiroCB.Visible = false;
                   cbTerceiroCB.Enabled = false;      
                    break;
                case "departamento":
                    rbAtivo.Enabled = false;   
                    rbAtivo.Visible = false;
                    rbInativo.Enabled = false;
                    rbInativo.Visible = false;
                    txtValor.Enabled = false; 
                    txtValor.Text = "";
                    cbTerceiroCB.Visible = true;
                    cbTerceiroCB.Enabled = true;
                    lblMensagem.Text = "Selecione:";
                    Popular_cbTerceiroCB();                    
                    break;
                case "marca":
                    rbAtivo.Enabled = false;   
                    rbAtivo.Visible = false;
                    rbInativo.Enabled = false;
                    rbInativo.Visible = false;
                    txtValor.Enabled = false; 
                    txtValor.Text = "";
                    cbTerceiroCB.Visible = true;
                    cbTerceiroCB.Enabled = true;
                    lblMensagem.Text = "Selecione:";
                    Popular_cbTerceiroCB();     
                    break;
                default://ESTADO NORMAL do campo de busca
                    txtValor.Enabled = true; //reativa campo de busca   
                    txtValor.Text = "";         //apaga o campo de qlq dado
                    lblMensagem.Text = "";
                   // lblMensagem.Visible = false; //libera o lblmsg
                    rbAtivo.Enabled = false;   //desativa os rbs
                    rbAtivo.Visible = false;
                    rbInativo.Enabled = false;
                    rbInativo.Visible = false;
                    cbTerceiroCB.Visible = false;
                    cbTerceiroCB.Enabled = false;
                    break;
            }    
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (cbAtualizarBuscarTabela.Text == "Todos")
            {
                RelacionamentoTabelaPrincipal();
            }
            else 
            {
                if (cbAtualizarBuscarColuna.Text == "estado")
                {
                    AtualizarPesquisarExato();
                }
                else
                {
                    AtualizarPesquisar();
                }
            }            
            txtValor.Text = "";
        }
        private void btAtualizar_MouseEnter(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                lblMensagem.Text = "Campo de pesquisa vazio = Buscar todos";
                lblMensagem.Visible = true;
            }
        }
        private void btAtualizar_MouseLeave(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            { lblMensagem.Visible = false; }
        }
        private void btTabelaPrincipal_MouseEnter(object sender, EventArgs e)
        {
            lblMensagem.Text = "Tabela Principal";
            lblMensagem.Visible = true;
        }
        private void btTabelaPrincipal_MouseLeave(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }
        private void btImprimir_MouseEnter(object sender, EventArgs e)
        {
            lblMensagem.Text = "Imprime tabela atual (Impressora padrão)";
            lblMensagem.Visible = true;
        }
        private void btImprimir_MouseLeave(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }
        private void btHistorico_MouseEnter(object sender, EventArgs e)
        {
            lblMensagem.Text = "Histórico";
            lblMensagem.Visible = true;
        }
        private void btHistorico_MouseLeave(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleDasTextBoxes(sender, e, txtValor, "SP");//F12 no método para mais informações
        }
        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = "ATIVO";
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = "INATIVO";
        }
        private void cbDepartamento_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToString(cbTerceiroCB.SelectedValue);
        }
        private void cbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region Botoes da Tela Principal, toda programação está nos métodos
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
        private void btUsuarioPesquisar_Click(object sender, EventArgs e)
        {
            UsuarioPesquisar("");
            cbAtualizarBuscarTabela.Text = "Usuário";
        }
        private void btMesaPesquisar_Click(object sender, EventArgs e)
        {
            MesaPesquisar("");
            cbAtualizarBuscarTabela.Text = "Mesa";
        }
        private void btComputadorPesquisar_Click(object sender, EventArgs e)
        {
            ComputadorPesquisar("");
            cbAtualizarBuscarTabela.Text = "Computador";
        }
        private void btMonitorPesquisar_Click(object sender, EventArgs e)
        {
            MonitorPesquisar("");
            cbAtualizarBuscarTabela.Text = "Monitor";
        }
        private void btPesquisarHistorico_Click(object sender, EventArgs e)
        {
            frmConsultaHistorico f = new frmConsultaHistorico();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
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
        private void tsm1Info_Click(object sender, EventArgs e)
        {
            frmCadastroInformacoes f = new frmCadastroInformacoes();
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
        private void tsm4BancoBackup_Click(object sender, EventArgs e)
        {
            FormBackup f = new FormBackup();
            f.ShowDialog();
            RelacionamentoTabelaPrincipal();
            f.Dispose();
        }
        private void tsm4BancoCriar_Click(object sender, EventArgs e)
        {
            FormCriarBanco f = new FormCriarBanco();
            f.ShowDialog();//Criar bando n precisa de relacionamentoTabelaPrincipal() pq técnicamente ainda não ta conectado     
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
        private void tsm4SelecionarImpressora_Click(object sender, EventArgs e)
        {
            string manual = @"print.lnk";
            if (File.Exists(manual)) { Process.Start(manual); }
            else
            {
                MessageBox.Show("Não foi possível abrir Dispositivos e Impressoras\nTente por Iniciar>Painel de controle> Dispositivos e Impressoras.");
            }
        }
   
        private void Sobre_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.ShowDialog();
            f.Dispose();
        }
        private void Manual_Click(object sender, EventArgs e)
        {
            string manual = @"manual.pdf";
            if (File.Exists(manual)) { Process.Start(manual); }
            else { MessageBox.Show("Arquivo de manual não foi encontrado, verifique a pasta do programa."); }
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
                lblMsgBanco.Text = "Conectado";                            
                lblMsgBanco.ForeColor = System.Drawing.Color.Green;
            }
            //catch (MySqlException error)
            //{ 
            //    MessageBox.Show("Arquivo de Configuração não encontrado, configure a conexão com banco\n\nErro: '" + error.Message);
            //    lblMsgBanco.Text = "Não conectado";
            //    lblMsgBanco.ForeColor = System.Drawing.Color.Red;
            //}
            catch (Exception error)
            { 
                MessageBox.Show("Arquivo de Configuração não encontrado, configure a conexão com banco\n\nErro: '" + error.Message);
                lblMsgBanco.Text = "Não conectado";
                lblMsgBanco.ForeColor = System.Drawing.Color.Red;
            }  
        }
        private void RelacionamentoTabelaPrincipal()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTabelas bll = new BLLTabelas(cx);
                dgvDados.DataSource = bll.Relacionamento();
                ArrumarTabelaPrincipal(dgvDados);
                lblMsgBanco.Text = "Conectado";
                lblMsgBanco.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception)
            {
                lblMsgBanco.Text = "Não conectado";
                lblMsgBanco.ForeColor = System.Drawing.Color.Red;
            } //MessageBox.Show("Banco de dados não conectado\nErro:" + error.Message);}         
        }        
        private void CarregarHistorico()
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLHistorico bll = new BLLHistorico(cx);
                dgvDados.DataSource = bll.Localizar("");
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
            catch (Exception error) { MessageBox.Show("Não foi possível carregar o Histórico\nBanco de dados não conectado\nErro: '" + error.Message + "'"); }         
        }
        private void AtualizarPesquisarExato()
        {//--------------------------------------------------------------------------------------------------------------------
            string AtualizarBuscarTabela = cbAtualizarBuscarTabela.Text; //passando da cb para texto usável no código               
            string AtualizarBuscarColuna = cbAtualizarBuscarColuna.Text;
            if (AtualizarBuscarTabela == "Mesa")
            {
                try
                {//TESTANDO, colocar condições
                    DALTabelas.stringDeTabela = "mesas";                            //tabela em que vai pesquisar
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;              //aqui vai a coluna de pesquisa
                    DALTabelas.txtBoxPesquisa = txtValor.Text;                      //aqui vai oq quer pesquisar           
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecificoSemLike();
                    ArrumarTabelaMESAS(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Mesas\nErro: '" + error.Message + "'"); }
            }
            if (AtualizarBuscarTabela == "Usuário")
            {
                try
                {
                    DALTabelas.stringDeTabela = "usuarios";
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                    DALTabelas.txtBoxPesquisa = txtValor.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecificoSemLike();
                    ArrumarTabelaUSUARIOS(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Usuários\nErro: '" + error.Message + "'"); }
            }
            if (AtualizarBuscarTabela == "Computador")
            {
                try
                {
                    DALTabelas.stringDeTabela = "computadores"; //string de tabela só existe pra poder ficar um método só lá na busca, pq se não eu tirava
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                    DALTabelas.txtBoxPesquisa = txtValor.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecificoSemLike();
                    ArrumarTabelaCOMPUTADORES(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Computadores\nErro: '" + error.Message + "'"); }
            }
            if (AtualizarBuscarTabela == "Monitor")
            {
                try
                {
                    DALTabelas.stringDeTabela = "monitores"; //string de tabela só existe pra poder ficar um método só lá na busca, pq se não eu tirava
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                    DALTabelas.txtBoxPesquisa = txtValor.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecificoSemLike();
                    ArrumarTabelaMONITORES(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Monitores\nErro: '" + error.Message + "'"); }
            }
        }        
        private void AtualizarPesquisar()
        {//--------------------------------------------------------------------------------------------------------------------
            string AtualizarBuscarTabela = cbAtualizarBuscarTabela.Text; //passando da cb para texto usável no código               
            string AtualizarBuscarColuna = cbAtualizarBuscarColuna.Text;            
            if (AtualizarBuscarTabela == "Mesa")
            {
                try
                {//TESTANDO, colocar condições
                    DALTabelas.stringDeTabela = "mesas";                            //tabela em que vai pesquisar
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;              //aqui vai a coluna de pesquisa
                    DALTabelas.txtBoxPesquisa = txtValor.Text;                      //aqui vai oq quer pesquisar           
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);                  
                    dgvDados.DataSource = bll.LocalizarEspecifico();                  
                    ArrumarTabelaMESAS(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Mesas\nErro: '" + error.Message + "'"); }                      
            }
            if (AtualizarBuscarTabela == "Usuário")
            {                             
                try
                    {
                        DALTabelas.stringDeTabela = "usuarios";
                        DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                        DALTabelas.txtBoxPesquisa = txtValor.Text;
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLTabelas bll = new BLLTabelas(cx);
                        dgvDados.DataSource = bll.LocalizarEspecifico();
                        ArrumarTabelaUSUARIOS(dgvDados);
                    }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Usuários\nErro: '" + error.Message + "'"); }           
            }
            if (AtualizarBuscarTabela == "Computador")
            {
                try
                {
                    DALTabelas.stringDeTabela = "computadores"; //string de tabela só existe pra poder ficar um método só lá na busca, pq se não eu tirava
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                    DALTabelas.txtBoxPesquisa = txtValor.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecifico();
                    ArrumarTabelaCOMPUTADORES(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Computadores\nErro: '" + error.Message + "'"); }                                               
            }
            if (AtualizarBuscarTabela == "Monitor")
            {
                try
                {
                    DALTabelas.stringDeTabela = "monitores"; //string de tabela só existe pra poder ficar um método só lá na busca, pq se não eu tirava
                    DALTabelas.stringDeColuna = AtualizarBuscarColuna;
                    DALTabelas.txtBoxPesquisa = txtValor.Text;
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTabelas bll = new BLLTabelas(cx);
                    dgvDados.DataSource = bll.LocalizarEspecifico();
                    ArrumarTabelaMONITORES(dgvDados);
                }
                catch (Exception error) { MessageBox.Show("Não foi possível carregar a tabela de Monitores\nErro: '" + error.Message + "'"); }                              
            }
        } 
        private void UsuarioPesquisar(string str)
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                dgvDados.DataSource = bll.Localizar(str);
                txtValor.Text = "";
                ArrumarTabelaUSUARIOS(dgvDados);
            }
            catch (Exception error) { MessageBox.Show("Erro ao buscar Usuários\nBanco de dados não conectado\nErro: '" + error.Message + "'"); }       
        }
        private void MesaPesquisar(string str)
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMesa bll = new BLLMesa(cx);
                dgvDados.DataSource = bll.Localizar(str);
                txtValor.Text = "";
                ArrumarTabelaMESAS(dgvDados);
            }
            catch (Exception error) { MessageBox.Show("Erro ao buscar Mesas\nBanco de dados não conectado\nErro: '" + error.Message + "'"); }           
        }
        private void ComputadorPesquisar(string str)
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLComputador bll = new BLLComputador(cx);
                dgvDados.DataSource = bll.Localizar(str);
                txtValor.Text = "";
                ArrumarTabelaCOMPUTADORES(dgvDados);
            }
            catch (Exception error) { MessageBox.Show("Erro ao buscar Computadores\nBanco de dados não conectado\nErro: '" + error.Message + "'"); }            
        }
        private void MonitorPesquisar(string str)
        {//--------------------------------------------------------------------------------------------------------------------
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMonitor bll = new BLLMonitor(cx);
                dgvDados.DataSource = bll.Localizar(str);
                txtValor.Text = "";
                ArrumarTabelaMONITORES(dgvDados);
            }
            catch (Exception error) { MessageBox.Show("Erro ao buscar Monitores\nBanco de dados não conectado\nErro: '" + error.Message + "'"); }           
        }
        private void Popular_cbAtualizarBuscarColuna()
        {//--------------------------------------------------------------------------------------------------------------------
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            if (cbAtualizarBuscarTabela.Text == "Computador")
            {
                try
                {
                    DALTabelas.stringDeTabela = "computadores";
                    BLLTabelas bll = new BLLTabelas(cx);
                    cbAtualizarBuscarColuna.DataSource = bll.ListarColunasDasTabelas();
                    cbAtualizarBuscarColuna.DisplayMember = "column_name";
                    cbAtualizarBuscarColuna.ValueMember = "column_name";
                }
                catch { }
            }            
            if (cbAtualizarBuscarTabela.Text == "Mesa")
            {
                try
                {
                    DALTabelas.stringDeTabela = "mesas";//Lembre-se não é 'MESA' no SQL é MESAS, Com S no final
                    BLLTabelas bll = new BLLTabelas(cx);
                    cbAtualizarBuscarColuna.DataSource = bll.ListarColunasDasTabelas();
                    cbAtualizarBuscarColuna.DisplayMember = "column_name";
                    cbAtualizarBuscarColuna.ValueMember = "column_name";
                }
                catch { }
            } 
            if (cbAtualizarBuscarTabela.Text == "Monitor")
            {
                try
                {
                    DALTabelas.stringDeTabela = "monitores";
                    BLLTabelas bll = new BLLTabelas(cx);
                    cbAtualizarBuscarColuna.DataSource = bll.ListarColunasDasTabelas();
                    cbAtualizarBuscarColuna.DisplayMember = "column_name";
                    cbAtualizarBuscarColuna.ValueMember = "column_name";
                }
                catch { }
            }
            if (cbAtualizarBuscarTabela.Text == "Usuário")
            {
                try
                {
                    DALTabelas.stringDeTabela = "usuarios";
                    BLLTabelas bll = new BLLTabelas(cx);
                    cbAtualizarBuscarColuna.DataSource = bll.ListarColunasDasTabelas();
                    cbAtualizarBuscarColuna.DisplayMember = "column_name";
                    cbAtualizarBuscarColuna.ValueMember = "column_name";
                }
                catch { }
            }
        }
        private void Popular_cbTerceiroCB()
        {
            switch (cbAtualizarBuscarColuna.Text)
            {
                case "departamento":
                    try
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLInformacoes bll = new BLLInformacoes(cx);
                        cbTerceiroCB.DataSource = bll.LocalizarDepartamento("");
                        cbTerceiroCB.DisplayMember = "departamento";
                        cbTerceiroCB.ValueMember = "codigo";
                    }
                    catch { }
                    break;
                case "marca":
                    try
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLInformacoes bll = new BLLInformacoes(cx);
                        cbTerceiroCB.DataSource = bll.LocalizarMarca("");
                        cbTerceiroCB.DisplayMember = "marca";
                        cbTerceiroCB.ValueMember = "codigo";
                    }
                    catch { }
                    break;
            }                  
        }
        #endregion

        #region Mudar Ícones
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
            btTabelaPrincipal.BackgroundImage = GUI.Properties.Resources.DarkTB2;
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
            btTabelaPrincipal.BackgroundImage = GUI.Properties.Resources.GustaTB;
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
        #endregion
        
        #region Organização de TABELAS (Público)
        private void ArrumarTabelaPrincipal(DataGridView dgvDados)
        {
            dgvDados.Columns["numeropatrimonio"].HeaderText = "Mesa (N°Patrimônio)";
            dgvDados.Columns["numeropatrimonio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["numeropatrimonio"].DisplayIndex = 0;                                     
            dgvDados.Columns["usuarios"].HeaderText = "Usuarios (Nome)";
            dgvDados.Columns["usuarios"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["usuarios"].DisplayIndex = 1;
            dgvDados.Columns["computadores"].HeaderText = "Computadores (N°Patrimônio)";
            dgvDados.Columns["computadores"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["computadores"].DisplayIndex = 2;
            dgvDados.Columns["monitores"].HeaderText = "Monitores (N°Patrimônio)";
            dgvDados.Columns["monitores"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["monitores"].DisplayIndex = 3;
            dgvDados.Columns["departamento"].HeaderText = "Departamento";
            dgvDados.Columns["departamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns["departamento"].DisplayIndex = 4;                   
        }
        public void ArrumarTabelaMESAS(DataGridView dgvDados)
        {//ITEMS: numeropatrimonio,patrimonioprov,departamento,sigla,datacadastro,ultimaalteracao,estado         
            dgvDados.Columns["codigo"].HeaderText = "Cód";                             
            dgvDados.Columns["codigo"].Width = 30;          
            dgvDados.Columns["codigo"].DisplayIndex = 0;                                      
            dgvDados.Columns["numeropatrimonio"].HeaderText = "N° de Patrimônio";
            dgvDados.Columns["numeropatrimonio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["numeropatrimonio"].DisplayIndex = 1;
            dgvDados.Columns["patrimonioprov"].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns["patrimonioprov"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["patrimonioprov"].DisplayIndex = 2;
            dgvDados.Columns["departamento"].HeaderText = "Departamento";
            dgvDados.Columns["departamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["departamento"].DisplayIndex = 3;
            dgvDados.Columns["sigla"].HeaderText = "Sigla";
            dgvDados.Columns["sigla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["sigla"].DisplayIndex = 4;
            dgvDados.Columns["estado"].HeaderText = "Estado";
            dgvDados.Columns["estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["estado"].DisplayIndex = 5;
            dgvDados.Columns["datacadastro"].HeaderText = "Data de Cadastro:";
            dgvDados.Columns["datacadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["datacadastro"].DisplayIndex = 6;
            dgvDados.Columns["ultimaalteracao"].HeaderText = "Data de Atualização:";
            dgvDados.Columns["ultimaalteracao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //fill manda célula até o fim do form
            dgvDados.Columns["ultimaalteracao"].DisplayIndex = 7;           
        }
        public void ArrumarTabelaUSUARIOS(DataGridView dgvDados)
        {//nomeusuario,login,ramal,departamento,email,foto,estado,datacadastro,ultimaalteracao
            dgvDados.Columns["codigo"].HeaderText = "Cód";
            dgvDados.Columns["codigo"].Width = 30;
            dgvDados.Columns["codigo"].DisplayIndex = 0;   
            dgvDados.Columns["nomeusuario"].HeaderText = "Nome";
            dgvDados.Columns["nomeusuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["nomeusuario"].DisplayIndex = 1;
            dgvDados.Columns["login"].HeaderText = "ID Login";
            dgvDados.Columns["login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["login"].DisplayIndex = 2;
            dgvDados.Columns["ramal"].HeaderText = "Ramal (Telefone)";
            dgvDados.Columns["ramal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["ramal"].DisplayIndex = 3;
            dgvDados.Columns["departamento"].HeaderText = "Departamento";
            dgvDados.Columns["departamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["departamento"].DisplayIndex = 4;
            dgvDados.Columns["email"].HeaderText = "E-mail";
            dgvDados.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["email"].DisplayIndex = 5;
            dgvDados.Columns["foto"].Visible = false; //--------------------------------------------------------esconde foto
            dgvDados.Columns["estado"].HeaderText = "Estado";
            dgvDados.Columns["estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["estado"].DisplayIndex = 6;
            dgvDados.Columns["datacadastro"].HeaderText = "Data de Cadastro:";
            dgvDados.Columns["datacadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["datacadastro"].DisplayIndex = 7;
            dgvDados.Columns["ultimaalteracao"].HeaderText = "Data de Atualização:";
            dgvDados.Columns["ultimaalteracao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns["ultimaalteracao"].DisplayIndex = 8;              
        }
        public void ArrumarTabelaMONITORES(DataGridView dgvDados)
        {//numeropatrimonio,patrimonioprov,marca,nserie,departamento,sigla,tipo,estado,datacadastro,ultimaalteracao
            dgvDados.Columns["codigo"].HeaderText = "Cód";
            dgvDados.Columns["codigo"].Width = 30;
            dgvDados.Columns["codigo"].DisplayIndex = 0;   
            dgvDados.Columns["numeropatrimonio"].HeaderText = "N° de Patrimônio";
            dgvDados.Columns["numeropatrimonio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["numeropatrimonio"].DisplayIndex = 1;
            dgvDados.Columns["patrimonioprov"].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns["patrimonioprov"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["patrimonioprov"].DisplayIndex = 2;
            dgvDados.Columns["marca"].HeaderText = "Marca";
            dgvDados.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["marca"].DisplayIndex = 3;
            dgvDados.Columns["modelomnt"].HeaderText = "Modelo";
            dgvDados.Columns["modelomnt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["modelomnt"].DisplayIndex = 4;
            dgvDados.Columns["nserie"].HeaderText = "N° de Série";
            dgvDados.Columns["nserie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["nserie"].DisplayIndex = 5;                      
            dgvDados.Columns["sigla"].HeaderText = "Sigla";
            dgvDados.Columns["sigla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["sigla"].DisplayIndex = 6;
            dgvDados.Columns["tipo"].HeaderText = "Tipo de Monitor";
            dgvDados.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["tipo"].DisplayIndex = 7;
            dgvDados.Columns["estado"].HeaderText = "Estado";
            dgvDados.Columns["estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["estado"].DisplayIndex = 8;
            dgvDados.Columns["datacadastro"].HeaderText = "Data de Cadastro:";
            dgvDados.Columns["datacadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["datacadastro"].DisplayIndex = 9;
            dgvDados.Columns["ultimaalteracao"].HeaderText = "Data de Atualização:";
            dgvDados.Columns["ultimaalteracao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns["ultimaalteracao"].DisplayIndex = 10;  
        }
        public void ArrumarTabelaCOMPUTADORES(DataGridView dgvDados)
        {//numeropatrimonio,nomemaquina,modelopc,marca,nserie,departamento,sigla,ip,patrimonioprov,estado,datacadastro,ultimaalteracao
            dgvDados.Columns["codigo"].HeaderText = "Cód";
            dgvDados.Columns["codigo"].Width = 30;
            dgvDados.Columns["codigo"].DisplayIndex = 0;   
            dgvDados.Columns["numeropatrimonio"].HeaderText = "N° de Patrimônio";
            dgvDados.Columns["numeropatrimonio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["numeropatrimonio"].DisplayIndex = 1;
            dgvDados.Columns["nomemaquina"].HeaderText = "Nome na Rede";
            dgvDados.Columns["nomemaquina"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["nomemaquina"].DisplayIndex = 2;
            dgvDados.Columns["modelopc"].HeaderText = "Modelo";
            dgvDados.Columns["modelopc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["modelopc"].DisplayIndex = 3;
            dgvDados.Columns["marca"].HeaderText = "Marca";
            dgvDados.Columns["marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["marca"].DisplayIndex = 4;
            dgvDados.Columns["tipo"].HeaderText = "Tipo";
            dgvDados.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["tipo"].DisplayIndex = 5; 
            dgvDados.Columns["nserie"].HeaderText = "N° de Série";
            dgvDados.Columns["nserie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["nserie"].DisplayIndex = 6;         
            dgvDados.Columns["sigla"].HeaderText = "Sigla";
            dgvDados.Columns["sigla"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["sigla"].DisplayIndex = 7;
            dgvDados.Columns["ip"].HeaderText = "IP (0.0.0.0)";
            dgvDados.Columns["ip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["ip"].DisplayIndex = 8;
            dgvDados.Columns["patrimonioprov"].HeaderText = "Patrimônio Prov.";
            dgvDados.Columns["patrimonioprov"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["patrimonioprov"].DisplayIndex = 9;
            dgvDados.Columns["estado"].HeaderText = "Estado";
            dgvDados.Columns["estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["estado"].DisplayIndex = 10;
            dgvDados.Columns["datacadastro"].HeaderText = "Data de Cadastro:";
            dgvDados.Columns["datacadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns["datacadastro"].DisplayIndex = 11;
            dgvDados.Columns["ultimaalteracao"].HeaderText = "Data de Atualização:";
            dgvDados.Columns["ultimaalteracao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns["ultimaalteracao"].DisplayIndex = 12;            
        }
        #endregion
                
        #region Regras para TEXTBOXES (público)
        public void ControleDasTextBoxes(Object senderX, KeyPressEventArgs eX, TextBox txtbox, String selecao)
        {//Como isso funciona, Letra marcada impede que seja executado no TEXTBOX. ex = 'L' impede que seja escrito LETRAS no TEXTBOX  
         //usando em outros forms:
         //FormMenu organizacao = new FormMenu();
         //organizacao.ControleDasTextBoxes(sender, e, SeuTxtBox, "S");//Letras,Números,Espaço,Simbolos,Pontuação
         //letras = L            //números = N            //espaço = E            //Simbolos = S            //Pontuação = P           
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

       

   

     
       

       
        
    }//class
}//namespace














//private void dgvDados_MouseDown(object sender, MouseEventArgs e)
//{//-----------------------------TESTE com click direito do mouse no Grid!
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

namespace GUI
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm1Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm1Computador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm1Mesa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm1Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm1Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm1Info = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2Pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2Computador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2Mesa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoPesquisaAvançadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3AtribuirTrocar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3MesaComputador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3MesaMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3MesaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3LimparMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4ConfigurarBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4BancoDados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4BancoCriar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4BancoBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4Icones = new System.Windows.Forms.ToolStripMenuItem();
            this.skinDark = new System.Windows.Forms.ToolStripMenuItem();
            this.skinGusta = new System.Windows.Forms.ToolStripMenuItem();
            this.skinBombom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4Historico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4SelecionarImpressora = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Manual = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAtualizarBuscarTabela = new System.Windows.Forms.ComboBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.btMesa = new System.Windows.Forms.Button();
            this.btMonitor = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btComputador = new System.Windows.Forms.Button();
            this.gbListarTodos = new System.Windows.Forms.GroupBox();
            this.btUsuarioPesquisar = new System.Windows.Forms.Button();
            this.btMonitorPesquisar = new System.Windows.Forms.Button();
            this.btMesaPesquisar = new System.Windows.Forms.Button();
            this.btComputadorPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cbAtualizarBuscarColuna = new System.Windows.Forms.ComboBox();
            this.btHistorico = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btTabelaPrincipal = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.lblMsgBanco = new System.Windows.Forms.Label();
            this.cbTerceiroCB = new System.Windows.Forms.ComboBox();
            this.btPesquisarHistorico = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbCadastrar.SuspendLayout();
            this.gbListarTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(243, 108);
            this.txtValor.MaxLength = 64;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(468, 20);
            this.txtValor.TabIndex = 11;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm1Cadastrar,
            this.tsm2Pesquisar,
            this.tsm3AtribuirTrocar,
            this.tsm4,
            this.tsm5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm1Cadastrar
            // 
            this.tsm1Cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm1Computador,
            this.tsm1Mesa,
            this.tsm1Monitor,
            this.tsm1Usuario,
            this.tsm1Info});
            this.tsm1Cadastrar.Name = "tsm1Cadastrar";
            this.tsm1Cadastrar.Size = new System.Drawing.Size(67, 20);
            this.tsm1Cadastrar.Text = "Cadastrar";
            // 
            // tsm1Computador
            // 
            this.tsm1Computador.Image = ((System.Drawing.Image)(resources.GetObject("tsm1Computador.Image")));
            this.tsm1Computador.Name = "tsm1Computador";
            this.tsm1Computador.Size = new System.Drawing.Size(152, 22);
            this.tsm1Computador.Text = "Computador";
            this.tsm1Computador.Click += new System.EventHandler(this.tsm1Computador_Click);
            // 
            // tsm1Mesa
            // 
            this.tsm1Mesa.Image = ((System.Drawing.Image)(resources.GetObject("tsm1Mesa.Image")));
            this.tsm1Mesa.Name = "tsm1Mesa";
            this.tsm1Mesa.Size = new System.Drawing.Size(152, 22);
            this.tsm1Mesa.Text = "Mesa";
            this.tsm1Mesa.Click += new System.EventHandler(this.tsm1Mesa_Click);
            // 
            // tsm1Monitor
            // 
            this.tsm1Monitor.Image = ((System.Drawing.Image)(resources.GetObject("tsm1Monitor.Image")));
            this.tsm1Monitor.Name = "tsm1Monitor";
            this.tsm1Monitor.Size = new System.Drawing.Size(152, 22);
            this.tsm1Monitor.Text = "Monitor";
            this.tsm1Monitor.Click += new System.EventHandler(this.tsm1Monitor_Click);
            // 
            // tsm1Usuario
            // 
            this.tsm1Usuario.Image = ((System.Drawing.Image)(resources.GetObject("tsm1Usuario.Image")));
            this.tsm1Usuario.Name = "tsm1Usuario";
            this.tsm1Usuario.Size = new System.Drawing.Size(152, 22);
            this.tsm1Usuario.Text = "Usuário";
            this.tsm1Usuario.Click += new System.EventHandler(this.tsm1Usuario_Click);
            // 
            // tsm1Info
            // 
            this.tsm1Info.Image = global::GUI.Properties.Resources.DarkTB2;
            this.tsm1Info.Name = "tsm1Info";
            this.tsm1Info.Size = new System.Drawing.Size(152, 22);
            this.tsm1Info.Text = "Informações";
            this.tsm1Info.Click += new System.EventHandler(this.tsm1Info_Click);
            // 
            // tsm2Pesquisar
            // 
            this.tsm2Pesquisar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm2Computador,
            this.tsm2Mesa,
            this.tsm2Monitor,
            this.tsm2Usuario,
            this.históricoPesquisaAvançadaToolStripMenuItem});
            this.tsm2Pesquisar.Name = "tsm2Pesquisar";
            this.tsm2Pesquisar.Size = new System.Drawing.Size(65, 20);
            this.tsm2Pesquisar.Text = "Pesquisar";
            // 
            // tsm2Computador
            // 
            this.tsm2Computador.Name = "tsm2Computador";
            this.tsm2Computador.Size = new System.Drawing.Size(218, 22);
            this.tsm2Computador.Text = "Computador";
            this.tsm2Computador.Click += new System.EventHandler(this.tsm2Computador_Click);
            // 
            // tsm2Mesa
            // 
            this.tsm2Mesa.Name = "tsm2Mesa";
            this.tsm2Mesa.Size = new System.Drawing.Size(218, 22);
            this.tsm2Mesa.Text = "Mesa";
            this.tsm2Mesa.Click += new System.EventHandler(this.tsm2Mesa_Click);
            // 
            // tsm2Monitor
            // 
            this.tsm2Monitor.Name = "tsm2Monitor";
            this.tsm2Monitor.Size = new System.Drawing.Size(218, 22);
            this.tsm2Monitor.Text = "Monitor";
            this.tsm2Monitor.Click += new System.EventHandler(this.tsm2Monitor_Click);
            // 
            // tsm2Usuario
            // 
            this.tsm2Usuario.Name = "tsm2Usuario";
            this.tsm2Usuario.Size = new System.Drawing.Size(218, 22);
            this.tsm2Usuario.Text = "Usuário";
            this.tsm2Usuario.Click += new System.EventHandler(this.tsm2Usuario_Click);
            // 
            // históricoPesquisaAvançadaToolStripMenuItem
            // 
            this.históricoPesquisaAvançadaToolStripMenuItem.Name = "históricoPesquisaAvançadaToolStripMenuItem";
            this.históricoPesquisaAvançadaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.históricoPesquisaAvançadaToolStripMenuItem.Text = "Histórico (Pesquisa avançada)";
            // 
            // tsm3AtribuirTrocar
            // 
            this.tsm3AtribuirTrocar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm3MesaComputador,
            this.tsm3MesaMonitor,
            this.tsm3MesaUsuario,
            this.tsm3LimparMesa});
            this.tsm3AtribuirTrocar.Name = "tsm3AtribuirTrocar";
            this.tsm3AtribuirTrocar.Size = new System.Drawing.Size(95, 20);
            this.tsm3AtribuirTrocar.Text = "Atribuir / Trocar";
            // 
            // tsm3MesaComputador
            // 
            this.tsm3MesaComputador.Name = "tsm3MesaComputador";
            this.tsm3MesaComputador.Size = new System.Drawing.Size(168, 22);
            this.tsm3MesaComputador.Text = "Mesa / Computador";
            this.tsm3MesaComputador.Click += new System.EventHandler(this.tsm3MesaComputador_Click);
            // 
            // tsm3MesaMonitor
            // 
            this.tsm3MesaMonitor.Name = "tsm3MesaMonitor";
            this.tsm3MesaMonitor.Size = new System.Drawing.Size(168, 22);
            this.tsm3MesaMonitor.Text = "Mesa / Monitor";
            this.tsm3MesaMonitor.Click += new System.EventHandler(this.tsm3MesaMonitor_Click);
            // 
            // tsm3MesaUsuario
            // 
            this.tsm3MesaUsuario.Name = "tsm3MesaUsuario";
            this.tsm3MesaUsuario.Size = new System.Drawing.Size(168, 22);
            this.tsm3MesaUsuario.Text = "Mesa / Usuário";
            this.tsm3MesaUsuario.Click += new System.EventHandler(this.tsm3MesaUsuario_Click);
            // 
            // tsm3LimparMesa
            // 
            this.tsm3LimparMesa.Name = "tsm3LimparMesa";
            this.tsm3LimparMesa.Size = new System.Drawing.Size(168, 22);
            this.tsm3LimparMesa.Text = "Limpar Mesa";
            this.tsm3LimparMesa.Click += new System.EventHandler(this.tsm3LimparMesa_Click);
            // 
            // tsm4
            // 
            this.tsm4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm4ConfigurarBanco,
            this.tsm4BancoDados,
            this.tsm4Icones,
            this.tsm4Historico,
            this.tsm4Imprimir,
            this.tsm4SelecionarImpressora});
            this.tsm4.Name = "tsm4";
            this.tsm4.Size = new System.Drawing.Size(59, 20);
            this.tsm4.Text = "Funções";
            // 
            // tsm4ConfigurarBanco
            // 
            this.tsm4ConfigurarBanco.Name = "tsm4ConfigurarBanco";
            this.tsm4ConfigurarBanco.Size = new System.Drawing.Size(215, 22);
            this.tsm4ConfigurarBanco.Text = "Configurar Conexão";
            this.tsm4ConfigurarBanco.Click += new System.EventHandler(this.tsm4ConfigurarBanco_Click);
            // 
            // tsm4BancoDados
            // 
            this.tsm4BancoDados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm4BancoCriar,
            this.tsm4BancoBackup});
            this.tsm4BancoDados.Name = "tsm4BancoDados";
            this.tsm4BancoDados.Size = new System.Drawing.Size(215, 22);
            this.tsm4BancoDados.Text = "Banco de Dados";
            // 
            // tsm4BancoCriar
            // 
            this.tsm4BancoCriar.Name = "tsm4BancoCriar";
            this.tsm4BancoCriar.Size = new System.Drawing.Size(129, 22);
            this.tsm4BancoCriar.Text = "Criar banco";
            this.tsm4BancoCriar.Click += new System.EventHandler(this.tsm4BancoCriar_Click);
            // 
            // tsm4BancoBackup
            // 
            this.tsm4BancoBackup.Name = "tsm4BancoBackup";
            this.tsm4BancoBackup.Size = new System.Drawing.Size(129, 22);
            this.tsm4BancoBackup.Text = "Backup";
            this.tsm4BancoBackup.Click += new System.EventHandler(this.tsm4BancoBackup_Click);
            // 
            // tsm4Icones
            // 
            this.tsm4Icones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinDark,
            this.skinGusta,
            this.skinBombom});
            this.tsm4Icones.Name = "tsm4Icones";
            this.tsm4Icones.Size = new System.Drawing.Size(215, 22);
            this.tsm4Icones.Text = "Mudar ícones";
            // 
            // skinDark
            // 
            this.skinDark.Name = "skinDark";
            this.skinDark.Size = new System.Drawing.Size(174, 22);
            this.skinDark.Text = "Dark";
            this.skinDark.Click += new System.EventHandler(this.skinDark_Click);
            // 
            // skinGusta
            // 
            this.skinGusta.Name = "skinGusta";
            this.skinGusta.Size = new System.Drawing.Size(174, 22);
            this.skinGusta.Text = "Gustavo (Renomear)";
            this.skinGusta.Click += new System.EventHandler(this.skinGusta_Click);
            // 
            // skinBombom
            // 
            this.skinBombom.Name = "skinBombom";
            this.skinBombom.Size = new System.Drawing.Size(174, 22);
            this.skinBombom.Text = "Cecília (Renomear)";
            this.skinBombom.Click += new System.EventHandler(this.skinBombom_Click);
            // 
            // tsm4Historico
            // 
            this.tsm4Historico.Name = "tsm4Historico";
            this.tsm4Historico.Size = new System.Drawing.Size(215, 22);
            this.tsm4Historico.Text = "Histórico";
            this.tsm4Historico.Click += new System.EventHandler(this.tsm4Historico_Click);
            // 
            // tsm4Imprimir
            // 
            this.tsm4Imprimir.Name = "tsm4Imprimir";
            this.tsm4Imprimir.Size = new System.Drawing.Size(215, 22);
            this.tsm4Imprimir.Text = "Imprimir..";
            this.tsm4Imprimir.Click += new System.EventHandler(this.tsm4Imprimir_Click);
            // 
            // tsm4SelecionarImpressora
            // 
            this.tsm4SelecionarImpressora.Name = "tsm4SelecionarImpressora";
            this.tsm4SelecionarImpressora.Size = new System.Drawing.Size(215, 22);
            this.tsm4SelecionarImpressora.Text = "Selecionar impressora padrão";
            this.tsm4SelecionarImpressora.Click += new System.EventHandler(this.tsm4SelecionarImpressora_Click);
            // 
            // tsm5
            // 
            this.tsm5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Manual,
            this.Sobre});
            this.tsm5.Name = "tsm5";
            this.tsm5.Size = new System.Drawing.Size(47, 20);
            this.tsm5.Text = "Ajuda";
            // 
            // Manual
            // 
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(199, 22);
            this.Manual.Text = "Manual do programa (pdf)";
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // Sobre
            // 
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(199, 22);
            this.Sobre.Text = "Sobre...";
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // cbAtualizarBuscarTabela
            // 
            this.cbAtualizarBuscarTabela.FormattingEnabled = true;
            this.cbAtualizarBuscarTabela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAtualizarBuscarTabela.Items.AddRange(new object[] {
            "Todos",
            "Computador",
            "Mesa",
            "Monitor",
            "Usuário"});
            this.cbAtualizarBuscarTabela.Location = new System.Drawing.Point(12, 108);
            this.cbAtualizarBuscarTabela.Name = "cbAtualizarBuscarTabela";
            this.cbAtualizarBuscarTabela.Size = new System.Drawing.Size(102, 21);
            this.cbAtualizarBuscarTabela.TabIndex = 128;
            this.cbAtualizarBuscarTabela.Text = "Todos";
            this.cbAtualizarBuscarTabela.TextChanged += new System.EventHandler(this.cbAtualizarBuscar_TextChanged);
            this.cbAtualizarBuscarTabela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAtualizarBuscar_KeyPress);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAtualizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(717, 27);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(102, 102);
            this.btAtualizar.TabIndex = 16;
            this.btAtualizar.Text = "Atualizar/ Pesquisar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            this.btAtualizar.MouseEnter += new System.EventHandler(this.btAtualizar_MouseEnter);
            this.btAtualizar.MouseLeave += new System.EventHandler(this.btAtualizar_MouseLeave);
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.btMesa);
            this.gbCadastrar.Controls.Add(this.btMonitor);
            this.gbCadastrar.Controls.Add(this.btUsuario);
            this.gbCadastrar.Controls.Add(this.btComputador);
            this.gbCadastrar.Location = new System.Drawing.Point(12, 27);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(225, 75);
            this.gbCadastrar.TabIndex = 133;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar / Alterar";
            // 
            // btMesa
            // 
            this.btMesa.BackColor = System.Drawing.SystemColors.Control;
            this.btMesa.BackgroundImage = global::GUI.Properties.Resources.DarkMes;
            this.btMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMesa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMesa.Location = new System.Drawing.Point(60, 19);
            this.btMesa.Name = "btMesa";
            this.btMesa.Size = new System.Drawing.Size(48, 50);
            this.btMesa.TabIndex = 18;
            this.btMesa.UseVisualStyleBackColor = false;
            this.btMesa.Click += new System.EventHandler(this.btMesa_Click);
            // 
            // btMonitor
            // 
            this.btMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.btMonitor.BackgroundImage = global::GUI.Properties.Resources.DarkMon;
            this.btMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMonitor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMonitor.Location = new System.Drawing.Point(168, 19);
            this.btMonitor.Name = "btMonitor";
            this.btMonitor.Size = new System.Drawing.Size(48, 50);
            this.btMonitor.TabIndex = 10;
            this.btMonitor.UseVisualStyleBackColor = false;
            this.btMonitor.Click += new System.EventHandler(this.btMonitor_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btUsuario.BackgroundImage = global::GUI.Properties.Resources.DarkU;
            this.btUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuario.Location = new System.Drawing.Point(6, 19);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(48, 50);
            this.btUsuario.TabIndex = 9;
            this.btUsuario.UseVisualStyleBackColor = false;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btComputador
            // 
            this.btComputador.BackColor = System.Drawing.SystemColors.Control;
            this.btComputador.BackgroundImage = global::GUI.Properties.Resources.DarkC;
            this.btComputador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btComputador.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComputador.Location = new System.Drawing.Point(114, 19);
            this.btComputador.Name = "btComputador";
            this.btComputador.Size = new System.Drawing.Size(48, 50);
            this.btComputador.TabIndex = 0;
            this.btComputador.UseVisualStyleBackColor = false;
            this.btComputador.Click += new System.EventHandler(this.btComputador_Click);
            // 
            // gbListarTodos
            // 
            this.gbListarTodos.Controls.Add(this.btUsuarioPesquisar);
            this.gbListarTodos.Controls.Add(this.btMonitorPesquisar);
            this.gbListarTodos.Controls.Add(this.btMesaPesquisar);
            this.gbListarTodos.Controls.Add(this.btComputadorPesquisar);
            this.gbListarTodos.Location = new System.Drawing.Point(243, 27);
            this.gbListarTodos.Name = "gbListarTodos";
            this.gbListarTodos.Size = new System.Drawing.Size(225, 75);
            this.gbListarTodos.TabIndex = 134;
            this.gbListarTodos.TabStop = false;
            this.gbListarTodos.Text = "Listar todos";
            // 
            // btUsuarioPesquisar
            // 
            this.btUsuarioPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btUsuarioPesquisar.BackgroundImage = global::GUI.Properties.Resources.DarkU;
            this.btUsuarioPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUsuarioPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuarioPesquisar.Location = new System.Drawing.Point(6, 19);
            this.btUsuarioPesquisar.Name = "btUsuarioPesquisar";
            this.btUsuarioPesquisar.Size = new System.Drawing.Size(48, 50);
            this.btUsuarioPesquisar.TabIndex = 130;
            this.btUsuarioPesquisar.UseVisualStyleBackColor = false;
            this.btUsuarioPesquisar.Click += new System.EventHandler(this.btUsuarioPesquisar_Click);
            // 
            // btMonitorPesquisar
            // 
            this.btMonitorPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btMonitorPesquisar.BackgroundImage = global::GUI.Properties.Resources.DarkMon;
            this.btMonitorPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMonitorPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMonitorPesquisar.Location = new System.Drawing.Point(168, 19);
            this.btMonitorPesquisar.Name = "btMonitorPesquisar";
            this.btMonitorPesquisar.Size = new System.Drawing.Size(48, 50);
            this.btMonitorPesquisar.TabIndex = 131;
            this.btMonitorPesquisar.UseVisualStyleBackColor = false;
            this.btMonitorPesquisar.Click += new System.EventHandler(this.btMonitorPesquisar_Click);
            // 
            // btMesaPesquisar
            // 
            this.btMesaPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btMesaPesquisar.BackgroundImage = global::GUI.Properties.Resources.DarkMes;
            this.btMesaPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMesaPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMesaPesquisar.Location = new System.Drawing.Point(60, 19);
            this.btMesaPesquisar.Name = "btMesaPesquisar";
            this.btMesaPesquisar.Size = new System.Drawing.Size(48, 50);
            this.btMesaPesquisar.TabIndex = 132;
            this.btMesaPesquisar.UseVisualStyleBackColor = false;
            this.btMesaPesquisar.Click += new System.EventHandler(this.btMesaPesquisar_Click);
            // 
            // btComputadorPesquisar
            // 
            this.btComputadorPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btComputadorPesquisar.BackgroundImage = global::GUI.Properties.Resources.DarkC;
            this.btComputadorPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btComputadorPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComputadorPesquisar.Location = new System.Drawing.Point(114, 19);
            this.btComputadorPesquisar.Name = "btComputadorPesquisar";
            this.btComputadorPesquisar.Size = new System.Drawing.Size(48, 50);
            this.btComputadorPesquisar.TabIndex = 129;
            this.btComputadorPesquisar.UseVisualStyleBackColor = false;
            this.btComputadorPesquisar.Click += new System.EventHandler(this.btComputadorPesquisar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(0, 134);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(990, 569);
            this.dgvDados.TabIndex = 144;
            // 
            // cbAtualizarBuscarColuna
            // 
            this.cbAtualizarBuscarColuna.Enabled = false;
            this.cbAtualizarBuscarColuna.FormattingEnabled = true;
            this.cbAtualizarBuscarColuna.Location = new System.Drawing.Point(121, 108);
            this.cbAtualizarBuscarColuna.Name = "cbAtualizarBuscarColuna";
            this.cbAtualizarBuscarColuna.Size = new System.Drawing.Size(116, 21);
            this.cbAtualizarBuscarColuna.TabIndex = 149;
            this.cbAtualizarBuscarColuna.TextChanged += new System.EventHandler(this.cbAtualizarBuscarColuna_TextChanged);
            this.cbAtualizarBuscarColuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAtualizarBuscarColuna_KeyPress);
            // 
            // btHistorico
            // 
            this.btHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.btHistorico.BackgroundImage = global::GUI.Properties.Resources.DarkH;
            this.btHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHistorico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.Location = new System.Drawing.Point(636, 27);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(75, 75);
            this.btHistorico.TabIndex = 141;
            this.btHistorico.UseVisualStyleBackColor = false;
            this.btHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            this.btHistorico.MouseEnter += new System.EventHandler(this.btHistorico_MouseEnter);
            this.btHistorico.MouseLeave += new System.EventHandler(this.btHistorico_MouseLeave);
            // 
            // btImprimir
            // 
            this.btImprimir.AccessibleDescription = "";
            this.btImprimir.AccessibleName = "";
            this.btImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimir.BackgroundImage")));
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(555, 27);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 75);
            this.btImprimir.TabIndex = 135;
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            this.btImprimir.MouseEnter += new System.EventHandler(this.btImprimir_MouseEnter);
            this.btImprimir.MouseLeave += new System.EventHandler(this.btImprimir_MouseLeave);
            // 
            // btTabelaPrincipal
            // 
            this.btTabelaPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.btTabelaPrincipal.BackgroundImage = global::GUI.Properties.Resources.DarkTB2;
            this.btTabelaPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTabelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTabelaPrincipal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTabelaPrincipal.Location = new System.Drawing.Point(474, 27);
            this.btTabelaPrincipal.Name = "btTabelaPrincipal";
            this.btTabelaPrincipal.Size = new System.Drawing.Size(75, 75);
            this.btTabelaPrincipal.TabIndex = 143;
            this.btTabelaPrincipal.UseVisualStyleBackColor = false;
            this.btTabelaPrincipal.Click += new System.EventHandler(this.btTabelaPrincipal_Click);
            this.btTabelaPrincipal.MouseEnter += new System.EventHandler(this.btTabelaPrincipal_MouseEnter);
            this.btTabelaPrincipal.MouseLeave += new System.EventHandler(this.btTabelaPrincipal_MouseLeave);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(246, 111);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 151;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Enabled = false;
            this.rbAtivo.Location = new System.Drawing.Point(573, 109);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(57, 17);
            this.rbAtivo.TabIndex = 152;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "ATIVO";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.Visible = false;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Enabled = false;
            this.rbInativo.Location = new System.Drawing.Point(636, 109);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(68, 17);
            this.rbInativo.TabIndex = 153;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "INATIVO";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.Visible = false;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // lblMsgBanco
            // 
            this.lblMsgBanco.AutoSize = true;
            this.lblMsgBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgBanco.ForeColor = System.Drawing.Color.Green;
            this.lblMsgBanco.Location = new System.Drawing.Point(842, 8);
            this.lblMsgBanco.Name = "lblMsgBanco";
            this.lblMsgBanco.Size = new System.Drawing.Size(136, 16);
            this.lblMsgBanco.TabIndex = 154;
            this.lblMsgBanco.Text = "Status da conexão";
            // 
            // cbTerceiroCB
            // 
            this.cbTerceiroCB.FormattingEnabled = true;
            this.cbTerceiroCB.Location = new System.Drawing.Point(474, 108);
            this.cbTerceiroCB.Name = "cbTerceiroCB";
            this.cbTerceiroCB.Size = new System.Drawing.Size(237, 21);
            this.cbTerceiroCB.TabIndex = 155;
            this.cbTerceiroCB.Visible = false;
            this.cbTerceiroCB.TextChanged += new System.EventHandler(this.cbDepartamento_TextChanged);
            this.cbTerceiroCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDepartamento_KeyPress);
            // 
            // btPesquisarHistorico
            // 
            this.btPesquisarHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.btPesquisarHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPesquisarHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisarHistorico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarHistorico.Location = new System.Drawing.Point(825, 27);
            this.btPesquisarHistorico.Name = "btPesquisarHistorico";
            this.btPesquisarHistorico.Size = new System.Drawing.Size(102, 102);
            this.btPesquisarHistorico.TabIndex = 156;
            this.btPesquisarHistorico.Text = "Pesquisar no Histórico";
            this.btPesquisarHistorico.UseVisualStyleBackColor = false;
            this.btPesquisarHistorico.Click += new System.EventHandler(this.btPesquisarHistorico_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 714);
            this.Controls.Add(this.btPesquisarHistorico);
            this.Controls.Add(this.cbTerceiroCB);
            this.Controls.Add(this.lblMsgBanco);
            this.Controls.Add(this.rbInativo);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.cbAtualizarBuscarColuna);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.gbListarTodos);
            this.Controls.Add(this.btTabelaPrincipal);
            this.Controls.Add(this.gbCadastrar);
            this.Controls.Add(this.cbAtualizarBuscarTabela);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Patrimônio";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCadastrar.ResumeLayout(false);
            this.gbListarTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btComputador;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm1Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsm1Usuario;
        private System.Windows.Forms.ToolStripMenuItem tsm2Pesquisar;
        private System.Windows.Forms.ToolStripMenuItem tsm2Usuario;
        private System.Windows.Forms.ToolStripMenuItem tsm4;
        private System.Windows.Forms.ToolStripMenuItem tsm4Historico;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Button btMonitor;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btMesa;
        private System.Windows.Forms.ToolStripMenuItem tsm1Mesa;
        private System.Windows.Forms.ToolStripMenuItem tsm1Computador;
        private System.Windows.Forms.ToolStripMenuItem tsm2Mesa;
        private System.Windows.Forms.ToolStripMenuItem tsm2Computador;
        private System.Windows.Forms.ToolStripMenuItem tsm2Monitor;
        private System.Windows.Forms.ToolStripMenuItem tsm1Monitor;
        private System.Windows.Forms.ToolStripMenuItem tsm3AtribuirTrocar;
        private System.Windows.Forms.ToolStripMenuItem tsm3MesaUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsm3MesaComputador;
        private System.Windows.Forms.ToolStripMenuItem tsm3MesaMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsm5;
        private System.Windows.Forms.ComboBox cbAtualizarBuscarTabela;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
        private System.Windows.Forms.Button btMesaPesquisar;
        private System.Windows.Forms.Button btComputadorPesquisar;
        private System.Windows.Forms.Button btUsuarioPesquisar;
        private System.Windows.Forms.Button btMonitorPesquisar;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.GroupBox gbListarTodos;
        private System.Windows.Forms.ToolStripMenuItem tsm4Imprimir;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.ToolStripMenuItem tsm4ConfigurarBanco;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button btTabelaPrincipal;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStripMenuItem tsm4Icones;
        private System.Windows.Forms.ToolStripMenuItem skinDark;
        private System.Windows.Forms.ToolStripMenuItem skinGusta;
        private System.Windows.Forms.ToolStripMenuItem skinBombom;
        private System.Windows.Forms.ToolStripMenuItem tsm3LimparMesa;
        private System.Windows.Forms.ComboBox cbAtualizarBuscarColuna;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.ToolStripMenuItem Manual;
        private System.Windows.Forms.ToolStripMenuItem tsm4SelecionarImpressora;
        public System.Windows.Forms.Label lblMsgBanco;
        private System.Windows.Forms.ToolStripMenuItem tsm4BancoDados;
        private System.Windows.Forms.ToolStripMenuItem tsm4BancoCriar;
        private System.Windows.Forms.ToolStripMenuItem tsm4BancoBackup;
        private System.Windows.Forms.ToolStripMenuItem tsm1Info;
        private System.Windows.Forms.ComboBox cbTerceiroCB;
        private System.Windows.Forms.ToolStripMenuItem históricoPesquisaAvançadaToolStripMenuItem;
        private System.Windows.Forms.Button btPesquisarHistorico;
    }
}
namespace GUI
{
    partial class frmCadastroComputador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroComputador));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumeroPatrimonio = new System.Windows.Forms.TextBox();
            this.lblNumeroPatrimonio = new System.Windows.Forms.Label();
            this.lblPatriProv = new System.Windows.Forms.Label();
            this.txtPatrimonioProv = new System.Windows.Forms.TextBox();
            this.lblNumMaquina = new System.Windows.Forms.Label();
            this.txtNomeMaquina = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModeloPC = new System.Windows.Forms.Label();
            this.txtModeloPC = new System.Windows.Forms.TextBox();
            this.lblNserie = new System.Windows.Forms.Label();
            this.txtNserie = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btQuebrado = new System.Windows.Forms.Button();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtUltimaAlteracao = new System.Windows.Forms.TextBox();
            this.lblUltimaAlt = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblInfoIP = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btfrmCadastroInformacoes = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.Controls.Add(this.btfrmCadastroInformacoes);
            this.pnDados.Controls.Add(this.cbMarca);
            this.pnDados.Controls.Add(this.lblTipo);
            this.pnDados.Controls.Add(this.cbTipo);
            this.pnDados.Controls.Add(this.lblInfoIP);
            this.pnDados.Controls.Add(this.txtUltimaAlteracao);
            this.pnDados.Controls.Add(this.lblUltimaAlt);
            this.pnDados.Controls.Add(this.txtDataCadastro);
            this.pnDados.Controls.Add(this.lblDataCadastro);
            this.pnDados.Controls.Add(this.cbEstado);
            this.pnDados.Controls.Add(this.lblEstado);
            this.pnDados.Controls.Add(this.lblSigla);
            this.pnDados.Controls.Add(this.lblIP);
            this.pnDados.Controls.Add(this.txtIP);
            this.pnDados.Controls.Add(this.txtSigla);
            this.pnDados.Controls.Add(this.txtNumeroPatrimonio);
            this.pnDados.Controls.Add(this.lblNumeroPatrimonio);
            this.pnDados.Controls.Add(this.lblPatriProv);
            this.pnDados.Controls.Add(this.txtPatrimonioProv);
            this.pnDados.Controls.Add(this.lblNumMaquina);
            this.pnDados.Controls.Add(this.txtNomeMaquina);
            this.pnDados.Controls.Add(this.lblMarca);
            this.pnDados.Controls.Add(this.lblModeloPC);
            this.pnDados.Controls.Add(this.txtModeloPC);
            this.pnDados.Controls.Add(this.lblNserie);
            this.pnDados.Controls.Add(this.txtNserie);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Size = new System.Drawing.Size(624, 250);
            // 
            // btCancelar
            // 
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(74, 12);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(120, 9);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "Automático";
            // 
            // txtNumeroPatrimonio
            // 
            this.txtNumeroPatrimonio.Location = new System.Drawing.Point(120, 34);
            this.txtNumeroPatrimonio.MaxLength = 64;
            this.txtNumeroPatrimonio.Name = "txtNumeroPatrimonio";
            this.txtNumeroPatrimonio.Size = new System.Drawing.Size(501, 20);
            this.txtNumeroPatrimonio.TabIndex = 0;
            this.txtNumeroPatrimonio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPatrimonio_KeyPress);
            // 
            // lblNumeroPatrimonio
            // 
            this.lblNumeroPatrimonio.AutoSize = true;
            this.lblNumeroPatrimonio.Location = new System.Drawing.Point(3, 37);
            this.lblNumeroPatrimonio.Name = "lblNumeroPatrimonio";
            this.lblNumeroPatrimonio.Size = new System.Drawing.Size(111, 13);
            this.lblNumeroPatrimonio.TabIndex = 37;
            this.lblNumeroPatrimonio.Text = "Número do Patrimônio";
            // 
            // lblPatriProv
            // 
            this.lblPatriProv.AutoSize = true;
            this.lblPatriProv.Location = new System.Drawing.Point(9, 63);
            this.lblPatriProv.Name = "lblPatriProv";
            this.lblPatriProv.Size = new System.Drawing.Size(105, 13);
            this.lblPatriProv.TabIndex = 39;
            this.lblPatriProv.Text = "Patrimônio Provisório";
            // 
            // txtPatrimonioProv
            // 
            this.txtPatrimonioProv.Location = new System.Drawing.Point(120, 60);
            this.txtPatrimonioProv.MaxLength = 64;
            this.txtPatrimonioProv.Name = "txtPatrimonioProv";
            this.txtPatrimonioProv.Size = new System.Drawing.Size(398, 20);
            this.txtPatrimonioProv.TabIndex = 1;
            this.txtPatrimonioProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatrimonioProv_KeyPress);
            // 
            // lblNumMaquina
            // 
            this.lblNumMaquina.AutoSize = true;
            this.lblNumMaquina.Location = new System.Drawing.Point(17, 89);
            this.lblNumMaquina.Name = "lblNumMaquina";
            this.lblNumMaquina.Size = new System.Drawing.Size(97, 13);
            this.lblNumMaquina.TabIndex = 41;
            this.lblNumMaquina.Text = "Nome Máq. (Rede)";
            // 
            // txtNomeMaquina
            // 
            this.txtNomeMaquina.Location = new System.Drawing.Point(120, 86);
            this.txtNomeMaquina.MaxLength = 64;
            this.txtNomeMaquina.Name = "txtNomeMaquina";
            this.txtNomeMaquina.Size = new System.Drawing.Size(181, 20);
            this.txtNomeMaquina.TabIndex = 3;
            this.txtNomeMaquina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeMaquina_KeyPress);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(77, 116);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca";
            // 
            // lblModeloPC
            // 
            this.lblModeloPC.AutoSize = true;
            this.lblModeloPC.Location = new System.Drawing.Point(72, 141);
            this.lblModeloPC.Name = "lblModeloPC";
            this.lblModeloPC.Size = new System.Drawing.Size(42, 13);
            this.lblModeloPC.TabIndex = 45;
            this.lblModeloPC.Text = "Modelo";
            // 
            // txtModeloPC
            // 
            this.txtModeloPC.Location = new System.Drawing.Point(120, 138);
            this.txtModeloPC.MaxLength = 64;
            this.txtModeloPC.Name = "txtModeloPC";
            this.txtModeloPC.Size = new System.Drawing.Size(181, 20);
            this.txtModeloPC.TabIndex = 6;
            this.txtModeloPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModeloPC_KeyPress);
            // 
            // lblNserie
            // 
            this.lblNserie.AutoSize = true;
            this.lblNserie.Location = new System.Drawing.Point(307, 141);
            this.lblNserie.Name = "lblNserie";
            this.lblNserie.Size = new System.Drawing.Size(61, 13);
            this.lblNserie.TabIndex = 51;
            this.lblNserie.Text = "N° de Série";
            // 
            // txtNserie
            // 
            this.txtNserie.Location = new System.Drawing.Point(374, 138);
            this.txtNserie.MaxLength = 64;
            this.txtNserie.Name = "txtNserie";
            this.txtNserie.Size = new System.Drawing.Size(247, 20);
            this.txtNserie.TabIndex = 7;
            this.txtNserie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNserie_KeyPress);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(561, 60);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(60, 20);
            this.txtSigla.TabIndex = 2;
            this.txtSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigla_KeyPress);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(307, 89);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(52, 13);
            this.lblIP.TabIndex = 70;
            this.lblIP.Text = "IP (Rede)";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(365, 86);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(525, 63);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 74;
            this.lblSigla.Text = "Sigla";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(318, 263);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(148, 13);
            this.lblTabela.TabIndex = 76;
            this.lblTabela.Text = "Tabela de Computadores";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbEstado.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbEstado.Location = new System.Drawing.Point(120, 216);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(73, 21);
            this.cbEstado.TabIndex = 10;
            this.cbEstado.Text = "ATIVO";
            this.cbEstado.TextChanged += new System.EventHandler(this.cbEstado_TextChanged);
            this.cbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEstado_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(74, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 128;
            this.lblEstado.Text = "Estado";
            // 
            // btQuebrado
            // 
            this.btQuebrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuebrado.Location = new System.Drawing.Point(30, 178);
            this.btQuebrado.Name = "btQuebrado";
            this.btQuebrado.Size = new System.Drawing.Size(138, 80);
            this.btQuebrado.TabIndex = 0;
            this.btQuebrado.Text = "Voltar";
            this.btQuebrado.UseVisualStyleBackColor = true;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(421, 190);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(200, 20);
            this.txtDataCadastro.TabIndex = 133;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(325, 193);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.lblDataCadastro.TabIndex = 132;
            this.lblDataCadastro.Text = "Data de Cadastro";
            // 
            // txtUltimaAlteracao
            // 
            this.txtUltimaAlteracao.Enabled = false;
            this.txtUltimaAlteracao.Location = new System.Drawing.Point(421, 216);
            this.txtUltimaAlteracao.Name = "txtUltimaAlteracao";
            this.txtUltimaAlteracao.Size = new System.Drawing.Size(200, 20);
            this.txtUltimaAlteracao.TabIndex = 135;
            // 
            // lblUltimaAlt
            // 
            this.lblUltimaAlt.AutoSize = true;
            this.lblUltimaAlt.Location = new System.Drawing.Point(325, 219);
            this.lblUltimaAlt.Name = "lblUltimaAlt";
            this.lblUltimaAlt.Size = new System.Drawing.Size(84, 13);
            this.lblUltimaAlt.TabIndex = 134;
            this.lblUltimaAlt.Text = "Última Alteração";
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
            this.dgvDados.Location = new System.Drawing.Point(11, 278);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(772, 279);
            this.dgvDados.TabIndex = 77;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // lblInfoIP
            // 
            this.lblInfoIP.AutoSize = true;
            this.lblInfoIP.Location = new System.Drawing.Point(524, 89);
            this.lblInfoIP.Name = "lblInfoIP";
            this.lblInfoIP.Size = new System.Drawing.Size(86, 13);
            this.lblInfoIP.TabIndex = 136;
            this.lblInfoIP.Text = "* Quarto Octetos";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Desktop",
            "Notebook",
            "All in One"});
            this.cbTipo.Location = new System.Drawing.Point(120, 190);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(73, 21);
            this.cbTipo.TabIndex = 9;
            this.cbTipo.Text = "Desktop";
            this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(86, 193);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 138;
            this.lblTipo.Text = "Tipo";
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(12, 174);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(142, 99);
            this.btVoltar.TabIndex = 78;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(121, 113);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(180, 21);
            this.cbMarca.TabIndex = 139;
            this.cbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMarca_KeyPress);
            // 
            // btfrmCadastroInformacoes
            // 
            this.btfrmCadastroInformacoes.Location = new System.Drawing.Point(307, 112);
            this.btfrmCadastroInformacoes.Name = "btfrmCadastroInformacoes";
            this.btfrmCadastroInformacoes.Size = new System.Drawing.Size(134, 21);
            this.btfrmCadastroInformacoes.TabIndex = 144;
            this.btfrmCadastroInformacoes.Text = "Cadastrar Marca";
            this.btfrmCadastroInformacoes.UseVisualStyleBackColor = true;
            this.btfrmCadastroInformacoes.Click += new System.EventHandler(this.btfrmCadastroInformacoes_Click);
            // 
            // frmCadastroComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblTabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroComputador";
            this.Text = "Cadastro/Alterar Computador";
            this.Load += new System.EventHandler(this.frmCadastroComputador_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroComputador_KeyDown);
            this.Controls.SetChildIndex(this.btLocalizar, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btInserir, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.btSalvar, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.lblTabela, 0);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            this.Controls.SetChildIndex(this.btVoltar, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumeroPatrimonio;
        private System.Windows.Forms.Label lblNumeroPatrimonio;
        private System.Windows.Forms.Label lblPatriProv;
        private System.Windows.Forms.TextBox txtPatrimonioProv;
        private System.Windows.Forms.Label lblNumMaquina;
        private System.Windows.Forms.TextBox txtNomeMaquina;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModeloPC;
        private System.Windows.Forms.TextBox txtModeloPC;
        private System.Windows.Forms.Label lblNserie;
        private System.Windows.Forms.TextBox txtNserie;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btQuebrado;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtUltimaAlteracao;
        private System.Windows.Forms.Label lblUltimaAlt;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblInfoIP;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btfrmCadastroInformacoes;
    }
}

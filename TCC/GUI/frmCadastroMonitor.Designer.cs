namespace GUI
{
    partial class frmCadastroMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMonitor));
            this.txtNumeroPatrimonio = new System.Windows.Forms.TextBox();
            this.lblNumeroPatrimonio = new System.Windows.Forms.Label();
            this.lblPatrimonioProv = new System.Windows.Forms.Label();
            this.txtPatrimonioProv = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNserie = new System.Windows.Forms.Label();
            this.txtNserie = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTabelaMonitores = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtUltimaAlteracao = new System.Windows.Forms.TextBox();
            this.lblUltimaAlt = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btfrmCadastroInformacoes = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbMarca);
            this.pnDados.Controls.Add(this.btfrmCadastroInformacoes);
            this.pnDados.Controls.Add(this.lblModelo);
            this.pnDados.Controls.Add(this.txtModelo);
            this.pnDados.Controls.Add(this.txtUltimaAlteracao);
            this.pnDados.Controls.Add(this.lblUltimaAlt);
            this.pnDados.Controls.Add(this.txtDataCadastro);
            this.pnDados.Controls.Add(this.lblDataCadastro);
            this.pnDados.Controls.Add(this.cbEstado);
            this.pnDados.Controls.Add(this.lblEstado);
            this.pnDados.Controls.Add(this.cbTipo);
            this.pnDados.Controls.Add(this.lblTipo);
            this.pnDados.Controls.Add(this.lblSigla);
            this.pnDados.Controls.Add(this.txtSigla);
            this.pnDados.Controls.Add(this.txtNumeroPatrimonio);
            this.pnDados.Controls.Add(this.lblNumeroPatrimonio);
            this.pnDados.Controls.Add(this.lblPatrimonioProv);
            this.pnDados.Controls.Add(this.txtPatrimonioProv);
            this.pnDados.Controls.Add(this.lblMarca);
            this.pnDados.Controls.Add(this.lblNserie);
            this.pnDados.Controls.Add(this.txtNserie);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Size = new System.Drawing.Size(624, 250);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
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
            // txtNumeroPatrimonio
            // 
            this.txtNumeroPatrimonio.Location = new System.Drawing.Point(120, 34);
            this.txtNumeroPatrimonio.MaxLength = 64;
            this.txtNumeroPatrimonio.Name = "txtNumeroPatrimonio";
            this.txtNumeroPatrimonio.Size = new System.Drawing.Size(501, 20);
            this.txtNumeroPatrimonio.TabIndex = 2;
            this.txtNumeroPatrimonio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPatrimonio_KeyPress);
            // 
            // lblNumeroPatrimonio
            // 
            this.lblNumeroPatrimonio.AutoSize = true;
            this.lblNumeroPatrimonio.Location = new System.Drawing.Point(3, 37);
            this.lblNumeroPatrimonio.Name = "lblNumeroPatrimonio";
            this.lblNumeroPatrimonio.Size = new System.Drawing.Size(111, 13);
            this.lblNumeroPatrimonio.TabIndex = 76;
            this.lblNumeroPatrimonio.Text = "Número do Patrimônio";
            // 
            // lblPatrimonioProv
            // 
            this.lblPatrimonioProv.AutoSize = true;
            this.lblPatrimonioProv.Location = new System.Drawing.Point(9, 63);
            this.lblPatrimonioProv.Name = "lblPatrimonioProv";
            this.lblPatrimonioProv.Size = new System.Drawing.Size(105, 13);
            this.lblPatrimonioProv.TabIndex = 78;
            this.lblPatrimonioProv.Text = "Patrimônio Provisório";
            // 
            // txtPatrimonioProv
            // 
            this.txtPatrimonioProv.Location = new System.Drawing.Point(120, 60);
            this.txtPatrimonioProv.MaxLength = 64;
            this.txtPatrimonioProv.Name = "txtPatrimonioProv";
            this.txtPatrimonioProv.Size = new System.Drawing.Size(399, 20);
            this.txtPatrimonioProv.TabIndex = 3;
            this.txtPatrimonioProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatrimonioProv_KeyPress);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(77, 89);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 82;
            this.lblMarca.Text = "Marca";
            // 
            // lblNserie
            // 
            this.lblNserie.AutoSize = true;
            this.lblNserie.Location = new System.Drawing.Point(301, 115);
            this.lblNserie.Name = "lblNserie";
            this.lblNserie.Size = new System.Drawing.Size(61, 13);
            this.lblNserie.TabIndex = 86;
            this.lblNserie.Text = "N° de Série";
            // 
            // txtNserie
            // 
            this.txtNserie.Location = new System.Drawing.Point(368, 112);
            this.txtNserie.MaxLength = 64;
            this.txtNserie.Name = "txtNserie";
            this.txtNserie.Size = new System.Drawing.Size(253, 20);
            this.txtNserie.TabIndex = 6;
            this.txtNserie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNserie_KeyPress);
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(74, 12);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 74;
            this.lblCodigo.Text = "Código";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(525, 63);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 93;
            this.lblSigla.Text = "Sigla";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(561, 60);
            this.txtSigla.MaxLength = 8;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(60, 20);
            this.txtSigla.TabIndex = 4;
            this.txtSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigla_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(86, 193);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 94;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTabelaMonitores
            // 
            this.lblTabelaMonitores.AutoSize = true;
            this.lblTabelaMonitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaMonitores.Location = new System.Drawing.Point(331, 263);
            this.lblTabelaMonitores.Name = "lblTabelaMonitores";
            this.lblTabelaMonitores.Size = new System.Drawing.Size(123, 13);
            this.lblTabelaMonitores.TabIndex = 101;
            this.lblTabelaMonitores.Text = "Tabela de Monitores";
            // 
            // cbTipo
            // 
            this.cbTipo.Items.AddRange(new object[] {
            "LED",
            "LCD",
            "TUBO",
            "PROJETOR"});
            this.cbTipo.Location = new System.Drawing.Point(120, 190);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(73, 21);
            this.cbTipo.TabIndex = 95;
            this.cbTipo.Text = "LED";
            this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo_KeyPress);
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
            this.cbEstado.TabIndex = 129;
            this.cbEstado.Text = "ATIVO";
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
            this.txtUltimaAlteracao.TabIndex = 137;
            // 
            // lblUltimaAlt
            // 
            this.lblUltimaAlt.AutoSize = true;
            this.lblUltimaAlt.Location = new System.Drawing.Point(325, 219);
            this.lblUltimaAlt.Name = "lblUltimaAlt";
            this.lblUltimaAlt.Size = new System.Drawing.Size(84, 13);
            this.lblUltimaAlt.TabIndex = 136;
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
            this.dgvDados.TabIndex = 102;
            this.dgvDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(72, 115);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 139;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(120, 112);
            this.txtModelo.MaxLength = 64;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(175, 20);
            this.txtModelo.TabIndex = 138;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(11, 174);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(142, 99);
            this.btVoltar.TabIndex = 103;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btfrmCadastroInformacoes
            // 
            this.btfrmCadastroInformacoes.Location = new System.Drawing.Point(301, 86);
            this.btfrmCadastroInformacoes.Name = "btfrmCadastroInformacoes";
            this.btfrmCadastroInformacoes.Size = new System.Drawing.Size(134, 21);
            this.btfrmCadastroInformacoes.TabIndex = 143;
            this.btfrmCadastroInformacoes.Text = "Cadastrar Marca";
            this.btfrmCadastroInformacoes.UseVisualStyleBackColor = true;
            this.btfrmCadastroInformacoes.Click += new System.EventHandler(this.btfrmCadastroInformacoes_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(120, 86);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(175, 21);
            this.cbMarca.TabIndex = 144;
            this.cbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMarca_KeyPress);
            // 
            // frmCadastroMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblTabelaMonitores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroMonitor";
            this.Text = "Cadastro/Alterar Monitores";
            this.Load += new System.EventHandler(this.frmCadastroMonitor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroMonitor_KeyDown);
            this.Controls.SetChildIndex(this.btLocalizar, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btInserir, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.btSalvar, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.lblTabelaMonitores, 0);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            this.Controls.SetChildIndex(this.btVoltar, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroPatrimonio;
        private System.Windows.Forms.Label lblNumeroPatrimonio;
        private System.Windows.Forms.Label lblPatrimonioProv;
        private System.Windows.Forms.TextBox txtPatrimonioProv;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNserie;
        private System.Windows.Forms.TextBox txtNserie;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblTabelaMonitores;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtUltimaAlteracao;
        private System.Windows.Forms.Label lblUltimaAlt;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btfrmCadastroInformacoes;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}

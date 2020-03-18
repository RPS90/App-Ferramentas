namespace GUI
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblRamal = new System.Windows.Forms.Label();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btCarregarFoto = new System.Windows.Forms.Button();
            this.btRemoverFoto = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btQuebrado = new System.Windows.Forms.Button();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtUltimaAlteracao = new System.Windows.Forms.TextBox();
            this.lblUltimaAlt = new System.Windows.Forms.Label();
            this.lblFotoMsg = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btVoltar = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btfrmCadastroInformacoes = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btfrmCadastroInformacoes);
            this.pnDados.Controls.Add(this.cbDepartamento);
            this.pnDados.Controls.Add(this.txtUltimaAlteracao);
            this.pnDados.Controls.Add(this.lblFotoMsg);
            this.pnDados.Controls.Add(this.lblUltimaAlt);
            this.pnDados.Controls.Add(this.txtDataCadastro);
            this.pnDados.Controls.Add(this.lblDataCadastro);
            this.pnDados.Controls.Add(this.cbEstado);
            this.pnDados.Controls.Add(this.lblEstado);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.lblEmail);
            this.pnDados.Controls.Add(this.btRemoverFoto);
            this.pnDados.Controls.Add(this.btCarregarFoto);
            this.pnDados.Controls.Add(this.pbFoto);
            this.pnDados.Controls.Add(this.lblDepartamento);
            this.pnDados.Controls.Add(this.txtNomeUsuario);
            this.pnDados.Controls.Add(this.lblNome);
            this.pnDados.Controls.Add(this.lblLogin);
            this.pnDados.Controls.Add(this.txtLogin);
            this.pnDados.Controls.Add(this.lblRamal);
            this.pnDados.Controls.Add(this.txtRamal);
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
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(40, 115);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 111;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(120, 34);
            this.txtNomeUsuario.MaxLength = 128;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(317, 20);
            this.txtNomeUsuario.TabIndex = 2;
            this.txtNomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeUsuario_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 102;
            this.lblNome.Text = "Nome do Usuário";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(58, 63);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 13);
            this.lblLogin.TabIndex = 104;
            this.lblLogin.Text = "Login (RF)";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(120, 60);
            this.txtLogin.MaxLength = 64;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(317, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(77, 89);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(37, 13);
            this.lblRamal.TabIndex = 106;
            this.lblRamal.Text = "Ramal";
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(120, 86);
            this.txtRamal.MaxLength = 64;
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(317, 20);
            this.txtRamal.TabIndex = 4;
            this.txtRamal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRamal_KeyPress);
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
            this.lblCodigo.TabIndex = 100;
            this.lblCodigo.Text = "Código";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Azure;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Location = new System.Drawing.Point(443, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(168, 175);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 119;
            this.pbFoto.TabStop = false;
            // 
            // btCarregarFoto
            // 
            this.btCarregarFoto.Location = new System.Drawing.Point(443, 185);
            this.btCarregarFoto.Name = "btCarregarFoto";
            this.btCarregarFoto.Size = new System.Drawing.Size(81, 35);
            this.btCarregarFoto.TabIndex = 120;
            this.btCarregarFoto.Text = "Carregar foto";
            this.btCarregarFoto.UseVisualStyleBackColor = true;
            this.btCarregarFoto.Click += new System.EventHandler(this.btCarregarFoto_Click);
            // 
            // btRemoverFoto
            // 
            this.btRemoverFoto.Location = new System.Drawing.Point(530, 185);
            this.btRemoverFoto.Name = "btRemoverFoto";
            this.btRemoverFoto.Size = new System.Drawing.Size(81, 35);
            this.btRemoverFoto.TabIndex = 121;
            this.btRemoverFoto.Text = "Remover foto";
            this.btRemoverFoto.UseVisualStyleBackColor = true;
            this.btRemoverFoto.Click += new System.EventHandler(this.btRemoverFoto_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 138);
            this.txtEmail.MaxLength = 64;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 125;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(331, 263);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(123, 13);
            this.lblTabela.TabIndex = 119;
            this.lblTabela.Text = "Tabela de Monitores";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(74, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 126;
            this.lblEstado.Text = "Estado";
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
            this.cbEstado.TabIndex = 127;
            this.cbEstado.Text = "ATIVO";
            this.cbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEstado_KeyPress);
            // 
            // btQuebrado
            // 
            this.btQuebrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuebrado.Location = new System.Drawing.Point(3, 4);
            this.btQuebrado.Name = "btQuebrado";
            this.btQuebrado.Size = new System.Drawing.Size(138, 80);
            this.btQuebrado.TabIndex = 1;
            this.btQuebrado.Text = "Voltar";
            this.btQuebrado.UseVisualStyleBackColor = true;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(289, 190);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(148, 20);
            this.txtDataCadastro.TabIndex = 133;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(199, 193);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.lblDataCadastro.TabIndex = 132;
            this.lblDataCadastro.Text = "Data de Cadastro";
            // 
            // txtUltimaAlteracao
            // 
            this.txtUltimaAlteracao.Enabled = false;
            this.txtUltimaAlteracao.Location = new System.Drawing.Point(289, 216);
            this.txtUltimaAlteracao.Name = "txtUltimaAlteracao";
            this.txtUltimaAlteracao.Size = new System.Drawing.Size(148, 20);
            this.txtUltimaAlteracao.TabIndex = 137;
            // 
            // lblUltimaAlt
            // 
            this.lblUltimaAlt.AutoSize = true;
            this.lblUltimaAlt.Location = new System.Drawing.Point(199, 219);
            this.lblUltimaAlt.Name = "lblUltimaAlt";
            this.lblUltimaAlt.Size = new System.Drawing.Size(84, 13);
            this.lblUltimaAlt.TabIndex = 136;
            this.lblUltimaAlt.Text = "Última Alteração";
            // 
            // lblFotoMsg
            // 
            this.lblFotoMsg.AutoSize = true;
            this.lblFotoMsg.Location = new System.Drawing.Point(497, 223);
            this.lblFotoMsg.Name = "lblFotoMsg";
            this.lblFotoMsg.Size = new System.Drawing.Size(114, 13);
            this.lblFotoMsg.TabIndex = 138;
            this.lblFotoMsg.Text = "*Foto não é obrigatória";
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
            this.dgvDados.TabIndex = 139;
            this.dgvDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(11, 174);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(142, 99);
            this.btVoltar.TabIndex = 140;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(120, 112);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(176, 21);
            this.cbDepartamento.TabIndex = 140;
            this.cbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDepartamento_KeyPress);
            // 
            // btfrmCadastroInformacoes
            // 
            this.btfrmCadastroInformacoes.Location = new System.Drawing.Point(303, 112);
            this.btfrmCadastroInformacoes.Name = "btfrmCadastroInformacoes";
            this.btfrmCadastroInformacoes.Size = new System.Drawing.Size(134, 21);
            this.btfrmCadastroInformacoes.TabIndex = 141;
            this.btfrmCadastroInformacoes.Text = "Cadastrar Departamento";
            this.btfrmCadastroInformacoes.UseVisualStyleBackColor = true;
            this.btfrmCadastroInformacoes.Click += new System.EventHandler(this.btfrmCadastroInformacoes_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblTabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro/Alterar de Usuários";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroUsuario_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btRemoverFoto;
        private System.Windows.Forms.Button btCarregarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btQuebrado;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtUltimaAlteracao;
        private System.Windows.Forms.Label lblUltimaAlt;
        private System.Windows.Forms.Label lblFotoMsg;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Button btfrmCadastroInformacoes;
    }
}

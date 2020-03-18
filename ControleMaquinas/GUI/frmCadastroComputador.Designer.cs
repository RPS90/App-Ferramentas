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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumeroPatrimonio = new System.Windows.Forms.TextBox();
            this.lblNumeroPatrimonio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatrimonioProv = new System.Windows.Forms.TextBox();
            this.lblNumMaquina = new System.Windows.Forms.Label();
            this.txtNomeMaquina = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModeloPC = new System.Windows.Forms.Label();
            this.txtModeloPC = new System.Windows.Forms.TextBox();
            this.lblNserie = new System.Windows.Forms.Label();
            this.txtNserie = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtUltimaAlteracao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.Controls.Add(this.txtUltimaAlteracao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtDataCadastro);
            this.pnDados.Controls.Add(this.lblDataCadastro);
            this.pnDados.Controls.Add(this.cbEstado);
            this.pnDados.Controls.Add(this.lblEstado);
            this.pnDados.Controls.Add(this.lblSigla);
            this.pnDados.Controls.Add(this.txtDepartamento);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.lblIP);
            this.pnDados.Controls.Add(this.txtIP);
            this.pnDados.Controls.Add(this.txtSigla);
            this.pnDados.Controls.Add(this.txtNumeroPatrimonio);
            this.pnDados.Controls.Add(this.lblNumeroPatrimonio);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtPatrimonioProv);
            this.pnDados.Controls.Add(this.lblNumMaquina);
            this.pnDados.Controls.Add(this.txtNomeMaquina);
            this.pnDados.Controls.Add(this.lblMarca);
            this.pnDados.Controls.Add(this.txtMarca);
            this.pnDados.Controls.Add(this.lblModeloPC);
            this.pnDados.Controls.Add(this.txtModeloPC);
            this.pnDados.Controls.Add(this.lblNserie);
            this.pnDados.Controls.Add(this.txtNserie);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label1);
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
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btVoltar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
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
            this.txtNumeroPatrimonio.Name = "txtNumeroPatrimonio";
            this.txtNumeroPatrimonio.Size = new System.Drawing.Size(490, 20);
            this.txtNumeroPatrimonio.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Patrimônio Provisório";
            // 
            // txtPatrimonioProv
            // 
            this.txtPatrimonioProv.Location = new System.Drawing.Point(120, 60);
            this.txtPatrimonioProv.Name = "txtPatrimonioProv";
            this.txtPatrimonioProv.Size = new System.Drawing.Size(236, 20);
            this.txtPatrimonioProv.TabIndex = 3;
            this.txtPatrimonioProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatrimonioProv_KeyPress);
            // 
            // lblNumMaquina
            // 
            this.lblNumMaquina.AutoSize = true;
            this.lblNumMaquina.Location = new System.Drawing.Point(20, 141);
            this.lblNumMaquina.Name = "lblNumMaquina";
            this.lblNumMaquina.Size = new System.Drawing.Size(97, 13);
            this.lblNumMaquina.TabIndex = 41;
            this.lblNumMaquina.Text = "Nome Máq. (Rede)";
            // 
            // txtNomeMaquina
            // 
            this.txtNomeMaquina.Location = new System.Drawing.Point(120, 138);
            this.txtNomeMaquina.Name = "txtNomeMaquina";
            this.txtNomeMaquina.Size = new System.Drawing.Size(490, 20);
            this.txtNomeMaquina.TabIndex = 8;
            this.txtNomeMaquina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeMaquina_KeyPress);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(362, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 43;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(405, 112);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(206, 20);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // lblModeloPC
            // 
            this.lblModeloPC.AutoSize = true;
            this.lblModeloPC.Location = new System.Drawing.Point(40, 115);
            this.lblModeloPC.Name = "lblModeloPC";
            this.lblModeloPC.Size = new System.Drawing.Size(74, 13);
            this.lblModeloPC.TabIndex = 45;
            this.lblModeloPC.Text = "Modelo do PC";
            // 
            // txtModeloPC
            // 
            this.txtModeloPC.Location = new System.Drawing.Point(120, 112);
            this.txtModeloPC.Name = "txtModeloPC";
            this.txtModeloPC.Size = new System.Drawing.Size(236, 20);
            this.txtModeloPC.TabIndex = 7;
            this.txtModeloPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModeloPC_KeyPress);
            // 
            // lblNserie
            // 
            this.lblNserie.AutoSize = true;
            this.lblNserie.Location = new System.Drawing.Point(53, 167);
            this.lblNserie.Name = "lblNserie";
            this.lblNserie.Size = new System.Drawing.Size(61, 13);
            this.lblNserie.TabIndex = 51;
            this.lblNserie.Text = "N° de Série";
            // 
            // txtNserie
            // 
            this.txtNserie.Location = new System.Drawing.Point(120, 164);
            this.txtNserie.Name = "txtNserie";
            this.txtNserie.Size = new System.Drawing.Size(490, 20);
            this.txtNserie.TabIndex = 9;
            this.txtNserie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNserie_KeyPress);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(398, 60);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(213, 20);
            this.txtSigla.TabIndex = 4;
            this.txtSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigla_KeyPress);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(62, 89);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(52, 13);
            this.lblIP.TabIndex = 70;
            this.lblIP.Text = "IP (Rede)";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(120, 86);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(490, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(120, 190);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(176, 20);
            this.txtDepartamento.TabIndex = 10;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Departamento";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(362, 63);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 74;
            this.lblSigla.Text = "Sigla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(318, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Tabela de Computadores";
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
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 129;
            this.cbEstado.Text = "ATIVO";
            this.cbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEstado_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(77, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 128;
            this.lblEstado.Text = "Estado";
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = global::GUI.Properties.Resources.Voltar1_fw;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVoltar.Location = new System.Drawing.Point(3, 5);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(138, 80);
            this.btVoltar.TabIndex = 0;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(398, 190);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(212, 20);
            this.txtDataCadastro.TabIndex = 133;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(302, 193);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.lblDataCadastro.TabIndex = 132;
            this.lblDataCadastro.Text = "Data de Cadastro";
            // 
            // txtUltimaAlteracao
            // 
            this.txtUltimaAlteracao.Enabled = false;
            this.txtUltimaAlteracao.Location = new System.Drawing.Point(398, 216);
            this.txtUltimaAlteracao.Name = "txtUltimaAlteracao";
            this.txtUltimaAlteracao.Size = new System.Drawing.Size(212, 20);
            this.txtUltimaAlteracao.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Ultima Alteração";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(11, 278);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(762, 273);
            this.dgvDados.TabIndex = 77;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // frmCadastroComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroComputador";
            this.Text = "Cadastro de Computador";
            this.Load += new System.EventHandler(this.frmCadastroComputador_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroComputador_KeyDown);
            this.Controls.SetChildIndex(this.btLocalizar, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btInserir, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.btSalvar, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPatrimonio;
        private System.Windows.Forms.Label lblNumeroPatrimonio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatrimonioProv;
        private System.Windows.Forms.Label lblNumMaquina;
        private System.Windows.Forms.TextBox txtNomeMaquina;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModeloPC;
        private System.Windows.Forms.TextBox txtModeloPC;
        private System.Windows.Forms.Label lblNserie;
        private System.Windows.Forms.TextBox txtNserie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtUltimaAlteracao;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvDados;
    }
}

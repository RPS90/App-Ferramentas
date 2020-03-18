namespace GUI
{
    partial class frmCadastroInformacoes
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
            this.btValorCadastrar = new System.Windows.Forms.Button();
            this.lblTabelaJC = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbCadastrando = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btDepartamento = new System.Windows.Forms.Button();
            this.btMarca = new System.Windows.Forms.Button();
            this.btSobra1 = new System.Windows.Forms.Button();
            this.btSobra2 = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbCadastrando.SuspendLayout();
            this.SuspendLayout();
            // 
            // btValorCadastrar
            // 
            this.btValorCadastrar.Location = new System.Drawing.Point(6, 45);
            this.btValorCadastrar.Name = "btValorCadastrar";
            this.btValorCadastrar.Size = new System.Drawing.Size(83, 22);
            this.btValorCadastrar.TabIndex = 0;
            this.btValorCadastrar.Text = "Cadastrar";
            this.btValorCadastrar.UseVisualStyleBackColor = true;
            this.btValorCadastrar.Click += new System.EventHandler(this.btValorCadastrar_Click);
            // 
            // lblTabelaJC
            // 
            this.lblTabelaJC.AutoSize = true;
            this.lblTabelaJC.Location = new System.Drawing.Point(144, 70);
            this.lblTabelaJC.Name = "lblTabelaJC";
            this.lblTabelaJC.Size = new System.Drawing.Size(82, 13);
            this.lblTabelaJC.TabIndex = 1;
            this.lblTabelaJC.Text = "Já cadastrados:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 19);
            this.txtValor.MaxLength = 256;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(286, 20);
            this.txtValor.TabIndex = 2;
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
            this.dgvDados.Location = new System.Drawing.Point(5, 85);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(360, 413);
            this.dgvDados.TabIndex = 78;
            this.dgvDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentDoubleClick);
            // 
            // gbCadastrando
            // 
            this.gbCadastrando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCadastrando.Controls.Add(this.lblCodigo);
            this.gbCadastrando.Controls.Add(this.btCancelar);
            this.gbCadastrando.Controls.Add(this.btExcluir);
            this.gbCadastrando.Controls.Add(this.btAlterar);
            this.gbCadastrando.Controls.Add(this.txtCodigo);
            this.gbCadastrando.Controls.Add(this.btValorCadastrar);
            this.gbCadastrando.Controls.Add(this.txtValor);
            this.gbCadastrando.Controls.Add(this.dgvDados);
            this.gbCadastrando.Controls.Add(this.lblTabelaJC);
            this.gbCadastrando.Location = new System.Drawing.Point(12, 57);
            this.gbCadastrando.Name = "gbCadastrando";
            this.gbCadastrando.Size = new System.Drawing.Size(370, 503);
            this.gbCadastrando.TabIndex = 3;
            this.gbCadastrando.TabStop = false;
            this.gbCadastrando.Text = "Cadastrar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(298, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 83;
            this.lblCodigo.Text = "Código";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(273, 45);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(91, 22);
            this.btCancelar.TabIndex = 82;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(184, 45);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 22);
            this.btExcluir.TabIndex = 81;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(95, 45);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(83, 22);
            this.btAlterar.TabIndex = 80;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(344, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(20, 20);
            this.txtCodigo.TabIndex = 79;
            // 
            // btDepartamento
            // 
            this.btDepartamento.Location = new System.Drawing.Point(11, 12);
            this.btDepartamento.Name = "btDepartamento";
            this.btDepartamento.Size = new System.Drawing.Size(90, 39);
            this.btDepartamento.TabIndex = 79;
            this.btDepartamento.Text = "Departamento";
            this.btDepartamento.UseVisualStyleBackColor = true;
            this.btDepartamento.Click += new System.EventHandler(this.btDepartamento_Click);
            // 
            // btMarca
            // 
            this.btMarca.Location = new System.Drawing.Point(108, 12);
            this.btMarca.Name = "btMarca";
            this.btMarca.Size = new System.Drawing.Size(90, 39);
            this.btMarca.TabIndex = 80;
            this.btMarca.Text = "Marca";
            this.btMarca.UseVisualStyleBackColor = true;
            this.btMarca.Click += new System.EventHandler(this.btMarca_Click);
            // 
            // btSobra1
            // 
            this.btSobra1.Enabled = false;
            this.btSobra1.Location = new System.Drawing.Point(204, 12);
            this.btSobra1.Name = "btSobra1";
            this.btSobra1.Size = new System.Drawing.Size(90, 39);
            this.btSobra1.TabIndex = 81;
            this.btSobra1.Text = "-";
            this.btSobra1.UseVisualStyleBackColor = true;
            // 
            // btSobra2
            // 
            this.btSobra2.Enabled = false;
            this.btSobra2.Location = new System.Drawing.Point(300, 12);
            this.btSobra2.Name = "btSobra2";
            this.btSobra2.Size = new System.Drawing.Size(82, 39);
            this.btSobra2.TabIndex = 82;
            this.btSobra2.Text = "-";
            this.btSobra2.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(239, 557);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(143, 13);
            this.lblAviso.TabIndex = 80;
            this.lblAviso.Text = "Click duas vezes para alterar";
            // 
            // frmCadastroInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 572);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btSobra2);
            this.Controls.Add(this.btSobra1);
            this.Controls.Add(this.btMarca);
            this.Controls.Add(this.btDepartamento);
            this.Controls.Add(this.gbCadastrando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroInformacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Alterar Informações";
            this.Load += new System.EventHandler(this.frmCadastroInformacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbCadastrando.ResumeLayout(false);
            this.gbCadastrando.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValorCadastrar;
        private System.Windows.Forms.Label lblTabelaJC;
        private System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox gbCadastrando;
        private System.Windows.Forms.Button btDepartamento;
        private System.Windows.Forms.Button btMarca;
        private System.Windows.Forms.Button btSobra1;
        private System.Windows.Forms.Button btSobra2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblCodigo;
    }
}
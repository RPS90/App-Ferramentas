namespace GUI
{
    partial class frmConsultaHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.chbInativo = new System.Windows.Forms.CheckBox();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.lblReg2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblReg1 = new System.Windows.Forms.Label();
            this.cbAcoes = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpRegistroAte = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistroDe = new System.Windows.Forms.DateTimePicker();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.chbDepartamento = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblAcoes = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Location = new System.Drawing.Point(0, 123);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(793, 438);
            this.dgvDados.TabIndex = 145;
            // 
            // chbInativo
            // 
            this.chbInativo.AutoSize = true;
            this.chbInativo.Location = new System.Drawing.Point(417, 46);
            this.chbInativo.Name = "chbInativo";
            this.chbInativo.Size = new System.Drawing.Size(58, 17);
            this.chbInativo.TabIndex = 147;
            this.chbInativo.Text = "Inativo";
            this.chbInativo.UseVisualStyleBackColor = true;
            this.chbInativo.CheckedChanged += new System.EventHandler(this.chbInativo_CheckedChanged);
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Location = new System.Drawing.Point(349, 46);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(50, 17);
            this.chbAtivo.TabIndex = 148;
            this.chbAtivo.Text = "Ativo";
            this.chbAtivo.UseVisualStyleBackColor = true;
            this.chbAtivo.CheckedChanged += new System.EventHandler(this.chbAtivo_CheckedChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(590, 11);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(82, 20);
            this.btPesquisar.TabIndex = 151;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // cbBusca
            // 
            this.cbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Todos",
            "Computadores",
            "Mesas",
            "Monitores",
            "Usuários"});
            this.cbBusca.Location = new System.Drawing.Point(12, 12);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(102, 21);
            this.cbBusca.TabIndex = 152;
            this.cbBusca.Text = "Todos";
            this.cbBusca.TextChanged += new System.EventHandler(this.cbBusca_TextChanged);
            this.cbBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBusca_KeyPress);
            // 
            // lblReg2
            // 
            this.lblReg2.AutoSize = true;
            this.lblReg2.Location = new System.Drawing.Point(607, 47);
            this.lblReg2.Name = "lblReg2";
            this.lblReg2.Size = new System.Drawing.Size(25, 13);
            this.lblReg2.TabIndex = 155;
            this.lblReg2.Text = "até:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(274, 47);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 13);
            this.lblEstado.TabIndex = 156;
            this.lblEstado.Text = "Estado atual:";
            // 
            // lblReg1
            // 
            this.lblReg1.AutoSize = true;
            this.lblReg1.Location = new System.Drawing.Point(563, 21);
            this.lblReg1.Name = "lblReg1";
            this.lblReg1.Size = new System.Drawing.Size(69, 13);
            this.lblReg1.TabIndex = 161;
            this.lblReg1.Text = "Registros de:";
            // 
            // cbAcoes
            // 
            this.cbAcoes.FormattingEnabled = true;
            this.cbAcoes.Items.AddRange(new object[] {
            "Todas",
            "Cadastrar",
            "Alterar",
            "Desvincular",
            "Limpar Mesa"});
            this.cbAcoes.Location = new System.Drawing.Point(349, 18);
            this.cbAcoes.Name = "cbAcoes";
            this.cbAcoes.Size = new System.Drawing.Size(128, 21);
            this.cbAcoes.TabIndex = 170;
            this.cbAcoes.Text = "Todas";
            this.cbAcoes.TextChanged += new System.EventHandler(this.cbAcoes_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValor.Location = new System.Drawing.Point(120, 12);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(464, 20);
            this.txtValor.TabIndex = 169;
            // 
            // dtpRegistroAte
            // 
            this.dtpRegistroAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistroAte.Location = new System.Drawing.Point(638, 44);
            this.dtpRegistroAte.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpRegistroAte.Name = "dtpRegistroAte";
            this.dtpRegistroAte.Size = new System.Drawing.Size(126, 20);
            this.dtpRegistroAte.TabIndex = 168;
            this.dtpRegistroAte.ValueChanged += new System.EventHandler(this.dtpATE_ValueChanged);
            // 
            // dtpRegistroDe
            // 
            this.dtpRegistroDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistroDe.Location = new System.Drawing.Point(638, 18);
            this.dtpRegistroDe.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpRegistroDe.Name = "dtpRegistroDe";
            this.dtpRegistroDe.Size = new System.Drawing.Size(126, 20);
            this.dtpRegistroDe.TabIndex = 167;
            this.dtpRegistroDe.ValueChanged += new System.EventHandler(this.dtpDE_ValueChanged);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chbMarca);
            this.gbFiltros.Controls.Add(this.chbDepartamento);
            this.gbFiltros.Controls.Add(this.cbMarca);
            this.gbFiltros.Controls.Add(this.lblAcoes);
            this.gbFiltros.Controls.Add(this.cbDepartamento);
            this.gbFiltros.Controls.Add(this.cbAcoes);
            this.gbFiltros.Controls.Add(this.dtpRegistroDe);
            this.gbFiltros.Controls.Add(this.lblReg1);
            this.gbFiltros.Controls.Add(this.dtpRegistroAte);
            this.gbFiltros.Controls.Add(this.lblReg2);
            this.gbFiltros.Controls.Add(this.lblEstado);
            this.gbFiltros.Controls.Add(this.chbInativo);
            this.gbFiltros.Controls.Add(this.chbAtivo);
            this.gbFiltros.Location = new System.Drawing.Point(12, 39);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(770, 79);
            this.gbFiltros.TabIndex = 176;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.Location = new System.Drawing.Point(6, 47);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(56, 17);
            this.chbMarca.TabIndex = 182;
            this.chbMarca.Text = "Marca";
            this.chbMarca.UseVisualStyleBackColor = true;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // chbDepartamento
            // 
            this.chbDepartamento.AutoSize = true;
            this.chbDepartamento.Location = new System.Drawing.Point(6, 20);
            this.chbDepartamento.Name = "chbDepartamento";
            this.chbDepartamento.Size = new System.Drawing.Size(96, 17);
            this.chbDepartamento.TabIndex = 181;
            this.chbDepartamento.Text = "Derpartamento";
            this.chbDepartamento.UseVisualStyleBackColor = true;
            this.chbDepartamento.CheckedChanged += new System.EventHandler(this.chbDepartamento_CheckedChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(108, 45);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(101, 21);
            this.cbMarca.TabIndex = 180;
            this.cbMarca.TextChanged += new System.EventHandler(this.cbMarca_TextChanged);
            // 
            // lblAcoes
            // 
            this.lblAcoes.AutoSize = true;
            this.lblAcoes.Location = new System.Drawing.Point(303, 21);
            this.lblAcoes.Name = "lblAcoes";
            this.lblAcoes.Size = new System.Drawing.Size(40, 13);
            this.lblAcoes.TabIndex = 179;
            this.lblAcoes.Text = "Ações:";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(108, 18);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(101, 21);
            this.cbDepartamento.TabIndex = 177;
            this.cbDepartamento.TextChanged += new System.EventHandler(this.cbDepartamento_TextChanged);
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(678, 11);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(104, 20);
            this.btImprimir.TabIndex = 182;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // frmConsultaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmConsultaHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa avançada de Histórico";
            this.Load += new System.EventHandler(this.frmConsultaHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.CheckBox chbInativo;
        private System.Windows.Forms.CheckBox chbAtivo;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label lblReg2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblReg1;
        private System.Windows.Forms.DateTimePicker dtpRegistroAte;
        private System.Windows.Forms.DateTimePicker dtpRegistroDe;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbAcoes;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblAcoes;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.CheckBox chbDepartamento;
    }
}
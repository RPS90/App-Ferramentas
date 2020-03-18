namespace GUI
{
    partial class frmAtribTrocaMesaMonitor
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
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lblPatrimonioProv = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblNumeroPatrimonio = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartamentoMonitor = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lblTipoMonitor = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lblNumeroPatrimonioMonitor = new System.Windows.Forms.Label();
            this.lblMarcaMonitor = new System.Windows.Forms.Label();
            this.lblNserieMonitor = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.btDesvincularMonitor = new System.Windows.Forms.Button();
            this.btLimparMesa = new System.Windows.Forms.Button();
            this.btTelaAnterior = new System.Windows.Forms.Button();
            this.btProximaTela = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMonitor
            // 
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(244, 25);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(228, 21);
            this.cbMonitor.TabIndex = 2;
            this.cbMonitor.SelectedValueChanged += new System.EventHandler(this.cbMonitor_SelectedValueChanged);
            // 
            // cbMesa
            // 
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(12, 25);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(226, 21);
            this.cbMesa.TabIndex = 1;
            this.cbMesa.SelectedValueChanged += new System.EventHandler(this.cbMesa_SelectedValueChanged);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(478, 9);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(104, 55);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Monitor (N° Patrimônio)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mesa (N° Patrimônio):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.lblPatrimonioProv);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Controls.Add(this.lblSigla);
            this.groupBox2.Controls.Add(this.lblNumeroPatrimonio);
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 228);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações (Mesa):";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(6, 74);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(84, 13);
            this.lb3.TabIndex = 24;
            this.lb3.Text = "Patrimônio Prov.";
            // 
            // lblPatrimonioProv
            // 
            this.lblPatrimonioProv.AutoSize = true;
            this.lblPatrimonioProv.Location = new System.Drawing.Point(107, 74);
            this.lblPatrimonioProv.Name = "lblPatrimonioProv";
            this.lblPatrimonioProv.Size = new System.Drawing.Size(10, 13);
            this.lblPatrimonioProv.TabIndex = 20;
            this.lblPatrimonioProv.Text = "-";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(6, 100);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(33, 13);
            this.lb4.TabIndex = 23;
            this.lb4.Text = "Sigla:";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(107, 100);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(10, 13);
            this.lblSigla.TabIndex = 19;
            this.lblSigla.Text = "-";
            // 
            // lblNumeroPatrimonio
            // 
            this.lblNumeroPatrimonio.AutoSize = true;
            this.lblNumeroPatrimonio.Location = new System.Drawing.Point(107, 22);
            this.lblNumeroPatrimonio.Name = "lblNumeroPatrimonio";
            this.lblNumeroPatrimonio.Size = new System.Drawing.Size(10, 13);
            this.lblNumeroPatrimonio.TabIndex = 18;
            this.lblNumeroPatrimonio.Text = "-";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(107, 48);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(10, 13);
            this.lblDepartamento.TabIndex = 17;
            this.lblDepartamento.Text = "-";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(6, 48);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(77, 13);
            this.lb2.TabIndex = 22;
            this.lb2.Text = "Departamento:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(74, 13);
            this.lb1.TabIndex = 21;
            this.lb1.Text = "N° Patrimônio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepartamentoMonitor);
            this.groupBox1.Controls.Add(this.lb5);
            this.groupBox1.Controls.Add(this.lb6);
            this.groupBox1.Controls.Add(this.lblTipoMonitor);
            this.groupBox1.Controls.Add(this.lb7);
            this.groupBox1.Controls.Add(this.lb8);
            this.groupBox1.Controls.Add(this.lblNumeroPatrimonioMonitor);
            this.groupBox1.Controls.Add(this.lblMarcaMonitor);
            this.groupBox1.Controls.Add(this.lblNserieMonitor);
            this.groupBox1.Controls.Add(this.lb9);
            this.groupBox1.Location = new System.Drawing.Point(244, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 228);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações (Computador)";
            // 
            // lblDepartamentoMonitor
            // 
            this.lblDepartamentoMonitor.AutoSize = true;
            this.lblDepartamentoMonitor.Location = new System.Drawing.Point(107, 100);
            this.lblDepartamentoMonitor.Name = "lblDepartamentoMonitor";
            this.lblDepartamentoMonitor.Size = new System.Drawing.Size(10, 13);
            this.lblDepartamentoMonitor.TabIndex = 16;
            this.lblDepartamentoMonitor.Text = "-";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(6, 22);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(74, 13);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "N° Patrimônio:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(6, 48);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(40, 13);
            this.lb6.TabIndex = 7;
            this.lb6.Text = "Marca:";
            // 
            // lblTipoMonitor
            // 
            this.lblTipoMonitor.AutoSize = true;
            this.lblTipoMonitor.Location = new System.Drawing.Point(107, 126);
            this.lblTipoMonitor.Name = "lblTipoMonitor";
            this.lblTipoMonitor.Size = new System.Drawing.Size(10, 13);
            this.lblTipoMonitor.TabIndex = 14;
            this.lblTipoMonitor.Text = "-";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(6, 74);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(49, 13);
            this.lb7.TabIndex = 3;
            this.lb7.Text = "N° Série:";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(6, 100);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(74, 13);
            this.lb8.TabIndex = 2;
            this.lb8.Text = "Departamento";
            // 
            // lblNumeroPatrimonioMonitor
            // 
            this.lblNumeroPatrimonioMonitor.AutoSize = true;
            this.lblNumeroPatrimonioMonitor.Location = new System.Drawing.Point(107, 22);
            this.lblNumeroPatrimonioMonitor.Name = "lblNumeroPatrimonioMonitor";
            this.lblNumeroPatrimonioMonitor.Size = new System.Drawing.Size(10, 13);
            this.lblNumeroPatrimonioMonitor.TabIndex = 12;
            this.lblNumeroPatrimonioMonitor.Text = "-";
            // 
            // lblMarcaMonitor
            // 
            this.lblMarcaMonitor.AutoSize = true;
            this.lblMarcaMonitor.Location = new System.Drawing.Point(107, 48);
            this.lblMarcaMonitor.Name = "lblMarcaMonitor";
            this.lblMarcaMonitor.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaMonitor.TabIndex = 10;
            this.lblMarcaMonitor.Text = "-";
            // 
            // lblNserieMonitor
            // 
            this.lblNserieMonitor.AutoSize = true;
            this.lblNserieMonitor.Location = new System.Drawing.Point(107, 74);
            this.lblNserieMonitor.Name = "lblNserieMonitor";
            this.lblNserieMonitor.Size = new System.Drawing.Size(10, 13);
            this.lblNserieMonitor.TabIndex = 11;
            this.lblNserieMonitor.Text = "-";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(6, 126);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(31, 13);
            this.lb9.TabIndex = 13;
            this.lb9.Text = "Tipo:";
            // 
            // btDesvincularMonitor
            // 
            this.btDesvincularMonitor.Location = new System.Drawing.Point(244, 52);
            this.btDesvincularMonitor.Name = "btDesvincularMonitor";
            this.btDesvincularMonitor.Size = new System.Drawing.Size(228, 23);
            this.btDesvincularMonitor.TabIndex = 15;
            this.btDesvincularMonitor.Text = "Desvincular Monitor da Mesa atual";
            this.btDesvincularMonitor.UseVisualStyleBackColor = true;
            this.btDesvincularMonitor.Click += new System.EventHandler(this.btDesvincularMonitor_Click);
            // 
            // btLimparMesa
            // 
            this.btLimparMesa.Location = new System.Drawing.Point(12, 52);
            this.btLimparMesa.Name = "btLimparMesa";
            this.btLimparMesa.Size = new System.Drawing.Size(226, 23);
            this.btLimparMesa.TabIndex = 14;
            this.btLimparMesa.Text = "Limpar Mesa";
            this.btLimparMesa.UseVisualStyleBackColor = true;
            this.btLimparMesa.Click += new System.EventHandler(this.btLimparMesa_Click);
            // 
            // btTelaAnterior
            // 
            this.btTelaAnterior.Location = new System.Drawing.Point(12, 315);
            this.btTelaAnterior.Name = "btTelaAnterior";
            this.btTelaAnterior.Size = new System.Drawing.Size(226, 45);
            this.btTelaAnterior.TabIndex = 19;
            this.btTelaAnterior.Text = "< Computadores";
            this.btTelaAnterior.UseVisualStyleBackColor = true;
            this.btTelaAnterior.Click += new System.EventHandler(this.btTelaAnterior_Click);
            // 
            // btProximaTela
            // 
            this.btProximaTela.Location = new System.Drawing.Point(244, 315);
            this.btProximaTela.Name = "btProximaTela";
            this.btProximaTela.Size = new System.Drawing.Size(228, 45);
            this.btProximaTela.TabIndex = 18;
            this.btProximaTela.Text = "Usuários >";
            this.btProximaTela.UseVisualStyleBackColor = true;
            this.btProximaTela.Click += new System.EventHandler(this.btProximaTela_Click);
            // 
            // frmAtribTrocaMesaMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.btTelaAnterior);
            this.Controls.Add(this.btProximaTela);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDesvincularMonitor);
            this.Controls.Add(this.btLimparMesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.cbMonitor);
            this.Controls.Add(this.cbMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtribTrocaMesaMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atribuir Monitores";
            this.Load += new System.EventHandler(this.frmAtribTrocaMesaMonitor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartamentoMonitor;
        private System.Windows.Forms.Label lblTipoMonitor;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lblNumeroPatrimonioMonitor;
        private System.Windows.Forms.Label lblNserieMonitor;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lblMarcaMonitor;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Button btDesvincularMonitor;
        private System.Windows.Forms.Button btLimparMesa;
        private System.Windows.Forms.Button btTelaAnterior;
        private System.Windows.Forms.Button btProximaTela;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lblPatrimonioProv;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblNumeroPatrimonio;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
    }
}
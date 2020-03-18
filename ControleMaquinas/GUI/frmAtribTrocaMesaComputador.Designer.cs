namespace GUI
{
    partial class frmAtribTrocaMesaComputador
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
            this.cbComputador = new System.Windows.Forms.ComboBox();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimparMesa = new System.Windows.Forms.Button();
            this.btDesvincularComputador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMarcaComputador = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lblDepartamentoComputador = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lblNumeroPatrimonioComputador = new System.Windows.Forms.Label();
            this.lblNserieComputador = new System.Windows.Forms.Label();
            this.lblModeloComputador = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lblPatrimonioProv = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblNumeroPatrimonio = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btProximaTela = new System.Windows.Forms.Button();
            this.btTelaAnterior = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbComputador
            // 
            this.cbComputador.FormattingEnabled = true;
            this.cbComputador.Location = new System.Drawing.Point(244, 25);
            this.cbComputador.Name = "cbComputador";
            this.cbComputador.Size = new System.Drawing.Size(228, 21);
            this.cbComputador.TabIndex = 2;
            this.cbComputador.SelectedValueChanged += new System.EventHandler(this.cbComputador_SelectedValueChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesa (N° Patrimônio):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computador (N° Patrimonio):";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(478, 9);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(104, 55);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimparMesa
            // 
            this.btLimparMesa.Location = new System.Drawing.Point(12, 52);
            this.btLimparMesa.Name = "btLimparMesa";
            this.btLimparMesa.Size = new System.Drawing.Size(226, 23);
            this.btLimparMesa.TabIndex = 8;
            this.btLimparMesa.Text = "Limpar Mesa";
            this.btLimparMesa.UseVisualStyleBackColor = true;
            this.btLimparMesa.Click += new System.EventHandler(this.btLimparMesa_Click);
            // 
            // btDesvincularComputador
            // 
            this.btDesvincularComputador.Location = new System.Drawing.Point(244, 52);
            this.btDesvincularComputador.Name = "btDesvincularComputador";
            this.btDesvincularComputador.Size = new System.Drawing.Size(228, 23);
            this.btDesvincularComputador.TabIndex = 9;
            this.btDesvincularComputador.Text = "Desvincular Computador da Mesa atual";
            this.btDesvincularComputador.UseVisualStyleBackColor = true;
            this.btDesvincularComputador.Click += new System.EventHandler(this.btDesvincularComputador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMarcaComputador);
            this.groupBox1.Controls.Add(this.lb5);
            this.groupBox1.Controls.Add(this.lb6);
            this.groupBox1.Controls.Add(this.lblDepartamentoComputador);
            this.groupBox1.Controls.Add(this.lb7);
            this.groupBox1.Controls.Add(this.lb8);
            this.groupBox1.Controls.Add(this.lblNumeroPatrimonioComputador);
            this.groupBox1.Controls.Add(this.lblNserieComputador);
            this.groupBox1.Controls.Add(this.lblModeloComputador);
            this.groupBox1.Controls.Add(this.lb9);
            this.groupBox1.Location = new System.Drawing.Point(244, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações (Computador)";
            // 
            // lblMarcaComputador
            // 
            this.lblMarcaComputador.AutoSize = true;
            this.lblMarcaComputador.Location = new System.Drawing.Point(107, 100);
            this.lblMarcaComputador.Name = "lblMarcaComputador";
            this.lblMarcaComputador.Size = new System.Drawing.Size(10, 13);
            this.lblMarcaComputador.TabIndex = 26;
            this.lblMarcaComputador.Text = "-";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(6, 22);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(74, 13);
            this.lb5.TabIndex = 20;
            this.lb5.Text = "N° Patrimônio:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(6, 48);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(46, 13);
            this.lb6.TabIndex = 19;
            this.lb6.Text = "N° Série";
            // 
            // lblDepartamentoComputador
            // 
            this.lblDepartamentoComputador.AutoSize = true;
            this.lblDepartamentoComputador.Location = new System.Drawing.Point(107, 126);
            this.lblDepartamentoComputador.Name = "lblDepartamentoComputador";
            this.lblDepartamentoComputador.Size = new System.Drawing.Size(10, 13);
            this.lblDepartamentoComputador.TabIndex = 25;
            this.lblDepartamentoComputador.Text = "-";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(6, 74);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(45, 13);
            this.lb7.TabIndex = 18;
            this.lb7.Text = "Modelo:";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(6, 100);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(40, 13);
            this.lb8.TabIndex = 17;
            this.lb8.Text = "Marca:";
            // 
            // lblNumeroPatrimonioComputador
            // 
            this.lblNumeroPatrimonioComputador.AutoSize = true;
            this.lblNumeroPatrimonioComputador.Location = new System.Drawing.Point(107, 22);
            this.lblNumeroPatrimonioComputador.Name = "lblNumeroPatrimonioComputador";
            this.lblNumeroPatrimonioComputador.Size = new System.Drawing.Size(10, 13);
            this.lblNumeroPatrimonioComputador.TabIndex = 23;
            this.lblNumeroPatrimonioComputador.Text = "-";
            // 
            // lblNserieComputador
            // 
            this.lblNserieComputador.AutoSize = true;
            this.lblNserieComputador.Location = new System.Drawing.Point(107, 48);
            this.lblNserieComputador.Name = "lblNserieComputador";
            this.lblNserieComputador.Size = new System.Drawing.Size(10, 13);
            this.lblNserieComputador.TabIndex = 21;
            this.lblNserieComputador.Text = "-";
            // 
            // lblModeloComputador
            // 
            this.lblModeloComputador.AutoSize = true;
            this.lblModeloComputador.Location = new System.Drawing.Point(107, 74);
            this.lblModeloComputador.Name = "lblModeloComputador";
            this.lblModeloComputador.Size = new System.Drawing.Size(10, 13);
            this.lblModeloComputador.TabIndex = 22;
            this.lblModeloComputador.Text = "-";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(6, 126);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(77, 13);
            this.lb9.TabIndex = 24;
            this.lb9.Text = "Departamento:";
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
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações (Mesa):";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(6, 74);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(84, 13);
            this.lb3.TabIndex = 32;
            this.lb3.Text = "Patrimônio Prov.";
            // 
            // lblPatrimonioProv
            // 
            this.lblPatrimonioProv.AutoSize = true;
            this.lblPatrimonioProv.Location = new System.Drawing.Point(107, 74);
            this.lblPatrimonioProv.Name = "lblPatrimonioProv";
            this.lblPatrimonioProv.Size = new System.Drawing.Size(10, 13);
            this.lblPatrimonioProv.TabIndex = 28;
            this.lblPatrimonioProv.Text = "-";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(6, 100);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(33, 13);
            this.lb4.TabIndex = 31;
            this.lb4.Text = "Sigla:";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(107, 100);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(10, 13);
            this.lblSigla.TabIndex = 27;
            this.lblSigla.Text = "-";
            // 
            // lblNumeroPatrimonio
            // 
            this.lblNumeroPatrimonio.AutoSize = true;
            this.lblNumeroPatrimonio.Location = new System.Drawing.Point(107, 22);
            this.lblNumeroPatrimonio.Name = "lblNumeroPatrimonio";
            this.lblNumeroPatrimonio.Size = new System.Drawing.Size(10, 13);
            this.lblNumeroPatrimonio.TabIndex = 26;
            this.lblNumeroPatrimonio.Text = "-";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(107, 48);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(10, 13);
            this.lblDepartamento.TabIndex = 25;
            this.lblDepartamento.Text = "-";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(6, 48);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(77, 13);
            this.lb2.TabIndex = 30;
            this.lb2.Text = "Departamento:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(74, 13);
            this.lb1.TabIndex = 29;
            this.lb1.Text = "N° Patrimônio:";
            // 
            // btProximaTela
            // 
            this.btProximaTela.Location = new System.Drawing.Point(244, 315);
            this.btProximaTela.Name = "btProximaTela";
            this.btProximaTela.Size = new System.Drawing.Size(228, 45);
            this.btProximaTela.TabIndex = 12;
            this.btProximaTela.Text = "Monitores >";
            this.btProximaTela.UseVisualStyleBackColor = true;
            this.btProximaTela.Click += new System.EventHandler(this.btProximaTela_Click);
            // 
            // btTelaAnterior
            // 
            this.btTelaAnterior.Location = new System.Drawing.Point(12, 315);
            this.btTelaAnterior.Name = "btTelaAnterior";
            this.btTelaAnterior.Size = new System.Drawing.Size(226, 45);
            this.btTelaAnterior.TabIndex = 13;
            this.btTelaAnterior.Text = "< Usuários";
            this.btTelaAnterior.UseVisualStyleBackColor = true;
            this.btTelaAnterior.Click += new System.EventHandler(this.btTelaAnterior_Click);
            // 
            // frmAtribTrocaMesaComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.btTelaAnterior);
            this.Controls.Add(this.btProximaTela);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDesvincularComputador);
            this.Controls.Add(this.btLimparMesa);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComputador);
            this.Controls.Add(this.cbMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtribTrocaMesaComputador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atribuir Computadores";
            this.Load += new System.EventHandler(this.frmAtribTrocaMesaComputador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComputador;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimparMesa;
        private System.Windows.Forms.Button btDesvincularComputador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btProximaTela;
        private System.Windows.Forms.Button btTelaAnterior;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lblPatrimonioProv;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblNumeroPatrimonio;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lblMarcaComputador;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lblDepartamentoComputador;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lblNumeroPatrimonioComputador;
        private System.Windows.Forms.Label lblNserieComputador;
        private System.Windows.Forms.Label lblModeloComputador;
        private System.Windows.Forms.Label lb9;
    }
}
namespace Reino_da_Garotada
{
    partial class FormCadastrarCurso
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.CodCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.cboLocalRealizacao = new System.Windows.Forms.TextBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.cboResponsCurso = new System.Windows.Forms.ComboBox();
            this.labelResp = new System.Windows.Forms.Label();
            this.labelLocalRealizacao = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.labelCargaHoraria = new System.Windows.Forms.Label();
            this.cboDiasSemana = new System.Windows.Forms.ComboBox();
            this.cboHorário = new System.Windows.Forms.ComboBox();
            this.txtQualifProfissional = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelQualificacao = new System.Windows.Forms.Label();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.labelNomeCurso = new System.Windows.Forms.Label();
            this.panelLow = new System.Windows.Forms.Panel();
            this.buttonSalvarCadastro = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonLimparCadastro = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTituloCadAluno = new System.Windows.Forms.Label();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkdQtdAluno = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxDados.SuspendLayout();
            this.panelLow.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCodigo.Location = new System.Drawing.Point(763, 77);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(132, 26);
            this.labelCodigo.TabIndex = 81;
            this.labelCodigo.Text = "Código do curso";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CodCurso
            // 
            this.CodCurso.Enabled = false;
            this.CodCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodCurso.Location = new System.Drawing.Point(901, 77);
            this.CodCurso.Name = "CodCurso";
            this.CodCurso.Size = new System.Drawing.Size(50, 26);
            this.CodCurso.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 27;
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCurso.Location = new System.Drawing.Point(136, 32);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(440, 26);
            this.txtCurso.TabIndex = 1;
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDados.Controls.Add(this.mkdQtdAluno);
            this.groupBoxDados.Controls.Add(this.label2);
            this.groupBoxDados.Controls.Add(this.cboLocalRealizacao);
            this.groupBoxDados.Controls.Add(this.cboPeriodo);
            this.groupBoxDados.Controls.Add(this.labelPeriodo);
            this.groupBoxDados.Controls.Add(this.cboResponsCurso);
            this.groupBoxDados.Controls.Add(this.labelResp);
            this.groupBoxDados.Controls.Add(this.labelLocalRealizacao);
            this.groupBoxDados.Controls.Add(this.txtCargaHoraria);
            this.groupBoxDados.Controls.Add(this.labelCargaHoraria);
            this.groupBoxDados.Controls.Add(this.cboDiasSemana);
            this.groupBoxDados.Controls.Add(this.cboHorário);
            this.groupBoxDados.Controls.Add(this.txtQualifProfissional);
            this.groupBoxDados.Controls.Add(this.txtDescricao);
            this.groupBoxDados.Controls.Add(this.labelDescricao);
            this.groupBoxDados.Controls.Add(this.labelQualificacao);
            this.groupBoxDados.Controls.Add(this.labelHorario);
            this.groupBoxDados.Controls.Add(this.label1);
            this.groupBoxDados.Controls.Add(this.labelDias);
            this.groupBoxDados.Controls.Add(this.txtCurso);
            this.groupBoxDados.Controls.Add(this.labelNomeCurso);
            this.groupBoxDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxDados.Location = new System.Drawing.Point(25, 106);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(1183, 307);
            this.groupBoxDados.TabIndex = 88;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados do Curso";
            // 
            // cboLocalRealizacao
            // 
            this.cboLocalRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboLocalRealizacao.Location = new System.Drawing.Point(649, 270);
            this.cboLocalRealizacao.Name = "cboLocalRealizacao";
            this.cboLocalRealizacao.Size = new System.Drawing.Size(277, 26);
            this.cboLocalRealizacao.TabIndex = 97;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Integral"});
            this.cboPeriodo.Location = new System.Drawing.Point(656, 32);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(263, 28);
            this.cboPeriodo.TabIndex = 2;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPeriodo.Location = new System.Drawing.Point(587, 34);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(65, 20);
            this.labelPeriodo.TabIndex = 96;
            this.labelPeriodo.Text = "Período";
            this.labelPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboResponsCurso
            // 
            this.cboResponsCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboResponsCurso.FormattingEnabled = true;
            this.cboResponsCurso.Location = new System.Drawing.Point(195, 238);
            this.cboResponsCurso.Name = "cboResponsCurso";
            this.cboResponsCurso.Size = new System.Drawing.Size(365, 28);
            this.cboResponsCurso.TabIndex = 8;
            // 
            // labelResp
            // 
            this.labelResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResp.Location = new System.Drawing.Point(-1, 240);
            this.labelResp.Name = "labelResp";
            this.labelResp.Size = new System.Drawing.Size(190, 23);
            this.labelResp.TabIndex = 94;
            this.labelResp.Text = "Responsável pelo Curso";
            this.labelResp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLocalRealizacao
            // 
            this.labelLocalRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLocalRealizacao.Location = new System.Drawing.Point(478, 274);
            this.labelLocalRealizacao.Name = "labelLocalRealizacao";
            this.labelLocalRealizacao.Size = new System.Drawing.Size(158, 23);
            this.labelLocalRealizacao.TabIndex = 92;
            this.labelLocalRealizacao.Text = "Local de Realização";
            this.labelLocalRealizacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCargaHoraria.Location = new System.Drawing.Point(631, 85);
            this.txtCargaHoraria.Mask = "0000h";
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(55, 26);
            this.txtCargaHoraria.TabIndex = 5;
            // 
            // labelCargaHoraria
            // 
            this.labelCargaHoraria.BackColor = System.Drawing.Color.Transparent;
            this.labelCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCargaHoraria.Location = new System.Drawing.Point(517, 86);
            this.labelCargaHoraria.Name = "labelCargaHoraria";
            this.labelCargaHoraria.Size = new System.Drawing.Size(108, 26);
            this.labelCargaHoraria.TabIndex = 88;
            this.labelCargaHoraria.Text = "Carga Horária";
            this.labelCargaHoraria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDiasSemana
            // 
            this.cboDiasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboDiasSemana.FormattingEnabled = true;
            this.cboDiasSemana.Items.AddRange(new object[] {
            "Segunda á Sexta",
            "Segunda á Quinta",
            "Segunda á Quarta",
            "Segunda á Terça"});
            this.cboDiasSemana.Location = new System.Drawing.Point(136, 83);
            this.cboDiasSemana.Name = "cboDiasSemana";
            this.cboDiasSemana.Size = new System.Drawing.Size(375, 28);
            this.cboDiasSemana.TabIndex = 4;
            // 
            // cboHorário
            // 
            this.cboHorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboHorário.FormattingEnabled = true;
            this.cboHorário.Items.AddRange(new object[] {
            "08:00 ás 10:00",
            "10:00 ás 12:00",
            "13:00 ás 15:00",
            "15:00 ás 17:00"});
            this.cboHorário.Location = new System.Drawing.Point(764, 84);
            this.cboHorário.Name = "cboHorário";
            this.cboHorário.Size = new System.Drawing.Size(155, 28);
            this.cboHorário.TabIndex = 6;
            // 
            // txtQualifProfissional
            // 
            this.txtQualifProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQualifProfissional.Location = new System.Drawing.Point(195, 272);
            this.txtQualifProfissional.Name = "txtQualifProfissional";
            this.txtQualifProfissional.Size = new System.Drawing.Size(277, 26);
            this.txtQualifProfissional.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(136, 154);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(783, 78);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBoxDescricao_TextChanged);
            // 
            // labelDescricao
            // 
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDescricao.Location = new System.Drawing.Point(10, 131);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(147, 20);
            this.labelDescricao.TabIndex = 46;
            this.labelDescricao.Text = "Descrição do curso";
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQualificacao
            // 
            this.labelQualificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQualificacao.Location = new System.Drawing.Point(10, 276);
            this.labelQualificacao.Name = "labelQualificacao";
            this.labelQualificacao.Size = new System.Drawing.Size(182, 20);
            this.labelQualificacao.TabIndex = 45;
            this.labelQualificacao.Text = "Qualificação Profissional";
            this.labelQualificacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHorario
            // 
            this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHorario.Location = new System.Drawing.Point(692, 89);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(66, 20);
            this.labelHorario.TabIndex = 41;
            this.labelHorario.Text = "Horário";
            this.labelHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDias
            // 
            this.labelDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDias.Location = new System.Drawing.Point(0, 85);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(132, 23);
            this.labelDias.TabIndex = 21;
            this.labelDias.Text = "Dias da Semana";
            this.labelDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNomeCurso
            // 
            this.labelNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNomeCurso.Location = new System.Drawing.Point(9, 35);
            this.labelNomeCurso.Name = "labelNomeCurso";
            this.labelNomeCurso.Size = new System.Drawing.Size(123, 20);
            this.labelNomeCurso.TabIndex = 0;
            this.labelNomeCurso.Text = "Nome do Curso";
            this.labelNomeCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLow
            // 
            this.panelLow.BackColor = System.Drawing.Color.Transparent;
            this.panelLow.Controls.Add(this.buttonSalvarCadastro);
            this.panelLow.Controls.Add(this.buttonCancelarCadastro);
            this.panelLow.Controls.Add(this.buttonLimparCadastro);
            this.panelLow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLow.Location = new System.Drawing.Point(0, 432);
            this.panelLow.Name = "panelLow";
            this.panelLow.Size = new System.Drawing.Size(1202, 72);
            this.panelLow.TabIndex = 118;
            this.panelLow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLow_Paint);
            // 
            // buttonSalvarCadastro
            // 
            this.buttonSalvarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvarCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSalvarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonSalvarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonSalvarCadastro.Image = global::Reino_da_Garotada.Properties.Resources.icon_entrar1;
            this.buttonSalvarCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvarCadastro.Location = new System.Drawing.Point(887, 0);
            this.buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            this.buttonSalvarCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonSalvarCadastro.TabIndex = 12;
            this.buttonSalvarCadastro.Text = "&Salvar";
            this.buttonSalvarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvarCadastro.UseVisualStyleBackColor = false;
            this.buttonSalvarCadastro.Click += new System.EventHandler(this.buttonSalvarCadastro_Click);
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarCadastro.Image = global::Reino_da_Garotada.Properties.Resources.icon_cancelar1;
            this.buttonCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(992, 0);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonCancelarCadastro.TabIndex = 13;
            this.buttonCancelarCadastro.Text = "&Cancelar";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click_1);
            // 
            // buttonLimparCadastro
            // 
            this.buttonLimparCadastro.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimparCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimparCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLimparCadastro.FlatAppearance.BorderSize = 0;
            this.buttonLimparCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonLimparCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLimparCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLimparCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCadastro.ForeColor = System.Drawing.Color.White;
            this.buttonLimparCadastro.Image = global::Reino_da_Garotada.Properties.Resources.icon_limpar1;
            this.buttonLimparCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLimparCadastro.Location = new System.Drawing.Point(1097, 0);
            this.buttonLimparCadastro.Name = "buttonLimparCadastro";
            this.buttonLimparCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonLimparCadastro.TabIndex = 14;
            this.buttonLimparCadastro.Text = "&Limpar";
            this.buttonLimparCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimparCadastro.UseVisualStyleBackColor = false;
            this.buttonLimparCadastro.Click += new System.EventHandler(this.buttonLimparCadastro_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.labelTituloCadAluno);
            this.panelTop.Controls.Add(this.pictureBoxVoltar);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1202, 61);
            this.panelTop.TabIndex = 121;
            // 
            // labelTituloCadAluno
            // 
            this.labelTituloCadAluno.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCadAluno.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTituloCadAluno.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.labelTituloCadAluno.ForeColor = System.Drawing.Color.Salmon;
            this.labelTituloCadAluno.Location = new System.Drawing.Point(144, 0);
            this.labelTituloCadAluno.Name = "labelTituloCadAluno";
            this.labelTituloCadAluno.Size = new System.Drawing.Size(737, 61);
            this.labelTituloCadAluno.TabIndex = 84;
            this.labelTituloCadAluno.Text = "SISTEMA DE CONTROLE INTERNO DO REINO \r\n               | CADASTRO DE CURSOS";
            this.labelTituloCadAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVoltar.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.icon_voltar;
            this.pictureBoxVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVoltar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxVoltar.Location = new System.Drawing.Point(1068, 0);
            this.pictureBoxVoltar.Name = "pictureBoxVoltar";
            this.pictureBoxVoltar.Size = new System.Drawing.Size(134, 61);
            this.pictureBoxVoltar.TabIndex = 96;
            this.pictureBoxVoltar.TabStop = false;
            this.pictureBoxVoltar.Click += new System.EventHandler(this.pictureBoxVoltar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.reino_logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(144, 61);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 97;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(942, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 44);
            this.label2.TabIndex = 98;
            this.label2.Text = "Quantidades de alunos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mkdQtdAluno
            // 
            this.mkdQtdAluno.Location = new System.Drawing.Point(1118, 37);
            this.mkdQtdAluno.Mask = "000";
            this.mkdQtdAluno.Name = "mkdQtdAluno";
            this.mkdQtdAluno.Size = new System.Drawing.Size(49, 30);
            this.mkdQtdAluno.TabIndex = 99;
            // 
            // FormCadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 504);
            this.ControlBox = false;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLow);
            this.Controls.Add(this.groupBoxDados);
            this.Controls.Add(this.CodCurso);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle Interno | Reino da Garotada de Poá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastrarCurso_Load);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            this.panelLow.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        public System.Windows.Forms.TextBox CodCurso;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Label labelNomeCurso;
        public System.Windows.Forms.TextBox txtQualifProfissional;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelQualificacao;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.Panel panelLow;
        private System.Windows.Forms.Button buttonSalvarCadastro;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonLimparCadastro;
        private System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Label labelTituloCadAluno;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.MaskedTextBox txtCargaHoraria;
        private System.Windows.Forms.Label labelCargaHoraria;
        private System.Windows.Forms.ComboBox cboDiasSemana;
        private System.Windows.Forms.ComboBox cboHorário;
        private System.Windows.Forms.ComboBox cboResponsCurso;
        private System.Windows.Forms.Label labelResp;
        private System.Windows.Forms.Label labelLocalRealizacao;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.TextBox cboLocalRealizacao;
        private System.Windows.Forms.MaskedTextBox mkdQtdAluno;
        private System.Windows.Forms.Label label2;
    }
}
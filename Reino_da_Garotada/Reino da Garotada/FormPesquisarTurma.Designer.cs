namespace Reino_da_Garotada
{
    partial class FormPesquisarTurma
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTituloCadTurma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNomeAluno = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.buttonBuscarAluno = new System.Windows.Forms.Button();
            this.rdbPesqTurma = new System.Windows.Forms.RadioButton();
            this.rbtPesqNomeCurso = new System.Windows.Forms.RadioButton();
            this.panelLow = new System.Windows.Forms.Panel();
            this.pictureBoxEsquerda = new System.Windows.Forms.PictureBox();
            this.buttonSalvarCadastro = new System.Windows.Forms.Button();
            this.pictureBoxDireta = new System.Windows.Forms.PictureBox();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonLimparCadastro = new System.Windows.Forms.Button();
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.Codigo_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco_reinoDataSet1 = new Reino_da_Garotada.banco_reinoDataSet1();
            this.tBTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_TurmaTableAdapter = new Reino_da_Garotada.banco_reinoDataSet1TableAdapters.TB_TurmaTableAdapter();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDireta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_reinoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTurmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.labelTituloCadTurma);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1376, 61);
            this.panelTop.TabIndex = 277;
            // 
            // labelTituloCadTurma
            // 
            this.labelTituloCadTurma.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCadTurma.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTituloCadTurma.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.labelTituloCadTurma.ForeColor = System.Drawing.Color.Salmon;
            this.labelTituloCadTurma.Location = new System.Drawing.Point(144, 0);
            this.labelTituloCadTurma.Name = "labelTituloCadTurma";
            this.labelTituloCadTurma.Size = new System.Drawing.Size(935, 61);
            this.labelTituloCadTurma.TabIndex = 84;
            this.labelTituloCadTurma.Text = "SISTEMA DE CONTROLE INTERNO DO REINO | PESQUISAR TURMA";
            this.labelTituloCadTurma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.icon_voltar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1242, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 61);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbNomeAluno);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rdbPesqTurma);
            this.groupBox1.Controls.Add(this.rbtPesqNomeCurso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(485, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 66);
            this.groupBox1.TabIndex = 282;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // rdbNomeAluno
            // 
            this.rdbNomeAluno.AutoSize = true;
            this.rdbNomeAluno.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbNomeAluno.Location = new System.Drawing.Point(280, 26);
            this.rdbNomeAluno.Name = "rdbNomeAluno";
            this.rdbNomeAluno.Size = new System.Drawing.Size(136, 37);
            this.rdbNomeAluno.TabIndex = 247;
            this.rdbNomeAluno.TabStop = true;
            this.rdbNomeAluno.Text = "Nome do Aluno";
            this.rdbNomeAluno.UseVisualStyleBackColor = true;
            this.rdbNomeAluno.CheckedChanged += new System.EventHandler(this.rdbNomeAluno_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPesquisa);
            this.panel1.Controls.Add(this.buttonBuscarAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(422, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 37);
            this.panel1.TabIndex = 246;
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Location = new System.Drawing.Point(0, 0);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(403, 33);
            this.cbPesquisa.TabIndex = 245;
            // 
            // buttonBuscarAluno
            // 
            this.buttonBuscarAluno.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscarAluno.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.icon_pesquisar1;
            this.buttonBuscarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarAluno.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonBuscarAluno.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuscarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarAluno.Location = new System.Drawing.Point(403, 0);
            this.buttonBuscarAluno.Name = "buttonBuscarAluno";
            this.buttonBuscarAluno.Size = new System.Drawing.Size(38, 37);
            this.buttonBuscarAluno.TabIndex = 244;
            this.buttonBuscarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarAluno.UseVisualStyleBackColor = false;
            this.buttonBuscarAluno.Click += new System.EventHandler(this.buttonBuscarAluno_Click);
            // 
            // rdbPesqTurma
            // 
            this.rdbPesqTurma.AutoSize = true;
            this.rdbPesqTurma.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbPesqTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbPesqTurma.Location = new System.Drawing.Point(140, 26);
            this.rdbPesqTurma.Name = "rdbPesqTurma";
            this.rdbPesqTurma.Size = new System.Drawing.Size(140, 37);
            this.rdbPesqTurma.TabIndex = 245;
            this.rdbPesqTurma.TabStop = true;
            this.rdbPesqTurma.Text = "Nome da Turma";
            this.rdbPesqTurma.UseVisualStyleBackColor = true;
            this.rdbPesqTurma.CheckedChanged += new System.EventHandler(this.rdbPesqTurma_CheckedChanged);
            // 
            // rbtPesqNomeCurso
            // 
            this.rbtPesqNomeCurso.AutoSize = true;
            this.rbtPesqNomeCurso.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtPesqNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtPesqNomeCurso.Location = new System.Drawing.Point(3, 26);
            this.rbtPesqNomeCurso.Name = "rbtPesqNomeCurso";
            this.rbtPesqNomeCurso.Size = new System.Drawing.Size(137, 37);
            this.rbtPesqNomeCurso.TabIndex = 245;
            this.rbtPesqNomeCurso.TabStop = true;
            this.rbtPesqNomeCurso.Text = "Nome do Curso";
            this.rbtPesqNomeCurso.UseVisualStyleBackColor = true;
            this.rbtPesqNomeCurso.CheckedChanged += new System.EventHandler(this.rbtPesqNome_CheckedChanged);
            // 
            // panelLow
            // 
            this.panelLow.BackColor = System.Drawing.Color.Transparent;
            this.panelLow.Controls.Add(this.pictureBoxEsquerda);
            this.panelLow.Controls.Add(this.buttonSalvarCadastro);
            this.panelLow.Controls.Add(this.pictureBoxDireta);
            this.panelLow.Controls.Add(this.buttonCancelarCadastro);
            this.panelLow.Controls.Add(this.buttonLimparCadastro);
            this.panelLow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLow.Location = new System.Drawing.Point(0, 690);
            this.panelLow.Name = "panelLow";
            this.panelLow.Size = new System.Drawing.Size(1376, 72);
            this.panelLow.TabIndex = 283;
            // 
            // pictureBoxEsquerda
            // 
            this.pictureBoxEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEsquerda.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.icon_setaEsquerda1;
            this.pictureBoxEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEsquerda.Location = new System.Drawing.Point(423, 9);
            this.pictureBoxEsquerda.Name = "pictureBoxEsquerda";
            this.pictureBoxEsquerda.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxEsquerda.TabIndex = 225;
            this.pictureBoxEsquerda.TabStop = false;
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
            this.buttonSalvarCadastro.Location = new System.Drawing.Point(1061, 0);
            this.buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            this.buttonSalvarCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonSalvarCadastro.TabIndex = 56;
            this.buttonSalvarCadastro.Text = "&Salvar";
            this.buttonSalvarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvarCadastro.UseVisualStyleBackColor = false;
            // 
            // pictureBoxDireta
            // 
            this.pictureBoxDireta.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDireta.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.icon_setaDireita;
            this.pictureBoxDireta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDireta.Location = new System.Drawing.Point(489, 9);
            this.pictureBoxDireta.Name = "pictureBoxDireta";
            this.pictureBoxDireta.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxDireta.TabIndex = 224;
            this.pictureBoxDireta.TabStop = false;
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
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(1166, 0);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonCancelarCadastro.TabIndex = 57;
            this.buttonCancelarCadastro.Text = "&Cancelar";
            this.buttonCancelarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
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
            this.buttonLimparCadastro.Location = new System.Drawing.Point(1271, 0);
            this.buttonLimparCadastro.Name = "buttonLimparCadastro";
            this.buttonLimparCadastro.Size = new System.Drawing.Size(105, 72);
            this.buttonLimparCadastro.TabIndex = 58;
            this.buttonLimparCadastro.Text = "&Limpar";
            this.buttonLimparCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimparCadastro.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dataGridViewTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTurma.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Turma,
            this.Turma,
            this.Codigo_Curso,
            this.Curso,
            this.Codigo_Aluno,
            this.Aluno,
            this.Quantidade_Faltas,
            this.Codigo_Funcionario,
            this.Funcionario,
            this.Horario,
            this.Inicio,
            this.Termino});
            this.dataGridViewTurma.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.Size = new System.Drawing.Size(1336, 545);
            this.dataGridViewTurma.TabIndex = 284;
            // 
            // Codigo_Turma
            // 
            this.Codigo_Turma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo_Turma.DataPropertyName = "CodTurma";
            this.Codigo_Turma.HeaderText = "Código da Turma";
            this.Codigo_Turma.Name = "Codigo_Turma";
            this.Codigo_Turma.ReadOnly = true;
            this.Codigo_Turma.Width = 93;
            // 
            // Turma
            // 
            this.Turma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Turma.DataPropertyName = "txtTurma";
            this.Turma.HeaderText = "Nome da Turma";
            this.Turma.Name = "Turma";
            this.Turma.ReadOnly = true;
            this.Turma.Width = 118;
            // 
            // Codigo_Curso
            // 
            this.Codigo_Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo_Curso.DataPropertyName = "CodCurso";
            this.Codigo_Curso.HeaderText = "Código do Curso";
            this.Codigo_Curso.Name = "Codigo_Curso";
            this.Codigo_Curso.ReadOnly = true;
            this.Codigo_Curso.Width = 94;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Curso.DataPropertyName = "cboCurso";
            this.Curso.HeaderText = "Nome do Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 118;
            // 
            // Codigo_Aluno
            // 
            this.Codigo_Aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo_Aluno.DataPropertyName = "CodAluno";
            this.Codigo_Aluno.HeaderText = "Código do Aluno";
            this.Codigo_Aluno.Name = "Codigo_Aluno";
            this.Codigo_Aluno.ReadOnly = true;
            this.Codigo_Aluno.Width = 94;
            // 
            // Aluno
            // 
            this.Aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Aluno.DataPropertyName = "cboAluno";
            this.Aluno.HeaderText = "Nome do aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 87;
            // 
            // Quantidade_Faltas
            // 
            this.Quantidade_Faltas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantidade_Faltas.DataPropertyName = "txtQtdFaltas";
            this.Quantidade_Faltas.HeaderText = "Quantidade de faltas";
            this.Quantidade_Faltas.Name = "Quantidade_Faltas";
            this.Quantidade_Faltas.ReadOnly = true;
            this.Quantidade_Faltas.Width = 115;
            // 
            // Codigo_Funcionario
            // 
            this.Codigo_Funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo_Funcionario.DataPropertyName = "CodFuncionario";
            this.Codigo_Funcionario.HeaderText = "Código do Funcionário";
            this.Codigo_Funcionario.Name = "Codigo_Funcionario";
            this.Codigo_Funcionario.ReadOnly = true;
            this.Codigo_Funcionario.Width = 156;
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Funcionario.DataPropertyName = "cboFuncionario";
            this.Funcionario.HeaderText = "Nome do Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            this.Funcionario.Width = 149;
            // 
            // Horario
            // 
            this.Horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Horario.DataPropertyName = "cboHorario";
            this.Horario.HeaderText = "Horário do Curso";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 93;
            // 
            // Inicio
            // 
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Inicio.DataPropertyName = "txtInicio";
            this.Inicio.HeaderText = "Data Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 87;
            // 
            // Termino
            // 
            this.Termino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Termino.DataPropertyName = "txtTermino";
            this.Termino.HeaderText = "Data Término";
            this.Termino.Name = "Termino";
            this.Termino.ReadOnly = true;
            this.Termino.Width = 103;
            // 
            // banco_reinoDataSet1
            // 
            this.banco_reinoDataSet1.DataSetName = "banco_reinoDataSet1";
            this.banco_reinoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBTurmaBindingSource
            // 
            this.tBTurmaBindingSource.DataMember = "TB_Turma";
            this.tBTurmaBindingSource.DataSource = this.banco_reinoDataSet1;
            // 
            // tB_TurmaTableAdapter
            // 
            this.tB_TurmaTableAdapter.ClearBeforeFill = true;
            // 
            // FormPesquisarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 762);
            this.Controls.Add(this.dataGridViewTurma);
            this.Controls.Add(this.panelLow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesquisarTurma";
            this.Text = "Sistema de Controle Interno | Reino da Garotada de Poá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPesquisarTurma_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDireta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_reinoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTurmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Label labelTituloCadTurma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscarAluno;
        public System.Windows.Forms.RadioButton rdbPesqTurma;
        public System.Windows.Forms.RadioButton rbtPesqNomeCurso;
        private System.Windows.Forms.Panel panelLow;
        private System.Windows.Forms.PictureBox pictureBoxEsquerda;
        private System.Windows.Forms.Button buttonSalvarCadastro;
        private System.Windows.Forms.PictureBox pictureBoxDireta;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonLimparCadastro;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        public System.Windows.Forms.RadioButton rdbNomeAluno;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private banco_reinoDataSet1 banco_reinoDataSet1;
        private System.Windows.Forms.BindingSource tBTurmaBindingSource;
        private banco_reinoDataSet1TableAdapters.TB_TurmaTableAdapter tB_TurmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termino;
    }
}
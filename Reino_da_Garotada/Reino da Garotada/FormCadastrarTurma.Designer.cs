namespace Reino_da_Garotada
{
    partial class FormCadastrarTurma
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
            this.groupBoxCurso = new System.Windows.Forms.GroupBox();
            this.cboHorario = new System.Windows.Forms.TextBox();
            this.CodFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.labelCodfunc = new System.Windows.Forms.Label();
            this.labelFuncionario = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.tBFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_reinoDataSet1 = new Reino_da_Garotada.banco_reinoDataSet1();
            this.CodCurso = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.tBCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelHorário = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.DateTimePicker();
            this.labelTermino = new System.Windows.Forms.Label();
            this.txtTermino = new System.Windows.Forms.DateTimePicker();
            this.labelQtdFaltas = new System.Windows.Forms.Label();
            this.txtQtdFaltas = new System.Windows.Forms.MaskedTextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.labelTituloCadTurma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLow = new System.Windows.Forms.Panel();
            this.buttonSalvarCadastro = new System.Windows.Forms.Button();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.buttonLimparCadastro = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.CodTurma = new System.Windows.Forms.MaskedTextBox();
            this.labelCodTurma = new System.Windows.Forms.Label();
            this.labelTxtTurma = new System.Windows.Forms.Label();
            this.dtDadosAluno = new System.Windows.Forms.DataGridView();
            this.CadastroAlunoTurma = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRGAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPFAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdadeAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSemestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDtNasctoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVerifica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_CursosTableAdapter = new Reino_da_Garotada.banco_reinoDataSet1TableAdapters.TB_CursosTableAdapter();
            this.tBCursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FuncionariosTableAdapter = new Reino_da_Garotada.banco_reinoDataSet1TableAdapters.TB_FuncionariosTableAdapter();
            this.groupBoxCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_reinoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLow.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDadosAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCursosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCurso
            // 
            this.groupBoxCurso.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCurso.Controls.Add(this.cboHorario);
            this.groupBoxCurso.Controls.Add(this.CodFuncionario);
            this.groupBoxCurso.Controls.Add(this.labelCodfunc);
            this.groupBoxCurso.Controls.Add(this.labelFuncionario);
            this.groupBoxCurso.Controls.Add(this.cboFuncionario);
            this.groupBoxCurso.Controls.Add(this.CodCurso);
            this.groupBoxCurso.Controls.Add(this.label3);
            this.groupBoxCurso.Controls.Add(this.labelCurso);
            this.groupBoxCurso.Controls.Add(this.cboCurso);
            this.groupBoxCurso.Controls.Add(this.labelHorário);
            this.groupBoxCurso.Controls.Add(this.labelInicio);
            this.groupBoxCurso.Controls.Add(this.txtInicio);
            this.groupBoxCurso.Controls.Add(this.labelTermino);
            this.groupBoxCurso.Controls.Add(this.txtTermino);
            this.groupBoxCurso.Controls.Add(this.labelQtdFaltas);
            this.groupBoxCurso.Controls.Add(this.txtQtdFaltas);
            this.groupBoxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBoxCurso.Location = new System.Drawing.Point(12, 129);
            this.groupBoxCurso.Name = "groupBoxCurso";
            this.groupBoxCurso.Size = new System.Drawing.Size(1339, 139);
            this.groupBoxCurso.TabIndex = 260;
            this.groupBoxCurso.TabStop = false;
            this.groupBoxCurso.Text = "Dados de Curso";
            // 
            // cboHorario
            // 
            this.cboHorario.Enabled = false;
            this.cboHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboHorario.Location = new System.Drawing.Point(79, 92);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(262, 26);
            this.cboHorario.TabIndex = 277;
            // 
            // CodFuncionario
            // 
            this.CodFuncionario.Enabled = false;
            this.CodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodFuncionario.Location = new System.Drawing.Point(651, 28);
            this.CodFuncionario.Mask = "00000";
            this.CodFuncionario.Name = "CodFuncionario";
            this.CodFuncionario.Size = new System.Drawing.Size(58, 26);
            this.CodFuncionario.TabIndex = 279;
            // 
            // labelCodfunc
            // 
            this.labelCodfunc.BackColor = System.Drawing.Color.Transparent;
            this.labelCodfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCodfunc.Location = new System.Drawing.Point(477, 30);
            this.labelCodfunc.Name = "labelCodfunc";
            this.labelCodfunc.Size = new System.Drawing.Size(168, 23);
            this.labelCodfunc.TabIndex = 280;
            this.labelCodfunc.Text = "Código do Funcionário";
            this.labelCodfunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFuncionario
            // 
            this.labelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFuncionario.Location = new System.Drawing.Point(719, 30);
            this.labelFuncionario.Name = "labelFuncionario";
            this.labelFuncionario.Size = new System.Drawing.Size(92, 22);
            this.labelFuncionario.TabIndex = 278;
            this.labelFuncionario.Text = "Professor";
            this.labelFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DataSource = this.tBFuncionariosBindingSource;
            this.cboFuncionario.DisplayMember = "txtNome";
            this.cboFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(817, 28);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(332, 28);
            this.cboFuncionario.TabIndex = 3;
            this.cboFuncionario.ValueMember = "CodFuncionario";
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // tBFuncionariosBindingSource
            // 
            this.tBFuncionariosBindingSource.DataMember = "TB_Funcionarios";
            this.tBFuncionariosBindingSource.DataSource = this.banco_reinoDataSet1;
            // 
            // banco_reinoDataSet1
            // 
            this.banco_reinoDataSet1.DataSetName = "banco_reinoDataSet1";
            this.banco_reinoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CodCurso
            // 
            this.CodCurso.Enabled = false;
            this.CodCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodCurso.Location = new System.Drawing.Point(137, 28);
            this.CodCurso.Mask = "00000";
            this.CodCurso.Name = "CodCurso";
            this.CodCurso.Size = new System.Drawing.Size(58, 26);
            this.CodCurso.TabIndex = 275;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 276;
            this.label3.Text = "Código do Curso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCurso
            // 
            this.labelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurso.Location = new System.Drawing.Point(201, 30);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(54, 22);
            this.labelCurso.TabIndex = 124;
            this.labelCurso.Text = "Curso";
            this.labelCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCurso
            // 
            this.cboCurso.DataSource = this.tBCursosBindingSource;
            this.cboCurso.DisplayMember = "txtCurso";
            this.cboCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(262, 28);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(209, 28);
            this.cboCurso.TabIndex = 2;
            this.cboCurso.ValueMember = "CodCurso";
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // tBCursosBindingSource
            // 
            this.tBCursosBindingSource.DataMember = "TB_Cursos";
            this.tBCursosBindingSource.DataSource = this.banco_reinoDataSet1;
            // 
            // labelHorário
            // 
            this.labelHorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHorário.Location = new System.Drawing.Point(8, 92);
            this.labelHorário.Name = "labelHorário";
            this.labelHorário.Size = new System.Drawing.Size(65, 22);
            this.labelHorário.TabIndex = 125;
            this.labelHorário.Text = "Horario:";
            this.labelHorário.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInicio
            // 
            this.labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInicio.Location = new System.Drawing.Point(423, 92);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(47, 27);
            this.labelInicio.TabIndex = 22;
            this.labelInicio.Text = "Início";
            this.labelInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtInicio.Location = new System.Drawing.Point(470, 92);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(105, 26);
            this.txtInicio.TabIndex = 5;
            this.txtInicio.Validating += new System.ComponentModel.CancelEventHandler(this.txtInicio_Validating);
            // 
            // labelTermino
            // 
            this.labelTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTermino.Location = new System.Drawing.Point(630, 92);
            this.labelTermino.Name = "labelTermino";
            this.labelTermino.Size = new System.Drawing.Size(66, 27);
            this.labelTermino.TabIndex = 177;
            this.labelTermino.Text = "Término";
            this.labelTermino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTermino
            // 
            this.txtTermino.Enabled = false;
            this.txtTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTermino.Location = new System.Drawing.Point(702, 92);
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(105, 26);
            this.txtTermino.TabIndex = 6;
            // 
            // labelQtdFaltas
            // 
            this.labelQtdFaltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQtdFaltas.Location = new System.Drawing.Point(915, 92);
            this.labelQtdFaltas.Name = "labelQtdFaltas";
            this.labelQtdFaltas.Size = new System.Drawing.Size(166, 22);
            this.labelQtdFaltas.TabIndex = 127;
            this.labelQtdFaltas.Text = "Quantidade de Faltas";
            this.labelQtdFaltas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQtdFaltas
            // 
            this.txtQtdFaltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQtdFaltas.Location = new System.Drawing.Point(1087, 92);
            this.txtQtdFaltas.Mask = "0000";
            this.txtQtdFaltas.Name = "txtQtdFaltas";
            this.txtQtdFaltas.Size = new System.Drawing.Size(43, 26);
            this.txtQtdFaltas.TabIndex = 9;
            // 
            // txtTurma
            // 
            this.txtTurma.Enabled = false;
            this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTurma.Location = new System.Drawing.Point(202, 97);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(202, 26);
            this.txtTurma.TabIndex = 1;
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
            this.labelTituloCadTurma.Text = "SISTEMA DE CONTROLE INTERNO DO REINO | CADASTRAR TURMA";
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
            // panelLow
            // 
            this.panelLow.BackColor = System.Drawing.Color.Transparent;
            this.panelLow.Controls.Add(this.buttonSalvarCadastro);
            this.panelLow.Controls.Add(this.buttonCancelarCadastro);
            this.panelLow.Controls.Add(this.buttonLimparCadastro);
            this.panelLow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLow.Location = new System.Drawing.Point(0, 690);
            this.panelLow.Name = "panelLow";
            this.panelLow.Size = new System.Drawing.Size(1376, 72);
            this.panelLow.TabIndex = 262;
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
            this.buttonLimparCadastro.Click += new System.EventHandler(this.buttonLimparCadastro_Click);
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
            this.panelTop.TabIndex = 261;
            // 
            // CodTurma
            // 
            this.CodTurma.Enabled = false;
            this.CodTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodTurma.Location = new System.Drawing.Point(75, 97);
            this.CodTurma.Mask = "00000";
            this.CodTurma.Name = "CodTurma";
            this.CodTurma.Size = new System.Drawing.Size(58, 26);
            this.CodTurma.TabIndex = 263;
            // 
            // labelCodTurma
            // 
            this.labelCodTurma.BackColor = System.Drawing.Color.Transparent;
            this.labelCodTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCodTurma.Location = new System.Drawing.Point(8, 100);
            this.labelCodTurma.Name = "labelCodTurma";
            this.labelCodTurma.Size = new System.Drawing.Size(64, 20);
            this.labelCodTurma.TabIndex = 267;
            this.labelCodTurma.Text = "Código";
            this.labelCodTurma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTxtTurma
            // 
            this.labelTxtTurma.BackColor = System.Drawing.Color.Transparent;
            this.labelTxtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTxtTurma.Location = new System.Drawing.Point(139, 100);
            this.labelTxtTurma.Name = "labelTxtTurma";
            this.labelTxtTurma.Size = new System.Drawing.Size(57, 20);
            this.labelTxtTurma.TabIndex = 274;
            this.labelTxtTurma.Text = "Turma";
            this.labelTxtTurma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDadosAluno
            // 
            this.dtDadosAluno.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDadosAluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDadosAluno.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDadosAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtDadosAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDadosAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CadastroAlunoTurma,
            this.codAlunoDataGridViewTextBoxColumn,
            this.txtMatriculaDataGridViewTextBoxColumn,
            this.txtNomeAlunoDataGridViewTextBoxColumn,
            this.txtRGAlunoDataGridViewTextBoxColumn,
            this.txtCPFAlunoDataGridViewTextBoxColumn,
            this.txtIdadeAlunoDataGridViewTextBoxColumn,
            this.cboSemestreDataGridViewTextBoxColumn,
            this.txtDtCadastroDataGridViewTextBoxColumn,
            this.txtDtNasctoDataGridViewTextBoxColumn,
            this.cboSexoDataGridViewTextBoxColumn});
            this.dtDadosAluno.GridColor = System.Drawing.Color.White;
            this.dtDadosAluno.Location = new System.Drawing.Point(12, 349);
            this.dtDadosAluno.Name = "dtDadosAluno";
            this.dtDadosAluno.Size = new System.Drawing.Size(1352, 335);
            this.dtDadosAluno.TabIndex = 275;
            this.dtDadosAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDadosAluno_CellContentClick);
            // 
            // CadastroAlunoTurma
            // 
            this.CadastroAlunoTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CadastroAlunoTurma.HeaderText = "CADASTRAR NA TURMA";
            this.CadastroAlunoTurma.Name = "CadastroAlunoTurma";
            this.CadastroAlunoTurma.Width = 108;
            // 
            // codAlunoDataGridViewTextBoxColumn
            // 
            this.codAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codAlunoDataGridViewTextBoxColumn.DataPropertyName = "CodAluno";
            this.codAlunoDataGridViewTextBoxColumn.HeaderText = "CÓDIGO DO ALUNO";
            this.codAlunoDataGridViewTextBoxColumn.Name = "codAlunoDataGridViewTextBoxColumn";
            this.codAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAlunoDataGridViewTextBoxColumn.Width = 103;
            // 
            // txtMatriculaDataGridViewTextBoxColumn
            // 
            this.txtMatriculaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtMatriculaDataGridViewTextBoxColumn.DataPropertyName = "txtMatricula";
            this.txtMatriculaDataGridViewTextBoxColumn.HeaderText = "NUMERO DA MATRICULA";
            this.txtMatriculaDataGridViewTextBoxColumn.Name = "txtMatriculaDataGridViewTextBoxColumn";
            this.txtMatriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtMatriculaDataGridViewTextBoxColumn.Width = 173;
            // 
            // txtNomeAlunoDataGridViewTextBoxColumn
            // 
            this.txtNomeAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtNomeAlunoDataGridViewTextBoxColumn.DataPropertyName = "txtNomeAluno";
            this.txtNomeAlunoDataGridViewTextBoxColumn.HeaderText = "NOME DO ALUNO";
            this.txtNomeAlunoDataGridViewTextBoxColumn.Name = "txtNomeAlunoDataGridViewTextBoxColumn";
            this.txtNomeAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtNomeAlunoDataGridViewTextBoxColumn.Width = 132;
            // 
            // txtRGAlunoDataGridViewTextBoxColumn
            // 
            this.txtRGAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtRGAlunoDataGridViewTextBoxColumn.DataPropertyName = "txtRGAluno";
            this.txtRGAlunoDataGridViewTextBoxColumn.HeaderText = "RG DO ALUNO";
            this.txtRGAlunoDataGridViewTextBoxColumn.Name = "txtRGAlunoDataGridViewTextBoxColumn";
            this.txtRGAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtRGAlunoDataGridViewTextBoxColumn.Width = 114;
            // 
            // txtCPFAlunoDataGridViewTextBoxColumn
            // 
            this.txtCPFAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtCPFAlunoDataGridViewTextBoxColumn.DataPropertyName = "txtCPFAluno";
            this.txtCPFAlunoDataGridViewTextBoxColumn.HeaderText = "CPF DO ALUNO";
            this.txtCPFAlunoDataGridViewTextBoxColumn.Name = "txtCPFAlunoDataGridViewTextBoxColumn";
            this.txtCPFAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtCPFAlunoDataGridViewTextBoxColumn.Width = 120;
            // 
            // txtIdadeAlunoDataGridViewTextBoxColumn
            // 
            this.txtIdadeAlunoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtIdadeAlunoDataGridViewTextBoxColumn.DataPropertyName = "txtIdadeAluno";
            this.txtIdadeAlunoDataGridViewTextBoxColumn.HeaderText = "IDADE";
            this.txtIdadeAlunoDataGridViewTextBoxColumn.Name = "txtIdadeAlunoDataGridViewTextBoxColumn";
            this.txtIdadeAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtIdadeAlunoDataGridViewTextBoxColumn.Width = 73;
            // 
            // cboSemestreDataGridViewTextBoxColumn
            // 
            this.cboSemestreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cboSemestreDataGridViewTextBoxColumn.DataPropertyName = "cboSemestre";
            this.cboSemestreDataGridViewTextBoxColumn.HeaderText = "SEMESTRE";
            this.cboSemestreDataGridViewTextBoxColumn.Name = "cboSemestreDataGridViewTextBoxColumn";
            this.cboSemestreDataGridViewTextBoxColumn.ReadOnly = true;
            this.cboSemestreDataGridViewTextBoxColumn.Width = 106;
            // 
            // txtDtCadastroDataGridViewTextBoxColumn
            // 
            this.txtDtCadastroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtDtCadastroDataGridViewTextBoxColumn.DataPropertyName = "txtDtCadastro";
            this.txtDtCadastroDataGridViewTextBoxColumn.HeaderText = "DATA DE CADASTRO";
            this.txtDtCadastroDataGridViewTextBoxColumn.Name = "txtDtCadastroDataGridViewTextBoxColumn";
            this.txtDtCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtDtCadastroDataGridViewTextBoxColumn.Width = 150;
            // 
            // txtDtNasctoDataGridViewTextBoxColumn
            // 
            this.txtDtNasctoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtDtNasctoDataGridViewTextBoxColumn.DataPropertyName = "txtDtNascto";
            this.txtDtNasctoDataGridViewTextBoxColumn.HeaderText = "DATA DE NASCIMENTO";
            this.txtDtNasctoDataGridViewTextBoxColumn.Name = "txtDtNasctoDataGridViewTextBoxColumn";
            this.txtDtNasctoDataGridViewTextBoxColumn.ReadOnly = true;
            this.txtDtNasctoDataGridViewTextBoxColumn.Width = 163;
            // 
            // cboSexoDataGridViewTextBoxColumn
            // 
            this.cboSexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cboSexoDataGridViewTextBoxColumn.DataPropertyName = "cboSexo";
            this.cboSexoDataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.cboSexoDataGridViewTextBoxColumn.Name = "cboSexoDataGridViewTextBoxColumn";
            this.cboSexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cboSexoDataGridViewTextBoxColumn.Width = 70;
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVerifica.Location = new System.Drawing.Point(12, 321);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(64, 25);
            this.lblVerifica.TabIndex = 277;
            this.lblVerifica.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 276;
            this.label1.Text = "Escolha abaixo os alunos que participarão da turma";
            // 
            // tB_CursosTableAdapter
            // 
            this.tB_CursosTableAdapter.ClearBeforeFill = true;
            // 
            // tBCursosBindingSource1
            // 
            this.tBCursosBindingSource1.DataMember = "TB_Cursos";
            this.tBCursosBindingSource1.DataSource = this.banco_reinoDataSet1;
            // 
            // tB_FuncionariosTableAdapter
            // 
            this.tB_FuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 762);
            this.Controls.Add(this.lblVerifica);
            this.Controls.Add(this.dtDadosAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTxtTurma);
            this.Controls.Add(this.CodTurma);
            this.Controls.Add(this.labelCodTurma);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.groupBoxCurso);
            this.Controls.Add(this.panelLow);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrarTurma";
            this.Text = "Sistema de Controle Interno | Reino da Garotada de Poá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastrarTurma_FormClosed);
            this.Load += new System.EventHandler(this.FormCadastrarTurma_Load);
            this.groupBoxCurso.ResumeLayout(false);
            this.groupBoxCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_reinoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLow.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDadosAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCursosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCurso;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label labelTermino;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.DateTimePicker txtInicio;
        private System.Windows.Forms.DateTimePicker txtTermino;
        private System.Windows.Forms.MaskedTextBox txtQtdFaltas;
        private System.Windows.Forms.Label labelQtdFaltas;
        private System.Windows.Forms.Label labelHorário;
        public System.Windows.Forms.Label labelTituloCadTurma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelLow;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.Button buttonLimparCadastro;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MaskedTextBox CodTurma;
        private System.Windows.Forms.Label labelCodTurma;
        private System.Windows.Forms.Label labelTxtTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CodFuncionario;
        private System.Windows.Forms.Label labelCodfunc;
        private System.Windows.Forms.Label labelFuncionario;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.MaskedTextBox CodCurso;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.DataGridView dtDadosAluno;
        private System.Windows.Forms.Label lblVerifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CadastroAlunoTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomeAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRGAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCPFAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdadeAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboSemestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDtNasctoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboSexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cboHorario;
        private banco_reinoDataSet1 banco_reinoDataSet1;
        private System.Windows.Forms.BindingSource tBCursosBindingSource;
        private banco_reinoDataSet1TableAdapters.TB_CursosTableAdapter tB_CursosTableAdapter;
        private System.Windows.Forms.BindingSource tBCursosBindingSource1;
        private System.Windows.Forms.BindingSource tBFuncionariosBindingSource;
        private banco_reinoDataSet1TableAdapters.TB_FuncionariosTableAdapter tB_FuncionariosTableAdapter;
        private System.Windows.Forms.Button buttonSalvarCadastro;
    }
}
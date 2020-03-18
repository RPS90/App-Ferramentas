namespace SecretarySimulator
{
    partial class FormPrincipal
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
            this.btAgenda = new System.Windows.Forms.Button();
            this.btCalc = new System.Windows.Forms.Button();
            this.btQuiz = new System.Windows.Forms.Button();
            this.btTarefas = new System.Windows.Forms.Button();
            this.btBancodados = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_Menu = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_iniciar2 = new System.Windows.Forms.PictureBox();
            this.BT_iniciar = new System.Windows.Forms.PictureBox();
            this.Tela_principal = new System.Windows.Forms.PictureBox();
            this.gb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BT_iniciar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tela_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgenda
            // 
            this.btAgenda.Location = new System.Drawing.Point(19, 21);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(75, 75);
            this.btAgenda.TabIndex = 5;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(100, 21);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(75, 75);
            this.btCalc.TabIndex = 6;
            this.btCalc.Text = "Calculadora Financeira";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btQuiz
            // 
            this.btQuiz.Location = new System.Drawing.Point(181, 21);
            this.btQuiz.Name = "btQuiz";
            this.btQuiz.Size = new System.Drawing.Size(75, 75);
            this.btQuiz.TabIndex = 7;
            this.btQuiz.Text = "Quiz";
            this.btQuiz.UseVisualStyleBackColor = true;
            this.btQuiz.Click += new System.EventHandler(this.btQuiz_Click);
            // 
            // btTarefas
            // 
            this.btTarefas.Location = new System.Drawing.Point(262, 21);
            this.btTarefas.Name = "btTarefas";
            this.btTarefas.Size = new System.Drawing.Size(75, 75);
            this.btTarefas.TabIndex = 8;
            this.btTarefas.Text = "Tarefas";
            this.btTarefas.UseVisualStyleBackColor = true;
            this.btTarefas.Click += new System.EventHandler(this.btTarefas_Click);
            // 
            // btBancodados
            // 
            this.btBancodados.Location = new System.Drawing.Point(343, 21);
            this.btBancodados.Name = "btBancodados";
            this.btBancodados.Size = new System.Drawing.Size(75, 75);
            this.btBancodados.TabIndex = 9;
            this.btBancodados.Text = "Banco de Dados";
            this.btBancodados.UseVisualStyleBackColor = true;
            this.btBancodados.Click += new System.EventHandler(this.btBancodados_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(424, 21);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 75);
            this.button18.TabIndex = 10;
            this.button18.Text = "Etc...";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Location = new System.Drawing.Point(936, 696);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(28, 13);
            this.lblRelogio.TabIndex = 11;
            this.lblRelogio.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gb_Menu
            // 
            this.gb_Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gb_Menu.BackgroundImage = global::SecretarySimulator.Properties.Resources.Menu_iniciar_branco;
            this.gb_Menu.Controls.Add(this.lblNome);
            this.gb_Menu.Controls.Add(this.btSair);
            this.gb_Menu.Controls.Add(this.button8);
            this.gb_Menu.Controls.Add(this.button7);
            this.gb_Menu.Controls.Add(this.button6);
            this.gb_Menu.Controls.Add(this.button5);
            this.gb_Menu.Controls.Add(this.button4);
            this.gb_Menu.Controls.Add(this.button3);
            this.gb_Menu.Controls.Add(this.button2);
            this.gb_Menu.Controls.Add(this.button1);
            this.gb_Menu.Enabled = false;
            this.gb_Menu.Location = new System.Drawing.Point(12, 203);
            this.gb_Menu.Name = "gb_Menu";
            this.gb_Menu.Size = new System.Drawing.Size(441, 485);
            this.gb_Menu.TabIndex = 4;
            this.gb_Menu.TabStop = false;
            this.gb_Menu.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(328, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(270, 442);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(85, 23);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Desligar";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(16, 397);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(237, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(16, 343);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(237, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(16, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(237, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(16, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(16, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(16, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(16, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BT_iniciar2
            // 
            this.BT_iniciar2.Image = global::SecretarySimulator.Properties.Resources.BT_iniciar2_v2;
            this.BT_iniciar2.Location = new System.Drawing.Point(12, 683);
            this.BT_iniciar2.Name = "BT_iniciar2";
            this.BT_iniciar2.Size = new System.Drawing.Size(54, 35);
            this.BT_iniciar2.TabIndex = 3;
            this.BT_iniciar2.TabStop = false;
            this.BT_iniciar2.Click += new System.EventHandler(this.BT_iniciar2_Click);
            // 
            // BT_iniciar
            // 
            this.BT_iniciar.Image = global::SecretarySimulator.Properties.Resources.BT_iniciar1_v2;
            this.BT_iniciar.Location = new System.Drawing.Point(12, 683);
            this.BT_iniciar.Name = "BT_iniciar";
            this.BT_iniciar.Size = new System.Drawing.Size(54, 35);
            this.BT_iniciar.TabIndex = 1;
            this.BT_iniciar.TabStop = false;
            this.BT_iniciar.Click += new System.EventHandler(this.BT_iniciar_Click);
            this.BT_iniciar.MouseEnter += new System.EventHandler(this.BT_iniciar_MouseEnter);
            this.BT_iniciar.MouseLeave += new System.EventHandler(this.BT_iniciar_MouseLeave);
            // 
            // Tela_principal
            // 
            this.Tela_principal.Image = global::SecretarySimulator.Properties.Resources.Layout_Base_984x706_v3;
            this.Tela_principal.InitialImage = null;
            this.Tela_principal.Location = new System.Drawing.Point(12, 12);
            this.Tela_principal.Name = "Tela_principal";
            this.Tela_principal.Size = new System.Drawing.Size(984, 706);
            this.Tela_principal.TabIndex = 0;
            this.Tela_principal.TabStop = false;
            this.Tela_principal.Click += new System.EventHandler(this.Tela_principal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecretarySimulator.Properties.Resources.Preto;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btBancodados);
            this.Controls.Add(this.btTarefas);
            this.Controls.Add(this.btQuiz);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.gb_Menu);
            this.Controls.Add(this.BT_iniciar2);
            this.Controls.Add(this.BT_iniciar);
            this.Controls.Add(this.Tela_principal);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "EMV - Escritório Modelo Virtual 1.0";
            this.gb_Menu.ResumeLayout(false);
            this.gb_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BT_iniciar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tela_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Tela_principal;
        private System.Windows.Forms.PictureBox BT_iniciar;
        private System.Windows.Forms.PictureBox BT_iniciar2;
        private System.Windows.Forms.GroupBox gb_Menu;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btQuiz;
        private System.Windows.Forms.Button btTarefas;
        private System.Windows.Forms.Button btBancodados;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNome;
    }
}


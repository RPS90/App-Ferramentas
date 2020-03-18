namespace Reino_da_Garotada
{
    partial class FormLogin
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
            this.labelIdent = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.linkLabelEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.linkLabelEsqueciUsuario = new System.Windows.Forms.LinkLabel();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBoxSenha = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.buttonAcessar = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelRodape = new System.Windows.Forms.Label();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdent
            // 
            this.labelIdent.AutoSize = true;
            this.labelIdent.BackColor = System.Drawing.Color.Transparent;
            this.labelIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdent.ForeColor = System.Drawing.Color.Salmon;
            this.labelIdent.Location = new System.Drawing.Point(109, 120);
            this.labelIdent.Name = "labelIdent";
            this.labelIdent.Size = new System.Drawing.Size(317, 18);
            this.labelIdent.TabIndex = 31;
            this.labelIdent.Text = "Identifique-se, por favor, para utilizar o sistema ";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelSenha.Location = new System.Drawing.Point(41, 91);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(76, 25);
            this.labelSenha.TabIndex = 15;
            this.labelSenha.Text = "Senha:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelUsuario.Location = new System.Drawing.Point(32, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(85, 25);
            this.labelUsuario.TabIndex = 14;
            this.labelUsuario.Text = "Usuário:";
            // 
            // linkLabelEsqueciSenha
            // 
            this.linkLabelEsqueciSenha.AutoSize = true;
            this.linkLabelEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEsqueciSenha.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelEsqueciSenha.Location = new System.Drawing.Point(225, 121);
            this.linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            this.linkLabelEsqueciSenha.Size = new System.Drawing.Size(145, 17);
            this.linkLabelEsqueciSenha.TabIndex = 11;
            this.linkLabelEsqueciSenha.TabStop = true;
            this.linkLabelEsqueciSenha.Text = "Esqueci minha Senha";
            // 
            // linkLabelEsqueciUsuario
            // 
            this.linkLabelEsqueciUsuario.AutoSize = true;
            this.linkLabelEsqueciUsuario.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEsqueciUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEsqueciUsuario.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelEsqueciUsuario.Location = new System.Drawing.Point(228, 50);
            this.linkLabelEsqueciUsuario.Name = "linkLabelEsqueciUsuario";
            this.linkLabelEsqueciUsuario.Size = new System.Drawing.Size(142, 17);
            this.linkLabelEsqueciUsuario.TabIndex = 11;
            this.linkLabelEsqueciUsuario.TabStop = true;
            this.linkLabelEsqueciUsuario.Text = "Esqueci meu Usuário";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLogin.Controls.Add(this.labelSenha);
            this.groupBoxLogin.Controls.Add(this.labelUsuario);
            this.groupBoxLogin.Controls.Add(this.pictureBoxSenha);
            this.groupBoxLogin.Controls.Add(this.pictureBoxUsuario);
            this.groupBoxLogin.Controls.Add(this.linkLabelEsqueciSenha);
            this.groupBoxLogin.Controls.Add(this.linkLabelEsqueciUsuario);
            this.groupBoxLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Location = new System.Drawing.Point(66, 141);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(391, 147);
            this.groupBoxLogin.TabIndex = 33;
            this.groupBoxLogin.TabStop = false;
            // 
            // pictureBoxSenha
            // 
            this.pictureBoxSenha.Image = global::Reino_da_Garotada.Properties.Resources.logo_senha;
            this.pictureBoxSenha.Location = new System.Drawing.Point(6, 88);
            this.pictureBoxSenha.Name = "pictureBoxSenha";
            this.pictureBoxSenha.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSenha.TabIndex = 13;
            this.pictureBoxSenha.TabStop = false;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::Reino_da_Garotada.Properties.Resources.logo_usuario;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(6, 15);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 12;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(123, 89);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(247, 29);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(123, 18);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(247, 29);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsuario_KeyDown);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.labelBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelBemVindo.ForeColor = System.Drawing.Color.Salmon;
            this.labelBemVindo.Location = new System.Drawing.Point(184, 92);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(155, 25);
            this.labelBemVindo.TabIndex = 30;
            this.labelBemVindo.Text = "Seja Bem vindo!";
            // 
            // buttonAcessar
            // 
            this.buttonAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcessar.Image = global::Reino_da_Garotada.Properties.Resources.icon_entrar;
            this.buttonAcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcessar.Location = new System.Drawing.Point(113, 308);
            this.buttonAcessar.Name = "buttonAcessar";
            this.buttonAcessar.Size = new System.Drawing.Size(141, 57);
            this.buttonAcessar.TabIndex = 3;
            this.buttonAcessar.Text = "&Acessar";
            this.buttonAcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAcessar.UseVisualStyleBackColor = true;
            this.buttonAcessar.Click += new System.EventHandler(this.buttonAcessar_Click);
            // 
            // tempo
            // 
            this.tempo.Interval = 1000;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.timeLabel.Location = new System.Drawing.Point(267, 351);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 36;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Salmon;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Black;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(230, 30);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRodape
            // 
            this.labelRodape.BackColor = System.Drawing.Color.Salmon;
            this.labelRodape.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRodape.ForeColor = System.Drawing.Color.Black;
            this.labelRodape.Location = new System.Drawing.Point(229, 0);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(310, 30);
            this.labelRodape.TabIndex = 4;
            this.labelRodape.Text = "FATEC Itaquaquecetuba - Copyright 2018";
            this.labelRodape.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.LightGreen;
            this.panelRodape.Controls.Add(this.labelStatus);
            this.panelRodape.Controls.Add(this.labelRodape);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 381);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(539, 30);
            this.panelRodape.TabIndex = 37;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Image = global::Reino_da_Garotada.Properties.Resources.icon_cancelar;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(260, 308);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(141, 57);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.Image = global::Reino_da_Garotada.Properties.Resources.icon_login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(356, 19);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 29;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Reino_da_Garotada.Properties.Resources.reino_login1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(186, 7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 82);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reino_da_Garotada.Properties.Resources.background_login1;
            this.ClientSize = new System.Drawing.Size(539, 411);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelIdent);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.labelBemVindo);
            this.Controls.Add(this.buttonAcessar);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle Interno | Reino da Garotada de Poá";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelIdent;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBoxSenha;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.LinkLabel linkLabelEsqueciSenha;
        private System.Windows.Forms.LinkLabel linkLabelEsqueciUsuario;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        public System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.Button buttonAcessar;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelRodape;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Button buttonSair;

    }
}


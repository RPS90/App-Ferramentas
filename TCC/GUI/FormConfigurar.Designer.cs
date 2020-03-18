namespace GUI
{
    partial class FormConfigurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurar));
            this.lblServ = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btTestar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCriarBanco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Location = new System.Drawing.Point(191, 9);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(46, 13);
            this.lblServ.TabIndex = 9;
            this.lblServ.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(243, 6);
            this.txtServidor.MaxLength = 128;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(329, 20);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServidor_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(243, 32);
            this.txtUsuario.MaxLength = 128;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(329, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(191, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Usuário";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(243, 58);
            this.txtBanco.MaxLength = 128;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(176, 20);
            this.txtBanco.TabIndex = 2;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(150, 61);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(87, 13);
            this.lblBanco.TabIndex = 11;
            this.lblBanco.Text = "Banco de Dados";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(243, 84);
            this.txtPort.MaxLength = 128;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(329, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "3306";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(211, 87);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 12;
            this.lblPort.Text = "Port";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(243, 110);
            this.txtSenha.MaxLength = 128;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(329, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(199, 113);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImagem.BackgroundImage")));
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(12, 12);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(132, 166);
            this.pbImagem.TabIndex = 10;
            this.pbImagem.TabStop = false;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(416, 136);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 42);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btTestar
            // 
            this.btTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTestar.Location = new System.Drawing.Point(150, 136);
            this.btTestar.Name = "btTestar";
            this.btTestar.Size = new System.Drawing.Size(260, 42);
            this.btTestar.TabIndex = 6;
            this.btTestar.Text = "Testar Conexão";
            this.btTestar.UseVisualStyleBackColor = true;
            this.btTestar.Click += new System.EventHandler(this.btTestar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(497, 136);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 42);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCriarBanco
            // 
            this.btCriarBanco.Location = new System.Drawing.Point(425, 56);
            this.btCriarBanco.Name = "btCriarBanco";
            this.btCriarBanco.Size = new System.Drawing.Size(147, 23);
            this.btCriarBanco.TabIndex = 5;
            this.btCriarBanco.Text = "Ainda não possuo banco";
            this.btCriarBanco.UseVisualStyleBackColor = true;
            this.btCriarBanco.Click += new System.EventHandler(this.btCriarBanco_Click);
            // 
            // FormConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 190);
            this.Controls.Add(this.btCriarBanco);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btTestar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar banco de dados (MySQL)";
            this.Load += new System.EventHandler(this.FormConfigurar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConfigurar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btTestar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCriarBanco;
    }
}
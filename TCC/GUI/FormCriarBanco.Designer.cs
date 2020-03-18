namespace GUI
{
    partial class FormCriarBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarBanco));
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btCriarBanco = new System.Windows.Forms.Button();
            this.txtCriarBanco = new System.Windows.Forms.TextBox();
            this.gbCriarBanco = new System.Windows.Forms.GroupBox();
            this.rtbTabelas = new System.Windows.Forms.RichTextBox();
            this.btTestar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.gbConectar = new System.Windows.Forms.GroupBox();
            this.gbCriarBanco.SuspendLayout();
            this.gbConectar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(279, 184);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(125, 32);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(6, 19);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(136, 13);
            this.lblBanco.TabIndex = 29;
            this.lblBanco.Text = "Nome do Banco de Dados:";
            // 
            // btCriarBanco
            // 
            this.btCriarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarBanco.Location = new System.Drawing.Point(6, 183);
            this.btCriarBanco.Name = "btCriarBanco";
            this.btCriarBanco.Size = new System.Drawing.Size(150, 32);
            this.btCriarBanco.TabIndex = 1;
            this.btCriarBanco.Text = "Criar Banco de dados";
            this.btCriarBanco.UseVisualStyleBackColor = true;
            this.btCriarBanco.Click += new System.EventHandler(this.btCriarBanco_Click);
            // 
            // txtCriarBanco
            // 
            this.txtCriarBanco.Location = new System.Drawing.Point(148, 16);
            this.txtCriarBanco.MaxLength = 64;
            this.txtCriarBanco.Name = "txtCriarBanco";
            this.txtCriarBanco.Size = new System.Drawing.Size(256, 20);
            this.txtCriarBanco.TabIndex = 0;
            // 
            // gbCriarBanco
            // 
            this.gbCriarBanco.Controls.Add(this.rtbTabelas);
            this.gbCriarBanco.Controls.Add(this.txtCriarBanco);
            this.gbCriarBanco.Controls.Add(this.btCancelar);
            this.gbCriarBanco.Controls.Add(this.btCriarBanco);
            this.gbCriarBanco.Controls.Add(this.lblBanco);
            this.gbCriarBanco.Location = new System.Drawing.Point(318, 12);
            this.gbCriarBanco.Name = "gbCriarBanco";
            this.gbCriarBanco.Size = new System.Drawing.Size(410, 222);
            this.gbCriarBanco.TabIndex = 37;
            this.gbCriarBanco.TabStop = false;
            this.gbCriarBanco.Text = "Criar Banco de Dados (MySQL)";
            // 
            // rtbTabelas
            // 
            this.rtbTabelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTabelas.Location = new System.Drawing.Point(6, 42);
            this.rtbTabelas.Name = "rtbTabelas";
            this.rtbTabelas.ReadOnly = true;
            this.rtbTabelas.Size = new System.Drawing.Size(398, 135);
            this.rtbTabelas.TabIndex = 1;
            this.rtbTabelas.Text = resources.GetString("rtbTabelas.Text");
            // 
            // btTestar
            // 
            this.btTestar.Location = new System.Drawing.Point(169, 182);
            this.btTestar.Name = "btTestar";
            this.btTestar.Size = new System.Drawing.Size(125, 33);
            this.btTestar.TabIndex = 4;
            this.btTestar.Text = "Testar Conexão";
            this.btTestar.UseVisualStyleBackColor = true;
            this.btTestar.Click += new System.EventHandler(this.btTestar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(68, 97);
            this.txtSenha.MaxLength = 128;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(226, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(6, 100);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 46;
            this.lblSenha.Text = "Senha";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(68, 71);
            this.txtPort.MaxLength = 128;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(226, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "3306";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(6, 74);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 44;
            this.lblPort.Text = "Port";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(68, 45);
            this.txtUsuario.MaxLength = 128;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 40;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(68, 19);
            this.txtServidor.MaxLength = 128;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(226, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(6, 22);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 38;
            this.lblServidor.Text = "Servidor";
            // 
            // gbConectar
            // 
            this.gbConectar.Controls.Add(this.lblServidor);
            this.gbConectar.Controls.Add(this.btTestar);
            this.gbConectar.Controls.Add(this.txtServidor);
            this.gbConectar.Controls.Add(this.lblUsuario);
            this.gbConectar.Controls.Add(this.txtSenha);
            this.gbConectar.Controls.Add(this.txtUsuario);
            this.gbConectar.Controls.Add(this.lblSenha);
            this.gbConectar.Controls.Add(this.txtPort);
            this.gbConectar.Controls.Add(this.lblPort);
            this.gbConectar.Location = new System.Drawing.Point(12, 12);
            this.gbConectar.Name = "gbConectar";
            this.gbConectar.Size = new System.Drawing.Size(300, 222);
            this.gbConectar.TabIndex = 51;
            this.gbConectar.TabStop = false;
            this.gbConectar.Text = "Conectar";
            // 
            // FormCriarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 244);
            this.Controls.Add(this.gbConectar);
            this.Controls.Add(this.gbCriarBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCriarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar banco de dados";
            this.Load += new System.EventHandler(this.FormCriarBanco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCriarBanco_KeyDown);
            this.gbCriarBanco.ResumeLayout(false);
            this.gbCriarBanco.PerformLayout();
            this.gbConectar.ResumeLayout(false);
            this.gbConectar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Button btCriarBanco;
        private System.Windows.Forms.TextBox txtCriarBanco;
        private System.Windows.Forms.GroupBox gbCriarBanco;
        private System.Windows.Forms.RichTextBox rtbTabelas;
        private System.Windows.Forms.Button btTestar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.GroupBox gbConectar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtServidor;
    }
}
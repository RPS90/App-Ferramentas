namespace LeitorFenagDados
{
    partial class Principal
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
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.txtEntidadeNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btCarregarArquivo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btRodar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(13, 139);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(553, 553);
            this.GridView1.TabIndex = 0;
            // 
            // txtEntidade
            // 
            this.txtEntidade.Location = new System.Drawing.Point(71, 19);
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.Size = new System.Drawing.Size(100, 20);
            this.txtEntidade.TabIndex = 2;
            // 
            // txtEntidadeNome
            // 
            this.txtEntidadeNome.Location = new System.Drawing.Point(71, 45);
            this.txtEntidadeNome.Name = "txtEntidadeNome";
            this.txtEntidadeNome.Size = new System.Drawing.Size(350, 20);
            this.txtEntidadeNome.TabIndex = 3;
            this.txtEntidadeNome.Text = "AGECEF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ent. Nome";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(12, 14);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(472, 20);
            this.txtArquivo.TabIndex = 7;
            // 
            // btCarregarArquivo
            // 
            this.btCarregarArquivo.Location = new System.Drawing.Point(490, 12);
            this.btCarregarArquivo.Name = "btCarregarArquivo";
            this.btCarregarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btCarregarArquivo.TabIndex = 8;
            this.btCarregarArquivo.Text = "Abrir...";
            this.btCarregarArquivo.UseVisualStyleBackColor = true;
            this.btCarregarArquivo.Click += new System.EventHandler(this.btCarregarArquivo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Abrir arquivo";
            // 
            // btRodar
            // 
            this.btRodar.Location = new System.Drawing.Point(427, 19);
            this.btRodar.Name = "btRodar";
            this.btRodar.Size = new System.Drawing.Size(118, 53);
            this.btRodar.TabIndex = 12;
            this.btRodar.Text = "TESTE!";
            this.btRodar.UseVisualStyleBackColor = true;
            this.btRodar.Click += new System.EventHandler(this.btRodar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEntidade);
            this.groupBox1.Controls.Add(this.txtEntidadeNome);
            this.groupBox1.Controls.Add(this.btRodar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCarregarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.GridView1);
            this.Name = "Form1";
            this.Text = "Conversor das AGECEF";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.TextBox txtEntidadeNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btCarregarArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRodar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


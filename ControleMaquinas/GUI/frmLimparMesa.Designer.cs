namespace GUI
{
    partial class frmLimparMesa
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
            this.btLimparMesa = new System.Windows.Forms.Button();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimparMesa
            // 
            this.btLimparMesa.Location = new System.Drawing.Point(12, 39);
            this.btLimparMesa.Name = "btLimparMesa";
            this.btLimparMesa.Size = new System.Drawing.Size(241, 39);
            this.btLimparMesa.TabIndex = 0;
            this.btLimparMesa.Text = "LIMPAR MESA";
            this.btLimparMesa.UseVisualStyleBackColor = true;
            this.btLimparMesa.Click += new System.EventHandler(this.btLimparMesa_Click);
            // 
            // cbMesa
            // 
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(54, 12);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(198, 21);
            this.cbMesa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesa:";
            // 
            // frmLimparMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMesa);
            this.Controls.Add(this.btLimparMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLimparMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLimparMesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimparMesa;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label1;
    }
}
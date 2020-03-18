namespace GUI
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            this.btFechar = new System.Windows.Forms.Button();
            this.rtbTabelas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(12, 426);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(370, 23);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // rtbTabelas
            // 
            this.rtbTabelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTabelas.Location = new System.Drawing.Point(12, 12);
            this.rtbTabelas.Name = "rtbTabelas";
            this.rtbTabelas.ReadOnly = true;
            this.rtbTabelas.Size = new System.Drawing.Size(370, 408);
            this.rtbTabelas.TabIndex = 2;
            this.rtbTabelas.Text = resources.GetString("rtbTabelas.Text");
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 461);
            this.Controls.Add(this.rtbTabelas);
            this.Controls.Add(this.btFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSobre";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre...";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSobre_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.RichTextBox rtbTabelas;

    }
}
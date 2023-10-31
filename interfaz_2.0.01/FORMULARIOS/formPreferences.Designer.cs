namespace interfaz_2._0._01
{
    partial class formSettings
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
            this.gradienteEfecto_UploadMusic = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradienteEfecto_UploadMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradienteEfecto_UploadMusic
            // 
            this.gradienteEfecto_UploadMusic.BackColor = System.Drawing.Color.Transparent;
            this.gradienteEfecto_UploadMusic.Controls.Add(this.label1);
            this.gradienteEfecto_UploadMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradienteEfecto_UploadMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.gradienteEfecto_UploadMusic.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(24)))), ((int)(((byte)(179)))));
            this.gradienteEfecto_UploadMusic.Location = new System.Drawing.Point(0, 0);
            this.gradienteEfecto_UploadMusic.Name = "gradienteEfecto_UploadMusic";
            this.gradienteEfecto_UploadMusic.Size = new System.Drawing.Size(724, 660);
            this.gradienteEfecto_UploadMusic.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Satoshi Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(295, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Configuraciones";
            // 
            // formSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(724, 660);
            this.Controls.Add(this.gradienteEfecto_UploadMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPreferences";
            this.gradienteEfecto_UploadMusic.ResumeLayout(false);
            this.gradienteEfecto_UploadMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel gradienteEfecto_UploadMusic;
        private System.Windows.Forms.Label label1;
    }
}
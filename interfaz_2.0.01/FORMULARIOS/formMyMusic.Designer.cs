namespace interfaz_2._0._01
{
    partial class formMyMusic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMyMusic));
            this.datagrid_MyMusic = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxSearch_MyMusic = new Guna.UI2.WinForms.Guna2TextBox();
            this.gradienteEfecto_MyMusic = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelSongTitle_MyMusic = new System.Windows.Forms.Label();
            this.labelOpening_MyMusic = new System.Windows.Forms.Label();
            this.labelEnding_MyMusic = new System.Windows.Forms.Label();
            this.btnRewindPlayer_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnFowardPlayer_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDelete_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEdit_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnStarPlayer_MyMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.trackerPlayer_MyMusic = new Guna.UI2.WinForms.Guna2TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_MyMusic)).BeginInit();
            this.gradienteEfecto_MyMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_MyMusic
            // 
            this.datagrid_MyMusic.AllowUserToAddRows = false;
            this.datagrid_MyMusic.AllowUserToDeleteRows = false;
            this.datagrid_MyMusic.AllowUserToOrderColumns = true;
            this.datagrid_MyMusic.AllowUserToResizeColumns = false;
            this.datagrid_MyMusic.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.datagrid_MyMusic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_MyMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_MyMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_MyMusic.ColumnHeadersHeight = 36;
            this.datagrid_MyMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_MyMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Artista,
            this.Album,
            this.Visibilidad,
            this.Ruta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_MyMusic.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_MyMusic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.datagrid_MyMusic.Location = new System.Drawing.Point(74, 109);
            this.datagrid_MyMusic.Name = "datagrid_MyMusic";
            this.datagrid_MyMusic.ReadOnly = true;
            this.datagrid_MyMusic.RowHeadersVisible = false;
            this.datagrid_MyMusic.Size = new System.Drawing.Size(584, 290);
            this.datagrid_MyMusic.TabIndex = 2;
            this.datagrid_MyMusic.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple;
            this.datagrid_MyMusic.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.datagrid_MyMusic.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_MyMusic.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_MyMusic.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_MyMusic.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_MyMusic.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.datagrid_MyMusic.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_MyMusic.ThemeStyle.HeaderStyle.Height = 36;
            this.datagrid_MyMusic.ThemeStyle.ReadOnly = true;
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.Height = 22;
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            this.datagrid_MyMusic.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 117;
            // 
            // Artista
            // 
            this.Artista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Artista.Frozen = true;
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            this.Artista.Width = 117;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Album.Frozen = true;
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Width = 116;
            // 
            // Visibilidad
            // 
            this.Visibilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Visibilidad.Frozen = true;
            this.Visibilidad.HeaderText = "Visibilidad";
            this.Visibilidad.Name = "Visibilidad";
            this.Visibilidad.ReadOnly = true;
            this.Visibilidad.Width = 117;
            // 
            // Ruta
            // 
            this.Ruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ruta.Frozen = true;
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            this.Ruta.Width = 117;
            // 
            // txtbxSearch_MyMusic
            // 
            this.txtbxSearch_MyMusic.BackColor = System.Drawing.Color.Transparent;
            this.txtbxSearch_MyMusic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txtbxSearch_MyMusic.BorderRadius = 15;
            this.txtbxSearch_MyMusic.BorderThickness = 0;
            this.txtbxSearch_MyMusic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSearch_MyMusic.DefaultText = "";
            this.txtbxSearch_MyMusic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxSearch_MyMusic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxSearch_MyMusic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearch_MyMusic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxSearch_MyMusic.FillColor = System.Drawing.Color.GhostWhite;
            this.txtbxSearch_MyMusic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearch_MyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch_MyMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxSearch_MyMusic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxSearch_MyMusic.Location = new System.Drawing.Point(193, 57);
            this.txtbxSearch_MyMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxSearch_MyMusic.Name = "txtbxSearch_MyMusic";
            this.txtbxSearch_MyMusic.PasswordChar = '\0';
            this.txtbxSearch_MyMusic.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtbxSearch_MyMusic.PlaceholderText = "Buscar...";
            this.txtbxSearch_MyMusic.SelectedText = "";
            this.txtbxSearch_MyMusic.Size = new System.Drawing.Size(463, 44);
            this.txtbxSearch_MyMusic.TabIndex = 3;
            // 
            // gradienteEfecto_MyMusic
            // 
            this.gradienteEfecto_MyMusic.BackColor = System.Drawing.Color.Transparent;
            this.gradienteEfecto_MyMusic.Controls.Add(this.labelSongTitle_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.txtbxSearch_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.labelOpening_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.labelEnding_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnRewindPlayer_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnFowardPlayer_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnSearch_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnDelete_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnEdit_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.btnStarPlayer_MyMusic);
            this.gradienteEfecto_MyMusic.Controls.Add(this.trackerPlayer_MyMusic);
            this.gradienteEfecto_MyMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradienteEfecto_MyMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
            this.gradienteEfecto_MyMusic.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(24)))), ((int)(((byte)(179)))));
            this.gradienteEfecto_MyMusic.Location = new System.Drawing.Point(0, 0);
            this.gradienteEfecto_MyMusic.Name = "gradienteEfecto_MyMusic";
            this.gradienteEfecto_MyMusic.Size = new System.Drawing.Size(724, 660);
            this.gradienteEfecto_MyMusic.TabIndex = 4;
            // 
            // labelSongTitle_MyMusic
            // 
            this.labelSongTitle_MyMusic.AutoSize = true;
            this.labelSongTitle_MyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongTitle_MyMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSongTitle_MyMusic.Location = new System.Drawing.Point(42, 436);
            this.labelSongTitle_MyMusic.Name = "labelSongTitle_MyMusic";
            this.labelSongTitle_MyMusic.Size = new System.Drawing.Size(333, 20);
            this.labelSongTitle_MyMusic.TabIndex = 4;
            this.labelSongTitle_MyMusic.Text = "Himno nacional - Orquesta de venezuela";
            // 
            // labelOpening_MyMusic
            // 
            this.labelOpening_MyMusic.AutoSize = true;
            this.labelOpening_MyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpening_MyMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOpening_MyMusic.Location = new System.Drawing.Point(42, 533);
            this.labelOpening_MyMusic.Name = "labelOpening_MyMusic";
            this.labelOpening_MyMusic.Size = new System.Drawing.Size(54, 20);
            this.labelOpening_MyMusic.TabIndex = 3;
            this.labelOpening_MyMusic.Text = "00:00";
            // 
            // labelEnding_MyMusic
            // 
            this.labelEnding_MyMusic.AutoSize = true;
            this.labelEnding_MyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnding_MyMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnding_MyMusic.Location = new System.Drawing.Point(628, 533);
            this.labelEnding_MyMusic.Name = "labelEnding_MyMusic";
            this.labelEnding_MyMusic.Size = new System.Drawing.Size(54, 20);
            this.labelEnding_MyMusic.TabIndex = 3;
            this.labelEnding_MyMusic.Text = "00:00";
            // 
            // btnRewindPlayer_MyMusic
            // 
            this.btnRewindPlayer_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRewindPlayer_MyMusic.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRewindPlayer_MyMusic.Image = global::interfaz_2._0._01.Properties.Resources.rewindButton;
            this.btnRewindPlayer_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRewindPlayer_MyMusic.ImageRotate = 0F;
            this.btnRewindPlayer_MyMusic.Location = new System.Drawing.Point(222, 548);
            this.btnRewindPlayer_MyMusic.Name = "btnRewindPlayer_MyMusic";
            this.btnRewindPlayer_MyMusic.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRewindPlayer_MyMusic.Size = new System.Drawing.Size(64, 54);
            this.btnRewindPlayer_MyMusic.TabIndex = 2;
            // 
            // btnFowardPlayer_MyMusic
            // 
            this.btnFowardPlayer_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFowardPlayer_MyMusic.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFowardPlayer_MyMusic.Image = global::interfaz_2._0._01.Properties.Resources.fastfoward;
            this.btnFowardPlayer_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFowardPlayer_MyMusic.ImageRotate = 0F;
            this.btnFowardPlayer_MyMusic.Location = new System.Drawing.Point(446, 548);
            this.btnFowardPlayer_MyMusic.Name = "btnFowardPlayer_MyMusic";
            this.btnFowardPlayer_MyMusic.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFowardPlayer_MyMusic.Size = new System.Drawing.Size(64, 54);
            this.btnFowardPlayer_MyMusic.TabIndex = 2;
            // 
            // btnSearch_MyMusic
            // 
            this.btnSearch_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch_MyMusic.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnSearch_MyMusic.Image = global::interfaz_2._0._01.Properties.Resources.search;
            this.btnSearch_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch_MyMusic.ImageRotate = 0F;
            this.btnSearch_MyMusic.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch_MyMusic.Location = new System.Drawing.Point(152, 62);
            this.btnSearch_MyMusic.Name = "btnSearch_MyMusic";
            this.btnSearch_MyMusic.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnSearch_MyMusic.Size = new System.Drawing.Size(35, 35);
            this.btnSearch_MyMusic.TabIndex = 2;
            // 
            // btnDelete_MyMusic
            // 
            this.btnDelete_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDelete_MyMusic.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDelete_MyMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_MyMusic.Image")));
            this.btnDelete_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete_MyMusic.ImageRotate = 0F;
            this.btnDelete_MyMusic.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete_MyMusic.Location = new System.Drawing.Point(117, 62);
            this.btnDelete_MyMusic.Name = "btnDelete_MyMusic";
            this.btnDelete_MyMusic.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDelete_MyMusic.Size = new System.Drawing.Size(35, 35);
            this.btnDelete_MyMusic.TabIndex = 2;
            // 
            // btnEdit_MyMusic
            // 
            this.btnEdit_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEdit_MyMusic.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEdit_MyMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_MyMusic.Image")));
            this.btnEdit_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEdit_MyMusic.ImageRotate = 0F;
            this.btnEdit_MyMusic.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEdit_MyMusic.Location = new System.Drawing.Point(76, 62);
            this.btnEdit_MyMusic.Name = "btnEdit_MyMusic";
            this.btnEdit_MyMusic.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEdit_MyMusic.Size = new System.Drawing.Size(35, 35);
            this.btnEdit_MyMusic.TabIndex = 2;
            // 
            // btnStarPlayer_MyMusic
            // 
            this.btnStarPlayer_MyMusic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStarPlayer_MyMusic.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStarPlayer_MyMusic.Image = global::interfaz_2._0._01.Properties.Resources.playIcon;
            this.btnStarPlayer_MyMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnStarPlayer_MyMusic.ImageRotate = 0F;
            this.btnStarPlayer_MyMusic.Location = new System.Drawing.Point(334, 548);
            this.btnStarPlayer_MyMusic.Name = "btnStarPlayer_MyMusic";
            this.btnStarPlayer_MyMusic.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStarPlayer_MyMusic.Size = new System.Drawing.Size(64, 54);
            this.btnStarPlayer_MyMusic.TabIndex = 2;
            // 
            // trackerPlayer_MyMusic
            // 
            this.trackerPlayer_MyMusic.Location = new System.Drawing.Point(74, 481);
            this.trackerPlayer_MyMusic.Name = "trackerPlayer_MyMusic";
            this.trackerPlayer_MyMusic.Size = new System.Drawing.Size(584, 27);
            this.trackerPlayer_MyMusic.TabIndex = 1;
            this.trackerPlayer_MyMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(2)))), ((int)(((byte)(154)))));
            // 
            // formMyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(724, 660);
            this.Controls.Add(this.datagrid_MyMusic);
            this.Controls.Add(this.gradienteEfecto_MyMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMyMusic";
            this.Text = "formMyMusic";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_MyMusic)).EndInit();
            this.gradienteEfecto_MyMusic.ResumeLayout(false);
            this.gradienteEfecto_MyMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_MyMusic;
        private Guna.UI2.WinForms.Guna2TextBox txtbxSearch_MyMusic;
        private Guna.UI2.WinForms.Guna2GradientPanel gradienteEfecto_MyMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnStarPlayer_MyMusic;
        private Guna.UI2.WinForms.Guna2TrackBar trackerPlayer_MyMusic;
        private System.Windows.Forms.Label labelEnding_MyMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnRewindPlayer_MyMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnFowardPlayer_MyMusic;
        private System.Windows.Forms.Label labelOpening_MyMusic;
        private System.Windows.Forms.Label labelSongTitle_MyMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete_MyMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnEdit_MyMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch_MyMusic;
    }
}
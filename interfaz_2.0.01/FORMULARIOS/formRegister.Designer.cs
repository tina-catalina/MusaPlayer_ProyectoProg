namespace interfaz_2._0._01
{
    partial class formRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            this.elipseformRegister = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtpNacimiento_Register = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.brandRegister = new System.Windows.Forms.Label();
            this.logoRegister = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtbxCheckPassword_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxPassword_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbxNombre_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbxApellido_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbxCI_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxNickname_Register = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlcontenedorDatosRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizeRegister = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExitRegister = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlcontenedorImagenRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.imagenRegister = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sombraformRegister = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).BeginInit();
            this.pnlcontenedorDatosRegister.SuspendLayout();
            this.pnlcontenedorImagenRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseformRegister
            // 
            this.elipseformRegister.BorderRadius = 10;
            this.elipseformRegister.TargetControl = this;
            // 
            // dtpNacimiento_Register
            // 
            this.dtpNacimiento_Register.Animated = true;
            this.dtpNacimiento_Register.BorderRadius = 6;
            this.dtpNacimiento_Register.Checked = true;
            this.dtpNacimiento_Register.FillColor = System.Drawing.Color.White;
            this.dtpNacimiento_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento_Register.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento_Register.Location = new System.Drawing.Point(197, 522);
            this.dtpNacimiento_Register.MaxDate = new System.DateTime(2023, 10, 29, 0, 0, 0, 0);
            this.dtpNacimiento_Register.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento_Register.Name = "dtpNacimiento_Register";
            this.dtpNacimiento_Register.Size = new System.Drawing.Size(160, 36);
            this.dtpNacimiento_Register.TabIndex = 27;
            this.dtpNacimiento_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNacimiento_Register.Value = new System.DateTime(2023, 10, 29, 0, 0, 0, 0);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Image = global::interfaz_2._0._01.Properties.Resources.btnBack;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(321, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // brandRegister
            // 
            this.brandRegister.AutoSize = true;
            this.brandRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.brandRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.brandRegister.Location = new System.Drawing.Point(97, 48);
            this.brandRegister.Name = "brandRegister";
            this.brandRegister.Size = new System.Drawing.Size(102, 15);
            this.brandRegister.TabIndex = 25;
            this.brandRegister.Text = "MUSA PLAYER";
            // 
            // logoRegister
            // 
            this.logoRegister.BackColor = System.Drawing.Color.Transparent;
            this.logoRegister.Image = global::interfaz_2._0._01.Properties.Resources.logo_opcion2;
            this.logoRegister.ImageRotate = 0F;
            this.logoRegister.Location = new System.Drawing.Point(10, 10);
            this.logoRegister.Name = "logoRegister";
            this.logoRegister.Size = new System.Drawing.Size(90, 90);
            this.logoRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoRegister.TabIndex = 24;
            this.logoRegister.TabStop = false;
            this.logoRegister.UseTransparentBackground = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Animated = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BorderRadius = 10;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Satoshi", 9.75F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRegistrar.Location = new System.Drawing.Point(131, 587);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 45);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Crear cuenta";
            this.btnRegistrar.UseTransparentBackground = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtbxCheckPassword_Register
            // 
            this.txtbxCheckPassword_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbxCheckPassword_Register.BorderRadius = 6;
            this.txtbxCheckPassword_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCheckPassword_Register.DefaultText = "";
            this.txtbxCheckPassword_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxCheckPassword_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxCheckPassword_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxCheckPassword_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxCheckPassword_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txtbxCheckPassword_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxCheckPassword_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCheckPassword_Register.ForeColor = System.Drawing.Color.White;
            this.txtbxCheckPassword_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txtbxCheckPassword_Register.Location = new System.Drawing.Point(37, 463);
            this.txtbxCheckPassword_Register.Name = "txtbxCheckPassword_Register";
            this.txtbxCheckPassword_Register.PasswordChar = '●';
            this.txtbxCheckPassword_Register.PlaceholderText = "Verificar contraseña";
            this.txtbxCheckPassword_Register.SelectedText = "";
            this.txtbxCheckPassword_Register.Size = new System.Drawing.Size(320, 36);
            this.txtbxCheckPassword_Register.TabIndex = 17;
            this.txtbxCheckPassword_Register.UseSystemPasswordChar = true;
            // 
            // txtbxPassword_Register
            // 
            this.txtbxPassword_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbxPassword_Register.BorderRadius = 6;
            this.txtbxPassword_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword_Register.DefaultText = "";
            this.txtbxPassword_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txtbxPassword_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword_Register.ForeColor = System.Drawing.Color.White;
            this.txtbxPassword_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txtbxPassword_Register.Location = new System.Drawing.Point(37, 396);
            this.txtbxPassword_Register.Name = "txtbxPassword_Register";
            this.txtbxPassword_Register.PasswordChar = '●';
            this.txtbxPassword_Register.PlaceholderText = "Contraseña";
            this.txtbxPassword_Register.SelectedText = "";
            this.txtbxPassword_Register.Size = new System.Drawing.Size(320, 36);
            this.txtbxPassword_Register.TabIndex = 18;
            this.txtbxPassword_Register.UseSystemPasswordChar = true;
            // 
            // txbxNombre_Register
            // 
            this.txbxNombre_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbxNombre_Register.BorderRadius = 6;
            this.txbxNombre_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxNombre_Register.DefaultText = "";
            this.txbxNombre_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbxNombre_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbxNombre_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxNombre_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxNombre_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txbxNombre_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbxNombre_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNombre_Register.ForeColor = System.Drawing.Color.White;
            this.txbxNombre_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txbxNombre_Register.Location = new System.Drawing.Point(37, 195);
            this.txbxNombre_Register.Name = "txbxNombre_Register";
            this.txbxNombre_Register.PasswordChar = '\0';
            this.txbxNombre_Register.PlaceholderText = "Nombre";
            this.txbxNombre_Register.SelectedText = "";
            this.txbxNombre_Register.Size = new System.Drawing.Size(320, 36);
            this.txbxNombre_Register.TabIndex = 19;
            // 
            // txbxApellido_Register
            // 
            this.txbxApellido_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbxApellido_Register.BorderRadius = 6;
            this.txbxApellido_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxApellido_Register.DefaultText = "";
            this.txbxApellido_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbxApellido_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbxApellido_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxApellido_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxApellido_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txbxApellido_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbxApellido_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxApellido_Register.ForeColor = System.Drawing.Color.White;
            this.txbxApellido_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txbxApellido_Register.Location = new System.Drawing.Point(37, 262);
            this.txbxApellido_Register.Name = "txbxApellido_Register";
            this.txbxApellido_Register.PasswordChar = '\0';
            this.txbxApellido_Register.PlaceholderText = "Apellido";
            this.txbxApellido_Register.SelectedText = "";
            this.txbxApellido_Register.Size = new System.Drawing.Size(320, 36);
            this.txbxApellido_Register.TabIndex = 20;
            // 
            // txbxCI_Register
            // 
            this.txbxCI_Register.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txbxCI_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txbxCI_Register.BorderRadius = 6;
            this.txbxCI_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxCI_Register.DefaultText = "";
            this.txbxCI_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbxCI_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbxCI_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxCI_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbxCI_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txbxCI_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbxCI_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCI_Register.ForeColor = System.Drawing.Color.White;
            this.txbxCI_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txbxCI_Register.Location = new System.Drawing.Point(37, 128);
            this.txbxCI_Register.Name = "txbxCI_Register";
            this.txbxCI_Register.PasswordChar = '\0';
            this.txbxCI_Register.PlaceholderText = "C.I: ejemplo 123678";
            this.txbxCI_Register.SelectedText = "";
            this.txbxCI_Register.Size = new System.Drawing.Size(320, 36);
            this.txbxCI_Register.TabIndex = 21;

            // txtbxNickname_Register
            // 
            this.txtbxNickname_Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbxNickname_Register.BorderRadius = 6;
            this.txtbxNickname_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxNickname_Register.DefaultText = "";
            this.txtbxNickname_Register.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxNickname_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxNickname_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNickname_Register.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxNickname_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.txtbxNickname_Register.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxNickname_Register.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNickname_Register.ForeColor = System.Drawing.Color.White;
            this.txtbxNickname_Register.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(158)))), ((int)(((byte)(242)))));
            this.txtbxNickname_Register.Location = new System.Drawing.Point(37, 329);
            this.txtbxNickname_Register.Name = "txtbxNickname_Register";
            this.txtbxNickname_Register.PasswordChar = '\0';
            this.txtbxNickname_Register.PlaceholderText = "Nombre de usuario";
            this.txtbxNickname_Register.SelectedText = "";
            this.txtbxNickname_Register.Size = new System.Drawing.Size(320, 36);
            this.txtbxNickname_Register.TabIndex = 22;
            // 
            // pnlcontenedorDatosRegister
            // 
            this.pnlcontenedorDatosRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.pnlcontenedorDatosRegister.Controls.Add(this.label3);
            this.pnlcontenedorDatosRegister.Controls.Add(this.dtpNacimiento_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.btnBack);
            this.pnlcontenedorDatosRegister.Controls.Add(this.btnRegistrar);
            this.pnlcontenedorDatosRegister.Controls.Add(this.brandRegister);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txtbxCheckPassword_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txtbxPassword_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.logoRegister);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txbxNombre_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txbxCI_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txbxApellido_Register);
            this.pnlcontenedorDatosRegister.Controls.Add(this.txtbxNickname_Register);
            this.pnlcontenedorDatosRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlcontenedorDatosRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlcontenedorDatosRegister.Name = "pnlcontenedorDatosRegister";
            this.pnlcontenedorDatosRegister.Size = new System.Drawing.Size(394, 660);
            this.pnlcontenedorDatosRegister.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Satoshi", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(47, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // btnMinimizeRegister
            // 
            this.btnMinimizeRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeRegister.Animated = true;
            this.btnMinimizeRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeRegister.BorderRadius = 3;
            this.btnMinimizeRegister.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.btnMinimizeRegister.IconColor = System.Drawing.Color.White;
            this.btnMinimizeRegister.Location = new System.Drawing.Point(496, 12);
            this.btnMinimizeRegister.Name = "btnMinimizeRegister";
            this.btnMinimizeRegister.Size = new System.Drawing.Size(25, 20);
            this.btnMinimizeRegister.TabIndex = 1;
            this.btnMinimizeRegister.UseTransparentBackground = true;
            // 
            // btnExitRegister
            // 
            this.btnExitRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitRegister.Animated = true;
            this.btnExitRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnExitRegister.BorderRadius = 3;
            this.btnExitRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(73)))));
            this.btnExitRegister.IconColor = System.Drawing.Color.White;
            this.btnExitRegister.Location = new System.Drawing.Point(537, 12);
            this.btnExitRegister.Name = "btnExitRegister";
            this.btnExitRegister.Size = new System.Drawing.Size(25, 20);
            this.btnExitRegister.TabIndex = 1;
            this.btnExitRegister.UseTransparentBackground = true;
            this.btnExitRegister.Click += new System.EventHandler(this.btnExitRegister_Click);
            // 
            // pnlcontenedorImagenRegister
            // 
            this.pnlcontenedorImagenRegister.Controls.Add(this.btnMinimizeRegister);
            this.pnlcontenedorImagenRegister.Controls.Add(this.btnExitRegister);
            this.pnlcontenedorImagenRegister.Controls.Add(this.imagenRegister);
            this.pnlcontenedorImagenRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlcontenedorImagenRegister.Location = new System.Drawing.Point(390, 0);
            this.pnlcontenedorImagenRegister.Name = "pnlcontenedorImagenRegister";
            this.pnlcontenedorImagenRegister.Size = new System.Drawing.Size(584, 660);
            this.pnlcontenedorImagenRegister.TabIndex = 29;
            // 
            // imagenRegister
            // 
            this.imagenRegister.BackColor = System.Drawing.Color.Transparent;
            this.imagenRegister.Image = global::interfaz_2._0._01.Properties.Resources.background_image1;
            this.imagenRegister.ImageRotate = 0F;
            this.imagenRegister.Location = new System.Drawing.Point(-53, 0);
            this.imagenRegister.Name = "imagenRegister";
            this.imagenRegister.Size = new System.Drawing.Size(674, 674);
            this.imagenRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenRegister.TabIndex = 0;
            this.imagenRegister.TabStop = false;
            this.imagenRegister.UseTransparentBackground = true;
            // 
            // sombraformRegister
            // 
            this.sombraformRegister.BorderRadius = 10;
            this.sombraformRegister.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.sombraformRegister.TargetForm = this;
            // 
            // formRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(974, 660);
            this.Controls.Add(this.pnlcontenedorImagenRegister);
            this.Controls.Add(this.pnlcontenedorDatosRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoRegister)).EndInit();
            this.pnlcontenedorDatosRegister.ResumeLayout(false);
            this.pnlcontenedorDatosRegister.PerformLayout();
            this.pnlcontenedorImagenRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseformRegister;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNacimiento_Register;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.Label brandRegister;
        private Guna.UI2.WinForms.Guna2PictureBox logoRegister;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtbxCheckPassword_Register;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword_Register;
        private Guna.UI2.WinForms.Guna2TextBox txbxNombre_Register;
        private Guna.UI2.WinForms.Guna2TextBox txbxApellido_Register;
        private Guna.UI2.WinForms.Guna2TextBox txbxCI_Register;
        private Guna.UI2.WinForms.Guna2TextBox txtbxNickname_Register;
        private Guna.UI2.WinForms.Guna2Panel pnlcontenedorDatosRegister;
        private Guna.UI2.WinForms.Guna2Panel pnlcontenedorImagenRegister;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeRegister;
        private Guna.UI2.WinForms.Guna2ControlBox btnExitRegister;
        private Guna.UI2.WinForms.Guna2PictureBox imagenRegister;
        private Guna.UI2.WinForms.Guna2ShadowForm sombraformRegister;
        private System.Windows.Forms.Label label3;
    }
}

namespace MainView.forms
{
    partial class AddConsoleForm
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
            this.MainWindowPanel = new System.Windows.Forms.Panel();
            this.SaveConsoleButton = new System.Windows.Forms.Button();
            this.DisplayPassButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.ChangeImageButton = new FontAwesome.Sharp.IconButton();
            this.MetadataBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.MetadataLabel = new System.Windows.Forms.Label();
            this.PassConsoleLabel = new System.Windows.Forms.Label();
            this.UsernameConsoleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PropBox = new System.Windows.Forms.GroupBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.HWBox = new System.Windows.Forms.TextBox();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.HWLabel = new System.Windows.Forms.Label();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.SerialConsoleLabel = new System.Windows.Forms.Label();
            this.ModelConsoleLabel = new System.Windows.Forms.Label();
            this.NameConsoleLabel = new System.Windows.Forms.Label();
            this.ConsoleDate = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.display = new System.Windows.Forms.Timer(this.components);
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveButtonCheck = new System.Windows.Forms.Timer(this.components);
            this.MainWindowPanel.SuspendLayout();
            this.PropBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainWindowPanel.Controls.Add(this.SaveConsoleButton);
            this.MainWindowPanel.Controls.Add(this.DisplayPassButton);
            this.MainWindowPanel.Controls.Add(this.label2);
            this.MainWindowPanel.Controls.Add(this.StatusBox);
            this.MainWindowPanel.Controls.Add(this.ChangeImageButton);
            this.MainWindowPanel.Controls.Add(this.MetadataBox);
            this.MainWindowPanel.Controls.Add(this.PassBox);
            this.MainWindowPanel.Controls.Add(this.UsernameBox);
            this.MainWindowPanel.Controls.Add(this.MetadataLabel);
            this.MainWindowPanel.Controls.Add(this.PassConsoleLabel);
            this.MainWindowPanel.Controls.Add(this.UsernameConsoleLabel);
            this.MainWindowPanel.Controls.Add(this.label1);
            this.MainWindowPanel.Controls.Add(this.PropBox);
            this.MainWindowPanel.Controls.Add(this.ImageBox);
            this.MainWindowPanel.Controls.Add(this.TopBar);
            this.MainWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.Size = new System.Drawing.Size(635, 460);
            this.MainWindowPanel.TabIndex = 0;
            // 
            // SaveConsoleButton
            // 
            this.SaveConsoleButton.BackColor = System.Drawing.Color.Black;
            this.SaveConsoleButton.FlatAppearance.BorderSize = 0;
            this.SaveConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConsoleButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SaveConsoleButton.ForeColor = System.Drawing.Color.White;
            this.SaveConsoleButton.Location = new System.Drawing.Point(13, 423);
            this.SaveConsoleButton.Name = "SaveConsoleButton";
            this.SaveConsoleButton.Size = new System.Drawing.Size(610, 29);
            this.SaveConsoleButton.TabIndex = 23;
            this.SaveConsoleButton.Text = "Guardar Consola";
            this.SaveConsoleButton.UseCompatibleTextRendering = true;
            this.SaveConsoleButton.UseVisualStyleBackColor = false;
            this.SaveConsoleButton.Click += new System.EventHandler(this.SaveConsoleButton_Click);
            // 
            // DisplayPassButton
            // 
            this.DisplayPassButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.DisplayPassButton.IconColor = System.Drawing.Color.Black;
            this.DisplayPassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DisplayPassButton.IconSize = 28;
            this.DisplayPassButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DisplayPassButton.Location = new System.Drawing.Point(194, 383);
            this.DisplayPassButton.Name = "DisplayPassButton";
            this.DisplayPassButton.Size = new System.Drawing.Size(30, 29);
            this.DisplayPassButton.TabIndex = 22;
            this.DisplayPassButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DisplayPassButton.UseVisualStyleBackColor = true;
            this.DisplayPassButton.Click += new System.EventHandler(this.DisplayPassButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "*El valor por defecto durante el registro es \"Activo\"";
            // 
            // StatusBox
            // 
            this.StatusBox.Enabled = false;
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Activo"});
            this.StatusBox.Location = new System.Drawing.Point(297, 244);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(188, 29);
            this.StatusBox.TabIndex = 19;
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.ChangeImageButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeImageButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeImageButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeImageButton.FlatAppearance.BorderSize = 0;
            this.ChangeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ChangeImageButton.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.ChangeImageButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ChangeImageButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.ChangeImageButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ChangeImageButton.IconSize = 20;
            this.ChangeImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeImageButton.Location = new System.Drawing.Point(7, 251);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(214, 30);
            this.ChangeImageButton.TabIndex = 17;
            this.ChangeImageButton.Text = "Cambiar Imagen";
            this.ChangeImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ChangeImageButton.UseVisualStyleBackColor = false;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // MetadataBox
            // 
            this.MetadataBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MetadataBox.Location = new System.Drawing.Point(237, 309);
            this.MetadataBox.MaxLength = 999;
            this.MetadataBox.Multiline = true;
            this.MetadataBox.Name = "MetadataBox";
            this.MetadataBox.Size = new System.Drawing.Size(385, 103);
            this.MetadataBox.TabIndex = 16;
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(12, 383);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(177, 29);
            this.PassBox.TabIndex = 15;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(11, 319);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(210, 29);
            this.UsernameBox.TabIndex = 14;
            // 
            // MetadataLabel
            // 
            this.MetadataLabel.AutoSize = true;
            this.MetadataLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MetadataLabel.Location = new System.Drawing.Point(234, 279);
            this.MetadataLabel.Name = "MetadataLabel";
            this.MetadataLabel.Size = new System.Drawing.Size(135, 27);
            this.MetadataLabel.TabIndex = 11;
            this.MetadataLabel.Text = "Datos Adicionales";
            this.MetadataLabel.UseCompatibleTextRendering = true;
            // 
            // PassConsoleLabel
            // 
            this.PassConsoleLabel.AutoSize = true;
            this.PassConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PassConsoleLabel.Location = new System.Drawing.Point(31, 352);
            this.PassConsoleLabel.Name = "PassConsoleLabel";
            this.PassConsoleLabel.Size = new System.Drawing.Size(171, 27);
            this.PassConsoleLabel.TabIndex = 10;
            this.PassConsoleLabel.Text = "Contraseña de consola";
            this.PassConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // UsernameConsoleLabel
            // 
            this.UsernameConsoleLabel.AutoSize = true;
            this.UsernameConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.UsernameConsoleLabel.Location = new System.Drawing.Point(44, 288);
            this.UsernameConsoleLabel.Name = "UsernameConsoleLabel";
            this.UsernameConsoleLabel.Size = new System.Drawing.Size(144, 27);
            this.UsernameConsoleLabel.TabIndex = 9;
            this.UsernameConsoleLabel.Text = "Usuario de consola";
            this.UsernameConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // PropBox
            // 
            this.PropBox.Controls.Add(this.DateBox);
            this.PropBox.Controls.Add(this.HWBox);
            this.PropBox.Controls.Add(this.IpBox);
            this.PropBox.Controls.Add(this.SerialBox);
            this.PropBox.Controls.Add(this.ModelBox);
            this.PropBox.Controls.Add(this.NameBox);
            this.PropBox.Controls.Add(this.HWLabel);
            this.PropBox.Controls.Add(this.IPAddressLabel);
            this.PropBox.Controls.Add(this.SerialConsoleLabel);
            this.PropBox.Controls.Add(this.ModelConsoleLabel);
            this.PropBox.Controls.Add(this.NameConsoleLabel);
            this.PropBox.Controls.Add(this.ConsoleDate);
            this.PropBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PropBox.Location = new System.Drawing.Point(228, 36);
            this.PropBox.Name = "PropBox";
            this.PropBox.Size = new System.Drawing.Size(394, 208);
            this.PropBox.TabIndex = 3;
            this.PropBox.TabStop = false;
            this.PropBox.Text = "Propiedades de la consola";
            this.PropBox.UseCompatibleTextRendering = true;
            // 
            // DateBox
            // 
            this.DateBox.CustomFormat = "";
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox.Location = new System.Drawing.Point(146, 33);
            this.DateBox.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(248, 29);
            this.DateBox.TabIndex = 14;
            this.DateBox.Value = new System.DateTime(2021, 6, 7, 0, 0, 0, 0);
            // 
            // HWBox
            // 
            this.HWBox.Location = new System.Drawing.Point(146, 167);
            this.HWBox.MaxLength = 10;
            this.HWBox.Name = "HWBox";
            this.HWBox.Size = new System.Drawing.Size(248, 29);
            this.HWBox.TabIndex = 13;
            this.HWBox.Text = "0";
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(146, 140);
            this.IpBox.MaxLength = 18;
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(248, 29);
            this.IpBox.TabIndex = 12;
            // 
            // SerialBox
            // 
            this.SerialBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SerialBox.Location = new System.Drawing.Point(146, 113);
            this.SerialBox.MaxLength = 30;
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(248, 29);
            this.SerialBox.TabIndex = 11;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(146, 86);
            this.ModelBox.MaxLength = 50;
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(248, 29);
            this.ModelBox.TabIndex = 10;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(146, 59);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(248, 29);
            this.NameBox.TabIndex = 9;
            // 
            // HWLabel
            // 
            this.HWLabel.AutoSize = true;
            this.HWLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HWLabel.Location = new System.Drawing.Point(6, 170);
            this.HWLabel.Name = "HWLabel";
            this.HWLabel.Size = new System.Drawing.Size(131, 27);
            this.HWLabel.TabIndex = 7;
            this.HWLabel.Text = "Horas de trabajo:";
            this.HWLabel.UseCompatibleTextRendering = true;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IPAddressLabel.Location = new System.Drawing.Point(6, 143);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(96, 27);
            this.IPAddressLabel.TabIndex = 6;
            this.IPAddressLabel.Text = "Direccion IP:";
            this.IPAddressLabel.UseCompatibleTextRendering = true;
            // 
            // SerialConsoleLabel
            // 
            this.SerialConsoleLabel.AutoSize = true;
            this.SerialConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialConsoleLabel.Location = new System.Drawing.Point(6, 116);
            this.SerialConsoleLabel.Name = "SerialConsoleLabel";
            this.SerialConsoleLabel.Size = new System.Drawing.Size(49, 27);
            this.SerialConsoleLabel.TabIndex = 5;
            this.SerialConsoleLabel.Text = "Serial:";
            this.SerialConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // ModelConsoleLabel
            // 
            this.ModelConsoleLabel.AutoSize = true;
            this.ModelConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ModelConsoleLabel.Location = new System.Drawing.Point(6, 89);
            this.ModelConsoleLabel.Name = "ModelConsoleLabel";
            this.ModelConsoleLabel.Size = new System.Drawing.Size(66, 27);
            this.ModelConsoleLabel.TabIndex = 4;
            this.ModelConsoleLabel.Text = "Modelo:";
            this.ModelConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // NameConsoleLabel
            // 
            this.NameConsoleLabel.AutoSize = true;
            this.NameConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NameConsoleLabel.Location = new System.Drawing.Point(6, 62);
            this.NameConsoleLabel.Name = "NameConsoleLabel";
            this.NameConsoleLabel.Size = new System.Drawing.Size(70, 27);
            this.NameConsoleLabel.TabIndex = 3;
            this.NameConsoleLabel.Text = "Nombre:";
            this.NameConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // ConsoleDate
            // 
            this.ConsoleDate.AutoSize = true;
            this.ConsoleDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ConsoleDate.Location = new System.Drawing.Point(6, 35);
            this.ConsoleDate.Name = "ConsoleDate";
            this.ConsoleDate.Size = new System.Drawing.Size(134, 27);
            this.ConsoleDate.TabIndex = 2;
            this.ConsoleDate.Text = "Fecha de compra:";
            this.ConsoleDate.UseCompatibleTextRendering = true;
            // 
            // ImageBox
            // 
            this.ImageBox.Image = global::MainView.Properties.Resources.XboxDefImage;
            this.ImageBox.InitialImage = null;
            this.ImageBox.Location = new System.Drawing.Point(7, 36);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(215, 208);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.TopBar.Controls.Add(this.panel1);
            this.TopBar.Controls.Add(this.MinButton);
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(635, 30);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 30);
            this.panel1.TabIndex = 6;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TitleLabel.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.TitleLabel.Location = new System.Drawing.Point(8, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(169, 19);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Agregar Nueva Consola";
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.Transparent;
            this.MinButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.IconSize = 30;
            this.MinButton.Location = new System.Drawing.Point(575, 0);
            this.MinButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(30, 30);
            this.MinButton.TabIndex = 4;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 30;
            this.CloseButton.Location = new System.Drawing.Point(605, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // display
            // 
            this.display.Interval = 5000;
            this.display.Tick += new System.EventHandler(this.display_Tick);
            // 
            // SaveButtonCheck
            // 
            this.SaveButtonCheck.Interval = 1000;
            this.SaveButtonCheck.Tick += new System.EventHandler(this.SaveButtonCheck_Tick);
            // 
            // AddConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(635, 460);
            this.Controls.Add(this.MainWindowPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddConsoleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nueva Consola";
            this.Load += new System.EventHandler(this.AddConsoleForm_Load);
            this.MainWindowPanel.ResumeLayout(false);
            this.MainWindowPanel.PerformLayout();
            this.PropBox.ResumeLayout(false);
            this.PropBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainWindowPanel;
        private System.Windows.Forms.Panel TopBar;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label ConsoleDate;
        private System.Windows.Forms.GroupBox PropBox;
        private System.Windows.Forms.Label HWLabel;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label SerialConsoleLabel;
        private System.Windows.Forms.Label ModelConsoleLabel;
        private System.Windows.Forms.Label NameConsoleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MetadataLabel;
        private System.Windows.Forms.Label PassConsoleLabel;
        private System.Windows.Forms.Label UsernameConsoleLabel;
        private FontAwesome.Sharp.IconButton ChangeImageButton;
        private System.Windows.Forms.TextBox MetadataBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox HWBox;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.DateTimePicker DateBox;
        private FontAwesome.Sharp.IconButton DisplayPassButton;
        private System.Windows.Forms.Timer display;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.Timer SaveButtonCheck;
        private System.Windows.Forms.Button SaveConsoleButton;
    }
}
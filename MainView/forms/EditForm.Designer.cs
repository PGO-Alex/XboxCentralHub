
namespace MainView.forms
{
    partial class EditConsole
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Topbar = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
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
            this.DisplayPassButton = new FontAwesome.Sharp.IconButton();
            this.ChangeImageButton = new FontAwesome.Sharp.IconButton();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PassConsoleLabel = new System.Windows.Forms.Label();
            this.UsernameConsoleLabel = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.MetadataBox = new System.Windows.Forms.TextBox();
            this.MetadataLabel = new System.Windows.Forms.Label();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SaveConsoleButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Timer(this.components);
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveButtonCheck = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.Topbar.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ControlPanel);
            this.MainPanel.Controls.Add(this.Topbar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(380, 540);
            this.MainPanel.TabIndex = 0;
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.Black;
            this.Topbar.Controls.Add(this.TitlePanel);
            this.Topbar.Controls.Add(this.CloseButton);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(380, 30);
            this.Topbar.TabIndex = 42;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.SaveConsoleButton);
            this.ControlPanel.Controls.Add(this.MessageLabel);
            this.ControlPanel.Controls.Add(this.StatusBox);
            this.ControlPanel.Controls.Add(this.StatusLabel);
            this.ControlPanel.Controls.Add(this.MetadataBox);
            this.ControlPanel.Controls.Add(this.MetadataLabel);
            this.ControlPanel.Controls.Add(this.DateBox);
            this.ControlPanel.Controls.Add(this.HWBox);
            this.ControlPanel.Controls.Add(this.IpBox);
            this.ControlPanel.Controls.Add(this.SerialBox);
            this.ControlPanel.Controls.Add(this.ModelBox);
            this.ControlPanel.Controls.Add(this.NameBox);
            this.ControlPanel.Controls.Add(this.HWLabel);
            this.ControlPanel.Controls.Add(this.IPAddressLabel);
            this.ControlPanel.Controls.Add(this.SerialConsoleLabel);
            this.ControlPanel.Controls.Add(this.ModelConsoleLabel);
            this.ControlPanel.Controls.Add(this.NameConsoleLabel);
            this.ControlPanel.Controls.Add(this.ConsoleDate);
            this.ControlPanel.Controls.Add(this.DisplayPassButton);
            this.ControlPanel.Controls.Add(this.ChangeImageButton);
            this.ControlPanel.Controls.Add(this.PassBox);
            this.ControlPanel.Controls.Add(this.UsernameBox);
            this.ControlPanel.Controls.Add(this.PassConsoleLabel);
            this.ControlPanel.Controls.Add(this.UsernameConsoleLabel);
            this.ControlPanel.Controls.Add(this.ImageBox);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 30);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(380, 510);
            this.ControlPanel.TabIndex = 43;
            // 
            // DateBox
            // 
            this.DateBox.CustomFormat = "";
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox.Location = new System.Drawing.Point(185, 201);
            this.DateBox.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(188, 29);
            this.DateBox.TabIndex = 60;
            this.DateBox.Value = new System.DateTime(2021, 6, 7, 0, 0, 0, 0);
            // 
            // HWBox
            // 
            this.HWBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HWBox.Location = new System.Drawing.Point(185, 351);
            this.HWBox.MaxLength = 10;
            this.HWBox.Name = "HWBox";
            this.HWBox.Size = new System.Drawing.Size(188, 29);
            this.HWBox.TabIndex = 59;
            this.HWBox.Text = "0";
            // 
            // IpBox
            // 
            this.IpBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IpBox.Location = new System.Drawing.Point(185, 321);
            this.IpBox.MaxLength = 18;
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(188, 29);
            this.IpBox.TabIndex = 58;
            // 
            // SerialBox
            // 
            this.SerialBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SerialBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialBox.Location = new System.Drawing.Point(185, 291);
            this.SerialBox.MaxLength = 30;
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(188, 29);
            this.SerialBox.TabIndex = 57;
            // 
            // ModelBox
            // 
            this.ModelBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ModelBox.Location = new System.Drawing.Point(185, 261);
            this.ModelBox.MaxLength = 50;
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(188, 29);
            this.ModelBox.TabIndex = 56;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(185, 231);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(188, 29);
            this.NameBox.TabIndex = 55;
            // 
            // HWLabel
            // 
            this.HWLabel.AutoSize = true;
            this.HWLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HWLabel.Location = new System.Drawing.Point(8, 354);
            this.HWLabel.Name = "HWLabel";
            this.HWLabel.Size = new System.Drawing.Size(131, 27);
            this.HWLabel.TabIndex = 54;
            this.HWLabel.Text = "Horas de trabajo:";
            this.HWLabel.UseCompatibleTextRendering = true;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IPAddressLabel.Location = new System.Drawing.Point(8, 324);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(96, 27);
            this.IPAddressLabel.TabIndex = 53;
            this.IPAddressLabel.Text = "Direccion IP:";
            this.IPAddressLabel.UseCompatibleTextRendering = true;
            // 
            // SerialConsoleLabel
            // 
            this.SerialConsoleLabel.AutoSize = true;
            this.SerialConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialConsoleLabel.Location = new System.Drawing.Point(8, 294);
            this.SerialConsoleLabel.Name = "SerialConsoleLabel";
            this.SerialConsoleLabel.Size = new System.Drawing.Size(49, 27);
            this.SerialConsoleLabel.TabIndex = 52;
            this.SerialConsoleLabel.Text = "Serial:";
            this.SerialConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // ModelConsoleLabel
            // 
            this.ModelConsoleLabel.AutoSize = true;
            this.ModelConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ModelConsoleLabel.Location = new System.Drawing.Point(8, 264);
            this.ModelConsoleLabel.Name = "ModelConsoleLabel";
            this.ModelConsoleLabel.Size = new System.Drawing.Size(66, 27);
            this.ModelConsoleLabel.TabIndex = 51;
            this.ModelConsoleLabel.Text = "Modelo:";
            this.ModelConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // NameConsoleLabel
            // 
            this.NameConsoleLabel.AutoSize = true;
            this.NameConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NameConsoleLabel.Location = new System.Drawing.Point(8, 234);
            this.NameConsoleLabel.Name = "NameConsoleLabel";
            this.NameConsoleLabel.Size = new System.Drawing.Size(70, 27);
            this.NameConsoleLabel.TabIndex = 50;
            this.NameConsoleLabel.Text = "Nombre:";
            this.NameConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // ConsoleDate
            // 
            this.ConsoleDate.AutoSize = true;
            this.ConsoleDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ConsoleDate.Location = new System.Drawing.Point(8, 207);
            this.ConsoleDate.Name = "ConsoleDate";
            this.ConsoleDate.Size = new System.Drawing.Size(134, 27);
            this.ConsoleDate.TabIndex = 49;
            this.ConsoleDate.Text = "Fecha de compra:";
            this.ConsoleDate.UseCompatibleTextRendering = true;
            // 
            // DisplayPassButton
            // 
            this.DisplayPassButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.DisplayPassButton.IconColor = System.Drawing.Color.Black;
            this.DisplayPassButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DisplayPassButton.IconSize = 28;
            this.DisplayPassButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DisplayPassButton.Location = new System.Drawing.Point(188, 163);
            this.DisplayPassButton.Name = "DisplayPassButton";
            this.DisplayPassButton.Size = new System.Drawing.Size(30, 29);
            this.DisplayPassButton.TabIndex = 48;
            this.DisplayPassButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DisplayPassButton.UseVisualStyleBackColor = true;
            this.DisplayPassButton.Click += new System.EventHandler(this.DisplayPassButton_Click);
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.BackColor = System.Drawing.Color.Black;
            this.ChangeImageButton.FlatAppearance.BorderSize = 0;
            this.ChangeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeImageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ChangeImageButton.ForeColor = System.Drawing.Color.White;
            this.ChangeImageButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ChangeImageButton.IconColor = System.Drawing.Color.White;
            this.ChangeImageButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ChangeImageButton.IconSize = 20;
            this.ChangeImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeImageButton.Location = new System.Drawing.Point(8, 164);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(172, 30);
            this.ChangeImageButton.TabIndex = 47;
            this.ChangeImageButton.Text = "Cambiar Imagen";
            this.ChangeImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ChangeImageButton.UseVisualStyleBackColor = false;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(218, 163);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(158, 29);
            this.PassBox.TabIndex = 46;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(186, 108);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(188, 29);
            this.UsernameBox.TabIndex = 45;
            // 
            // PassConsoleLabel
            // 
            this.PassConsoleLabel.AutoSize = true;
            this.PassConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PassConsoleLabel.Location = new System.Drawing.Point(195, 142);
            this.PassConsoleLabel.Name = "PassConsoleLabel";
            this.PassConsoleLabel.Size = new System.Drawing.Size(171, 27);
            this.PassConsoleLabel.TabIndex = 44;
            this.PassConsoleLabel.Text = "Contraseña de consola";
            this.PassConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // UsernameConsoleLabel
            // 
            this.UsernameConsoleLabel.AutoSize = true;
            this.UsernameConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.UsernameConsoleLabel.Location = new System.Drawing.Point(208, 85);
            this.UsernameConsoleLabel.Name = "UsernameConsoleLabel";
            this.UsernameConsoleLabel.Size = new System.Drawing.Size(144, 27);
            this.UsernameConsoleLabel.TabIndex = 43;
            this.UsernameConsoleLabel.Text = "Usuario de consola";
            this.UsernameConsoleLabel.UseCompatibleTextRendering = true;
            // 
            // ImageBox
            // 
            this.ImageBox.Image = global::MainView.Properties.Resources.XboxDefImage;
            this.ImageBox.InitialImage = null;
            this.ImageBox.Location = new System.Drawing.Point(8, 6);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(172, 152);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 42;
            this.ImageBox.TabStop = false;
            // 
            // MetadataBox
            // 
            this.MetadataBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MetadataBox.Location = new System.Drawing.Point(8, 410);
            this.MetadataBox.MaxLength = 999;
            this.MetadataBox.Multiline = true;
            this.MetadataBox.Name = "MetadataBox";
            this.MetadataBox.Size = new System.Drawing.Size(365, 47);
            this.MetadataBox.TabIndex = 62;
            // 
            // MetadataLabel
            // 
            this.MetadataLabel.AutoSize = true;
            this.MetadataLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MetadataLabel.Location = new System.Drawing.Point(7, 380);
            this.MetadataLabel.Name = "MetadataLabel";
            this.MetadataLabel.Size = new System.Drawing.Size(135, 27);
            this.MetadataLabel.TabIndex = 61;
            this.MetadataLabel.Text = "Datos Adicionales";
            this.MetadataLabel.UseCompatibleTextRendering = true;
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
            this.CloseButton.Location = new System.Drawing.Point(350, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(126, 30);
            this.TitlePanel.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(11, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(105, 19);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Editar Consola";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(186, 58);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(182, 27);
            this.MessageLabel.TabIndex = 65;
            this.MessageLabel.Text = "*El valor por defecto durante el registro es \"Activo\"";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Activo",
            "Desactivado",
            "Ok",
            "Error"});
            this.StatusBox.Location = new System.Drawing.Point(186, 26);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(188, 29);
            this.StatusBox.TabIndex = 64;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(253, 6);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 27);
            this.StatusLabel.TabIndex = 63;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.UseCompatibleTextRendering = true;
            // 
            // SaveConsoleButton
            // 
            this.SaveConsoleButton.BackColor = System.Drawing.Color.Black;
            this.SaveConsoleButton.FlatAppearance.BorderSize = 0;
            this.SaveConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConsoleButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SaveConsoleButton.ForeColor = System.Drawing.Color.White;
            this.SaveConsoleButton.Location = new System.Drawing.Point(8, 469);
            this.SaveConsoleButton.Name = "SaveConsoleButton";
            this.SaveConsoleButton.Size = new System.Drawing.Size(366, 29);
            this.SaveConsoleButton.TabIndex = 66;
            this.SaveConsoleButton.Text = "Modificar Consola";
            this.SaveConsoleButton.UseCompatibleTextRendering = true;
            this.SaveConsoleButton.UseVisualStyleBackColor = true;
            this.SaveConsoleButton.Click += new System.EventHandler(this.SaveConsoleButton_Click);
            // 
            // display
            // 
            this.display.Interval = 5000;
            this.display.Tick += new System.EventHandler(this.display_Tick);
            // 
            // SaveButtonCheck
            // 
            this.SaveButtonCheck.Tick += new System.EventHandler(this.SaveButtonCheck_Tick);
            // 
            // EditConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 540);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(380, 540);
            this.MinimumSize = new System.Drawing.Size(380, 540);
            this.Name = "EditConsole";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Editar Consola";
            this.Load += new System.EventHandler(this.EditConsole_Load);
            this.MainPanel.ResumeLayout(false);
            this.Topbar.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.TextBox HWBox;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label HWLabel;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label SerialConsoleLabel;
        private System.Windows.Forms.Label ModelConsoleLabel;
        private System.Windows.Forms.Label NameConsoleLabel;
        private System.Windows.Forms.Label ConsoleDate;
        private FontAwesome.Sharp.IconButton DisplayPassButton;
        private FontAwesome.Sharp.IconButton ChangeImageButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label PassConsoleLabel;
        private System.Windows.Forms.Label UsernameConsoleLabel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.TextBox MetadataBox;
        private System.Windows.Forms.Label MetadataLabel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button SaveConsoleButton;
        private System.Windows.Forms.Timer display;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.Timer SaveButtonCheck;
    }
}
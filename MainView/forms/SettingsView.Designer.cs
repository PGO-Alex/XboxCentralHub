
namespace MainView.forms
{
    partial class SettingsView
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
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.DBSettings = new System.Windows.Forms.GroupBox();
            this.BuildedCSLabel = new System.Windows.Forms.Label();
            this.BuildedCSBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveNewDBChange = new System.Windows.Forms.Button();
            this.DBNameBox = new System.Windows.Forms.TextBox();
            this.DBNameLabel = new System.Windows.Forms.Label();
            this.PassCheck = new System.Windows.Forms.CheckBox();
            this.PortCheck = new System.Windows.Forms.CheckBox();
            this.UsernameCheck = new System.Windows.Forms.CheckBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.NewCSBox = new System.Windows.Forms.TextBox();
            this.CurrentConnBox = new System.Windows.Forms.TextBox();
            this.NewCSLabel = new System.Windows.Forms.Label();
            this.ThemeSettings = new System.Windows.Forms.GroupBox();
            this.RTextColorLabel = new System.Windows.Forms.Label();
            this.TextColorDownList = new System.Windows.Forms.ComboBox();
            this.TextColorLabel = new System.Windows.Forms.Label();
            this.RColorLabel = new System.Windows.Forms.Label();
            this.ColorDownList = new System.Windows.Forms.ComboBox();
            this.AppColor = new System.Windows.Forms.Label();
            this.BuildNewDBCS = new System.Windows.Forms.Timer(this.components);
            this.CurrentCSLabel = new System.Windows.Forms.Label();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.WindowNamePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.MainFormPanel.SuspendLayout();
            this.DBSettings.SuspendLayout();
            this.ThemeSettings.SuspendLayout();
            this.TopBarPanel.SuspendLayout();
            this.WindowNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.Controls.Add(this.DBSettings);
            this.MainFormPanel.Controls.Add(this.ThemeSettings);
            this.MainFormPanel.Controls.Add(this.TopBarPanel);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(720, 470);
            this.MainFormPanel.TabIndex = 0;
            // 
            // DBSettings
            // 
            this.DBSettings.Controls.Add(this.BuildedCSLabel);
            this.DBSettings.Controls.Add(this.BuildedCSBox);
            this.DBSettings.Controls.Add(this.button2);
            this.DBSettings.Controls.Add(this.SaveNewDBChange);
            this.DBSettings.Controls.Add(this.DBNameBox);
            this.DBSettings.Controls.Add(this.DBNameLabel);
            this.DBSettings.Controls.Add(this.PassCheck);
            this.DBSettings.Controls.Add(this.PortCheck);
            this.DBSettings.Controls.Add(this.UsernameCheck);
            this.DBSettings.Controls.Add(this.PassBox);
            this.DBSettings.Controls.Add(this.PassLabel);
            this.DBSettings.Controls.Add(this.UsernameBox);
            this.DBSettings.Controls.Add(this.UsernameLabel);
            this.DBSettings.Controls.Add(this.PortBox);
            this.DBSettings.Controls.Add(this.PortLabel);
            this.DBSettings.Controls.Add(this.IpBox);
            this.DBSettings.Controls.Add(this.IPLabel);
            this.DBSettings.Controls.Add(this.CommentLabel);
            this.DBSettings.Controls.Add(this.NewCSBox);
            this.DBSettings.Controls.Add(this.CurrentConnBox);
            this.DBSettings.Controls.Add(this.CurrentCSLabel);
            this.DBSettings.Controls.Add(this.NewCSLabel);
            this.DBSettings.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DBSettings.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.DBSettings.Location = new System.Drawing.Point(265, 36);
            this.DBSettings.Name = "DBSettings";
            this.DBSettings.Size = new System.Drawing.Size(452, 431);
            this.DBSettings.TabIndex = 4;
            this.DBSettings.TabStop = false;
            this.DBSettings.Text = "Configuracion de base de datos";
            // 
            // BuildedCSLabel
            // 
            this.BuildedCSLabel.AutoSize = true;
            this.BuildedCSLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BuildedCSLabel.Location = new System.Drawing.Point(6, 335);
            this.BuildedCSLabel.Name = "BuildedCSLabel";
            this.BuildedCSLabel.Size = new System.Drawing.Size(191, 20);
            this.BuildedCSLabel.TabIndex = 22;
            this.BuildedCSLabel.Text = "Nueva cadena de conexion:";
            // 
            // BuildedCSBox
            // 
            this.BuildedCSBox.Enabled = false;
            this.BuildedCSBox.Location = new System.Drawing.Point(9, 365);
            this.BuildedCSBox.Name = "BuildedCSBox";
            this.BuildedCSBox.ReadOnly = true;
            this.BuildedCSBox.Size = new System.Drawing.Size(437, 26);
            this.BuildedCSBox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveNewDBChange
            // 
            this.SaveNewDBChange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SaveNewDBChange.Location = new System.Drawing.Point(234, 398);
            this.SaveNewDBChange.Name = "SaveNewDBChange";
            this.SaveNewDBChange.Size = new System.Drawing.Size(100, 30);
            this.SaveNewDBChange.TabIndex = 19;
            this.SaveNewDBChange.Text = "Guardar";
            this.SaveNewDBChange.UseCompatibleTextRendering = true;
            this.SaveNewDBChange.UseVisualStyleBackColor = true;
            this.SaveNewDBChange.Click += new System.EventHandler(this.SaveNewDBChange_Click);
            // 
            // DBNameBox
            // 
            this.DBNameBox.Location = new System.Drawing.Point(96, 237);
            this.DBNameBox.Name = "DBNameBox";
            this.DBNameBox.Size = new System.Drawing.Size(161, 26);
            this.DBNameBox.TabIndex = 18;
            // 
            // DBNameLabel
            // 
            this.DBNameLabel.AutoSize = true;
            this.DBNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DBNameLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.DBNameLabel.Location = new System.Drawing.Point(6, 236);
            this.DBNameLabel.Name = "DBNameLabel";
            this.DBNameLabel.Size = new System.Drawing.Size(91, 20);
            this.DBNameLabel.TabIndex = 17;
            this.DBNameLabel.Text = "DB Nombre:";
            // 
            // PassCheck
            // 
            this.PassCheck.AutoSize = true;
            this.PassCheck.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PassCheck.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.PassCheck.Location = new System.Drawing.Point(270, 268);
            this.PassCheck.Name = "PassCheck";
            this.PassCheck.Size = new System.Drawing.Size(155, 24);
            this.PassCheck.TabIndex = 16;
            this.PassCheck.Text = "No usar contraseña";
            this.PassCheck.UseVisualStyleBackColor = true;
            this.PassCheck.CheckedChanged += new System.EventHandler(this.PassCheck_CheckedChanged);
            // 
            // PortCheck
            // 
            this.PortCheck.AutoSize = true;
            this.PortCheck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PortCheck.Location = new System.Drawing.Point(270, 302);
            this.PortCheck.Name = "PortCheck";
            this.PortCheck.Size = new System.Drawing.Size(127, 24);
            this.PortCheck.TabIndex = 15;
            this.PortCheck.Text = "No usar puerto";
            this.PortCheck.UseVisualStyleBackColor = true;
            this.PortCheck.CheckedChanged += new System.EventHandler(this.PortCheck_CheckedChanged);
            // 
            // UsernameCheck
            // 
            this.UsernameCheck.AutoSize = true;
            this.UsernameCheck.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsernameCheck.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.UsernameCheck.Location = new System.Drawing.Point(270, 202);
            this.UsernameCheck.Name = "UsernameCheck";
            this.UsernameCheck.Size = new System.Drawing.Size(131, 24);
            this.UsernameCheck.TabIndex = 14;
            this.UsernameCheck.Text = "No usar usuario";
            this.UsernameCheck.UseVisualStyleBackColor = true;
            this.UsernameCheck.CheckedChanged += new System.EventHandler(this.UsernameCheck_CheckedChanged);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(96, 271);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(161, 26);
            this.PassBox.TabIndex = 12;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PassLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.PassLabel.Location = new System.Drawing.Point(6, 270);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(86, 20);
            this.PassLabel.TabIndex = 11;
            this.PassLabel.Text = "Contraseña:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(96, 203);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(161, 26);
            this.UsernameBox.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsernameLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 202);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(62, 20);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Usuario:";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(96, 304);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(161, 26);
            this.PortBox.TabIndex = 8;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PortLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.PortLabel.Location = new System.Drawing.Point(6, 304);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(55, 20);
            this.PortLabel.TabIndex = 7;
            this.PortLabel.Text = "Puerto:";
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(96, 172);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(161, 26);
            this.IpBox.TabIndex = 6;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IPLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.IPLabel.Location = new System.Drawing.Point(5, 171);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(91, 20);
            this.IPLabel.TabIndex = 5;
            this.IPLabel.Text = "Direccion IP:";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CommentLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.CommentLabel.ForeColor = System.Drawing.Color.Brown;
            this.CommentLabel.Location = new System.Drawing.Point(6, 145);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(300, 15);
            this.CommentLabel.TabIndex = 4;
            this.CommentLabel.Text = "*Pegue su nueva cadena de conexion o puede contruirla";
            // 
            // NewCSBox
            // 
            this.NewCSBox.Location = new System.Drawing.Point(9, 116);
            this.NewCSBox.Name = "NewCSBox";
            this.NewCSBox.Size = new System.Drawing.Size(437, 26);
            this.NewCSBox.TabIndex = 3;
            this.NewCSBox.TextChanged += new System.EventHandler(this.NewCSBox_TextChanged);
            // 
            // CurrentConnBox
            // 
            this.CurrentConnBox.Enabled = false;
            this.CurrentConnBox.Location = new System.Drawing.Point(9, 56);
            this.CurrentConnBox.Name = "CurrentConnBox";
            this.CurrentConnBox.ReadOnly = true;
            this.CurrentConnBox.Size = new System.Drawing.Size(437, 26);
            this.CurrentConnBox.TabIndex = 2;
            // 
            // NewCSLabel
            // 
            this.NewCSLabel.AutoSize = true;
            this.NewCSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewCSLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.NewCSLabel.Location = new System.Drawing.Point(6, 91);
            this.NewCSLabel.Name = "NewCSLabel";
            this.NewCSLabel.Size = new System.Drawing.Size(188, 20);
            this.NewCSLabel.TabIndex = 0;
            this.NewCSLabel.Text = "Nueva cadena de conexion";
            // 
            // ThemeSettings
            // 
            this.ThemeSettings.Controls.Add(this.RTextColorLabel);
            this.ThemeSettings.Controls.Add(this.TextColorDownList);
            this.ThemeSettings.Controls.Add(this.TextColorLabel);
            this.ThemeSettings.Controls.Add(this.RColorLabel);
            this.ThemeSettings.Controls.Add(this.ColorDownList);
            this.ThemeSettings.Controls.Add(this.AppColor);
            this.ThemeSettings.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeSettings.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.ThemeSettings.Location = new System.Drawing.Point(3, 33);
            this.ThemeSettings.Name = "ThemeSettings";
            this.ThemeSettings.Size = new System.Drawing.Size(256, 259);
            this.ThemeSettings.TabIndex = 3;
            this.ThemeSettings.TabStop = false;
            this.ThemeSettings.Text = "Configuracion visual";
            // 
            // RTextColorLabel
            // 
            this.RTextColorLabel.AutoSize = true;
            this.RTextColorLabel.Location = new System.Drawing.Point(9, 191);
            this.RTextColorLabel.Name = "RTextColorLabel";
            this.RTextColorLabel.Size = new System.Drawing.Size(0, 20);
            this.RTextColorLabel.TabIndex = 7;
            // 
            // TextColorDownList
            // 
            this.TextColorDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextColorDownList.FormattingEnabled = true;
            this.TextColorDownList.Location = new System.Drawing.Point(3, 161);
            this.TextColorDownList.Name = "TextColorDownList";
            this.TextColorDownList.Size = new System.Drawing.Size(247, 27);
            this.TextColorDownList.TabIndex = 6;
            this.TextColorDownList.SelectedValueChanged += new System.EventHandler(this.TextColorDownList_SelectedValueChanged);
            // 
            // TextColorLabel
            // 
            this.TextColorLabel.AutoSize = true;
            this.TextColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextColorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextColorLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.TextColorLabel.ForeColor = System.Drawing.Color.Black;
            this.TextColorLabel.Location = new System.Drawing.Point(9, 136);
            this.TextColorLabel.Name = "TextColorLabel";
            this.TextColorLabel.Size = new System.Drawing.Size(104, 20);
            this.TextColorLabel.TabIndex = 5;
            this.TextColorLabel.Text = "Color de texto";
            // 
            // RColorLabel
            // 
            this.RColorLabel.AutoSize = true;
            this.RColorLabel.Location = new System.Drawing.Point(9, 88);
            this.RColorLabel.Name = "RColorLabel";
            this.RColorLabel.Size = new System.Drawing.Size(0, 20);
            this.RColorLabel.TabIndex = 4;
            // 
            // ColorDownList
            // 
            this.ColorDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorDownList.FormattingEnabled = true;
            this.ColorDownList.Location = new System.Drawing.Point(3, 58);
            this.ColorDownList.Name = "ColorDownList";
            this.ColorDownList.Size = new System.Drawing.Size(247, 27);
            this.ColorDownList.TabIndex = 3;
            this.ColorDownList.SelectedValueChanged += new System.EventHandler(this.ColorDownList_SelectedValueChanged);
            // 
            // AppColor
            // 
            this.AppColor.AutoSize = true;
            this.AppColor.Location = new System.Drawing.Point(9, 35);
            this.AppColor.Name = "AppColor";
            this.AppColor.Size = new System.Drawing.Size(138, 20);
            this.AppColor.TabIndex = 2;
            this.AppColor.Text = "Color de aplicacion";
            // 
            // BuildNewDBCS
            // 
            this.BuildNewDBCS.Tick += new System.EventHandler(this.BuildNewDBCS_Tick);
            // 
            // CurrentCSLabel
            // 
            this.CurrentCSLabel.AutoSize = true;
            this.CurrentCSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CurrentCSLabel.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.CurrentCSLabel.Location = new System.Drawing.Point(6, 28);
            this.CurrentCSLabel.Name = "CurrentCSLabel";
            this.CurrentCSLabel.Size = new System.Drawing.Size(188, 20);
            this.CurrentCSLabel.TabIndex = 1;
            this.CurrentCSLabel.Text = "Cadena de conexion actual";
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.TopBarPanel.Controls.Add(this.WindowNamePanel);
            this.TopBarPanel.Controls.Add(this.CloseButton);
            this.TopBarPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(720, 30);
            this.TopBarPanel.TabIndex = 0;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // WindowNamePanel
            // 
            this.WindowNamePanel.Controls.Add(this.TitleLabel);
            this.WindowNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowNamePanel.Location = new System.Drawing.Point(0, 0);
            this.WindowNamePanel.Name = "WindowNamePanel";
            this.WindowNamePanel.Size = new System.Drawing.Size(259, 30);
            this.WindowNamePanel.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TitleLabel.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.TitleLabel.Location = new System.Drawing.Point(23, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(212, 19);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Configuracion de la aplicacion";
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
            this.CloseButton.Location = new System.Drawing.Point(690, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Controls.Add(this.MainFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.MainFormPanel.ResumeLayout(false);
            this.DBSettings.ResumeLayout(false);
            this.DBSettings.PerformLayout();
            this.ThemeSettings.ResumeLayout(false);
            this.ThemeSettings.PerformLayout();
            this.TopBarPanel.ResumeLayout(false);
            this.WindowNamePanel.ResumeLayout(false);
            this.WindowNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.Panel TopBarPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.GroupBox ThemeSettings;
        private System.Windows.Forms.Label AppColor;
        private System.Windows.Forms.ComboBox ColorDownList;
        private System.Windows.Forms.Label RColorLabel;
        private System.Windows.Forms.ComboBox TextColorDownList;
        private System.Windows.Forms.Label TextColorLabel;
        private System.Windows.Forms.Label RTextColorLabel;
        private System.Windows.Forms.GroupBox DBSettings;
        private System.Windows.Forms.Label NewCSLabel;
        private System.Windows.Forms.TextBox CurrentConnBox;
        private System.Windows.Forms.Label CurrentCSLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox NewCSBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox DBNameBox;
        private System.Windows.Forms.Label DBNameLabel;
        private System.Windows.Forms.CheckBox PassCheck;
        private System.Windows.Forms.CheckBox PortCheck;
        private System.Windows.Forms.CheckBox UsernameCheck;
        private System.Windows.Forms.Button SaveNewDBChange;
        private System.Windows.Forms.Label BuildedCSLabel;
        private System.Windows.Forms.TextBox BuildedCSBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel WindowNamePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Timer BuildNewDBCS;
    }
}
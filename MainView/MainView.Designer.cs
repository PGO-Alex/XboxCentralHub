
namespace MainView
{
    partial class XboxCentralHub
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ChildPanelBot = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.AboutThisButton = new FontAwesome.Sharp.IconButton();
            this.UpdateConsoleList = new FontAwesome.Sharp.IconButton();
            this.ConfigButton = new FontAwesome.Sharp.IconButton();
            this.GenReportButton = new FontAwesome.Sharp.IconButton();
            this.AddConsoleButton = new FontAwesome.Sharp.IconButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.TimeCounterBox = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CalendarBox = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColapseButton = new FontAwesome.Sharp.IconButton();
            this.BotPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modernLabel1 = new DevLib.ModernUI.Forms.ModernLabel();
            this.AuthorLink = new ReaLTaiizor.Controls.MetroLinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckDBButton = new System.Windows.Forms.Button();
            this.DBstatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AppTitle = new System.Windows.Forms.Label();
            this.LogoIcon = new FontAwesome.Sharp.IconButton();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.MaxButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BotPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ControlPanel);
            this.MainPanel.Controls.Add(this.BotPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 600);
            this.MainPanel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.DataPanel);
            this.ControlPanel.Controls.Add(this.SidePanel);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 30);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1000, 540);
            this.ControlPanel.TabIndex = 2;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.ContentPanel);
            this.DataPanel.Controls.Add(this.ToolsPanel);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(260, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(740, 540);
            this.DataPanel.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ChildPanelBot);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(740, 510);
            this.ContentPanel.TabIndex = 1;
            // 
            // ChildPanelBot
            // 
            this.ChildPanelBot.AutoScroll = true;
            this.ChildPanelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanelBot.Location = new System.Drawing.Point(0, 0);
            this.ChildPanelBot.Name = "ChildPanelBot";
            this.ChildPanelBot.Size = new System.Drawing.Size(740, 510);
            this.ChildPanelBot.TabIndex = 2;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.ToolsPanel.Controls.Add(this.AboutThisButton);
            this.ToolsPanel.Controls.Add(this.UpdateConsoleList);
            this.ToolsPanel.Controls.Add(this.ConfigButton);
            this.ToolsPanel.Controls.Add(this.GenReportButton);
            this.ToolsPanel.Controls.Add(this.AddConsoleButton);
            this.ToolsPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(740, 30);
            this.ToolsPanel.TabIndex = 0;
            // 
            // AboutThisButton
            // 
            this.AboutThisButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AboutThisButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AboutThisButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AboutThisButton.FlatAppearance.BorderSize = 0;
            this.AboutThisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AboutThisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutThisButton.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.AboutThisButton.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.AboutThisButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.AboutThisButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutThisButton.IconSize = 30;
            this.AboutThisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutThisButton.Location = new System.Drawing.Point(460, 0);
            this.AboutThisButton.Name = "AboutThisButton";
            this.AboutThisButton.Size = new System.Drawing.Size(99, 30);
            this.AboutThisButton.TabIndex = 14;
            this.AboutThisButton.Text = "Acerca de ";
            this.AboutThisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AboutThisButton.UseCompatibleTextRendering = true;
            this.AboutThisButton.UseVisualStyleBackColor = false;
            this.AboutThisButton.Click += new System.EventHandler(this.AboutThisButton_Click);
            // 
            // UpdateConsoleList
            // 
            this.UpdateConsoleList.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateConsoleList.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateConsoleList.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdateConsoleList.FlatAppearance.BorderSize = 0;
            this.UpdateConsoleList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.UpdateConsoleList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateConsoleList.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.UpdateConsoleList.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.UpdateConsoleList.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.UpdateConsoleList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateConsoleList.IconSize = 30;
            this.UpdateConsoleList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateConsoleList.Location = new System.Drawing.Point(335, 0);
            this.UpdateConsoleList.Name = "UpdateConsoleList";
            this.UpdateConsoleList.Size = new System.Drawing.Size(125, 30);
            this.UpdateConsoleList.TabIndex = 13;
            this.UpdateConsoleList.Text = "Actualizar lista de consolas";
            this.UpdateConsoleList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UpdateConsoleList.UseCompatibleTextRendering = true;
            this.UpdateConsoleList.UseVisualStyleBackColor = false;
            this.UpdateConsoleList.Click += new System.EventHandler(this.UpdateConsoleList_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ConfigButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConfigButton.FlatAppearance.BorderSize = 0;
            this.ConfigButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.ConfigButton.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ConfigButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.ConfigButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConfigButton.IconSize = 30;
            this.ConfigButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigButton.Location = new System.Drawing.Point(210, 0);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(125, 30);
            this.ConfigButton.TabIndex = 11;
            this.ConfigButton.Text = "Configuracion de la aplicacion";
            this.ConfigButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ConfigButton.UseCompatibleTextRendering = true;
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // GenReportButton
            // 
            this.GenReportButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GenReportButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GenReportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenReportButton.FlatAppearance.BorderSize = 0;
            this.GenReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.GenReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenReportButton.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.GenReportButton.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.GenReportButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.GenReportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GenReportButton.IconSize = 30;
            this.GenReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenReportButton.Location = new System.Drawing.Point(91, 0);
            this.GenReportButton.Name = "GenReportButton";
            this.GenReportButton.Size = new System.Drawing.Size(119, 30);
            this.GenReportButton.TabIndex = 9;
            this.GenReportButton.Text = "Generar Reporte Diario";
            this.GenReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GenReportButton.UseCompatibleTextRendering = true;
            this.GenReportButton.UseVisualStyleBackColor = false;
            this.GenReportButton.Click += new System.EventHandler(this.GenReportButton_Click);
            // 
            // AddConsoleButton
            // 
            this.AddConsoleButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AddConsoleButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AddConsoleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddConsoleButton.FlatAppearance.BorderSize = 0;
            this.AddConsoleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConsoleButton.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.AddConsoleButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddConsoleButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.AddConsoleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddConsoleButton.IconSize = 30;
            this.AddConsoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddConsoleButton.Location = new System.Drawing.Point(0, 0);
            this.AddConsoleButton.Name = "AddConsoleButton";
            this.AddConsoleButton.Size = new System.Drawing.Size(91, 30);
            this.AddConsoleButton.TabIndex = 8;
            this.AddConsoleButton.Text = "Agregar Consola";
            this.AddConsoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddConsoleButton.UseCompatibleTextRendering = true;
            this.AddConsoleButton.UseVisualStyleBackColor = false;
            this.AddConsoleButton.Click += new System.EventHandler(this.AddConsoleButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.SidePanel.Controls.Add(this.TimeCounterBox);
            this.SidePanel.Controls.Add(this.TimeLabel);
            this.SidePanel.Controls.Add(this.CalendarBox);
            this.SidePanel.Controls.Add(this.panel2);
            this.SidePanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(260, 540);
            this.SidePanel.TabIndex = 0;
            // 
            // TimeCounterBox
            // 
            this.TimeCounterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TimeCounterBox.AutoSize = true;
            this.TimeCounterBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimeCounterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeCounterBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCounterBox.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.TimeCounterBox.Location = new System.Drawing.Point(36, 67);
            this.TimeCounterBox.Name = "TimeCounterBox";
            this.TimeCounterBox.Size = new System.Drawing.Size(0, 48);
            this.TimeCounterBox.TabIndex = 5;
            this.TimeCounterBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeCounterBox.UseCompatibleTextRendering = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.TimeLabel.Location = new System.Drawing.Point(73, 33);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(120, 30);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Hora actual";
            // 
            // CalendarBox
            // 
            this.CalendarBox.Location = new System.Drawing.Point(6, 125);
            this.CalendarBox.Name = "CalendarBox";
            this.CalendarBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ColapseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 30);
            this.panel2.TabIndex = 0;
            // 
            // ColapseButton
            // 
            this.ColapseButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ColapseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColapseButton.FlatAppearance.BorderSize = 0;
            this.ColapseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ColapseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.ColapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColapseButton.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.ColapseButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.ColapseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ColapseButton.IconSize = 28;
            this.ColapseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ColapseButton.Location = new System.Drawing.Point(220, 0);
            this.ColapseButton.Name = "ColapseButton";
            this.ColapseButton.Size = new System.Drawing.Size(40, 30);
            this.ColapseButton.TabIndex = 0;
            this.ColapseButton.UseVisualStyleBackColor = true;
            this.ColapseButton.Click += new System.EventHandler(this.ColapseButton_Click);
            // 
            // BotPanel
            // 
            this.BotPanel.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.BotPanel.Controls.Add(this.panel3);
            this.BotPanel.Controls.Add(this.panel1);
            this.BotPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotPanel.Location = new System.Drawing.Point(0, 570);
            this.BotPanel.Name = "BotPanel";
            this.BotPanel.Size = new System.Drawing.Size(1000, 30);
            this.BotPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.modernLabel1);
            this.panel3.Controls.Add(this.AuthorLink);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 30);
            this.panel3.TabIndex = 5;
            // 
            // modernLabel1
            // 
            this.modernLabel1.AutoSize = true;
            this.modernLabel1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modernLabel1.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.modernLabel1.Location = new System.Drawing.Point(3, 5);
            this.modernLabel1.Name = "modernLabel1";
            this.modernLabel1.Size = new System.Drawing.Size(124, 19);
            this.modernLabel1.TabIndex = 8;
            this.modernLabel1.Text = "Created with ❤ by";
            this.modernLabel1.UseCustomBackColor = true;
            this.modernLabel1.UseCustomForeColor = true;
            this.modernLabel1.UseStyleColors = false;
            // 
            // AuthorLink
            // 
            this.AuthorLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.AuthorLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AuthorLink.IsDerivedStyle = true;
            this.AuthorLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AuthorLink.Location = new System.Drawing.Point(118, 0);
            this.AuthorLink.Name = "AuthorLink";
            this.AuthorLink.Size = new System.Drawing.Size(109, 30);
            this.AuthorLink.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.AuthorLink.StyleManager = null;
            this.AuthorLink.TabIndex = 9;
            this.AuthorLink.TabStop = true;
            this.AuthorLink.Text = "Alex Guevara";
            this.AuthorLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorLink.ThemeAuthor = "Taiizor";
            this.AuthorLink.ThemeName = "MetroLight";
            this.AuthorLink.UseCompatibleTextRendering = true;
            this.AuthorLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.AuthorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLink_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CheckDBButton);
            this.panel1.Controls.Add(this.DBstatusLabel);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Location = new System.Drawing.Point(720, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 30);
            this.panel1.TabIndex = 4;
            // 
            // CheckDBButton
            // 
            this.CheckDBButton.BackColor = System.Drawing.Color.White;
            this.CheckDBButton.FlatAppearance.BorderSize = 0;
            this.CheckDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDBButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CheckDBButton.Location = new System.Drawing.Point(13, 4);
            this.CheckDBButton.Name = "CheckDBButton";
            this.CheckDBButton.Size = new System.Drawing.Size(90, 23);
            this.CheckDBButton.TabIndex = 6;
            this.CheckDBButton.Text = "Check DB";
            this.CheckDBButton.UseCompatibleTextRendering = true;
            this.CheckDBButton.UseVisualStyleBackColor = false;
            this.CheckDBButton.Click += new System.EventHandler(this.CheckDBButton_Click);
            // 
            // DBstatusLabel
            // 
            this.DBstatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DBstatusLabel.AutoSize = true;
            this.DBstatusLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DBstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DBstatusLabel.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.DBstatusLabel.Location = new System.Drawing.Point(109, 5);
            this.DBstatusLabel.Name = "DBstatusLabel";
            this.DBstatusLabel.Size = new System.Drawing.Size(101, 19);
            this.DBstatusLabel.TabIndex = 5;
            this.DBstatusLabel.Text = "DataBase Status:";
            this.DBstatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DBstatusLabel.UseCompatibleTextRendering = true;
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StatusBox.Location = new System.Drawing.Point(215, 9);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(56, 13);
            this.StatusBox.TabIndex = 4;
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.TopPanel.Controls.Add(this.AppTitle);
            this.TopPanel.Controls.Add(this.LogoIcon);
            this.TopPanel.Controls.Add(this.MinButton);
            this.TopPanel.Controls.Add(this.MaxButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AppTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainView.Properties.Settings.Default, "AppTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AppTitle.ForeColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.AppTitle.Location = new System.Drawing.Point(36, 5);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(140, 24);
            this.AppTitle.TabIndex = 4;
            this.AppTitle.Text = global::MainView.Properties.Settings.Default.AppTitle;
            this.AppTitle.UseCompatibleTextRendering = true;
            // 
            // LogoIcon
            // 
            this.LogoIcon.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LogoIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoIcon.FlatAppearance.BorderSize = 0;
            this.LogoIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogoIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoIcon.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.LogoIcon.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.LogoIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoIcon.IconSize = 30;
            this.LogoIcon.Location = new System.Drawing.Point(0, 0);
            this.LogoIcon.Name = "LogoIcon";
            this.LogoIcon.Size = new System.Drawing.Size(30, 30);
            this.LogoIcon.TabIndex = 3;
            this.LogoIcon.UseVisualStyleBackColor = true;
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
            this.MinButton.Location = new System.Drawing.Point(910, 0);
            this.MinButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(30, 30);
            this.MinButton.TabIndex = 2;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.BackColor = System.Drawing.Color.Transparent;
            this.MaxButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxButton.FlatAppearance.BorderSize = 0;
            this.MaxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MaxButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaxButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.MaxButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaxButton.IconSize = 30;
            this.MaxButton.Location = new System.Drawing.Point(940, 0);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(30, 30);
            this.MaxButton.TabIndex = 1;
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
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
            this.CloseButton.Location = new System.Drawing.Point(970, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 900;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // XboxCentralHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MainPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MainView.Properties.Settings.Default, "AppTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XboxCentralHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::MainView.Properties.Settings.Default.AppTitle;
            this.MainPanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.BotPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton MaxButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private System.Windows.Forms.Panel BotPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ColapseButton;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel ToolsPanel;
        private FontAwesome.Sharp.IconButton LogoIcon;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DBstatusLabel;
        private System.Windows.Forms.TextBox StatusBox;
        private FontAwesome.Sharp.IconButton ConfigButton;
        private FontAwesome.Sharp.IconButton GenReportButton;
        private FontAwesome.Sharp.IconButton AddConsoleButton;
        private System.Windows.Forms.Panel ChildPanelBot;
        private System.Windows.Forms.Panel panel3;
        private DevLib.ModernUI.Forms.ModernLabel modernLabel1;
        private ReaLTaiizor.Controls.MetroLinkLabel AuthorLink;
        private FontAwesome.Sharp.IconButton UpdateConsoleList;
        private System.Windows.Forms.MonthCalendar CalendarBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label TimeCounterBox;
        private FontAwesome.Sharp.IconButton AboutThisButton;
        private System.Windows.Forms.Button CheckDBButton;
    }
}


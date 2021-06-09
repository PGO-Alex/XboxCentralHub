
namespace MainView.CustomControls
{
    partial class ConsoleListItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConsolePanel = new DevLib.ModernUI.Forms.ModernPanel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.RentTimeBox = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RentButton = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.Label();
            this.HorasTBox = new System.Windows.Forms.Label();
            this.IpBox = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.Label();
            this.FechaCompraBox = new System.Windows.Forms.Label();
            this.ConsoleName = new System.Windows.Forms.Label();
            this.LblDelete = new System.Windows.Forms.Label();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.ConsoleInfoLbl = new System.Windows.Forms.Label();
            this.HorasTrabajolbl = new System.Windows.Forms.Label();
            this.IpLbl = new System.Windows.Forms.Label();
            this.SerialLbl = new System.Windows.Forms.Label();
            this.Modelbl = new System.Windows.Forms.Label();
            this.FechaCompralbl = new System.Windows.Forms.Label();
            this.ConsoleInfoBox = new DevLib.ModernUI.Forms.ModernTextBox();
            this.RentTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckConn = new System.Windows.Forms.Timer(this.components);
            this.ConsolePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.AutoSize = true;
            this.ConsolePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsolePanel.Controls.Add(this.ImageBox);
            this.ConsolePanel.Controls.Add(this.RentTimeBox);
            this.ConsolePanel.Controls.Add(this.IdLabel);
            this.ConsolePanel.Controls.Add(this.label3);
            this.ConsolePanel.Controls.Add(this.RentButton);
            this.ConsolePanel.Controls.Add(this.label5);
            this.ConsolePanel.Controls.Add(this.StatusBox);
            this.ConsolePanel.Controls.Add(this.HorasTBox);
            this.ConsolePanel.Controls.Add(this.IpBox);
            this.ConsolePanel.Controls.Add(this.SerialBox);
            this.ConsolePanel.Controls.Add(this.ModelBox);
            this.ConsolePanel.Controls.Add(this.FechaCompraBox);
            this.ConsolePanel.Controls.Add(this.ConsoleName);
            this.ConsolePanel.Controls.Add(this.LblDelete);
            this.ConsolePanel.Controls.Add(this.DeleteButton);
            this.ConsolePanel.Controls.Add(this.StatusLbl);
            this.ConsolePanel.Controls.Add(this.EditButton);
            this.ConsolePanel.Controls.Add(this.ConsoleInfoLbl);
            this.ConsolePanel.Controls.Add(this.HorasTrabajolbl);
            this.ConsolePanel.Controls.Add(this.IpLbl);
            this.ConsolePanel.Controls.Add(this.SerialLbl);
            this.ConsolePanel.Controls.Add(this.Modelbl);
            this.ConsolePanel.Controls.Add(this.FechaCompralbl);
            this.ConsolePanel.Controls.Add(this.ConsoleInfoBox);
            this.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsolePanel.HorizontalScrollBarSize = 10;
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(300, 500);
            this.ConsolePanel.TabIndex = 2;
            this.ConsolePanel.UseHorizontalBarColor = true;
            this.ConsolePanel.UseStyleColors = false;
            this.ConsolePanel.UseVerticalBarColor = true;
            this.ConsolePanel.VerticalScrollBarSize = 10;
            // 
            // ImageBox
            // 
            this.ImageBox.InitialImage = null;
            this.ImageBox.Location = new System.Drawing.Point(13, 24);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(200, 200);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 44;
            this.ImageBox.TabStop = false;
            // 
            // RentTimeBox
            // 
            this.RentTimeBox.AutoSize = true;
            this.RentTimeBox.BackColor = System.Drawing.Color.Transparent;
            this.RentTimeBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RentTimeBox.Location = new System.Drawing.Point(189, 435);
            this.RentTimeBox.Name = "RentTimeBox";
            this.RentTimeBox.Size = new System.Drawing.Size(63, 19);
            this.RentTimeBox.TabIndex = 41;
            this.RentTimeBox.Text = "00:00:00";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(247, 5);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(35, 13);
            this.IdLabel.TabIndex = 42;
            this.IdLabel.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(161, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tiempo de renta:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // RentButton
            // 
            this.RentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.RentButton.IconColor = System.Drawing.Color.Black;
            this.RentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RentButton.IconSize = 30;
            this.RentButton.Location = new System.Drawing.Point(9, 420);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(148, 30);
            this.RentButton.TabIndex = 38;
            this.RentButton.Text = "Rentar Consola";
            this.RentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 42);
            this.label5.TabIndex = 36;
            this.label5.Text = "Editar Consola";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(142, 319);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(47, 19);
            this.StatusBox.TabIndex = 35;
            this.StatusBox.Text = "Status";
            // 
            // HorasTBox
            // 
            this.HorasTBox.AutoSize = true;
            this.HorasTBox.BackColor = System.Drawing.Color.Transparent;
            this.HorasTBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HorasTBox.Location = new System.Drawing.Point(142, 300);
            this.HorasTBox.Name = "HorasTBox";
            this.HorasTBox.Size = new System.Drawing.Size(113, 19);
            this.HorasTBox.TabIndex = 34;
            this.HorasTBox.Text = "Horas Trabajadas";
            // 
            // IpBox
            // 
            this.IpBox.AutoSize = true;
            this.IpBox.BackColor = System.Drawing.Color.Transparent;
            this.IpBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IpBox.Location = new System.Drawing.Point(142, 281);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(81, 19);
            this.IpBox.TabIndex = 33;
            this.IpBox.Text = "Direccion IP";
            // 
            // SerialBox
            // 
            this.SerialBox.AutoSize = true;
            this.SerialBox.BackColor = System.Drawing.Color.Transparent;
            this.SerialBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialBox.Location = new System.Drawing.Point(142, 262);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(41, 19);
            this.SerialBox.TabIndex = 32;
            this.SerialBox.Text = "Serial";
            // 
            // ModelBox
            // 
            this.ModelBox.AutoSize = true;
            this.ModelBox.BackColor = System.Drawing.Color.Transparent;
            this.ModelBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ModelBox.Location = new System.Drawing.Point(142, 243);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(56, 19);
            this.ModelBox.TabIndex = 31;
            this.ModelBox.Text = "Modelo";
            // 
            // FechaCompraBox
            // 
            this.FechaCompraBox.AutoSize = true;
            this.FechaCompraBox.BackColor = System.Drawing.Color.Transparent;
            this.FechaCompraBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FechaCompraBox.Location = new System.Drawing.Point(142, 224);
            this.FechaCompraBox.Name = "FechaCompraBox";
            this.FechaCompraBox.Size = new System.Drawing.Size(113, 19);
            this.FechaCompraBox.TabIndex = 30;
            this.FechaCompraBox.Text = "Fecha de compra";
            // 
            // ConsoleName
            // 
            this.ConsoleName.AutoSize = true;
            this.ConsoleName.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ConsoleName.ForeColor = System.Drawing.Color.Black;
            this.ConsoleName.Location = new System.Drawing.Point(119, 1);
            this.ConsoleName.Name = "ConsoleName";
            this.ConsoleName.Size = new System.Drawing.Size(62, 19);
            this.ConsoleName.TabIndex = 29;
            this.ConsoleName.Text = "Consola";
            // 
            // LblDelete
            // 
            this.LblDelete.BackColor = System.Drawing.Color.Transparent;
            this.LblDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblDelete.ForeColor = System.Drawing.Color.Black;
            this.LblDelete.Location = new System.Drawing.Point(221, 24);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(63, 42);
            this.LblDelete.TabIndex = 15;
            this.LblDelete.Text = "Eliminar Consola";
            this.LblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.DeleteButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DeleteButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.DeleteButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteButton.IconSize = 50;
            this.DeleteButton.Location = new System.Drawing.Point(225, 69);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.Black;
            this.StatusLbl.Location = new System.Drawing.Point(9, 319);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(53, 19);
            this.StatusLbl.TabIndex = 27;
            this.StatusLbl.Text = "Status:";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = global::MainView.Properties.Settings.Default.SettingBackColor;
            this.EditButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::MainView.Properties.Settings.Default, "SettingBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EditButton.DataBindings.Add(new System.Windows.Forms.Binding("IconColor", global::MainView.Properties.Settings.Default, "SettingTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditButton.IconColor = global::MainView.Properties.Settings.Default.SettingTextColor;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 50;
            this.EditButton.Location = new System.Drawing.Point(225, 171);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 50);
            this.EditButton.TabIndex = 12;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ConsoleInfoLbl
            // 
            this.ConsoleInfoLbl.AutoSize = true;
            this.ConsoleInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleInfoLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleInfoLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ConsoleInfoLbl.ForeColor = System.Drawing.Color.Black;
            this.ConsoleInfoLbl.Location = new System.Drawing.Point(9, 338);
            this.ConsoleInfoLbl.Name = "ConsoleInfoLbl";
            this.ConsoleInfoLbl.Size = new System.Drawing.Size(186, 19);
            this.ConsoleInfoLbl.TabIndex = 25;
            this.ConsoleInfoLbl.Text = "Informacion de la consola:";
            // 
            // HorasTrabajolbl
            // 
            this.HorasTrabajolbl.AutoSize = true;
            this.HorasTrabajolbl.BackColor = System.Drawing.Color.Transparent;
            this.HorasTrabajolbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorasTrabajolbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HorasTrabajolbl.ForeColor = System.Drawing.Color.Black;
            this.HorasTrabajolbl.Location = new System.Drawing.Point(9, 300);
            this.HorasTrabajolbl.Name = "HorasTrabajolbl";
            this.HorasTrabajolbl.Size = new System.Drawing.Size(127, 19);
            this.HorasTrabajolbl.TabIndex = 24;
            this.HorasTrabajolbl.Text = "Horas de trabajo:";
            // 
            // IpLbl
            // 
            this.IpLbl.AutoSize = true;
            this.IpLbl.BackColor = System.Drawing.Color.Transparent;
            this.IpLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IpLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IpLbl.ForeColor = System.Drawing.Color.Black;
            this.IpLbl.Location = new System.Drawing.Point(9, 281);
            this.IpLbl.Name = "IpLbl";
            this.IpLbl.Size = new System.Drawing.Size(93, 19);
            this.IpLbl.TabIndex = 23;
            this.IpLbl.Text = "Direccion IP:";
            // 
            // SerialLbl
            // 
            this.SerialLbl.AutoSize = true;
            this.SerialLbl.BackColor = System.Drawing.Color.Transparent;
            this.SerialLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerialLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialLbl.ForeColor = System.Drawing.Color.Black;
            this.SerialLbl.Location = new System.Drawing.Point(9, 262);
            this.SerialLbl.Name = "SerialLbl";
            this.SerialLbl.Size = new System.Drawing.Size(51, 19);
            this.SerialLbl.TabIndex = 22;
            this.SerialLbl.Text = "Serial:";
            // 
            // Modelbl
            // 
            this.Modelbl.AutoSize = true;
            this.Modelbl.BackColor = System.Drawing.Color.Transparent;
            this.Modelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modelbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Modelbl.ForeColor = System.Drawing.Color.Black;
            this.Modelbl.Location = new System.Drawing.Point(9, 243);
            this.Modelbl.Name = "Modelbl";
            this.Modelbl.Size = new System.Drawing.Size(65, 19);
            this.Modelbl.TabIndex = 21;
            this.Modelbl.Text = "Modelo:";
            // 
            // FechaCompralbl
            // 
            this.FechaCompralbl.AutoSize = true;
            this.FechaCompralbl.BackColor = System.Drawing.Color.Transparent;
            this.FechaCompralbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaCompralbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FechaCompralbl.ForeColor = System.Drawing.Color.Black;
            this.FechaCompralbl.Location = new System.Drawing.Point(9, 224);
            this.FechaCompralbl.Name = "FechaCompralbl";
            this.FechaCompralbl.Size = new System.Drawing.Size(128, 19);
            this.FechaCompralbl.TabIndex = 20;
            this.FechaCompralbl.Text = "Fecha de compra:";
            // 
            // ConsoleInfoBox
            // 
            this.ConsoleInfoBox.Enabled = false;
            this.ConsoleInfoBox.Lines = new string[] {
        "Informacion de la consola"};
            this.ConsoleInfoBox.Location = new System.Drawing.Point(9, 360);
            this.ConsoleInfoBox.MaxLength = 2147483647;
            this.ConsoleInfoBox.Name = "ConsoleInfoBox";
            this.ConsoleInfoBox.PasswordChar = '\0';
            this.ConsoleInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsoleInfoBox.SelectedText = "";
            this.ConsoleInfoBox.Size = new System.Drawing.Size(273, 54);
            this.ConsoleInfoBox.TabIndex = 19;
            this.ConsoleInfoBox.Text = "Informacion de la consola";
            this.ConsoleInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ConsoleInfoBox.UseSelectable = true;
            this.ConsoleInfoBox.UseStyleColors = false;
            this.ConsoleInfoBox.UseSystemPasswordChar = false;
            this.ConsoleInfoBox.WordWrap = true;
            // 
            // RentTimer
            // 
            this.RentTimer.Interval = 1000;
            this.RentTimer.Tick += new System.EventHandler(this.RentTimer_Tick);
            // 
            // CheckConn
            // 
            this.CheckConn.Interval = 30000;
            this.CheckConn.Tick += new System.EventHandler(this.CheckConn_Tick);
            // 
            // ConsoleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsolePanel);
            this.DoubleBuffered = true;
            this.Name = "ConsoleListItem";
            this.Size = new System.Drawing.Size(300, 500);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevLib.ModernUI.Forms.ModernPanel ConsolePanel;
        private System.Windows.Forms.Label RentTimeBox;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton RentButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label HorasTBox;
        private System.Windows.Forms.Label IpBox;
        private System.Windows.Forms.Label SerialBox;
        private System.Windows.Forms.Label ModelBox;
        private System.Windows.Forms.Label FechaCompraBox;
        private System.Windows.Forms.Label ConsoleName;
        private System.Windows.Forms.Label LblDelete;
        private FontAwesome.Sharp.IconButton DeleteButton;
        private System.Windows.Forms.Label StatusLbl;
        private FontAwesome.Sharp.IconButton EditButton;
        private System.Windows.Forms.Label ConsoleInfoLbl;
        private System.Windows.Forms.Label HorasTrabajolbl;
        private System.Windows.Forms.Label IpLbl;
        private System.Windows.Forms.Label SerialLbl;
        private System.Windows.Forms.Label Modelbl;
        private System.Windows.Forms.Label FechaCompralbl;
        private DevLib.ModernUI.Forms.ModernTextBox ConsoleInfoBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Timer RentTimer;
        private System.Windows.Forms.Timer CheckConn;
    }
}

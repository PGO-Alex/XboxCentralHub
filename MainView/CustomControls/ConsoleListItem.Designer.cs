
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
            this.RentTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckConn = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsoleInfoBox = new System.Windows.Forms.TextBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.RentTimeBox = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.RentTimelabel = new System.Windows.Forms.Label();
            this.RentButton = new FontAwesome.Sharp.IconButton();
            this.EditConsoleLabel = new System.Windows.Forms.Label();
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
            this.RentTypeLabel = new System.Windows.Forms.Label();
            this.TimeToRentLabel = new System.Windows.Forms.Label();
            this.TimeToRentBox = new System.Windows.Forms.MaskedTextBox();
            this.RentTypeBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RentTypeBox);
            this.panel1.Controls.Add(this.TimeToRentBox);
            this.panel1.Controls.Add(this.TimeToRentLabel);
            this.panel1.Controls.Add(this.RentTypeLabel);
            this.panel1.Controls.Add(this.ConsoleInfoBox);
            this.panel1.Controls.Add(this.ImageBox);
            this.panel1.Controls.Add(this.RentTimeBox);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.RentTimelabel);
            this.panel1.Controls.Add(this.RentButton);
            this.panel1.Controls.Add(this.EditConsoleLabel);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.HorasTBox);
            this.panel1.Controls.Add(this.IpBox);
            this.panel1.Controls.Add(this.SerialBox);
            this.panel1.Controls.Add(this.ModelBox);
            this.panel1.Controls.Add(this.FechaCompraBox);
            this.panel1.Controls.Add(this.ConsoleName);
            this.panel1.Controls.Add(this.LblDelete);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.StatusLbl);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.ConsoleInfoLbl);
            this.panel1.Controls.Add(this.HorasTrabajolbl);
            this.panel1.Controls.Add(this.IpLbl);
            this.panel1.Controls.Add(this.SerialLbl);
            this.panel1.Controls.Add(this.Modelbl);
            this.panel1.Controls.Add(this.FechaCompralbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 500);
            this.panel1.TabIndex = 0;
            // 
            // ConsoleInfoBox
            // 
            this.ConsoleInfoBox.Location = new System.Drawing.Point(13, 365);
            this.ConsoleInfoBox.Multiline = true;
            this.ConsoleInfoBox.Name = "ConsoleInfoBox";
            this.ConsoleInfoBox.ReadOnly = true;
            this.ConsoleInfoBox.Size = new System.Drawing.Size(273, 41);
            this.ConsoleInfoBox.TabIndex = 69;
            // 
            // ImageBox
            // 
            this.ImageBox.InitialImage = null;
            this.ImageBox.Location = new System.Drawing.Point(17, 28);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(200, 200);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 68;
            this.ImageBox.TabStop = false;
            // 
            // RentTimeBox
            // 
            this.RentTimeBox.AutoSize = true;
            this.RentTimeBox.BackColor = System.Drawing.Color.Transparent;
            this.RentTimeBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RentTimeBox.Location = new System.Drawing.Point(193, 476);
            this.RentTimeBox.Name = "RentTimeBox";
            this.RentTimeBox.Size = new System.Drawing.Size(63, 19);
            this.RentTimeBox.TabIndex = 66;
            this.RentTimeBox.Text = "00:00:00";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(251, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(35, 13);
            this.IdLabel.TabIndex = 67;
            this.IdLabel.Text = "label1";
            // 
            // RentTimelabel
            // 
            this.RentTimelabel.AutoSize = true;
            this.RentTimelabel.BackColor = System.Drawing.Color.Transparent;
            this.RentTimelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentTimelabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RentTimelabel.ForeColor = System.Drawing.Color.Black;
            this.RentTimelabel.Location = new System.Drawing.Point(165, 458);
            this.RentTimelabel.Name = "RentTimelabel";
            this.RentTimelabel.Size = new System.Drawing.Size(121, 24);
            this.RentTimelabel.TabIndex = 65;
            this.RentTimelabel.Text = "Tiempo de renta:";
            this.RentTimelabel.UseCompatibleTextRendering = true;
            // 
            // RentButton
            // 
            this.RentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.RentButton.IconColor = System.Drawing.Color.Black;
            this.RentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RentButton.IconSize = 30;
            this.RentButton.Location = new System.Drawing.Point(13, 461);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(148, 30);
            this.RentButton.TabIndex = 64;
            this.RentButton.Text = "Rentar Consola";
            this.RentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // EditConsoleLabel
            // 
            this.EditConsoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditConsoleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.EditConsoleLabel.ForeColor = System.Drawing.Color.Black;
            this.EditConsoleLabel.Location = new System.Drawing.Point(223, 130);
            this.EditConsoleLabel.Name = "EditConsoleLabel";
            this.EditConsoleLabel.Size = new System.Drawing.Size(63, 42);
            this.EditConsoleLabel.TabIndex = 63;
            this.EditConsoleLabel.Text = "Editar Consola";
            this.EditConsoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StatusBox.Location = new System.Drawing.Point(146, 323);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(47, 19);
            this.StatusBox.TabIndex = 62;
            this.StatusBox.Text = "Status";
            // 
            // HorasTBox
            // 
            this.HorasTBox.AutoSize = true;
            this.HorasTBox.BackColor = System.Drawing.Color.Transparent;
            this.HorasTBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HorasTBox.Location = new System.Drawing.Point(146, 304);
            this.HorasTBox.Name = "HorasTBox";
            this.HorasTBox.Size = new System.Drawing.Size(113, 19);
            this.HorasTBox.TabIndex = 61;
            this.HorasTBox.Text = "Horas Trabajadas";
            // 
            // IpBox
            // 
            this.IpBox.AutoSize = true;
            this.IpBox.BackColor = System.Drawing.Color.Transparent;
            this.IpBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IpBox.Location = new System.Drawing.Point(146, 285);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(81, 19);
            this.IpBox.TabIndex = 60;
            this.IpBox.Text = "Direccion IP";
            // 
            // SerialBox
            // 
            this.SerialBox.AutoSize = true;
            this.SerialBox.BackColor = System.Drawing.Color.Transparent;
            this.SerialBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialBox.Location = new System.Drawing.Point(146, 266);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(41, 19);
            this.SerialBox.TabIndex = 59;
            this.SerialBox.Text = "Serial";
            // 
            // ModelBox
            // 
            this.ModelBox.AutoSize = true;
            this.ModelBox.BackColor = System.Drawing.Color.Transparent;
            this.ModelBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ModelBox.Location = new System.Drawing.Point(146, 247);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(56, 19);
            this.ModelBox.TabIndex = 58;
            this.ModelBox.Text = "Modelo";
            // 
            // FechaCompraBox
            // 
            this.FechaCompraBox.AutoSize = true;
            this.FechaCompraBox.BackColor = System.Drawing.Color.Transparent;
            this.FechaCompraBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FechaCompraBox.Location = new System.Drawing.Point(146, 228);
            this.FechaCompraBox.Name = "FechaCompraBox";
            this.FechaCompraBox.Size = new System.Drawing.Size(113, 19);
            this.FechaCompraBox.TabIndex = 57;
            this.FechaCompraBox.Text = "Fecha de compra";
            // 
            // ConsoleName
            // 
            this.ConsoleName.AutoSize = true;
            this.ConsoleName.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ConsoleName.ForeColor = System.Drawing.Color.Black;
            this.ConsoleName.Location = new System.Drawing.Point(123, 5);
            this.ConsoleName.Name = "ConsoleName";
            this.ConsoleName.Size = new System.Drawing.Size(62, 19);
            this.ConsoleName.TabIndex = 56;
            this.ConsoleName.Text = "Consola";
            // 
            // LblDelete
            // 
            this.LblDelete.BackColor = System.Drawing.Color.Transparent;
            this.LblDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblDelete.ForeColor = System.Drawing.Color.Black;
            this.LblDelete.Location = new System.Drawing.Point(225, 28);
            this.LblDelete.Name = "LblDelete";
            this.LblDelete.Size = new System.Drawing.Size(63, 42);
            this.LblDelete.TabIndex = 47;
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
            this.DeleteButton.Location = new System.Drawing.Point(229, 73);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 46;
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
            this.StatusLbl.Location = new System.Drawing.Point(13, 323);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(53, 19);
            this.StatusLbl.TabIndex = 55;
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
            this.EditButton.Location = new System.Drawing.Point(229, 175);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 50);
            this.EditButton.TabIndex = 45;
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
            this.ConsoleInfoLbl.Location = new System.Drawing.Point(13, 342);
            this.ConsoleInfoLbl.Name = "ConsoleInfoLbl";
            this.ConsoleInfoLbl.Size = new System.Drawing.Size(186, 19);
            this.ConsoleInfoLbl.TabIndex = 54;
            this.ConsoleInfoLbl.Text = "Informacion de la consola:";
            // 
            // HorasTrabajolbl
            // 
            this.HorasTrabajolbl.AutoSize = true;
            this.HorasTrabajolbl.BackColor = System.Drawing.Color.Transparent;
            this.HorasTrabajolbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HorasTrabajolbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HorasTrabajolbl.ForeColor = System.Drawing.Color.Black;
            this.HorasTrabajolbl.Location = new System.Drawing.Point(13, 304);
            this.HorasTrabajolbl.Name = "HorasTrabajolbl";
            this.HorasTrabajolbl.Size = new System.Drawing.Size(127, 19);
            this.HorasTrabajolbl.TabIndex = 53;
            this.HorasTrabajolbl.Text = "Horas de trabajo:";
            // 
            // IpLbl
            // 
            this.IpLbl.AutoSize = true;
            this.IpLbl.BackColor = System.Drawing.Color.Transparent;
            this.IpLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IpLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IpLbl.ForeColor = System.Drawing.Color.Black;
            this.IpLbl.Location = new System.Drawing.Point(13, 285);
            this.IpLbl.Name = "IpLbl";
            this.IpLbl.Size = new System.Drawing.Size(93, 19);
            this.IpLbl.TabIndex = 52;
            this.IpLbl.Text = "Direccion IP:";
            // 
            // SerialLbl
            // 
            this.SerialLbl.AutoSize = true;
            this.SerialLbl.BackColor = System.Drawing.Color.Transparent;
            this.SerialLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerialLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SerialLbl.ForeColor = System.Drawing.Color.Black;
            this.SerialLbl.Location = new System.Drawing.Point(13, 266);
            this.SerialLbl.Name = "SerialLbl";
            this.SerialLbl.Size = new System.Drawing.Size(51, 19);
            this.SerialLbl.TabIndex = 51;
            this.SerialLbl.Text = "Serial:";
            // 
            // Modelbl
            // 
            this.Modelbl.AutoSize = true;
            this.Modelbl.BackColor = System.Drawing.Color.Transparent;
            this.Modelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modelbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Modelbl.ForeColor = System.Drawing.Color.Black;
            this.Modelbl.Location = new System.Drawing.Point(13, 247);
            this.Modelbl.Name = "Modelbl";
            this.Modelbl.Size = new System.Drawing.Size(65, 19);
            this.Modelbl.TabIndex = 50;
            this.Modelbl.Text = "Modelo:";
            // 
            // FechaCompralbl
            // 
            this.FechaCompralbl.AutoSize = true;
            this.FechaCompralbl.BackColor = System.Drawing.Color.Transparent;
            this.FechaCompralbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaCompralbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FechaCompralbl.ForeColor = System.Drawing.Color.Black;
            this.FechaCompralbl.Location = new System.Drawing.Point(13, 228);
            this.FechaCompralbl.Name = "FechaCompralbl";
            this.FechaCompralbl.Size = new System.Drawing.Size(128, 19);
            this.FechaCompralbl.TabIndex = 49;
            this.FechaCompralbl.Text = "Fecha de compra:";
            // 
            // RentTypeLabel
            // 
            this.RentTypeLabel.AutoSize = true;
            this.RentTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RentTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RentTypeLabel.Location = new System.Drawing.Point(13, 409);
            this.RentTypeLabel.Name = "RentTypeLabel";
            this.RentTypeLabel.Size = new System.Drawing.Size(90, 19);
            this.RentTypeLabel.TabIndex = 70;
            this.RentTypeLabel.Text = "Tipo de renta";
            // 
            // TimeToRentLabel
            // 
            this.TimeToRentLabel.AutoSize = true;
            this.TimeToRentLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeToRentLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TimeToRentLabel.Location = new System.Drawing.Point(173, 409);
            this.TimeToRentLabel.Name = "TimeToRentLabel";
            this.TimeToRentLabel.Size = new System.Drawing.Size(106, 19);
            this.TimeToRentLabel.TabIndex = 71;
            this.TimeToRentLabel.Text = "Tiempo a rentar";
            // 
            // TimeToRentBox
            // 
            this.TimeToRentBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimeToRentBox.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.TimeToRentBox.Location = new System.Drawing.Point(197, 429);
            this.TimeToRentBox.Mask = "00:00";
            this.TimeToRentBox.Name = "TimeToRentBox";
            this.TimeToRentBox.Size = new System.Drawing.Size(40, 26);
            this.TimeToRentBox.TabIndex = 72;
            this.TimeToRentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeToRentBox.ValidatingType = typeof(System.DateTime);
            // 
            // RentTypeBox
            // 
            this.RentTypeBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::MainView.Properties.Settings.Default, "SettingFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RentTypeBox.Font = global::MainView.Properties.Settings.Default.SettingFont;
            this.RentTypeBox.FormattingEnabled = true;
            this.RentTypeBox.Items.AddRange(new object[] {
            "Renta Cliente",
            "Renta Interna"});
            this.RentTypeBox.Location = new System.Drawing.Point(13, 428);
            this.RentTypeBox.Name = "RentTypeBox";
            this.RentTypeBox.Size = new System.Drawing.Size(148, 27);
            this.RentTypeBox.TabIndex = 73;
            this.RentTypeBox.Text = "(Elija una opcion)";
            // 
            // ConsoleListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ConsoleListItem";
            this.Size = new System.Drawing.Size(300, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer RentTimer;
        private System.Windows.Forms.Timer CheckConn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label RentTimeBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label RentTimelabel;
        private FontAwesome.Sharp.IconButton RentButton;
        private System.Windows.Forms.Label EditConsoleLabel;
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
        private System.Windows.Forms.TextBox ConsoleInfoBox;
        private System.Windows.Forms.Label RentTypeLabel;
        private System.Windows.Forms.Label TimeToRentLabel;
        private System.Windows.Forms.ComboBox RentTypeBox;
        private System.Windows.Forms.MaskedTextBox TimeToRentBox;
    }
}

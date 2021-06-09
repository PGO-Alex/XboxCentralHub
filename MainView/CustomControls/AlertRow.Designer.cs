
namespace MainView.CustomControls
{
    partial class AlertRow
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.BotPanel = new System.Windows.Forms.Panel();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.MensajeBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CloseRow = new FontAwesome.Sharp.IconButton();
            this.StatusButton = new FontAwesome.Sharp.IconButton();
            this.MainPanel.SuspendLayout();
            this.MidPanel.SuspendLayout();
            this.BotPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MidPanel);
            this.MainPanel.Controls.Add(this.CloseRow);
            this.MainPanel.Controls.Add(this.StatusButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(250, 50);
            this.MainPanel.TabIndex = 0;
            // 
            // MidPanel
            // 
            this.MidPanel.Controls.Add(this.BotPanel);
            this.MidPanel.Controls.Add(this.TopPanel);
            this.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidPanel.Location = new System.Drawing.Point(40, 0);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(170, 50);
            this.MidPanel.TabIndex = 4;
            // 
            // BotPanel
            // 
            this.BotPanel.Controls.Add(this.TimeBox);
            this.BotPanel.Controls.Add(this.MensajeBox);
            this.BotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotPanel.Location = new System.Drawing.Point(0, 14);
            this.BotPanel.Name = "BotPanel";
            this.BotPanel.Size = new System.Drawing.Size(170, 36);
            this.BotPanel.TabIndex = 1;
            // 
            // TimeBox
            // 
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeBox.Location = new System.Drawing.Point(114, 0);
            this.TimeBox.Multiline = true;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(56, 36);
            this.TimeBox.TabIndex = 1;
            // 
            // MensajeBox
            // 
            this.MensajeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MensajeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MensajeBox.Location = new System.Drawing.Point(0, 0);
            this.MensajeBox.Multiline = true;
            this.MensajeBox.Name = "MensajeBox";
            this.MensajeBox.Size = new System.Drawing.Size(114, 36);
            this.MensajeBox.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.textBox3);
            this.TopPanel.Controls.Add(this.textBox4);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(170, 14);
            this.TopPanel.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(114, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 13);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Time";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(114, 13);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Mensaje";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseRow
            // 
            this.CloseRow.BackColor = System.Drawing.Color.Crimson;
            this.CloseRow.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseRow.FlatAppearance.BorderSize = 0;
            this.CloseRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRow.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseRow.IconColor = System.Drawing.Color.White;
            this.CloseRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseRow.IconSize = 35;
            this.CloseRow.Location = new System.Drawing.Point(210, 0);
            this.CloseRow.Margin = new System.Windows.Forms.Padding(0);
            this.CloseRow.Name = "CloseRow";
            this.CloseRow.Size = new System.Drawing.Size(40, 50);
            this.CloseRow.TabIndex = 3;
            this.CloseRow.Text = " ";
            this.CloseRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseRow.UseCompatibleTextRendering = true;
            this.CloseRow.UseVisualStyleBackColor = false;
            this.CloseRow.Click += new System.EventHandler(this.CloseRow_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.BackColor = System.Drawing.Color.Transparent;
            this.StatusButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusButton.FlatAppearance.BorderSize = 0;
            this.StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.StatusButton.IconColor = System.Drawing.Color.Black;
            this.StatusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatusButton.IconSize = 38;
            this.StatusButton.Location = new System.Drawing.Point(0, 0);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(40, 50);
            this.StatusButton.TabIndex = 0;
            this.StatusButton.UseCompatibleTextRendering = true;
            this.StatusButton.UseVisualStyleBackColor = false;
            // 
            // AlertRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AlertRow";
            this.Size = new System.Drawing.Size(250, 50);
            this.MainPanel.ResumeLayout(false);
            this.MidPanel.ResumeLayout(false);
            this.BotPanel.ResumeLayout(false);
            this.BotPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private FontAwesome.Sharp.IconButton StatusButton;
        private System.Windows.Forms.Panel MidPanel;
        private FontAwesome.Sharp.IconButton CloseRow;
        private System.Windows.Forms.Panel BotPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox MensajeBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}


namespace MainView.CustomControls
{
    partial class ColorOption
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
            this.ColorNameBox = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gray;
            this.MainPanel.Controls.Add(this.ColorNameBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 20);
            this.MainPanel.TabIndex = 0;
            // 
            // ColorNameBox
            // 
            this.ColorNameBox.AutoSize = true;
            this.ColorNameBox.BackColor = System.Drawing.Color.Transparent;
            this.ColorNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorNameBox.Location = new System.Drawing.Point(0, 0);
            this.ColorNameBox.Name = "ColorNameBox";
            this.ColorNameBox.Size = new System.Drawing.Size(89, 27);
            this.ColorNameBox.TabIndex = 1;
            this.ColorNameBox.Text = "ColorName";
            this.ColorNameBox.UseCompatibleTextRendering = true;
            // 
            // ColorOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Name = "ColorOption";
            this.Size = new System.Drawing.Size(200, 20);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ColorNameBox;
    }
}

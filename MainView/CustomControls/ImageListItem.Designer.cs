
namespace MainView.CustomControls
{
    partial class ImageListItem
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.SelectedOption = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SelectedOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(90, 90);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // SelectedOption
            // 
            this.SelectedOption.Controls.Add(this.checkBox1);
            this.SelectedOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOption.Location = new System.Drawing.Point(0, 90);
            this.SelectedOption.Name = "SelectedOption";
            this.SelectedOption.Size = new System.Drawing.Size(90, 30);
            this.SelectedOption.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ImageListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedOption);
            this.Controls.Add(this.ImageBox);
            this.Name = "ImageListItem";
            this.Size = new System.Drawing.Size(90, 120);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.SelectedOption.ResumeLayout(false);
            this.SelectedOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel SelectedOption;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

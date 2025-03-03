namespace _911
{
    partial class Form1
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
            this.picbxTorresGenelas = new System.Windows.Forms.PictureBox();
            this.bttAtentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTorresGenelas)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxTorresGenelas
            // 
            this.picbxTorresGenelas.Image = global::_911.Properties.Resources.Torres_Gemelas;
            this.picbxTorresGenelas.Location = new System.Drawing.Point(418, 12);
            this.picbxTorresGenelas.Name = "picbxTorresGenelas";
            this.picbxTorresGenelas.Size = new System.Drawing.Size(141, 197);
            this.picbxTorresGenelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxTorresGenelas.TabIndex = 0;
            this.picbxTorresGenelas.TabStop = false;
            // 
            // bttAtentar
            // 
            this.bttAtentar.Location = new System.Drawing.Point(432, 401);
            this.bttAtentar.Name = "bttAtentar";
            this.bttAtentar.Size = new System.Drawing.Size(127, 35);
            this.bttAtentar.TabIndex = 1;
            this.bttAtentar.Text = "ATENTAR";
            this.bttAtentar.UseVisualStyleBackColor = true;
            this.bttAtentar.Click += new System.EventHandler(this.bttAtentar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 583);
            this.Controls.Add(this.bttAtentar);
            this.Controls.Add(this.picbxTorresGenelas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbxTorresGenelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxTorresGenelas;
        private System.Windows.Forms.Button bttAtentar;
    }
}


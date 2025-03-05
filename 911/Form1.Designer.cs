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
            this.lblNumTorres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTorresGenelas)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxTorresGenelas
            // 
            this.picbxTorresGenelas.BackColor = System.Drawing.Color.Transparent;
            this.picbxTorresGenelas.Image = global::_911.Properties.Resources.Torres_Gemelas;
            this.picbxTorresGenelas.Location = new System.Drawing.Point(418, 39);
            this.picbxTorresGenelas.Name = "picbxTorresGenelas";
            this.picbxTorresGenelas.Size = new System.Drawing.Size(141, 197);
            this.picbxTorresGenelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxTorresGenelas.TabIndex = 0;
            this.picbxTorresGenelas.TabStop = false;
            // 
            // bttAtentar
            // 
            this.bttAtentar.BackColor = System.Drawing.Color.Red;
            this.bttAtentar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAtentar.ForeColor = System.Drawing.Color.Yellow;
            this.bttAtentar.Location = new System.Drawing.Point(432, 415);
            this.bttAtentar.Name = "bttAtentar";
            this.bttAtentar.Size = new System.Drawing.Size(127, 35);
            this.bttAtentar.TabIndex = 1;
            this.bttAtentar.Text = "ATENTAR";
            this.bttAtentar.UseVisualStyleBackColor = false;
            this.bttAtentar.Click += new System.EventHandler(this.bttAtentar_Click);
            // 
            // lblNumTorres
            // 
            this.lblNumTorres.AutoSize = true;
            this.lblNumTorres.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTorres.Location = new System.Drawing.Point(817, 9);
            this.lblNumTorres.Name = "lblNumTorres";
            this.lblNumTorres.Size = new System.Drawing.Size(158, 16);
            this.lblNumTorres.TabIndex = 2;
            this.lblNumTorres.Text = "TORRES IMPACTADAS";
            this.lblNumTorres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_911.Properties.Resources.Afganistas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 583);
            this.Controls.Add(this.lblNumTorres);
            this.Controls.Add(this.bttAtentar);
            this.Controls.Add(this.picbxTorresGenelas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picbxTorresGenelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxTorresGenelas;
        private System.Windows.Forms.Button bttAtentar;
        private System.Windows.Forms.Label lblNumTorres;
    }
}


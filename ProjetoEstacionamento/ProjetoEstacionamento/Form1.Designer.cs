
namespace ProjetoEstacionamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pBImageLogo = new System.Windows.Forms.PictureBox();
            this.lblTextLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.Location = new System.Drawing.Point(3, 37);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1013, 494);
            this.panelContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(974, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblTextLogo);
            this.panelLogo.Controls.Add(this.pBImageLogo);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Location = new System.Drawing.Point(3, -2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(315, 39);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // pBImageLogo
            // 
            this.pBImageLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBImageLogo.Image")));
            this.pBImageLogo.Location = new System.Drawing.Point(3, 3);
            this.pBImageLogo.Name = "pBImageLogo";
            this.pBImageLogo.Size = new System.Drawing.Size(31, 37);
            this.pBImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImageLogo.TabIndex = 0;
            this.pBImageLogo.TabStop = false;
            this.pBImageLogo.Click += new System.EventHandler(this.pBImageLogo_Click);
            // 
            // lblTextLogo
            // 
            this.lblTextLogo.AutoSize = true;
            this.lblTextLogo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTextLogo.Location = new System.Drawing.Point(34, 8);
            this.lblTextLogo.Name = "lblTextLogo";
            this.lblTextLogo.Size = new System.Drawing.Size(222, 25);
            this.lblTextLogo.TabIndex = 1;
            this.lblTextLogo.Text = "CFB ESTACIONAMENTO";
            this.lblTextLogo.Click += new System.EventHandler(this.lblTextLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1018, 533);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTextLogo;
        private System.Windows.Forms.PictureBox pBImageLogo;
    }
}



namespace ProjetoEstacionamento.UserControls
{
    partial class UserControlMenu
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMenu));
            this.btnRegistroDeEntrada = new System.Windows.Forms.Button();
            this.btnRegistroDeSaida = new System.Windows.Forms.Button();
            this.btnListagemVeiculos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerenciarValores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistroDeEntrada
            // 
            this.btnRegistroDeEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnRegistroDeEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroDeEntrada.FlatAppearance.BorderSize = 0;
            this.btnRegistroDeEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroDeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeEntrada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistroDeEntrada.Location = new System.Drawing.Point(289, 375);
            this.btnRegistroDeEntrada.Name = "btnRegistroDeEntrada";
            this.btnRegistroDeEntrada.Size = new System.Drawing.Size(206, 61);
            this.btnRegistroDeEntrada.TabIndex = 1;
            this.btnRegistroDeEntrada.Text = "Registrar Entrada";
            this.btnRegistroDeEntrada.UseVisualStyleBackColor = false;
            this.btnRegistroDeEntrada.Click += new System.EventHandler(this.btnRegistroDeEntrada_Click);
            this.btnRegistroDeEntrada.MouseEnter += new System.EventHandler(this.btnRegistroDeEntrada_MouseEnter);
            this.btnRegistroDeEntrada.MouseLeave += new System.EventHandler(this.btnRegistroDeEntrada_MouseLeave);
            // 
            // btnRegistroDeSaida
            // 
            this.btnRegistroDeSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRegistroDeSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroDeSaida.FlatAppearance.BorderSize = 0;
            this.btnRegistroDeSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroDeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeSaida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistroDeSaida.Location = new System.Drawing.Point(515, 375);
            this.btnRegistroDeSaida.Name = "btnRegistroDeSaida";
            this.btnRegistroDeSaida.Size = new System.Drawing.Size(206, 61);
            this.btnRegistroDeSaida.TabIndex = 2;
            this.btnRegistroDeSaida.Text = "Remover Veículo";
            this.btnRegistroDeSaida.UseVisualStyleBackColor = false;
            this.btnRegistroDeSaida.Click += new System.EventHandler(this.btnRegistroDeSaida_Click);
            this.btnRegistroDeSaida.MouseEnter += new System.EventHandler(this.btnRegistroDeSaida_MouseEnter);
            this.btnRegistroDeSaida.MouseLeave += new System.EventHandler(this.btnRegistroDeSaida_MouseLeave);
            // 
            // btnListagemVeiculos
            // 
            this.btnListagemVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnListagemVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListagemVeiculos.FlatAppearance.BorderSize = 0;
            this.btnListagemVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListagemVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListagemVeiculos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListagemVeiculos.Location = new System.Drawing.Point(741, 375);
            this.btnListagemVeiculos.Name = "btnListagemVeiculos";
            this.btnListagemVeiculos.Size = new System.Drawing.Size(206, 61);
            this.btnListagemVeiculos.TabIndex = 3;
            this.btnListagemVeiculos.Text = "Listar Veículos";
            this.btnListagemVeiculos.UseVisualStyleBackColor = false;
            this.btnListagemVeiculos.Click += new System.EventHandler(this.btnListagemVeiculos_Click);
            this.btnListagemVeiculos.MouseEnter += new System.EventHandler(this.btnListagemVeiculos_MouseEnter);
            this.btnListagemVeiculos.MouseLeave += new System.EventHandler(this.btnListagemVeiculos_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciarValores
            // 
            this.btnGerenciarValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGerenciarValores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarValores.FlatAppearance.BorderSize = 0;
            this.btnGerenciarValores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGerenciarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarValores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGerenciarValores.Location = new System.Drawing.Point(63, 375);
            this.btnGerenciarValores.Name = "btnGerenciarValores";
            this.btnGerenciarValores.Size = new System.Drawing.Size(206, 61);
            this.btnGerenciarValores.TabIndex = 5;
            this.btnGerenciarValores.Text = "Gerenciar Valores";
            this.btnGerenciarValores.UseVisualStyleBackColor = false;
            this.btnGerenciarValores.Click += new System.EventHandler(this.btnGerenciarValores_Click);
            this.btnGerenciarValores.MouseEnter += new System.EventHandler(this.btnGerenciarValores_MouseEnter);
            this.btnGerenciarValores.MouseLeave += new System.EventHandler(this.btnGerenciarValores_MouseLeave);
            // 
            // UserControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.btnGerenciarValores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListagemVeiculos);
            this.Controls.Add(this.btnRegistroDeSaida);
            this.Controls.Add(this.btnRegistroDeEntrada);
            this.Name = "UserControlMenu";
            this.Size = new System.Drawing.Size(1013, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistroDeEntrada;
        private System.Windows.Forms.Button btnRegistroDeSaida;
        private System.Windows.Forms.Button btnListagemVeiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerenciarValores;
    }
}

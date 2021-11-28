
namespace AplicacaoDesktop
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.txtTextoDigitado = new System.Windows.Forms.TextBox();
            this.txtTamanhoTexto = new System.Windows.Forms.TextBox();
            this.txtTotalPalavras = new System.Windows.Forms.TextBox();
            this.txtTotalBuracos = new System.Windows.Forms.TextBox();
            this.lblTextoDigitado = new System.Windows.Forms.Label();
            this.lblTamanhoTexto = new System.Windows.Forms.Label();
            this.lblTotalPalavras = new System.Windows.Forms.Label();
            this.lblTotalBuracos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextoDigitado
            // 
            this.txtTextoDigitado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoDigitado.Location = new System.Drawing.Point(186, 12);
            this.txtTextoDigitado.Name = "txtTextoDigitado";
            this.txtTextoDigitado.Size = new System.Drawing.Size(470, 30);
            this.txtTextoDigitado.TabIndex = 0;
            this.txtTextoDigitado.TextChanged += new System.EventHandler(this.txtTextoDigitado_TextChanged);
            // 
            // txtTamanhoTexto
            // 
            this.txtTamanhoTexto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanhoTexto.Location = new System.Drawing.Point(186, 58);
            this.txtTamanhoTexto.Name = "txtTamanhoTexto";
            this.txtTamanhoTexto.ReadOnly = true;
            this.txtTamanhoTexto.Size = new System.Drawing.Size(470, 30);
            this.txtTamanhoTexto.TabIndex = 0;
            // 
            // txtTotalPalavras
            // 
            this.txtTotalPalavras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPalavras.Location = new System.Drawing.Point(186, 104);
            this.txtTotalPalavras.Name = "txtTotalPalavras";
            this.txtTotalPalavras.ReadOnly = true;
            this.txtTotalPalavras.Size = new System.Drawing.Size(470, 30);
            this.txtTotalPalavras.TabIndex = 0;
            // 
            // txtTotalBuracos
            // 
            this.txtTotalBuracos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBuracos.Location = new System.Drawing.Point(186, 150);
            this.txtTotalBuracos.Name = "txtTotalBuracos";
            this.txtTotalBuracos.ReadOnly = true;
            this.txtTotalBuracos.Size = new System.Drawing.Size(470, 30);
            this.txtTotalBuracos.TabIndex = 0;
            // 
            // lblTextoDigitado
            // 
            this.lblTextoDigitado.AutoSize = true;
            this.lblTextoDigitado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDigitado.Location = new System.Drawing.Point(12, 15);
            this.lblTextoDigitado.Name = "lblTextoDigitado";
            this.lblTextoDigitado.Size = new System.Drawing.Size(54, 23);
            this.lblTextoDigitado.TabIndex = 1;
            this.lblTextoDigitado.Text = "Texto:";
            // 
            // lblTamanhoTexto
            // 
            this.lblTamanhoTexto.AutoSize = true;
            this.lblTamanhoTexto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoTexto.Location = new System.Drawing.Point(12, 61);
            this.lblTamanhoTexto.Name = "lblTamanhoTexto";
            this.lblTamanhoTexto.Size = new System.Drawing.Size(154, 23);
            this.lblTamanhoTexto.TabIndex = 1;
            this.lblTamanhoTexto.Text = "Tamanho do Texto:";
            // 
            // lblTotalPalavras
            // 
            this.lblTotalPalavras.AutoSize = true;
            this.lblTotalPalavras.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPalavras.Location = new System.Drawing.Point(12, 107);
            this.lblTotalPalavras.Name = "lblTotalPalavras";
            this.lblTotalPalavras.Size = new System.Drawing.Size(140, 23);
            this.lblTotalPalavras.TabIndex = 1;
            this.lblTotalPalavras.Text = "Total de Palavras:";
            // 
            // lblTotalBuracos
            // 
            this.lblTotalBuracos.AutoSize = true;
            this.lblTotalBuracos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBuracos.Location = new System.Drawing.Point(12, 153);
            this.lblTotalBuracos.Name = "lblTotalBuracos";
            this.lblTotalBuracos.Size = new System.Drawing.Size(139, 23);
            this.lblTotalBuracos.TabIndex = 1;
            this.lblTotalBuracos.Text = "Total de Buracos:";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 199);
            this.Controls.Add(this.lblTotalBuracos);
            this.Controls.Add(this.lblTotalPalavras);
            this.Controls.Add(this.lblTamanhoTexto);
            this.Controls.Add(this.lblTextoDigitado);
            this.Controls.Add(this.txtTotalBuracos);
            this.Controls.Add(this.txtTotalPalavras);
            this.Controls.Add(this.txtTamanhoTexto);
            this.Controls.Add(this.txtTextoDigitado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buraco Nas Letras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoDigitado;
        private System.Windows.Forms.TextBox txtTamanhoTexto;
        private System.Windows.Forms.TextBox txtTotalPalavras;
        private System.Windows.Forms.TextBox txtTotalBuracos;
        private System.Windows.Forms.Label lblTextoDigitado;
        private System.Windows.Forms.Label lblTamanhoTexto;
        private System.Windows.Forms.Label lblTotalPalavras;
        private System.Windows.Forms.Label lblTotalBuracos;
    }
}


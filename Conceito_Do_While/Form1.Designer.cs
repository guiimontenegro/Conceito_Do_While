﻿namespace Conceito_Do_While
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(107, 84);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(35, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "label1";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(88, 158);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(109, 50);
            this.btnTeste.TabIndex = 1;
            this.btnTeste.Text = "Teste DO/WHILE";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 311);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnTeste;
    }
}


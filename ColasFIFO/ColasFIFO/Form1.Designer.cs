﻿namespace ColasFIFO
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
            this.txtProcesos = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcesos
            // 
            this.txtProcesos.Location = new System.Drawing.Point(62, 65);
            this.txtProcesos.Multiline = true;
            this.txtProcesos.Name = "txtProcesos";
            this.txtProcesos.ReadOnly = true;
            this.txtProcesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcesos.Size = new System.Drawing.Size(316, 401);
            this.txtProcesos.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(167, 12);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(98, 37);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 478);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtProcesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcesos;
        private System.Windows.Forms.Button btnProcesar;
    }
}


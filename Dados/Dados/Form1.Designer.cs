namespace Dados
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
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.btnLanzarSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(94, 131);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDados.Size = new System.Drawing.Size(171, 224);
            this.txtDados.TabIndex = 0;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(94, 102);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar dado";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // btnLanzarSuma
            // 
            this.btnLanzarSuma.Location = new System.Drawing.Point(190, 102);
            this.btnLanzarSuma.Name = "btnLanzarSuma";
            this.btnLanzarSuma.Size = new System.Drawing.Size(75, 23);
            this.btnLanzarSuma.TabIndex = 2;
            this.btnLanzarSuma.Text = "Lanzar suma";
            this.btnLanzarSuma.UseVisualStyleBackColor = true;
            this.btnLanzarSuma.Click += new System.EventHandler(this.btnLanzarSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 415);
            this.Controls.Add(this.btnLanzarSuma);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.txtDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnLanzarSuma;
    }
}


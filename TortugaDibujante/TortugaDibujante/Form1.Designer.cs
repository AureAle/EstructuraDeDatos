namespace TortugaDibujante
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
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.btnEstado1 = new System.Windows.Forms.Button();
            this.btnEstado2 = new System.Windows.Forms.Button();
            this.btnGirarDer = new System.Windows.Forms.Button();
            this.btnGirarIzq = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComandos = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.lblSentido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPiso
            // 
            this.txtPiso.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.Location = new System.Drawing.Point(27, 63);
            this.txtPiso.Multiline = true;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(290, 482);
            this.txtPiso.TabIndex = 0;
            // 
            // btnEstado1
            // 
            this.btnEstado1.Location = new System.Drawing.Point(323, 208);
            this.btnEstado1.Name = "btnEstado1";
            this.btnEstado1.Size = new System.Drawing.Size(88, 23);
            this.btnEstado1.TabIndex = 1;
            this.btnEstado1.Text = "Pluma Arriba";
            this.btnEstado1.UseVisualStyleBackColor = true;
            this.btnEstado1.Click += new System.EventHandler(this.btnEstado1_Click);
            // 
            // btnEstado2
            // 
            this.btnEstado2.Location = new System.Drawing.Point(417, 208);
            this.btnEstado2.Name = "btnEstado2";
            this.btnEstado2.Size = new System.Drawing.Size(88, 23);
            this.btnEstado2.TabIndex = 2;
            this.btnEstado2.Text = "Pluma Abajo";
            this.btnEstado2.UseVisualStyleBackColor = true;
            this.btnEstado2.Click += new System.EventHandler(this.btnEstado2_Click);
            // 
            // btnGirarDer
            // 
            this.btnGirarDer.Location = new System.Drawing.Point(417, 179);
            this.btnGirarDer.Name = "btnGirarDer";
            this.btnGirarDer.Size = new System.Drawing.Size(88, 23);
            this.btnGirarDer.TabIndex = 3;
            this.btnGirarDer.Text = "Girar Derecha";
            this.btnGirarDer.UseVisualStyleBackColor = true;
            this.btnGirarDer.Click += new System.EventHandler(this.btnGirarDer_Click);
            // 
            // btnGirarIzq
            // 
            this.btnGirarIzq.Location = new System.Drawing.Point(323, 179);
            this.btnGirarIzq.Name = "btnGirarIzq";
            this.btnGirarIzq.Size = new System.Drawing.Size(88, 23);
            this.btnGirarIzq.TabIndex = 4;
            this.btnGirarIzq.Text = "Girar Izquierda";
            this.btnGirarIzq.UseVisualStyleBackColor = true;
            this.btnGirarIzq.Click += new System.EventHandler(this.btnGirarIzq_Click);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(45, 34);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(100, 20);
            this.txtPasos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Pasos";
            // 
            // lblComandos
            // 
            this.lblComandos.AutoSize = true;
            this.lblComandos.Location = new System.Drawing.Point(355, 111);
            this.lblComandos.Name = "lblComandos";
            this.lblComandos.Size = new System.Drawing.Size(150, 65);
            this.lblComandos.TabIndex = 7;
            this.lblComandos.Text = "Presione las veces necesarias\r\n1: Arriba\r\n2: Derecha\r\n3: Abajo\r\n4: Izquierda\r\n";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(151, 34);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(88, 23);
            this.btnAvanzar.TabIndex = 8;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // lblSentido
            // 
            this.lblSentido.AutoSize = true;
            this.lblSentido.Location = new System.Drawing.Point(206, 9);
            this.lblSentido.Name = "lblSentido";
            this.lblSentido.Size = new System.Drawing.Size(49, 13);
            this.lblSentido.TabIndex = 9;
            this.lblSentido.Text = "Sentido: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 557);
            this.Controls.Add(this.lblSentido);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.lblComandos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.btnGirarIzq);
            this.Controls.Add(this.btnGirarDer);
            this.Controls.Add(this.btnEstado2);
            this.Controls.Add(this.btnEstado1);
            this.Controls.Add(this.txtPiso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Button btnEstado1;
        private System.Windows.Forms.Button btnEstado2;
        private System.Windows.Forms.Button btnGirarDer;
        private System.Windows.Forms.Button btnGirarIzq;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComandos;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label lblSentido;
    }
}


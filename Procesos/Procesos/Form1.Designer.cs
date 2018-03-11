namespace Procesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcesos = new System.Windows.Forms.TextBox();
            this.rbtnFCFS = new System.Windows.Forms.RadioButton();
            this.rbtnSJF = new System.Windows.Forms.RadioButton();
            this.rbtnLSF = new System.Windows.Forms.RadioButton();
            this.rbtnRRQ = new System.Windows.Forms.RadioButton();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuántos Procesos";
            // 
            // txtProcesos
            // 
            this.txtProcesos.Location = new System.Drawing.Point(133, 26);
            this.txtProcesos.Name = "txtProcesos";
            this.txtProcesos.Size = new System.Drawing.Size(100, 25);
            this.txtProcesos.TabIndex = 1;
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Location = new System.Drawing.Point(69, 234);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(60, 22);
            this.rbtnFCFS.TabIndex = 2;
            this.rbtnFCFS.TabStop = true;
            this.rbtnFCFS.Text = "FCFS";
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            this.rbtnFCFS.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // rbtnSJF
            // 
            this.rbtnSJF.AutoSize = true;
            this.rbtnSJF.Location = new System.Drawing.Point(160, 234);
            this.rbtnSJF.Name = "rbtnSJF";
            this.rbtnSJF.Size = new System.Drawing.Size(50, 22);
            this.rbtnSJF.TabIndex = 3;
            this.rbtnSJF.TabStop = true;
            this.rbtnSJF.Text = "SJF";
            this.rbtnSJF.UseVisualStyleBackColor = true;
            this.rbtnSJF.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // rbtnLSF
            // 
            this.rbtnLSF.AutoSize = true;
            this.rbtnLSF.Location = new System.Drawing.Point(263, 234);
            this.rbtnLSF.Name = "rbtnLSF";
            this.rbtnLSF.Size = new System.Drawing.Size(50, 22);
            this.rbtnLSF.TabIndex = 4;
            this.rbtnLSF.TabStop = true;
            this.rbtnLSF.Text = "LSF";
            this.rbtnLSF.UseVisualStyleBackColor = true;
            this.rbtnLSF.CheckedChanged += new System.EventHandler(this.Check);
            // 
            // rbtnRRQ
            // 
            this.rbtnRRQ.AutoSize = true;
            this.rbtnRRQ.Location = new System.Drawing.Point(353, 234);
            this.rbtnRRQ.Name = "rbtnRRQ";
            this.rbtnRRQ.Size = new System.Drawing.Size(54, 22);
            this.rbtnRRQ.TabIndex = 5;
            this.rbtnRRQ.TabStop = true;
            this.rbtnRRQ.Text = "RRQ";
            this.rbtnRRQ.UseVisualStyleBackColor = true;
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(69, 71);
            this.txtValores.Multiline = true;
            this.txtValores.Name = "txtValores";
            this.txtValores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValores.Size = new System.Drawing.Size(338, 118);
            this.txtValores.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantum";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(377, 279);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(41, 25);
            this.txtQuantum.TabIndex = 8;
            // 
            // btnLlenar
            // 
            this.btnLlenar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLlenar.Location = new System.Drawing.Point(329, 26);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(75, 25);
            this.btnLlenar.TabIndex = 11;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = false;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCrear.Location = new System.Drawing.Point(248, 26);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 25);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMostrar.Location = new System.Drawing.Point(187, 195);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(114, 25);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tiempos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.rbtnRRQ);
            this.Controls.Add(this.rbtnLSF);
            this.Controls.Add(this.rbtnSJF);
            this.Controls.Add(this.rbtnFCFS);
            this.Controls.Add(this.txtProcesos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Procesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcesos;
        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.RadioButton rbtnSJF;
        private System.Windows.Forms.RadioButton rbtnLSF;
        private System.Windows.Forms.RadioButton rbtnRRQ;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label4;
    }
}


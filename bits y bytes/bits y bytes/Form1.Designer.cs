namespace bits_y_bytes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtNewFecha = new System.Windows.Forms.TextBox();
            this.btnAjustarFecha = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picDirecc = new System.Windows.Forms.PictureBox();
            this.imgListDirecc = new System.Windows.Forms.ImageList(this.components);
            this.picState1 = new System.Windows.Forms.PictureBox();
            this.picState2 = new System.Windows.Forms.PictureBox();
            this.imgListState = new System.Windows.Forms.ImageList(this.components);
            this.imgListNivel = new System.Windows.Forms.ImageList(this.components);
            this.picNivel = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFechaLectura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDirecc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picState1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picState2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.AccessibleDescription = "";
            this.txtEntrada.Location = new System.Drawing.Point(99, 55);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(141, 29);
            this.txtEntrada.TabIndex = 0;
            // 
            // txtNewFecha
            // 
            this.txtNewFecha.Location = new System.Drawing.Point(194, 472);
            this.txtNewFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNewFecha.Name = "txtNewFecha";
            this.txtNewFecha.Size = new System.Drawing.Size(128, 29);
            this.txtNewFecha.TabIndex = 1;
            // 
            // btnAjustarFecha
            // 
            this.btnAjustarFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjustarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustarFecha.Location = new System.Drawing.Point(195, 424);
            this.btnAjustarFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAjustarFecha.Name = "btnAjustarFecha";
            this.btnAjustarFecha.Size = new System.Drawing.Size(127, 30);
            this.btnAjustarFecha.TabIndex = 2;
            this.btnAjustarFecha.Text = "Ajustar Fecha";
            this.btnAjustarFecha.UseVisualStyleBackColor = false;
            this.btnAjustarFecha.Click += new System.EventHandler(this.btnAjustarFecha_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Location = new System.Drawing.Point(244, 55);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(93, 29);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.AccessibleDescription = "";
            this.txtFecha.Location = new System.Drawing.Point(195, 371);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(127, 29);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sensores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "FechaLectura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha:";
            // 
            // picDirecc
            // 
            this.picDirecc.Location = new System.Drawing.Point(336, 173);
            this.picDirecc.Name = "picDirecc";
            this.picDirecc.Size = new System.Drawing.Size(150, 150);
            this.picDirecc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDirecc.TabIndex = 11;
            this.picDirecc.TabStop = false;
            // 
            // imgListDirecc
            // 
            this.imgListDirecc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDirecc.ImageStream")));
            this.imgListDirecc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDirecc.Images.SetKeyName(0, "norte.png");
            this.imgListDirecc.Images.SetKeyName(1, "noreste.png");
            this.imgListDirecc.Images.SetKeyName(2, "este.png");
            this.imgListDirecc.Images.SetKeyName(3, "sureste.png");
            this.imgListDirecc.Images.SetKeyName(4, "sur.png");
            this.imgListDirecc.Images.SetKeyName(5, "suroeste.png");
            this.imgListDirecc.Images.SetKeyName(6, "oeste.png");
            this.imgListDirecc.Images.SetKeyName(7, "noroeste.png");
            // 
            // picState1
            // 
            this.picState1.Location = new System.Drawing.Point(3, 196);
            this.picState1.Name = "picState1";
            this.picState1.Size = new System.Drawing.Size(74, 69);
            this.picState1.TabIndex = 12;
            this.picState1.TabStop = false;
            // 
            // picState2
            // 
            this.picState2.Location = new System.Drawing.Point(83, 196);
            this.picState2.Name = "picState2";
            this.picState2.Size = new System.Drawing.Size(74, 69);
            this.picState2.TabIndex = 13;
            this.picState2.TabStop = false;
            // 
            // imgListState
            // 
            this.imgListState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListState.ImageStream")));
            this.imgListState.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListState.Images.SetKeyName(0, "off.png");
            this.imgListState.Images.SetKeyName(1, "on.png");
            // 
            // imgListNivel
            // 
            this.imgListNivel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListNivel.ImageStream")));
            this.imgListNivel.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListNivel.Images.SetKeyName(0, "vacío.png");
            this.imgListNivel.Images.SetKeyName(1, "medio.png");
            this.imgListNivel.Images.SetKeyName(2, "lleno.png");
            this.imgListNivel.Images.SetKeyName(3, "llenándose.png");
            // 
            // picNivel
            // 
            this.picNivel.Location = new System.Drawing.Point(214, 173);
            this.picNivel.Name = "picNivel";
            this.picNivel.Size = new System.Drawing.Size(62, 81);
            this.picNivel.TabIndex = 14;
            this.picNivel.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(413, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 29);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFechaLectura
            // 
            this.lblFechaLectura.AutoSize = true;
            this.lblFechaLectura.Location = new System.Drawing.Point(196, 326);
            this.lblFechaLectura.Name = "lblFechaLectura";
            this.lblFechaLectura.Size = new System.Drawing.Size(0, 21);
            this.lblFechaLectura.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 520);
            this.Controls.Add(this.lblFechaLectura);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picNivel);
            this.Controls.Add(this.picState2);
            this.Controls.Add(this.picState1);
            this.Controls.Add(this.picDirecc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnAjustarFecha);
            this.Controls.Add(this.txtNewFecha);
            this.Controls.Add(this.txtEntrada);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica 1";
            ((System.ComponentModel.ISupportInitialize)(this.picDirecc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picState1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picState2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtNewFecha;
        private System.Windows.Forms.Button btnAjustarFecha;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picDirecc;
        private System.Windows.Forms.ImageList imgListDirecc;
        private System.Windows.Forms.PictureBox picState1;
        private System.Windows.Forms.PictureBox picState2;
        private System.Windows.Forms.ImageList imgListState;
        private System.Windows.Forms.ImageList imgListNivel;
        private System.Windows.Forms.PictureBox picNivel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFechaLectura;
    }
}


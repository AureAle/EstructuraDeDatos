namespace ListasCirculares
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.btnAgregarFin = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarFin = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutas = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtBaseInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutos:";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(136, 101);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 3;
            // 
            // btnAgregarFin
            // 
            this.btnAgregarFin.Location = new System.Drawing.Point(360, 105);
            this.btnAgregarFin.Name = "btnAgregarFin";
            this.btnAgregarFin.Size = new System.Drawing.Size(83, 23);
            this.btnAgregarFin.TabIndex = 4;
            this.btnAgregarFin.Text = "AgregarFin";
            this.btnAgregarFin.UseVisualStyleBackColor = true;
            this.btnAgregarFin.Click += new System.EventHandler(this.btnAgregarFin_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarFin
            // 
            this.btnEliminarFin.Location = new System.Drawing.Point(360, 190);
            this.btnEliminarFin.Name = "btnEliminarFin";
            this.btnEliminarFin.Size = new System.Drawing.Size(83, 23);
            this.btnEliminarFin.TabIndex = 7;
            this.btnEliminarFin.Text = "EliminarFin";
            this.btnEliminarFin.UseVisualStyleBackColor = true;
            this.btnEliminarFin.Click += new System.EventHandler(this.btnEliminarFin_Click);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(360, 219);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(83, 23);
            this.btnEliminarInicio.TabIndex = 8;
            this.btnEliminarInicio.Text = "EliminarInicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(360, 255);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(83, 23);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(360, 286);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(145, 23);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(458, 255);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(47, 20);
            this.txtPos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Posición";
            // 
            // txtRutas
            // 
            this.txtRutas.Location = new System.Drawing.Point(18, 131);
            this.txtRutas.Multiline = true;
            this.txtRutas.Name = "txtRutas";
            this.txtRutas.ReadOnly = true;
            this.txtRutas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRutas.Size = new System.Drawing.Size(299, 285);
            this.txtRutas.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(360, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(333, 393);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(83, 23);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtBaseInicial
            // 
            this.txtBaseInicial.Location = new System.Drawing.Point(333, 362);
            this.txtBaseInicial.Name = "txtBaseInicial";
            this.txtBaseInicial.Size = new System.Drawing.Size(83, 20);
            this.txtBaseInicial.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Base Inicial:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(431, 362);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(113, 20);
            this.dtpHoraInicio.TabIndex = 20;
            this.dtpHoraInicio.Value = new System.DateTime(2018, 5, 20, 18, 1, 56, 0);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Checked = false;
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(431, 396);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(113, 20);
            this.dtpHoraFin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "HoraIncio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "HoraFin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseInicial);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtRutas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.btnEliminarFin);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarFin);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rutas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button btnAgregarFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarFin;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtBaseInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


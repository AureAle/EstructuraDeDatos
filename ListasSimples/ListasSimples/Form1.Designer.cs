namespace ListasSimples
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnBorarInicio = new System.Windows.Forms.Button();
            this.btnBorrarUltimo = new System.Windows.Forms.Button();
            this.btnListarInverso = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(480, 86);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(164, 88);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(277, 351);
            this.txtLista.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(480, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(255, 59);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(480, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(480, 173);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(84, 23);
            this.btnAgregarInicio.TabIndex = 5;
            this.btnAgregarInicio.Text = "AgregarInicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // btnBorarInicio
            // 
            this.btnBorarInicio.Location = new System.Drawing.Point(480, 202);
            this.btnBorarInicio.Name = "btnBorarInicio";
            this.btnBorarInicio.Size = new System.Drawing.Size(84, 23);
            this.btnBorarInicio.TabIndex = 6;
            this.btnBorarInicio.Text = "BorrarInicio";
            this.btnBorarInicio.UseVisualStyleBackColor = true;
            this.btnBorarInicio.Click += new System.EventHandler(this.btnBorarInicio_Click);
            // 
            // btnBorrarUltimo
            // 
            this.btnBorrarUltimo.Location = new System.Drawing.Point(480, 231);
            this.btnBorrarUltimo.Name = "btnBorrarUltimo";
            this.btnBorrarUltimo.Size = new System.Drawing.Size(84, 23);
            this.btnBorrarUltimo.TabIndex = 7;
            this.btnBorrarUltimo.Text = "BorrarÚltimo";
            this.btnBorrarUltimo.UseVisualStyleBackColor = true;
            this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
            // 
            // btnListarInverso
            // 
            this.btnListarInverso.Location = new System.Drawing.Point(480, 260);
            this.btnListarInverso.Name = "btnListarInverso";
            this.btnListarInverso.Size = new System.Drawing.Size(84, 23);
            this.btnListarInverso.TabIndex = 8;
            this.btnListarInverso.Text = "ListarInverso";
            this.btnListarInverso.UseVisualStyleBackColor = true;
            this.btnListarInverso.Click += new System.EventHandler(this.btnListarInverso_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 98);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(84, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(62, 197);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(84, 20);
            this.txtCosto.TabIndex = 15;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(62, 245);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(84, 20);
            this.txtCant.TabIndex = 16;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(480, 289);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(84, 20);
            this.txtPos.TabIndex = 17;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(480, 315);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(84, 23);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pos:";
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(480, 344);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(84, 23);
            this.btnInvertir.TabIndex = 20;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(447, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 478);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnListarInverso);
            this.Controls.Add(this.btnBorrarUltimo);
            this.Controls.Add(this.btnBorarInicio);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnBorarInicio;
        private System.Windows.Forms.Button btnBorrarUltimo;
        private System.Windows.Forms.Button btnListarInverso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace Examen_Pacial_1
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
            this.txtingresesunombre = new System.Windows.Forms.Label();
            this.txtingresesushorastrabajadas = new System.Windows.Forms.Label();
            this.txtpagodehoras = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtingresesunombre
            // 
            this.txtingresesunombre.AutoSize = true;
            this.txtingresesunombre.Location = new System.Drawing.Point(29, 52);
            this.txtingresesunombre.Name = "txtingresesunombre";
            this.txtingresesunombre.Size = new System.Drawing.Size(99, 13);
            this.txtingresesunombre.TabIndex = 0;
            this.txtingresesunombre.Text = "Ingrese su Nombre:";
            // 
            // txtingresesushorastrabajadas
            // 
            this.txtingresesushorastrabajadas.AutoSize = true;
            this.txtingresesushorastrabajadas.Location = new System.Drawing.Point(34, 104);
            this.txtingresesushorastrabajadas.Name = "txtingresesushorastrabajadas";
            this.txtingresesushorastrabajadas.Size = new System.Drawing.Size(94, 13);
            this.txtingresesushorastrabajadas.TabIndex = 1;
            this.txtingresesushorastrabajadas.Text = "Horas Trabajadas:";
            // 
            // txtpagodehoras
            // 
            this.txtpagodehoras.AutoSize = true;
            this.txtpagodehoras.Location = new System.Drawing.Point(34, 154);
            this.txtpagodehoras.Name = "txtpagodehoras";
            this.txtpagodehoras.Size = new System.Drawing.Size(79, 13);
            this.txtpagodehoras.TabIndex = 2;
            this.txtpagodehoras.Text = "Pago de horas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(134, 101);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 4;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(134, 154);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(109, 207);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(228, 207);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.AutoSize = true;
            this.txtresultado.Location = new System.Drawing.Point(380, 52);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(58, 13);
            this.txtresultado.TabIndex = 8;
            this.txtresultado.Text = "Resultado:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(348, 207);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 303);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtpagodehoras);
            this.Controls.Add(this.txtingresesushorastrabajadas);
            this.Controls.Add(this.txtingresesunombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtingresesunombre;
        private System.Windows.Forms.Label txtingresesushorastrabajadas;
        private System.Windows.Forms.Label txtpagodehoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label txtresultado;
        private System.Windows.Forms.Button btnlimpiar;
    }
}


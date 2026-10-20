namespace Unidad_4
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtaltocarmostrarsemostraralainformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(144, 88);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 0;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtaltocarmostrarsemostraralainformacion
            // 
            this.txtaltocarmostrarsemostraralainformacion.AutoSize = true;
            this.txtaltocarmostrarsemostraralainformacion.Location = new System.Drawing.Point(129, 37);
            this.txtaltocarmostrarsemostraralainformacion.Name = "txtaltocarmostrarsemostraralainformacion";
            this.txtaltocarmostrarsemostraralainformacion.Size = new System.Drawing.Size(100, 13);
            this.txtaltocarmostrarsemostraralainformacion.TabIndex = 1;
            this.txtaltocarmostrarsemostraralainformacion.Text = "Mostrar Informacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 172);
            this.Controls.Add(this.txtaltocarmostrarsemostraralainformacion);
            this.Controls.Add(this.btnmostrar);
            this.Name = "Form1";
            this.Text = "Aqui sera Mostrara la Informacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label txtaltocarmostrarsemostraralainformacion;
    }
}


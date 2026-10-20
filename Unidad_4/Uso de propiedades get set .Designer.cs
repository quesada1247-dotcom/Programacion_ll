namespace Unidad_4
{
    partial class Uso_de_propiedades_get_set
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtregistrodeproductos = new System.Windows.Forms.Label();
            this.txtingreseelnombredelproducto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtingreseelpreciodelproducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtregistrodeproductos
            // 
            this.txtregistrodeproductos.AutoSize = true;
            this.txtregistrodeproductos.Location = new System.Drawing.Point(227, 37);
            this.txtregistrodeproductos.Name = "txtregistrodeproductos";
            this.txtregistrodeproductos.Size = new System.Drawing.Size(112, 13);
            this.txtregistrodeproductos.TabIndex = 0;
            this.txtregistrodeproductos.Text = "Registro de Productos";
            // 
            // txtingreseelnombredelproducto
            // 
            this.txtingreseelnombredelproducto.AutoSize = true;
            this.txtingreseelnombredelproducto.Location = new System.Drawing.Point(58, 128);
            this.txtingreseelnombredelproducto.Name = "txtingreseelnombredelproducto";
            this.txtingreseelnombredelproducto.Size = new System.Drawing.Size(110, 13);
            this.txtingreseelnombredelproducto.TabIndex = 1;
            this.txtingreseelnombredelproducto.Text = "Nombre del Producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtingreseelpreciodelproducto
            // 
            this.txtingreseelpreciodelproducto.AutoSize = true;
            this.txtingreseelpreciodelproducto.Location = new System.Drawing.Point(58, 181);
            this.txtingreseelpreciodelproducto.Name = "txtingreseelpreciodelproducto";
            this.txtingreseelpreciodelproducto.Size = new System.Drawing.Size(152, 13);
            this.txtingreseelpreciodelproducto.TabIndex = 3;
            this.txtingreseelpreciodelproducto.Text = "Ingrese el Precio del Producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(216, 178);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(246, 233);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Uso_de_propiedades_get_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 351);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtingreseelpreciodelproducto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtingreseelnombredelproducto);
            this.Controls.Add(this.txtregistrodeproductos);
            this.Name = "Uso_de_propiedades_get_set";
            this.Text = "Uso_de_propiedades_get_set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtregistrodeproductos;
        private System.Windows.Forms.Label txtingreseelnombredelproducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label txtingreseelpreciodelproducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnguardar;
    }
}
namespace Unidad_1
{
    partial class Registro
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
            this.txtnombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(31, 76);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(47, 13);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.AutoSize = true;
            this.txtapellido.Location = new System.Drawing.Point(31, 127);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(47, 13);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.Text = "Apellido:";
            this.txtapellido.Click += new System.EventHandler(this.txtapellido_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtusuario
            // 
            this.txtusuario.AutoSize = true;
            this.txtusuario.Location = new System.Drawing.Point(32, 176);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(46, 13);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.Text = "Usuario:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.AutoSize = true;
            this.txtcontraseña.Location = new System.Drawing.Point(14, 228);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(64, 13);
            this.txtcontraseña.TabIndex = 6;
            this.txtcontraseña.Text = "Contraseña:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // txtcorreo
            // 
            this.txtcorreo.AutoSize = true;
            this.txtcorreo.Location = new System.Drawing.Point(31, 276);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(41, 13);
            this.txtcorreo.TabIndex = 8;
            this.txtcorreo.Text = "Correo:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 269);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(237, 322);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 10;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(344, 322);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(460, 322);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtnombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtapellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtcontraseña;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtcorreo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}
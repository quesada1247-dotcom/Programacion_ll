namespace Unidad_7
{
    partial class PracticaMySQL
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
            this.txtConexionMySQL = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoModificar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConexionMySQL
            // 
            this.txtConexionMySQL.AutoSize = true;
            this.txtConexionMySQL.Location = new System.Drawing.Point(12, 9);
            this.txtConexionMySQL.Name = "txtConexionMySQL";
            this.txtConexionMySQL.Size = new System.Drawing.Size(89, 13);
            this.txtConexionMySQL.TabIndex = 0;
            this.txtConexionMySQL.Text = "Conexion MySQL";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(12, 25);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(129, 23);
            this.btnProbarConexion.TabIndex = 1;
            this.btnProbarConexion.Text = "Probar conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(12, 177);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(15, 214);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar y modificar clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Buscar cliente por nombre:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(196, 126);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(141, 20);
            this.txtBuscarNombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo del cliente:";
            // 
            // txtCorreoModificar
            // 
            this.txtCorreoModificar.Location = new System.Drawing.Point(196, 177);
            this.txtCorreoModificar.Name = "txtCorreoModificar";
            this.txtCorreoModificar.Size = new System.Drawing.Size(141, 20);
            this.txtCorreoModificar.TabIndex = 12;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(275, 214);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar correo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(183, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Eliminar clientes:";
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(12, 282);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(111, 20);
            this.txtNombreEliminar.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PracticaMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 394);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCorreoModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.txtConexionMySQL);
            this.Name = "PracticaMySQL";
            this.Text = "PracticaMySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConexionMySQL;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
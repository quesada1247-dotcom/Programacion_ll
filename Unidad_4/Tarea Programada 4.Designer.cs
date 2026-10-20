namespace Unidad_4
{
    partial class Tarea_Programada_4
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtnombre = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(45, 79);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(47, 13);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "Nombre:";
            // 
            // txtedad
            // 
            this.txtedad.AutoSize = true;
            this.txtedad.Location = new System.Drawing.Point(45, 125);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(35, 13);
            this.txtedad.TabIndex = 1;
            this.txtedad.Text = "Edad:";
            // 
            // txtcurso
            // 
            this.txtcurso.AutoSize = true;
            this.txtcurso.Location = new System.Drawing.Point(45, 176);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(37, 13);
            this.txtcurso.TabIndex = 2;
            this.txtcurso.Text = "Curso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(201, 218);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Tarea_Programada_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 309);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Name = "Tarea_Programada_4";
            this.Text = "Tarea_Programada_4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label txtcurso;
        private System.Windows.Forms.Label txtedad;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
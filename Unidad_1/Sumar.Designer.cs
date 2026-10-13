namespace Unidad_1
{
    partial class Sumar
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
            this.txtingreseelprimernumeri = new System.Windows.Forms.Label();
            this.txtingreseelsegundonumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtingreseelprimernumeri
            // 
            this.txtingreseelprimernumeri.AutoSize = true;
            this.txtingreseelprimernumeri.Location = new System.Drawing.Point(94, 102);
            this.txtingreseelprimernumeri.Name = "txtingreseelprimernumeri";
            this.txtingreseelprimernumeri.Size = new System.Drawing.Size(127, 13);
            this.txtingreseelprimernumeri.TabIndex = 0;
            this.txtingreseelprimernumeri.Text = "Ingrese el primer Numero:";
            // 
            // txtingreseelsegundonumero
            // 
            this.txtingreseelsegundonumero.AutoSize = true;
            this.txtingreseelsegundonumero.Location = new System.Drawing.Point(94, 179);
            this.txtingreseelsegundonumero.Name = "txtingreseelsegundonumero";
            this.txtingreseelsegundonumero.Size = new System.Drawing.Size(140, 13);
            this.txtingreseelsegundonumero.TabIndex = 1;
            this.txtingreseelsegundonumero.Text = "Ingrese el segundo Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(390, 136);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 4;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtingreseelsegundonumero);
            this.Controls.Add(this.txtingreseelprimernumeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtingreseelprimernumeri;
        private System.Windows.Forms.Label txtingreseelsegundonumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsumar;
    }
}


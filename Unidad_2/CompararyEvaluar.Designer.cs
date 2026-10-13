namespace Unidad_2
{
    partial class CompararyEvaluar
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
            this.txtingreseelprimernumero = new System.Windows.Forms.Label();
            this.txtingreseelsegundonumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncompararyevaluar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btncolordeformulario = new System.Windows.Forms.Button();
            this.btncolortextbox = new System.Windows.Forms.Button();
            this.btncolorlabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtingreseelprimernumero
            // 
            this.txtingreseelprimernumero.AutoSize = true;
            this.txtingreseelprimernumero.Location = new System.Drawing.Point(136, 125);
            this.txtingreseelprimernumero.Name = "txtingreseelprimernumero";
            this.txtingreseelprimernumero.Size = new System.Drawing.Size(127, 13);
            this.txtingreseelprimernumero.TabIndex = 0;
            this.txtingreseelprimernumero.Text = "Ingrese el primer Numero:";
            // 
            // txtingreseelsegundonumero
            // 
            this.txtingreseelsegundonumero.AutoSize = true;
            this.txtingreseelsegundonumero.Location = new System.Drawing.Point(136, 207);
            this.txtingreseelsegundonumero.Name = "txtingreseelsegundonumero";
            this.txtingreseelsegundonumero.Size = new System.Drawing.Size(140, 13);
            this.txtingreseelsegundonumero.TabIndex = 1;
            this.txtingreseelsegundonumero.Text = "Ingrese el segundo Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btncompararyevaluar
            // 
            this.btncompararyevaluar.Location = new System.Drawing.Point(469, 155);
            this.btncompararyevaluar.Name = "btncompararyevaluar";
            this.btncompararyevaluar.Size = new System.Drawing.Size(126, 23);
            this.btncompararyevaluar.TabIndex = 4;
            this.btncompararyevaluar.Text = "Comparar y Evaluar";
            this.btncompararyevaluar.UseVisualStyleBackColor = true;
            this.btncompararyevaluar.Click += new System.EventHandler(this.btncompararyevaluar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(498, 184);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncolordeformulario
            // 
            this.btncolordeformulario.Location = new System.Drawing.Point(76, 313);
            this.btncolordeformulario.Name = "btncolordeformulario";
            this.btncolordeformulario.Size = new System.Drawing.Size(93, 37);
            this.btncolordeformulario.TabIndex = 6;
            this.btncolordeformulario.Text = "Color de Formulario";
            this.btncolordeformulario.UseVisualStyleBackColor = true;
            this.btncolordeformulario.Click += new System.EventHandler(this.btncolordeformulario_Click);
            // 
            // btncolortextbox
            // 
            this.btncolortextbox.Location = new System.Drawing.Point(202, 313);
            this.btncolortextbox.Name = "btncolortextbox";
            this.btncolortextbox.Size = new System.Drawing.Size(91, 37);
            this.btncolortextbox.TabIndex = 7;
            this.btncolortextbox.Text = "Color TEXTBOX";
            this.btncolortextbox.UseVisualStyleBackColor = true;
            this.btncolortextbox.Click += new System.EventHandler(this.btncolortextbox_Click);
            // 
            // btncolorlabel
            // 
            this.btncolorlabel.Location = new System.Drawing.Point(327, 316);
            this.btncolorlabel.Name = "btncolorlabel";
            this.btncolorlabel.Size = new System.Drawing.Size(82, 30);
            this.btncolorlabel.TabIndex = 8;
            this.btncolorlabel.Text = "Color LABEL";
            this.btncolorlabel.UseVisualStyleBackColor = true;
            this.btncolorlabel.Click += new System.EventHandler(this.btncolorlabel_Click);
            // 
            // CompararyEvaluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncolorlabel);
            this.Controls.Add(this.btncolortextbox);
            this.Controls.Add(this.btncolordeformulario);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncompararyevaluar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtingreseelsegundonumero);
            this.Controls.Add(this.txtingreseelprimernumero);
            this.Name = "CompararyEvaluar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtingreseelprimernumero;
        private System.Windows.Forms.Label txtingreseelsegundonumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btncompararyevaluar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btncolordeformulario;
        private System.Windows.Forms.Button btncolortextbox;
        private System.Windows.Forms.Button btncolorlabel;
    }
}


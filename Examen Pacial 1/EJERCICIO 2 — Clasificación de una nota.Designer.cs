namespace Examen_Pacial_1
{
    partial class EJERCICIO_2___Clasificación_de_una_nota
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtingreselanota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.Label();
            this.btnevaluar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clasificación de una nota";
            // 
            // txtingreselanota
            // 
            this.txtingreselanota.AutoSize = true;
            this.txtingreselanota.Location = new System.Drawing.Point(210, 63);
            this.txtingreselanota.Name = "txtingreselanota";
            this.txtingreselanota.Size = new System.Drawing.Size(82, 13);
            this.txtingreselanota.TabIndex = 1;
            this.txtingreselanota.Text = "Ingrese la Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(202, 89);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 2;
            // 
            // txtresultado
            // 
            this.txtresultado.AutoSize = true;
            this.txtresultado.Location = new System.Drawing.Point(185, 122);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(58, 13);
            this.txtresultado.TabIndex = 3;
            this.txtresultado.Text = "Resultado:";
            // 
            // btnevaluar
            // 
            this.btnevaluar.Location = new System.Drawing.Point(129, 160);
            this.btnevaluar.Name = "btnevaluar";
            this.btnevaluar.Size = new System.Drawing.Size(75, 23);
            this.btnevaluar.TabIndex = 4;
            this.btnevaluar.Text = "Evaluar";
            this.btnevaluar.UseVisualStyleBackColor = true;
            this.btnevaluar.Click += new System.EventHandler(this.btnevaluar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(283, 160);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.Location = new System.Drawing.Point(41, 199);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(120, 95);
            this.lstCategorias.TabIndex = 6;
            this.lstCategorias.SelectedIndexChanged += new System.EventHandler(this.lstCategorias_SelectedIndexChanged);
            // 
            // EJERCICIO_2___Clasificación_de_una_nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 313);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnevaluar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtingreselanota);
            this.Controls.Add(this.label1);
            this.Name = "EJERCICIO_2___Clasificación_de_una_nota";
            this.Text = "EJERCICIO_2___Clasificación_de_una_nota";
            this.Load += new System.EventHandler(this.EJERCICIO_2___Clasificación_de_una_nota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtingreselanota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label txtresultado;
        private System.Windows.Forms.Button btnevaluar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ListBox lstCategorias;
    }
}
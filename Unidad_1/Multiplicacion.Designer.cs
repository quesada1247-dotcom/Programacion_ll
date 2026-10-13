namespace Unidad_1
{
    partial class Multiplicacion
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
            this.txtingreseelprimernumero = new System.Windows.Forms.Label();
            this.txtingreseelsegundonumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtingreseelprimernumero
            // 
            this.txtingreseelprimernumero.AutoSize = true;
            this.txtingreseelprimernumero.Location = new System.Drawing.Point(102, 89);
            this.txtingreseelprimernumero.Name = "txtingreseelprimernumero";
            this.txtingreseelprimernumero.Size = new System.Drawing.Size(127, 13);
            this.txtingreseelprimernumero.TabIndex = 0;
            this.txtingreseelprimernumero.Text = "Ingrese el primer Numero:";
            // 
            // txtingreseelsegundonumero
            // 
            this.txtingreseelsegundonumero.AutoSize = true;
            this.txtingreseelsegundonumero.Location = new System.Drawing.Point(102, 149);
            this.txtingreseelsegundonumero.Name = "txtingreseelsegundonumero";
            this.txtingreseelsegundonumero.Size = new System.Drawing.Size(140, 13);
            this.txtingreseelsegundonumero.TabIndex = 1;
            this.txtingreseelsegundonumero.Text = "Ingrese el segundo Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(404, 120);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplicar.TabIndex = 4;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // Multiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtingreseelsegundonumero);
            this.Controls.Add(this.txtingreseelprimernumero);
            this.Name = "Multiplicacion";
            this.Text = "Multiplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtingreseelprimernumero;
        private System.Windows.Forms.Label txtingreseelsegundonumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnmultiplicar;
    }
}
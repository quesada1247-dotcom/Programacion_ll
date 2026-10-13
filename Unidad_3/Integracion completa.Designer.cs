namespace Unidad_3
{
    partial class Integracion_completa
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
            this.txtselectordenumeros = new System.Windows.Forms.Label();
            this.txtingreseunnumerodel1al4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtselectordenumeros
            // 
            this.txtselectordenumeros.AutoSize = true;
            this.txtselectordenumeros.Location = new System.Drawing.Point(287, 84);
            this.txtselectordenumeros.Name = "txtselectordenumeros";
            this.txtselectordenumeros.Size = new System.Drawing.Size(106, 13);
            this.txtselectordenumeros.TabIndex = 0;
            this.txtselectordenumeros.Text = "Selector de Numeros";
            // 
            // txtingreseunnumerodel1al4
            // 
            this.txtingreseunnumerodel1al4.AutoSize = true;
            this.txtingreseunnumerodel1al4.Location = new System.Drawing.Point(276, 111);
            this.txtingreseunnumerodel1al4.Name = "txtingreseunnumerodel1al4";
            this.txtingreseunnumerodel1al4.Size = new System.Drawing.Size(141, 13);
            this.txtingreseunnumerodel1al4.TabIndex = 1;
            this.txtingreseunnumerodel1al4.Text = "Ingrese un numero del 1 al 4";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(293, 143);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(304, 190);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Integracion_completa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtingreseunnumerodel1al4);
            this.Controls.Add(this.txtselectordenumeros);
            this.Name = "Integracion_completa";
            this.Text = "Integracion_completa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtselectordenumeros;
        private System.Windows.Forms.Label txtingreseunnumerodel1al4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnmostrar;
    }
}
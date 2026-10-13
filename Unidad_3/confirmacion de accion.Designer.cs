namespace Unidad_3
{
    partial class txtconfirmaciondeunaaccion
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
            this.txtconfirmaciondeaccion = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtconfirmaciondeaccion
            // 
            this.txtconfirmaciondeaccion.AutoSize = true;
            this.txtconfirmaciondeaccion.Location = new System.Drawing.Point(318, 119);
            this.txtconfirmaciondeaccion.Name = "txtconfirmaciondeaccion";
            this.txtconfirmaciondeaccion.Size = new System.Drawing.Size(119, 13);
            this.txtconfirmaciondeaccion.TabIndex = 0;
            this.txtconfirmaciondeaccion.Text = "Confirmacion de Accion";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(339, 168);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtconfirmaciondeunaaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtconfirmaciondeaccion);
            this.Name = "txtconfirmaciondeunaaccion";
            this.Text = "Confirmacion de accion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtconfirmaciondeaccion;
        private System.Windows.Forms.Button btnsalir;
    }
}
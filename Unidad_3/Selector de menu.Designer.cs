namespace Unidad_3
{
    partial class Selector_de_menu
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
            this.txtselectordemenu = new System.Windows.Forms.Label();
            this.txtingreseunaopcion = new System.Windows.Forms.Label();
            this.txtopcion = new System.Windows.Forms.TextBox();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtselectordemenu
            // 
            this.txtselectordemenu.AutoSize = true;
            this.txtselectordemenu.Location = new System.Drawing.Point(289, 68);
            this.txtselectordemenu.Name = "txtselectordemenu";
            this.txtselectordemenu.Size = new System.Drawing.Size(91, 13);
            this.txtselectordemenu.TabIndex = 0;
            this.txtselectordemenu.Text = "Selector de Menu";
            // 
            // txtingreseunaopcion
            // 
            this.txtingreseunaopcion.AutoSize = true;
            this.txtingreseunaopcion.Location = new System.Drawing.Point(263, 94);
            this.txtingreseunaopcion.Name = "txtingreseunaopcion";
            this.txtingreseunaopcion.Size = new System.Drawing.Size(159, 13);
            this.txtingreseunaopcion.TabIndex = 1;
            this.txtingreseunaopcion.Text = "Ingrese una opcion del (1 ,2 y 3)";
            // 
            // txtopcion
            // 
            this.txtopcion.Location = new System.Drawing.Point(256, 123);
            this.txtopcion.Name = "txtopcion";
            this.txtopcion.Size = new System.Drawing.Size(166, 20);
            this.txtopcion.TabIndex = 2;
            this.txtopcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(305, 163);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(75, 23);
            this.btnselecionar.TabIndex = 3;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = true;
            this.btnselecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Selector_de_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.txtopcion);
            this.Controls.Add(this.txtingreseunaopcion);
            this.Controls.Add(this.txtselectordemenu);
            this.Name = "Selector_de_menu";
            this.Text = "Selector_de_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtselectordemenu;
        private System.Windows.Forms.Label txtingreseunaopcion;
        private System.Windows.Forms.TextBox txtopcion;
        private System.Windows.Forms.Button btnselecionar;
    }
}
namespace WindowsFormsApp3
{
    partial class MostrarRecibos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Muestra = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el numero de factura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Muestra
            // 
            this.Muestra.Location = new System.Drawing.Point(235, 141);
            this.Muestra.Name = "Muestra";
            this.Muestra.Size = new System.Drawing.Size(233, 40);
            this.Muestra.TabIndex = 2;
            this.Muestra.Text = "Mostrar Factura";
            this.Muestra.UseVisualStyleBackColor = true;
            this.Muestra.Click += new System.EventHandler(this.Muestra_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(1, 217);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(166, 49);
            this.Salir.TabIndex = 46;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(1, 57);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(166, 49);
            this.Volver.TabIndex = 47;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // MostrarRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 377);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Muestra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MostrarRecibos";
            this.Text = "MostrarRecibos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Muestra;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Volver;
    }
}
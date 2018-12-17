namespace WindowsFormsApp3
{
    partial class Recibo
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
            this.Fecha = new System.Windows.Forms.Label();
            this.fecha1 = new System.Windows.Forms.Label();
            this.IdFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(38, 34);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(51, 17);
            this.Fecha.TabIndex = 0;
            this.Fecha.Text = "Fecha:";
            this.Fecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Location = new System.Drawing.Point(95, 34);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(46, 17);
            this.fecha1.TabIndex = 1;
            this.fecha1.Text = "label1";
            // 
            // IdFactura
            // 
            this.IdFactura.AutoSize = true;
            this.IdFactura.ForeColor = System.Drawing.Color.Red;
            this.IdFactura.Location = new System.Drawing.Point(407, 40);
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Size = new System.Drawing.Size(46, 17);
            this.IdFactura.TabIndex = 2;
            this.IdFactura.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa:";
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(160, 115);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(122, 44);
            this.placa.TabIndex = 4;
            this.placa.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Salida:";
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Location = new System.Drawing.Point(208, 189);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(46, 17);
            this.entrada.TabIndex = 8;
            this.entrada.Text = "label5";
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(211, 224);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(46, 17);
            this.salida.TabIndex = 9;
            this.salida.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total  a Pagar:  ¢";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(211, 270);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(79, 29);
            this.monto.TabIndex = 11;
            this.monto.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gracias por su Visita!";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdFactura);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.Fecha);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.Label IdFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label entrada;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label label6;
    }
}
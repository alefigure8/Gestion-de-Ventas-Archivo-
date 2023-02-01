namespace presentación
{
    partial class frmCantidadVentas
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
            this.lbTituloCantidadVentas = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloCantidadVentas
            // 
            this.lbTituloCantidadVentas.AutoSize = true;
            this.lbTituloCantidadVentas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCantidadVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloCantidadVentas.Location = new System.Drawing.Point(37, 23);
            this.lbTituloCantidadVentas.Name = "lbTituloCantidadVentas";
            this.lbTituloCantidadVentas.Size = new System.Drawing.Size(126, 16);
            this.lbTituloCantidadVentas.TabIndex = 0;
            this.lbTituloCantidadVentas.Text = "Cantidad a vender";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(40, 51);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericCantidad.TabIndex = 1;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericCantidad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presione \"Enter\" para salir.";
            // 
            // frmCantidadVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(199, 110);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTituloCantidadVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCantidadVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloCantidadVentas;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label1;
    }
}
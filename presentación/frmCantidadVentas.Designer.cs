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
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloCantidadVentas
            // 
            this.lbTituloCantidadVentas.AutoSize = true;
            this.lbTituloCantidadVentas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCantidadVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloCantidadVentas.Location = new System.Drawing.Point(33, 32);
            this.lbTituloCantidadVentas.Name = "lbTituloCantidadVentas";
            this.lbTituloCantidadVentas.Size = new System.Drawing.Size(126, 16);
            this.lbTituloCantidadVentas.TabIndex = 0;
            this.lbTituloCantidadVentas.Text = "Cantidad a vender";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(36, 60);
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
            // frmCantidadVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(199, 110);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.lbTituloCantidadVentas);
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
    }
}
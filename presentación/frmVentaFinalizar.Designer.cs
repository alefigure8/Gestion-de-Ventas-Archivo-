namespace presentación
{
    partial class frmVentaFinalizar
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
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalAPagar = new System.Windows.Forms.Label();
            this.lbSubTotalTitulo = new System.Windows.Forms.Label();
            this.lbDescuentoTitulo = new System.Windows.Forms.Label();
            this.lbImpuestoTitulo = new System.Windows.Forms.Label();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.checkTarjeta = new System.Windows.Forms.CheckBox();
            this.checkEfectivo = new System.Windows.Forms.CheckBox();
            this.lbSubTotalPrecio = new System.Windows.Forms.Label();
            this.lbDescuentoPrecio = new System.Windows.Forms.Label();
            this.lbImpuestoPrecio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacturar.Location = new System.Drawing.Point(247, 281);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(129, 51);
            this.btnFacturar.TabIndex = 9;
            this.btnFacturar.Text = "Finalizar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(92, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 51);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.lbTotalAPagar);
            this.panel1.Location = new System.Drawing.Point(92, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 54);
            this.panel1.TabIndex = 11;
            // 
            // lbTotalAPagar
            // 
            this.lbTotalAPagar.AutoSize = true;
            this.lbTotalAPagar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAPagar.ForeColor = System.Drawing.Color.LightGreen;
            this.lbTotalAPagar.Location = new System.Drawing.Point(13, 16);
            this.lbTotalAPagar.Name = "lbTotalAPagar";
            this.lbTotalAPagar.Size = new System.Drawing.Size(77, 25);
            this.lbTotalAPagar.TabIndex = 12;
            this.lbTotalAPagar.Text = "$ 0.00";
            // 
            // lbSubTotalTitulo
            // 
            this.lbSubTotalTitulo.AutoSize = true;
            this.lbSubTotalTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubTotalTitulo.Location = new System.Drawing.Point(89, 114);
            this.lbSubTotalTitulo.Name = "lbSubTotalTitulo";
            this.lbSubTotalTitulo.Size = new System.Drawing.Size(66, 16);
            this.lbSubTotalTitulo.TabIndex = 12;
            this.lbSubTotalTitulo.Text = "Sub total";
            // 
            // lbDescuentoTitulo
            // 
            this.lbDescuentoTitulo.AutoSize = true;
            this.lbDescuentoTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescuentoTitulo.Location = new System.Drawing.Point(89, 141);
            this.lbDescuentoTitulo.Name = "lbDescuentoTitulo";
            this.lbDescuentoTitulo.Size = new System.Drawing.Size(76, 16);
            this.lbDescuentoTitulo.TabIndex = 12;
            this.lbDescuentoTitulo.Text = "Descuento";
            // 
            // lbImpuestoTitulo
            // 
            this.lbImpuestoTitulo.AutoSize = true;
            this.lbImpuestoTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpuestoTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbImpuestoTitulo.Location = new System.Drawing.Point(89, 172);
            this.lbImpuestoTitulo.Name = "lbImpuestoTitulo";
            this.lbImpuestoTitulo.Size = new System.Drawing.Size(68, 16);
            this.lbImpuestoTitulo.TabIndex = 12;
            this.lbImpuestoTitulo.Text = "Impuesto";
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.checkTarjeta);
            this.gbPago.Controls.Add(this.checkEfectivo);
            this.gbPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbPago.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbPago.Location = new System.Drawing.Point(92, 205);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(284, 58);
            this.gbPago.TabIndex = 13;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pago";
            // 
            // checkTarjeta
            // 
            this.checkTarjeta.AutoSize = true;
            this.checkTarjeta.Location = new System.Drawing.Point(169, 22);
            this.checkTarjeta.Name = "checkTarjeta";
            this.checkTarjeta.Size = new System.Drawing.Size(73, 20);
            this.checkTarjeta.TabIndex = 0;
            this.checkTarjeta.Text = "Crédito";
            this.checkTarjeta.UseVisualStyleBackColor = true;
            this.checkTarjeta.CheckedChanged += new System.EventHandler(this.checkTarjeta_CheckedChanged);
            // 
            // checkEfectivo
            // 
            this.checkEfectivo.AutoSize = true;
            this.checkEfectivo.Checked = true;
            this.checkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEfectivo.Location = new System.Drawing.Point(33, 22);
            this.checkEfectivo.Name = "checkEfectivo";
            this.checkEfectivo.Size = new System.Drawing.Size(78, 20);
            this.checkEfectivo.TabIndex = 0;
            this.checkEfectivo.Text = "Efectivo";
            this.checkEfectivo.UseVisualStyleBackColor = true;
            this.checkEfectivo.CheckedChanged += new System.EventHandler(this.checkEfectivo_CheckedChanged);
            // 
            // lbSubTotalPrecio
            // 
            this.lbSubTotalPrecio.AutoSize = true;
            this.lbSubTotalPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubTotalPrecio.Location = new System.Drawing.Point(176, 114);
            this.lbSubTotalPrecio.Name = "lbSubTotalPrecio";
            this.lbSubTotalPrecio.Size = new System.Drawing.Size(43, 16);
            this.lbSubTotalPrecio.TabIndex = 12;
            this.lbSubTotalPrecio.Text = "$ 0.00";
            // 
            // lbDescuentoPrecio
            // 
            this.lbDescuentoPrecio.AutoSize = true;
            this.lbDescuentoPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescuentoPrecio.Location = new System.Drawing.Point(176, 141);
            this.lbDescuentoPrecio.Name = "lbDescuentoPrecio";
            this.lbDescuentoPrecio.Size = new System.Drawing.Size(43, 16);
            this.lbDescuentoPrecio.TabIndex = 14;
            this.lbDescuentoPrecio.Text = "$ 0.00";
            // 
            // lbImpuestoPrecio
            // 
            this.lbImpuestoPrecio.AutoSize = true;
            this.lbImpuestoPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpuestoPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbImpuestoPrecio.Location = new System.Drawing.Point(174, 172);
            this.lbImpuestoPrecio.Name = "lbImpuestoPrecio";
            this.lbImpuestoPrecio.Size = new System.Drawing.Size(43, 16);
            this.lbImpuestoPrecio.TabIndex = 15;
            this.lbImpuestoPrecio.Text = "$ 0.00";
            // 
            // frmVentaFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(452, 358);
            this.Controls.Add(this.lbImpuestoPrecio);
            this.Controls.Add(this.lbDescuentoPrecio);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.lbImpuestoTitulo);
            this.Controls.Add(this.lbDescuentoTitulo);
            this.Controls.Add(this.lbSubTotalPrecio);
            this.Controls.Add(this.lbSubTotalTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVentaFinalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venta";
            this.Load += new System.EventHandler(this.frmVentaFinalizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotalAPagar;
        private System.Windows.Forms.Label lbSubTotalTitulo;
        private System.Windows.Forms.Label lbDescuentoTitulo;
        private System.Windows.Forms.Label lbImpuestoTitulo;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.CheckBox checkTarjeta;
        private System.Windows.Forms.CheckBox checkEfectivo;
        private System.Windows.Forms.Label lbSubTotalPrecio;
        private System.Windows.Forms.Label lbDescuentoPrecio;
        private System.Windows.Forms.Label lbImpuestoPrecio;
    }
}
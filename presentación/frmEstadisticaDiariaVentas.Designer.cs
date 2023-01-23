namespace presentación
{
    partial class frmEstadisticaDiariaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbNumeroVentaTitulo = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTarjetaOEfectivo = new System.Windows.Forms.Label();
            this.lbClienteNombre = new System.Windows.Forms.Label();
            this.lbClienteTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalTitulo = new System.Windows.Forms.Label();
            this.lbTotalPrecio = new System.Windows.Forms.Label();
            this.lbDescuentoTitulo = new System.Windows.Forms.Label();
            this.lbDescuentoTotal = new System.Windows.Forms.Label();
            this.lbImpuestoTitulo = new System.Windows.Forms.Label();
            this.lbImpuestoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.Location = new System.Drawing.Point(52, 59);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 35;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(704, 241);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Location = new System.Drawing.Point(627, 387);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 51);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbNumeroVentaTitulo
            // 
            this.lbNumeroVentaTitulo.AutoSize = true;
            this.lbNumeroVentaTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroVentaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNumeroVentaTitulo.Location = new System.Drawing.Point(48, 27);
            this.lbNumeroVentaTitulo.Name = "lbNumeroVentaTitulo";
            this.lbNumeroVentaTitulo.Size = new System.Drawing.Size(151, 19);
            this.lbNumeroVentaTitulo.TabIndex = 15;
            this.lbNumeroVentaTitulo.Text = "Venta Número 00";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFecha.Location = new System.Drawing.Point(649, 27);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(107, 19);
            this.lbFecha.TabIndex = 15;
            this.lbFecha.Text = "00/00/0000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lbImpuestoTotal);
            this.panel1.Controls.Add(this.lbDescuentoTotal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbImpuestoTitulo);
            this.panel1.Controls.Add(this.lbDescuentoTitulo);
            this.panel1.Location = new System.Drawing.Point(52, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 54);
            this.panel1.TabIndex = 16;
            // 
            // lbTarjetaOEfectivo
            // 
            this.lbTarjetaOEfectivo.AutoSize = true;
            this.lbTarjetaOEfectivo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarjetaOEfectivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTarjetaOEfectivo.Location = new System.Drawing.Point(45, 36);
            this.lbTarjetaOEfectivo.Name = "lbTarjetaOEfectivo";
            this.lbTarjetaOEfectivo.Size = new System.Drawing.Size(59, 16);
            this.lbTarjetaOEfectivo.TabIndex = 17;
            this.lbTarjetaOEfectivo.Text = "Efectivo";
            // 
            // lbClienteNombre
            // 
            this.lbClienteNombre.AutoSize = true;
            this.lbClienteNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteNombre.Location = new System.Drawing.Point(395, 30);
            this.lbClienteNombre.Name = "lbClienteNombre";
            this.lbClienteNombre.Size = new System.Drawing.Size(87, 16);
            this.lbClienteNombre.TabIndex = 17;
            this.lbClienteNombre.Text = "Loren Ipsum";
            // 
            // lbClienteTitulo
            // 
            this.lbClienteTitulo.AutoSize = true;
            this.lbClienteTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteTitulo.Location = new System.Drawing.Point(333, 30);
            this.lbClienteTitulo.Name = "lbClienteTitulo";
            this.lbClienteTitulo.Size = new System.Drawing.Size(56, 16);
            this.lbClienteTitulo.TabIndex = 17;
            this.lbClienteTitulo.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lbTarjetaOEfectivo);
            this.panel2.Controls.Add(this.lbTotalTitulo);
            this.panel2.Controls.Add(this.lbTotalPrecio);
            this.panel2.Location = new System.Drawing.Point(459, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 54);
            this.panel2.TabIndex = 0;
            // 
            // lbTotalTitulo
            // 
            this.lbTotalTitulo.AutoSize = true;
            this.lbTotalTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalTitulo.Location = new System.Drawing.Point(15, 15);
            this.lbTotalTitulo.Name = "lbTotalTitulo";
            this.lbTotalTitulo.Size = new System.Drawing.Size(59, 23);
            this.lbTotalTitulo.TabIndex = 17;
            this.lbTotalTitulo.Text = "Total";
            // 
            // lbTotalPrecio
            // 
            this.lbTotalPrecio.AutoSize = true;
            this.lbTotalPrecio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPrecio.Location = new System.Drawing.Point(80, 15);
            this.lbTotalPrecio.Name = "lbTotalPrecio";
            this.lbTotalPrecio.Size = new System.Drawing.Size(56, 23);
            this.lbTotalPrecio.TabIndex = 18;
            this.lbTotalPrecio.Text = "0.000";
            // 
            // lbDescuentoTitulo
            // 
            this.lbDescuentoTitulo.AutoSize = true;
            this.lbDescuentoTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescuentoTitulo.Location = new System.Drawing.Point(20, 18);
            this.lbDescuentoTitulo.Name = "lbDescuentoTitulo";
            this.lbDescuentoTitulo.Size = new System.Drawing.Size(81, 16);
            this.lbDescuentoTitulo.TabIndex = 17;
            this.lbDescuentoTitulo.Text = "Descuento:";
            // 
            // lbDescuentoTotal
            // 
            this.lbDescuentoTotal.AutoSize = true;
            this.lbDescuentoTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoTotal.ForeColor = System.Drawing.Color.LightGreen;
            this.lbDescuentoTotal.Location = new System.Drawing.Point(107, 18);
            this.lbDescuentoTotal.Name = "lbDescuentoTotal";
            this.lbDescuentoTotal.Size = new System.Drawing.Size(47, 16);
            this.lbDescuentoTotal.TabIndex = 17;
            this.lbDescuentoTotal.Text = "$ 0.00";
            // 
            // lbImpuestoTitulo
            // 
            this.lbImpuestoTitulo.AutoSize = true;
            this.lbImpuestoTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpuestoTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbImpuestoTitulo.Location = new System.Drawing.Point(250, 18);
            this.lbImpuestoTitulo.Name = "lbImpuestoTitulo";
            this.lbImpuestoTitulo.Size = new System.Drawing.Size(73, 16);
            this.lbImpuestoTitulo.TabIndex = 17;
            this.lbImpuestoTitulo.Text = "Impuesto:";
            // 
            // lbImpuestoTotal
            // 
            this.lbImpuestoTotal.AutoSize = true;
            this.lbImpuestoTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpuestoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbImpuestoTotal.Location = new System.Drawing.Point(329, 18);
            this.lbImpuestoTotal.Name = "lbImpuestoTotal";
            this.lbImpuestoTotal.Size = new System.Drawing.Size(47, 16);
            this.lbImpuestoTotal.TabIndex = 17;
            this.lbImpuestoTotal.Text = "$ 0.00";
            // 
            // frmEstadisticaDiariaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbClienteNombre);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbClienteTitulo);
            this.Controls.Add(this.lbNumeroVentaTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEstadisticaDiariaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la Venta";
            this.Load += new System.EventHandler(this.frmEstadisticaDiariaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbNumeroVentaTitulo;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTarjetaOEfectivo;
        private System.Windows.Forms.Label lbClienteNombre;
        private System.Windows.Forms.Label lbClienteTitulo;
        private System.Windows.Forms.Label lbTotalTitulo;
        private System.Windows.Forms.Label lbTotalPrecio;
        private System.Windows.Forms.Label lbImpuestoTotal;
        private System.Windows.Forms.Label lbDescuentoTotal;
        private System.Windows.Forms.Label lbImpuestoTitulo;
        private System.Windows.Forms.Label lbDescuentoTitulo;
    }
}
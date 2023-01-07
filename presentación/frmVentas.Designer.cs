﻿namespace presentación
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSubtotal = new System.Windows.Forms.Panel();
            this.checkIVA = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalTitulo = new System.Windows.Forms.Label();
            this.lbTotalPrecio = new System.Windows.Forms.Label();
            this.lbIVAPorcentaje = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lbDescuentoSimbolo = new System.Windows.Forms.Label();
            this.lbIVATitulo = new System.Windows.Forms.Label();
            this.lbIVAPrecio = new System.Windows.Forms.Label();
            this.lbDescuentoTitlo = new System.Windows.Forms.Label();
            this.lbSubTotalTitulo = new System.Windows.Forms.Label();
            this.lbSubTotalPrecio = new System.Windows.Forms.Label();
            this.lbCantidadItemTitulo = new System.Windows.Forms.Label();
            this.lbCantidadProductosTitulo = new System.Windows.Forms.Label();
            this.lbCantidadItemsTotal = new System.Windows.Forms.Label();
            this.lbCantidadProductosTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lbFechaTitulo = new System.Windows.Forms.Label();
            this.lbClienteTitulo = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lbAgregarCantidad = new System.Windows.Forms.Label();
            this.panelSubtotal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSubtotal
            // 
            this.panelSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelSubtotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSubtotal.Controls.Add(this.checkIVA);
            this.panelSubtotal.Controls.Add(this.panel1);
            this.panelSubtotal.Controls.Add(this.lbIVAPorcentaje);
            this.panelSubtotal.Controls.Add(this.txtDescuento);
            this.panelSubtotal.Controls.Add(this.lbDescuentoSimbolo);
            this.panelSubtotal.Controls.Add(this.lbIVATitulo);
            this.panelSubtotal.Controls.Add(this.lbIVAPrecio);
            this.panelSubtotal.Controls.Add(this.lbDescuentoTitlo);
            this.panelSubtotal.Controls.Add(this.lbSubTotalTitulo);
            this.panelSubtotal.Controls.Add(this.lbSubTotalPrecio);
            this.panelSubtotal.Location = new System.Drawing.Point(42, 387);
            this.panelSubtotal.Name = "panelSubtotal";
            this.panelSubtotal.Size = new System.Drawing.Size(879, 76);
            this.panelSubtotal.TabIndex = 3;
            // 
            // checkIVA
            // 
            this.checkIVA.AutoSize = true;
            this.checkIVA.Location = new System.Drawing.Point(280, 26);
            this.checkIVA.Name = "checkIVA";
            this.checkIVA.Size = new System.Drawing.Size(15, 14);
            this.checkIVA.TabIndex = 12;
            this.checkIVA.UseVisualStyleBackColor = true;
            this.checkIVA.CheckedChanged += new System.EventHandler(this.checkIVA_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lbTotalTitulo);
            this.panel1.Controls.Add(this.lbTotalPrecio);
            this.panel1.Location = new System.Drawing.Point(713, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 76);
            this.panel1.TabIndex = 7;
            // 
            // lbTotalTitulo
            // 
            this.lbTotalTitulo.AutoSize = true;
            this.lbTotalTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalTitulo.Location = new System.Drawing.Point(52, 14);
            this.lbTotalTitulo.Name = "lbTotalTitulo";
            this.lbTotalTitulo.Size = new System.Drawing.Size(59, 23);
            this.lbTotalTitulo.TabIndex = 7;
            this.lbTotalTitulo.Text = "Total";
            // 
            // lbTotalPrecio
            // 
            this.lbTotalPrecio.AutoSize = true;
            this.lbTotalPrecio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPrecio.Location = new System.Drawing.Point(55, 39);
            this.lbTotalPrecio.Name = "lbTotalPrecio";
            this.lbTotalPrecio.Size = new System.Drawing.Size(56, 23);
            this.lbTotalPrecio.TabIndex = 8;
            this.lbTotalPrecio.Text = "0.000";
            // 
            // lbIVAPorcentaje
            // 
            this.lbIVAPorcentaje.AutoSize = true;
            this.lbIVAPorcentaje.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVAPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIVAPorcentaje.Location = new System.Drawing.Point(330, 27);
            this.lbIVAPorcentaje.Name = "lbIVAPorcentaje";
            this.lbIVAPorcentaje.Size = new System.Drawing.Size(46, 13);
            this.lbIVAPorcentaje.TabIndex = 4;
            this.lbIVAPorcentaje.Text = "21.00%";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(494, 44);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(36, 20);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lbDescuentoSimbolo
            // 
            this.lbDescuentoSimbolo.AutoSize = true;
            this.lbDescuentoSimbolo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoSimbolo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescuentoSimbolo.Location = new System.Drawing.Point(536, 44);
            this.lbDescuentoSimbolo.Name = "lbDescuentoSimbolo";
            this.lbDescuentoSimbolo.Size = new System.Drawing.Size(19, 14);
            this.lbDescuentoSimbolo.TabIndex = 4;
            this.lbDescuentoSimbolo.Text = "%";
            // 
            // lbIVATitulo
            // 
            this.lbIVATitulo.AutoSize = true;
            this.lbIVATitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVATitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIVATitulo.Location = new System.Drawing.Point(301, 26);
            this.lbIVATitulo.Name = "lbIVATitulo";
            this.lbIVATitulo.Size = new System.Drawing.Size(29, 14);
            this.lbIVATitulo.TabIndex = 4;
            this.lbIVATitulo.Text = "IVA";
            // 
            // lbIVAPrecio
            // 
            this.lbIVAPrecio.AutoSize = true;
            this.lbIVAPrecio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVAPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIVAPrecio.Location = new System.Drawing.Point(301, 44);
            this.lbIVAPrecio.Name = "lbIVAPrecio";
            this.lbIVAPrecio.Size = new System.Drawing.Size(39, 14);
            this.lbIVAPrecio.TabIndex = 6;
            this.lbIVAPrecio.Text = "0.000";
            // 
            // lbDescuentoTitlo
            // 
            this.lbDescuentoTitlo.AutoSize = true;
            this.lbDescuentoTitlo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoTitlo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescuentoTitlo.Location = new System.Drawing.Point(491, 27);
            this.lbDescuentoTitlo.Name = "lbDescuentoTitlo";
            this.lbDescuentoTitlo.Size = new System.Drawing.Size(72, 14);
            this.lbDescuentoTitlo.TabIndex = 4;
            this.lbDescuentoTitlo.Text = "Descuento";
            // 
            // lbSubTotalTitulo
            // 
            this.lbSubTotalTitulo.AutoSize = true;
            this.lbSubTotalTitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubTotalTitulo.Location = new System.Drawing.Point(126, 26);
            this.lbSubTotalTitulo.Name = "lbSubTotalTitulo";
            this.lbSubTotalTitulo.Size = new System.Drawing.Size(62, 14);
            this.lbSubTotalTitulo.TabIndex = 4;
            this.lbSubTotalTitulo.Text = "SubTotal";
            // 
            // lbSubTotalPrecio
            // 
            this.lbSubTotalPrecio.AutoSize = true;
            this.lbSubTotalPrecio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubTotalPrecio.Location = new System.Drawing.Point(136, 44);
            this.lbSubTotalPrecio.Name = "lbSubTotalPrecio";
            this.lbSubTotalPrecio.Size = new System.Drawing.Size(39, 14);
            this.lbSubTotalPrecio.TabIndex = 6;
            this.lbSubTotalPrecio.Text = "0.000";
            // 
            // lbCantidadItemTitulo
            // 
            this.lbCantidadItemTitulo.AutoSize = true;
            this.lbCantidadItemTitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadItemTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCantidadItemTitulo.Location = new System.Drawing.Point(176, 364);
            this.lbCantidadItemTitulo.Name = "lbCantidadItemTitulo";
            this.lbCantidadItemTitulo.Size = new System.Drawing.Size(105, 14);
            this.lbCantidadItemTitulo.TabIndex = 4;
            this.lbCantidadItemTitulo.Text = "Cantidad Items:";
            // 
            // lbCantidadProductosTitulo
            // 
            this.lbCantidadProductosTitulo.AutoSize = true;
            this.lbCantidadProductosTitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadProductosTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCantidadProductosTitulo.Location = new System.Drawing.Point(552, 364);
            this.lbCantidadProductosTitulo.Name = "lbCantidadProductosTitulo";
            this.lbCantidadProductosTitulo.Size = new System.Drawing.Size(133, 14);
            this.lbCantidadProductosTitulo.TabIndex = 5;
            this.lbCantidadProductosTitulo.Text = "Cantidad Productos:";
            // 
            // lbCantidadItemsTotal
            // 
            this.lbCantidadItemsTotal.AutoSize = true;
            this.lbCantidadItemsTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadItemsTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCantidadItemsTotal.Location = new System.Drawing.Point(296, 364);
            this.lbCantidadItemsTotal.Name = "lbCantidadItemsTotal";
            this.lbCantidadItemsTotal.Size = new System.Drawing.Size(15, 14);
            this.lbCantidadItemsTotal.TabIndex = 6;
            this.lbCantidadItemsTotal.Text = "0";
            // 
            // lbCantidadProductosTotal
            // 
            this.lbCantidadProductosTotal.AutoSize = true;
            this.lbCantidadProductosTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadProductosTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCantidadProductosTotal.Location = new System.Drawing.Point(701, 364);
            this.lbCantidadProductosTotal.Name = "lbCantidadProductosTotal";
            this.lbCantidadProductosTotal.Size = new System.Drawing.Size(15, 14);
            this.lbCantidadProductosTotal.TabIndex = 6;
            this.lbCantidadProductosTotal.Text = "0";
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
            this.btnCancelar.Location = new System.Drawing.Point(843, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnFacturar.Location = new System.Drawing.Point(402, 477);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 8;
            this.btnFacturar.Text = "Finalizar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnAyuda.Location = new System.Drawing.Point(42, 477);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // lbFechaTitulo
            // 
            this.lbFechaTitulo.AutoSize = true;
            this.lbFechaTitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFechaTitulo.Location = new System.Drawing.Point(40, 51);
            this.lbFechaTitulo.Name = "lbFechaTitulo";
            this.lbFechaTitulo.Size = new System.Drawing.Size(40, 13);
            this.lbFechaTitulo.TabIndex = 10;
            this.lbFechaTitulo.Text = "Fecha";
            // 
            // lbClienteTitulo
            // 
            this.lbClienteTitulo.AutoSize = true;
            this.lbClienteTitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteTitulo.Location = new System.Drawing.Point(210, 51);
            this.lbClienteTitulo.Name = "lbClienteTitulo";
            this.lbClienteTitulo.Size = new System.Drawing.Size(46, 13);
            this.lbClienteTitulo.TabIndex = 10;
            this.lbClienteTitulo.Text = "Cliente";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(86, 48);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(262, 48);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(298, 20);
            this.txtCliente.TabIndex = 11;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.Location = new System.Drawing.Point(42, 116);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 35;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProductos.Size = new System.Drawing.Size(876, 240);
            this.dgvProductos.TabIndex = 12;
            this.dgvProductos.TabStop = false;
            this.dgvProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductos_EditingControlShowing);
            // 
            // lbAgregarCantidad
            // 
            this.lbAgregarCantidad.AutoSize = true;
            this.lbAgregarCantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAgregarCantidad.Location = new System.Drawing.Point(40, 87);
            this.lbAgregarCantidad.Name = "lbAgregarCantidad";
            this.lbAgregarCantidad.Size = new System.Drawing.Size(242, 16);
            this.lbAgregarCantidad.TabIndex = 13;
            this.lbAgregarCantidad.Text = "Presione F1 para modificar cantidad.";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(955, 515);
            this.Controls.Add(this.lbAgregarCantidad);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lbClienteTitulo);
            this.Controls.Add(this.lbFechaTitulo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbCantidadProductosTotal);
            this.Controls.Add(this.lbCantidadItemsTotal);
            this.Controls.Add(this.lbCantidadProductosTitulo);
            this.Controls.Add(this.lbCantidadItemTitulo);
            this.Controls.Add(this.panelSubtotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.panelSubtotal.ResumeLayout(false);
            this.panelSubtotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSubtotal;
        private System.Windows.Forms.Label lbSubTotalTitulo;
        private System.Windows.Forms.Label lbSubTotalPrecio;
        private System.Windows.Forms.Label lbCantidadItemTitulo;
        private System.Windows.Forms.Label lbCantidadProductosTitulo;
        private System.Windows.Forms.Label lbCantidadItemsTotal;
        private System.Windows.Forms.Label lbCantidadProductosTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIVAPorcentaje;
        private System.Windows.Forms.Label lbIVATitulo;
        private System.Windows.Forms.Label lbIVAPrecio;
        private System.Windows.Forms.Label lbTotalTitulo;
        private System.Windows.Forms.Label lbTotalPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lbFechaTitulo;
        private System.Windows.Forms.Label lbClienteTitulo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lbDescuentoSimbolo;
        private System.Windows.Forms.Label lbDescuentoTitlo;
        private System.Windows.Forms.CheckBox checkIVA;
        private System.Windows.Forms.Label lbAgregarCantidad;
    }
}
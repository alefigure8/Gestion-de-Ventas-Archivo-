namespace presentación
{
    partial class frmPresupuesto
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
            this.lbTituloPresupuesto = new System.Windows.Forms.Label();
            this.panelPrespuesto = new System.Windows.Forms.Panel();
            this.lbBuscador = new System.Windows.Forms.Label();
            this.lbModificarcantidad = new System.Windows.Forms.Label();
            this.lbAgregarCantidad = new System.Windows.Forms.Label();
            this.lbModificarPrecio = new System.Windows.Forms.Label();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.numericModificarPresupuesto = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btEliminarProducto = new System.Windows.Forms.Button();
            this.fechaPresupuesto = new System.Windows.Forms.Label();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.lbAgregarPresupuesto = new System.Windows.Forms.Label();
            this.btnAgregarGrid = new System.Windows.Forms.Button();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panelDescarga = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.PictureBox();
            this.btnPrinter = new System.Windows.Forms.PictureBox();
            this.btnFile = new System.Windows.Forms.PictureBox();
            this.panelPrecioTotal = new System.Windows.Forms.Panel();
            this.lbDescuentoPrecio = new System.Windows.Forms.Label();
            this.lbDescueto = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printPresupuesto = new System.Drawing.Printing.PrintDocument();
            this.panelCargarArchivo = new System.Windows.Forms.Panel();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrespuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericModificarPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            this.panelDescarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).BeginInit();
            this.panelPrecioTotal.SuspendLayout();
            this.panelCargarArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloPresupuesto
            // 
            this.lbTituloPresupuesto.AutoSize = true;
            this.lbTituloPresupuesto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPresupuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloPresupuesto.Location = new System.Drawing.Point(37, 47);
            this.lbTituloPresupuesto.Name = "lbTituloPresupuesto";
            this.lbTituloPresupuesto.Size = new System.Drawing.Size(168, 25);
            this.lbTituloPresupuesto.TabIndex = 2;
            this.lbTituloPresupuesto.Text = "PRESUPUESTO";
            // 
            // panelPrespuesto
            // 
            this.panelPrespuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelPrespuesto.Controls.Add(this.label2);
            this.panelPrespuesto.Controls.Add(this.lbBuscador);
            this.panelPrespuesto.Controls.Add(this.lbModificarcantidad);
            this.panelPrespuesto.Controls.Add(this.lbAgregarCantidad);
            this.panelPrespuesto.Controls.Add(this.lbModificarPrecio);
            this.panelPrespuesto.Controls.Add(this.txtModificarPrecio);
            this.panelPrespuesto.Controls.Add(this.numericModificarPresupuesto);
            this.panelPrespuesto.Controls.Add(this.btnModificar);
            this.panelPrespuesto.Controls.Add(this.btEliminarProducto);
            this.panelPrespuesto.Controls.Add(this.fechaPresupuesto);
            this.panelPrespuesto.Controls.Add(this.dgvPresupuesto);
            this.panelPrespuesto.Controls.Add(this.lbAgregarPresupuesto);
            this.panelPrespuesto.Controls.Add(this.btnAgregarGrid);
            this.panelPrespuesto.Location = new System.Drawing.Point(42, 82);
            this.panelPrespuesto.Name = "panelPrespuesto";
            this.panelPrespuesto.Size = new System.Drawing.Size(662, 318);
            this.panelPrespuesto.TabIndex = 11;
            // 
            // lbBuscador
            // 
            this.lbBuscador.AutoSize = true;
            this.lbBuscador.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBuscador.Location = new System.Drawing.Point(164, 64);
            this.lbBuscador.Name = "lbBuscador";
            this.lbBuscador.Size = new System.Drawing.Size(138, 13);
            this.lbBuscador.TabIndex = 16;
            this.lbBuscador.Text = "F2 buscador Productos.";
            // 
            // lbModificarcantidad
            // 
            this.lbModificarcantidad.AutoSize = true;
            this.lbModificarcantidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarcantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbModificarcantidad.Location = new System.Drawing.Point(447, 290);
            this.lbModificarcantidad.Name = "lbModificarcantidad";
            this.lbModificarcantidad.Size = new System.Drawing.Size(62, 14);
            this.lbModificarcantidad.TabIndex = 19;
            this.lbModificarcantidad.Text = "Cantidad";
            // 
            // lbAgregarCantidad
            // 
            this.lbAgregarCantidad.AutoSize = true;
            this.lbAgregarCantidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAgregarCantidad.Location = new System.Drawing.Point(14, 64);
            this.lbAgregarCantidad.Name = "lbAgregarCantidad";
            this.lbAgregarCantidad.Size = new System.Drawing.Size(144, 13);
            this.lbAgregarCantidad.TabIndex = 15;
            this.lbAgregarCantidad.Text = "F1 modificar cantidades.";
            // 
            // lbModificarPrecio
            // 
            this.lbModificarPrecio.AutoSize = true;
            this.lbModificarPrecio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbModificarPrecio.Location = new System.Drawing.Point(336, 290);
            this.lbModificarPrecio.Name = "lbModificarPrecio";
            this.lbModificarPrecio.Size = new System.Drawing.Size(44, 14);
            this.lbModificarPrecio.TabIndex = 18;
            this.lbModificarPrecio.Text = "Precio";
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Location = new System.Drawing.Point(386, 288);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(48, 20);
            this.txtModificarPrecio.TabIndex = 3;
            // 
            // numericModificarPresupuesto
            // 
            this.numericModificarPresupuesto.Location = new System.Drawing.Point(515, 288);
            this.numericModificarPresupuesto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericModificarPresupuesto.Name = "numericModificarPresupuesto";
            this.numericModificarPresupuesto.Size = new System.Drawing.Size(41, 20);
            this.numericModificarPresupuesto.TabIndex = 4;
            this.numericModificarPresupuesto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(562, 286);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btEliminarProducto.Location = new System.Drawing.Point(17, 285);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(77, 23);
            this.btEliminarProducto.TabIndex = 2;
            this.btEliminarProducto.Text = "Borrar";
            this.btEliminarProducto.UseVisualStyleBackColor = false;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // fechaPresupuesto
            // 
            this.fechaPresupuesto.AutoSize = true;
            this.fechaPresupuesto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPresupuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fechaPresupuesto.Location = new System.Drawing.Point(386, 17);
            this.fechaPresupuesto.Name = "fechaPresupuesto";
            this.fechaPresupuesto.Size = new System.Drawing.Size(43, 14);
            this.fechaPresupuesto.TabIndex = 12;
            this.fechaPresupuesto.Text = "label2";
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToDeleteRows = false;
            this.dgvPresupuesto.AllowUserToResizeColumns = false;
            this.dgvPresupuesto.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvPresupuesto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresupuesto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPresupuesto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPresupuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresupuesto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPresupuesto.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPresupuesto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPresupuesto.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvPresupuesto.Location = new System.Drawing.Point(17, 81);
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresupuesto.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPresupuesto.RowHeadersVisible = false;
            this.dgvPresupuesto.RowHeadersWidth = 35;
            this.dgvPresupuesto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPresupuesto.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuesto.Size = new System.Drawing.Size(624, 193);
            this.dgvPresupuesto.TabIndex = 1;
            this.dgvPresupuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuesto_CellContentClick);
            this.dgvPresupuesto.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductos_EditingControlShowing);
            // 
            // lbAgregarPresupuesto
            // 
            this.lbAgregarPresupuesto.AutoSize = true;
            this.lbAgregarPresupuesto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarPresupuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAgregarPresupuesto.Location = new System.Drawing.Point(60, 17);
            this.lbAgregarPresupuesto.Name = "lbAgregarPresupuesto";
            this.lbAgregarPresupuesto.Size = new System.Drawing.Size(167, 14);
            this.lbAgregarPresupuesto.TabIndex = 10;
            this.lbAgregarPresupuesto.Text = "Iniciar nuevo presupuesto";
            // 
            // btnAgregarGrid
            // 
            this.btnAgregarGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnAgregarGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarGrid.FlatAppearance.BorderSize = 0;
            this.btnAgregarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGrid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarGrid.Location = new System.Drawing.Point(16, 13);
            this.btnAgregarGrid.Name = "btnAgregarGrid";
            this.btnAgregarGrid.Size = new System.Drawing.Size(27, 23);
            this.btnAgregarGrid.TabIndex = 0;
            this.btnAgregarGrid.Text = "+";
            this.btnAgregarGrid.UseVisualStyleBackColor = false;
            this.btnAgregarGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPrecio.Location = new System.Drawing.Point(95, 82);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(0, 18);
            this.lbPrecio.TabIndex = 13;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotal.Location = new System.Drawing.Point(20, 82);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 19);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "TOTAL: ";
            // 
            // panelDescarga
            // 
            this.panelDescarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelDescarga.Controls.Add(this.btnExportar);
            this.panelDescarga.Controls.Add(this.btnPrinter);
            this.panelDescarga.Controls.Add(this.btnFile);
            this.panelDescarga.Location = new System.Drawing.Point(710, 82);
            this.panelDescarga.Name = "panelDescarga";
            this.panelDescarga.Size = new System.Drawing.Size(212, 86);
            this.panelDescarga.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Location = new System.Drawing.Point(24, 17);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(50, 50);
            this.btnExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExportar.TabIndex = 2;
            this.btnExportar.TabStop = false;
            this.btnExportar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinter.Location = new System.Drawing.Point(136, 17);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(50, 50);
            this.btnPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrinter.TabIndex = 1;
            this.btnPrinter.TabStop = false;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnFile
            // 
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.Location = new System.Drawing.Point(80, 17);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(50, 50);
            this.btnFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFile.TabIndex = 0;
            this.btnFile.TabStop = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panelPrecioTotal
            // 
            this.panelPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelPrecioTotal.Controls.Add(this.lbDescuentoPrecio);
            this.panelPrecioTotal.Controls.Add(this.lbDescueto);
            this.panelPrecioTotal.Controls.Add(this.txtDescuento);
            this.panelPrecioTotal.Controls.Add(this.label1);
            this.panelPrecioTotal.Controls.Add(this.lbPrecio);
            this.panelPrecioTotal.Controls.Add(this.lbTotal);
            this.panelPrecioTotal.Location = new System.Drawing.Point(710, 227);
            this.panelPrecioTotal.Name = "panelPrecioTotal";
            this.panelPrecioTotal.Size = new System.Drawing.Size(212, 116);
            this.panelPrecioTotal.TabIndex = 13;
            // 
            // lbDescuentoPrecio
            // 
            this.lbDescuentoPrecio.AutoSize = true;
            this.lbDescuentoPrecio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoPrecio.ForeColor = System.Drawing.Color.LightGreen;
            this.lbDescuentoPrecio.Location = new System.Drawing.Point(96, 59);
            this.lbDescuentoPrecio.Name = "lbDescuentoPrecio";
            this.lbDescuentoPrecio.Size = new System.Drawing.Size(0, 14);
            this.lbDescuentoPrecio.TabIndex = 16;
            // 
            // lbDescueto
            // 
            this.lbDescueto.AutoSize = true;
            this.lbDescueto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescueto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescueto.Location = new System.Drawing.Point(21, 27);
            this.lbDescueto.Name = "lbDescueto";
            this.lbDescueto.Size = new System.Drawing.Size(66, 14);
            this.lbDescueto.TabIndex = 15;
            this.lbDescueto.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(104, 22);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(48, 20);
            this.txtDescuento.TabIndex = 0;
            this.txtDescuento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(158, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "%";
            // 
            // printPresupuesto
            // 
            this.printPresupuesto.OriginAtMargins = true;
            this.printPresupuesto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPresupuesto_PrintPage);
            // 
            // panelCargarArchivo
            // 
            this.panelCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelCargarArchivo.Controls.Add(this.btnCargarArchivo);
            this.panelCargarArchivo.Location = new System.Drawing.Point(710, 173);
            this.panelCargarArchivo.Name = "panelCargarArchivo";
            this.panelCargarArchivo.Size = new System.Drawing.Size(212, 50);
            this.panelCargarArchivo.TabIndex = 14;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarArchivo.Location = new System.Drawing.Point(24, 15);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(162, 23);
            this.btnCargarArchivo.TabIndex = 0;
            this.btnCargarArchivo.Text = "Cargar Presupuesto";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(308, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "F3 producto libre.";
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(955, 515);
            this.Controls.Add(this.panelCargarArchivo);
            this.Controls.Add(this.panelPrecioTotal);
            this.Controls.Add(this.panelDescarga);
            this.Controls.Add(this.panelPrespuesto);
            this.Controls.Add(this.lbTituloPresupuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.frmPresupuesto_Load);
            this.panelPrespuesto.ResumeLayout(false);
            this.panelPrespuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericModificarPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.panelDescarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).EndInit();
            this.panelPrecioTotal.ResumeLayout(false);
            this.panelPrecioTotal.PerformLayout();
            this.panelCargarArchivo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloPresupuesto;
        private System.Windows.Forms.Panel panelPrespuesto;
        private System.Windows.Forms.Label lbAgregarPresupuesto;
        private System.Windows.Forms.Button btnAgregarGrid;
        private System.Windows.Forms.Panel panelDescarga;
        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.PictureBox btnPrinter;
        private System.Windows.Forms.PictureBox btnFile;
        private System.Windows.Forms.Panel panelPrecioTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechaPresupuesto;
        private System.Windows.Forms.Button btEliminarProducto;
        private System.Windows.Forms.NumericUpDown numericModificarPresupuesto;
        private System.Windows.Forms.Button btnModificar;
        private System.Drawing.Printing.PrintDocument printPresupuesto;
        private System.Windows.Forms.Label lbDescueto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lbDescuentoPrecio;
        private System.Windows.Forms.PictureBox btnExportar;
        private System.Windows.Forms.Label lbModificarcantidad;
        private System.Windows.Forms.Label lbModificarPrecio;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.Panel panelCargarArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Label lbBuscador;
        private System.Windows.Forms.Label lbAgregarCantidad;
        private System.Windows.Forms.Label label2;
    }
}
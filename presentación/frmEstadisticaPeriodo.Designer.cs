namespace presentación
{
    partial class frmEstadisticaPeriodo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVentasTotalesTitulo = new System.Windows.Forms.Label();
            this.lbVentasTotales = new System.Windows.Forms.Label();
            this.lbVentasCantidad = new System.Windows.Forms.Label();
            this.lbVentasPromedio = new System.Windows.Forms.Label();
            this.lbVentasTarjeta = new System.Windows.Forms.Label();
            this.lbVentasEfectivo = new System.Windows.Forms.Label();
            this.lbVentasTarjetaTitulo = new System.Windows.Forms.Label();
            this.lbVentasTotal = new System.Windows.Forms.Label();
            this.lbVentasPromedioTitulo = new System.Windows.Forms.Label();
            this.lbVentasCantidadTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbOpcionesDescarga = new System.Windows.Forms.ComboBox();
            this.btnPrinter = new System.Windows.Forms.PictureBox();
            this.btnFile = new System.Windows.Forms.PictureBox();
            this.lbEscel = new System.Windows.Forms.Label();
            this.lbPrint = new System.Windows.Forms.Label();
            this.chartSemanalCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printProdcuctosPeriodo = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSemanalCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvVentas.Location = new System.Drawing.Point(17, 41);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidth = 35;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(606, 291);
            this.dgvVentas.TabIndex = 17;
            this.dgvVentas.TabStop = false;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lbVentasCantidad);
            this.panel3.Controls.Add(this.lbVentasPromedio);
            this.panel3.Controls.Add(this.lbVentasTarjeta);
            this.panel3.Controls.Add(this.lbVentasEfectivo);
            this.panel3.Controls.Add(this.lbVentasTarjetaTitulo);
            this.panel3.Controls.Add(this.lbVentasTotal);
            this.panel3.Controls.Add(this.lbVentasPromedioTitulo);
            this.panel3.Controls.Add(this.lbVentasCantidadTitulo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(17, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 159);
            this.panel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lbVentasTotalesTitulo);
            this.panel1.Controls.Add(this.lbVentasTotales);
            this.panel1.Location = new System.Drawing.Point(14, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 98);
            this.panel1.TabIndex = 8;
            // 
            // lbVentasTotalesTitulo
            // 
            this.lbVentasTotalesTitulo.AutoSize = true;
            this.lbVentasTotalesTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTotalesTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTotalesTitulo.Location = new System.Drawing.Point(13, 18);
            this.lbVentasTotalesTitulo.Name = "lbVentasTotalesTitulo";
            this.lbVentasTotalesTitulo.Size = new System.Drawing.Size(80, 25);
            this.lbVentasTotalesTitulo.TabIndex = 3;
            this.lbVentasTotalesTitulo.Text = "TOTAL";
            // 
            // lbVentasTotales
            // 
            this.lbVentasTotales.AutoSize = true;
            this.lbVentasTotales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTotales.ForeColor = System.Drawing.Color.Lime;
            this.lbVentasTotales.Location = new System.Drawing.Point(14, 59);
            this.lbVentasTotales.Name = "lbVentasTotales";
            this.lbVentasTotales.Size = new System.Drawing.Size(70, 23);
            this.lbVentasTotales.TabIndex = 5;
            this.lbVentasTotales.Text = "$ 0,00";
            // 
            // lbVentasCantidad
            // 
            this.lbVentasCantidad.AutoSize = true;
            this.lbVentasCantidad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasCantidad.Location = new System.Drawing.Point(458, 67);
            this.lbVentasCantidad.Name = "lbVentasCantidad";
            this.lbVentasCantidad.Size = new System.Drawing.Size(22, 23);
            this.lbVentasCantidad.TabIndex = 5;
            this.lbVentasCantidad.Text = "0";
            // 
            // lbVentasPromedio
            // 
            this.lbVentasPromedio.AutoSize = true;
            this.lbVentasPromedio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasPromedio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasPromedio.Location = new System.Drawing.Point(458, 122);
            this.lbVentasPromedio.Name = "lbVentasPromedio";
            this.lbVentasPromedio.Size = new System.Drawing.Size(70, 23);
            this.lbVentasPromedio.TabIndex = 5;
            this.lbVentasPromedio.Text = "$ 0,00";
            // 
            // lbVentasTarjeta
            // 
            this.lbVentasTarjeta.AutoSize = true;
            this.lbVentasTarjeta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTarjeta.ForeColor = System.Drawing.Color.Gold;
            this.lbVentasTarjeta.Location = new System.Drawing.Point(272, 119);
            this.lbVentasTarjeta.Name = "lbVentasTarjeta";
            this.lbVentasTarjeta.Size = new System.Drawing.Size(70, 23);
            this.lbVentasTarjeta.TabIndex = 5;
            this.lbVentasTarjeta.Text = "$ 0,00";
            // 
            // lbVentasEfectivo
            // 
            this.lbVentasEfectivo.AutoSize = true;
            this.lbVentasEfectivo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasEfectivo.ForeColor = System.Drawing.Color.LightGreen;
            this.lbVentasEfectivo.Location = new System.Drawing.Point(274, 67);
            this.lbVentasEfectivo.Name = "lbVentasEfectivo";
            this.lbVentasEfectivo.Size = new System.Drawing.Size(70, 23);
            this.lbVentasEfectivo.TabIndex = 5;
            this.lbVentasEfectivo.Text = "$ 0,00";
            // 
            // lbVentasTarjetaTitulo
            // 
            this.lbVentasTarjetaTitulo.AutoSize = true;
            this.lbVentasTarjetaTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTarjetaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTarjetaTitulo.Location = new System.Drawing.Point(273, 98);
            this.lbVentasTarjetaTitulo.Name = "lbVentasTarjetaTitulo";
            this.lbVentasTarjetaTitulo.Size = new System.Drawing.Size(63, 16);
            this.lbVentasTarjetaTitulo.TabIndex = 5;
            this.lbVentasTarjetaTitulo.Text = "TARJETA";
            // 
            // lbVentasTotal
            // 
            this.lbVentasTotal.AutoSize = true;
            this.lbVentasTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTotal.Location = new System.Drawing.Point(11, 18);
            this.lbVentasTotal.Name = "lbVentasTotal";
            this.lbVentasTotal.Size = new System.Drawing.Size(308, 18);
            this.lbVentasTotal.TabIndex = 4;
            this.lbVentasTotal.Text = "Ventas del 00/00/0000 al 00/00/0000";
            // 
            // lbVentasPromedioTitulo
            // 
            this.lbVentasPromedioTitulo.AutoSize = true;
            this.lbVentasPromedioTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasPromedioTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasPromedioTitulo.Location = new System.Drawing.Point(459, 98);
            this.lbVentasPromedioTitulo.Name = "lbVentasPromedioTitulo";
            this.lbVentasPromedioTitulo.Size = new System.Drawing.Size(149, 16);
            this.lbVentasPromedioTitulo.TabIndex = 3;
            this.lbVentasPromedioTitulo.Text = "PROMEDIO POR VENTA";
            // 
            // lbVentasCantidadTitulo
            // 
            this.lbVentasCantidadTitulo.AutoSize = true;
            this.lbVentasCantidadTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasCantidadTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasCantidadTitulo.Location = new System.Drawing.Point(459, 47);
            this.lbVentasCantidadTitulo.Name = "lbVentasCantidadTitulo";
            this.lbVentasCantidadTitulo.Size = new System.Drawing.Size(115, 16);
            this.lbVentasCantidadTitulo.TabIndex = 3;
            this.lbVentasCantidadTitulo.Text = "VENTAS TOTALES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(273, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "EFECTIVO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.cbOpcionesDescarga);
            this.panel2.Controls.Add(this.btnPrinter);
            this.panel2.Controls.Add(this.btnFile);
            this.panel2.Controls.Add(this.lbEscel);
            this.panel2.Controls.Add(this.lbPrint);
            this.panel2.Location = new System.Drawing.Point(680, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 159);
            this.panel2.TabIndex = 15;
            // 
            // cbOpcionesDescarga
            // 
            this.cbOpcionesDescarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcionesDescarga.FormattingEnabled = true;
            this.cbOpcionesDescarga.Location = new System.Drawing.Point(59, 15);
            this.cbOpcionesDescarga.Name = "cbOpcionesDescarga";
            this.cbOpcionesDescarga.Size = new System.Drawing.Size(144, 21);
            this.cbOpcionesDescarga.TabIndex = 6;
            // 
            // btnPrinter
            // 
            this.btnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinter.Location = new System.Drawing.Point(153, 55);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(50, 50);
            this.btnPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrinter.TabIndex = 5;
            this.btnPrinter.TabStop = false;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnFile
            // 
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.Location = new System.Drawing.Point(59, 55);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(50, 50);
            this.btnFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFile.TabIndex = 5;
            this.btnFile.TabStop = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lbEscel
            // 
            this.lbEscel.AutoSize = true;
            this.lbEscel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEscel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEscel.Location = new System.Drawing.Point(65, 118);
            this.lbEscel.Name = "lbEscel";
            this.lbEscel.Size = new System.Drawing.Size(36, 13);
            this.lbEscel.TabIndex = 3;
            this.lbEscel.Text = "Excel";
            // 
            // lbPrint
            // 
            this.lbPrint.AutoSize = true;
            this.lbPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPrint.Location = new System.Drawing.Point(151, 118);
            this.lbPrint.Name = "lbPrint";
            this.lbPrint.Size = new System.Drawing.Size(57, 13);
            this.lbPrint.TabIndex = 3;
            this.lbPrint.Text = "Imprimir";
            // 
            // chartSemanalCategoria
            // 
            this.chartSemanalCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea1.Name = "ChartArea1";
            this.chartSemanalCategoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSemanalCategoria.Legends.Add(legend1);
            this.chartSemanalCategoria.Location = new System.Drawing.Point(636, 41);
            this.chartSemanalCategoria.Name = "chartSemanalCategoria";
            this.chartSemanalCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Categorias";
            this.chartSemanalCategoria.Series.Add(series1);
            this.chartSemanalCategoria.Size = new System.Drawing.Size(294, 291);
            this.chartSemanalCategoria.TabIndex = 14;
            this.chartSemanalCategoria.Text = "chart1";
            title1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Title1";
            title1.Text = "Categorias";
            this.chartSemanalCategoria.Titles.Add(title1);
            // 
            // frmEstadisticaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(971, 575);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartSemanalCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadisticaPeriodo";
            this.Text = "Estadistica por periodo";
            this.Load += new System.EventHandler(this.frmEstadisticaPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSemanalCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVentasTotalesTitulo;
        private System.Windows.Forms.Label lbVentasTotales;
        private System.Windows.Forms.Label lbVentasCantidad;
        private System.Windows.Forms.Label lbVentasPromedio;
        private System.Windows.Forms.Label lbVentasTarjeta;
        private System.Windows.Forms.Label lbVentasEfectivo;
        private System.Windows.Forms.Label lbVentasTarjetaTitulo;
        private System.Windows.Forms.Label lbVentasTotal;
        private System.Windows.Forms.Label lbVentasPromedioTitulo;
        private System.Windows.Forms.Label lbVentasCantidadTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnPrinter;
        private System.Windows.Forms.PictureBox btnFile;
        private System.Windows.Forms.Label lbEscel;
        private System.Windows.Forms.Label lbPrint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSemanalCategoria;
        private System.Drawing.Printing.PrintDocument printProdcuctosPeriodo;
        private System.Windows.Forms.ComboBox cbOpcionesDescarga;
    }
}
namespace presentación
{
    partial class frmEstadisticaSemanales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartGananciaSemanal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSemanalCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbVentaTotalPorDia = new System.Windows.Forms.Label();
            this.lbVentaTotalPorDiaTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVentaSemanaTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrinter = new System.Windows.Forms.PictureBox();
            this.btnFile = new System.Windows.Forms.PictureBox();
            this.lbDescasFiles = new System.Windows.Forms.Label();
            this.lbEscel = new System.Windows.Forms.Label();
            this.lbPrint = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbVentasTarjeta = new System.Windows.Forms.Label();
            this.lbVentasEfectivo = new System.Windows.Forms.Label();
            this.lbVentasTarjetaTitulo = new System.Windows.Forms.Label();
            this.lbVentasTotal = new System.Windows.Forms.Label();
            this.lbVentasEfectivoTitulo = new System.Windows.Forms.Label();
            this.printProdcuctosSemanal = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciaSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSemanalCategoria)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGananciaSemanal
            // 
            this.chartGananciaSemanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.chartGananciaSemanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartGananciaSemanal.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartGananciaSemanal.BackSecondaryColor = System.Drawing.Color.White;
            this.chartGananciaSemanal.BorderlineWidth = 0;
            this.chartGananciaSemanal.BorderSkin.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.DarkGray;
            this.chartGananciaSemanal.ChartAreas.Add(chartArea3);
            legend3.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend3.Name = "Legend1";
            this.chartGananciaSemanal.Legends.Add(legend3);
            this.chartGananciaSemanal.Location = new System.Drawing.Point(19, 41);
            this.chartGananciaSemanal.Name = "chartGananciaSemanal";
            this.chartGananciaSemanal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsVisibleInLegend = false;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Transparent;
            series3.Name = "Semana";
            this.chartGananciaSemanal.Series.Add(series3);
            this.chartGananciaSemanal.Size = new System.Drawing.Size(606, 291);
            this.chartGananciaSemanal.TabIndex = 1;
            this.chartGananciaSemanal.Text = "chart1";
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.BackSecondaryColor = System.Drawing.Color.Transparent;
            title3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.WhiteSmoke;
            title3.Name = "Semana";
            this.chartGananciaSemanal.Titles.Add(title3);
            // 
            // chartSemanalCategoria
            // 
            this.chartSemanalCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea4.Name = "ChartArea1";
            this.chartSemanalCategoria.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSemanalCategoria.Legends.Add(legend4);
            this.chartSemanalCategoria.Location = new System.Drawing.Point(636, 41);
            this.chartSemanalCategoria.Name = "chartSemanalCategoria";
            this.chartSemanalCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Categorias";
            this.chartSemanalCategoria.Series.Add(series4);
            this.chartSemanalCategoria.Size = new System.Drawing.Size(294, 291);
            this.chartSemanalCategoria.TabIndex = 2;
            this.chartSemanalCategoria.Text = "chart1";
            title4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.WhiteSmoke;
            title4.Name = "Title1";
            title4.Text = "Categorias";
            this.chartSemanalCategoria.Titles.Add(title4);
            // 
            // lbVentaTotalPorDia
            // 
            this.lbVentaTotalPorDia.AutoSize = true;
            this.lbVentaTotalPorDia.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentaTotalPorDia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentaTotalPorDia.Location = new System.Drawing.Point(38, 44);
            this.lbVentaTotalPorDia.Name = "lbVentaTotalPorDia";
            this.lbVentaTotalPorDia.Size = new System.Drawing.Size(82, 15);
            this.lbVentaTotalPorDia.TabIndex = 3;
            this.lbVentaTotalPorDia.Text = "Ventas por día";
            // 
            // lbVentaTotalPorDiaTitulo
            // 
            this.lbVentaTotalPorDiaTitulo.AutoSize = true;
            this.lbVentaTotalPorDiaTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentaTotalPorDiaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentaTotalPorDiaTitulo.Location = new System.Drawing.Point(37, 14);
            this.lbVentaTotalPorDiaTitulo.Name = "lbVentaTotalPorDiaTitulo";
            this.lbVentaTotalPorDiaTitulo.Size = new System.Drawing.Size(150, 23);
            this.lbVentaTotalPorDiaTitulo.TabIndex = 4;
            this.lbVentaTotalPorDiaTitulo.Text = "Ventas por Día";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lbVentaTotalPorDiaTitulo);
            this.panel1.Controls.Add(this.lbVentaTotalPorDia);
            this.panel1.Location = new System.Drawing.Point(135, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 159);
            this.panel1.TabIndex = 5;
            // 
            // lbVentaSemanaTitulo
            // 
            this.lbVentaSemanaTitulo.AutoSize = true;
            this.lbVentaSemanaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.lbVentaSemanaTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentaSemanaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentaSemanaTitulo.Location = new System.Drawing.Point(185, 53);
            this.lbVentaSemanaTitulo.Name = "lbVentaSemanaTitulo";
            this.lbVentaSemanaTitulo.Size = new System.Drawing.Size(273, 23);
            this.lbVentaSemanaTitulo.TabIndex = 5;
            this.lbVentaSemanaTitulo.Text = "Semana del 00/00 al 00/00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.btnPrinter);
            this.panel2.Controls.Add(this.btnFile);
            this.panel2.Controls.Add(this.lbDescasFiles);
            this.panel2.Controls.Add(this.lbEscel);
            this.panel2.Controls.Add(this.lbPrint);
            this.panel2.Location = new System.Drawing.Point(606, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 159);
            this.panel2.TabIndex = 5;
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
            // lbDescasFiles
            // 
            this.lbDescasFiles.AutoSize = true;
            this.lbDescasFiles.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescasFiles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescasFiles.Location = new System.Drawing.Point(78, 14);
            this.lbDescasFiles.Name = "lbDescasFiles";
            this.lbDescasFiles.Size = new System.Drawing.Size(105, 23);
            this.lbDescasFiles.TabIndex = 4;
            this.lbDescasFiles.Text = "Descargar";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.lbVentasTarjeta);
            this.panel3.Controls.Add(this.lbVentasEfectivo);
            this.panel3.Controls.Add(this.lbVentasTarjetaTitulo);
            this.panel3.Controls.Add(this.lbVentasTotal);
            this.panel3.Controls.Add(this.lbVentasEfectivoTitulo);
            this.panel3.Location = new System.Drawing.Point(366, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 159);
            this.panel3.TabIndex = 6;
            // 
            // lbVentasTarjeta
            // 
            this.lbVentasTarjeta.AutoSize = true;
            this.lbVentasTarjeta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTarjeta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTarjeta.Location = new System.Drawing.Point(18, 122);
            this.lbVentasTarjeta.Name = "lbVentasTarjeta";
            this.lbVentasTarjeta.Size = new System.Drawing.Size(70, 23);
            this.lbVentasTarjeta.TabIndex = 5;
            this.lbVentasTarjeta.Text = "$ 0,00";
            // 
            // lbVentasEfectivo
            // 
            this.lbVentasEfectivo.AutoSize = true;
            this.lbVentasEfectivo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasEfectivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasEfectivo.Location = new System.Drawing.Point(18, 70);
            this.lbVentasEfectivo.Name = "lbVentasEfectivo";
            this.lbVentasEfectivo.Size = new System.Drawing.Size(68, 23);
            this.lbVentasEfectivo.TabIndex = 5;
            this.lbVentasEfectivo.Text = "label1";
            // 
            // lbVentasTarjetaTitulo
            // 
            this.lbVentasTarjetaTitulo.AutoSize = true;
            this.lbVentasTarjetaTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTarjetaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTarjetaTitulo.Location = new System.Drawing.Point(17, 101);
            this.lbVentasTarjetaTitulo.Name = "lbVentasTarjetaTitulo";
            this.lbVentasTarjetaTitulo.Size = new System.Drawing.Size(172, 16);
            this.lbVentasTarjetaTitulo.TabIndex = 5;
            this.lbVentasTarjetaTitulo.Text = "Tarjetas y transferencias";
            // 
            // lbVentasTotal
            // 
            this.lbVentasTotal.AutoSize = true;
            this.lbVentasTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasTotal.Location = new System.Drawing.Point(37, 14);
            this.lbVentasTotal.Name = "lbVentasTotal";
            this.lbVentasTotal.Size = new System.Drawing.Size(152, 23);
            this.lbVentasTotal.TabIndex = 4;
            this.lbVentasTotal.Text = "Venta Semanal";
            // 
            // lbVentasEfectivoTitulo
            // 
            this.lbVentasEfectivoTitulo.AutoSize = true;
            this.lbVentasEfectivoTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentasEfectivoTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentasEfectivoTitulo.Location = new System.Drawing.Point(19, 47);
            this.lbVentasEfectivoTitulo.Name = "lbVentasEfectivoTitulo";
            this.lbVentasEfectivoTitulo.Size = new System.Drawing.Size(59, 16);
            this.lbVentasEfectivoTitulo.TabIndex = 3;
            this.lbVentasEfectivoTitulo.Text = "Efectivo";
            // 
            // frmEstadisticaSemanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(971, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbVentaSemanaTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSemanalCategoria);
            this.Controls.Add(this.chartGananciaSemanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadisticaSemanales";
            this.Text = "frmEstadisticaSemanales";
            this.Load += new System.EventHandler(this.frmEstadisticaSemanales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciaSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSemanalCategoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGananciaSemanal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSemanalCategoria;
        private System.Windows.Forms.Label lbVentaTotalPorDia;
        private System.Windows.Forms.Label lbVentaTotalPorDiaTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVentaSemanaTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDescasFiles;
        private System.Windows.Forms.Label lbPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbVentasTarjetaTitulo;
        private System.Windows.Forms.Label lbVentasTotal;
        private System.Windows.Forms.Label lbVentasEfectivoTitulo;
        private System.Windows.Forms.Label lbVentasEfectivo;
        private System.Windows.Forms.Label lbVentasTarjeta;
        private System.Windows.Forms.PictureBox btnPrinter;
        private System.Windows.Forms.PictureBox btnFile;
        private System.Windows.Forms.Label lbEscel;
        private System.Drawing.Printing.PrintDocument printProdcuctosSemanal;
    }
}
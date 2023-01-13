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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartGananciaSemanal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSemanalCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbVentaTotalPorDia = new System.Windows.Forms.Label();
            this.lbVentaTotalPorDiaTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVentaSemanaTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciaSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSemanalCategoria)).BeginInit();
            this.panel1.SuspendLayout();
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
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.DarkGray;
            this.chartGananciaSemanal.ChartAreas.Add(chartArea5);
            legend5.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend5.Name = "Legend1";
            this.chartGananciaSemanal.Legends.Add(legend5);
            this.chartGananciaSemanal.Location = new System.Drawing.Point(19, 41);
            this.chartGananciaSemanal.Name = "chartGananciaSemanal";
            this.chartGananciaSemanal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsVisibleInLegend = false;
            series5.LabelBackColor = System.Drawing.Color.Transparent;
            series5.LabelBorderColor = System.Drawing.Color.Transparent;
            series5.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Transparent;
            series5.Name = "Semana";
            this.chartGananciaSemanal.Series.Add(series5);
            this.chartGananciaSemanal.Size = new System.Drawing.Size(606, 291);
            this.chartGananciaSemanal.TabIndex = 1;
            this.chartGananciaSemanal.Text = "chart1";
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.BackSecondaryColor = System.Drawing.Color.Transparent;
            title5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.ForeColor = System.Drawing.Color.WhiteSmoke;
            title5.Name = "Semana";
            this.chartGananciaSemanal.Titles.Add(title5);
            // 
            // chartSemanalCategoria
            // 
            this.chartSemanalCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea6.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            chartArea6.Name = "ChartArea1";
            this.chartSemanalCategoria.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSemanalCategoria.Legends.Add(legend6);
            this.chartSemanalCategoria.Location = new System.Drawing.Point(636, 41);
            this.chartSemanalCategoria.Name = "chartSemanalCategoria";
            this.chartSemanalCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Categorias";
            this.chartSemanalCategoria.Series.Add(series6);
            this.chartSemanalCategoria.Size = new System.Drawing.Size(294, 291);
            this.chartSemanalCategoria.TabIndex = 2;
            this.chartSemanalCategoria.Text = "chart1";
            title6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.ForeColor = System.Drawing.Color.WhiteSmoke;
            title6.Name = "Title1";
            title6.Text = "Categorias";
            this.chartSemanalCategoria.Titles.Add(title6);
            // 
            // lbVentaTotalPorDia
            // 
            this.lbVentaTotalPorDia.AutoSize = true;
            this.lbVentaTotalPorDia.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentaTotalPorDia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentaTotalPorDia.Location = new System.Drawing.Point(38, 44);
            this.lbVentaTotalPorDia.Name = "lbVentaTotalPorDia";
            this.lbVentaTotalPorDia.Size = new System.Drawing.Size(38, 15);
            this.lbVentaTotalPorDia.TabIndex = 3;
            this.lbVentaTotalPorDia.Text = "label1";
            // 
            // lbVentaTotalPorDiaTitulo
            // 
            this.lbVentaTotalPorDiaTitulo.AutoSize = true;
            this.lbVentaTotalPorDiaTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentaTotalPorDiaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbVentaTotalPorDiaTitulo.Location = new System.Drawing.Point(121, 14);
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
            this.panel1.Location = new System.Drawing.Point(19, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 159);
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
            // frmEstadisticaSemanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(971, 575);
            this.Controls.Add(this.lbVentaSemanaTitulo);
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
    }
}
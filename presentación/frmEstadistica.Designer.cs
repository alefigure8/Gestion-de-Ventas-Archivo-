namespace presentación
{
    partial class frmEstadistica
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
            this.panelContainerOprions = new System.Windows.Forms.Panel();
            this.btnDiario = new System.Windows.Forms.Button();
            this.btnEstadisticaSemanal = new System.Windows.Forms.Button();
            this.lbDateTimeEnd = new System.Windows.Forms.Label();
            this.panelContainerOprions2 = new System.Windows.Forms.Panel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.lbDateTimeStart = new System.Windows.Forms.Label();
            this.lbTituloPresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainerOprions.SuspendLayout();
            this.panelContainerOprions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainerOprions
            // 
            this.panelContainerOprions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panelContainerOprions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerOprions.Controls.Add(this.btnDiario);
            this.panelContainerOprions.Controls.Add(this.btnEstadisticaSemanal);
            this.panelContainerOprions.Location = new System.Drawing.Point(193, 102);
            this.panelContainerOprions.Name = "panelContainerOprions";
            this.panelContainerOprions.Size = new System.Drawing.Size(552, 152);
            this.panelContainerOprions.TabIndex = 0;
            this.panelContainerOprions.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDiario
            // 
            this.btnDiario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiario.FlatAppearance.BorderSize = 0;
            this.btnDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiario.Location = new System.Drawing.Point(82, 45);
            this.btnDiario.Name = "btnDiario";
            this.btnDiario.Size = new System.Drawing.Size(162, 66);
            this.btnDiario.TabIndex = 1;
            this.btnDiario.Text = "Venta Diaria";
            this.btnDiario.UseVisualStyleBackColor = false;
            this.btnDiario.Click += new System.EventHandler(this.btnDiario_Click);
            // 
            // btnEstadisticaSemanal
            // 
            this.btnEstadisticaSemanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnEstadisticaSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticaSemanal.FlatAppearance.BorderSize = 0;
            this.btnEstadisticaSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticaSemanal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticaSemanal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadisticaSemanal.Location = new System.Drawing.Point(311, 45);
            this.btnEstadisticaSemanal.Name = "btnEstadisticaSemanal";
            this.btnEstadisticaSemanal.Size = new System.Drawing.Size(162, 66);
            this.btnEstadisticaSemanal.TabIndex = 1;
            this.btnEstadisticaSemanal.Text = "Venta Semanal";
            this.btnEstadisticaSemanal.UseVisualStyleBackColor = false;
            this.btnEstadisticaSemanal.Click += new System.EventHandler(this.btnEstadisticaSemanal_Click);
            // 
            // lbDateTimeEnd
            // 
            this.lbDateTimeEnd.AutoSize = true;
            this.lbDateTimeEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTimeEnd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDateTimeEnd.Location = new System.Drawing.Point(256, 27);
            this.lbDateTimeEnd.Name = "lbDateTimeEnd";
            this.lbDateTimeEnd.Size = new System.Drawing.Size(45, 16);
            this.lbDateTimeEnd.TabIndex = 4;
            this.lbDateTimeEnd.Text = "Hasta";
            // 
            // panelContainerOprions2
            // 
            this.panelContainerOprions2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panelContainerOprions2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerOprions2.Controls.Add(this.lbDateTimeEnd);
            this.panelContainerOprions2.Controls.Add(this.dateStart);
            this.panelContainerOprions2.Controls.Add(this.dateEnd);
            this.panelContainerOprions2.Controls.Add(this.btnPeriodo);
            this.panelContainerOprions2.Controls.Add(this.lbDateTimeStart);
            this.panelContainerOprions2.Location = new System.Drawing.Point(193, 301);
            this.panelContainerOprions2.Name = "panelContainerOprions2";
            this.panelContainerOprions2.Size = new System.Drawing.Size(552, 152);
            this.panelContainerOprions2.TabIndex = 4;
            this.panelContainerOprions2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainerOprions2_Paint);
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.CustomFormat = "";
            this.dateStart.Location = new System.Drawing.Point(160, 27);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(90, 20);
            this.dateStart.TabIndex = 2;
            this.dateStart.Value = new System.DateTime(2023, 1, 25, 0, 0, 0, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(307, 27);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(90, 20);
            this.dateEnd.TabIndex = 3;
            this.dateEnd.Value = new System.DateTime(2023, 1, 25, 0, 0, 0, 0);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriodo.FlatAppearance.BorderSize = 0;
            this.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPeriodo.Location = new System.Drawing.Point(196, 66);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(162, 66);
            this.btnPeriodo.TabIndex = 1;
            this.btnPeriodo.Text = "Ventas";
            this.btnPeriodo.UseVisualStyleBackColor = false;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // lbDateTimeStart
            // 
            this.lbDateTimeStart.AutoSize = true;
            this.lbDateTimeStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTimeStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDateTimeStart.Location = new System.Drawing.Point(107, 27);
            this.lbDateTimeStart.Name = "lbDateTimeStart";
            this.lbDateTimeStart.Size = new System.Drawing.Size(47, 16);
            this.lbDateTimeStart.TabIndex = 4;
            this.lbDateTimeStart.Text = "Desde";
            // 
            // lbTituloPresupuesto
            // 
            this.lbTituloPresupuesto.AutoSize = true;
            this.lbTituloPresupuesto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPresupuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloPresupuesto.Location = new System.Drawing.Point(397, 74);
            this.lbTituloPresupuesto.Name = "lbTituloPresupuesto";
            this.lbTituloPresupuesto.Size = new System.Drawing.Size(155, 25);
            this.lbTituloPresupuesto.TabIndex = 3;
            this.lbTituloPresupuesto.Text = "ESTADÍSTICA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(332, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESTADÍSTICA POR FECHA";
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panelContainerOprions2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTituloPresupuesto);
            this.Controls.Add(this.panelContainerOprions);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadistica";
            this.Text = "frmEstadistica";
            this.Load += new System.EventHandler(this.frmEstadistica_Load);
            this.panelContainerOprions.ResumeLayout(false);
            this.panelContainerOprions2.ResumeLayout(false);
            this.panelContainerOprions2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerOprions;
        private System.Windows.Forms.Label lbTituloPresupuesto;
        private System.Windows.Forms.Button btnEstadisticaSemanal;
        private System.Windows.Forms.Button btnDiario;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Panel panelContainerOprions2;
        private System.Windows.Forms.Label lbDateTimeEnd;
        private System.Windows.Forms.Label lbDateTimeStart;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.lbTituloPresupuesto = new System.Windows.Forms.Label();
            this.btnEstadisticaSemanal = new System.Windows.Forms.Button();
            this.panelContainerOprions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainerOprions
            // 
            this.panelContainerOprions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelContainerOprions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerOprions.Controls.Add(this.btnEstadisticaSemanal);
            this.panelContainerOprions.Location = new System.Drawing.Point(193, 102);
            this.panelContainerOprions.Name = "panelContainerOprions";
            this.panelContainerOprions.Size = new System.Drawing.Size(552, 302);
            this.panelContainerOprions.TabIndex = 0;
            this.panelContainerOprions.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTituloPresupuesto
            // 
            this.lbTituloPresupuesto.AutoSize = true;
            this.lbTituloPresupuesto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPresupuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloPresupuesto.Location = new System.Drawing.Point(386, 62);
            this.lbTituloPresupuesto.Name = "lbTituloPresupuesto";
            this.lbTituloPresupuesto.Size = new System.Drawing.Size(168, 25);
            this.lbTituloPresupuesto.TabIndex = 3;
            this.lbTituloPresupuesto.Text = "PRESUPUESTO";
            // 
            // btnEstadisticaSemanal
            // 
            this.btnEstadisticaSemanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnEstadisticaSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticaSemanal.FlatAppearance.BorderSize = 0;
            this.btnEstadisticaSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticaSemanal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticaSemanal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadisticaSemanal.Location = new System.Drawing.Point(84, 38);
            this.btnEstadisticaSemanal.Name = "btnEstadisticaSemanal";
            this.btnEstadisticaSemanal.Size = new System.Drawing.Size(162, 66);
            this.btnEstadisticaSemanal.TabIndex = 1;
            this.btnEstadisticaSemanal.Text = "Venta Semanal";
            this.btnEstadisticaSemanal.UseVisualStyleBackColor = false;
            this.btnEstadisticaSemanal.Click += new System.EventHandler(this.btnEstadisticaSemanal_Click);
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTituloPresupuesto);
            this.Controls.Add(this.panelContainerOprions);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadistica";
            this.Text = "frmEstadistica";
            this.Load += new System.EventHandler(this.frmEstadistica_Load);
            this.panelContainerOprions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerOprions;
        private System.Windows.Forms.Label lbTituloPresupuesto;
        private System.Windows.Forms.Button btnEstadisticaSemanal;
    }
}
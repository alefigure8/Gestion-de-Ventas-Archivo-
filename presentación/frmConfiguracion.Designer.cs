namespace presentación
{
    partial class frmConfiguracion
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
            this.lbTituloConfiguracion = new System.Windows.Forms.Label();
            this.gbLogo = new System.Windows.Forms.GroupBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.picLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbLogoText = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.gbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloConfiguracion
            // 
            this.lbTituloConfiguracion.AutoSize = true;
            this.lbTituloConfiguracion.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloConfiguracion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTituloConfiguracion.Location = new System.Drawing.Point(33, 47);
            this.lbTituloConfiguracion.Name = "lbTituloConfiguracion";
            this.lbTituloConfiguracion.Size = new System.Drawing.Size(197, 25);
            this.lbTituloConfiguracion.TabIndex = 2;
            this.lbTituloConfiguracion.Text = "CONFIGURACIÓN";
            // 
            // gbLogo
            // 
            this.gbLogo.Controls.Add(this.btnLogo);
            this.gbLogo.Controls.Add(this.picLogoEmpresa);
            this.gbLogo.Controls.Add(this.btnGuardar);
            this.gbLogo.Controls.Add(this.lbLogoText);
            this.gbLogo.Controls.Add(this.btnSeleccionarImagen);
            this.gbLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbLogo.Location = new System.Drawing.Point(38, 97);
            this.gbLogo.Name = "gbLogo";
            this.gbLogo.Size = new System.Drawing.Size(857, 187);
            this.gbLogo.TabIndex = 4;
            this.gbLogo.TabStop = false;
            this.gbLogo.Text = "Logo";
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnLogo.Location = new System.Drawing.Point(14, 149);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(86, 23);
            this.btnLogo.TabIndex = 11;
            this.btnLogo.Text = "Sin Banner";
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogoEmpresa
            // 
            this.picLogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogoEmpresa.InitialImage = null;
            this.picLogoEmpresa.Location = new System.Drawing.Point(14, 58);
            this.picLogoEmpresa.Name = "picLogoEmpresa";
            this.picLogoEmpresa.Size = new System.Drawing.Size(314, 76);
            this.picLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoEmpresa.TabIndex = 10;
            this.picLogoEmpresa.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(253, 149);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbLogoText
            // 
            this.lbLogoText.AutoSize = true;
            this.lbLogoText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogoText.Location = new System.Drawing.Point(11, 30);
            this.lbLogoText.Name = "lbLogoText";
            this.lbLogoText.Size = new System.Drawing.Size(511, 14);
            this.lbLogoText.TabIndex = 5;
            this.lbLogoText.Text = "Modificar la imagen principal. Solo se puede elegir imágenes con extensión .jgp, " +
    ".png y .bmp";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSeleccionarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarImagen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(118, 149);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(120, 23);
            this.btnSeleccionarImagen.TabIndex = 4;
            this.btnSeleccionarImagen.Text = "Seleccionar";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = false;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(945, 476);
            this.Controls.Add(this.gbLogo);
            this.Controls.Add(this.lbTituloConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "Configuración";
            this.gbLogo.ResumeLayout(false);
            this.gbLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloConfiguracion;
        private System.Windows.Forms.GroupBox gbLogo;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.Label lbLogoText;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox picLogoEmpresa;
        private System.Windows.Forms.Button btnLogo;
    }
}
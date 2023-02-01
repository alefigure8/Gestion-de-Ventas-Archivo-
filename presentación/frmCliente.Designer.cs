namespace presentación
{
    partial class frmCliente
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
            this.labelFrmClienteTitulo = new System.Windows.Forms.Label();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.panelCamposAgregarCliente = new System.Windows.Forms.Panel();
            this.lbClienteEmpresa = new System.Windows.Forms.Label();
            this.txtClienteEmpresa = new System.Windows.Forms.TextBox();
            this.lbClienteApellido = new System.Windows.Forms.Label();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.lbClienteNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.panelTituloAgregarCliente = new System.Windows.Forms.Panel();
            this.lbSearchTitle = new System.Windows.Forms.Label();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.panelCamposAgregarCliente.SuspendLayout();
            this.panelTituloAgregarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrmClienteTitulo
            // 
            this.labelFrmClienteTitulo.AutoSize = true;
            this.labelFrmClienteTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrmClienteTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFrmClienteTitulo.Location = new System.Drawing.Point(33, 22);
            this.labelFrmClienteTitulo.Name = "labelFrmClienteTitulo";
            this.labelFrmClienteTitulo.Size = new System.Drawing.Size(116, 25);
            this.labelFrmClienteTitulo.TabIndex = 2;
            this.labelFrmClienteTitulo.Text = "CLIENTES";
            // 
            // dvgClientes
            // 
            this.dvgClientes.AllowUserToResizeColumns = false;
            this.dvgClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dvgClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dvgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgClientes.GridColor = System.Drawing.SystemColors.WindowText;
            this.dvgClientes.Location = new System.Drawing.Point(38, 109);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgClientes.RowHeadersVisible = false;
            this.dvgClientes.RowHeadersWidth = 35;
            this.dvgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgClientes.Size = new System.Drawing.Size(364, 223);
            this.dvgClientes.TabIndex = 3;
            this.dvgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClientes_CellContentClick);
            // 
            // panelCamposAgregarCliente
            // 
            this.panelCamposAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.panelCamposAgregarCliente.Controls.Add(this.lbClienteEmpresa);
            this.panelCamposAgregarCliente.Controls.Add(this.txtClienteEmpresa);
            this.panelCamposAgregarCliente.Controls.Add(this.lbClienteApellido);
            this.panelCamposAgregarCliente.Controls.Add(this.txtClienteApellido);
            this.panelCamposAgregarCliente.Controls.Add(this.lbClienteNombre);
            this.panelCamposAgregarCliente.Controls.Add(this.btnAgregar);
            this.panelCamposAgregarCliente.Controls.Add(this.txtClienteNombre);
            this.panelCamposAgregarCliente.Location = new System.Drawing.Point(422, 133);
            this.panelCamposAgregarCliente.Name = "panelCamposAgregarCliente";
            this.panelCamposAgregarCliente.Size = new System.Drawing.Size(307, 199);
            this.panelCamposAgregarCliente.TabIndex = 1;
            // 
            // lbClienteEmpresa
            // 
            this.lbClienteEmpresa.AutoSize = true;
            this.lbClienteEmpresa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteEmpresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteEmpresa.Location = new System.Drawing.Point(18, 105);
            this.lbClienteEmpresa.Name = "lbClienteEmpresa";
            this.lbClienteEmpresa.Size = new System.Drawing.Size(62, 16);
            this.lbClienteEmpresa.TabIndex = 9;
            this.lbClienteEmpresa.Text = "Empresa";
            // 
            // txtClienteEmpresa
            // 
            this.txtClienteEmpresa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEmpresa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClienteEmpresa.Location = new System.Drawing.Point(21, 124);
            this.txtClienteEmpresa.MaxLength = 200;
            this.txtClienteEmpresa.Name = "txtClienteEmpresa";
            this.txtClienteEmpresa.Size = new System.Drawing.Size(268, 21);
            this.txtClienteEmpresa.TabIndex = 2;
            this.txtClienteEmpresa.Tag = "";
            // 
            // lbClienteApellido
            // 
            this.lbClienteApellido.AutoSize = true;
            this.lbClienteApellido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteApellido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteApellido.Location = new System.Drawing.Point(18, 57);
            this.lbClienteApellido.Name = "lbClienteApellido";
            this.lbClienteApellido.Size = new System.Drawing.Size(58, 16);
            this.lbClienteApellido.TabIndex = 7;
            this.lbClienteApellido.Text = "Apellido";
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClienteApellido.Location = new System.Drawing.Point(21, 76);
            this.txtClienteApellido.MaxLength = 200;
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(268, 21);
            this.txtClienteApellido.TabIndex = 1;
            this.txtClienteApellido.Tag = "";
            // 
            // lbClienteNombre
            // 
            this.lbClienteNombre.AutoSize = true;
            this.lbClienteNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClienteNombre.Location = new System.Drawing.Point(18, 9);
            this.lbClienteNombre.Name = "lbClienteNombre";
            this.lbClienteNombre.Size = new System.Drawing.Size(56, 16);
            this.lbClienteNombre.TabIndex = 2;
            this.lbClienteNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(21, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClienteNombre.Location = new System.Drawing.Point(21, 28);
            this.txtClienteNombre.MaxLength = 200;
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(268, 21);
            this.txtClienteNombre.TabIndex = 0;
            this.txtClienteNombre.Tag = "";
            // 
            // panelTituloAgregarCliente
            // 
            this.panelTituloAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panelTituloAgregarCliente.Controls.Add(this.lbSearchTitle);
            this.panelTituloAgregarCliente.Location = new System.Drawing.Point(422, 109);
            this.panelTituloAgregarCliente.Name = "panelTituloAgregarCliente";
            this.panelTituloAgregarCliente.Size = new System.Drawing.Size(307, 24);
            this.panelTituloAgregarCliente.TabIndex = 15;
            // 
            // lbSearchTitle
            // 
            this.lbSearchTitle.AutoSize = true;
            this.lbSearchTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSearchTitle.Location = new System.Drawing.Point(80, 3);
            this.lbSearchTitle.Name = "lbSearchTitle";
            this.lbSearchTitle.Size = new System.Drawing.Size(153, 16);
            this.lbSearchTitle.TabIndex = 0;
            this.lbSearchTitle.Text = "Agregar Nuevo Cliente";
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClienteBuscar.Location = new System.Drawing.Point(38, 71);
            this.txtClienteBuscar.MaxLength = 200;
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(250, 21);
            this.txtClienteBuscar.TabIndex = 0;
            this.txtClienteBuscar.Tag = "";
            this.txtClienteBuscar.TextChanged += new System.EventHandler(this.txtClienteBuscar_TextChanged);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(762, 381);
            this.Controls.Add(this.txtClienteBuscar);
            this.Controls.Add(this.panelCamposAgregarCliente);
            this.Controls.Add(this.panelTituloAgregarCliente);
            this.Controls.Add(this.dvgClientes);
            this.Controls.Add(this.labelFrmClienteTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.panelCamposAgregarCliente.ResumeLayout(false);
            this.panelCamposAgregarCliente.PerformLayout();
            this.panelTituloAgregarCliente.ResumeLayout(false);
            this.panelTituloAgregarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrmClienteTitulo;
        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.Panel panelCamposAgregarCliente;
        private System.Windows.Forms.Label lbClienteEmpresa;
        private System.Windows.Forms.TextBox txtClienteEmpresa;
        private System.Windows.Forms.Label lbClienteApellido;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label lbClienteNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Panel panelTituloAgregarCliente;
        private System.Windows.Forms.Label lbSearchTitle;
        private System.Windows.Forms.TextBox txtClienteBuscar;
    }
}
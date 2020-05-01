namespace AppVenta.VISTA
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.lblNumVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTipDoc = new System.Windows.Forms.Label();
            this.lblBusProducto = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipDoc = new System.Windows.Forms.ComboBox();
            this.txtBusProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.lblNomProd = new System.Windows.Forms.Label();
            this.lblPrecProd = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtvVentas = new System.Windows.Forms.DataGridView();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIOPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDADPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.txtPrecProd = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarV = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumVenta
            // 
            this.lblNumVenta.AutoSize = true;
            this.lblNumVenta.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVenta.Location = new System.Drawing.Point(22, 28);
            this.lblNumVenta.Name = "lblNumVenta";
            this.lblNumVenta.Size = new System.Drawing.Size(112, 17);
            this.lblNumVenta.TabIndex = 0;
            this.lblNumVenta.Text = "Numero de Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(22, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 17);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipDoc
            // 
            this.lblTipDoc.AutoSize = true;
            this.lblTipDoc.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipDoc.Location = new System.Drawing.Point(343, 69);
            this.lblTipDoc.Name = "lblTipDoc";
            this.lblTipDoc.Size = new System.Drawing.Size(124, 17);
            this.lblTipDoc.TabIndex = 2;
            this.lblTipDoc.Text = "Tipo de Documento";
            // 
            // lblBusProducto
            // 
            this.lblBusProducto.AutoSize = true;
            this.lblBusProducto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusProducto.Location = new System.Drawing.Point(22, 119);
            this.lblBusProducto.Name = "lblBusProducto";
            this.lblBusProducto.Size = new System.Drawing.Size(103, 17);
            this.lblBusProducto.TabIndex = 3;
            this.lblBusProducto.Text = "Buscar Producto";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(48, 192);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(108, 17);
            this.lblCodProd.TabIndex = 4;
            this.lblCodProd.Text = "Codigo Producto";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumVenta.Enabled = false;
            this.txtNumVenta.Location = new System.Drawing.Point(140, 28);
            this.txtNumVenta.Multiline = true;
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(164, 20);
            this.txtNumVenta.TabIndex = 5;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(140, 65);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(164, 21);
            this.cmbCliente.TabIndex = 6;
            // 
            // cmbTipDoc
            // 
            this.cmbTipDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipDoc.FormattingEnabled = true;
            this.cmbTipDoc.Location = new System.Drawing.Point(473, 69);
            this.cmbTipDoc.Name = "cmbTipDoc";
            this.cmbTipDoc.Size = new System.Drawing.Size(156, 21);
            this.cmbTipDoc.TabIndex = 7;
            // 
            // txtBusProducto
            // 
            this.txtBusProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusProducto.Location = new System.Drawing.Point(140, 113);
            this.txtBusProducto.Multiline = true;
            this.txtBusProducto.Name = "txtBusProducto";
            this.txtBusProducto.Size = new System.Drawing.Size(387, 23);
            this.txtBusProducto.TabIndex = 8;
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.BackColor = System.Drawing.Color.Khaki;
            this.btnBuscarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarV.FlatAppearance.BorderSize = 0;
            this.btnBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarV.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarV.Location = new System.Drawing.Point(554, 113);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarV.TabIndex = 9;
            this.btnBuscarV.Text = "Buscar";
            this.btnBuscarV.UseVisualStyleBackColor = false;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // lblNomProd
            // 
            this.lblNomProd.AutoSize = true;
            this.lblNomProd.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProd.Location = new System.Drawing.Point(209, 193);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(114, 17);
            this.lblNomProd.TabIndex = 10;
            this.lblNomProd.Text = "Nombre Producto";
            // 
            // lblPrecProd
            // 
            this.lblPrecProd.AutoSize = true;
            this.lblPrecProd.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecProd.Location = new System.Drawing.Point(366, 193);
            this.lblPrecProd.Name = "lblPrecProd";
            this.lblPrecProd.Size = new System.Drawing.Size(101, 17);
            this.lblPrecProd.TabIndex = 11;
            this.lblPrecProd.Text = "Precio Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(528, 193);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 17);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(699, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 17);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(380, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 26);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtvVentas
            // 
            this.dtvVentas.AllowUserToAddRows = false;
            this.dtvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CÓDIGO,
            this.NOMBREPROD,
            this.PRECIOPROD,
            this.CANTIDADPROD,
            this.TOTAL});
            this.dtvVentas.Location = new System.Drawing.Point(29, 295);
            this.dtvVentas.Name = "dtvVentas";
            this.dtvVentas.ReadOnly = true;
            this.dtvVentas.Size = new System.Drawing.Size(785, 184);
            this.dtvVentas.TabIndex = 15;
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.HeaderText = "CÓDIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // NOMBREPROD
            // 
            this.NOMBREPROD.HeaderText = "NOMBRE PRODUCTO";
            this.NOMBREPROD.Name = "NOMBREPROD";
            this.NOMBREPROD.ReadOnly = true;
            // 
            // PRECIOPROD
            // 
            this.PRECIOPROD.HeaderText = "PRECIO PRODUCTO";
            this.PRECIOPROD.Name = "PRECIOPROD";
            this.PRECIOPROD.ReadOnly = true;
            // 
            // CANTIDADPROD
            // 
            this.CANTIDADPROD.HeaderText = "CANTIDAD";
            this.CANTIDADPROD.Name = "CANTIDADPROD";
            this.CANTIDADPROD.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // txtCodProd
            // 
            this.txtCodProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Location = new System.Drawing.Point(29, 213);
            this.txtCodProd.Multiline = true;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(137, 20);
            this.txtCodProd.TabIndex = 16;
            // 
            // txtNomProd
            // 
            this.txtNomProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomProd.Enabled = false;
            this.txtNomProd.Location = new System.Drawing.Point(196, 213);
            this.txtNomProd.Multiline = true;
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(139, 20);
            this.txtNomProd.TabIndex = 17;
            // 
            // txtPrecProd
            // 
            this.txtPrecProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecProd.Enabled = false;
            this.txtPrecProd.Location = new System.Drawing.Point(355, 213);
            this.txtPrecProd.Multiline = true;
            this.txtPrecProd.Name = "txtPrecProd";
            this.txtPrecProd.Size = new System.Drawing.Size(127, 20);
            this.txtPrecProd.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Location = new System.Drawing.Point(502, 213);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 20);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(656, 213);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.Location = new System.Drawing.Point(272, 547);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(104, 25);
            this.lblTotalFinal.TabIndex = 21;
            this.lblTotalFinal.Text = "TOTAL $:";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Enabled = false;
            this.txtTotalFinal.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFinal.Location = new System.Drawing.Point(382, 538);
            this.txtTotalFinal.Multiline = true;
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(100, 43);
            this.txtTotalFinal.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(656, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarV
            // 
            this.btnGuardarV.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardarV.FlatAppearance.BorderSize = 0;
            this.btnGuardarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarV.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarV.Location = new System.Drawing.Point(644, 504);
            this.btnGuardarV.Name = "btnGuardarV";
            this.btnGuardarV.Size = new System.Drawing.Size(75, 34);
            this.btnGuardarV.TabIndex = 24;
            this.btnGuardarV.Text = "Guardar Venta";
            this.btnGuardarV.UseVisualStyleBackColor = false;
            this.btnGuardarV.Click += new System.EventHandler(this.btnGuardarV_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(369, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(227, 22);
            this.dtpFecha.TabIndex = 25;
            this.dtpFecha.Value = new System.DateTime(2020, 4, 30, 17, 20, 32, 0);
            // 
            // FrmVentas
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 603);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardarV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.lblTotalFinal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecProd);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.dtvVentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecProd);
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.txtBusProducto);
            this.Controls.Add(this.cmbTipDoc);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtNumVenta);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.lblBusProducto);
            this.Controls.Add(this.lblTipDoc);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumVenta);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipDoc;
        private System.Windows.Forms.Label lblBusProducto;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipDoc;
        private System.Windows.Forms.TextBox txtBusProducto;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.Label lblNomProd;
        private System.Windows.Forms.Label lblPrecProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtvVentas;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCodProd;
        public System.Windows.Forms.TextBox txtNomProd;
        public System.Windows.Forms.TextBox txtPrecProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CÓDIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIOPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDADPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.TextBox txtTotalFinal;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardarV;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}
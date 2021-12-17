namespace Almacen1.Facturas
{
    partial class Frm_Facturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblParte = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.txtP_Unitario = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtParte = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_orden = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNoFactura);
            this.panel2.Controls.Add(this.cbProveedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 97);
            this.panel2.TabIndex = 2;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(142, 59);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNoFactura.TabIndex = 1;
            // 
            // cbProveedor
            // 
            this.cbProveedor.DisplayMember = "Aaa";
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(142, 21);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 0;
            this.cbProveedor.Tag = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_agregar);
            this.panel3.Controls.Add(this.cbx_marca);
            this.panel3.Controls.Add(this.lblPrecio);
            this.panel3.Controls.Add(this.lblCantidad);
            this.panel3.Controls.Add(this.lblParte);
            this.panel3.Controls.Add(this.lbModelo);
            this.panel3.Controls.Add(this.lblMarca);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.cbNombre);
            this.panel3.Controls.Add(this.txtP_Unitario);
            this.panel3.Controls.Add(this.txtModelo);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtParte);
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1238, 73);
            this.panel3.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(662, 28);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(74, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(568, 28);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblParte
            // 
            this.lblParte.AutoSize = true;
            this.lblParte.Location = new System.Drawing.Point(442, 28);
            this.lblParte.Name = "lblParte";
            this.lblParte.Size = new System.Drawing.Size(32, 13);
            this.lblParte.TabIndex = 13;
            this.lblParte.Text = "Parte";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(293, 29);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 12;
            this.lbModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 30);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(147, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // cbNombre
            // 
            this.cbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNombre.DisplayMember = "Aaa";
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            ""});
            this.cbNombre.Location = new System.Drawing.Point(147, 45);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(140, 21);
            this.cbNombre.TabIndex = 2;
            this.cbNombre.Tag = "";
            this.cbNombre.SelectedValueChanged += new System.EventHandler(this.cbNombre_SelectedValueChanged);
            // 
            // txtP_Unitario
            // 
            this.txtP_Unitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Unitario.Location = new System.Drawing.Point(662, 44);
            this.txtP_Unitario.Name = "txtP_Unitario";
            this.txtP_Unitario.Size = new System.Drawing.Size(96, 20);
            this.txtP_Unitario.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(293, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(140, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(568, 44);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtParte
            // 
            this.txtParte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParte.Location = new System.Drawing.Point(439, 44);
            this.txtParte.Name = "txtParte";
            this.txtParte.Size = new System.Drawing.Size(123, 20);
            this.txtParte.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.lblIVA);
            this.panel4.Controls.Add(this.lblSubtotal);
            this.panel4.Controls.Add(this.dgv_orden);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1061, 319);
            this.panel4.TabIndex = 13;
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(623, 241);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(21, 13);
            this.lblIVA.TabIndex = 19;
            this.lblIVA.Text = "iva";
            this.lblIVA.Click += new System.EventHandler(this.lblIVA_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(623, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(619, 217);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(44, 13);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "subtotal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackgroundImage = global::Almacen1.Properties.Resources.Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(12, 218);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(67, 62);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbx_marca
            // 
            this.cbx_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_marca.DisplayMember = "Aaa";
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Items.AddRange(new object[] {
            ""});
            this.cbx_marca.Location = new System.Drawing.Point(12, 45);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(129, 21);
            this.cbx_marca.TabIndex = 16;
            this.cbx_marca.Tag = "";
            this.cbx_marca.SelectedValueChanged += new System.EventHandler(this.cbx_marca_SelectedValueChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(764, 42);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(38, 23);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "+";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_orden
            // 
            this.dgv_orden.AllowUserToAddRows = false;
            this.dgv_orden.AllowUserToResizeRows = false;
            this.dgv_orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_orden.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_orden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_orden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.marca,
            this.modelo,
            this.parte,
            this.cantidad,
            this.precio_unitario,
            this.importe1});
            this.dgv_orden.EnableHeadersVisualStyles = false;
            this.dgv_orden.Location = new System.Drawing.Point(12, 96);
            this.dgv_orden.Name = "dgv_orden";
            this.dgv_orden.ReadOnly = true;
            this.dgv_orden.RowHeadersVisible = false;
            this.dgv_orden.Size = new System.Drawing.Size(790, 114);
            this.dgv_orden.TabIndex = 215;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 95;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 80;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 90;
            // 
            // parte
            // 
            this.parte.HeaderText = "Parte";
            this.parte.Name = "parte";
            this.parte.ReadOnly = true;
            this.parte.Width = 74;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 103;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "P.Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 107;
            // 
            // importe1
            // 
            this.importe1.HeaderText = "Importe";
            this.importe1.Name = "importe1";
            this.importe1.ReadOnly = true;
            this.importe1.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numero de orden:";
            // 
            // Frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 416);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Facturas";
            this.Text = "Frm_Facturas";
            this.Load += new System.EventHandler(this.Frm_Facturas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.TextBox txtP_Unitario;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtParte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblParte;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbx_marca;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn parte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
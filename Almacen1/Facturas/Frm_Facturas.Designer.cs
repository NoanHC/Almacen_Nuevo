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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lklblAgregar = new System.Windows.Forms.LinkLabel();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.txtP_Unitario = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtParte = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Parte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_P_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.txtNoFactura);
            this.panel2.Controls.Add(this.cbProveedor);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 120);
            this.panel2.TabIndex = 2;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(12, 71);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNoFactura.TabIndex = 1;
            // 
            // cbProveedor
            // 
            this.cbProveedor.DisplayMember = "Aaa";
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(12, 25);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 0;
            this.cbProveedor.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(572, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 104);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMarca);
            this.panel3.Controls.Add(this.lklblAgregar);
            this.panel3.Controls.Add(this.cbNombre);
            this.panel3.Controls.Add(this.txtP_Unitario);
            this.panel3.Controls.Add(this.txtModelo);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtParte);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 73);
            this.panel3.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(216, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(170, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lklblAgregar
            // 
            this.lklblAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklblAgregar.AutoSize = true;
            this.lklblAgregar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblAgregar.Location = new System.Drawing.Point(1114, 15);
            this.lklblAgregar.Name = "lklblAgregar";
            this.lklblAgregar.Size = new System.Drawing.Size(83, 23);
            this.lklblAgregar.TabIndex = 8;
            this.lklblAgregar.TabStop = true;
            this.lklblAgregar.Text = "Agregar";
            this.lklblAgregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblAgregar_LinkClicked);
            // 
            // cbNombre
            // 
            this.cbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNombre.DisplayMember = "Aaa";
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            ""});
            this.cbNombre.Location = new System.Drawing.Point(40, 20);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(170, 21);
            this.cbNombre.TabIndex = 2;
            this.cbNombre.Tag = "";
            // 
            // txtP_Unitario
            // 
            this.txtP_Unitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtP_Unitario.Location = new System.Drawing.Point(920, 20);
            this.txtP_Unitario.Name = "txtP_Unitario";
            this.txtP_Unitario.Size = new System.Drawing.Size(170, 20);
            this.txtP_Unitario.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(392, 20);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(170, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(744, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(170, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtParte
            // 
            this.txtParte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParte.Location = new System.Drawing.Point(568, 20);
            this.txtParte.Name = "txtParte";
            this.txtParte.Size = new System.Drawing.Size(170, 20);
            this.txtParte.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Nombre,
            this.C_Marca,
            this.C_Modelo,
            this.C_Parte,
            this.C_Cantidad,
            this.C_P_Unitario,
            this.C_Importe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 183);
            this.dataGridView1.TabIndex = 12;
            // 
            // C_Nombre
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.Name = "C_Nombre";
            // 
            // C_Marca
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Marca.DefaultCellStyle = dataGridViewCellStyle2;
            this.C_Marca.HeaderText = "Marca";
            this.C_Marca.Name = "C_Marca";
            // 
            // C_Modelo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Modelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_Modelo.HeaderText = "Modelo";
            this.C_Modelo.Name = "C_Modelo";
            // 
            // C_Parte
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Parte.DefaultCellStyle = dataGridViewCellStyle4;
            this.C_Parte.HeaderText = "Parte";
            this.C_Parte.Name = "C_Parte";
            // 
            // C_Cantidad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.C_Cantidad.HeaderText = "Cantidad";
            this.C_Cantidad.Name = "C_Cantidad";
            // 
            // C_P_Unitario
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_P_Unitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.C_P_Unitario.HeaderText = "P.Unitario";
            this.C_P_Unitario.Name = "C_P_Unitario";
            // 
            // C_Importe
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.C_Importe.DefaultCellStyle = dataGridViewCellStyle7;
            this.C_Importe.HeaderText = "Importe";
            this.C_Importe.Name = "C_Importe";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1235, 183);
            this.panel4.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackgroundImage = global::Almacen1.Properties.Resources.Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(12, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(67, 62);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIVA
            // 
            this.lblIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(1135, 408);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(0, 13);
            this.lblIVA.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1135, 434);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 18;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(1135, 382);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotal.TabIndex = 17;
            // 
            // Frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Facturas";
            this.Text = "Frm_Facturas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.LinkLabel lklblAgregar;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.TextBox txtP_Unitario;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtParte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Parte;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_P_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Importe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
    }
}
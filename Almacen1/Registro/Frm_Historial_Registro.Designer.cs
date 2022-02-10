namespace Almacen1.Registro
{
    partial class Frm_Historial_Registro
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
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.PanelFoto = new System.Windows.Forms.Panel();
            this.lblPuesto2 = new System.Windows.Forms.Label();
            this.lblMatricula2 = new System.Windows.Forms.Label();
            this.PanellblNombre = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.PanelDGV1 = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.PanelDGV2 = new System.Windows.Forms.Panel();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PanelInfo.SuspendLayout();
            this.PanellblNombre.SuspendLayout();
            this.PanelDGV1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.PanelDGV2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.lblPuesto);
            this.PanelInfo.Controls.Add(this.lblMatricula);
            this.PanelInfo.Controls.Add(this.PanelFoto);
            this.PanelInfo.Controls.Add(this.lblPuesto2);
            this.PanelInfo.Controls.Add(this.lblMatricula2);
            this.PanelInfo.Controls.Add(this.PanellblNombre);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(610, 99);
            this.PanelInfo.TabIndex = 0;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(78, 69);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(0, 22);
            this.lblPuesto.TabIndex = 5;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(89, 40);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(0, 22);
            this.lblMatricula.TabIndex = 4;
            // 
            // PanelFoto
            // 
            this.PanelFoto.BackgroundImage = global::Almacen1.Properties.Resources.Usuario;
            this.PanelFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelFoto.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFoto.Location = new System.Drawing.Point(485, 0);
            this.PanelFoto.Name = "PanelFoto";
            this.PanelFoto.Size = new System.Drawing.Size(125, 99);
            this.PanelFoto.TabIndex = 3;
            // 
            // lblPuesto2
            // 
            this.lblPuesto2.AutoSize = true;
            this.lblPuesto2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto2.Location = new System.Drawing.Point(12, 68);
            this.lblPuesto2.Name = "lblPuesto2";
            this.lblPuesto2.Size = new System.Drawing.Size(66, 23);
            this.lblPuesto2.TabIndex = 2;
            this.lblPuesto2.Text = "Puesto: ";
            // 
            // lblMatricula2
            // 
            this.lblMatricula2.AutoSize = true;
            this.lblMatricula2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula2.Location = new System.Drawing.Point(12, 39);
            this.lblMatricula2.Name = "lblMatricula2";
            this.lblMatricula2.Size = new System.Drawing.Size(80, 23);
            this.lblMatricula2.TabIndex = 0;
            this.lblMatricula2.Text = "Matricula: ";
            // 
            // PanellblNombre
            // 
            this.PanellblNombre.BackColor = System.Drawing.Color.Teal;
            this.PanellblNombre.Controls.Add(this.lblNombre);
            this.PanellblNombre.Controls.Add(this.lblNombre2);
            this.PanellblNombre.Location = new System.Drawing.Point(12, 7);
            this.PanellblNombre.Name = "PanellblNombre";
            this.PanellblNombre.Size = new System.Drawing.Size(166, 29);
            this.PanellblNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(74, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 22);
            this.lblNombre.TabIndex = 6;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre2.Location = new System.Drawing.Point(3, 3);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(74, 23);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre: ";
            // 
            // PanelDGV1
            // 
            this.PanelDGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV1.Controls.Add(this.DGV1);
            this.PanelDGV1.Controls.Add(this.lblPrestamos);
            this.PanelDGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelDGV1.Location = new System.Drawing.Point(0, 99);
            this.PanelDGV1.Name = "PanelDGV1";
            this.PanelDGV1.Size = new System.Drawing.Size(610, 211);
            this.PanelDGV1.TabIndex = 1;
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.Location = new System.Drawing.Point(0, 29);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(610, 182);
            this.DGV1.TabIndex = 216;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(12, 4);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(110, 22);
            this.lblPrestamos.TabIndex = 7;
            this.lblPrestamos.Text = "Prestamos";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(12, 4);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(86, 22);
            this.lblPedidos.TabIndex = 4;
            this.lblPedidos.Text = "Pedidos";
            // 
            // PanelDGV2
            // 
            this.PanelDGV2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV2.Controls.Add(this.DGV2);
            this.PanelDGV2.Controls.Add(this.lblPedidos);
            this.PanelDGV2.Location = new System.Drawing.Point(0, 310);
            this.PanelDGV2.Name = "PanelDGV2";
            this.PanelDGV2.Size = new System.Drawing.Size(610, 196);
            this.PanelDGV2.TabIndex = 5;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV2.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV2.EnableHeadersVisualStyles = false;
            this.DGV2.Location = new System.Drawing.Point(0, 29);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.Size = new System.Drawing.Size(610, 167);
            this.DGV2.TabIndex = 215;
            this.DGV2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellDoubleClick);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::Almacen1.Properties.Resources.Borrar;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Width = 64;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(9, 522);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 60);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(485, 519);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 60);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Frm_Historial_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 591);
            this.Controls.Add(this.PanelDGV2);
            this.Controls.Add(this.PanelDGV1);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Historial_Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Historial_Registro_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Historial_Registro_Load);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.PanellblNombre.ResumeLayout(false);
            this.PanellblNombre.PerformLayout();
            this.PanelDGV1.ResumeLayout(false);
            this.PanelDGV1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.PanelDGV2.ResumeLayout(false);
            this.PanelDGV2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Panel PanelFoto;
        private System.Windows.Forms.Label lblPuesto2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblMatricula2;
        private System.Windows.Forms.Panel PanelDGV1;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Panel PanelDGV2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel PanellblNombre;
    }
}
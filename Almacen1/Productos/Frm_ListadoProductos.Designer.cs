
namespace Almacen1.Productos
{
    partial class Frm_ListadoProductos
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
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.PanelDGV1 = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelSuperior.SuspendLayout();
            this.PanelDGV1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.AllowDrop = true;
            this.PanelSuperior.AutoSize = true;
            this.PanelSuperior.Controls.Add(this.txtBuscar);
            this.PanelSuperior.Controls.Add(this.btnAgregar);
            this.PanelSuperior.Controls.Add(this.lblBusqueda);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(800, 63);
            this.PanelSuperior.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(203, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(348, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 48);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(142, 30);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(55, 13);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Busqueda";
            // 
            // PanelDGV1
            // 
            this.PanelDGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV1.AutoSize = true;
            this.PanelDGV1.Controls.Add(this.DGV1);
            this.PanelDGV1.Location = new System.Drawing.Point(-1, 66);
            this.PanelDGV1.Name = "PanelDGV1";
            this.PanelDGV1.Size = new System.Drawing.Size(803, 351);
            this.PanelDGV1.TabIndex = 6;
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Borrar});
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(803, 351);
            this.DGV1.TabIndex = 3;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::Almacen1.Properties.Resources.Editar345;
            this.Editar.Name = "Editar";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "";
            this.Borrar.Image = global::Almacen1.Properties.Resources.Borrar;
            this.Borrar.Name = "Borrar";
            // 
            // Frm_ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDGV1);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoProductos";
            this.Text = "Frm_ListadoProductos";
            this.Load += new System.EventHandler(this.Frm_ListadoProductos_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelDGV1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Panel PanelDGV1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
    }
}
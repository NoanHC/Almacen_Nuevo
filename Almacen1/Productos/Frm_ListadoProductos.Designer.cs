
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
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.pnlDGVProductos = new System.Windows.Forms.Panel();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.pnlDGVProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Borrar});
            this.DGVProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProductos.Location = new System.Drawing.Point(0, 0);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(784, 392);
            this.DGVProductos.TabIndex = 0;
            // 
            // pnlDGVProductos
            // 
            this.pnlDGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGVProductos.Controls.Add(this.DGVProductos);
            this.pnlDGVProductos.Location = new System.Drawing.Point(4, 46);
            this.pnlDGVProductos.Name = "pnlDGVProductos";
            this.pnlDGVProductos.Size = new System.Drawing.Size(784, 392);
            this.pnlDGVProductos.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "";
            this.Borrar.Name = "Borrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDGVProductos);
            this.Name = "Frm_ListadoProductos";
            this.Text = "Frm_ListadoProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.pnlDGVProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Panel pnlDGVProductos;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.Button button1;
    }
}
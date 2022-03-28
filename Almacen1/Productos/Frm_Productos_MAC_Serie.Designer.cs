namespace Almacen1.Productos
{
    partial class Frm_Productos_MAC_Serie
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
            this.PanelDGV = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.PicMedio = new System.Windows.Forms.PictureBox();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.lblOrden2 = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.rtxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblParte2 = new System.Windows.Forms.Label();
            this.lblParte = new System.Windows.Forms.Label();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.lblModelo2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.PanellblNombre = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMAC = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedio)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.PanellblNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDGV
            // 
            this.PanelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV.Controls.Add(this.DGV1);
            this.PanelDGV.Location = new System.Drawing.Point(150, 220);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Size = new System.Drawing.Size(560, 220);
            this.PanelDGV.TabIndex = 1;
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
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
            this.DGV1.Size = new System.Drawing.Size(560, 220);
            this.DGV1.TabIndex = 216;
            this.DGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellClick);
            this.DGV1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellValueChanged);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Almacen1.Properties.Resources.editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 60;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(728, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 40);
            this.btnGuardar.TabIndex = 227;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.ForestGreen;
            this.PanelSuperior.Controls.Add(this.lbl_minimize);
            this.PanelSuperior.Controls.Add(this.PicMedio);
            this.PanelSuperior.Controls.Add(this.lbl_cerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(860, 30);
            this.PanelSuperior.TabIndex = 219;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown_1);
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimize.ForeColor = System.Drawing.Color.White;
            this.lbl_minimize.Location = new System.Drawing.Point(774, -5);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(21, 24);
            this.lbl_minimize.TabIndex = 219;
            this.lbl_minimize.Text = "_";
            this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
            // 
            // PicMedio
            // 
            this.PicMedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMedio.BackColor = System.Drawing.Color.Transparent;
            this.PicMedio.BackgroundImage = global::Almacen1.Properties.Resources.Minimizar;
            this.PicMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicMedio.Location = new System.Drawing.Point(801, 3);
            this.PicMedio.Name = "PicMedio";
            this.PicMedio.Size = new System.Drawing.Size(21, 24);
            this.PicMedio.TabIndex = 220;
            this.PicMedio.TabStop = false;
            this.PicMedio.Click += new System.EventHandler(this.PicMedio_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cerrar.Location = new System.Drawing.Point(832, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(25, 24);
            this.lbl_cerrar.TabIndex = 219;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.White;
            this.PanelInfo.Controls.Add(this.lblOrden2);
            this.PanelInfo.Controls.Add(this.lblOrden);
            this.PanelInfo.Controls.Add(this.rtxDescripcion);
            this.PanelInfo.Controls.Add(this.lblParte2);
            this.PanelInfo.Controls.Add(this.lblParte);
            this.PanelInfo.Controls.Add(this.lblMarca2);
            this.PanelInfo.Controls.Add(this.lblModelo2);
            this.PanelInfo.Controls.Add(this.lblModelo);
            this.PanelInfo.Controls.Add(this.lblMarca);
            this.PanelInfo.Controls.Add(this.PanellblNombre);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfo.Location = new System.Drawing.Point(0, 30);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(860, 183);
            this.PanelInfo.TabIndex = 220;
            // 
            // lblOrden2
            // 
            this.lblOrden2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrden2.AutoSize = true;
            this.lblOrden2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden2.Location = new System.Drawing.Point(500, 130);
            this.lblOrden2.Name = "lblOrden2";
            this.lblOrden2.Size = new System.Drawing.Size(28, 23);
            this.lblOrden2.TabIndex = 225;
            this.lblOrden2.Text = "aa";
            // 
            // lblOrden
            // 
            this.lblOrden.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(450, 130);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(58, 23);
            this.lblOrden.TabIndex = 224;
            this.lblOrden.Text = "Orden:";
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtxDescripcion.Location = new System.Drawing.Point(550, 10);
            this.rtxDescripcion.Name = "rtxDescripcion";
            this.rtxDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxDescripcion.ShortcutsEnabled = false;
            this.rtxDescripcion.Size = new System.Drawing.Size(300, 154);
            this.rtxDescripcion.TabIndex = 80;
            this.rtxDescripcion.Text = "";
            this.rtxDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxDescripcion_KeyDown);
            this.rtxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxDescripcion_KeyPress);
            // 
            // lblParte2
            // 
            this.lblParte2.AutoSize = true;
            this.lblParte2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte2.Location = new System.Drawing.Point(90, 130);
            this.lblParte2.Name = "lblParte2";
            this.lblParte2.Size = new System.Drawing.Size(62, 25);
            this.lblParte2.TabIndex = 9;
            this.lblParte2.Text = "aaaaa";
            // 
            // lblParte
            // 
            this.lblParte.AutoSize = true;
            this.lblParte.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte.Location = new System.Drawing.Point(10, 130);
            this.lblParte.Name = "lblParte";
            this.lblParte.Size = new System.Drawing.Size(64, 25);
            this.lblParte.TabIndex = 8;
            this.lblParte.Text = "Parte: ";
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca2.Location = new System.Drawing.Point(90, 60);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(38, 31);
            this.lblMarca2.TabIndex = 5;
            this.lblMarca2.Text = "aa";
            // 
            // lblModelo2
            // 
            this.lblModelo2.AutoSize = true;
            this.lblModelo2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo2.Location = new System.Drawing.Point(90, 96);
            this.lblModelo2.Name = "lblModelo2";
            this.lblModelo2.Size = new System.Drawing.Size(68, 29);
            this.lblModelo2.TabIndex = 4;
            this.lblModelo2.Text = "aaaaa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(10, 96);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(88, 29);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(10, 60);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(86, 31);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca: ";
            // 
            // PanellblNombre
            // 
            this.PanellblNombre.BackColor = System.Drawing.Color.Teal;
            this.PanellblNombre.Controls.Add(this.lblNombre);
            this.PanellblNombre.Location = new System.Drawing.Point(10, 10);
            this.PanellblNombre.Name = "PanellblNombre";
            this.PanellblNombre.Size = new System.Drawing.Size(110, 40);
            this.PanellblNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Underline);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 37);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "aaaaaj";
            // 
            // btnMAC
            // 
            this.btnMAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMAC.BackColor = System.Drawing.Color.Green;
            this.btnMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAC.ForeColor = System.Drawing.Color.White;
            this.btnMAC.Location = new System.Drawing.Point(728, 220);
            this.btnMAC.Name = "btnMAC";
            this.btnMAC.Size = new System.Drawing.Size(122, 40);
            this.btnMAC.TabIndex = 225;
            this.btnMAC.Text = "MAC´s";
            this.btnMAC.UseVisualStyleBackColor = false;
            this.btnMAC.Click += new System.EventHandler(this.btnMAC_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.Green;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.ForeColor = System.Drawing.Color.White;
            this.btnSeries.Location = new System.Drawing.Point(10, 220);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(122, 40);
            this.btnSeries.TabIndex = 226;
            this.btnSeries.Text = "Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Almacen1.Properties.Resources.editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Frm_Productos_MAC_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnMAC);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelDGV);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos_MAC_Serie";
            this.Load += new System.EventHandler(this.Frm_Productos_MAC_Serie_Load);
            this.PanelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMedio)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.PanellblNombre.ResumeLayout(false);
            this.PanellblNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.PictureBox PicMedio;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Label lblModelo2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Panel PanellblNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblParte;
        private System.Windows.Forms.Label lblParte2;
        private System.Windows.Forms.RichTextBox rtxDescripcion;
        private System.Windows.Forms.Label lblOrden2;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnMAC;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnGuardar;
    }
}
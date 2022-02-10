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
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnAgregarSerie = new System.Windows.Forms.Button();
            this.btnAgregarMAC = new System.Windows.Forms.Button();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.PanelSerie = new System.Windows.Forms.Panel();
            this.PanelMAC = new System.Windows.Forms.Panel();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.PanelDGV.SuspendLayout();
            this.PanelSerie.SuspendLayout();
            this.PanelMAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDGV
            // 
            this.PanelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV.Controls.Add(this.DGV1);
            this.PanelDGV.Location = new System.Drawing.Point(183, 0);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Size = new System.Drawing.Size(617, 450);
            this.PanelDGV.TabIndex = 1;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(76, 19);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 22);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(50, 44);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 3;
            // 
            // btnAgregarSerie
            // 
            this.btnAgregarSerie.FlatAppearance.BorderSize = 0;
            this.btnAgregarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSerie.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAgregarSerie.Location = new System.Drawing.Point(33, 70);
            this.btnAgregarSerie.Name = "btnAgregarSerie";
            this.btnAgregarSerie.Size = new System.Drawing.Size(135, 36);
            this.btnAgregarSerie.TabIndex = 4;
            this.btnAgregarSerie.Text = "Agregar Serie";
            this.btnAgregarSerie.UseVisualStyleBackColor = true;
            this.btnAgregarSerie.Click += new System.EventHandler(this.btnAgregarSerie_Click);
            // 
            // btnAgregarMAC
            // 
            this.btnAgregarMAC.FlatAppearance.BorderSize = 0;
            this.btnAgregarMAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMAC.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAgregarMAC.Location = new System.Drawing.Point(33, 57);
            this.btnAgregarMAC.Name = "btnAgregarMAC";
            this.btnAgregarMAC.Size = new System.Drawing.Size(135, 36);
            this.btnAgregarMAC.TabIndex = 7;
            this.btnAgregarMAC.Text = "Agregar MAC";
            this.btnAgregarMAC.UseVisualStyleBackColor = true;
            this.btnAgregarMAC.Click += new System.EventHandler(this.btnAgregarMAC_Click);
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(50, 31);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(100, 20);
            this.txtMAC.TabIndex = 6;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(76, 6);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(53, 22);
            this.lblMAC.TabIndex = 5;
            this.lblMAC.Text = "MAC";
            // 
            // PanelSerie
            // 
            this.PanelSerie.Controls.Add(this.txtSerie);
            this.PanelSerie.Controls.Add(this.lblSerie);
            this.PanelSerie.Controls.Add(this.btnAgregarSerie);
            this.PanelSerie.Location = new System.Drawing.Point(0, 0);
            this.PanelSerie.Name = "PanelSerie";
            this.PanelSerie.Size = new System.Drawing.Size(180, 123);
            this.PanelSerie.TabIndex = 8;
            // 
            // PanelMAC
            // 
            this.PanelMAC.Controls.Add(this.lblMAC);
            this.PanelMAC.Controls.Add(this.txtMAC);
            this.PanelMAC.Controls.Add(this.btnAgregarMAC);
            this.PanelMAC.Location = new System.Drawing.Point(0, 130);
            this.PanelMAC.Name = "PanelMAC";
            this.PanelMAC.Size = new System.Drawing.Size(180, 104);
            this.PanelMAC.TabIndex = 9;
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.BackgroundColor = System.Drawing.Color.Silver;
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
            this.DGV1.Size = new System.Drawing.Size(617, 450);
            this.DGV1.TabIndex = 216;
            this.DGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellClick);
            // 
            // Frm_Productos_MAC_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMAC);
            this.Controls.Add(this.PanelSerie);
            this.Controls.Add(this.PanelDGV);
            this.Name = "Frm_Productos_MAC_Serie";
            this.Load += new System.EventHandler(this.Frm_Productos_MAC_Serie_Load);
            this.PanelDGV.ResumeLayout(false);
            this.PanelSerie.ResumeLayout(false);
            this.PanelSerie.PerformLayout();
            this.PanelMAC.ResumeLayout(false);
            this.PanelMAC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnAgregarSerie;
        private System.Windows.Forms.Button btnAgregarMAC;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Panel PanelSerie;
        private System.Windows.Forms.Panel PanelMAC;
        private System.Windows.Forms.DataGridView DGV1;
    }
}
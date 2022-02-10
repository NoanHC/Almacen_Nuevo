namespace Almacen1.Productos
{
    partial class Frm_Agregar_Serie
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
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.ForestGreen;
            this.PanelSuperior.Controls.Add(this.lbl_minimize);
            this.PanelSuperior.Controls.Add(this.lbl_cerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(582, 30);
            this.PanelSuperior.TabIndex = 219;
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimize.ForeColor = System.Drawing.Color.White;
            this.lbl_minimize.Location = new System.Drawing.Point(527, 3);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(21, 24);
            this.lbl_minimize.TabIndex = 219;
            this.lbl_minimize.Text = "_";
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cerrar.Location = new System.Drawing.Point(554, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(25, 24);
            this.lbl_cerrar.TabIndex = 219;
            this.lbl_cerrar.Text = "X";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 2);
            this.label3.TabIndex = 222;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(56, 101);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(452, 29);
            this.txtNombre.TabIndex = 220;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(211, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 23);
            this.lblNombre.TabIndex = 221;
            this.lblNombre.Text = "Agregar Serie:";
            // 
            // Frm_Agregar_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Agregar_Serie";
            this.Text = "Frm_Agregar_Serie";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}
namespace Almacen1.Productos
{
    partial class Frm_Modificar_SerieYMAC
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.lblBarra2 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Green;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(190, 119);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 44);
            this.btnModificar.TabIndex = 230;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBarra1
            // 
            this.lblBarra1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra1.Location = new System.Drawing.Point(65, 57);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(450, 2);
            this.lblBarra1.TabIndex = 229;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(64, 37);
            this.txtSerie.MaxLength = 50;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(450, 22);
            this.txtSerie.TabIndex = 227;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSerie.Location = new System.Drawing.Point(12, 36);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 23);
            this.lblSerie.TabIndex = 228;
            this.lblSerie.Text = "Serie:";
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.ForestGreen;
            this.PanelSuperior.Controls.Add(this.lbl_minimize);
            this.PanelSuperior.Controls.Add(this.lbl_cerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(530, 30);
            this.PanelSuperior.TabIndex = 226;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_minimize.ForeColor = System.Drawing.Color.White;
            this.lbl_minimize.Location = new System.Drawing.Point(475, 3);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(21, 24);
            this.lbl_minimize.TabIndex = 219;
            this.lbl_minimize.Text = "_";
            this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_cerrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cerrar.Location = new System.Drawing.Point(502, 3);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(25, 24);
            this.lbl_cerrar.TabIndex = 219;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // lblBarra2
            // 
            this.lblBarra2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra2.Location = new System.Drawing.Point(65, 98);
            this.lblBarra2.Name = "lblBarra2";
            this.lblBarra2.Size = new System.Drawing.Size(450, 2);
            this.lblBarra2.TabIndex = 234;
            // 
            // txtMAC
            // 
            this.txtMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(64, 78);
            this.txtMAC.MaxLength = 50;
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(450, 22);
            this.txtMAC.TabIndex = 232;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.lblMAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMAC.Location = new System.Drawing.Point(12, 77);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(48, 23);
            this.lblMAC.TabIndex = 233;
            this.lblMAC.Text = "MAC:";
            // 
            // Frm_Modificar_SerieYMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 175);
            this.Controls.Add(this.lblBarra2);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBarra1);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.PanelSuperior);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Modificar_SerieYMAC";
            this.Text = "Frm_Modificar_SerieYMAC";
            this.Load += new System.EventHandler(this.Frm_Modificar_SerieYMAC_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Label lblBarra2;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblMAC;
    }
}
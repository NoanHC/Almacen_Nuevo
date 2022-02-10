namespace Almacen1
{
    partial class Frm_Notas
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
            this.rtbNotas = new System.Windows.Forms.RichTextBox();
            this.llblGuardar = new System.Windows.Forms.LinkLabel();
            this.llblNoInformar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // rtbNotas
            // 
            this.rtbNotas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotas.Location = new System.Drawing.Point(12, 12);
            this.rtbNotas.Name = "rtbNotas";
            this.rtbNotas.Size = new System.Drawing.Size(487, 295);
            this.rtbNotas.TabIndex = 0;
            this.rtbNotas.Text = "";
            // 
            // llblGuardar
            // 
            this.llblGuardar.AutoSize = true;
            this.llblGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGuardar.LinkColor = System.Drawing.SystemColors.Desktop;
            this.llblGuardar.Location = new System.Drawing.Point(37, 333);
            this.llblGuardar.Name = "llblGuardar";
            this.llblGuardar.Size = new System.Drawing.Size(161, 22);
            this.llblGuardar.TabIndex = 1;
            this.llblGuardar.TabStop = true;
            this.llblGuardar.Text = "Aceptar e informar";
            this.llblGuardar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGuardar_LinkClicked);
            // 
            // llblNoInformar
            // 
            this.llblNoInformar.AutoSize = true;
            this.llblNoInformar.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNoInformar.LinkColor = System.Drawing.SystemColors.Desktop;
            this.llblNoInformar.Location = new System.Drawing.Point(359, 333);
            this.llblNoInformar.Name = "llblNoInformar";
            this.llblNoInformar.Size = new System.Drawing.Size(109, 22);
            this.llblNoInformar.TabIndex = 2;
            this.llblNoInformar.TabStop = true;
            this.llblNoInformar.Text = "No informar";
            this.llblNoInformar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNoInformar_LinkClicked);
            // 
            // Frm_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 382);
            this.Controls.Add(this.llblNoInformar);
            this.Controls.Add(this.llblGuardar);
            this.Controls.Add(this.rtbNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNotas;
        private System.Windows.Forms.LinkLabel llblGuardar;
        private System.Windows.Forms.LinkLabel llblNoInformar;
    }
}
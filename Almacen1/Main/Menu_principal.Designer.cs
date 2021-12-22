
namespace Almacen1.Main
{
    partial class Menu_principal
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_entradas = new System.Windows.Forms.Button();
            this.tbn_salidas = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_orden = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_forms = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pB_mobile = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_mobile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_menu.Controls.Add(this.btn_entradas);
            this.pnl_menu.Controls.Add(this.tbn_salidas);
            this.pnl_menu.Controls.Add(this.btn_usuarios);
            this.pnl_menu.Controls.Add(this.label5);
            this.pnl_menu.Controls.Add(this.btn_empleados);
            this.pnl_menu.Controls.Add(this.btn_orden);
            this.pnl_menu.Controls.Add(this.btn_productos);
            this.pnl_menu.Controls.Add(this.label10);
            this.pnl_menu.Controls.Add(this.label3);
            this.pnl_menu.Controls.Add(this.label4);
            this.pnl_menu.Controls.Add(this.label2);
            this.pnl_menu.Controls.Add(this.label8);
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(240, 626);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // btn_entradas
            // 
            this.btn_entradas.FlatAppearance.BorderSize = 0;
            this.btn_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entradas.ForeColor = System.Drawing.Color.White;
            this.btn_entradas.Image = global::Almacen1.Properties.Resources.inventario;
            this.btn_entradas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_entradas.Location = new System.Drawing.Point(10, 214);
            this.btn_entradas.Name = "btn_entradas";
            this.btn_entradas.Size = new System.Drawing.Size(221, 43);
            this.btn_entradas.TabIndex = 41;
            this.btn_entradas.Text = "Devoluciones";
            this.btn_entradas.UseVisualStyleBackColor = true;
            this.btn_entradas.Click += new System.EventHandler(this.btn_entradas_Click);
            // 
            // tbn_salidas
            // 
            this.tbn_salidas.FlatAppearance.BorderSize = 0;
            this.tbn_salidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_salidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_salidas.ForeColor = System.Drawing.Color.White;
            this.tbn_salidas.Image = global::Almacen1.Properties.Resources.descripcion_del_producto;
            this.tbn_salidas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tbn_salidas.Location = new System.Drawing.Point(10, 152);
            this.tbn_salidas.Name = "tbn_salidas";
            this.tbn_salidas.Size = new System.Drawing.Size(221, 43);
            this.tbn_salidas.TabIndex = 40;
            this.tbn_salidas.Text = "Entregas";
            this.tbn_salidas.UseVisualStyleBackColor = true;
            this.tbn_salidas.Click += new System.EventHandler(this.tbn_salidas_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.Image = global::Almacen1.Properties.Resources.programador;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(10, 421);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(221, 43);
            this.btn_usuarios.TabIndex = 39;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(4, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 2);
            this.label5.TabIndex = 38;
            // 
            // btn_empleados
            // 
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.White;
            this.btn_empleados.Image = global::Almacen1.Properties.Resources.empleado_del_mes;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_empleados.Location = new System.Drawing.Point(10, 492);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(221, 43);
            this.btn_empleados.TabIndex = 37;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_orden
            // 
            this.btn_orden.FlatAppearance.BorderSize = 0;
            this.btn_orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orden.ForeColor = System.Drawing.Color.White;
            this.btn_orden.Image = global::Almacen1.Properties.Resources.factura;
            this.btn_orden.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_orden.Location = new System.Drawing.Point(10, 349);
            this.btn_orden.Name = "btn_orden";
            this.btn_orden.Size = new System.Drawing.Size(221, 43);
            this.btn_orden.TabIndex = 34;
            this.btn_orden.Text = "     Orden de compra";
            this.btn_orden.UseVisualStyleBackColor = true;
            this.btn_orden.Click += new System.EventHandler(this.btn_orden_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::Almacen1.Properties.Resources.caja__1_;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_productos.Location = new System.Drawing.Point(10, 280);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(221, 43);
            this.btn_productos.TabIndex = 33;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(4, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 2);
            this.label10.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(4, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 2);
            this.label3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(4, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 2);
            this.label4.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(4, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 2);
            this.label2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(4, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 2);
            this.label8.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Almacen1.Properties.Resources.wislogo;
            this.pictureBox1.Location = new System.Drawing.Point(28, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_forms);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 626);
            this.panel2.TabIndex = 1;
            // 
            // panel_forms
            // 
            this.panel_forms.BackColor = System.Drawing.Color.White;
            this.panel_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_forms.Location = new System.Drawing.Point(0, 74);
            this.panel_forms.Name = "panel_forms";
            this.panel_forms.Size = new System.Drawing.Size(646, 552);
            this.panel_forms.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pB_mobile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 74);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Almacen WIS";
            // 
            // pB_mobile
            // 
            this.pB_mobile.Image = global::Almacen1.Properties.Resources.mobile;
            this.pB_mobile.Location = new System.Drawing.Point(6, 12);
            this.pB_mobile.Name = "pB_mobile";
            this.pB_mobile.Size = new System.Drawing.Size(54, 51);
            this.pB_mobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_mobile.TabIndex = 0;
            this.pB_mobile.TabStop = false;
            this.pB_mobile.Click += new System.EventHandler(this.pB_mobile_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_menu);
            this.Name = "Menu_principal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_principal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_mobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_forms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pB_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_orden;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_entradas;
        private System.Windows.Forms.Button tbn_salidas;
    }
}
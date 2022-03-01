﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Almacen1.Main
{
    public partial class Menu_principal : Form
    {
        //Class
        Class.ClsUtilidades util = new Class.ClsUtilidades();

        //Datatables
        //Variables
        public Menu_principal()
        {
            InitializeComponent();
        }

        public void LimpiarPanel()
        {
            this.panel_forms.Controls.Clear();
        }
        void add_panel(Form fh)
        {
            this.panel_forms.Controls.Clear();
            if (this.panel_forms.Controls.Count > 0)
                this.panel_forms.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Invoke(new Action(() => this.panel_forms.Controls.Add(fh)));
            this.panel_forms.Tag = fh;
            this.Invoke(new Action(() => fh.Show()));
        }

        void load()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            load();
        }

        private void pB_mobile_Click(object sender, EventArgs e)
        {
            if (pnl_menu.Visible == true)
            {
                pnl_menu.Visible = false;
            }
            else
            {
                pnl_menu.Visible = true;
            }
        }

        private void Menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.close();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            Empleados.Frm_Empleados fh = new Empleados.Frm_Empleados();
            add_panel(fh);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            Usuarios.FrmListadoUsuarios fh = new Usuarios.FrmListadoUsuarios();
            add_panel(fh);
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
        void Productos()
        {
            LimpiarPanel();
            Productos.Frm_ListadoProductos fh = new Productos.Frm_ListadoProductos();
            add_panel(fh);
        }
        private void btn_productos_Click(object sender, EventArgs e)
        {
            Thread HiloProductos = new Thread(Productos);
            HiloProductos.Start();
        }

        private void tbn_salidas_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            Salidas.FrmAltaSalidas fh = new Salidas.FrmAltaSalidas();
            add_panel(fh);
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            Entradas.FrmAltaEntradas fh = new Entradas.FrmAltaEntradas();
            add_panel(fh);
        }

        private void btn_orden_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            OrdenCompra.FrmAltaOrdenes fh = new OrdenCompra.FrmAltaOrdenes();
            add_panel(fh);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            Registro.Frm_Escanear_Producto fh = new Registro.Frm_Escanear_Producto();
            add_panel(fh);
        }
    }
}

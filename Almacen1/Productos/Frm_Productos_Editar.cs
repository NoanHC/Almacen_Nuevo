﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_Productos_Editar : Form
    {
        // Delegados
        public Action DelegadoActualizar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();
        Class.ClsUtilidades Utilidades = new Class.ClsUtilidades();

        // datatable
        DataTable dt = new DataTable();
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();
        DataTable dtS = new DataTable();

        // Variables
        int Id;

        public Frm_Productos_Editar(int Id, DataTable dt)
        {
            InitializeComponent();
            this.Id = Id;
            this.dt = dt;
        }

        void Listas(DataTable dt, ComboBox cb, int Caso)
        {
            cb.Items.Clear();
            dt.Clear();
            switch (Caso)
            {
                case 0:
                    ObjProductos._consult_Marca(dt);
                    break;
                case 1:
                    ObjProductos._consult_Factura(dt);
                    break;
                case 2:
                    ObjProductos._consult_Status(dt);
                    break;
                default:
                    break;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void CargarNombre ()
        {
            lblNombre.Text = dt.Rows[Id][1].ToString();
            lblNombre.Left = (panel1.Width / 2) - (lblNombre.Width / 2);
            if (lblNombre.Width > panel1.Width)
            {
                lblNombre.Font = new Font("Arial Narrow ", lblNombre.Font.Size - 1, FontStyle.Underline);
                CargarNombre();
            }
        }
        void Carga()
        {
            lblId.Text = dt.Rows[Id][0].ToString();
            CargarNombre();
            lblId.Left = lblNombre.Width - lblId.Width + lblNombre.Left;
            lblId.Top = lblNombre.Height + lblNombre.Top;
            cbMarca.Text = dt.Rows[Id][2].ToString();
            Listas(dtM, cbMarca, 0);
            //Utilidades.CentrarComboBox(cbMarca);
            txtModelo.Text = dt.Rows[Id][3].ToString();
            txtParte.Text = dt.Rows[Id][4].ToString();
            txtDescripcion.Text = dt.Rows[Id][5].ToString();
        }
        private void Frm_Productos_Editar_Load(object sender, EventArgs e)
        {
            Carga();
        }

        string Ids(DataTable dtIds, ComboBox cbIds)
        {
            string ids = "";
            string CbText = Utilidades.QuitarEspacios(cbIds.Text);
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (CbText == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            ObjProductos._update(lblNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, txtDescripcion.Text, lblId.Text);
            DelegadoActualizar();
            this.Close();
        }

        private void cbMarca_Leave(object sender, EventArgs e)
        {
            //Utilidades.CentrarComboBox(cbMarca);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
        void Carga()
        {
            txtId.Text = dt.Rows[Id][0].ToString();
            txtNombre.Text = dt.Rows[Id][1].ToString();
            cbMarca.Text = dt.Rows[Id][2].ToString();
            Listas(dtM, cbMarca, 0);
            txtModelo.Text = dt.Rows[Id][3].ToString();
            txtParte.Text = dt.Rows[Id][4].ToString();
            cbFactura.Text = dt.Rows[Id][7].ToString();
            Listas(dtF, cbFactura, 1);
            txtDescripcion.Text = dt.Rows[Id][8].ToString();
            txtCantidad.Text = dt.Rows[Id][9].ToString();
            cbEstatus.Text = dt.Rows[Id][10].ToString();
            Listas(dtS, cbEstatus, 2);
        }
        private void Frm_Productos_Editar_Load(object sender, EventArgs e)
        {
            Carga();
        }

        string Ids(DataTable dtIds, ComboBox cbIds)
        {
            string ids = "";
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (cbIds.Text == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ObjProductos._update(txtNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, Ids(dtF, cbFactura), txtDescripcion.Text, txtCantidad.Text, Ids(dtS, cbEstatus), txtId.Text);
            DelegadoActualizar();
        }
    }
}

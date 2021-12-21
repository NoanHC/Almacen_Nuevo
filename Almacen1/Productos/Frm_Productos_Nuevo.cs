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
    public partial class Frm_Productos_Nuevo : Form
    {
        // Delegados
        public Action DelegadoActualizar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // datatable
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();


        public Frm_Productos_Nuevo()
        {
            InitializeComponent();
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
                default:
                    break;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        private void Frm_Productos_Nuevo_Load(object sender, EventArgs e)
        {
            Listas(dtM, cbMarca, 0);
            Listas(dtF, cbFactura, 1);
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

        void Nuevo()
        {
            ObjProductos._set(txtNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, Ids(dtF, cbFactura), txtDescripcion.Text, txtCantidad.Text);
            DelegadoActualizar();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}

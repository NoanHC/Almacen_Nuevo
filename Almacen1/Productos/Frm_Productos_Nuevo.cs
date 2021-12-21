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
        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // datatable
        DataTable dtP = new DataTable();
        DataTable dtF = new DataTable();


        public Frm_Productos_Nuevo()
        {
            InitializeComponent();
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
        void Marca()
        {
            cbMarca.Items.Clear();
            dtP.Clear();
            ObjProductos._consult_Marca(dtP);
            for (int i = 0; i < dtP.Rows.Count; i++)
            {
                cbMarca.Items.Add(dtP.Rows[i][1].ToString());
            }
        }
        private void Frm_Productos_Nuevo_Load(object sender, EventArgs e)
        {
            Marca();
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
            ObjProductos._set(txtNombre.Text, Ids(dtP, cbMarca), txtModelo.Text, txtParte.Text, Ids(dtP,cbMarca),);
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
        }
    }
}

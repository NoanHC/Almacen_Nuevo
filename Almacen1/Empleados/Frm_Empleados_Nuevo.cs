using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Empleados
{
    public partial class Frm_Empleados_Nuevo : Form
    {
        // Clases
        Class.Cls_Empleados ObjEmpleados = new Class.Cls_Empleados();
        // Datatables
        DataTable dt = new DataTable();
        DataTable dtE = new DataTable();
        DataTable dtP = new DataTable();

        public Frm_Empleados_Nuevo()
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

        void añadir()
        {
            ObjEmpleados._set(txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, Ids(dtP,cbPuesto), Ids(dtE,cbEstatus), txtMatricula.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            añadir();
        }

        void Status()
        {
            cbEstatus.Items.Clear();
            dtE.Clear();
            ObjEmpleados._consult_status(dtE);
            for (int i = 0; i < dtE.Rows.Count; i++)
            {
                cbEstatus.Items.Add(dtE.Rows[i][1].ToString());
            }
        }
        void Puesto ()
        {
            cbPuesto.Items.Clear();
            dtP.Clear();
            ObjEmpleados._consult_Puesto(dtP);
            for (int i = 0; i < dtP.Rows.Count; i++)
            {
                cbPuesto.Items.Add(dtP.Rows[i][1].ToString());
            }
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            Status();
            Puesto();
        }
    }
}

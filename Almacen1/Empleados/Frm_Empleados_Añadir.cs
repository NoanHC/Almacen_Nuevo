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
    public partial class Frm_Empleados_Añadir : Form
    {
        // Clases
        Class.Cls_Empleados ObjEmpleados = new Class.Cls_Empleados();
        // Datatables
        DataTable dt = new DataTable();

        public Frm_Empleados_Añadir()
        {
            InitializeComponent();
        }
        void añadir()
        {
            ObjEmpleados._set(txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtPuesto.Text, dt.Rows[cbEstatus.SelectedIndex][0].ToString(), txtMatricula.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            añadir();
        }

        void Status()
        {
            ObjEmpleados._consult_status(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbEstatus.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            Status();
        }
    }
}

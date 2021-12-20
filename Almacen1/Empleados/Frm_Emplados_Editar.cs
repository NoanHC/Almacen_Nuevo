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
    public partial class Frm_Emplados_Editar : Form
    {
        // Clases
        Class.Cls_Empleados ObjEmpleados = new Class.Cls_Empleados();

        // Datatable
        DataTable dt = new DataTable();
        DataTable dtE = new DataTable();
        DataTable dtP = new DataTable();

        // Variables
        int Id;
        public Frm_Emplados_Editar(int Id, DataTable dt)
        {
            InitializeComponent();
            this.Id = Id;
            this.dt = dt;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ObjEmpleados._update(txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, Ids(dtP,cbPuesto), Ids(dtE,cbEstatus), txtMatricula.Text, txtId.Text);
        }
        void Status()
        {
            cbEstatus.Items.Clear();
            ObjEmpleados._consult_status(dtE);
            for (int i = 0; i < dtE.Rows.Count; i++)
            {
                cbEstatus.Items.Add(dtE.Rows[i][1].ToString());
            }
        }
        void Puesto()
        {
            cbPuesto.Items.Clear();
            dtP.Clear();
            ObjEmpleados._consult_Puesto(dtP);
            for (int i = 0; i < dtP.Rows.Count; i++)
            {
                cbPuesto.Items.Add(dtP.Rows[i][1].ToString());
            }
        }
        void Datos()
        {
            txtId.Text = dt.Rows[Id][0].ToString();
            txtNombre.Text = dt.Rows[Id][1].ToString();
            txtTelefono.Text = dt.Rows[Id][2].ToString();
            txtCorreo.Text = dt.Rows[Id][3].ToString();
            txtDireccion.Text = dt.Rows[Id][4].ToString();
            cbPuesto.Text = dt.Rows[Id][5].ToString();
            Puesto();
            cbEstatus.Text = dt.Rows[Id][6].ToString();
            Status();
            txtMatricula.Text = dt.Rows[Id][7].ToString();
        }

        private void Frm_Emplados_Editar_Load(object sender, EventArgs e)
        {
            Datos();
        }
    }
}

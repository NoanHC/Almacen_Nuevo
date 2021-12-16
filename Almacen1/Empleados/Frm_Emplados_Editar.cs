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
        DataTable dtE= new DataTable();

        // Variables
        int Id;
        public Frm_Emplados_Editar(int Id, DataTable dt)
        {
            InitializeComponent();
            this.Id = Id;
            this.dt = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ObjEmpleados._update(txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtPuesto.Text, dtE.Rows[cbEstatus.SelectedIndex][0].ToString(), txtMatricula.Text, txtId.Text);
        }
        void Status()
        {
            ObjEmpleados._consult_status(dtE);
            for (int i = 0; i < dtE.Rows.Count; i++)
            {
                cbEstatus.Items.Add(dtE.Rows[i][1].ToString());
            }
        }
        void Datos()
        {
            txtId.Text = dt.Rows[Id][0].ToString();
            txtNombre.Text = dt.Rows[Id][1].ToString();
            txtTelefono.Text = dt.Rows[Id][2].ToString();
            txtCorreo.Text = dt.Rows[Id][3].ToString();
            txtDireccion.Text = dt.Rows[Id][4].ToString();
            txtPuesto.Text = dt.Rows[Id][5].ToString();
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

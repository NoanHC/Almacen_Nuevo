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
    public partial class Frm_Empleados : Form
    {
        //Formas
        Empleados.Frm_Emplados_Editar ObjEmpleadosEditar;
        Empleados.Frm_Empleados_Nuevo ObjEmpleadosAñadir = new Frm_Empleados_Nuevo();

        // Clases
        Class.Cls_Empleados ObjEmpleados = new Class.Cls_Empleados();
        

        // Datatable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public Frm_Empleados()
        {
            InitializeComponent();
        }
        void Carga()
        {
            ObjEmpleados._consult_Empleado(dt1);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            dataGridView1.DataSource = dt2;
            this.Invoke(new Action(() => dataGridView1.Columns["Editar"].DisplayIndex = dataGridView1.Columns.Count - 1));
            this.Invoke(new Action(() => dataGridView1.Columns["Borrar"].DisplayIndex = dataGridView1.Columns.Count - 1));
        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            Carga();
        }
        void Añadir ()
        {
            ObjEmpleadosAñadir.ShowDialog();
        }
        void EditarEmpleados(int Id)
        {
            ObjEmpleadosEditar = new Frm_Emplados_Editar(Id, dt1);
            ObjEmpleadosEditar.ShowDialog();
        }

        void Borrar_Empleado(int Fila)
        {
            if (MessageBox.Show("¿Desea borrar al empleado " + dt2.Rows[Fila][0].ToString() + "?", "Borrar empleado", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ObjEmpleados._delete(dt1.Rows[Fila][0].ToString());
            }
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditarEmpleados(e.RowIndex);
                }
                if (e.ColumnIndex == 1)
                {
                    Borrar_Empleado(e.RowIndex);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Añadir();
        }
    }
}

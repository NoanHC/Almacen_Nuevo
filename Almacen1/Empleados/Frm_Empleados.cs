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
        // Clases
        Class.Cls_Empleados ObjEmpleados = new Class.Cls_Empleados();

        // Datatable
        DataTable TablaAux2 = new DataTable();
        DataTable TablaAuxiiar = new DataTable();
        public Frm_Empleados()
        {
            InitializeComponent();
        }
        void Carga()
        {

        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            ObjEmpleados._consult_Empleado(TablaAuxiiar);
            TablaAux2 = TablaAuxiiar.Copy();
            TablaAux2.Columns.Remove("id");
            dataGridView1.DataSource = TablaAux2;
            this.Invoke(new Action(() => dataGridView1.Columns["Editar"].DisplayIndex = dataGridView1.Columns.Count - 1));
            this.Invoke(new Action(() => dataGridView1.Columns["Borrar"].DisplayIndex = dataGridView1.Columns.Count - 1));
        }
    }
}

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
    public partial class Frm_ListadoProductos : Form
    {
        // Formas
        Productos.Frm_Productos_Nuevo FormaProductos = new Productos.Frm_Productos_Nuevo();

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();


        // Datatable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public Frm_ListadoProductos()
        {
            InitializeComponent();
        }
        void Carga()
        {
            ObjProductos._consult_Productos(dt1);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        private void Frm_ListadoProductos_Load(object sender, EventArgs e)
        {
            Carga();
        }
        void Nuevo()
        {
            FormaProductos.DelegadoActualizar = Carga;
            FormaProductos.ShowDialog();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}

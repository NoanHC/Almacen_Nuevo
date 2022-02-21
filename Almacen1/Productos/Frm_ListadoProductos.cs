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
        Productos.Frm_Productos_Editar FormaProductosEditar;
        Productos.Frm_Productos_Nuevo FormaProductosNuevo = new Frm_Productos_Nuevo();
        Productos.Frm_Productos__Observar FormaObservar;
        Productos.Frm_Borrar_Producto FormaBorrar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();


        // Datatable
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtO1= new DataTable();

        public Frm_ListadoProductos()
        {
            InitializeComponent();
        }
        void Carga()
        {
           dt1.Clear();
            dt2.Clear();
            ObjProductos._consult_Productos(dt1);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
            DGV1.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Disponibilidad();
        }
        private void Frm_ListadoProductos_Load(object sender, EventArgs e)
        {
            Carga();
        }
        void Producto (DataTable dt)
        {
            dt2 = dt;
            dt1 = dt;
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        void Nuevo()
        {
            FormaProductosNuevo.Actualizar = Carga;
            FormaProductosNuevo.Producto = Producto;
            FormaProductosNuevo.ShowDialog();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void EditarEmpleados(int Id)
        {
            FormaProductosEditar = new Productos.Frm_Productos_Editar(Id, dt1);
            FormaProductosEditar.DelegadoActualizar = Carga;
            FormaProductosEditar.ShowDialog();
        }

        void Borrar_Producto(int Fila)
        {
            if (MessageBox.Show("¿Desea borrar el producto " + dt2.Rows[Fila][0].ToString() + "?", "Borrar producto", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ObjProductos._delete(dt1.Rows[Fila][0].ToString());
                string Nose = dt1.Rows[Fila][0].ToString();
            }
            Carga();
        }
        //void Disponibilidad ()
        //{
        //    for (int i = 0; i < DGV1.Rows.Count; i++)
        //    {
        //        switch (DGV1[11, i].Value.ToString())
        //        {
        //            case "Disponible":
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.Green));
        //                break;
        //            case "En espera":
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.DarkOrange));
        //                break;
        //            default:
        //                this.Invoke(new Action(() => DGV1[11, i].Style.ForeColor = Color.Red));
        //                break;
        //        }
        //    }
        //}
        private void Frm_ListadoProductos_SizeChanged(object sender, EventArgs e)
        {
            //Disponibilidad(); 
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex > 1)
                {
                    dtO1.Clear();
                    ObjProductos._consult_Productos_Series_MACs(dtO1, dt1.Rows[e.RowIndex][0].ToString());
                    if (dtO1.Rows.Count != 0)
                    {
                        FormaObservar = new Frm_Productos__Observar(dtO1);
                        FormaObservar.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Este producto no cuenta con serie o MAC");
                    }
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        EditarEmpleados(e.RowIndex);
                    }
                    if (e.ColumnIndex == 1)
                    {
                        FormaBorrar = new Frm_Borrar_Producto(dt1.Rows[e.RowIndex][0].ToString(), dt1.Rows[e.RowIndex][1].ToString());
                        FormaBorrar.ShowDialog();
                        Carga();
                    }
                }
            }
        }
        void Buscar()
        {
            dt1.Clear();
            dt2.Clear();
            ObjProductos._consult_Buscar(dt1, txtBuscar.Text);
            dt2 = dt1.Copy();
            dt2.Columns.Remove("id");
            DGV1.DataSource = dt2;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                Carga();
            }
            else
            {
                Buscar();
            }
        }
    }
}
